using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.OxyPlotCli
{
    public static class HistogramSeriesHelpers
    {
        public static int GetBinCount(double min, double max, int count)
        {
            var w = (int)Math.Ceiling(Math.Sqrt(count));
            if (w < 5)
                w = 5;
            else if (w > 100)
                w = 100;

            return w;
        }

        public class HistogramInterval
        {
            public int BinCount { get; internal set; }
            public double BinWidth { get; internal set; }
            public double AdjustedLower { get; internal set; }
            public double AdjustedUpper { get; internal set; }
        }

        public static HistogramInterval GetPrettyBinWidth(double min, double max, int binCount)
        {
            var ceiling = (max - min) / binCount;
            var widthBase = Math.Pow(10, Math.Floor(Math.Log10(ceiling)));

            var binWidth = 0.0;
            if (ceiling <= 1.4 * widthBase)
                binWidth = widthBase;
            else if (ceiling < 2.8 * widthBase)
                binWidth = 2 * widthBase;
            else if (ceiling < 7 * widthBase)
                binWidth = 5 * widthBase;
            else
                binWidth = 5 * widthBase;

            var baseLower = Math.Floor(min / binWidth);
            var baseUpper = Math.Ceiling(max / binWidth);
            var newBinCount = baseUpper - baseLower;

            var adjustedLower = binWidth * baseLower;
            var adjustedUpper = binWidth * baseUpper;

            return new HistogramInterval()
            {
                BinCount = (int)newBinCount,
                BinWidth = binWidth,
                AdjustedLower = adjustedLower,
                AdjustedUpper = adjustedUpper
            };
        }
    }
}
