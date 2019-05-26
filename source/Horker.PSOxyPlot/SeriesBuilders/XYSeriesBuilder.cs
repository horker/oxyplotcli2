using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.SeriesBuilders
{
    public class AreaSeriesBuilder : SeriesBuilder<AreaSeries, DataPoint, double, double, double, double, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new string[] { "X0", "Y0", "X1", "Y1" };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, true, true, true };
        public override int[] AxisItemIndexes => new int[] { 0, 1, -1, -1 };
        public override Type[] DefaultAxisTypes => new Type[] { typeof(LinearAxis), typeof(LinearAxis) };
        public override string ShortName => "area";

        protected override void AddDataPointToSeries(AreaSeries series, double x0, double y0, double x1, double y1, VoidT e5, VoidT e6)
        {
            series.Points.Add(new DataPoint(x0, y0));
            series.Points2.Add(new DataPoint(x1, y1));
        }
    }

    public class BarSeriesBuilder : SeriesBuilder<BarSeries, BarItem, double, TypeAdaptors.Category, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new string[] { "Value", "Category" };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, false };
        public override int[] AxisItemIndexes => new int[] { 0, 1 };
        public override Type[] DefaultAxisTypes => new Type[] { typeof(LinearAxis), typeof(CategoryAxis) };
        public override string ShortName => "bar";

        protected override void AddDataPointToSeries(BarSeries series, double value, TypeAdaptors.Category category, VoidT e3, VoidT e4, VoidT e5, VoidT e6)
        {
            series.Items.Add(new BarItem(value));
        }
    }

    public class CandleStickSeriesBuilder : SeriesBuilder<CandleStickSeries, HighLowItem, double, double, double, double, double, VoidT>
    {
        public override string[] DataPointItemNames => new string[] { "X", "High", "Low", "Open", "Close" };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, true, true, true, true };
        public override int[] AxisItemIndexes => new int[] { 0, -1, -1, -1, 1 };
        public override Type[] DefaultAxisTypes => new Type[] { typeof(LinearAxis), typeof(LinearAxis) };
        public override string ShortName => "candleStick";

        protected override void AddDataPointToSeries(CandleStickSeries series, double x, double high, double low, double open, double close, VoidT e6)
        {
            series.Items.Add(new HighLowItem(x, high, low, open, close));
        }
    }

    public class CandleStickAndVolumeSeriesBuilder : SeriesBuilder<CandleStickAndVolumeSeries, OhlcvItem, double, double, double, double, double, double>
    {
        public override string[] DataPointItemNames => new string[] { "X", "Open", "High", "Low", "Close", "BuyVolume" /* , "SellVolume" */ };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, true, true, true, true, false, false };
        public override int[] AxisItemIndexes => new int[] { 0, -1, -1, -1, 1, -1, -1 };
        public override Type[] DefaultAxisTypes => new Type[] { typeof(LinearAxis), typeof(LinearAxis) };
        public override string ShortName => "candleStickAndVolume";

        protected override void AddDataPointToSeries(CandleStickAndVolumeSeries series, double x, double open, double high, double low, double close, double buyVolume)
        {
            series.Items.Add(new OhlcvItem(x, open, high, low, close, buyVolume));
        }
    }

    public class ColumnSeriesBuilder : SeriesBuilder<ColumnSeries, ColumnItem, double, TypeAdaptors.Category, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new string[] { "Value", "Category" };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, false };
        public override int[] AxisItemIndexes => new int[] { 1, 0 };
        public override Type[] DefaultAxisTypes => new Type[] { typeof(CategoryAxis), typeof(LinearAxis) };
        public override string ShortName => "column";

        protected override void AddDataPointToSeries(ColumnSeries series, double value, TypeAdaptors.Category category, VoidT e3, VoidT e4, VoidT e5, VoidT e6)
        {
            series.Items.Add(new ColumnItem(value));
        }
    }

    public class ErrorColumnSeriesBuilder : SeriesBuilder<ErrorColumnSeries, ErrorColumnItem, double, double, TypeAdaptors.Category, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new string[] { "Value", "Error", "Category" };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, true, false };
        public override int[] AxisItemIndexes => new int[] { 1, -1, 0 };
        public override Type[] DefaultAxisTypes => new Type[] { typeof(CategoryAxis), typeof(LinearAxis) };
        public override string ShortName => "errorColumn";

        protected override void AddDataPointToSeries(ErrorColumnSeries series, double value, double error, TypeAdaptors.Category category, VoidT e4, VoidT e5, VoidT e6)
        {
            series.Items.Add(new ErrorColumnItem(value, error));
        }
    }

    public class IntervalBarSeriesBuilder : SeriesBuilder<IntervalBarSeries, IntervalBarItem, double, double, string, TypeAdaptors.Category, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new string[] { "Start", "End", "BarTitle", "Category" };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, true, false, false };
        public override int[] AxisItemIndexes => new int[] { 1, -1, -1, 0 };
        public override Type[] DefaultAxisTypes => new Type[] { typeof(LinearAxis), typeof(CategoryAxis) };
        public override string ShortName => "intervalBar";

        protected override void AddDataPointToSeries(IntervalBarSeries series, double start, double end, string barTitle, TypeAdaptors.Category category, VoidT e5, VoidT e6)
        {
            series.Items.Add(new IntervalBarItem(start, end, barTitle));
        }
    }

    public class LineSeriesBuilder : SeriesBuilder<LineSeries, DataPoint, double, double, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new string[] { "X", "Y" };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, true };
        public override int[] AxisItemIndexes => new int[] { 0, 1 };
        public override Type[] DefaultAxisTypes => new Type[] { typeof(LinearAxis), typeof(LinearAxis) };
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
        public override int[] AxisItemIndexes => new int[] { 0, 1, -1, -1 };
        public override Type[] DefaultAxisTypes => new Type[] { typeof(LinearAxis), typeof(LinearAxis) };
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
        public override int[] AxisItemIndexes => new int[] { -1, -1, -1, -1 };
        public override Type[] DefaultAxisTypes => new Type[] { null, null };
        public override string ShortName => "pie";

        protected override void AddDataPointToSeries(PieSeries series, string label, double value, OxyColor fill, bool isExploded, VoidT e5, VoidT e6)
        {
            var slice = new PieSlice(label, value);
            slice.Fill = fill;
            slice.IsExploded = isExploded;
            series.Slices.Add(slice);
        }
    }

    public class RectangleBarSeriesBuilder : SeriesBuilder<RectangleBarSeries, RectangleBarItem, double, double, double, double, TypeAdaptors.Category, VoidT>
    {
        public override string[] DataPointItemNames => new string[] { "X0", "Y0", "X1", "Y1", "Category" };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, true, true, true, false };
        public override int[] AxisItemIndexes => new int[] { 0, 1, -1, -1, -1 };
        public override Type[] DefaultAxisTypes => new Type[] { typeof(LinearAxis), typeof(LinearAxis) };
        public override string ShortName => "rectangleBar";

        protected override void AddDataPointToSeries(RectangleBarSeries series, double x0, double y0, double x1, double y1, TypeAdaptors.Category category, VoidT e6)
        {
            series.Items.Add(new RectangleBarItem(x0, y0, x1, y1));
        }
    }

    public class TornadoBarSeriesBuilder : SeriesBuilder<TornadoBarSeries, TornadoBarItem, double, double, double, OxyColor, OxyColor, TypeAdaptors.Category>
    {
        public override string[] DataPointItemNames => new string[] { "Minimum", "Maximum", "BarBaseValue", "MinimumColor", "MaximumColor", "Category" };
        public override bool[] DataPointItemMandatoriness => new bool[] { true, true, true, false, false, false };
        public override int[] AxisItemIndexes => new int[] { 0, -1, -1, -1, -1, -1 };
        public override Type[] DefaultAxisTypes => new Type[] { typeof(LinearAxis), typeof(CategoryAxis) };
        public override string ShortName => "tornadoBar";

        protected override void AddDataPointToSeries(TornadoBarSeries series, double minimum, double maximum, double barBaseValue, OxyColor minimumColor, OxyColor maximumColor, TypeAdaptors.Category category)
        {
            var item = new TornadoBarItem()
            {
                Minimum = minimum,
                Maximum = maximum,
                BaseValue = barBaseValue,
                MinimumColor = minimumColor,
                MaximumColor = maximumColor
            };
            series.Items.Add(item);
        }
    }
}
