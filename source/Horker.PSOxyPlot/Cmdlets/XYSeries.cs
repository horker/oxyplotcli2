﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using OxyPlot;
using OxyPlot.Series;

namespace Horker.PSOxyPlot
{
    [Cmdlet("New", "OxyLineSeries")]
    [Alias("oxy.line")]
    [OutputType(typeof(LineSeries))]
    public class NewOxyLineSeries : PSCmdlet
    {
        [Parameter(ParameterSetName = "ByPipeline", Position = 0, Mandatory = true, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(ParameterSetName = "ByPipeline", Position = 1, Mandatory = true)]
        public string XName = "X";

        [Parameter(ParameterSetName = "ByPipeline", Position = 2, Mandatory = true)]
        public string YName = "Y";

        [Parameter(ParameterSetName = "ByPipeline", Position = 3, Mandatory = false)]
        public string GroupName = null;

        [Parameter(ParameterSetName = "ByArray", Position = 4, Mandatory = true)]
        public System.Double[] X;

        [Parameter(ParameterSetName = "ByArray", Position = 5, Mandatory = true)]
        public System.Double[] Y;

        [Parameter(Position = 6, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 7, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 8, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 9, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 10, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 13, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 14, Mandatory = false)]
        public System.Double BrokenLineThickness;

        [Parameter(Position = 15, Mandatory = false)]
        public System.Double[] Dashes;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Double LabelMargin;

        [Parameter(Position = 19, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.ScreenPoint[] MarkerOutline;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Double MarkerSize;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Double MarkerStrokeThickness;

        [Parameter(Position = 28, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Double MinimumSegmentLength;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Boolean Smooth;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Double StrokeThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Boolean CanTrackerInterpolatePoints;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Boolean IsVisible;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Boolean RenderInLegend;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 48, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 50, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 51, Mandatory = false)]
        public System.Boolean Selectable;

        [Parameter(Position = 52, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private Dictionary<string, List<DataPoint>> _points;

		private static readonly string DEFAULT_GROUP_NAME = "no groups!!??#$%__";

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
            _points = new Dictionary<string, List<DataPoint>>();
        }

        protected override void ProcessRecord()
        {
			// ProcessRecord is called once when InputObject is not given at all.
			if (InputObject == null)
				return;

	        string group = DEFAULT_GROUP_NAME;
            if (!string.IsNullOrEmpty(GroupName))
            {
                var g = InputObject.Properties.Match(GroupName);
                if (g.Count > 0)
                    group = g[0].Value.ToString();
            }

			List<DataPoint> list;
			if (!_points.TryGetValue(group, out list))
			{
				list = new List<DataPoint>();
				_points.Add(group, list);
			}

			var point = PointFactory.CreateLineSeriesPoint(MyInvocation.BoundParameters, InputObject);
            list.Add(point);
        }

        protected override void EndProcessing()
        {
			var bp = MyInvocation.BoundParameters;

			PlotModel model = AddTo;
			if (model == null && bp.ContainsKey("OutFile"))
				model = new PlotModel();

			if (ParameterSetName == "ByPipeline")
			{
				foreach (var entry in _points)
				{
					var series = new LineSeries();

					if (entry.Key != DEFAULT_GROUP_NAME)
						series.Title = entry.Key;

					AssignParameters(series, bp);

					foreach (var p in entry.Value)
						series.Points.Add(p);

					if (model != null)
						model.Series.Add(series);
					else
						WriteObject(series);
				}
			}
			else
			{
				var series = new LineSeries();
				AssignParameters(series, bp);
				PointFactory.AddLineSeriesPoints(series, bp);

				if (model != null)
					model.Series.Add(series);
				else
					WriteObject(series);
			}

			if (bp.ContainsKey("OutFile"))
				ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

    [Cmdlet("New", "OxyScatterSeries")]
    [Alias("oxy.scatter")]
    [OutputType(typeof(ScatterSeries))]
    public class NewOxyScatterSeries : PSCmdlet
    {
        [Parameter(ParameterSetName = "ByPipeline", Position = 0, Mandatory = true, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(ParameterSetName = "ByPipeline", Position = 1, Mandatory = true)]
        public string XName = "X";

        [Parameter(ParameterSetName = "ByPipeline", Position = 2, Mandatory = true)]
        public string YName = "Y";

        [Parameter(ParameterSetName = "ByPipeline", Position = 3, Mandatory = false)]
        public string SizeName = "Size";

        [Parameter(ParameterSetName = "ByPipeline", Position = 4, Mandatory = false)]
        public string ValueName = "Value";

        [Parameter(ParameterSetName = "ByPipeline", Position = 5, Mandatory = false)]
        public string GroupName = null;

        [Parameter(ParameterSetName = "ByArray", Position = 6, Mandatory = true)]
        public System.Double[] X;

        [Parameter(ParameterSetName = "ByArray", Position = 7, Mandatory = true)]
        public System.Double[] Y;

        [Parameter(ParameterSetName = "ByArray", Position = 8, Mandatory = false)]
        public System.Double[] Size;

        [Parameter(ParameterSetName = "ByArray", Position = 9, Mandatory = false)]
        public System.Double[] Value;

        [Parameter(Position = 10, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 11, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 12, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 13, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 14, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 15, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Double LabelMargin;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.Series.ScatterPoint> Mapping;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Int32 BinSize;

        [Parameter(Position = 19, Mandatory = false)]
        public System.String ColorAxisKey;

        [Parameter(Position = 20, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 21, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String DataFieldSize;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String DataFieldTag;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String DataFieldValue;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 26, Mandatory = false)]
        public OxyPlot.ScreenPoint[] MarkerOutline;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Double MarkerSize;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Double MarkerStrokeThickness;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

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
        public System.Double FontSize;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Double FontWeight;

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

        private Dictionary<string, List<ScatterPoint>> _points;

		private static readonly string DEFAULT_GROUP_NAME = "no groups!!??#$%__";

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
            _points = new Dictionary<string, List<ScatterPoint>>();
        }

        protected override void ProcessRecord()
        {
			// ProcessRecord is called once when InputObject is not given at all.
			if (InputObject == null)
				return;

	        string group = DEFAULT_GROUP_NAME;
            if (!string.IsNullOrEmpty(GroupName))
            {
                var g = InputObject.Properties.Match(GroupName);
                if (g.Count > 0)
                    group = g[0].Value.ToString();
            }

			List<ScatterPoint> list;
			if (!_points.TryGetValue(group, out list))
			{
				list = new List<ScatterPoint>();
				_points.Add(group, list);
			}

			var point = PointFactory.CreateScatterSeriesPoint(MyInvocation.BoundParameters, InputObject);
            list.Add(point);
        }

        protected override void EndProcessing()
        {
			var bp = MyInvocation.BoundParameters;

			PlotModel model = AddTo;
			if (model == null && bp.ContainsKey("OutFile"))
				model = new PlotModel();

			if (ParameterSetName == "ByPipeline")
			{
				foreach (var entry in _points)
				{
					var series = new ScatterSeries();

					if (entry.Key != DEFAULT_GROUP_NAME)
						series.Title = entry.Key;

					AssignParameters(series, bp);

					foreach (var p in entry.Value)
						series.Points.Add(p);

					if (model != null)
						model.Series.Add(series);
					else
						WriteObject(series);
				}
			}
			else
			{
				var series = new ScatterSeries();
				AssignParameters(series, bp);
				PointFactory.AddScatterSeriesPoints(series, bp);

				if (model != null)
					model.Series.Add(series);
				else
					WriteObject(series);
			}

			if (bp.ContainsKey("OutFile"))
				ModelExporter.Export(model, OutFile, OutWidth, OutHeight, SvgIsDocument);
        }
    }

}