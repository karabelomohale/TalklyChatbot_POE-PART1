using System;
using System.Drawing;
using System.IO;

namespace talklyapp
{//start of namespace
    public class AsciiLogo
    {//start of class
        public static void DisplayLogo()
        {//start of method
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logo.png");

                if (!File.Exists(path))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[DEBUG] File not found: {path}");
                    PrintFallback();
                    return;
                }

                Bitmap image = new Bitmap(path);

                // Maintain aspect ratio
                int width = 40;
                int height = (int)(image.Height / (double)image.Width * width * 1.5);

                Bitmap resized = new Bitmap(image, new Size(width, height));

                // Better ASCII gradient 
                string asciiChars = "@%#*+=-:. ";

                Console.ForegroundColor = ConsoleColor.Green;

                for (int y = 0; y < resized.Height; y++)
                {
                    for (int x = 0; x < resized.Width; x++)
                    {
                        Color pixel = resized.GetPixel(x, y);

                        // Convert to grayscale
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;

                        int index = (gray * (asciiChars.Length - 1)) / 255;

                        Console.Write(asciiChars[index]);
                        Console.Write(asciiChars[index]); // stretch width
                    }
                    Console.WriteLine();
                }

                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ERROR: {ex.Message}]");
                PrintFallback();
            }
        }

        private static void PrintFallback()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
        TALKLY 
  CYBERSECURITY BOT 
");
            Console.ResetColor();
        } //end of main
    } //end of class
} //end of namespace