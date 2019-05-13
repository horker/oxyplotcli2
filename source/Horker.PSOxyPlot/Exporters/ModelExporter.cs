using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Wpf;

namespace Horker.PSOxyPlot
{
    public static class ModelExporter
    {
        public static string ExportToSvgString(PlotModel model, double width = 800, double height = 600, bool isDocument = false)
        {
            var ex = new OxyPlot.Wpf.SvgExporter()
            {
                Width = width,
                Height = height,
                IsDocument = isDocument
            };

            return ex.ExportToString(model);
        }

        public static void ExportToSvg(PlotModel model, string path, double width = 800, double height = 600, bool isDocument = false)
        {
            var svgString = ExportToSvgString(model, width, height, isDocument);

            using (var f = new StreamWriter(path))
            {
                f.Write(svgString);
            }
        }

        public static void ExportToPng(PlotModel model, string path, int width = 800, int height = 600)
        {
            var ex = new PngExporter()
            {
                Width = width,
                Height = height
            };

            ex.ExportToFile(model, path);
        }

        public static void Export(PlotModel model, string path, double width = 800, double height = 600, bool isDocument = false)
        {
            var p = path.ToLower();
            if (p.EndsWith(".png"))
                ExportToPng(model, path, (int)width, (int)height);
            else
                ExportToSvg(model, path, width, height, isDocument);
        }
    }
}
