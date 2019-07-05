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
        private static int GetColorCount(PlotModel model)
        {
            // TODO: find OxyColors.Automatic in series objects' setter properties

            var count = 0;
            for (var i = 0; i < model.Series.Count; ++i)
            {
                var s = model.Series[i];
                if (s is PieSeries pie)
                    count += pie.Slices.Count;
                else if (s is TwoColorAreaSeries || s is TwoColorLineSeries || s is TornadoBarSeries)
                    count += 2;
                else if (s is ThreeColorLineSeries)
                    count += 3;
                else if (s is BoxPlotSeries || s is CandleStickSeries || s is CandleStickAndVolumeSeries || s is VolumeSeries)
                {
                    // These series don't respect DefaultColors so that we set them manually in Style.ApplyColorScheme().
                    continue;
                }
                else
                    ++count;
            }

            if (count == 0)
                ++count;

            return count;
        }

        public static void ApplyColorScheme(PlotModel model, IColorScheme colorScheme)
        {
            var colorCount = GetColorCount(model);
            model.DefaultColors = colorScheme.GetDefaultColors(colorCount);
        }
    }
}
