
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using OxyPlot;
using OxyPlot.Series;
using Horker.PSOxyPlot.ObjectFactories;

namespace Horker.PSOxyPlot
{
    [Cmdlet("New", "OxyFunctionSeries")]
    [Alias("oxy.func", "oxyfunc")]
    [OutputType(typeof(FunctionSeries))]
    public class NewOxyFunctionSeries : PSCmdlet
    {
        [Parameter(ParameterSetName = "Explicit", Position = 0, Mandatory = true)]
        public ScriptBlock[] F = null;

        [Parameter(ParameterSetName = "Explicit", Position = 1, Mandatory = false)]
        public double X0 = -1;

        [Parameter(ParameterSetName = "Explicit", Position = 2, Mandatory = false)]
        public double X1 = 1;

        [Parameter(ParameterSetName = "Implicit", Position = 0, Mandatory = true)]
        public ScriptBlock[] Fx = null;

        [Parameter(ParameterSetName = "Implicit", Position = 1, Mandatory = true)]
        public ScriptBlock[] Fy = null;

        [Parameter(ParameterSetName = "Implicit", Position = 2, Mandatory = false)]
        public double T0 = 0;

        [Parameter(ParameterSetName = "Implicit", Position = 3, Mandatory = false)]
        public double T1 = 1;

        [Parameter(Position = 4, Mandatory = false)]
        public double N  = 100;

        [Alias("Dt")]
        [Parameter(Position = 5, Mandatory = false)]
        public double Dx  =  double.NaN;

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
        public SwitchParameter PassThru = false;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 13, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 15, Mandatory = false)]
        public System.Double[] Dashes;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelMargin;

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
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 28, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.IInterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

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
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

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

        private void AssignParameters(FunctionSeries series, Dictionary<string, object> bp)
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
            var si = new SeriesInfo<FunctionSeries>();

            var bp = MyInvocation.BoundParameters;

            bool isExplicit = ParameterSetName == "Explicit";
            if (double.IsNaN(Dx))
            {
                if (isExplicit)
                    Dx = (X1 - X0) / (N - 1);
                else
                    Dx = (T1 - T0) / (N - 1);
            }

            si.Series = new List<FunctionSeries>();
            var va = new List<PSVariable>();
            if (isExplicit)
            {
                va.Add(new PSVariable("x"));
				foreach (var f in F)
				{
					var series = new FunctionSeries();
					series.Title = f.ToString();
                    AssignParameters(series, bp);
                    si.Series.Add(series);

					for (var i = X0; i <= X1 + Dx * .5; i += Dx)
					{
						va[0].Value = i;
						var y = (double)f.InvokeWithContext(null, va, null)[0].BaseObject;
						series.Points.Add(new DataPoint(i, y));
					}
                }
            }
            else
            {
                va.Add(new PSVariable("t"));
				for (var i = 0; i < Fx.Length; ++i)
				{
					var series = new FunctionSeries();
					series.Title = Fx[i].ToString() + ", " + Fy[i].ToString();
                    AssignParameters(series, bp);
                    si.Series.Add(series);

                    for (var j = T0; j <= T1 + Dx * .5; j += Dx)
                    {
                        va[0].Value = j;
                        var x = (double)Fx[i].InvokeWithContext(null, va, null)[0].BaseObject;
                        var y = (double)Fy[i].InvokeWithContext(null, va, null)[0].BaseObject;
                        series.Points.Add(new DataPoint(x, y));
                    }
                }
            }

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
