using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot
{
    public static class GridViewExporter
    {
        public static string ExportToSvgString(GridView grid, int width = 800, int height = 600)
        {
            var s = new StringBuilder();
            s.AppendFormat("<svg width=\"{0}\" height=\"{1}\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" version=\"1.1\">", width, height);
            s.AppendLine();

            var adjusted = grid.GetAdjustedWidthHeight();
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
                    if (modelCount < grid.Models.Count)
                    {
                        var wr = w / totalWidth;
                        var svg = ModelExporter.ExportToSvgString(grid.Models[modelCount],  wr * width, hr * height, false);
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
    }
}
