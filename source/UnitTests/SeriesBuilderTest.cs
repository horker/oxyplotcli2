using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Horker.PSOxyPlot.SeriesBuilders;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class SeriesBuilderTest
    {
        [TestMethod]
        public void TestContourSeriesBuilder()
        {
            var sb = new ContourSeriesBuilder();

            var arguments = new Dictionary<string, object>();
            arguments["X"] = new double[] { 1, 5, 0 };
            arguments["Y"] = new double[] { 0, 3, 5 };
            arguments["Z"] = new double[] { 5, 4, 3 };

            sb.ReadBoundParameters(arguments);
            var si = sb.CreateSeriesInfo();
            var s = si.Series[0];

            Assert.AreEqual(2, s.Data.Rank);
            CollectionAssert.AreEqual(new double[] { 0, 1, 5 }, s.ColumnCoordinates);
            CollectionAssert.AreEqual(new double[] { 0, 3, 5 }, s.RowCoordinates);

            var dataExpected = new double[3, 3]
            {
                { 0, 0, 3 },
                { 5, 0, 0 },
                { 0, 4, 0 }
            };
            CollectionAssert.AreEqual(dataExpected, s.Data);
        }
    }
}
