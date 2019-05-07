using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;

namespace Horker.PSOxyPlot
{
    public static class Exporter
    {
        public static string ExportToSvgString(PlotModel model, int width = 800, int height = 600, bool isDocument = false)
        {
            var ex = new SvgExporter()
            {
                Width = width,
                Height = height,
                IsDocument = isDocument
            };

            return ex.ExportToString(model);
        }
    }
}
