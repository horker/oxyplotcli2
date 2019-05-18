using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.SeriesBuilders
{
    public class BarSeriesBuilder : SeriesBuilder<BarSeries, BarItem, double, string, VoidT, VoidT, VoidT, VoidT>
    {
        public static readonly string[] DataPointItemNames = new string[] { "Value", "Category" };
        public static readonly bool[] DataPointItemMandatoriness = new bool[] { true, false };
        public static readonly string ShortName = "bar";

        protected override string[] GetDataPointItemNames() => DataPointItemNames;
        protected override bool[] GetDataPointItemMandatoriness() => DataPointItemMandatoriness;

        protected override void AddDataPointToSeries(BarSeries series, double value, string category, VoidT e3, VoidT e4, VoidT e5, VoidT e6)
        {
            series.Items.Add(new BarItem(value));
        }

        public BarSeriesBuilder(Dictionary<string, object> boundParameters)
            : base(boundParameters)
        { }
    }

    public class ColumnSeriesBuilder : SeriesBuilder<ColumnSeries, ColumnItem, double, string, VoidT, VoidT, VoidT, VoidT>
    {
        public static readonly string[] DataPointItemNames = new string[] { "Value", "Category" };
        public static readonly bool[] DataPointItemMandatoriness = new bool[] { true, false };
        public static readonly string ShortName = "column";

        protected override string[] GetDataPointItemNames() => DataPointItemNames;
        protected override bool[] GetDataPointItemMandatoriness() => DataPointItemMandatoriness;

        protected override void AddDataPointToSeries(ColumnSeries series, double value, string category, VoidT e3, VoidT e4, VoidT e5, VoidT e6)
        {
            series.Items.Add(new ColumnItem(value));
        }

        public ColumnSeriesBuilder(Dictionary<string, object> boundParameters)
            : base(boundParameters)
        { }
    }

    public class LineSeriesBuilder : SeriesBuilder<LineSeries, DataPoint, double, double, VoidT, VoidT, VoidT, VoidT>
    {
        public static readonly string[] DataPointItemNames = new string[] { "X", "Y" };
        public static readonly bool[] DataPointItemMandatoriness = new bool[] { true, true };
        public static readonly string ShortName = "line";

        protected override string[] GetDataPointItemNames() => DataPointItemNames;
        protected override bool[] GetDataPointItemMandatoriness() => DataPointItemMandatoriness;

        protected override void AddDataPointToSeries(LineSeries series, double x, double y, VoidT e3, VoidT e4, VoidT e5, VoidT e6)
        {
            series.Points.Add(new DataPoint(x, y));
        }

        public LineSeriesBuilder(Dictionary<string, object> boundParameters)
            : base(boundParameters)
        { }
    }

    public class ScatterSeriesBuilder : SeriesBuilder<ScatterSeries, ScatterPoint, double, double, double, double, VoidT, VoidT>
    {
        public static readonly string[] DataPointItemNames = new string[] { "X", "Y", "Size", "Value" };
        public static readonly bool[] DataPointItemMandatoriness = new bool[] { true, true, false, false };
        public static readonly string ShortName = "scatter";

        protected override string[] GetDataPointItemNames() => DataPointItemNames;
        protected override bool[] GetDataPointItemMandatoriness() => DataPointItemMandatoriness;

        protected override void AddDataPointToSeries(ScatterSeries series, double x, double y, double size, double value, VoidT e5, VoidT e6)
        {
            series.Points.Add(new ScatterPoint(x, y, size, value));
        }

        public ScatterSeriesBuilder(Dictionary<string, object> boundParameters)
            : base(boundParameters)
        { }
    }

    public class PieSeriesBuilder : SeriesBuilder<PieSeries, PieSlice, string, double, OxyColor, bool, VoidT, VoidT>
    {
        public static readonly string[] DataPointItemNames = new string[] { "Label", "Value", "Fill", "IsExploded" };
        public static readonly bool[] DataPointItemMandatoriness = new bool[] { true, true, false, false };
        public static readonly string ShortName = "pie";

        protected override string[] GetDataPointItemNames() => DataPointItemNames;
        protected override bool[] GetDataPointItemMandatoriness() => DataPointItemMandatoriness;

        protected override void AddDataPointToSeries(PieSeries series, string label, double value, OxyColor fill, bool isExploded, VoidT e5, VoidT e6)
        {
            var slice = new PieSlice(label, value);
            slice.Fill = fill;
            slice.IsExploded = isExploded;
            series.Slices.Add(slice);
        }

        public PieSeriesBuilder(Dictionary<string, object> boundParameters)
            : base(boundParameters)
        { }
    }
}
