using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Horker.OxyPlotCli.SeriesBuilders;
using System.Collections.Generic;
using Horker.OxyPlotCli;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class HistogramSeriesHelpersTest
    {
        [TestMethod]
        public void TestBinWidth()
        {
            var data = new[] { 11, 22, 33, 44, 55 };

            var min = data.Min();
            var max = data.Max();

            var binCount = HistogramSeriesHelpers.GetBinCount(min, max, data.Length);
            var h = HistogramSeriesHelpers.GetPrettyBinWidth(min, max, binCount);

            Assert.AreEqual(3, binCount);

            Assert.AreEqual(20, h.BinWidth);
            Assert.AreEqual(0, h.AdjustedLower);
            Assert.AreEqual(60, h.AdjustedUpper);
        }
    }
}
