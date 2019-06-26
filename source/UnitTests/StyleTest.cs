using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Horker.PSOxyPlot.SeriesBuilders;
using System.Collections.Generic;
using Horker.PSOxyPlot.Styles;
using OxyPlot.Series;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class StyleTest
    {
        [TestMethod]
        public void TestCreateStyle()
        {
            var temp = -1;

            var style = Style.Create(new Dictionary<string, object>()
            {
                {
                    "PieSeries.Diameter", .9
                },
                {
                    "LineSeries.*", new Action<object>(value => temp = 1234)
                },
                {
                    "*LineSeries.FontSize", 10
                }
            });

            Assert.AreEqual(4, style.Decorators.Count);

            var typeNames = new List<Type>(style.Decorators.Keys).Select(x => x.Name).ToList();
            typeNames.Sort();
            CollectionAssert.AreEqual(new string[] { "LineSeries", "PieSeries", "ThreeColorLineSeries", "TwoColorLineSeries" }, typeNames);

            Assert.AreEqual(1, style.TypeHooks.Count);
            Assert.AreEqual(0, style.EventHooks.Count);

            var decs = style.Decorators[typeof(PieSeries)];
            Assert.AreEqual(1, decs.Count);
            Assert.AreEqual("Diameter", decs[0].Property.Name);
            Assert.AreEqual(.9, decs[0].Value);

            decs = style.Decorators[typeof(TwoColorLineSeries)];
            Assert.AreEqual(1, decs.Count);
            Assert.AreEqual("FontSize", decs[0].Property.Name);
            Assert.AreEqual(10.0, decs[0].Value);

            var typeHooks = style.TypeHooks[typeof(LineSeries)];
            Assert.AreEqual(1, typeHooks.Count);
            typeHooks[0].Invoke(null);
            Assert.AreEqual(temp, 1234);
        }
    }
}
