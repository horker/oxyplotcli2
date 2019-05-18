using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace Horker.PSOxyPlot
{
    internal class LineSeriesBuilder : SeriesBuilder<LineSeries, DataPoint, double, double, VoidT, VoidT, VoidT, VoidT>
    {
        protected override string[] PropertyNameArguments => new string[] { "X", "Y" };

        protected override bool[] PropertyMandatoriness => new bool[] { true, true };

        protected override void AddDataPointToSeries(LineSeries series, double x, double y, VoidT e3, VoidT e4, VoidT e5, VoidT e6)
        {
            series.Points.Add(new DataPoint(x, y));
        }

        public LineSeriesBuilder(Dictionary<string, object> boundParameters)
            : base(boundParameters)
        { }
    }

    internal class ScatterSeriesBuilder : SeriesBuilder<ScatterSeries, ScatterPoint, double, double, double, double, VoidT, VoidT>
    {
        protected override string[] PropertyNameArguments => new string[] { "X", "Y", "Size", "Value" };

        protected override bool[] PropertyMandatoriness => new bool[] { true, true, false, false };

        protected override void AddDataPointToSeries(ScatterSeries series, double x, double y, double size, double value, VoidT e5, VoidT e6)
        {
            series.Points.Add(new ScatterPoint(x, y, size, value));
        }

        public ScatterSeriesBuilder(Dictionary<string, object> boundParameters)
            : base(boundParameters)
        { }
    }
}
