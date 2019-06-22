using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.Initializers
{
    public class PlotModelInitializer
    {
        public static PlotModel CreateWithSeriesInfo(IList<ISeriesInfo> siList)
        {
            var model = new PlotModel();

            model.Updating += (object sender, EventArgs e) =>
            {
                foreach (var si in siList)
                    AxisInitializer.EnsureAxes((PlotModel)sender, si);
            };

            return model;
        }
    }
}
