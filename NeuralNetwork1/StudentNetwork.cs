using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NeuralNetwork1
{
    public class StudentNetwork : BaseNetwork
    {
        private Layer[] layers;
        private double error = 0;
        //  Секундомер спортивный, завода «Агат», измеряет время пробегания стометровки, ну и время затраченное на обучение тоже умеет
        public Stopwatch stopWatch = new Stopwatch();
        private double learning_rate = 0.1;

        public StudentNetwork(int[] structure)
        {
            layers = new Layer[structure.Length];
            layers[0] = new Layer(learning_rate, structure[0]);
            for (int i = 1; i < layers.Count(); i++)
            {
                layers[i] = new Layer(learning_rate, structure[i], layers[i - 1]);
            }
        }

        public override int Train(Sample sample, double acceptableError, bool parallel)
        {
            int epoch = 0;
            do
            {
                sample.ProcessPrediction(Compute(sample.input));
                //sample.Correct() 
                if (sample.EstimatedError() < 0.02)
                {
                    error += sample.EstimatedError();
                    break;
                }
                Backward(sample, parallel);
                epoch++;
            } while (epoch < 100);

            return epoch;
        }

        public override double TrainOnDataSet(SamplesSet samplesSet, int epochsCount, double acceptableError, bool parallel)
        {
            stopWatch.Start();
            double prev_error = error;
            double sumError = 0;
            for (int epoch = 0; epoch < epochsCount; epoch++)
            {
                error = 0;
                foreach (var sample in samplesSet.samples)
                {
                    sumError += Train(sample, acceptableError, parallel);
                }
                error = sumError / ((epoch + 1) * samplesSet.Count + 1);
                OnTrainProgress((epoch * 1.0) / epochsCount, error, stopWatch.Elapsed);
                //error <= acceptableError
                if (Math.Abs(prev_error - error) < 1e-8)
                {
                    break;
                }
                prev_error = error;
            }

            stopWatch.Stop();
            OnTrainProgress(1, error, stopWatch.Elapsed);

            return error;
        }

        private void Backward(Sample sample, bool parallel = true)
        {
            for (int i = 0; i < layers[layers.Length - 1].neurons.Count(); i++)
            {
                layers[layers.Count() - 1].neurons[i].error = sample.error[i];
            }
            for (int i = layers.Count() - 1; i > 0; i--)
            {
                layers[i].Backward(parallel);
            }
        }

        public override double[] Compute(double[] input)
        {
            for (int i = 0; i < layers.Count(); i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        layers[0].neurons[j].output = input[j];
                    }
                    continue;
                }
                layers[i].Compute();
            }
            return layers.Last().neurons.Select(x => x.output).ToArray();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }

        

        
    }
}