using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Wpf;

namespace Horker.OxyPlotCli
{
    public static class ModelExporter
    {
        public static string RemoveHtmlHeaderFromSvg(string svg)
        {
            var startIndex = svg.IndexOf("<svg ");
            var endIndex = svg.IndexOf(">", startIndex + 5);
            return svg.Substring(startIndex);
        }

        public static string RemoveOpeningSvgTag(string svg)
        {
            var startIndex = svg.IndexOf("<svg ");
            var endIndex = svg.IndexOf(">", startIndex + 5);
            return svg.Substring(endIndex + 1);
        }

        public static string ExportToSvgString(PlotModel model, double width, double height, bool isDocument)
        {
            var ex = new OxyPlot.SvgExporter()
            {
                Width = width,
                Height = height,
                IsDocument = isDocument
            };

            var svg = ex.ExportToString(model);

            return isDocument ? svg : RemoveHtmlHeaderFromSvg(svg);
        }

        public static void ExportToSvg(PlotModel model, string path, double width, double height, bool isDocument)
        {
            var svgString = ExportToSvgString(model, width, height, isDocument);

            using (var f = new StreamWriter(path))
            {
                f.Write(svgString);
            }
        }

        public static void ExportToPng(PlotModel model, string path, int width, int height)
        {
            var ex = new PngExporter()
            {
                Width = width,
                Height = height
            };

            ex.ExportToFile(model, path);
        }

        public static void Export(PlotModel model, string path, double width, double height, bool isDocument)
        {
            var p = path.ToLower();
            if (p.EndsWith(".png"))
                ExportToPng(model, path, (int)width, (int)height);
            else
                ExportToSvg(model, path, width, height, isDocument);
        }
    }
}
