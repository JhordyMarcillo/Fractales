using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace C__Proyecto_Final
{
    public class Fractal1
    {
        public int MaxIterations { get; set; }
        public double Scale { get; set; }
        public Color FractalColor { get; set; }
        public Color BackgroundColor { get; set; }

        public Fractal1(int maxIterations, double scale, Color fractalColor, Color backgroundColor)
        {
            MaxIterations = maxIterations;
            Scale = scale;
            FractalColor = fractalColor;
            BackgroundColor = backgroundColor;
        }

        public Bitmap GenerateFractal(int width, int height, double zoom)
        {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            double scaleZoom = Scale / zoom;
            double halfWidth = width / 2.0;
            double halfHeight = height / 2.0;
            double inverseWidth = 1.0 / width;
            double inverseHeight = 1.0 / height;

            BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, bitmap.PixelFormat);
            int bytesPerPixel = Image.GetPixelFormatSize(bitmap.PixelFormat) / 8;
            int byteCount = bmpData.Stride * height;

            byte[] pixelBuffer = new byte[byteCount];

            //recorre cada pixel de la imagen 
            Parallel.For(0, height, y =>
            {
                int rowOffset = y * bmpData.Stride;

                //cy, cx oordenadas normalizadas en el plano complejo
                double cy = (y - halfHeight) * scaleZoom * inverseHeight;

                for (int x = 0; x < width; x++)
                {
                    double cx = (x - halfWidth) * scaleZoom * inverseWidth;
                    double zx = 0, zy = 0; //Variables que representan el número complejo
                    int iteration = 0;

                    while (zx * zx + zy * zy < 8.0 && iteration < MaxIterations) //iteracion de la funcion compleja   
                    {
                        double zx2 = zx * zx - zy * zy + cx;
                        zy = 2.0 * zx * zy + cy;
                        zx = zx2;
                        iteration++;
                    }

                    int offset = rowOffset + x * bytesPerPixel;

                    //coloraciones
                    if (iteration < MaxIterations)
                    {
                        pixelBuffer[offset] = FractalColor.B;     // B
                        pixelBuffer[offset + 1] = FractalColor.G; // G
                        pixelBuffer[offset + 2] = FractalColor.R; // R
                        pixelBuffer[offset + 3] = FractalColor.A; // A
                    }
                    else
                    {
                        pixelBuffer[offset] = BackgroundColor.B;     // B
                        pixelBuffer[offset + 1] = BackgroundColor.G; // G
                        pixelBuffer[offset + 2] = BackgroundColor.R; // R
                        pixelBuffer[offset + 3] = BackgroundColor.A; // A
                    }
                }
            });

            //Se copian los datos al Bitmap. y se devuelve la imagen generada
            System.Runtime.InteropServices.Marshal.Copy(pixelBuffer, 0, bmpData.Scan0, byteCount);
            bitmap.UnlockBits(bmpData);

            return bitmap;
        }
    }
}