using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.Styles
{
    public static class ColorSchemeHelper
    {
        public static int GetCountCount(PlotModel model, Style style)
        {
            var count = 0;
            for (var i = 0; i < model.Series.Count; ++i)
            {
                var s = model.Series[i];
                if (s is PieSeries pie)
                    count += pie.Slices.Count;
                else if (s is CandleStickSeries || s is TwoColorAreaSeries || s is TwoColorLineSeries || s is TornadoBarSeries || s is VolumeSeries)
                    count += 2;
                else if (s is ThreeColorLineSeries)
                    count += 3;
                else
                    ++count;
            }

            return count;
        }
    }
}
