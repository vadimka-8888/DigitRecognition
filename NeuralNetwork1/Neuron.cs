using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork1
{
    public class Neuron
    {
        public double[] weights;
        private Neuron[] prevLayer;
        public double bias;
        public double error = 0;
        public double output = 0;

        public static Random r = new Random();
        private static double Sigmoid(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }
        private static double Tangens(double x)
        {
            return 2 * Sigmoid(2 * x) - 1;
        }
        private static double RELU(double x)
        {
            return Math.Max(0, x);
        }

        private static double SigmoidDerivate(double x)
        {
            return (x * (1 - x));
        }
        private static double TangensDerivate(double x)
        {
            return 1 / (Math.Cos(x) * Math.Cos(x));
        }

        private static double RELUDerivate(double x)
        {
            if (x > 0)
                return 1;
            else return 0;

        }
        //public Func<double, double> sigmFunc = (double x) => 1 / (1 + Math.Exp(-x));
        //public Func<double, double> derivativeSigmFunc = (double x) => x * (1 - x);
        public Func<double, double> sigmFunc = (double x) => Sigmoid(x);
        public Func<double, double> derivativeSigmFunc = (double x) => SigmoidDerivate(x);
        public Neuron(Neuron[] previous)
        {
            prevLayer = previous;
            weights = new double[prevLayer.Length];
            for (int i = 0; i < prevLayer.Length; i++)
                weights[i] = r.NextDouble() - 0.5;
            bias = r.NextDouble() - 0.5;
        }

        public Neuron()
        {
            bias = r.NextDouble() - 0.5;
        }

        public void activationFunc()
        {
            double sum = 0;
            for (int i = 0; i < prevLayer.Length; i++)
            {
                sum += prevLayer[i].output * weights[i];
            }
            output = sigmFunc(bias + sum);
        }

        public void setError(double learningRate)
        {
            error *= derivativeSigmFunc(output);
            bias -= learningRate * bias * error;
        }

        public void Backward(double learningRate)
        {
            setError(learningRate);

            for (int i = 0; i < prevLayer.Length; i++)
                prevLayer[i].error += error * weights[i];

            errorToWeights(learningRate, 0, prevLayer.Length);
            error = 0;
        }

        public void BackwardParallel(double learningRate, int from, int to)
        {
            for (int i = from; i < to; i++)
                prevLayer[i].error += error * weights[i];
            errorToWeights(learningRate, from, to);
        }

        private void errorToWeights(double learningRate, int from, int to)
        {
            for (int i = from; i < to; i++)
                weights[i] -= learningRate * prevLayer[i].output * error;
        }
    }
}
