using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;

namespace Horker.PSOxyPlot.PowerShellMethods
{
    public static class PlotModelMethods
    {
        public static PSObject Save(PSObject self, string path, int width = 800, int height = 600, bool isDocument = false)
        {
            var model = (PlotModel)self.BaseObject;
            Exporter.Export(model, path, width, height, isDocument);

            return AutomationNull.Value;
        }
    }
}
