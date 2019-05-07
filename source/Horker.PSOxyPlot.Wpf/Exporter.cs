using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Wpf;

namespace Horker.PSOxyPlot.Wpf
{
    public static class Exporter
    {
        public static void ExportToPng(PlotModel model, string path, int width = 800, int height = 600)
        {
            var ex = new PngExporter()
            {
                Width = width,
                Height = height
            };

            ex.ExportToFile(model, path);
        }
    }
}
