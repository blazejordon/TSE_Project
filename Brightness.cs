using System.Drawing.Imaging;

namespace TSE
{
    public class Brightness
    {
        private static Bitmap ScreenShot()
        {
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppRgb);

            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,Screen.PrimaryScreen.Bounds.Y,0,0,Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

            bmpScreenshot.Save("Screenshot.png", ImageFormat.Png);

            return bmpScreenshot;
        }

        private static double CalculateAverageLightness(Bitmap bm)
        {
            double lum = 0;
            var tmpBmp = new Bitmap(bm);
            var width = bm.Width;
            var height = bm.Height;
            var bppModifier = bm.PixelFormat == PixelFormat.Format24bppRgb ? 3 : 4;

            var srcData = tmpBmp.LockBits(new Rectangle(0, 0, bm.Width, bm.Height), ImageLockMode.ReadOnly, bm.PixelFormat);
            var stride = srcData.Stride;
            var scan = srcData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)scan;

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        int idx = (i * stride) + j * bppModifier;
                        lum += (0.299 * p[idx + 2] + 0.587 * p[idx + 1] + 0.114 * p[idx]);
                    }
                }
            }

            tmpBmp.UnlockBits(srcData);
            tmpBmp.Dispose();
            var avgLum = lum / (width * height);

            return (avgLum / 255.0) * 5;
            Console.WriteLine(avgLum);
        }

        public static void BrightnessRun()
        {
            Console.WriteLine(CalculateAverageLightness(ScreenShot()));
        }
    }
}