
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using OxyPlot;
using OxyPlot.Series;
using Horker.PSOxyPlot.SeriesBuilders;
using Horker.PSOxyPlot.ObjectFactories;

namespace Horker.PSOxyPlot
{
    [Cmdlet("New", "OxyAreaSeries")]
    [Alias("oxy.area")]
    [OutputType(typeof(SeriesInfo<AreaSeries>))]
    public class NewOxyAreaSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string X0Name;

        [Parameter(Position = 2, Mandatory = false)]
        public string Y0Name;

        [Parameter(Position = 3, Mandatory = false)]
        public string X1Name;

        [Parameter(Position = 4, Mandatory = false)]
        public string Y1Name;

        [Parameter(Position = 5, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 6, Mandatory = false)]
        public System.Double[] X0;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double[] Y0;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double[] X1;

        [Parameter(Position = 9, Mandatory = false)]
        public System.Double[] Y1;

        [Parameter(Position = 10, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 11, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 12, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 13, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 14, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 15, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Double ConstantY2;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String DataFieldX2;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String DataFieldY2;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color2;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Boolean Reverse2;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Double BrokenLineThickness;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Double[] Dashes;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Double LabelMargin;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 31, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 32, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 34, Mandatory = false)]
        public OxyPlot.ScreenPoint[] MarkerOutline;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Double MarkerSize;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Double MarkerStrokeThickness;

