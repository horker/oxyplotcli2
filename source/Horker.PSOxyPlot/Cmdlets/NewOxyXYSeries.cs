
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using OxyPlot;
using OxyPlot.Series;
using Horker.PSOxyPlot.SeriesBuilders;

namespace Horker.PSOxyPlot
{
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
        public System.String[] Category;

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
			_builder = new BarSeriesBuilder(MyInvocation.BoundParameters);
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
			var bp = MyInvocation.BoundParameters;

			PlotModel model = AddTo;
			if (model == null && bp.ContainsKey("OutFile"))
				model = new PlotModel();

			var series = _builder.CreateSeries();

			foreach (var s in series.Series)
				AssignParameters(s, bp);

			if (model != null)
			{
				foreach (var s in series.Series)
					model.Series.Add(s);
			}
			else
				WriteObject(series);

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
        public System.String[] Category;

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
			_builder = new ColumnSeriesBuilder(MyInvocation.BoundParameters);
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
			var bp = MyInvocation.BoundParameters;

			PlotModel model = AddTo;
			if (model == null && bp.ContainsKey("OutFile"))
				model = new PlotModel();

			var series = _builder.CreateSeries();

			foreach (var s in series.Series)
				AssignParameters(s, bp);

			if (model != null)
			{
				foreach (var s in series.Series)
					model.Series.Add(s);
			}
			else
				WriteObject(series);

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
			_builder = new LineSeriesBuilder(MyInvocation.BoundParameters);
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
			var bp = MyInvocation.BoundParameters;

			PlotModel model = AddTo;
			if (model == null && bp.ContainsKey("OutFile"))
				model = new PlotModel();

			var series = _builder.CreateSeries();

			foreach (var s in series.Series)
				AssignParameters(s, bp);

			if (model != null)
			{
				foreach (var s in series.Series)
					model.Series.Add(s);
			}
			else
				WriteObject(series);

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
			_builder = new ScatterSeriesBuilder(MyInvocation.BoundParameters);
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
			var bp = MyInvocation.BoundParameters;

			PlotModel model = AddTo;
			if (model == null && bp.ContainsKey("OutFile"))
				model = new PlotModel();

			var series = _builder.CreateSeries();

			foreach (var s in series.Series)
				AssignParameters(s, bp);

			if (model != null)
			{
				foreach (var s in series.Series)
					model.Series.Add(s);
			}
			else
				WriteObject(series);

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
			_builder = new PieSeriesBuilder(MyInvocation.BoundParameters);
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
			var bp = MyInvocation.BoundParameters;

			PlotModel model = AddTo;
			if (model == null && bp.ContainsKey("OutFile"))
				model = new PlotModel();

			var series = _builder.CreateSeries();

			foreach (var s in series.Series)
				AssignParameters(s, bp);

			if (model != null)
			{
				foreach (var s in series.Series)
					model.Series.Add(s);
			}
			else
				WriteObject(series);

			if (bp.ContainsKey("OutFile"))
				ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

}