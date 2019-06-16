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

            // Initialize axes

            if (parameters.TryGetValue("AxType", out var axTypeName))
            {
                var axisType = AxisInitializer.GetAxisTypeByPartialName(axTypeName.ToString());
                var axis = (Axis)axisType.GetConstructor(new Type[0]).Invoke(new object[0]);
                axis.Position = AxisPosition.Bottom;
                model.Axes.Add(axis);
            }

            if (parameters.TryGetValue("AyType", out var ayTypeName))
            {
                var axisType = AxisInitializer.GetAxisTypeByPartialName(ayTypeName.ToString());
                var axis = (Axis)axisType.GetConstructor(new Type[0]).Invoke(new object[0]);
                axis.Position = AxisPosition.Left;
                model.Axes.Add(axis);
            }

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
