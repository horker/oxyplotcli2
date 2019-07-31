using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Horker.OxyPlotCli.Initializers;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.OxyPlotCli.SeriesBuilders
{
    public class AreaSeriesBuilder : SeriesBuilder<AreaSeries, DataPoint, double, double, double, double, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X1", "Y1", "X2", "Y2" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false };
        public override int[] AxisItemIndexes => new[] { 0, 1, -1, -1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.area", "oxyarea" };

        protected override void AddDataPointToSeries(AreaSeries series, double x1, double y1, double x2, double y2, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Points.Add(new DataPoint(x1, y1));
            if (!double.IsNaN(x2))
                series.Points2.Add(new DataPoint(x2, y2));
        }

        protected override void ValidateInputData()
        {
            if (_e1.Count > 0 && _e1.Count != _e2.Count)
                throw new ArgumentException($"Length of X1 and Y1 is different from each other");

            if (_e3.Count > 0 && _e3.Count != _e4.Count)
                throw new ArgumentException($"Length of X2 and Y2 is different from each other");
        }
    }

    public class BarSeriesBuilder : CategorySeriesBuilder<BarSeries, BarItem, double, TypeAdaptors.Category, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "Value", "Category" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false };
        public override int[] AxisItemIndexes => new[] { 0, 1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(CategoryAxis), null };
        public override string[] Aliases => new[] { "oxy.bar", "oxybar" };

        protected override void AddDataPointToSeries(BarSeries series, double value, TypeAdaptors.Category category, VoidT e3, VoidT e4, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Items.Add(new BarItem(value, GetCategoryIndex(category)));
        }
    }

    public class BoxPlotSeriesBuilder : CategorySeriesBuilder<BoxPlotSeries, BoxPlotItem, TypeAdaptors.Category, double, double, double, double, double, object, double>
    {
        public override string[] DataPointItemNames => new[] { "Category", "LowerWhisker", "BoxBottom", "Median", "BoxTop", "UpperWhisker", "Outliers", "Data" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false, false, false, false };
        public override int[] AxisItemIndexes => new[] { 0, -1, -1, -1, -1, -1, -1, 1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(CategoryAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.boxPlot", "oxy.box", "oxybox" };

        private Dictionary<int, List<double>> _seriesData = new Dictionary<int, List<double>>();

        protected override void AddDataPointToSeries(BoxPlotSeries series, TypeAdaptors.Category category, double lowerWhisker, double boxBottom, double median, double boxTop, double upperWhisker, object outliers, double data)
        {
            var index = 0;
            if (category != null)
                index = GetCategoryIndex(category);

            if (!double.IsNaN(data))
            {
                List<double> d;
                if (!_seriesData.TryGetValue(index, out d))
                {
                    d = new List<double>();
                    _seriesData.Add(index, d);
                }

                d.Add(data);
                return;
            }

            if (double.IsNaN(lowerWhisker))
                throw new ArgumentException("LowerWhisker is mandatory but not specified");

            if (double.IsNaN(boxBottom))
                throw new ArgumentException("BoxBottom is mandatory but not specified");

            if (double.IsNaN(median))
                throw new ArgumentException("Median is mandatory but not specified");

            if (double.IsNaN(boxTop))
                throw new ArgumentException("BoxTop is mandatory but not specified");

            if (double.IsNaN(upperWhisker))
                throw new ArgumentException("UppeprWhisker is mandatory but not specified");

            var item = new BoxPlotItem(index, lowerWhisker, boxBottom, median, boxTop, upperWhisker);
            if (outliers != null)
                item.Outliers = new TypeAdaptors.DoubleList(outliers).Values;

            series.Items.Add(item);
        }

        protected override void Postprocess(IDictionary<object, BoxPlotSeries> seriesSet)
        {
            if (_seriesData.Count == 0)
                return;

            foreach (var entry in seriesSet)
            {
                var series = entry.Value;

                foreach (var dataEntry in _seriesData)
                {
                    var index = dataEntry.Key;
                    var data = dataEntry.Value;

                    data.Sort();
                    var stat = new BoxPlotStat(data);

                    var item = new BoxPlotItem(index, stat.LowerWhisker, stat.LowerQuartile, stat.Median, stat.UpperQuartile, stat.UpperWhisker);
                    item.Outliers = stat.Outliers;
                    series.Items.Add(item);
                }
            }

        }
    }

    public class CandleStickSeriesBuilder : SeriesBuilder<CandleStickSeries, HighLowItem, double, double, double, double, double, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X", "High", "Low", "Open", "Close" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false, false };
        public override int[] AxisItemIndexes => new[] { 0, -1, -1, -1, 1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(DateTimeAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.candleStick", "oxy.candle", "oxycandle" };

        protected override void AddDataPointToSeries(CandleStickSeries series, double x, double high, double low, double open, double close, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Items.Add(new HighLowItem(x, high, low, open, close));
        }
    }

    public class CandleStickAndVolumeSeriesBuilder : SeriesBuilder<CandleStickAndVolumeSeries, OhlcvItem, double, double, double, double, double, double, double, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X", "Open", "High", "Low", "Close", "BuyVolume", "SellVolume" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false, false, false, false };
        public override int[] AxisItemIndexes => new[] { 0, -1, -1, -1, 1, -1, -1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(DateTimeAxis), typeof(LinearAxis), typeof(LinearAxis) };
        public override string[] Aliases => new[] { "oxy.candleStickAndVolume", "oxy.candlev", "oxycandlev" };

        protected override CandleStickAndVolumeSeries Create()
        {
            return new CandleStickAndVolumeSeries()
            {
                VolumeAxisKey = null
            };
        }

        protected override void AddDataPointToSeries(CandleStickAndVolumeSeries series, double x, double open, double high, double low, double close, double buyVolume, double sellVolume, VoidT e8)
        {
            if (double.IsNaN(buyVolume))
                buyVolume = 0.0;
            if (double.IsNaN(sellVolume))
                sellVolume = 0.0;

            series.Items.Add(new OhlcvItem(x, open, high, low, close, buyVolume, sellVolume));
        }

        public override Axis GetDefaultAxisObject(AxisKind kind)
        {
            Axis axis;
            switch (kind)
            {

                case AxisKind.Ax:
                    axis = new DateTimeAxis()
                    {
                        Position = AxisPosition.Bottom
                    };
                    break;

                case AxisKind.Ay:
                    axis = new LinearAxis()
                    {
                        Position = AxisPosition.Left,
                        StartPosition = .25,
                        EndPosition = 1.0
                    };
                    break;

                case AxisKind.Az:
                    axis = new LinearAxis()
                    {
                        Position = AxisPosition.Left,
                        StartPosition = 0,
                        EndPosition = .22
                    };
                    break;

                default:
                    throw new ArgumentException($"Unknown axis kind: {kind}");
            }

            return axis;
        }
    }

    public class ColumnSeriesBuilder : CategorySeriesBuilder<ColumnSeries, ColumnItem, double, TypeAdaptors.Category, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "Value", "Category" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false };
        public override int[] AxisItemIndexes => new[] { 1, 0 };
        public override Type[] DefaultAxisTypes => new[] { typeof(CategoryAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.column", "oxy.col", "oxycol" };

        protected override void AddDataPointToSeries(ColumnSeries series, double value, TypeAdaptors.Category category, VoidT e3, VoidT e4, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Items.Add(new ColumnItem(value, GetCategoryIndex(category)));
        }
    }

    public class ContourSeriesBuilder : SeriesBuilder<ContourSeries, DataPoint, double, double, double, VoidT, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X", "Y", "Z" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false };
        public override int[] AxisItemIndexes => new[] { 0, 1, -1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.contour", "oxycontour" };

        private List<double> _x;
        private List<double> _y;
        private List<double> _z;

        public ContourSeriesBuilder()
            : base()
        {
            _x = new List<double>();
            _y = new List<double>();
            _z = new List<double>();
        }

        protected override void AddDataPointToSeries(ContourSeries series, double x, double y, double z, VoidT e4, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            _x.Add(x);
            _y.Add(y);
            _z.Add(z);
        }

        protected override void Postprocess(IDictionary<object, ContourSeries> seriesSet)
        {
            if (_x.Count == 0)
                return;

            var xSorted = _x.Distinct().ToArray();
            Array.Sort(xSorted);

            var ySorted = _y.Distinct().ToArray();
            Array.Sort(ySorted);

            var xToIndex = new Dictionary<double, int>();
            var yToIndex = new Dictionary<double, int>();

            for (var i = 0; i < xSorted.Length; ++i)
                xToIndex.Add(xSorted[i], i);

            for (var i = 0; i < ySorted.Length; ++i)
                yToIndex.Add(ySorted[i], i);

            var data = new double[xSorted.Length, ySorted.Length];

            for (var i = 0; i < _x.Count; ++i)
                data[xToIndex[_x[i]], yToIndex[_y[i]]] = _z[i];

            // TODO: grouping
            foreach (var entry in seriesSet)
            {
                var series = entry.Value;
                series.ColumnCoordinates = xSorted;
                series.RowCoordinates = ySorted;
                series.Data = data;
            }
        }
    }

    public class ErrorColumnSeriesBuilder : CategorySeriesBuilder<ErrorColumnSeries, ErrorColumnItem, double, double, TypeAdaptors.Category, VoidT, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "Value", "Error", "Category" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false };
        public override int[] AxisItemIndexes => new[] { 1, -1, 0 };
        public override Type[] DefaultAxisTypes => new[] { typeof(CategoryAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.errorColumn", "oxy.ecol", "oxyecol" };

        protected override void AddDataPointToSeries(ErrorColumnSeries series, double value, double error, TypeAdaptors.Category category, VoidT e4, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Items.Add(new ErrorColumnItem(value, error, GetCategoryIndex(category)));
        }
    }

    public class FunctionSeriesBuilder : SeriesBuilder<FunctionSeries, DataPoint, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new string[0];
        public override bool[] DataPointItemMandatoriness => new bool[0];
        public override int[] AxisItemIndexes => new int[0];
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.function", "oxy.func", "oxyfunc" };

        protected override void AddDataPointToSeries(FunctionSeries series, VoidT e1, VoidT e2, VoidT e3, VoidT e4, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
        }
    }

    public class HeatMapSeriesBuilder : SeriesBuilder<HeatMapSeries, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new string[0];
        public override bool[] DataPointItemMandatoriness => new bool[0];
        public override int[] AxisItemIndexes => new int[0];
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), typeof(LinearColorAxis) };
        public override string[] Aliases => new[] { "oxy.heatMap", "oxy.heat", "oxyheat" };

        protected override void AddDataPointToSeries(HeatMapSeries series, VoidT e1, VoidT e2, VoidT e3, VoidT e4, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
        }
    }

    public class HighLowSeriesBuilder : SeriesBuilder<HighLowSeries, HighLowItem, double, double, double, double, double, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X", "High", "Low", "Open", "Close" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false, false };
        public override int[] AxisItemIndexes => new[] { 0, -1, -1, -1, 1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.highLow", "oxyhighlow" };

        protected override void AddDataPointToSeries(HighLowSeries series, double x, double high, double low, double open, double close, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Items.Add(new HighLowItem(x, high, low, open, close));
        }
    }

    public class HistogramSeriesBuilder : HistogramSeriesBuilder<HistogramSeries, HistogramItem, double, double, double, double, double, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "RangeStart", "RangeEnd", "Area", "Count", "Data" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false, false };
        public override int[] AxisItemIndexes => new[] { -1, -1, -1, 1, 0 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.histogram", "oxy.hist", "oxyhist" };

        private List<double> _data = new List<double>();
        private HistogramInterval _intervals;

        public HistogramInterval HistogramInterval => _intervals;

        protected override void AddDataPointToSeries(HistogramSeries series, double rangeStart, double rangeEnd, double area, double count, double data, VoidT e6, VoidT e7, VoidT e8)
        {
            if (!double.IsNaN(data))
            {
                _data.Add(data);
                return;
            }

            if (double.IsNaN(rangeStart))
                throw new ArgumentException("RangeStart is mandatory but not specified");

            if (double.IsNaN(rangeEnd))
                throw new ArgumentException("RangeEnd is mandatory but not specified");

            if (double.IsNaN(area) && double.IsNaN(count))
                throw new ArgumentException("Area and Count cannot be specfied at the same time");

            if (double.IsNaN(area))
                area = count * (rangeEnd - rangeStart);

            series.Items.Add(new HistogramItem(rangeStart, rangeEnd, area));
        }

        protected override void Postprocess(IDictionary<object, HistogramSeries> seriesSet)
        {
            if (_data == null || _data.Count == 0)
                return;

            _intervals = GetHistogramInterval(_data.Min(), _data.Max(), _data.Count);

            foreach (var entry in seriesSet)
            {
                var series = entry.Value;
                if (series.Items.Count > 0)
                    throw new ArgumentException("-Data and the other data items cannot be specify at the same time");

                // Grouping is not supported in HistogramSeries
                var bins = HistogramSeriesHelpers.Collect(_data, _intervals, _normalize);

                var s = _intervals.AdjustedLower;
                for (var i = 0; i < _intervals.BinCount; ++i)
                {
                    var item = new HistogramItem(s, s + _intervals.BinWidth, bins[i] * _intervals.BinWidth);
                    series.Items.Add(item);
                    s += _intervals.BinWidth;
                }
            }
        }

        public override Axis GetDefaultAxisObject(AxisKind kind)
        {
            Axis axis;

            switch (kind)
            {
                case AxisKind.Ax:
                    axis = new LinearAxis()
                    {
                        Position = AxisPosition.Bottom,
                        MajorStep = _intervals.BinWidth
                    };
                    break;
                case AxisKind.Ay:
                    axis = new LinearAxis()
                    {
                        Position = AxisPosition.Left,
                        Title = "Frequency"
                    };
                    break;
                case AxisKind.Az:
                    axis = null;
                    break;
                default:
                    throw new ArgumentException($"Unknown axis kind: {kind}");
            }

            return axis;
        }
    }

    public class Histogram2SeriesBuilder : HistogramSeriesBuilder<ColumnSeries, ColumnItem, double, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT>
    {
        public override string CmdletName => "HistogramSeries2";
        public override string[] DataPointItemNames => new[] { "Data" };
        public override bool[] DataPointItemMandatoriness => new[] { false };
        public override int[] AxisItemIndexes => new[] { 0 };
        public override Type[] DefaultAxisTypes => new[] { typeof(CategoryAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.histogram2", "oxy.hist2", "oxyhist2" };

        private List<double> _data = new List<double>();
        private Dictionary<ColumnSeries, List<double>> _seriesData = new Dictionary<ColumnSeries, List<double>>();

        private string[] _categories = null;

        protected override string[] GetCategoryNames() => _categories;

        protected override void AddDataPointToSeries(ColumnSeries series, double data, VoidT e2, VoidT e3, VoidT e4, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            List<double> d;
            if (!_seriesData.TryGetValue(series, out d))
            {
                d = new List<double>();
                _seriesData.Add(series, d);
            }

            _data.Add(data);
            d.Add(data);
        }

        protected override void Postprocess(IDictionary<object, ColumnSeries> seriesSet)
        {
            if (_data.Count == 0)
                return;

            var h = GetHistogramInterval(_data.Min(), _data.Max(), _data.Count);

            SetCategories(h);

            foreach (var entry in seriesSet)
            {
                var series = entry.Value;
                var bins = HistogramSeriesHelpers.Collect(_seriesData[series], h, _normalize);

                for (var i = 0; i < h.BinCount; ++i)
                    series.Items.Add(new ColumnItem(bins[i], i));
            }
        }

        protected void SetCategories(HistogramInterval h)
        {
            _categories = new string[h.BinCount];
            for (var i = 0; i < h.BinCount; ++i)
                _categories[i] = $"{Math.Round(h.AdjustedLower + i * h.BinWidth, 5)} - {Math.Round(h.AdjustedLower + (i + 1) * h.BinWidth, 5)}";
        }

        public override Axis GetDefaultAxisObject(AxisKind kind)
        {
            Axis axis;

            switch (kind)
            {
                case AxisKind.Ax:
                    axis = new CategoryAxis()
                    {
                        Position = AxisPosition.Bottom,
                        IsTickCentered = false,
                        GapWidth = 0.0
                    };
                    break;
                case AxisKind.Ay:
                    axis = new LinearAxis()
                    {
                        Position = AxisPosition.Left,
                        Title = "Frequency"
                    };
                    break;
                case AxisKind.Az:
                    axis = null;
                    break;
                default:
                    throw new ArgumentException($"Unknown axis kind: {kind}");
            }

            return axis;
        }
    }

    public class IntervalBarSeriesBuilder : CategorySeriesBuilder<IntervalBarSeries, IntervalBarItem, double, double, string, TypeAdaptors.Category, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "Start", "End", "BarTitle", "Category" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false };
        public override int[] AxisItemIndexes => new[] { 1, -1, -1, 0 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(CategoryAxis), null };
        public override string[] Aliases => new[] { "oxy.intervalBar", "oxy.ibar", "oxyibar" };

        protected override void AddDataPointToSeries(IntervalBarSeries series, double start, double end, string barTitle, TypeAdaptors.Category category, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            GetCategoryIndex(category);
            series.Items.Add(new IntervalBarItem(start, end, barTitle));
        }
    }

    public class LinearBarSeriesBuilder : SeriesBuilder<LinearBarSeries, DataPoint, double, double, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X", "Y" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false };
        public override int[] AxisItemIndexes => new[] { 0, 1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.linearBar", "oxy.lbar", "oxylbar" };

        protected override void AddDataPointToSeries(LinearBarSeries series, double x, double y, VoidT e3, VoidT e4, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Points.Add(new DataPoint(x, y));
        }
    }

    public class LineSeriesBuilder : SeriesBuilder<LineSeries, DataPoint, double, double, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X", "Y" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false };
        public override int[] AxisItemIndexes => new[] { 0, 1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.line", "oxyline" };

        protected override void AddDataPointToSeries(LineSeries series, double x, double y, VoidT e3, VoidT e4, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Points.Add(new DataPoint(x, y));
        }
    }

    public class PieSeriesBuilder : SeriesBuilder<PieSeries, PieSlice, string, double, OxyColor, bool, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "Label", "Value", "Fill", "IsExploded" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false };
        public override int[] AxisItemIndexes => new[] { -1, -1, -1, -1 };
        public override Type[] DefaultAxisTypes => new Type[] { null, null, null };
        public override string[] Aliases => new[] { "oxy.pie", "oxypie" };

        protected override void AddDataPointToSeries(PieSeries series, string label, double value, OxyColor fill, bool isExploded, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            var slice = new PieSlice(label, value);
            slice.Fill = fill;
            slice.IsExploded = isExploded;
            series.Slices.Add(slice);
        }
    }

    public class RectangleBarSeriesBuilder : SeriesBuilder<RectangleBarSeries, RectangleBarItem, double, double, double, double, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X0", "Y0", "X1", "Y1" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false };
        public override int[] AxisItemIndexes => new[] { 0, 1, -1, -1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.rectangleBar", "oxy.rbar", "oxyrbar" };

        protected override void AddDataPointToSeries(RectangleBarSeries series, double x0, double y0, double x1, double y1, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Items.Add(new RectangleBarItem(x0, y0, x1, y1));
        }
    }

    public class RectangleSeriesBuilder : SeriesBuilder<RectangleSeries, RectangleItem, double, double, double, double, double, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X1", "X2", "Y1", "Y2", "Value" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false, false };
        public override int[] AxisItemIndexes => new[] { 0, -1, 1, -1, -1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), typeof(LinearColorAxis) };
        public override string[] Aliases => new[] { "oxy.rectangle", "oxy.rec", "oxyrec" };

        protected override void AddDataPointToSeries(RectangleSeries series, double x1, double x2, double y1, double y2, double value, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Items.Add(new RectangleItem(x1, x2, y1, y2, value));
        }
    }

    public class ScatterSeriesBuilder : SeriesBuilder<ScatterSeries, ScatterPoint, double, double, double, double, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X", "Y", "Size", "Value" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false };
        public override int[] AxisItemIndexes => new[] { 0, 1, -1, -1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.scatter", "oxy.scat", "oxyscat" };

        protected override void AddDataPointToSeries(ScatterSeries series, double x, double y, double size, double value, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Points.Add(new ScatterPoint(x, y, size, value));
        }
    }

    public class ScatterErrorSeriesBuilder : SeriesBuilder<ScatterErrorSeries, ScatterPoint, double, double, double, double, double, double, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X", "Y", "ErrorX", "ErrorY", "Size", "Value" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false, false, false };
        public override int[] AxisItemIndexes => new[] { 0, 1, -1, -1, -1, -1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.scatterError", "oxy.scate", "oxyscate" };

        protected override void AddDataPointToSeries(ScatterErrorSeries series, double x, double y, double errorX, double errorY, double size, double value, VoidT e7, VoidT e8)
        {
            series.Points.Add(new ScatterErrorPoint(x, y, errorX, errorY, size, value));
        }
    }

    public class StairStepSeriesBuilder : SeriesBuilder<StairStepSeries, DataPoint, double, double, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X", "Y" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false };
        public override int[] AxisItemIndexes => new[] { 0, 1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.stairStep", "oxy.stair", "oxystair" };

        protected override void AddDataPointToSeries(StairStepSeries series, double x, double y, VoidT e3, VoidT e4, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Points.Add(new DataPoint(x, y));
        }
    }

    public class StemSeriesBuilder : SeriesBuilder<StemSeries, DataPoint, double, double, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X", "Y" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false };
        public override int[] AxisItemIndexes => new[] { 0, 1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.stem", "oxystem" };

        protected override void AddDataPointToSeries(StemSeries series, double x, double y, VoidT e3, VoidT e4, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Points.Add(new DataPoint(x, y));
        }
    }

    public class ThreeColorLineSeriesBuilder : SeriesBuilder<ThreeColorLineSeries, DataPoint, double, double, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X", "Y" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false };
        public override int[] AxisItemIndexes => new[] { 0, 1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.ThreeColorLine", "oxy.3cLine", "oxy3cline" };

        protected override void AddDataPointToSeries(ThreeColorLineSeries series, double x, double y, VoidT e3, VoidT e4, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Points.Add(new DataPoint(x, y));
        }
    }

    public class TornadoBarSeriesBuilder : CategorySeriesBuilder<TornadoBarSeries, TornadoBarItem, double, double, double, OxyColor, OxyColor, TypeAdaptors.Category, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "Minimum", "Maximum", "BarBaseValue", "MinimumColor", "MaximumColor", "Category" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false, false, false };
        public override int[] AxisItemIndexes => new[] { 0, -1, -1, -1, -1, -1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(CategoryAxis), null };
        public override string[] Aliases => new[] { "oxy.tornadoBar", "oxy.tornado", "oxytornado" };

        protected override void AddDataPointToSeries(TornadoBarSeries series, double minimum, double maximum, double barBaseValue, OxyColor minimumColor, OxyColor maximumColor, TypeAdaptors.Category category, VoidT e7, VoidT e8)
        {
            var item = new TornadoBarItem()
            {
                Minimum = minimum,
                Maximum = maximum,
                BaseValue = barBaseValue,
                MinimumColor = minimumColor,
                MaximumColor = maximumColor,
                CategoryIndex = GetCategoryIndex(category)
            };
            series.Items.Add(item);
        }
    }

    public class TwoColorAreaSeriesBuilder : SeriesBuilder<TwoColorAreaSeries, DataPoint, double, double, double, double, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X1", "Y1", "X2", "Y2" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false };
        public override int[] AxisItemIndexes => new[] { 0, 1, -1, -1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.twoColorArea", "oxy.2cArea", "oxy2carea" };

        protected override void AddDataPointToSeries(TwoColorAreaSeries series, double x1, double y1, double x2, double y2, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Points.Add(new DataPoint(x1, y1));
            if (!double.IsNaN(x2))
                series.Points2.Add(new DataPoint(x2, y2));
        }

        protected override void ValidateInputData()
        {
            if (_e1.Count > 0 && _e1.Count != _e2.Count)
                throw new ArgumentException($"Length of X1 and Y1 is different from each other");

            if (_e3.Count > 0 && _e3.Count != _e4.Count)
                throw new ArgumentException($"Length of X2 and Y2 is different from each other");
        }
    }

    public class TwoColorLineSeriesBuilder : SeriesBuilder<TwoColorLineSeries, DataPoint, double, double, VoidT, VoidT, VoidT, VoidT, VoidT, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X", "Y" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false };
        public override int[] AxisItemIndexes => new[] { 0, 1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.twoColorLine", "oxy.2cLine", "oxy2cline" };

        protected override void AddDataPointToSeries(TwoColorLineSeries series, double x, double y, VoidT e3, VoidT e4, VoidT e5, VoidT e6, VoidT e7, VoidT e8)
        {
            series.Points.Add(new DataPoint(x, y));
        }
    }

    public class VolumeSeriesBuilder : SeriesBuilder<VolumeSeries, OhlcvItem, double, double, double, double, double, double, double, VoidT>
    {
        public override string[] DataPointItemNames => new[] { "X", "Open", "High", "Low", "Close", "BuyVolume", "SellVolume" };
        public override bool[] DataPointItemMandatoriness => new[] { false, false, false, false, false, false, false };
        public override int[] AxisItemIndexes => new[] { 0, -1, -1, -1, 1, -1, -1 };
        public override Type[] DefaultAxisTypes => new[] { typeof(LinearAxis), typeof(LinearAxis), null };
        public override string[] Aliases => new[] { "oxy.volume", "oxyvolume" };

        protected override void AddDataPointToSeries(VolumeSeries series, double x, double open, double high, double low, double close, double buyVolume, double sellVolume, VoidT e8)
        {
            series.Items.Add(new OhlcvItem(x, open, high, low, close, buyVolume, sellVolume));
        }
    }
}
