using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Horker.PSOxyPlot
{
    public static class WpfVisualRenderer
    {
        public static void SaveToFile(Visual content, string path, double dpiX = 96.0, double dpiY = 96.0)
        {
            var bitmapSource = CaptureScreen(content, dpiX, dpiY);

            var encoder = new PngBitmapEncoder();

            SaveBitmapSource(bitmapSource, encoder, path);
        }

        // ref.
        // https://blogs.msdn.microsoft.com/jaimer/2009/07/03/rendertargetbitmap-tips/

        private static BitmapSource CaptureScreen(Visual target, double dpiX, double dpiY)
        {
            Rect bounds = VisualTreeHelper.GetDescendantBounds(target);

            RenderTargetBitmap rtb = new RenderTargetBitmap(
                (int)(bounds.Width * dpiX / 96.0),
                (int)(bounds.Height * dpiY / 96.0),
                dpiX,
                dpiY,
                PixelFormats.Pbgra32);

            DrawingVisual dv = new DrawingVisual();
            using (DrawingContext ctx = dv.RenderOpen())
            {
                VisualBrush vb = new VisualBrush(target);
                ctx.DrawRectangle(vb, null, new Rect(new System.Windows.Point(), bounds.Size));
            }

            rtb.Render(dv);

            return rtb;
        }

        // ref.
        // https://stackoverflow.com/questions/2900447/how-to-save-a-wpf-image-to-a-file

        private static void SaveBitmapSource(BitmapSource bitmapSource, BitmapEncoder encoder, string path)
        {
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                encoder.Frames.Add(BitmapFrame.Create(bitmapSource));
                encoder.Save(fileStream);
            }
        }
    }
}
