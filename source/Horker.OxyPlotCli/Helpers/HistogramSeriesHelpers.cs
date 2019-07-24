using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.OxyPlotCli
{
    public class HistogramInterval
    {
        public int BinCount { get; internal set; }
        public double BinWidth { get; internal set; }
        public double AdjustedLower { get; internal set; }
        public double AdjustedUpper { get; internal set; }
    }

    public static class HistogramSeriesHelpers
    {
        public static int GetBinCount(double min, double max, int count)
        {
            // square root
            var binCount = (int)Math.Ceiling(Math.Sqrt(count));

            // Sturges
            // var binCount = (int)Math.Floor(Math.Log(count) / Math.Log(2) + 1);

            if (binCount > count)
                binCount = count;

            if (binCount > 50)
                binCount = 50;

            return binCount;
        }

        public static HistogramInterval GetHistogramIntervalFromBinCount(double min, double max, int binCount)
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

            return GetHistogramIntervalFromBinWidth(min, max, binWidth);
        }

        public static HistogramInterval GetHistogramIntervalFromBinWidth(double min, double max, double binWidth)
        {
            var baseLower = Math.Floor(min / binWidth);
            var baseUpper = Math.Ceiling(max / binWidth);

            var binCount = baseUpper - baseLower + 1;

            var adjustedLower = binWidth * baseLower;
            var adjustedUpper = binWidth * baseUpper;

            return new HistogramInterval()
            {
                BinCount = (int)binCount,
                BinWidth = binWidth,
                AdjustedLower = adjustedLower,
                AdjustedUpper = adjustedUpper
            };
        }

        public static IList<double> Collect(IList<double> data, HistogramInterval intervals, bool normalize)
        {
            var result = new double[intervals.BinCount];
            var total = 0;

            foreach (var value in data)
            {
                var bin = (int)Math.Floor((value - intervals.AdjustedLower) / intervals.BinWidth);
                ++result[bin];
                ++total;
            }

            if (normalize)
            {
                for (var i = 0; i < result.Length; ++i)
                    result[i] = result[i] / total;
            }

            return result;
        }
    }
}
