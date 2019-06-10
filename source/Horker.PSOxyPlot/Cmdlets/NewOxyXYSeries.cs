
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
    [Alias("oxy.area", "oxyarea")]
    [OutputType(typeof(SeriesInfo<AreaSeries>))]
    public class NewOxyAreaSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string X1Name;

        [Parameter(Position = 2, Mandatory = false)]
        public string Y1Name;

        [Parameter(Position = 3, Mandatory = false)]
        public string X2Name;

        [Parameter(Position = 4, Mandatory = false)]
        public string Y2Name;

        [Parameter(Position = 5, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X1;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y1;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X2;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y2;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ConstantY2;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String DataFieldX2;

        [Parameter(Position = 19, Mandatory = false)]
        public System.String DataFieldY2;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color2;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Boolean Reverse2;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 25, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Double[] Dashes;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 31, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 32, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 35, Mandatory = false)]
        public OxyPlot.ScreenPoint[] MarkerOutline;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 40, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 42, Mandatory = false)]
        public OxyPlot.IInterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Boolean CanTrackerInterpolatePoints;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 49, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 52, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 53, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 56, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 60, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 62, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 63, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 64, Mandatory = false)]
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
            if (bp.ContainsKey("InterpolationAlgorithm")) series.InterpolationAlgorithm = InterpolationAlgorithm;
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyBarSeries")]
    [Alias("oxy.bar", "oxybar")]
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Value;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BarWidth;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BaseValue;

        [Parameter(Position = 15, Mandatory = false)]
        public System.String ColorField;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Boolean IsStacked;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.Series.LabelPlacement LabelPlacement;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor NegativeFillColor;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String StackGroup;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String ValueField;

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
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyBoxPlotSeries")]
    [Alias("oxy.boxPlot", "oxy.box", "oxybox")]
    [OutputType(typeof(SeriesInfo<BoxPlotSeries>))]
    public class NewOxyBoxPlotSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string CategoryName;

        [Parameter(Position = 2, Mandatory = false)]
        public string LowerWhiskerName;

        [Parameter(Position = 3, Mandatory = false)]
        public string BoxBottomName;

        [Parameter(Position = 4, Mandatory = false)]
        public string MedianName;

        [Parameter(Position = 5, Mandatory = false)]
        public string BoxTopName;

        [Parameter(Position = 6, Mandatory = false)]
        public string UpperWhiskerName;

        [Parameter(Position = 7, Mandatory = false)]
        public string OutliersName;

        [Parameter(Position = 8, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Category[] Category;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] LowerWhisker;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] BoxBottom;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Median;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] BoxTop;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] UpperWhisker;

        [Parameter(Position = 15, Mandatory = false)]
        public System.Object[] Outliers;

        [Parameter(Position = 16, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 17, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 18, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 19, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 20, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 21, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 22, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BoxWidth;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Collections.Generic.IList<OxyPlot.Series.BoxPlotItem> Items;

        [Parameter(Position = 26, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MedianPointSize;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MedianThickness;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MeanPointSize;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MeanThickness;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double OutlierSize;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String OutlierTrackerFormatString;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.MarkerType OutlierType;

        [Parameter(Position = 34, Mandatory = false)]
        public OxyPlot.ScreenPoint[] OutlierOutline;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Boolean ShowBox;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Boolean ShowMedianAsDot;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Boolean ShowMeanAsDot;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double WhiskerWidth;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 49, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 50, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 56, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 57, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private BoxPlotSeriesBuilder _builder;

        private void AssignParameters(BoxPlotSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("BoxWidth")) series.BoxWidth = BoxWidth;
            if (bp.ContainsKey("Fill")) series.Fill = Fill;
            if (bp.ContainsKey("Items")) series.Items = Items;
            if (bp.ContainsKey("LineStyle")) series.LineStyle = LineStyle;
            if (bp.ContainsKey("MedianPointSize")) series.MedianPointSize = MedianPointSize;
            if (bp.ContainsKey("MedianThickness")) series.MedianThickness = MedianThickness;
            if (bp.ContainsKey("MeanPointSize")) series.MeanPointSize = MeanPointSize;
            if (bp.ContainsKey("MeanThickness")) series.MeanThickness = MeanThickness;
            if (bp.ContainsKey("OutlierSize")) series.OutlierSize = OutlierSize;
            if (bp.ContainsKey("OutlierTrackerFormatString")) series.OutlierTrackerFormatString = OutlierTrackerFormatString;
            if (bp.ContainsKey("OutlierType")) series.OutlierType = OutlierType;
            if (bp.ContainsKey("OutlierOutline")) series.OutlierOutline = OutlierOutline;
            if (bp.ContainsKey("ShowBox")) series.ShowBox = ShowBox;
            if (bp.ContainsKey("ShowMedianAsDot")) series.ShowMedianAsDot = ShowMedianAsDot;
            if (bp.ContainsKey("ShowMeanAsDot")) series.ShowMeanAsDot = ShowMeanAsDot;
            if (bp.ContainsKey("Stroke")) series.Stroke = Stroke;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("WhiskerWidth")) series.WhiskerWidth = WhiskerWidth;
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
            _builder = new BoxPlotSeriesBuilder();
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyCandleStickSeries")]
    [Alias("oxy.candleStick", "oxy.cnadle", "oxycandle")]
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] High;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Low;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Open;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Close;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor IncreasingColor;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor DecreasingColor;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double CandleWidth;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Double[] Dashes;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String DataFieldClose;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String DataFieldHigh;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String DataFieldLow;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String DataFieldOpen;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 29, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.Series.HighLowItem> Mapping;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TickLength;

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
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyCandleStickAndVolumeSeries")]
    [Alias("oxy.candlev", "oxycandlev")]
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
        public string SellVolumeName;

        [Parameter(Position = 8, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Open;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] High;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Low;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Close;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] BuyVolume;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] SellVolume;

        [Parameter(Position = 16, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 17, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 18, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 19, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 20, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 21, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 22, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Collections.Generic.List<OxyPlot.Series.OhlcvItem> Items;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String VolumeAxisKey;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String BarAxisKey;

        [Parameter(Position = 26, Mandatory = false)]
        public OxyPlot.Series.VolumeStyle VolumeStyle;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeIntensity;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double SeparatorStrokeThickness;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LineStyle SeparatorLineStyle;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor PositiveColor;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor NegativeColor;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor SeparatorColor;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Boolean PositiveHollow;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Boolean NegativeHollow;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double CandleWidth;

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
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyColumnSeries")]
    [Alias("oxy.column", "oxy.col", "oxycolumn")]
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Value;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ColumnWidth;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BaseValue;

        [Parameter(Position = 15, Mandatory = false)]
        public System.String ColorField;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Boolean IsStacked;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.Series.LabelPlacement LabelPlacement;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor NegativeFillColor;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String StackGroup;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String ValueField;

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
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyContourSeries")]
    [Alias("oxy.contour", "oxycontour")]
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Z;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Double[] ColumnCoordinates;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ContourLevelStep;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Double[] ContourLevels;

        [Parameter(Position = 19, Mandatory = false)]
        public OxyPlot.OxyColor[] ContourColors;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Double[,] Data;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LabelBackground;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelSpacing;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Int32 LabelStep;

        [Parameter(Position = 25, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Double[] RowCoordinates;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 44, Mandatory = false)]
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyErrorColumnSeries")]
    [Alias("oxy.errorColumn", "oxy.ecol", "oxyecol")]
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Value;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Error;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ErrorStrokeThickness;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ErrorWidth;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ColumnWidth;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BaseValue;

        [Parameter(Position = 19, Mandatory = false)]
        public System.String ColorField;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Boolean IsStacked;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.Series.LabelPlacement LabelPlacement;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor NegativeFillColor;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String StackGroup;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String ValueField;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 46, Mandatory = false)]
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyHighLowSeries")]
    [Alias("oxy.highLow", "oxyhighlow")]
    [OutputType(typeof(SeriesInfo<HighLowSeries>))]
    public class NewOxyHighLowSeries : PSCmdlet
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] High;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Low;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Open;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Close;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Double[] Dashes;

        [Parameter(Position = 21, Mandatory = false)]
        public System.String DataFieldClose;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String DataFieldHigh;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String DataFieldLow;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String DataFieldOpen;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 26, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 27, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.Series.HighLowItem> Mapping;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TickLength;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 47, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private HighLowSeriesBuilder _builder;

        private void AssignParameters(HighLowSeries series, Dictionary<string, object> bp)
        {
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
            _builder = new HighLowSeriesBuilder();
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyIntervalBarSeries")]
    [Alias("oxy.intervalBar", "oxy.ibar", "oxyibar")]
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Start;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] End;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BarWidth;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LabelColor;

        [Parameter(Position = 20, Mandatory = false)]
        public System.String LabelField;

        [Parameter(Position = 21, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String MaximumField;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String MinimumField;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

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
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyLinearBarSeries")]
    [Alias("oxy.linearBar", "oxy.lbar", "oxylbar")]
    [OutputType(typeof(SeriesInfo<LinearBarSeries>))]
    public class NewOxyLinearBarSeries : PSCmdlet
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BarWidth;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor NegativeFillColor;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor NegativeStrokeColor;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Boolean CanTrackerInterpolatePoints;

        [Parameter(Position = 20, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 21, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

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
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

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

        private LinearBarSeriesBuilder _builder;

        private void AssignParameters(LinearBarSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("FillColor")) series.FillColor = FillColor;
            if (bp.ContainsKey("BarWidth")) series.BarWidth = BarWidth;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("StrokeColor")) series.StrokeColor = StrokeColor;
            if (bp.ContainsKey("NegativeFillColor")) series.NegativeFillColor = NegativeFillColor;
            if (bp.ContainsKey("NegativeStrokeColor")) series.NegativeStrokeColor = NegativeStrokeColor;
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
            _builder = new LinearBarSeriesBuilder();
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyLineSeries")]
    [Alias("oxy.line", "oxyline")]
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Double[] Dashes;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 19, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 22, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 25, Mandatory = false)]
        public OxyPlot.ScreenPoint[] MarkerOutline;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 32, Mandatory = false)]
        public OxyPlot.IInterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Boolean CanTrackerInterpolatePoints;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 54, Mandatory = false)]
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
            if (bp.ContainsKey("InterpolationAlgorithm")) series.InterpolationAlgorithm = InterpolationAlgorithm;
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyPieSeries")]
    [Alias("oxy.pie", "oxypie")]
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Value;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AngleIncrement;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AngleSpan;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Boolean AreInsideLabelsAngled;

        [Parameter(Position = 20, Mandatory = false)]
        public System.String ColorField;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Diameter;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ExplodedDistance;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double InnerDiameter;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor InsideLabelColor;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String InsideLabelFormat;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double InsideLabelPosition;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String IsExplodedField;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String LabelField;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String LegendFormat;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String OutsideLabelFormat;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Collections.Generic.IList<OxyPlot.Series.PieSlice> Slices;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StartAngle;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TickDistance;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TickHorizontalLength;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TickLabelDistance;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TickRadialLength;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String ValueField;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 54, Mandatory = false)]
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyRectangleBarSeries")]
    [Alias("oxy.rectangleBar", "oxy.rbar", "oxyrbar")]
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
        public string GroupName = null;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X0;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y0;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X1;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y1;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LabelColor;

        [Parameter(Position = 19, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 38, Mandatory = false)]
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyScatterSeries")]
    [Alias("oxy.scatter", "oxy.scat", "oxyscat")]
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Size;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Value;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.Series.ScatterPoint> Mapping;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Int32 BinSize;

        [Parameter(Position = 21, Mandatory = false)]
        public System.String ColorAxisKey;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String DataFieldSize;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String DataFieldTag;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String DataFieldValue;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 28, Mandatory = false)]
        public OxyPlot.ScreenPoint[] MarkerOutline;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

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
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyScatterErrorSeries")]
    [Alias("oxy.scatterError", "oxy.scate", "oxyscate")]
    [OutputType(typeof(SeriesInfo<ScatterErrorSeries>))]
    public class NewOxyScatterErrorSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName;

        [Parameter(Position = 2, Mandatory = false)]
        public string YName;

        [Parameter(Position = 3, Mandatory = false)]
        public string ErrorXName;

        [Parameter(Position = 4, Mandatory = false)]
        public string ErrorYName;

        [Parameter(Position = 5, Mandatory = false)]
        public string SizeName;

        [Parameter(Position = 6, Mandatory = false)]
        public string ValueName;

        [Parameter(Position = 7, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] ErrorX;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] ErrorY;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Size;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Value;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 21, Mandatory = false)]
        public System.String DataFieldErrorX;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String DataFieldErrorY;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ErrorBarColor;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ErrorBarStopWidth;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ErrorBarStrokeThickness;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumErrorSize;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.Series.ScatterErrorPoint> Mapping;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Int32 BinSize;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String ColorAxisKey;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String DataFieldSize;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String DataFieldTag;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String DataFieldValue;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 38, Mandatory = false)]
        public OxyPlot.ScreenPoint[] MarkerOutline;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 42, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 50, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 55, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 58, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 59, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private ScatterErrorSeriesBuilder _builder;

        private void AssignParameters(ScatterErrorSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("DataFieldErrorX")) series.DataFieldErrorX = DataFieldErrorX;
            if (bp.ContainsKey("DataFieldErrorY")) series.DataFieldErrorY = DataFieldErrorY;
            if (bp.ContainsKey("ErrorBarColor")) series.ErrorBarColor = ErrorBarColor;
            if (bp.ContainsKey("ErrorBarStopWidth")) series.ErrorBarStopWidth = ErrorBarStopWidth;
            if (bp.ContainsKey("ErrorBarStrokeThickness")) series.ErrorBarStrokeThickness = ErrorBarStrokeThickness;
            if (bp.ContainsKey("MinimumErrorSize")) series.MinimumErrorSize = MinimumErrorSize;
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
            _builder = new ScatterErrorSeriesBuilder();
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyStairStepSeries")]
    [Alias("oxy.stairStep", "oxy.stair", "oxystart")]
    [OutputType(typeof(SeriesInfo<StairStepSeries>))]
    public class NewOxyStairStepSeries : PSCmdlet
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double VerticalStrokeThickness;

        [Parameter(Position = 14, Mandatory = false)]
        public OxyPlot.LineStyle VerticalLineStyle;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 17, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Double[] Dashes;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 21, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 25, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 27, Mandatory = false)]
        public OxyPlot.ScreenPoint[] MarkerOutline;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 34, Mandatory = false)]
        public OxyPlot.IInterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Boolean CanTrackerInterpolatePoints;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 49, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 52, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 55, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 56, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private StairStepSeriesBuilder _builder;

        private void AssignParameters(StairStepSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("VerticalStrokeThickness")) series.VerticalStrokeThickness = VerticalStrokeThickness;
            if (bp.ContainsKey("VerticalLineStyle")) series.VerticalLineStyle = VerticalLineStyle;
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
            if (bp.ContainsKey("InterpolationAlgorithm")) series.InterpolationAlgorithm = InterpolationAlgorithm;
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
            _builder = new StairStepSeriesBuilder();
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyStemSeries")]
    [Alias("oxy.stem", "oxystem")]
    [OutputType(typeof(SeriesInfo<StemSeries>))]
    public class NewOxyStemSeries : PSCmdlet
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Base;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 16, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Double[] Dashes;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 20, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 22, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 26, Mandatory = false)]
        public OxyPlot.ScreenPoint[] MarkerOutline;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 31, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.IInterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Boolean CanTrackerInterpolatePoints;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 51, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 53, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 55, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private StemSeriesBuilder _builder;

        private void AssignParameters(StemSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("Base")) series.Base = Base;
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
            if (bp.ContainsKey("InterpolationAlgorithm")) series.InterpolationAlgorithm = InterpolationAlgorithm;
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
            _builder = new StemSeriesBuilder();
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyThreeColorLineSeries")]
    [Alias("oxy.ThreeColorLine", "oxy.3cLine", "oxy3cline")]
    [OutputType(typeof(SeriesInfo<ThreeColorLineSeries>))]
    public class NewOxyThreeColorLineSeries : PSCmdlet
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ColorLo;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ColorHi;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LimitHi;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LimitLo;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Double[] DashesHi;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Double[] DashesLo;

        [Parameter(Position = 19, Mandatory = false)]
        public OxyPlot.LineStyle LineStyleHi;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.LineStyle LineStyleLo;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Double[] Dashes;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 29, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 31, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.ScreenPoint[] MarkerOutline;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 38, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 40, Mandatory = false)]
        public OxyPlot.IInterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Boolean CanTrackerInterpolatePoints;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 48, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 52, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 53, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 58, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 61, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 62, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private ThreeColorLineSeriesBuilder _builder;

        private void AssignParameters(ThreeColorLineSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("ColorLo")) series.ColorLo = ColorLo;
            if (bp.ContainsKey("ColorHi")) series.ColorHi = ColorHi;
            if (bp.ContainsKey("LimitHi")) series.LimitHi = LimitHi;
            if (bp.ContainsKey("LimitLo")) series.LimitLo = LimitLo;
            if (bp.ContainsKey("DashesHi")) series.DashesHi = DashesHi;
            if (bp.ContainsKey("DashesLo")) series.DashesLo = DashesLo;
            if (bp.ContainsKey("LineStyleHi")) series.LineStyleHi = LineStyleHi;
            if (bp.ContainsKey("LineStyleLo")) series.LineStyleLo = LineStyleLo;
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
            if (bp.ContainsKey("InterpolationAlgorithm")) series.InterpolationAlgorithm = InterpolationAlgorithm;
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
            _builder = new ThreeColorLineSeriesBuilder();
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyTornadoBarSeries")]
    [Alias("oxy.tornadoBar", "oxy.tornado", "oxytornado")]
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Minimum;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Maximum;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] BarBaseValue;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BarWidth;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BaseValue;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LabelColor;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String LabelField;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String MaximumField;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MaximumFillColor;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String MaximumLabelFormatString;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String MinimumField;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinimumFillColor;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String MinimumLabelFormatString;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

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
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyTwoColorAreaSeries")]
    [Alias("oxy.twoColorArea", "oxy.2cArea", "oxy2carea")]
    [OutputType(typeof(SeriesInfo<TwoColorAreaSeries>))]
    public class NewOxyTwoColorAreaSeries : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string X1Name;

        [Parameter(Position = 2, Mandatory = false)]
        public string Y1Name;

        [Parameter(Position = 3, Mandatory = false)]
        public string X2Name;

        [Parameter(Position = 4, Mandatory = false)]
        public string Y2Name;

        [Parameter(Position = 5, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X1;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y1;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X2;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y2;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Fill2;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Double[] Dashes2;

        [Parameter(Position = 19, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle2;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill2;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke2;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Limit;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ConstantY2;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String DataFieldX2;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String DataFieldY2;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color2;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Boolean Reverse2;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 31, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Double[] Dashes;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 37, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 38, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 39, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 41, Mandatory = false)]
        public OxyPlot.ScreenPoint[] MarkerOutline;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 46, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.IInterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Boolean CanTrackerInterpolatePoints;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 56, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 58, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 59, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 60, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 62, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 66, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 68, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 70, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private TwoColorAreaSeriesBuilder _builder;

        private void AssignParameters(TwoColorAreaSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("Fill2")) series.Fill2 = Fill2;
            if (bp.ContainsKey("Dashes2")) series.Dashes2 = Dashes2;
            if (bp.ContainsKey("LineStyle2")) series.LineStyle2 = LineStyle2;
            if (bp.ContainsKey("MarkerFill2")) series.MarkerFill2 = MarkerFill2;
            if (bp.ContainsKey("MarkerStroke2")) series.MarkerStroke2 = MarkerStroke2;
            if (bp.ContainsKey("Limit")) series.Limit = Limit;
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
            if (bp.ContainsKey("InterpolationAlgorithm")) series.InterpolationAlgorithm = InterpolationAlgorithm;
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
            _builder = new TwoColorAreaSeriesBuilder();
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyTwoColorLineSeries")]
    [Alias("oxy.twoColorLine", "oxy.2cLine", "oxy2cline")]
    [OutputType(typeof(SeriesInfo<TwoColorLineSeries>))]
    public class NewOxyTwoColorLineSeries : PSCmdlet
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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Y;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color2;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Limit;

        [Parameter(Position = 15, Mandatory = false)]
        public System.Double[] Dashes2;

        [Parameter(Position = 16, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle2;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 19, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Double[] Dashes;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 25, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 26, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 27, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 29, Mandatory = false)]
        public OxyPlot.ScreenPoint[] MarkerOutline;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 34, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 36, Mandatory = false)]
        public OxyPlot.IInterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Boolean CanTrackerInterpolatePoints;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 48, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 49, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 50, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 56, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 57, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 58, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private TwoColorLineSeriesBuilder _builder;

        private void AssignParameters(TwoColorLineSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("Color2")) series.Color2 = Color2;
            if (bp.ContainsKey("Limit")) series.Limit = Limit;
            if (bp.ContainsKey("Dashes2")) series.Dashes2 = Dashes2;
            if (bp.ContainsKey("LineStyle2")) series.LineStyle2 = LineStyle2;
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
            if (bp.ContainsKey("InterpolationAlgorithm")) series.InterpolationAlgorithm = InterpolationAlgorithm;
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
            _builder = new TwoColorLineSeriesBuilder();
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

    [Cmdlet("New", "OxyVolumeSeries")]
    [Alias("oxy.volume", "oxyvolume")]
    [OutputType(typeof(SeriesInfo<VolumeSeries>))]
    public class NewOxyVolumeSeries : PSCmdlet
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
        public string SellVolumeName;

        [Parameter(Position = 8, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] X;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Open;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] High;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Low;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Close;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] BuyVolume;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] SellVolume;

        [Parameter(Position = 16, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 17, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 18, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 19, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 20, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 21, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 22, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Collections.Generic.List<OxyPlot.Series.OhlcvItem> Items;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.Series.VolumeStyle VolumeStyle;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeIntensity;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor PositiveColor;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor NegativeColor;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor InterceptColor;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double InterceptStrokeThickness;

        [Parameter(Position = 31, Mandatory = false)]
        public OxyPlot.LineStyle InterceptLineStyle;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Boolean PositiveHollow;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Boolean NegativeHollow;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BarWidth;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 49, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 51, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private VolumeSeriesBuilder _builder;

        private void AssignParameters(VolumeSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("Items")) series.Items = Items;
            if (bp.ContainsKey("VolumeStyle")) series.VolumeStyle = VolumeStyle;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("StrokeIntensity")) series.StrokeIntensity = StrokeIntensity;
            if (bp.ContainsKey("PositiveColor")) series.PositiveColor = PositiveColor;
            if (bp.ContainsKey("NegativeColor")) series.NegativeColor = NegativeColor;
            if (bp.ContainsKey("InterceptColor")) series.InterceptColor = InterceptColor;
            if (bp.ContainsKey("InterceptStrokeThickness")) series.InterceptStrokeThickness = InterceptStrokeThickness;
            if (bp.ContainsKey("InterceptLineStyle")) series.InterceptLineStyle = InterceptLineStyle;
            if (bp.ContainsKey("PositiveHollow")) series.PositiveHollow = PositiveHollow;
            if (bp.ContainsKey("NegativeHollow")) series.NegativeHollow = NegativeHollow;
            if (bp.ContainsKey("BarWidth")) series.BarWidth = BarWidth;
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
            _builder = new VolumeSeriesBuilder();
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

                if (bp.ContainsKey("OutFile"))
                {
                    ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                    if (!PassThru)
                        return;
                }

                WriteObject(model);
            }
            else
                WriteObject(si);
        }
    }

}
