using System;
using System.Drawing;
using System.IO;

namespace Part1__Cybersecurity__Awareness__bot
{//start of namespace
    internal class ascii_logo
    {//start of class
        public ascii_logo()
        {
            displayLogo();
        }
        private void displayLogo() {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo1.jpeg");

            if (File.Exists(path))
            {

                Bitmap image = new Bitmap(path);

                int width = 100;
                int height = 40;
                Bitmap resized = new Bitmap(image, new Size(width, height));

                string asciiChars = " .:-=+*#%@";
                Console.ForegroundColor = ConsoleColor.Green;

                for (int y = 0; y < resized.Height; y++)
                {
                    for (int x = 0; x < resized.Width; x++)
                    {
                        Color pixel = resized.GetPixel(x, y);
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;
                        int index = (gray * (asciiChars.Length - 1)) / 255;
                        Console.Write(asciiChars[index]);
                    }
                    Console.WriteLine();

                }

                Console.ResetColor();
            }
        }
    }//emd of class
}//end of namespave