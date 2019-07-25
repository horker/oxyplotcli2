using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Horker.OxyPlotCli.Initializers;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.OxyPlotCli.SeriesBuilders
{
    public abstract class HistogramSeriesBuilder<SeriesT, DataPointT, E1, E2, E3, E4, E5, E6, E7, E8> : SeriesBuilder<SeriesT, DataPointT, E1, E2, E3, E4, E5, E6, E7, E8>
        where SeriesT : Series, new()
    {
        public override Tuple<string, Type>[] AdditionalParameters => new[]
        {
            Tuple.Create("BinCount", typeof(int)),
            Tuple.Create("BinWidth", typeof(TypeAdaptors.Double)),
            Tuple.Create("Normalize", typeof(SwitchParameter))
        };

        protected int _binCount = -1;
        protected double _binWidth = double.NaN;
        protected bool _normalize = false;

        protected override void ReadSpecificParameters(Dictionary<string, object> boundParameters)
        {
            if (boundParameters.TryGetValue("BinCount", out var value))
                _binCount = (int)value;
            if (boundParameters.TryGetValue("BinWidth", out value))
                _binWidth = (TypeAdaptors.Double)value;
            if (boundParameters.TryGetValue("Normalize", out value))
                _normalize = (SwitchParameter)value;
        }

        protected HistogramInterval GetHistogramInterval(double min, double max, int dataCount)
        {
            HistogramInterval h;

            if (double.IsNaN(_binWidth))
            {
                if (_binCount == -1)
                    _binCount = HistogramSeriesHelpers.GetBinCount(min, max, dataCount);
                h = HistogramSeriesHelpers.GetHistogramIntervalFromBinCount(min, max, _binCount);
            }
            else
            {
                h = HistogramSeriesHelpers.GetHistogramIntervalFromBinWidth(min, max, _binWidth);
            }

            return h;
        }
    }
}