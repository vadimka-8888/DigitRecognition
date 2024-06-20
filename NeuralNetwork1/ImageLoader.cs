using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork1
{
    public enum DigitType : byte { Zero = 0, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Undef };
    class ImageLoader
    {
        public static int imgSize = 50;
        public bool[] img = new bool[imgSize * imgSize];
        private Random rand = new Random();

        public DigitType currentDigit = DigitType.Undef;

        public int DigitCount { get; set; } = 10;

        // Создание обучающей выборки
        public SamplesSet samples = new SamplesSet();
        // Создание тестовой выборки
        public SamplesSet samplesTest = new SamplesSet();

        private Controller controller = null;

        public ImageLoader(Controller cont)
        {
            controller = cont;
        }

        public SamplesSet GetSampleSet()
        {
            return samples;
        }

        public SamplesSet GetSampleSetTest()
        {
            return samplesTest;
        }
        
        // Файл с векторами признаков
        public void LoadDataset()
        {
            string nameFile = "";
            int size = 0;
            nameFile = "MethodAlternation.txt";
            size = imgSize * 2;
            SamplesSet MethodSamples = new SamplesSet();
            SamplesSet MethodSamplesTest = new SamplesSet();
            // получение директории,  где хранится файл с векторами признаков
            string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName + "\\data\\";
            string pathFile = path + nameFile;
            int c = 1;
            using (StreamReader sr = File.OpenText(pathFile))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    List<string> splitSep = s.Split(';').ToList();
                    // загружаем из файла все классы, пока не достигли выбранного
                    if (Int32.Parse(splitSep[0]) == DigitCount)
                    {
                        break;
                    }
                    List<string> splitSpace = splitSep[1].Split(' ').ToList();

                    double[] input = new double[size];
                    for (int k = 0; k < size; k++)
                        input[k] = 0;

                    for (int i = 0; i < splitSpace.Count(); i++)
                    {
                        input[i] = double.Parse(splitSpace[i]);
                    }
                    currentDigit = (DigitType)Int32.Parse(splitSep[0]);
                    if (MethodSamples.samples.Count() < 15 * c)
                        MethodSamples.AddSample(new Sample(input, DigitCount, currentDigit)); // берем по 15 векторов для обучения
                    else
                    {
                        MethodSamplesTest.AddSample(new Sample(input, DigitCount, currentDigit)); // берем по 5 векторов для обучения
                        if (MethodSamplesTest.samples.Count() > 5 * c) c += 1;
                    }
                }
            }

            samples = MethodSamples;
            samplesTest = MethodSamplesTest;
        }

        // Функция загрузки случайного изображения для тестирования в зависимости от метода(при нажатии на экран)
        public Sample LoadImage(bool isInput = false)
        {
            //очистка изображения
            for (int i = 0; i < imgSize; ++i)
                for (int j = 0; j < imgSize; ++j)
                    img[i * imgSize + j] = false;

            Bitmap bmp = !isInput ? GetRandomImage() : GetInputImage();
            // получение изображения
            for (int x = 0; x < imgSize; x++)
            {
                for (int y = 0; y < imgSize; y++)
                {
                    Color newColor = bmp.GetPixel(x, y);
                    if (newColor.R < 50 || newColor.G < 50 || newColor.B < 50)
                    {
                        img[x * imgSize + y] = true;
                    }
                }
            }

       
            return SensorsAlternative();
             
            
        }

        // Функция получения случайного изображения
        private Bitmap GetRandomImage()
        {
            // путь к данным
            string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName + "\\data";
            // получение всех директорий
            List<string> directories = Directory.GetDirectories(path).ToList();

            // случайная директория
            int randomDirectory = rand.Next(0, DigitCount);
            // получение всех файлов
            List<string> files = Directory.GetFiles(directories[randomDirectory]).ToList();

            // случайная директория
            int randomFile = rand.Next(0, files.Count());

            currentDigit = (DigitType)randomDirectory;
            using (Bitmap bmp = new Bitmap(Image.FromFile(files[randomFile])))
            {
                controller.processor.ProcessImage(bmp, true);
                return controller.processor.processed2;
            }
        }
        private Sample SensorsAlternative()
        {
            double[] inputAlt = new double[imgSize*2];
            for (int k = 0; k < imgSize*2; k++)
                inputAlt[k] = 0;


            // вектор признаков
            for (int x = 0; x < imgSize; x++)
                for (int y = 0; y < imgSize; y++)
                    if (x - 1 > 0 && img[x * imgSize + y] != img[(x - 1) * imgSize + y])
                    {
                        inputAlt[x] += 1;
                    }

            for (int x = 0; x < imgSize; x++)
                for (int y = 0; y < imgSize; y++)
                    if (y - 1 > 0 && img[x * imgSize + y] != img[x * imgSize + y - 1])
                    {
                        inputAlt[imgSize + y] += 1;
                    }

            // создание выборки с методом чередования пикселей
            return new Sample(inputAlt, DigitCount, currentDigit);
        }

        // Фиксирование изображения
        private Bitmap GetInputImage()
        {
            // путь к фото
            string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName + "\\data\\input.jpg";

            currentDigit = DigitType.Undef;

            // загрузка изображения
            Bitmap bmp = new Bitmap(Image.FromFile(path));
            if (bmp.Width > imgSize)
            {
                controller.processor.ProcessImage(bmp, true);

                return controller.processor.processed;
            }
            else
            {
                return bmp;
            }
        }

        // Отрисовка картинки на PictureBox
        public Bitmap GenImage()
        {
            Bitmap drawArea = new Bitmap(imgSize, imgSize);
            for (int i = 0; i < imgSize; ++i)
                for (int j = 0; j < imgSize; ++j)
                    if (!img[i * imgSize + j]) drawArea.SetPixel(i, j, Color.Black);
            return drawArea;
        }
    }
}