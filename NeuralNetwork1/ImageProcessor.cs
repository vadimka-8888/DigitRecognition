using AForge.Imaging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork1
{
    public class Settings1
    {

        public byte threshold = 120;
        public int border = 100;
        public int top = 100;
        public int left = 100;
        public float differenceLim = 0.15f;

        public Settings1(byte treshold, float differenceLim)
        {
            this.threshold = treshold;
            this.differenceLim = differenceLim;
        }

    }

    public class ImagePreproccessor
    {
        private Settings1 settings;
        public ImagePreproccessor(Settings1 settings)
        {
            this.settings = settings;
        }


        private UnmanagedImage GetGreyScaledImage(UnmanagedImage image)
        {
            AForge.Imaging.Filters.Grayscale grayFilter = new AForge.Imaging.Filters.Grayscale(0.2125, 0.7154, 0.0721);
            return grayFilter.Apply(image);
        }

        private UnmanagedImage GetFilteredImage(UnmanagedImage image)
        {
            AForge.Imaging.Filters.BradleyLocalThresholding threshldFilter = new AForge.Imaging.Filters.BradleyLocalThresholding();
            threshldFilter.PixelBrightnessDifferenceLimit = settings.differenceLim;
            return threshldFilter.Apply(image);
        }

        private double[] ConvertImageToArray(Bitmap processed)
        {
            double[] input = new double[processed.Width * processed.Height];
            int size = 28;
            for (int i = 0; i < processed.Height; i++)
            {
                for (int j = 0; j < processed.Width; j++)
                {
                    Color newColor = processed.GetPixel(i, j);
                    if (newColor.R > 0 || newColor.G > 0 || newColor.B > 0)
                    {
                        input[i * size + j] = 1;
                    }
                    else
                    {
                        input[i * size + j] = 0;
                    }
                }
            }
            return input;
        }

        public double[] ProcessImage(Bitmap original)
        {
            int side = original.Height;

            //  Отпиливаем границы, но не более половины изображения
            if (side < 2 * settings.border) settings.border = side / 2;
            side -= 2 * settings.border;


            var processedImage = UnmanagedImage.FromManagedImage(original);

            processedImage = GetGreyScaledImage(processedImage);
            //пороговое отсечение 
            processedImage = GetFilteredImage(processedImage);
            // наибольший блоб
            processedImage = GetMaxBlob(processedImage);
            processedImage = GetScaledImage(processedImage, 28, 28);
            var processed = processedImage.ToManagedImage();
            return ConvertImageToArray(processed);
        }


        public Bitmap GetProcessedImage(Bitmap original)
        {
            int side = original.Height;

            //  Отпиливаем границы, но не более половины изображения
            if (side < 4 * settings.border) settings.border = side / 4;
            side -= 2 * settings.border;
            Rectangle cropRect = new Rectangle((original.Width - original.Height) / 2 + settings.left + settings.border, settings.top + settings.border, side, side);


            var processedImage = UnmanagedImage.FromManagedImage(original);

            processedImage = GetGreyScaledImage(processedImage);
            //пороговое отсечение 
            processedImage = GetFilteredImage(processedImage);
            // получаем самый большой блоб - нашу циферку, которую будем распознавать
            processedImage = GetMaxBlob(processedImage);
            processedImage = GetScaledImage(processedImage, 28, 28);
            var processed = processedImage.ToManagedImage();
            return processed;
        }


        private UnmanagedImage GetScaledImage(UnmanagedImage unmanaged, int w, int h)
        {
            AForge.Imaging.Filters.ResizeBilinear scaleFilter = new AForge.Imaging.Filters.ResizeBilinear(w, h);
            return scaleFilter.Apply(unmanaged);
        }

        private UnmanagedImage GetMaxBlob(UnmanagedImage unmanaged)
        {


            ///  Инвертируем изображение
            AForge.Imaging.Filters.Invert InvertFilter = new AForge.Imaging.Filters.Invert();
            InvertFilter.ApplyInPlace(unmanaged);

            ///    Создаём BlobCounter, выдёргиваем самый большой кусок, масштабируем, пересечение и сохраняем
            ///    изображение в эксклюзивном использовании
            AForge.Imaging.BlobCounterBase bc = new AForge.Imaging.BlobCounter();

            bc.FilterBlobs = true;
            bc.MinWidth = 3;
            bc.MinHeight = 3;
            // Упорядочиваем по размеру
            bc.ObjectsOrder = AForge.Imaging.ObjectsOrder.Size;
            // Обрабатываем картинку

            bc.ProcessImage(unmanaged);

            Rectangle[] rects = bc.GetObjectsRectangles();

            var maxRect = rects.FirstOrDefault();

            var beforeCutting = unmanaged.ToManagedImage();
            beforeCutting.Save(@"../../beforeBlobbing.png");
            // Обрезаем края, оставляя только центральные блобы
            AForge.Imaging.Filters.Crop cropFilter = new AForge.Imaging.Filters.Crop(new Rectangle(maxRect.X, maxRect.Y, maxRect.X + maxRect.Width, maxRect.Y + maxRect.Height));
            unmanaged = cropFilter.Apply(unmanaged);
            var afterCutting = unmanaged.ToManagedImage();
            afterCutting.Save(@"../../afterBlobbing.png");
            return unmanaged;
        }

    }
}