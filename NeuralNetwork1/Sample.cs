﻿using System;
using System.Collections.Generic;
using System.Collections;

namespace NeuralNetwork1
{
    /// <summary>
    /// Класс для хранения образа – входной массив сигналов на сенсорах, выходные сигналы сети, и прочее
    /// </summary>
    public class Sample
    {
        /// <summary>
        /// Входной вектор
        /// </summary>
        public double[] input = null;

        /// <summary>
        /// Вектор ошибки, вычисляется по какой-нибудь хитрой формуле
        /// </summary>
        public double[] error = null;

        /// <summary>
        /// Действительный класс образа. Указывается учителем
        /// </summary>
        public DigitType actualClass;

        /// <summary>
        /// Распознанный класс - определяется после обработки
        /// </summary>
        public DigitType recognizedClass;

        // Вектор целевых выходных значений
        public double[] targetValues;

        /// <summary>
        /// Конструктор образа - на основе входных данных для сенсоров, при этом можно указать класс образа, или не указывать
        /// </summary>
        /// <param name="inputValues"></param>
        /// <param name="sampleClass"></param>
        public Sample(double[] inputValues, int classesCount, DigitType sampleClass = DigitType.Undef)
        {
            //  Клонируем массивчик
            input = (double[])inputValues.Clone();
            Output = new double[classesCount];
            if (sampleClass != DigitType.Undef) Output[(int)sampleClass] = 1;



            recognizedClass = DigitType.Undef;
            actualClass = sampleClass;

            targetValues = new double[classesCount];
            for (int i = 0; i < classesCount; i++)
            {
                targetValues[i] = i == (int)actualClass ? 1 : 0;
            }
        }

        /// <summary>
        /// Выходной вектор, задаётся извне как результат распознавания
        /// </summary>
        public double[] Output { get; private set; }

        /// <summary>
        /// Обработка реакции сети на данный образ на основе вектора выходов сети
        /// </summary>
        public DigitType ProcessPrediction(double[] neuralOutput)
        {
            Output = neuralOutput;
            if (error == null)
                error = new double[Output.Length];

            //  Нам так-то выход не нужен, нужна ошибка и определённый класс
            recognizedClass = 0;
            for (int i = 0; i < Output.Length; ++i)
            {
                int actClass = (int)actualClass;
                if (i == actClass)
                    error[i] = Output[i] - 1;
                else 
                    error[i] = Output[i];
                //error[i] = (Output[i] - (i == (int)actualClass ? 1 : 0));
                if (Output[i] > Output[(int)recognizedClass]) 
                    recognizedClass = (DigitType)i;
            }

            return recognizedClass;
        }

        /// <summary>
        /// Вычисленная суммарная квадратичная ошибка сети. Предполагается, что целевые выходы - 1 для верного, и 0 для остальных
        /// </summary>
        /// <returns></returns>
        public double EstimatedError()
        {
            double Result = 0;
            for (int i = 0; i < Output.Length; ++i)
                Result += Math.Pow(error[i], 2);
            return Result;
        }

        /// <summary>
        /// Добавляет к аргументу ошибку, соответствующую данному образу (не квадратичную!!!)
        /// </summary>
        /// <param name="errorVector"></param>
        /// <returns></returns>
        public void updateErrorVector(double[] errorVector)
        {
            for (int i = 0; i < errorVector.Length; ++i)
                errorVector[i] += error[i];
        }
     

        /// <summary>
        /// Правильно ли распознан образ
        /// </summary>
        /// <returns></returns>
        public bool Correct()
        {
            return actualClass == recognizedClass;
        }
    }

    /// <summary>
    /// Выборка образов. Могут быть как классифицированные (обучающая, тестовая выборки), так и не классифицированные (обработка)
    /// </summary>
    public class SamplesSet : IEnumerable
    {
        /// <summary>
        /// Накопленные обучающие образы
        /// </summary>
        public List<Sample> samples = new List<Sample>();

        /// <summary>
        /// Добавление образа к коллекции
        /// </summary>
        /// <param name="image"></param>
        public void AddSample(Sample image)
        {
            samples.Add(image);
        }

        public int Count => samples.Count;

        public IEnumerator GetEnumerator()
        {
            return samples.GetEnumerator();
        }

        /// <summary>
        /// Реализация доступа по индексу
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Sample this[int i]
        {
            get => samples[i];
            set => samples[i] = value;
        }

        public double TestNeuralNetwork(BaseNetwork network)
        {
            double correct = 0;
            double wrong = 0;
            foreach (var sample in samples)
            {
                if (sample.actualClass == network.Predict(sample)) ++correct;
                else ++wrong;
            }
            return correct / (correct + wrong);
        }

        // Тут бы ещё сохранение в файл и чтение сделать, вообще классно было бы
    }
}