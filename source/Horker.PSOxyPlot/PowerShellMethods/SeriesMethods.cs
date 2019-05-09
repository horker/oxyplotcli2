using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.PowerShellMethods
{
    public static class SeriesMethods
    {
        public static PSObject Save(PSObject self, string path, int width = 800, int height = 600, bool isDocument = false)
        {
            var series = (Series)self.BaseObject;

            var model = new PlotModel();
            model.Series.Add(series);

            Exporter.Export(model, path, width, height, isDocument);

            return AutomationNull.Value;
        }
    }
}
