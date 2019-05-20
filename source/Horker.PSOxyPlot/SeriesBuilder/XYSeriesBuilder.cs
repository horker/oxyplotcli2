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
        public override string[] DataPointItemNames => new string[] { "Value", "Category" };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, false };
        public override int[] AxisItemIndexes => new int[] { 0, 1 };
        public override string ShortName => "bar";

        protected override void AddDataPointToSeries(BarSeries series, double value, string category, VoidT e3, VoidT e4, VoidT e5, VoidT e6)
        {
            series.Items.Add(new BarItem(value));
        }
    }

    public class ColumnSeriesBuilder : SeriesBuilder<ColumnSeries, ColumnItem, double, string, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new string[] { "Value", "Category" };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, false };
        public override int[] AxisItemIndexes => new int[] { 1, 0 };
        public override string ShortName => "column";

        protected override void AddDataPointToSeries(ColumnSeries series, double value, string category, VoidT e3, VoidT e4, VoidT e5, VoidT e6)
        {
            series.Items.Add(new ColumnItem(value));
        }
    }

    public class LineSeriesBuilder : SeriesBuilder<LineSeries, DataPoint, double, double, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new string[] { "X", "Y" };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, true };
        public override int[] AxisItemIndexes => new int[] { 0, 1 };
        public override string ShortName => "line";

        protected override void AddDataPointToSeries(LineSeries series, double x, double y, VoidT e3, VoidT e4, VoidT e5, VoidT e6)
        {
            series.Points.Add(new DataPoint(x, y));
        }
    }

    public class ScatterSeriesBuilder : SeriesBuilder<ScatterSeries, ScatterPoint, double, double, double, double, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new string[] { "X", "Y", "Size", "Value" };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, true, false, false };
        public override int[] AxisItemIndexes => new int[] { 0, 1 };
        public override string ShortName => "scatter";

        protected override void AddDataPointToSeries(ScatterSeries series, double x, double y, double size, double value, VoidT e5, VoidT e6)
        {
            series.Points.Add(new ScatterPoint(x, y, size, value));
        }
    }

    public class PieSeriesBuilder : SeriesBuilder<PieSeries, PieSlice, string, double, OxyColor, bool, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new string[] { "Label", "Value", "Fill", "IsExploded" };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, true, false, false };
        public override int[] AxisItemIndexes => new int[] { 999, 999 };
        public override string ShortName => "pie";

        protected override void AddDataPointToSeries(PieSeries series, string label, double value, OxyColor fill, bool isExploded, VoidT e5, VoidT e6)
        {
            var slice = new PieSlice(label, value);
            slice.Fill = fill;
            slice.IsExploded = isExploded;
            series.Slices.Add(slice);
        }
    }
}
