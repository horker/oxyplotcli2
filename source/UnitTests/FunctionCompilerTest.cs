using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Horker.OxyPlotCli.SeriesBuilders;
using System.Collections.Generic;
using Horker.OxyPlotCli;

namespace UnitTests
{
    [TestClass]
    public class FunctionCompilerTest
    {
        [TestMethod]
        public void TestCompile()
        {
            var f = FunctionCompiler.Compile("x => x * 2 + 1");

            Assert.AreEqual(7, f.Invoke(3));
        }
    }
}
