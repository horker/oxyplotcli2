using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.Series;

namespace Horker.OxyPlotCli.SeriesBuilders
{
    public static class SeriesBuilderStore
    {
        private static Dictionary<Type, ISeriesBuilder> _seriesBuilders;

        static SeriesBuilderStore()
        {
            _seriesBuilders = new Dictionary<Type, ISeriesBuilder>();

            foreach (var ti in typeof(SeriesBuilderStore).Assembly.DefinedTypes)
            {
                var t = ti.AsType();
                if (t.Name.EndsWith("SeriesBuilder") && !t.IsAbstract)
                {
                    var instance = (ISeriesBuilder)t.GetConstructor(new Type[0]).Invoke(new object[0]);
                    var seriesType = instance.SeriesType;
                    _seriesBuilders.Add(seriesType, instance);
                }
            }
        }

        public static ISeriesBuilder OfType(Type seriesType) => _seriesBuilders[seriesType];
    }
}
