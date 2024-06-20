using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NeuralNetwork1.StudentNetwork;

namespace NeuralNetwork1
{

    public class Layer
    {
        public static int threads = Environment.ProcessorCount;
        public double learningRate;
        public Neuron[] neurons;
        private Layer prevLayer;

        public Layer(double _learningRate, int length)
        {
            prevLayer = null;
            learningRate = _learningRate;
            neurons = new Neuron[length];
            for (int j = 0; j < length; j++)
                neurons[j] = new Neuron();
        }

        public Layer(double rate, int length, Layer prev)
        {
            prevLayer = prev;
            learningRate = rate;
            neurons = new Neuron[length];
            for (int j = 0; j < length; j++)
            {
                neurons[j] = new Neuron(prev.neurons);
            }
        }

        public void Compute()
        {
            foreach (Neuron n in neurons)
            {
                n.activationFunc();
            }
        }

        
        public void Backward(bool parallel)
        {
            if (parallel)
            {
                int perThread = prevLayer.neurons.Count() / threads;
                foreach (var n in prevLayer.neurons) n.error = 0;
                for (int j = 0; j < neurons.Length; j++)
                {
                    neurons[j].setError(learningRate);
                }
                Parallel.For(0, threads, i =>
                {
                    for (int j = 0; j < neurons.Length; j++)
                        neurons[j].BackwardParallel(learningRate, perThread * i, i == threads ? prevLayer.neurons.Count() : perThread * (i + 1));
                });
            }
            else
            {
                for (int j = 0; j < neurons.Length; j++)
                    neurons[j].Backward(learningRate);
            }
        }
    }
}
