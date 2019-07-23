using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horker.OxyPlotCli.Initializers;
using OxyPlot.Axes;
using OxyPlot.Series;
using static Horker.OxyPlotCli.HistogramSeriesHelpers;

namespace Horker.OxyPlotCli.SeriesBuilders
{
    public abstract class HistogramSeriesBuilder<SeriesT, DataPointT, E1, E2, E3, E4, E5, E6, E7> : SeriesBuilder<SeriesT, DataPointT, E1, E2, E3, E4, E5, E6, E7>
        where SeriesT : Series, new()
    {
        private string[] _categories = null;

        protected override string[] GetCategoryNames() => _categories;

        protected virtual void SetCategories(HistogramInterval h)
        {
            _categories = new string[h.BinCount];
            for (var i = 0; i < h.BinCount; ++i)
                _categories[i] = $"{Math.Round(h.AdjustedLower + i * h.BinWidth, 5)} - {Math.Round(h.AdjustedLower + (i + 1) * h.BinWidth, 5)}";
        }

        public override Axis GetDefaultAxisObject(AxisKind kind)
        {
            Axis axis;

            switch (kind)
            {
                case AxisKind.Ax:
                    axis = new CategoryAxis()
                    {
                        Position = AxisPosition.Bottom,
                        IsTickCentered = false,
                        GapWidth = 0.0
                    };
                    break;
                case AxisKind.Ay:
                    axis = new LinearAxis()
                    {
                        Position = AxisPosition.Left,
                        Title = "Frequency"
                    };
                    break;
                case AxisKind.Az:
                    axis = null;
                    break;
                default:
                    throw new ArgumentException($"Unknown axis kind: {kind}");
            }

            return axis;
        }
    }
}