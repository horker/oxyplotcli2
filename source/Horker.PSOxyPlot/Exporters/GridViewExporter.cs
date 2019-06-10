using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot
{
    public static class GridViewExporter
    {
        public static string ExportToSvgString(GridView gridView, int width = 800, int height = 600, bool isDocument = true)
        {
            var s = new StringBuilder();
            s.AppendFormat("<svg width=\"{0}\" height=\"{1}\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" version=\"1.1\">", width, height);
            s.AppendLine();

            var adjusted = gridView.GetAdjustedWidthHeight();
            var widths = adjusted.Item1;
            var heights = adjusted.Item2;
            var totalWidth = widths.Sum();
            var totalHeight = heights.Sum();

            var modelCount = 0;
            var hp = 0.0;
            foreach (var h in heights)
            {
                var hr = h / totalHeight;
                var wp = 0.0;
                foreach (var w in widths)
                {
                    if (modelCount < gridView.Models.Count)
                    {
                        var wr = w / totalWidth;
                        var svg = ModelExporter.ExportToSvgString(gridView.Models[modelCount],  wr * width, hr * height, false);
                        var startIndex = svg.IndexOf("<svg ");
                        var endIndex = svg.IndexOf(">", startIndex + 5);
                        s.AppendFormat("<svg x=\"{0}%\" y=\"{1}%\" width=\"{2}%\" height=\"{3}%\">", wp * 100, hp * 100, wr * 100, hr * 100);
                        s.Append(svg.Substring(endIndex + 1));
                        s.AppendLine();

                        wp += wr;
                    }
                    ++modelCount;
                }

                hp += hr;
            }

            s.Append("</svg>");

            return s.ToString();
        }

        public static void ExportToSvg(GridView gridView, string path, int width = 800, int height = 600, bool isDocument = true)
        {
            var svgString = GridViewExporter.ExportToSvgString(gridView, width, height, isDocument);

            using (var f = new StreamWriter(path))
            {
                f.Write(svgString);
            }
        }

        public static void ExportToPng(GridView gridView, string path, int width = 800, int height = 600)
        {
            var adjusted = gridView.GetAdjustedWidthHeight();
            var widths = adjusted.Item1;
            var heights = adjusted.Item2;
            var totalWidth = widths.Sum();
            var totalHeight = heights.Sum();

            var file = Path.GetTempFileName();

            var canvas = new Bitmap(width, height);
            using (var g = Graphics.FromImage(canvas))
            {
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, width, height));

                var modelCount = 0;
                var hp = 0.0;
                foreach (var h in heights)
                {
                    var hr = h / totalHeight;
                    var wp = 0.0;
                    foreach (var w in widths)
                    {
                        var wr = w / totalWidth;
                        if (modelCount < gridView.Models.Count)
                        {
                            var model = gridView.Models[modelCount];
                            ModelExporter.ExportToPng(model, file, (int)(wr * width), (int)(hr * height));
                            using (var image = Image.FromFile(file))
                            {
                                g.DrawImage(image, new Point((int)(wp * width), (int)(hp * height)));
                            }

                            wp += wr;
                        }
                        ++modelCount;
                    }
                    hp += hr;
                }

                canvas.Save(path, ImageFormat.Png);
            }

            File.Delete(file);
        }

        public static void Export(GridView gridView, string path, int width = 800, int height = 600, bool isDocument = true)
        {
            var p = path.ToLower();
            if (p.EndsWith(".png"))
                ExportToPng(gridView, path, width, height);
            else
                ExportToSvg(gridView, path, width, height, isDocument);
        }
    }
}
