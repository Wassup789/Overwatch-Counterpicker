using Gma.System.MouseKeyHook;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Overwatch_Team_Overview
{

    static class Program
    {
        public static IKeyboardMouseEvents m_GlobalHook;
        public static MainForm mainForm;
        public static bool debug = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyPress += GlobalHookKeyPress;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainForm = new MainForm();

            Application.Run(mainForm);
        }

        private static void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            // User has pressed the G key
            if (e.KeyChar == mainForm.settings.key.ToCharArray()[0]) {
                TakeScreenshot();
            }
            if (e.KeyChar == ']' && debug)
                TakeScreenshotAsset();
        }

        private static readonly int testingSizeX = 60;
        private static readonly int testingSizeY = 40;

        private static readonly int[][] positions = new int[][]
        {
            new int[] {415, 290},// X travels +206
            new int[] {621, 290},// Bottom Y is 595
            new int[] {827, 290},
            new int[] {1033, 290},
            new int[] {1239, 290},
            new int[] {1445, 290}
        };
        public static readonly string[] heroes = new string[]
        {
            "genji",
            "mccree",
            "pharah",
            "reaper",
            "soldier76",
            "tracer",
            "bastion",
            "hanzo",
            "junkrat",
            "mei",
            "torbjorn",
            "widowmaker",
            "dva",
            "reinhardt",
            "roadhog",
            "winston",
            "zarya",
            "lucio",
            "mercy",
            "symmetra",
            "zenyatta"
        };

        public static int[] currentHeroes = new int[6];
        public static Boolean hasRefreshedOnce = false;

        public static void CompareImages(Bitmap screenshot)
        {
            //Positions, Heroes, {Percentage Correct, Accuracy by +-10} (Probably not a good idea using Jagged Arrays TODO)
            double[][][] percentages = new double[positions.Length][][];
            for (int i = 0; i < positions.Length; i++)
            {
                Bitmap cropped = screenshot.Clone(new Rectangle(positions[i][0], positions[i][1], testingSizeX, testingSizeY), screenshot.PixelFormat);
                for (int j = 0; j < heroes.Length; j++)
                {
                    if(j == 0)
                        percentages[i] = new double[heroes.Length][];

                    Bitmap source = new Bitmap("assets/" + heroes[j] + ".png");
                    Bitmap source_dead = new Bitmap("assets/" + heroes[j] + "_dead.png");
                    List<Color> colorsTest = GetBitmapColors(cropped);
                    List<Color> colorsSource = GetBitmapColors(source);
                    List<Color> colorsSourceDead = GetBitmapColors(source_dead);

                    double[][] results = 
                    {
                        CompareColors(colorsSource, colorsTest),
                        CompareColors(colorsSourceDead, colorsTest)
                    };
                    percentages[i][j] = results[GetBestValue(results)];
                    if (i == 1)
                    {
                        Console.WriteLine(heroes[j] + percentages[i][j][0]);
                        Console.WriteLine(heroes[j] + percentages[i][j][1]);
                    }
                }
            }
            for (int i = 0; i < positions.Length; i++)
            {
                int index = GetBestValue(percentages[i]);
                Console.WriteLine("Enemy #{0} is: {1}, their percentage value is: {2}% and accuracy is: {3}%", i, heroes[index], (100-percentages[i][index][0]), (100-percentages[i][index][1]));
                currentHeroes[i] = index;
            }
            hasRefreshedOnce = true;
            mainForm.onHeroesChange();
        }

        //Index, value
        public static int GetBestValue(double[][] array)
        {
            double[] bestArr = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i][1] > bestArr[1])
                {
                    bestArr = array[i];
                    index = i;
                }
            }
            return index;
        }

        public static List<Color> GetBitmapColors(Bitmap image)
        {
            List<Color> output = new List<Color>();
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    // Get pixel color 
                    Color c = image.GetPixel(x, y);
                    output.Add(c);
                }
            }
            return output;
        }

        public static double[] CompareColors(List<Color> image1, List<Color> image2)
        {
            double changeInR = 0;
            double changeInG = 0;
            double changeInB = 0;
            double accuracy = 0;
            for (int i = 0; i < image1.Count; i++)
            {
                changeInR += (image1[i].R - image2[i].R);
                changeInG += (image1[i].G - image2[i].G);
                changeInB += (image1[i].R - image2[i].B);

                if ((image1[i].R - image2[i].R < 10 && image1[i].R - image2[i].R > -10) &&
                    (image1[i].G - image2[i].G < 10 && image1[i].G - image2[i].G > -10) &&
                    (image1[i].B - image2[i].B < 10 && image1[i].B - image2[i].B > -10))
                    accuracy++;
            }
            changeInR = Math.Abs(changeInR/image1.Count)/255.0*100.0;
            changeInG = Math.Abs(changeInG/image1.Count)/255.0*100.0;
            changeInB = Math.Abs(changeInB/image1.Count)/255.0*100.0;

            return new double[] {(changeInR + changeInG + changeInB)/3.0, (accuracy/image1.Count*100.0)};
        }

        public static void TakeScreenshot()
        {
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                           Screen.PrimaryScreen.Bounds.Height,
                                           PixelFormat.Format32bppArgb);
            
            var graphicsScreenshot = Graphics.FromImage(bmpScreenshot);
            graphicsScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

            // ALPHA, not sure if this will work officially
            if (Screen.PrimaryScreen.Bounds.Width != 1920 || Screen.PrimaryScreen.Bounds.Height != 1080)
                bmpScreenshot = ResizeImage(bmpScreenshot, new Size(1920, 1080));
            
            CompareImages(bmpScreenshot);
        }

        public static void TakeScreenshotAsset()
        {
            var bmpScreenshot = new Bitmap(testingSizeX,
                                           testingSizeY,
                                           PixelFormat.Format32bppArgb);

            var graphicsScreenshot = Graphics.FromImage(bmpScreenshot);
            graphicsScreenshot.CopyFromScreen(415, 595, 0, 0, new Size(testingSizeX, testingSizeY), CopyPixelOperation.SourceCopy);

            bmpScreenshot.Save("asset_" + (int) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds + ".png", ImageFormat.Png);
        }

        public static Bitmap ResizeImage(Bitmap imgToResize, Size size)
        {
            try
            {
                Bitmap b = new Bitmap(size.Width, size.Height);
                using (Graphics g = Graphics.FromImage((Image)b))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(imgToResize, 0, 0, size.Width, size.Height);
                }
                return b;
            }
            catch
            {
                Console.WriteLine("Bitmap could not be resized");
                return imgToResize;
            }
        }

        public static string GetHeroName(int index)
        {
            string heroName = Program.heroes[index].ToCharArray()[0].ToString().ToUpper() +
                              Program.heroes[index].Substring(1);
            if (heroName == "Soldier76")
                heroName = "Soldier: 76";
            if (heroName == "Dva")
                heroName = "D.Va";
            return heroName;
        }
    }
}