        [Parameter(Position = 39, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Double MinimumSegmentLength;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Boolean Smooth;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Double StrokeThickness;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Boolean CanTrackerInterpolatePoints;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 51, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 56, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 57, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 58, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 59, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 62, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 63, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private AreaSeriesBuilder _builder;

        private void AssignParameters(AreaSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("ConstantY2")) series.ConstantY2 = ConstantY2;
            if (bp.ContainsKey("DataFieldX2")) series.DataFieldX2 = DataFieldX2;
            if (bp.ContainsKey("DataFieldY2")) series.DataFieldY2 = DataFieldY2;
            if (bp.ContainsKey("Color2")) series.Color2 = Color2;
            if (bp.ContainsKey("Fill")) series.Fill = Fill;
            if (bp.ContainsKey("Reverse2")) series.Reverse2 = Reverse2;
            if (bp.ContainsKey("Color")) series.Color = Color;
            if (bp.ContainsKey("BrokenLineColor")) series.BrokenLineColor = BrokenLineColor;
            if (bp.ContainsKey("BrokenLineStyle")) series.BrokenLineStyle = BrokenLineStyle;
            if (bp.ContainsKey("BrokenLineThickness")) series.BrokenLineThickness = BrokenLineThickness;
            if (bp.ContainsKey("Dashes")) series.Dashes = Dashes;
            if (bp.ContainsKey("Decimator")) series.Decimator = Decimator;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("LineJoin")) series.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) series.LineStyle = LineStyle;
            if (bp.ContainsKey("LineLegendPosition")) series.LineLegendPosition = LineLegendPosition;
            if (bp.ContainsKey("MarkerFill")) series.MarkerFill = MarkerFill;
            if (bp.ContainsKey("MarkerOutline")) series.MarkerOutline = MarkerOutline;
            if (bp.ContainsKey("MarkerResolution")) series.MarkerResolution = MarkerResolution;
            if (bp.ContainsKey("MarkerSize")) series.MarkerSize = MarkerSize;
            if (bp.ContainsKey("MarkerStroke")) series.MarkerStroke = MarkerStroke;
            if (bp.ContainsKey("MarkerStrokeThickness")) series.MarkerStrokeThickness = MarkerStrokeThickness;
            if (bp.ContainsKey("MarkerType")) series.MarkerType = MarkerType;
            if (bp.ContainsKey("MinimumSegmentLength")) series.MinimumSegmentLength = MinimumSegmentLength;
            if (bp.ContainsKey("Smooth")) series.Smooth = Smooth;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("CanTrackerInterpolatePoints")) series.CanTrackerInterpolatePoints = CanTrackerInterpolatePoints;
            if (bp.ContainsKey("DataFieldX")) series.DataFieldX = DataFieldX;
            if (bp.ContainsKey("DataFieldY")) series.DataFieldY = DataFieldY;
            if (bp.ContainsKey("Mapping")) series.Mapping = Mapping;
            if (bp.ContainsKey("XAxisKey")) series.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) series.YAxisKey = YAxisKey;
            if (bp.ContainsKey("ItemsSource")) series.ItemsSource = ItemsSource;
            if (bp.ContainsKey("Background")) series.Background = Background;
            if (bp.ContainsKey("IsVisible")) series.IsVisible = IsVisible;
            if (bp.ContainsKey("Title")) series.Title = Title;
            if (bp.ContainsKey("RenderInLegend")) series.RenderInLegend = RenderInLegend;
            if (bp.ContainsKey("TrackerFormatString")) series.TrackerFormatString = TrackerFormatString;
            if (bp.ContainsKey("TrackerKey")) series.TrackerKey = TrackerKey;
            if (bp.ContainsKey("Font")) series.Font = Font;
            if (bp.ContainsKey("FontSize")) series.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) series.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) series.Tag = Tag;
            if (bp.ContainsKey("TextColor")) series.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) series.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) series.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) series.SelectionMode = SelectionMode;
        }

        protected override void BeginProcessing()
        {
            _builder = new AreaSeriesBuilder();
            _builder.ReadBoundParameters(MyInvocation.BoundParameters);
        }

        protected override void ProcessRecord()
        {
            // ProcessRecord is called once when InputObject is not given at all.
            if (InputObject == null)
                return;

            _builder.ReadPSObject(InputObject);
        }

        protected override void EndProcessing()
        {
            var si = _builder.CreateSeriesInfo();

            var bp = MyInvocation.BoundParameters;
            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PlotModel model = AddTo;
            if (model == null && bp.ContainsKey("OutFile"))
                model = ObjectFactory.CreatePlotModel(si);

            if (model != null)
            {
                foreach (var s in si.Series)
                    model.Series.Add(s);
            }
            else
                WriteObject(si);

            if (bp.ContainsKey("OutFile"))
                ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

    [Cmdlet("New", "OxyBarSeries")]
    [Alias("oxy.bar")]
    [OutputType(typeof(SeriesInfo<BarSeries>))]
    public class NewOxyBarSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string ValueName;

        [Parameter(Position = 2, Mandatory = false)]
        public string CategoryName;

        [Parameter(Position = 3, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 4, Mandatory = false)]
        public System.Double[] Value;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Category[] Category;

        [Parameter(Position = 6, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 7, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 8, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 9, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 10, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 11, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 12, Mandatory = false)]
        public System.Double BarWidth;

        [Parameter(Position = 13, Mandatory = false)]
        public System.Double BaseValue;

        [Parameter(Position = 14, Mandatory = false)]
        public System.String ColorField;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Boolean IsStacked;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Double LabelMargin;

        [Parameter(Position = 19, Mandatory = false)]
        public OxyPlot.Series.LabelPlacement LabelPlacement;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor NegativeFillColor;

        [Parameter(Position = 21, Mandatory = false)]
        public System.String StackGroup;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Double StrokeThickness;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String ValueField;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 41, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private BarSeriesBuilder _builder;

        private void AssignParameters(BarSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("BarWidth")) series.BarWidth = BarWidth;
            if (bp.ContainsKey("BaseValue")) series.BaseValue = BaseValue;
            if (bp.ContainsKey("ColorField")) series.ColorField = ColorField;
            if (bp.ContainsKey("FillColor")) series.FillColor = FillColor;
            if (bp.ContainsKey("IsStacked")) series.IsStacked = IsStacked;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("LabelPlacement")) series.LabelPlacement = LabelPlacement;
            if (bp.ContainsKey("NegativeFillColor")) series.NegativeFillColor = NegativeFillColor;
            if (bp.ContainsKey("StackGroup")) series.StackGroup = StackGroup;
            if (bp.ContainsKey("StrokeColor")) series.StrokeColor = StrokeColor;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("ValueField")) series.ValueField = ValueField;
            if (bp.ContainsKey("XAxisKey")) series.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) series.YAxisKey = YAxisKey;
            if (bp.ContainsKey("ItemsSource")) series.ItemsSource = ItemsSource;
            if (bp.ContainsKey("Background")) series.Background = Background;
            if (bp.ContainsKey("IsVisible")) series.IsVisible = IsVisible;
            if (bp.ContainsKey("Title")) series.Title = Title;
            if (bp.ContainsKey("RenderInLegend")) series.RenderInLegend = RenderInLegend;
            if (bp.ContainsKey("TrackerFormatString")) series.TrackerFormatString = TrackerFormatString;
            if (bp.ContainsKey("TrackerKey")) series.TrackerKey = TrackerKey;
            if (bp.ContainsKey("Font")) series.Font = Font;
            if (bp.ContainsKey("FontSize")) series.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) series.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) series.Tag = Tag;
            if (bp.ContainsKey("TextColor")) series.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) series.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) series.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) series.SelectionMode = SelectionMode;
        }

        protected override void BeginProcessing()
        {
            _builder = new BarSeriesBuilder();
            _builder.ReadBoundParameters(MyInvocation.BoundParameters);
        }

        protected override void ProcessRecord()
        {
            // ProcessRecord is called once when InputObject is not given at all.
            if (InputObject == null)
                return;

            _builder.ReadPSObject(InputObject);
        }

        protected override void EndProcessing()
        {
            var si = _builder.CreateSeriesInfo();

            var bp = MyInvocation.BoundParameters;
            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PlotModel model = AddTo;
            if (model == null && bp.ContainsKey("OutFile"))
                model = ObjectFactory.CreatePlotModel(si);

            if (model != null)
            {
                foreach (var s in si.Series)
                    model.Series.Add(s);
            }
            else
                WriteObject(si);

            if (bp.ContainsKey("OutFile"))
                ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

    [Cmdlet("New", "OxyCandleStickSeries")]
    [Alias("oxy.candleStick")]
    [OutputType(typeof(SeriesInfo<CandleStickSeries>))]
    public class NewOxyCandleStickSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName;

        [Parameter(Position = 2, Mandatory = false)]
        public string HighName;

        [Parameter(Position = 3, Mandatory = false)]
        public string LowName;

        [Parameter(Position = 4, Mandatory = false)]
        public string OpenName;

        [Parameter(Position = 5, Mandatory = false)]
        public string CloseName;

        [Parameter(Position = 6, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double[] X;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double[] High;

        [Parameter(Position = 9, Mandatory = false)]
        public System.Double[] Low;

        [Parameter(Position = 10, Mandatory = false)]
        public System.Double[] Open;

        [Parameter(Position = 11, Mandatory = false)]
        public System.Double[] Close;

        [Parameter(Position = 12, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 13, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 14, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 15, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 16, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 17, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor IncreasingColor;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor DecreasingColor;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Double CandleWidth;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Double[] Dashes;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String DataFieldClose;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String DataFieldHigh;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String DataFieldLow;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String DataFieldOpen;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 28, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 29, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.Series.HighLowItem> Mapping;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Double StrokeThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Double TickLength;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 48, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 49, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private CandleStickSeriesBuilder _builder;

        private void AssignParameters(CandleStickSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("IncreasingColor")) series.IncreasingColor = IncreasingColor;
            if (bp.ContainsKey("DecreasingColor")) series.DecreasingColor = DecreasingColor;
            if (bp.ContainsKey("CandleWidth")) series.CandleWidth = CandleWidth;
            if (bp.ContainsKey("Color")) series.Color = Color;
            if (bp.ContainsKey("Dashes")) series.Dashes = Dashes;
            if (bp.ContainsKey("DataFieldClose")) series.DataFieldClose = DataFieldClose;
            if (bp.ContainsKey("DataFieldHigh")) series.DataFieldHigh = DataFieldHigh;
            if (bp.ContainsKey("DataFieldLow")) series.DataFieldLow = DataFieldLow;
            if (bp.ContainsKey("DataFieldOpen")) series.DataFieldOpen = DataFieldOpen;
            if (bp.ContainsKey("DataFieldX")) series.DataFieldX = DataFieldX;
            if (bp.ContainsKey("LineJoin")) series.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) series.LineStyle = LineStyle;
            if (bp.ContainsKey("Mapping")) series.Mapping = Mapping;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("TickLength")) series.TickLength = TickLength;
            if (bp.ContainsKey("XAxisKey")) series.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) series.YAxisKey = YAxisKey;
            if (bp.ContainsKey("ItemsSource")) series.ItemsSource = ItemsSource;
            if (bp.ContainsKey("Background")) series.Background = Background;
            if (bp.ContainsKey("IsVisible")) series.IsVisible = IsVisible;
            if (bp.ContainsKey("Title")) series.Title = Title;
            if (bp.ContainsKey("RenderInLegend")) series.RenderInLegend = RenderInLegend;
            if (bp.ContainsKey("TrackerFormatString")) series.TrackerFormatString = TrackerFormatString;
            if (bp.ContainsKey("TrackerKey")) series.TrackerKey = TrackerKey;
            if (bp.ContainsKey("Font")) series.Font = Font;
            if (bp.ContainsKey("FontSize")) series.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) series.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) series.Tag = Tag;
            if (bp.ContainsKey("TextColor")) series.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) series.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) series.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) series.SelectionMode = SelectionMode;
        }

        protected override void BeginProcessing()
        {
            _builder = new CandleStickSeriesBuilder();
            _builder.ReadBoundParameters(MyInvocation.BoundParameters);
        }

        protected override void ProcessRecord()
        {
            // ProcessRecord is called once when InputObject is not given at all.
            if (InputObject == null)
                return;

            _builder.ReadPSObject(InputObject);
        }

        protected override void EndProcessing()
        {
            var si = _builder.CreateSeriesInfo();

            var bp = MyInvocation.BoundParameters;
            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PlotModel model = AddTo;
            if (model == null && bp.ContainsKey("OutFile"))
                model = ObjectFactory.CreatePlotModel(si);

            if (model != null)
            {
                foreach (var s in si.Series)
                    model.Series.Add(s);
            }
            else
                WriteObject(si);

            if (bp.ContainsKey("OutFile"))
                ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

    [Cmdlet("New", "OxyCandleStickAndVolumeSeries")]
    [Alias("oxy.candleStickAndVolume")]
    [OutputType(typeof(SeriesInfo<CandleStickAndVolumeSeries>))]
    public class NewOxyCandleStickAndVolumeSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName;

        [Parameter(Position = 2, Mandatory = false)]
        public string OpenName;

        [Parameter(Position = 3, Mandatory = false)]
        public string HighName;

        [Parameter(Position = 4, Mandatory = false)]
        public string LowName;

        [Parameter(Position = 5, Mandatory = false)]
        public string CloseName;

        [Parameter(Position = 6, Mandatory = false)]
        public string BuyVolumeName;

        [Parameter(Position = 7, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double[] X;

        [Parameter(Position = 9, Mandatory = false)]
        public System.Double[] Open;

        [Parameter(Position = 10, Mandatory = false)]
        public System.Double[] High;

        [Parameter(Position = 11, Mandatory = false)]
        public System.Double[] Low;

        [Parameter(Position = 12, Mandatory = false)]
        public System.Double[] Close;

        [Parameter(Position = 13, Mandatory = false)]
        public System.Double[] BuyVolume;

        [Parameter(Position = 14, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 15, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 16, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 17, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 18, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 19, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Collections.Generic.List<OxyPlot.Series.OhlcvItem> Items;

        [Parameter(Position = 21, Mandatory = false)]
        public System.String VolumeAxisKey;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String BarAxisKey;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.Series.VolumeStyle VolumeStyle;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Double StrokeThickness;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Double StrokeIntensity;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Double SeparatorStrokeThickness;

        [Parameter(Position = 27, Mandatory = false)]
        public OxyPlot.LineStyle SeparatorLineStyle;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor PositiveColor;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor NegativeColor;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor SeparatorColor;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Boolean PositiveHollow;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Boolean NegativeHollow;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Double CandleWidth;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 50, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private CandleStickAndVolumeSeriesBuilder _builder;

        private void AssignParameters(CandleStickAndVolumeSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("Items")) series.Items = Items;
            if (bp.ContainsKey("VolumeAxisKey")) series.VolumeAxisKey = VolumeAxisKey;
            if (bp.ContainsKey("BarAxisKey")) series.BarAxisKey = BarAxisKey;
            if (bp.ContainsKey("VolumeStyle")) series.VolumeStyle = VolumeStyle;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("StrokeIntensity")) series.StrokeIntensity = StrokeIntensity;
            if (bp.ContainsKey("SeparatorStrokeThickness")) series.SeparatorStrokeThickness = SeparatorStrokeThickness;
            if (bp.ContainsKey("SeparatorLineStyle")) series.SeparatorLineStyle = SeparatorLineStyle;
            if (bp.ContainsKey("PositiveColor")) series.PositiveColor = PositiveColor;
            if (bp.ContainsKey("NegativeColor")) series.NegativeColor = NegativeColor;
            if (bp.ContainsKey("SeparatorColor")) series.SeparatorColor = SeparatorColor;
            if (bp.ContainsKey("PositiveHollow")) series.PositiveHollow = PositiveHollow;
            if (bp.ContainsKey("NegativeHollow")) series.NegativeHollow = NegativeHollow;
            if (bp.ContainsKey("CandleWidth")) series.CandleWidth = CandleWidth;
            if (bp.ContainsKey("XAxisKey")) series.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) series.YAxisKey = YAxisKey;
            if (bp.ContainsKey("ItemsSource")) series.ItemsSource = ItemsSource;
            if (bp.ContainsKey("Background")) series.Background = Background;
            if (bp.ContainsKey("IsVisible")) series.IsVisible = IsVisible;
            if (bp.ContainsKey("Title")) series.Title = Title;
            if (bp.ContainsKey("RenderInLegend")) series.RenderInLegend = RenderInLegend;
            if (bp.ContainsKey("TrackerFormatString")) series.TrackerFormatString = TrackerFormatString;
            if (bp.ContainsKey("TrackerKey")) series.TrackerKey = TrackerKey;
            if (bp.ContainsKey("Font")) series.Font = Font;
            if (bp.ContainsKey("FontSize")) series.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) series.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) series.Tag = Tag;
            if (bp.ContainsKey("TextColor")) series.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) series.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) series.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) series.SelectionMode = SelectionMode;
        }

        protected override void BeginProcessing()
        {
            _builder = new CandleStickAndVolumeSeriesBuilder();
            _builder.ReadBoundParameters(MyInvocation.BoundParameters);
        }

        protected override void ProcessRecord()
        {
            // ProcessRecord is called once when InputObject is not given at all.
            if (InputObject == null)
                return;

            _builder.ReadPSObject(InputObject);
        }

        protected override void EndProcessing()
        {
            var si = _builder.CreateSeriesInfo();

            var bp = MyInvocation.BoundParameters;
            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PlotModel model = AddTo;
            if (model == null && bp.ContainsKey("OutFile"))
                model = ObjectFactory.CreatePlotModel(si);

            if (model != null)
            {
                foreach (var s in si.Series)
                    model.Series.Add(s);
            }
            else
                WriteObject(si);

            if (bp.ContainsKey("OutFile"))
                ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

    [Cmdlet("New", "OxyColumnSeries")]
    [Alias("oxy.column")]
    [OutputType(typeof(SeriesInfo<ColumnSeries>))]
    public class NewOxyColumnSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string ValueName;

        [Parameter(Position = 2, Mandatory = false)]
        public string CategoryName;

        [Parameter(Position = 3, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 4, Mandatory = false)]
        public System.Double[] Value;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Category[] Category;

        [Parameter(Position = 6, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 7, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 8, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 9, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 10, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 11, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 12, Mandatory = false)]
        public System.Double ColumnWidth;

        [Parameter(Position = 13, Mandatory = false)]
        public System.Double BaseValue;

        [Parameter(Position = 14, Mandatory = false)]
        public System.String ColorField;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Boolean IsStacked;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Double LabelMargin;

        [Parameter(Position = 19, Mandatory = false)]
        public OxyPlot.Series.LabelPlacement LabelPlacement;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor NegativeFillColor;

        [Parameter(Position = 21, Mandatory = false)]
        public System.String StackGroup;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Double StrokeThickness;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String ValueField;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 41, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private ColumnSeriesBuilder _builder;

        private void AssignParameters(ColumnSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("ColumnWidth")) series.ColumnWidth = ColumnWidth;
            if (bp.ContainsKey("BaseValue")) series.BaseValue = BaseValue;
            if (bp.ContainsKey("ColorField")) series.ColorField = ColorField;
            if (bp.ContainsKey("FillColor")) series.FillColor = FillColor;
            if (bp.ContainsKey("IsStacked")) series.IsStacked = IsStacked;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("LabelPlacement")) series.LabelPlacement = LabelPlacement;
            if (bp.ContainsKey("NegativeFillColor")) series.NegativeFillColor = NegativeFillColor;
            if (bp.ContainsKey("StackGroup")) series.StackGroup = StackGroup;
            if (bp.ContainsKey("StrokeColor")) series.StrokeColor = StrokeColor;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("ValueField")) series.ValueField = ValueField;
            if (bp.ContainsKey("XAxisKey")) series.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) series.YAxisKey = YAxisKey;
            if (bp.ContainsKey("ItemsSource")) series.ItemsSource = ItemsSource;
            if (bp.ContainsKey("Background")) series.Background = Background;
            if (bp.ContainsKey("IsVisible")) series.IsVisible = IsVisible;
            if (bp.ContainsKey("Title")) series.Title = Title;
            if (bp.ContainsKey("RenderInLegend")) series.RenderInLegend = RenderInLegend;
            if (bp.ContainsKey("TrackerFormatString")) series.TrackerFormatString = TrackerFormatString;
            if (bp.ContainsKey("TrackerKey")) series.TrackerKey = TrackerKey;
            if (bp.ContainsKey("Font")) series.Font = Font;
            if (bp.ContainsKey("FontSize")) series.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) series.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) series.Tag = Tag;
            if (bp.ContainsKey("TextColor")) series.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) series.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) series.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) series.SelectionMode = SelectionMode;
        }

        protected override void BeginProcessing()
        {
            _builder = new ColumnSeriesBuilder();
            _builder.ReadBoundParameters(MyInvocation.BoundParameters);
        }

        protected override void ProcessRecord()
        {
            // ProcessRecord is called once when InputObject is not given at all.
            if (InputObject == null)
                return;

            _builder.ReadPSObject(InputObject);
        }

        protected override void EndProcessing()
        {
            var si = _builder.CreateSeriesInfo();

            var bp = MyInvocation.BoundParameters;
            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PlotModel model = AddTo;
            if (model == null && bp.ContainsKey("OutFile"))
                model = ObjectFactory.CreatePlotModel(si);

            if (model != null)
            {
                foreach (var s in si.Series)
                    model.Series.Add(s);
            }
            else
                WriteObject(si);

            if (bp.ContainsKey("OutFile"))
                ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

    [Cmdlet("New", "OxyContourSeries")]
    [Alias("oxy.contour")]
    [OutputType(typeof(SeriesInfo<ContourSeries>))]
    public class NewOxyContourSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName;

        [Parameter(Position = 2, Mandatory = false)]
        public string YName;

        [Parameter(Position = 3, Mandatory = false)]
        public string ZName;

        [Parameter(Position = 4, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 5, Mandatory = false)]
        public System.Double[] X;

        [Parameter(Position = 6, Mandatory = false)]
        public System.Double[] Y;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double[] Z;

        [Parameter(Position = 8, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 9, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 10, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 11, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 12, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 13, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 15, Mandatory = false)]
        public System.Double[] ColumnCoordinates;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Double ContourLevelStep;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Double[] ContourLevels;

        [Parameter(Position = 18, Mandatory = false)]
        public OxyPlot.OxyColor[] ContourColors;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Double[,] Data;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LabelBackground;

        [Parameter(Position = 21, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Double LabelSpacing;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Int32 LabelStep;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Double[] RowCoordinates;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Double StrokeThickness;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 43, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private ContourSeriesBuilder _builder;

        private void AssignParameters(ContourSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("Color")) series.Color = Color;
            if (bp.ContainsKey("ColumnCoordinates")) series.ColumnCoordinates = ColumnCoordinates;
            if (bp.ContainsKey("ContourLevelStep")) series.ContourLevelStep = ContourLevelStep;
            if (bp.ContainsKey("ContourLevels")) series.ContourLevels = ContourLevels;
            if (bp.ContainsKey("ContourColors")) series.ContourColors = ContourColors;
            if (bp.ContainsKey("Data")) series.Data = Data;
            if (bp.ContainsKey("LabelBackground")) series.LabelBackground = LabelBackground;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelSpacing")) series.LabelSpacing = LabelSpacing;
            if (bp.ContainsKey("LabelStep")) series.LabelStep = LabelStep;
            if (bp.ContainsKey("LineStyle")) series.LineStyle = LineStyle;
            if (bp.ContainsKey("RowCoordinates")) series.RowCoordinates = RowCoordinates;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("XAxisKey")) series.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) series.YAxisKey = YAxisKey;
            if (bp.ContainsKey("ItemsSource")) series.ItemsSource = ItemsSource;
            if (bp.ContainsKey("Background")) series.Background = Background;
            if (bp.ContainsKey("IsVisible")) series.IsVisible = IsVisible;
            if (bp.ContainsKey("Title")) series.Title = Title;
            if (bp.ContainsKey("RenderInLegend")) series.RenderInLegend = RenderInLegend;
            if (bp.ContainsKey("TrackerFormatString")) series.TrackerFormatString = TrackerFormatString;
            if (bp.ContainsKey("TrackerKey")) series.TrackerKey = TrackerKey;
            if (bp.ContainsKey("Font")) series.Font = Font;
            if (bp.ContainsKey("FontSize")) series.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) series.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) series.Tag = Tag;
            if (bp.ContainsKey("TextColor")) series.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) series.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) series.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) series.SelectionMode = SelectionMode;
        }

        protected override void BeginProcessing()
        {
            _builder = new ContourSeriesBuilder();
            _builder.ReadBoundParameters(MyInvocation.BoundParameters);
        }

        protected override void ProcessRecord()
        {
            // ProcessRecord is called once when InputObject is not given at all.
            if (InputObject == null)
                return;

            _builder.ReadPSObject(InputObject);
        }

        protected override void EndProcessing()
        {
            var si = _builder.CreateSeriesInfo();

            var bp = MyInvocation.BoundParameters;
            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PlotModel model = AddTo;
            if (model == null && bp.ContainsKey("OutFile"))
                model = ObjectFactory.CreatePlotModel(si);

            if (model != null)
            {
                foreach (var s in si.Series)
                    model.Series.Add(s);
            }
            else
                WriteObject(si);

            if (bp.ContainsKey("OutFile"))
                ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

    [Cmdlet("New", "OxyErrorColumnSeries")]
    [Alias("oxy.errorColumn")]
    [OutputType(typeof(SeriesInfo<ErrorColumnSeries>))]
    public class NewOxyErrorColumnSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string ValueName;

        [Parameter(Position = 2, Mandatory = false)]
        public string ErrorName;

        [Parameter(Position = 3, Mandatory = false)]
        public string CategoryName;

        [Parameter(Position = 4, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 5, Mandatory = false)]
        public System.Double[] Value;

        [Parameter(Position = 6, Mandatory = false)]
        public System.Double[] Error;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Category[] Category;

        [Parameter(Position = 8, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 9, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 10, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 11, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 12, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 13, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 14, Mandatory = false)]
        public System.Double ErrorStrokeThickness;

        [Parameter(Position = 15, Mandatory = false)]
        public System.Double ErrorWidth;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Double ColumnWidth;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Double BaseValue;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String ColorField;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Boolean IsStacked;

        [Parameter(Position = 21, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Double LabelMargin;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.Series.LabelPlacement LabelPlacement;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor NegativeFillColor;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String StackGroup;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Double StrokeThickness;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String ValueField;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 45, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private ErrorColumnSeriesBuilder _builder;

        private void AssignParameters(ErrorColumnSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("ErrorStrokeThickness")) series.ErrorStrokeThickness = ErrorStrokeThickness;
            if (bp.ContainsKey("ErrorWidth")) series.ErrorWidth = ErrorWidth;
            if (bp.ContainsKey("ColumnWidth")) series.ColumnWidth = ColumnWidth;
            if (bp.ContainsKey("BaseValue")) series.BaseValue = BaseValue;
            if (bp.ContainsKey("ColorField")) series.ColorField = ColorField;
            if (bp.ContainsKey("FillColor")) series.FillColor = FillColor;
            if (bp.ContainsKey("IsStacked")) series.IsStacked = IsStacked;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("LabelPlacement")) series.LabelPlacement = LabelPlacement;
            if (bp.ContainsKey("NegativeFillColor")) series.NegativeFillColor = NegativeFillColor;
            if (bp.ContainsKey("StackGroup")) series.StackGroup = StackGroup;
            if (bp.ContainsKey("StrokeColor")) series.StrokeColor = StrokeColor;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("ValueField")) series.ValueField = ValueField;
            if (bp.ContainsKey("XAxisKey")) series.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) series.YAxisKey = YAxisKey;
            if (bp.ContainsKey("ItemsSource")) series.ItemsSource = ItemsSource;
            if (bp.ContainsKey("Background")) series.Background = Background;
            if (bp.ContainsKey("IsVisible")) series.IsVisible = IsVisible;
            if (bp.ContainsKey("Title")) series.Title = Title;
            if (bp.ContainsKey("RenderInLegend")) series.RenderInLegend = RenderInLegend;
            if (bp.ContainsKey("TrackerFormatString")) series.TrackerFormatString = TrackerFormatString;
            if (bp.ContainsKey("TrackerKey")) series.TrackerKey = TrackerKey;
            if (bp.ContainsKey("Font")) series.Font = Font;
            if (bp.ContainsKey("FontSize")) series.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) series.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) series.Tag = Tag;
            if (bp.ContainsKey("TextColor")) series.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) series.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) series.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) series.SelectionMode = SelectionMode;
        }

        protected override void BeginProcessing()
        {
            _builder = new ErrorColumnSeriesBuilder();
            _builder.ReadBoundParameters(MyInvocation.BoundParameters);
        }

        protected override void ProcessRecord()
        {
            // ProcessRecord is called once when InputObject is not given at all.
            if (InputObject == null)
                return;

            _builder.ReadPSObject(InputObject);
        }

        protected override void EndProcessing()
        {
            var si = _builder.CreateSeriesInfo();

            var bp = MyInvocation.BoundParameters;
            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PlotModel model = AddTo;
            if (model == null && bp.ContainsKey("OutFile"))
                model = ObjectFactory.CreatePlotModel(si);

            if (model != null)
            {
                foreach (var s in si.Series)
                    model.Series.Add(s);
            }
            else
                WriteObject(si);

            if (bp.ContainsKey("OutFile"))
                ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

    [Cmdlet("New", "OxyIntervalBarSeries")]
    [Alias("oxy.intervalBar")]
    [OutputType(typeof(SeriesInfo<IntervalBarSeries>))]
    public class NewOxyIntervalBarSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string StartName;

        [Parameter(Position = 2, Mandatory = false)]
        public string EndName;

        [Parameter(Position = 3, Mandatory = false)]
        public string BarTitleName;

        [Parameter(Position = 4, Mandatory = false)]
        public string CategoryName;

        [Parameter(Position = 5, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 6, Mandatory = false)]
        public System.Double[] Start;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double[] End;

        [Parameter(Position = 8, Mandatory = false)]
        public System.String[] BarTitle;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Category[] Category;

        [Parameter(Position = 10, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 11, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 12, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 13, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 14, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 15, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Double BarWidth;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LabelColor;

        [Parameter(Position = 19, Mandatory = false)]
        public System.String LabelField;

        [Parameter(Position = 20, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Double LabelMargin;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String MaximumField;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String MinimumField;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Double StrokeThickness;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 42, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private IntervalBarSeriesBuilder _builder;

        private void AssignParameters(IntervalBarSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("BarWidth")) series.BarWidth = BarWidth;
            if (bp.ContainsKey("FillColor")) series.FillColor = FillColor;
            if (bp.ContainsKey("LabelColor")) series.LabelColor = LabelColor;
            if (bp.ContainsKey("LabelField")) series.LabelField = LabelField;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("MaximumField")) series.MaximumField = MaximumField;
            if (bp.ContainsKey("MinimumField")) series.MinimumField = MinimumField;
            if (bp.ContainsKey("StrokeColor")) series.StrokeColor = StrokeColor;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("XAxisKey")) series.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) series.YAxisKey = YAxisKey;
            if (bp.ContainsKey("ItemsSource")) series.ItemsSource = ItemsSource;
            if (bp.ContainsKey("Background")) series.Background = Background;
            if (bp.ContainsKey("IsVisible")) series.IsVisible = IsVisible;
            if (bp.ContainsKey("Title")) series.Title = Title;
            if (bp.ContainsKey("RenderInLegend")) series.RenderInLegend = RenderInLegend;
            if (bp.ContainsKey("TrackerFormatString")) series.TrackerFormatString = TrackerFormatString;
            if (bp.ContainsKey("TrackerKey")) series.TrackerKey = TrackerKey;
            if (bp.ContainsKey("Font")) series.Font = Font;
            if (bp.ContainsKey("FontSize")) series.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) series.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) series.Tag = Tag;
            if (bp.ContainsKey("TextColor")) series.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) series.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) series.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) series.SelectionMode = SelectionMode;
        }

        protected override void BeginProcessing()
        {
            _builder = new IntervalBarSeriesBuilder();
            _builder.ReadBoundParameters(MyInvocation.BoundParameters);
        }

        protected override void ProcessRecord()
        {
            // ProcessRecord is called once when InputObject is not given at all.
            if (InputObject == null)
                return;

            _builder.ReadPSObject(InputObject);
        }

        protected override void EndProcessing()
        {
            var si = _builder.CreateSeriesInfo();

            var bp = MyInvocation.BoundParameters;
            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PlotModel model = AddTo;
            if (model == null && bp.ContainsKey("OutFile"))
                model = ObjectFactory.CreatePlotModel(si);

            if (model != null)
            {
                foreach (var s in si.Series)
                    model.Series.Add(s);
            }
            else
                WriteObject(si);

            if (bp.ContainsKey("OutFile"))
                ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

    [Cmdlet("New", "OxyLineSeries")]
    [Alias("oxy.line")]
    [OutputType(typeof(SeriesInfo<LineSeries>))]
    public class NewOxyLineSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName;

        [Parameter(Position = 2, Mandatory = false)]
        public string YName;

        [Parameter(Position = 3, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 4, Mandatory = false)]
        public System.Double[] X;

        [Parameter(Position = 5, Mandatory = false)]
        public System.Double[] Y;

        [Parameter(Position = 6, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 7, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 8, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 9, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 10, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 11, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 14, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 15, Mandatory = false)]
        public System.Double BrokenLineThickness;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Double[] Dashes;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Double LabelMargin;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 22, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.ScreenPoint[] MarkerOutline;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Double MarkerSize;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Double MarkerStrokeThickness;

        [Parameter(Position = 29, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Double MinimumSegmentLength;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Boolean Smooth;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Double StrokeThickness;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Boolean CanTrackerInterpolatePoints;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 48, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 52, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private LineSeriesBuilder _builder;

        private void AssignParameters(LineSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("Color")) series.Color = Color;
            if (bp.ContainsKey("BrokenLineColor")) series.BrokenLineColor = BrokenLineColor;
            if (bp.ContainsKey("BrokenLineStyle")) series.BrokenLineStyle = BrokenLineStyle;
            if (bp.ContainsKey("BrokenLineThickness")) series.BrokenLineThickness = BrokenLineThickness;
            if (bp.ContainsKey("Dashes")) series.Dashes = Dashes;
            if (bp.ContainsKey("Decimator")) series.Decimator = Decimator;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("LineJoin")) series.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) series.LineStyle = LineStyle;
            if (bp.ContainsKey("LineLegendPosition")) series.LineLegendPosition = LineLegendPosition;
            if (bp.ContainsKey("MarkerFill")) series.MarkerFill = MarkerFill;
            if (bp.ContainsKey("MarkerOutline")) series.MarkerOutline = MarkerOutline;
            if (bp.ContainsKey("MarkerResolution")) series.MarkerResolution = MarkerResolution;
            if (bp.ContainsKey("MarkerSize")) series.MarkerSize = MarkerSize;
            if (bp.ContainsKey("MarkerStroke")) series.MarkerStroke = MarkerStroke;
            if (bp.ContainsKey("MarkerStrokeThickness")) series.MarkerStrokeThickness = MarkerStrokeThickness;
            if (bp.ContainsKey("MarkerType")) series.MarkerType = MarkerType;
            if (bp.ContainsKey("MinimumSegmentLength")) series.MinimumSegmentLength = MinimumSegmentLength;
            if (bp.ContainsKey("Smooth")) series.Smooth = Smooth;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("CanTrackerInterpolatePoints")) series.CanTrackerInterpolatePoints = CanTrackerInterpolatePoints;
            if (bp.ContainsKey("DataFieldX")) series.DataFieldX = DataFieldX;
            if (bp.ContainsKey("DataFieldY")) series.DataFieldY = DataFieldY;
            if (bp.ContainsKey("Mapping")) series.Mapping = Mapping;
            if (bp.ContainsKey("XAxisKey")) series.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) series.YAxisKey = YAxisKey;
            if (bp.ContainsKey("ItemsSource")) series.ItemsSource = ItemsSource;
            if (bp.ContainsKey("Background")) series.Background = Background;
            if (bp.ContainsKey("IsVisible")) series.IsVisible = IsVisible;
            if (bp.ContainsKey("Title")) series.Title = Title;
            if (bp.ContainsKey("RenderInLegend")) series.RenderInLegend = RenderInLegend;
            if (bp.ContainsKey("TrackerFormatString")) series.TrackerFormatString = TrackerFormatString;
            if (bp.ContainsKey("TrackerKey")) series.TrackerKey = TrackerKey;
            if (bp.ContainsKey("Font")) series.Font = Font;
            if (bp.ContainsKey("FontSize")) series.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) series.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) series.Tag = Tag;
            if (bp.ContainsKey("TextColor")) series.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) series.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) series.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) series.SelectionMode = SelectionMode;
        }

        protected override void BeginProcessing()
        {
            _builder = new LineSeriesBuilder();
            _builder.ReadBoundParameters(MyInvocation.BoundParameters);
        }

        protected override void ProcessRecord()
        {
            // ProcessRecord is called once when InputObject is not given at all.
            if (InputObject == null)
                return;

            _builder.ReadPSObject(InputObject);
        }

        protected override void EndProcessing()
        {
            var si = _builder.CreateSeriesInfo();

            var bp = MyInvocation.BoundParameters;
            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PlotModel model = AddTo;
            if (model == null && bp.ContainsKey("OutFile"))
                model = ObjectFactory.CreatePlotModel(si);

            if (model != null)
            {
                foreach (var s in si.Series)
                    model.Series.Add(s);
            }
            else
                WriteObject(si);

            if (bp.ContainsKey("OutFile"))
                ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

    [Cmdlet("New", "OxyScatterSeries")]
    [Alias("oxy.scatter")]
    [OutputType(typeof(SeriesInfo<ScatterSeries>))]
    public class NewOxyScatterSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName;

        [Parameter(Position = 2, Mandatory = false)]
        public string YName;

        [Parameter(Position = 3, Mandatory = false)]
        public string SizeName;

        [Parameter(Position = 4, Mandatory = false)]
        public string ValueName;

        [Parameter(Position = 5, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 6, Mandatory = false)]
        public System.Double[] X;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double[] Y;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double[] Size;

        [Parameter(Position = 9, Mandatory = false)]
        public System.Double[] Value;

        [Parameter(Position = 10, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 11, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 12, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 13, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 14, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 15, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 16, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Double LabelMargin;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.Series.ScatterPoint> Mapping;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Int32 BinSize;

        [Parameter(Position = 20, Mandatory = false)]
        public System.String ColorAxisKey;

        [Parameter(Position = 21, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String DataFieldSize;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String DataFieldTag;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String DataFieldValue;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 27, Mandatory = false)]
        public OxyPlot.ScreenPoint[] MarkerOutline;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Double MarkerSize;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Double MarkerStrokeThickness;

        [Parameter(Position = 31, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private ScatterSeriesBuilder _builder;

        private void AssignParameters(ScatterSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("Mapping")) series.Mapping = Mapping;
            if (bp.ContainsKey("BinSize")) series.BinSize = BinSize;
            if (bp.ContainsKey("ColorAxisKey")) series.ColorAxisKey = ColorAxisKey;
            if (bp.ContainsKey("DataFieldX")) series.DataFieldX = DataFieldX;
            if (bp.ContainsKey("DataFieldY")) series.DataFieldY = DataFieldY;
            if (bp.ContainsKey("DataFieldSize")) series.DataFieldSize = DataFieldSize;
            if (bp.ContainsKey("DataFieldTag")) series.DataFieldTag = DataFieldTag;
            if (bp.ContainsKey("DataFieldValue")) series.DataFieldValue = DataFieldValue;
            if (bp.ContainsKey("MarkerFill")) series.MarkerFill = MarkerFill;
            if (bp.ContainsKey("MarkerOutline")) series.MarkerOutline = MarkerOutline;
            if (bp.ContainsKey("MarkerSize")) series.MarkerSize = MarkerSize;
            if (bp.ContainsKey("MarkerStroke")) series.MarkerStroke = MarkerStroke;
            if (bp.ContainsKey("MarkerStrokeThickness")) series.MarkerStrokeThickness = MarkerStrokeThickness;
            if (bp.ContainsKey("MarkerType")) series.MarkerType = MarkerType;
            if (bp.ContainsKey("XAxisKey")) series.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) series.YAxisKey = YAxisKey;
            if (bp.ContainsKey("ItemsSource")) series.ItemsSource = ItemsSource;
            if (bp.ContainsKey("Background")) series.Background = Background;
            if (bp.ContainsKey("IsVisible")) series.IsVisible = IsVisible;
            if (bp.ContainsKey("Title")) series.Title = Title;
            if (bp.ContainsKey("RenderInLegend")) series.RenderInLegend = RenderInLegend;
            if (bp.ContainsKey("TrackerFormatString")) series.TrackerFormatString = TrackerFormatString;
            if (bp.ContainsKey("TrackerKey")) series.TrackerKey = TrackerKey;
            if (bp.ContainsKey("Font")) series.Font = Font;
            if (bp.ContainsKey("FontSize")) series.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) series.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) series.Tag = Tag;
            if (bp.ContainsKey("TextColor")) series.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) series.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) series.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) series.SelectionMode = SelectionMode;
        }

        protected override void BeginProcessing()
        {
            _builder = new ScatterSeriesBuilder();
            _builder.ReadBoundParameters(MyInvocation.BoundParameters);
        }

        protected override void ProcessRecord()
        {
            // ProcessRecord is called once when InputObject is not given at all.
            if (InputObject == null)
                return;

            _builder.ReadPSObject(InputObject);
        }

        protected override void EndProcessing()
        {
            var si = _builder.CreateSeriesInfo();

            var bp = MyInvocation.BoundParameters;
            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PlotModel model = AddTo;
            if (model == null && bp.ContainsKey("OutFile"))
                model = ObjectFactory.CreatePlotModel(si);

            if (model != null)
            {
                foreach (var s in si.Series)
                    model.Series.Add(s);
            }
            else
                WriteObject(si);

            if (bp.ContainsKey("OutFile"))
                ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

    [Cmdlet("New", "OxyPieSeries")]
    [Alias("oxy.pie")]
    [OutputType(typeof(SeriesInfo<PieSeries>))]
    public class NewOxyPieSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string LabelName;

        [Parameter(Position = 2, Mandatory = false)]
        public string ValueName;

        [Parameter(Position = 3, Mandatory = false)]
        public string FillName;

        [Parameter(Position = 4, Mandatory = false)]
        public string IsExplodedName;

        [Parameter(Position = 5, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 6, Mandatory = false)]
        public System.String[] Label;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double[] Value;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor[] Fill;

        [Parameter(Position = 9, Mandatory = false)]
        public System.Boolean[] IsExploded;

        [Parameter(Position = 10, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 11, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 12, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 13, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 14, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 15, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Double AngleIncrement;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Double AngleSpan;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Boolean AreInsideLabelsAngled;

        [Parameter(Position = 19, Mandatory = false)]
        public System.String ColorField;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Double Diameter;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Double ExplodedDistance;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Double InnerDiameter;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor InsideLabelColor;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String InsideLabelFormat;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Double InsideLabelPosition;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String IsExplodedField;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String LabelField;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String LegendFormat;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String OutsideLabelFormat;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Collections.Generic.IList<OxyPlot.Series.PieSlice> Slices;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Double StartAngle;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Double StrokeThickness;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Double TickDistance;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Double TickHorizontalLength;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Double TickLabelDistance;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Double TickRadialLength;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String ValueField;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 48, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 52, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private PieSeriesBuilder _builder;

        private void AssignParameters(PieSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("AngleIncrement")) series.AngleIncrement = AngleIncrement;
            if (bp.ContainsKey("AngleSpan")) series.AngleSpan = AngleSpan;
            if (bp.ContainsKey("AreInsideLabelsAngled")) series.AreInsideLabelsAngled = AreInsideLabelsAngled;
            if (bp.ContainsKey("ColorField")) series.ColorField = ColorField;
            if (bp.ContainsKey("Diameter")) series.Diameter = Diameter;
            if (bp.ContainsKey("ExplodedDistance")) series.ExplodedDistance = ExplodedDistance;
            if (bp.ContainsKey("InnerDiameter")) series.InnerDiameter = InnerDiameter;
            if (bp.ContainsKey("InsideLabelColor")) series.InsideLabelColor = InsideLabelColor;
            if (bp.ContainsKey("InsideLabelFormat")) series.InsideLabelFormat = InsideLabelFormat;
            if (bp.ContainsKey("InsideLabelPosition")) series.InsideLabelPosition = InsideLabelPosition;
            if (bp.ContainsKey("IsExplodedField")) series.IsExplodedField = IsExplodedField;
            if (bp.ContainsKey("LabelField")) series.LabelField = LabelField;
            if (bp.ContainsKey("LegendFormat")) series.LegendFormat = LegendFormat;
            if (bp.ContainsKey("OutsideLabelFormat")) series.OutsideLabelFormat = OutsideLabelFormat;
            if (bp.ContainsKey("Slices")) series.Slices = Slices;
            if (bp.ContainsKey("StartAngle")) series.StartAngle = StartAngle;
            if (bp.ContainsKey("Stroke")) series.Stroke = Stroke;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("TickDistance")) series.TickDistance = TickDistance;
            if (bp.ContainsKey("TickHorizontalLength")) series.TickHorizontalLength = TickHorizontalLength;
            if (bp.ContainsKey("TickLabelDistance")) series.TickLabelDistance = TickLabelDistance;
            if (bp.ContainsKey("TickRadialLength")) series.TickRadialLength = TickRadialLength;
            if (bp.ContainsKey("ValueField")) series.ValueField = ValueField;
            if (bp.ContainsKey("ItemsSource")) series.ItemsSource = ItemsSource;
            if (bp.ContainsKey("Background")) series.Background = Background;
            if (bp.ContainsKey("IsVisible")) series.IsVisible = IsVisible;
            if (bp.ContainsKey("Title")) series.Title = Title;
            if (bp.ContainsKey("RenderInLegend")) series.RenderInLegend = RenderInLegend;
            if (bp.ContainsKey("TrackerFormatString")) series.TrackerFormatString = TrackerFormatString;
            if (bp.ContainsKey("TrackerKey")) series.TrackerKey = TrackerKey;
            if (bp.ContainsKey("Font")) series.Font = Font;
            if (bp.ContainsKey("FontSize")) series.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) series.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) series.Tag = Tag;
            if (bp.ContainsKey("TextColor")) series.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) series.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) series.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) series.SelectionMode = SelectionMode;
        }

        protected override void BeginProcessing()
        {
            _builder = new PieSeriesBuilder();
            _builder.ReadBoundParameters(MyInvocation.BoundParameters);
        }

        protected override void ProcessRecord()
        {
            // ProcessRecord is called once when InputObject is not given at all.
            if (InputObject == null)
                return;

            _builder.ReadPSObject(InputObject);
        }

        protected override void EndProcessing()
        {
            var si = _builder.CreateSeriesInfo();

            var bp = MyInvocation.BoundParameters;
            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PlotModel model = AddTo;
            if (model == null && bp.ContainsKey("OutFile"))
                model = ObjectFactory.CreatePlotModel(si);

            if (model != null)
            {
                foreach (var s in si.Series)
                    model.Series.Add(s);
            }
            else
                WriteObject(si);

            if (bp.ContainsKey("OutFile"))
                ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

    [Cmdlet("New", "OxyRectangleBarSeries")]
    [Alias("oxy.rectangleBar")]
    [OutputType(typeof(SeriesInfo<RectangleBarSeries>))]
    public class NewOxyRectangleBarSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string X0Name;

        [Parameter(Position = 2, Mandatory = false)]
        public string Y0Name;

        [Parameter(Position = 3, Mandatory = false)]
        public string X1Name;

        [Parameter(Position = 4, Mandatory = false)]
        public string Y1Name;

        [Parameter(Position = 5, Mandatory = false)]
        public string CategoryName;

        [Parameter(Position = 6, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double[] X0;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double[] Y0;

        [Parameter(Position = 9, Mandatory = false)]
        public System.Double[] X1;

        [Parameter(Position = 10, Mandatory = false)]
        public System.Double[] Y1;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Category[] Category;

        [Parameter(Position = 12, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 13, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 14, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 15, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 16, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 17, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LabelColor;

        [Parameter(Position = 20, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Double StrokeThickness;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 39, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private RectangleBarSeriesBuilder _builder;

        private void AssignParameters(RectangleBarSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("FillColor")) series.FillColor = FillColor;
            if (bp.ContainsKey("LabelColor")) series.LabelColor = LabelColor;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("StrokeColor")) series.StrokeColor = StrokeColor;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("XAxisKey")) series.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) series.YAxisKey = YAxisKey;
            if (bp.ContainsKey("ItemsSource")) series.ItemsSource = ItemsSource;
            if (bp.ContainsKey("Background")) series.Background = Background;
            if (bp.ContainsKey("IsVisible")) series.IsVisible = IsVisible;
            if (bp.ContainsKey("Title")) series.Title = Title;
            if (bp.ContainsKey("RenderInLegend")) series.RenderInLegend = RenderInLegend;
            if (bp.ContainsKey("TrackerFormatString")) series.TrackerFormatString = TrackerFormatString;
            if (bp.ContainsKey("TrackerKey")) series.TrackerKey = TrackerKey;
            if (bp.ContainsKey("Font")) series.Font = Font;
            if (bp.ContainsKey("FontSize")) series.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) series.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) series.Tag = Tag;
            if (bp.ContainsKey("TextColor")) series.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) series.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) series.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) series.SelectionMode = SelectionMode;
        }

        protected override void BeginProcessing()
        {
            _builder = new RectangleBarSeriesBuilder();
            _builder.ReadBoundParameters(MyInvocation.BoundParameters);
        }

        protected override void ProcessRecord()
        {
            // ProcessRecord is called once when InputObject is not given at all.
            if (InputObject == null)
                return;

            _builder.ReadPSObject(InputObject);
        }

        protected override void EndProcessing()
        {
            var si = _builder.CreateSeriesInfo();

            var bp = MyInvocation.BoundParameters;
            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PlotModel model = AddTo;
            if (model == null && bp.ContainsKey("OutFile"))
                model = ObjectFactory.CreatePlotModel(si);

            if (model != null)
            {
                foreach (var s in si.Series)
                    model.Series.Add(s);
            }
            else
                WriteObject(si);

            if (bp.ContainsKey("OutFile"))
                ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

    [Cmdlet("New", "OxyTornadoBarSeries")]
    [Alias("oxy.tornadoBar")]
    [OutputType(typeof(SeriesInfo<TornadoBarSeries>))]
    public class NewOxyTornadoBarSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string MinimumName;

        [Parameter(Position = 2, Mandatory = false)]
        public string MaximumName;

        [Parameter(Position = 3, Mandatory = false)]
        public string BarBaseValueName;

        [Parameter(Position = 4, Mandatory = false)]
        public string MinimumColorName;

        [Parameter(Position = 5, Mandatory = false)]
        public string MaximumColorName;

        [Parameter(Position = 6, Mandatory = false)]
        public string CategoryName;

        [Parameter(Position = 7, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double[] Minimum;

        [Parameter(Position = 9, Mandatory = false)]
        public System.Double[] Maximum;

        [Parameter(Position = 10, Mandatory = false)]
        public System.Double[] BarBaseValue;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor[] MinimumColor;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor[] MaximumColor;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Category[] Category;

        [Parameter(Position = 14, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 15, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 16, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 17, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 18, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 19, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Double BarWidth;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Double BaseValue;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LabelColor;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String LabelField;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Double LabelMargin;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String MaximumField;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MaximumFillColor;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String MaximumLabelFormatString;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String MinimumField;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinimumFillColor;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String MinimumLabelFormatString;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Double StrokeThickness;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 48, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 49, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private TornadoBarSeriesBuilder _builder;

        private void AssignParameters(TornadoBarSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("BarWidth")) series.BarWidth = BarWidth;
            if (bp.ContainsKey("BaseValue")) series.BaseValue = BaseValue;
            if (bp.ContainsKey("LabelColor")) series.LabelColor = LabelColor;
            if (bp.ContainsKey("LabelField")) series.LabelField = LabelField;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("MaximumField")) series.MaximumField = MaximumField;
            if (bp.ContainsKey("MaximumFillColor")) series.MaximumFillColor = MaximumFillColor;
            if (bp.ContainsKey("MaximumLabelFormatString")) series.MaximumLabelFormatString = MaximumLabelFormatString;
            if (bp.ContainsKey("MinimumField")) series.MinimumField = MinimumField;
            if (bp.ContainsKey("MinimumFillColor")) series.MinimumFillColor = MinimumFillColor;
            if (bp.ContainsKey("MinimumLabelFormatString")) series.MinimumLabelFormatString = MinimumLabelFormatString;
            if (bp.ContainsKey("StrokeColor")) series.StrokeColor = StrokeColor;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("XAxisKey")) series.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) series.YAxisKey = YAxisKey;
            if (bp.ContainsKey("ItemsSource")) series.ItemsSource = ItemsSource;
            if (bp.ContainsKey("Background")) series.Background = Background;
            if (bp.ContainsKey("IsVisible")) series.IsVisible = IsVisible;
            if (bp.ContainsKey("Title")) series.Title = Title;
            if (bp.ContainsKey("RenderInLegend")) series.RenderInLegend = RenderInLegend;
            if (bp.ContainsKey("TrackerFormatString")) series.TrackerFormatString = TrackerFormatString;
            if (bp.ContainsKey("TrackerKey")) series.TrackerKey = TrackerKey;
            if (bp.ContainsKey("Font")) series.Font = Font;
            if (bp.ContainsKey("FontSize")) series.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) series.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) series.Tag = Tag;
            if (bp.ContainsKey("TextColor")) series.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) series.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) series.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) series.SelectionMode = SelectionMode;
        }

        protected override void BeginProcessing()
        {
            _builder = new TornadoBarSeriesBuilder();
            _builder.ReadBoundParameters(MyInvocation.BoundParameters);
        }

        protected override void ProcessRecord()
        {
            // ProcessRecord is called once when InputObject is not given at all.
            if (InputObject == null)
                return;

            _builder.ReadPSObject(InputObject);
        }

        protected override void EndProcessing()
        {
            var si = _builder.CreateSeriesInfo();

            var bp = MyInvocation.BoundParameters;
            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PlotModel model = AddTo;
            if (model == null && bp.ContainsKey("OutFile"))
                model = ObjectFactory.CreatePlotModel(si);

            if (model != null)
            {
                foreach (var s in si.Series)
                    model.Series.Add(s);
            }
            else
                WriteObject(si);

            if (bp.ContainsKey("OutFile"))
                ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

}
