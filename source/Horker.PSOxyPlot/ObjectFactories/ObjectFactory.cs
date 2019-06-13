using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.ObjectFactories
{
    public class ObjectFactory
    {
        public static PlotModel CreatePlotModel(ISeriesInfo si, Dictionary<string, object> parameters)
        {
            var model = new PlotModel();
            AxisInitializer.WithSeriesInfo(model, si);
            AxisInitializer.AssignParametersToModelAxes(model, parameters);

            return model;
        }

        public static T CreateSeries<T>()
            where T: Series, new()
        {
            return new T();
        }

        public static T CreateAxis<T>()
            where T: Axis, new()
        {
            return new T();
        }
    }
}
