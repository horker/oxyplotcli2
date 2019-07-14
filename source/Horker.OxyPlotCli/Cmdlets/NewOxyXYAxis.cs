
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;
using Horker.OxyPlotCli.Styles;

namespace Horker.OxyPlotCli.Cmdlets
{
    [Cmdlet("New", "OxyAngleAxis")]
    [Alias("oxy.axis.angle")]
    [OutputType(typeof(OxyPlot.Axes.AngleAxis))]
    public class NewOxyAngleAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StartAngle;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double EndAngle;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 4, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Angle;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 12, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 18, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 32, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Maximum;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Minimum;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 45, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 50, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 52, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 55, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 67, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 72, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 74, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 75, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 76, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 77, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Axes.AngleAxis();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("StartAngle")) obj.StartAngle = StartAngle;
            if (bp.ContainsKey("EndAngle")) obj.EndAngle = EndAngle;
            if (bp.ContainsKey("FormatAsFractions")) obj.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) obj.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) obj.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) obj.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) obj.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) obj.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) obj.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) obj.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) obj.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) obj.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) obj.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) obj.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) obj.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) obj.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) obj.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) obj.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) obj.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) obj.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) obj.ExtraGridlines = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) obj.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) obj.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) obj.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) obj.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) obj.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) obj.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) obj.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) obj.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) obj.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) obj.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) obj.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) obj.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) obj.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) obj.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) obj.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) obj.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) obj.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) obj.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) obj.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) obj.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) obj.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) obj.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) obj.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) obj.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) obj.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) obj.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) obj.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) obj.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) obj.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) obj.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) obj.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) obj.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) obj.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) obj.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) obj.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) obj.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) obj.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) obj.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) obj.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) obj.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) obj.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) obj.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) obj.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) obj.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) obj.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Axes.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyCategoryAxis")]
    [Alias("oxy.axis.category")]
    [OutputType(typeof(OxyPlot.Axes.CategoryAxis))]
    public class NewOxyCategoryAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double GapWidth;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsTickCentered;

        [Parameter(Position = 2, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 3, Mandatory = false)]
        public System.String LabelField;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 6, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Angle;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 14, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 32, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 34, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Maximum;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Minimum;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 47, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 52, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 56, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 57, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 59, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 62, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 67, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 69, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 74, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 76, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 77, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 78, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 79, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Axes.CategoryAxis();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("GapWidth")) obj.GapWidth = GapWidth;
            if (bp.ContainsKey("IsTickCentered")) obj.IsTickCentered = IsTickCentered;
            if (bp.ContainsKey("ItemsSource")) obj.ItemsSource = ItemsSource;
            if (bp.ContainsKey("LabelField")) obj.LabelField = LabelField;
            if (bp.ContainsKey("FormatAsFractions")) obj.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) obj.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) obj.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) obj.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) obj.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) obj.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) obj.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) obj.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) obj.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) obj.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) obj.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) obj.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) obj.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) obj.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) obj.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) obj.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) obj.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) obj.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) obj.ExtraGridlines = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) obj.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) obj.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) obj.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) obj.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) obj.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) obj.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) obj.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) obj.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) obj.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) obj.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) obj.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) obj.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) obj.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) obj.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) obj.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) obj.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) obj.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) obj.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) obj.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) obj.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) obj.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) obj.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) obj.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) obj.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) obj.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) obj.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) obj.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) obj.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) obj.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) obj.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) obj.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) obj.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) obj.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) obj.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) obj.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) obj.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) obj.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) obj.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) obj.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) obj.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) obj.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) obj.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) obj.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) obj.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) obj.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Axes.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyCategoryColorAxis")]
    [Alias("oxy.axis.categoryColor")]
    [OutputType(typeof(OxyPlot.Axes.CategoryColorAxis))]
    public class NewOxyCategoryColorAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor InvalidCategoryColor;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] Palette;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double GapWidth;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsTickCentered;

        [Parameter(Position = 4, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 5, Mandatory = false)]
        public System.String LabelField;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 8, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Angle;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 16, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 22, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 34, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 36, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Maximum;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Minimum;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 49, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 54, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 56, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 59, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 64, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 67, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 69, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 71, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 74, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 76, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 78, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 79, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 80, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 81, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Axes.CategoryColorAxis();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("InvalidCategoryColor")) obj.InvalidCategoryColor = InvalidCategoryColor;
            if (bp.ContainsKey("Palette")) obj.Palette = new Horker.OxyPlotCli.TypeAdaptors.OxyPalette(Palette);
            if (bp.ContainsKey("GapWidth")) obj.GapWidth = GapWidth;
            if (bp.ContainsKey("IsTickCentered")) obj.IsTickCentered = IsTickCentered;
            if (bp.ContainsKey("ItemsSource")) obj.ItemsSource = ItemsSource;
            if (bp.ContainsKey("LabelField")) obj.LabelField = LabelField;
            if (bp.ContainsKey("FormatAsFractions")) obj.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) obj.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) obj.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) obj.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) obj.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) obj.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) obj.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) obj.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) obj.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) obj.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) obj.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) obj.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) obj.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) obj.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) obj.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) obj.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) obj.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) obj.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) obj.ExtraGridlines = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) obj.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) obj.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) obj.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) obj.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) obj.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) obj.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) obj.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) obj.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) obj.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) obj.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) obj.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) obj.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) obj.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) obj.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) obj.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) obj.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) obj.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) obj.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) obj.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) obj.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) obj.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) obj.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) obj.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) obj.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) obj.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) obj.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) obj.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) obj.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) obj.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) obj.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) obj.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) obj.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) obj.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) obj.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) obj.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) obj.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) obj.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) obj.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) obj.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) obj.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) obj.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) obj.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) obj.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) obj.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) obj.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Axes.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyDateTimeAxis")]
    [Alias("oxy.axis.dateTime")]
    [OutputType(typeof(OxyPlot.Axes.DateTimeAxis))]
    public class NewOxyDateTimeAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public System.Globalization.CalendarWeekRule CalendarWeekRule;

        [Parameter(Position = 1, Mandatory = false)]
        public System.DayOfWeek FirstDayOfWeek;

        [Parameter(Position = 2, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType IntervalType;

        [Parameter(Position = 3, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType MinorIntervalType;

        [Parameter(Position = 4, Mandatory = false)]
        public System.TimeZoneInfo TimeZone;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 7, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Angle;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 35, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Maximum;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Minimum;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 55, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 58, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 66, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 68, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 75, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 77, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 78, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 79, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 80, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Axes.DateTimeAxis();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("CalendarWeekRule")) obj.CalendarWeekRule = CalendarWeekRule;
            if (bp.ContainsKey("FirstDayOfWeek")) obj.FirstDayOfWeek = FirstDayOfWeek;
            if (bp.ContainsKey("IntervalType")) obj.IntervalType = IntervalType;
            if (bp.ContainsKey("MinorIntervalType")) obj.MinorIntervalType = MinorIntervalType;
            if (bp.ContainsKey("TimeZone")) obj.TimeZone = TimeZone;
            if (bp.ContainsKey("FormatAsFractions")) obj.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) obj.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) obj.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) obj.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) obj.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) obj.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) obj.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) obj.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) obj.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) obj.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) obj.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) obj.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) obj.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) obj.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) obj.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) obj.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) obj.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) obj.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) obj.ExtraGridlines = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) obj.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) obj.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) obj.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) obj.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) obj.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) obj.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) obj.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) obj.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) obj.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) obj.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) obj.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) obj.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) obj.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) obj.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) obj.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) obj.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) obj.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) obj.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) obj.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) obj.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) obj.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) obj.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) obj.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) obj.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) obj.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) obj.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) obj.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) obj.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) obj.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) obj.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) obj.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) obj.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) obj.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) obj.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) obj.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) obj.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) obj.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) obj.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) obj.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) obj.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) obj.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) obj.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) obj.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) obj.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) obj.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Axes.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyLinearAxis")]
    [Alias("oxy.axis.linear")]
    [OutputType(typeof(OxyPlot.Axes.LinearAxis))]
    public class NewOxyLinearAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 2, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Angle;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 16, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 28, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Maximum;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Minimum;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 43, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 72, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 73, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 74, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 75, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Axes.LinearAxis();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("FormatAsFractions")) obj.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) obj.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) obj.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) obj.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) obj.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) obj.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) obj.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) obj.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) obj.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) obj.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) obj.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) obj.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) obj.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) obj.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) obj.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) obj.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) obj.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) obj.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) obj.ExtraGridlines = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) obj.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) obj.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) obj.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) obj.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) obj.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) obj.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) obj.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) obj.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) obj.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) obj.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) obj.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) obj.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) obj.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) obj.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) obj.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) obj.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) obj.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) obj.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) obj.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) obj.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) obj.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) obj.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) obj.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) obj.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) obj.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) obj.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) obj.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) obj.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) obj.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) obj.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) obj.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) obj.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) obj.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) obj.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) obj.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) obj.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) obj.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) obj.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) obj.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) obj.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) obj.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) obj.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) obj.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) obj.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) obj.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Axes.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyLinearColorAxis")]
    [Alias("oxy.axis.linearColor")]
    [OutputType(typeof(OxyPlot.Axes.LinearColorAxis))]
    public class NewOxyLinearColorAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor InvalidNumberColor;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor HighColor;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor LowColor;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] Palette;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderAsImage;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 7, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Angle;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 35, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Maximum;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Minimum;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 55, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 58, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 66, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 68, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 75, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 77, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 78, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 79, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 80, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Axes.LinearColorAxis();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("InvalidNumberColor")) obj.InvalidNumberColor = InvalidNumberColor;
            if (bp.ContainsKey("HighColor")) obj.HighColor = HighColor;
            if (bp.ContainsKey("LowColor")) obj.LowColor = LowColor;
            if (bp.ContainsKey("Palette")) obj.Palette = new Horker.OxyPlotCli.TypeAdaptors.OxyPalette(Palette);
            if (bp.ContainsKey("RenderAsImage")) obj.RenderAsImage = RenderAsImage;
            if (bp.ContainsKey("FormatAsFractions")) obj.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) obj.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) obj.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) obj.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) obj.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) obj.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) obj.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) obj.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) obj.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) obj.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) obj.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) obj.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) obj.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) obj.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) obj.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) obj.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) obj.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) obj.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) obj.ExtraGridlines = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) obj.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) obj.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) obj.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) obj.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) obj.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) obj.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) obj.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) obj.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) obj.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) obj.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) obj.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) obj.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) obj.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) obj.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) obj.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) obj.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) obj.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) obj.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) obj.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) obj.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) obj.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) obj.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) obj.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) obj.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) obj.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) obj.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) obj.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) obj.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) obj.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) obj.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) obj.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) obj.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) obj.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) obj.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) obj.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) obj.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) obj.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) obj.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) obj.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) obj.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) obj.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) obj.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) obj.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) obj.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) obj.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Axes.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyLogarithmicAxis")]
    [Alias("oxy.axis.logarithmic")]
    [OutputType(typeof(OxyPlot.Axes.LogarithmicAxis))]
    public class NewOxyLogarithmicAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Base;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool PowerPadding;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Angle;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 9, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 27, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 29, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Maximum;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Minimum;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 42, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 47, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 52, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 62, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 64, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 69, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 71, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 72, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 73, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 74, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Axes.LogarithmicAxis();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("Base")) obj.Base = Base;
            if (bp.ContainsKey("PowerPadding")) obj.PowerPadding = PowerPadding;
            if (bp.ContainsKey("AbsoluteMaximum")) obj.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) obj.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) obj.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) obj.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) obj.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) obj.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) obj.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) obj.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) obj.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) obj.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) obj.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) obj.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) obj.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) obj.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) obj.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) obj.ExtraGridlines = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) obj.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) obj.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) obj.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) obj.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) obj.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) obj.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) obj.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) obj.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) obj.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) obj.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) obj.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) obj.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) obj.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) obj.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) obj.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) obj.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) obj.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) obj.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) obj.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) obj.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) obj.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) obj.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) obj.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) obj.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) obj.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) obj.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) obj.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) obj.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) obj.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) obj.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) obj.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) obj.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) obj.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) obj.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) obj.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) obj.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) obj.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) obj.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) obj.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) obj.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) obj.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) obj.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) obj.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) obj.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) obj.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Axes.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyMagnitudeAxis")]
    [Alias("oxy.axis.magnitude")]
    [OutputType(typeof(OxyPlot.Axes.MagnitudeAxis))]
    public class NewOxyMagnitudeAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 2, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Angle;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 16, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 28, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Maximum;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Minimum;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 43, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 72, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 73, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 74, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 75, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Axes.MagnitudeAxis();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("FormatAsFractions")) obj.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) obj.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) obj.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) obj.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) obj.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) obj.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) obj.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) obj.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) obj.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) obj.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) obj.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) obj.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) obj.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) obj.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) obj.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) obj.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) obj.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) obj.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) obj.ExtraGridlines = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) obj.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) obj.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) obj.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) obj.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) obj.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) obj.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) obj.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) obj.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) obj.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) obj.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) obj.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) obj.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) obj.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) obj.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) obj.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) obj.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) obj.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) obj.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) obj.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) obj.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) obj.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) obj.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) obj.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) obj.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) obj.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) obj.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) obj.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) obj.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) obj.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) obj.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) obj.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) obj.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) obj.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) obj.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) obj.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) obj.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) obj.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) obj.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) obj.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) obj.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) obj.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) obj.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) obj.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) obj.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) obj.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Axes.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyRangeColorAxis")]
    [Alias("oxy.axis.rangeColor")]
    [OutputType(typeof(OxyPlot.Axes.RangeColorAxis))]
    public class NewOxyRangeColorAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor InvalidNumberColor;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor HighColor;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor LowColor;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 5, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Angle;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 13, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 19, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 31, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Maximum;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Minimum;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 46, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 51, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 56, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 64, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 66, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 68, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 73, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 75, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 76, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 77, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 78, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Axes.RangeColorAxis();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("InvalidNumberColor")) obj.InvalidNumberColor = InvalidNumberColor;
            if (bp.ContainsKey("HighColor")) obj.HighColor = HighColor;
            if (bp.ContainsKey("LowColor")) obj.LowColor = LowColor;
            if (bp.ContainsKey("FormatAsFractions")) obj.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) obj.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) obj.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) obj.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) obj.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) obj.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) obj.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) obj.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) obj.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) obj.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) obj.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) obj.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) obj.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) obj.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) obj.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) obj.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) obj.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) obj.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) obj.ExtraGridlines = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) obj.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) obj.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) obj.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) obj.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) obj.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) obj.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) obj.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) obj.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) obj.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) obj.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) obj.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) obj.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) obj.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) obj.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) obj.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) obj.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) obj.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) obj.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) obj.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) obj.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) obj.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) obj.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) obj.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) obj.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) obj.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) obj.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) obj.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) obj.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) obj.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) obj.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) obj.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) obj.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) obj.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) obj.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) obj.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) obj.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) obj.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) obj.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) obj.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) obj.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) obj.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) obj.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) obj.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) obj.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) obj.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Axes.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyTimeSpanAxis")]
    [Alias("oxy.axis.timeSpan")]
    [OutputType(typeof(OxyPlot.Axes.TimeSpanAxis))]
    public class NewOxyTimeSpanAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 2, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Angle;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 16, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 28, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Maximum;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Minimum;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 43, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 72, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 73, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 74, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 75, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Axes.TimeSpanAxis();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("FormatAsFractions")) obj.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) obj.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) obj.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) obj.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) obj.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) obj.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) obj.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) obj.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) obj.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) obj.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) obj.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) obj.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) obj.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) obj.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) obj.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) obj.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) obj.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) obj.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) obj.ExtraGridlines = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) obj.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) obj.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) obj.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) obj.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) obj.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) obj.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) obj.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) obj.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) obj.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) obj.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) obj.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) obj.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) obj.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) obj.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) obj.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) obj.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) obj.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) obj.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) obj.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) obj.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) obj.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) obj.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) obj.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) obj.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) obj.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) obj.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) obj.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) obj.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) obj.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) obj.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) obj.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) obj.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) obj.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) obj.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) obj.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) obj.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) obj.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) obj.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) obj.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) obj.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) obj.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) obj.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) obj.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) obj.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) obj.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Axes.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyArrowAnnotation")]
    [Alias("oxy.ann.arrow")]
    [OutputType(typeof(OxyPlot.Annotations.ArrowAnnotation))]
    public class NewOxyArrowAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ArrowDirection;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] EndPoint;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double HeadLength;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double HeadWidth;

        [Parameter(Position = 5, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 6, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] StartPoint;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Veeness;

        [Parameter(Position = 10, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 12, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 13, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 16, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 25, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 26, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 27, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 28, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Annotations.ArrowAnnotation();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("ArrowDirection")) obj.ArrowDirection = new Horker.OxyPlotCli.TypeAdaptors.ScreenVector(ArrowDirection);
            if (bp.ContainsKey("Color")) obj.Color = Color;
            if (bp.ContainsKey("EndPoint")) obj.EndPoint = new Horker.OxyPlotCli.TypeAdaptors.DataPoint(EndPoint);
            if (bp.ContainsKey("HeadLength")) obj.HeadLength = HeadLength;
            if (bp.ContainsKey("HeadWidth")) obj.HeadWidth = HeadWidth;
            if (bp.ContainsKey("LineJoin")) obj.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) obj.LineStyle = LineStyle;
            if (bp.ContainsKey("StartPoint")) obj.StartPoint = new Horker.OxyPlotCli.TypeAdaptors.DataPoint(StartPoint);
            if (bp.ContainsKey("StrokeThickness")) obj.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("Veeness")) obj.Veeness = Veeness;
            if (bp.ContainsKey("Text")) obj.Text = Text;
            if (bp.ContainsKey("TextPosition")) obj.TextPosition = new Horker.OxyPlotCli.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) obj.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) obj.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) obj.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) obj.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) obj.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Annotations.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyEllipseAnnotation")]
    [Alias("oxy.ann.ellipse")]
    [OutputType(typeof(OxyPlot.Annotations.EllipseAnnotation))]
    public class NewOxyEllipseAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double X;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Y;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Width;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Height;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 7, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 9, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 12, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 13, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 14, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 15, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 20, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 22, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 23, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 24, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 25, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Annotations.EllipseAnnotation();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("X")) obj.X = X;
            if (bp.ContainsKey("Y")) obj.Y = Y;
            if (bp.ContainsKey("Width")) obj.Width = Width;
            if (bp.ContainsKey("Height")) obj.Height = Height;
            if (bp.ContainsKey("Fill")) obj.Fill = Fill;
            if (bp.ContainsKey("Stroke")) obj.Stroke = Stroke;
            if (bp.ContainsKey("StrokeThickness")) obj.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("Text")) obj.Text = Text;
            if (bp.ContainsKey("TextPosition")) obj.TextPosition = new Horker.OxyPlotCli.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) obj.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) obj.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) obj.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) obj.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) obj.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Annotations.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyFunctionAnnotation")]
    [Alias("oxy.ann.function")]
    [OutputType(typeof(OxyPlot.Annotations.FunctionAnnotation))]
    public class NewOxyFunctionAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public OxyPlot.Annotations.FunctionAnnotationType Type;

        [Parameter(Position = 1, Mandatory = false)]
        public System.Func<System.Double,System.Double> Equation;

        [Parameter(Position = 2, Mandatory = false)]
        public System.Int32 Resolution;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 4, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 5, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumX;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumY;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumX;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumY;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextMargin;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextPadding;

        [Parameter(Position = 13, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationTextOrientation TextOrientation;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextLinePosition;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipText;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipByXAxis;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipByYAxis;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 34, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 35, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 36, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Annotations.FunctionAnnotation();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("Type")) obj.Type = Type;
            if (bp.ContainsKey("Equation")) obj.Equation = Equation;
            if (bp.ContainsKey("Resolution")) obj.Resolution = Resolution;
            if (bp.ContainsKey("Color")) obj.Color = Color;
            if (bp.ContainsKey("LineJoin")) obj.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) obj.LineStyle = LineStyle;
            if (bp.ContainsKey("MaximumX")) obj.MaximumX = MaximumX;
            if (bp.ContainsKey("MaximumY")) obj.MaximumY = MaximumY;
            if (bp.ContainsKey("MinimumX")) obj.MinimumX = MinimumX;
            if (bp.ContainsKey("MinimumY")) obj.MinimumY = MinimumY;
            if (bp.ContainsKey("StrokeThickness")) obj.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("TextMargin")) obj.TextMargin = TextMargin;
            if (bp.ContainsKey("TextPadding")) obj.TextPadding = TextPadding;
            if (bp.ContainsKey("TextOrientation")) obj.TextOrientation = TextOrientation;
            if (bp.ContainsKey("TextLinePosition")) obj.TextLinePosition = TextLinePosition;
            if (bp.ContainsKey("ClipText")) obj.ClipText = ClipText;
            if (bp.ContainsKey("ClipByXAxis")) obj.ClipByXAxis = ClipByXAxis;
            if (bp.ContainsKey("ClipByYAxis")) obj.ClipByYAxis = ClipByYAxis;
            if (bp.ContainsKey("Text")) obj.Text = Text;
            if (bp.ContainsKey("TextPosition")) obj.TextPosition = new Horker.OxyPlotCli.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) obj.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) obj.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) obj.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) obj.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) obj.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Annotations.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyImageAnnotation")]
    [Alias("oxy.ann.image")]
    [OutputType(typeof(OxyPlot.Annotations.ImageAnnotation))]
    public class NewOxyImageAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyImage ImageSource;

        [Parameter(Position = 1, Mandatory = false)]
        public OxyPlot.HorizontalAlignment HorizontalAlignment;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.PlotLength X;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.PlotLength Y;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.PlotLength OffsetX;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.PlotLength OffsetY;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.PlotLength Width;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.PlotLength Height;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Opacity;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Interpolate;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.VerticalAlignment VerticalAlignment;

        [Parameter(Position = 11, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 12, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 13, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 14, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 19, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 22, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 23, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 24, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Annotations.ImageAnnotation();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("ImageSource")) obj.ImageSource = ImageSource;
            if (bp.ContainsKey("HorizontalAlignment")) obj.HorizontalAlignment = HorizontalAlignment;
            if (bp.ContainsKey("X")) obj.X = X;
            if (bp.ContainsKey("Y")) obj.Y = Y;
            if (bp.ContainsKey("OffsetX")) obj.OffsetX = OffsetX;
            if (bp.ContainsKey("OffsetY")) obj.OffsetY = OffsetY;
            if (bp.ContainsKey("Width")) obj.Width = Width;
            if (bp.ContainsKey("Height")) obj.Height = Height;
            if (bp.ContainsKey("Opacity")) obj.Opacity = Opacity;
            if (bp.ContainsKey("Interpolate")) obj.Interpolate = Interpolate;
            if (bp.ContainsKey("VerticalAlignment")) obj.VerticalAlignment = VerticalAlignment;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) obj.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) obj.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Annotations.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyLineAnnotation")]
    [Alias("oxy.ann.line")]
    [OutputType(typeof(OxyPlot.Annotations.LineAnnotation))]
    public class NewOxyLineAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Intercept;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Slope;

        [Parameter(Position = 2, Mandatory = false)]
        public OxyPlot.Annotations.LineAnnotationType Type;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double X;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Y;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 6, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 7, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumX;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumY;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumX;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumY;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextMargin;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextPadding;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationTextOrientation TextOrientation;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextLinePosition;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipText;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipByXAxis;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipByYAxis;

        [Parameter(Position = 20, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 22, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 25, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 35, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 36, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 37, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 38, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Annotations.LineAnnotation();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("Intercept")) obj.Intercept = Intercept;
            if (bp.ContainsKey("Slope")) obj.Slope = Slope;
            if (bp.ContainsKey("Type")) obj.Type = Type;
            if (bp.ContainsKey("X")) obj.X = X;
            if (bp.ContainsKey("Y")) obj.Y = Y;
            if (bp.ContainsKey("Color")) obj.Color = Color;
            if (bp.ContainsKey("LineJoin")) obj.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) obj.LineStyle = LineStyle;
            if (bp.ContainsKey("MaximumX")) obj.MaximumX = MaximumX;
            if (bp.ContainsKey("MaximumY")) obj.MaximumY = MaximumY;
            if (bp.ContainsKey("MinimumX")) obj.MinimumX = MinimumX;
            if (bp.ContainsKey("MinimumY")) obj.MinimumY = MinimumY;
            if (bp.ContainsKey("StrokeThickness")) obj.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("TextMargin")) obj.TextMargin = TextMargin;
            if (bp.ContainsKey("TextPadding")) obj.TextPadding = TextPadding;
            if (bp.ContainsKey("TextOrientation")) obj.TextOrientation = TextOrientation;
            if (bp.ContainsKey("TextLinePosition")) obj.TextLinePosition = TextLinePosition;
            if (bp.ContainsKey("ClipText")) obj.ClipText = ClipText;
            if (bp.ContainsKey("ClipByXAxis")) obj.ClipByXAxis = ClipByXAxis;
            if (bp.ContainsKey("ClipByYAxis")) obj.ClipByYAxis = ClipByYAxis;
            if (bp.ContainsKey("Text")) obj.Text = Text;
            if (bp.ContainsKey("TextPosition")) obj.TextPosition = new Horker.OxyPlotCli.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) obj.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) obj.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) obj.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) obj.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) obj.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Annotations.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyPointAnnotation")]
    [Alias("oxy.ann.point")]
    [OutputType(typeof(OxyPlot.Annotations.PointAnnotation))]
    public class NewOxyPointAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double X;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Y;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Size;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextMargin;

        [Parameter(Position = 4, Mandatory = false)]
        public OxyPlot.MarkerType Shape;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] CustomOutline;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 9, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 11, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 12, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 14, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 15, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 16, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 25, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 26, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 27, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Annotations.PointAnnotation();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("X")) obj.X = X;
            if (bp.ContainsKey("Y")) obj.Y = Y;
            if (bp.ContainsKey("Size")) obj.Size = Size;
            if (bp.ContainsKey("TextMargin")) obj.TextMargin = TextMargin;
            if (bp.ContainsKey("Shape")) obj.Shape = Shape;
            if (bp.ContainsKey("CustomOutline")) obj.CustomOutline = Horker.OxyPlotCli.TypeAdaptors.ScreenPoint.ConvertArray(CustomOutline);
            if (bp.ContainsKey("Fill")) obj.Fill = Fill;
            if (bp.ContainsKey("Stroke")) obj.Stroke = Stroke;
            if (bp.ContainsKey("StrokeThickness")) obj.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("Text")) obj.Text = Text;
            if (bp.ContainsKey("TextPosition")) obj.TextPosition = new Horker.OxyPlotCli.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) obj.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) obj.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) obj.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) obj.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) obj.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Annotations.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyPolygonAnnotation")]
    [Alias("oxy.ann.polygon")]
    [OutputType(typeof(OxyPlot.Annotations.PolygonAnnotation))]
    public class NewOxyPolygonAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 1, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 5, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 7, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 8, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 11, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 12, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 13, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 21, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 22, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 23, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Annotations.PolygonAnnotation();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("LineJoin")) obj.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) obj.LineStyle = LineStyle;
            if (bp.ContainsKey("Fill")) obj.Fill = Fill;
            if (bp.ContainsKey("Stroke")) obj.Stroke = Stroke;
            if (bp.ContainsKey("StrokeThickness")) obj.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("Text")) obj.Text = Text;
            if (bp.ContainsKey("TextPosition")) obj.TextPosition = new Horker.OxyPlotCli.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) obj.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) obj.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) obj.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) obj.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) obj.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Annotations.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyPolylineAnnotation")]
    [Alias("oxy.ann.polyline")]
    [OutputType(typeof(OxyPlot.Annotations.PolylineAnnotation))]
    public class NewOxyPolylineAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.InterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 3, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 4, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumX;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumY;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumX;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumY;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextMargin;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextPadding;

        [Parameter(Position = 12, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationTextOrientation TextOrientation;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextLinePosition;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipText;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipByXAxis;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipByYAxis;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 19, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 22, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 32, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 33, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 34, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 35, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Annotations.PolylineAnnotation();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("MinimumSegmentLength")) obj.MinimumSegmentLength = MinimumSegmentLength;
            if (bp.ContainsKey("InterpolationAlgorithm")) obj.InterpolationAlgorithm = InterpolationAlgorithm.Value;
            if (bp.ContainsKey("Color")) obj.Color = Color;
            if (bp.ContainsKey("LineJoin")) obj.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) obj.LineStyle = LineStyle;
            if (bp.ContainsKey("MaximumX")) obj.MaximumX = MaximumX;
            if (bp.ContainsKey("MaximumY")) obj.MaximumY = MaximumY;
            if (bp.ContainsKey("MinimumX")) obj.MinimumX = MinimumX;
            if (bp.ContainsKey("MinimumY")) obj.MinimumY = MinimumY;
            if (bp.ContainsKey("StrokeThickness")) obj.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("TextMargin")) obj.TextMargin = TextMargin;
            if (bp.ContainsKey("TextPadding")) obj.TextPadding = TextPadding;
            if (bp.ContainsKey("TextOrientation")) obj.TextOrientation = TextOrientation;
            if (bp.ContainsKey("TextLinePosition")) obj.TextLinePosition = TextLinePosition;
            if (bp.ContainsKey("ClipText")) obj.ClipText = ClipText;
            if (bp.ContainsKey("ClipByXAxis")) obj.ClipByXAxis = ClipByXAxis;
            if (bp.ContainsKey("ClipByYAxis")) obj.ClipByYAxis = ClipByYAxis;
            if (bp.ContainsKey("Text")) obj.Text = Text;
            if (bp.ContainsKey("TextPosition")) obj.TextPosition = new Horker.OxyPlotCli.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) obj.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) obj.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) obj.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) obj.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) obj.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Annotations.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyRectangleAnnotation")]
    [Alias("oxy.ann.rectangle")]
    [OutputType(typeof(OxyPlot.Annotations.RectangleAnnotation))]
    public class NewOxyRectangleAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumX;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumX;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumY;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MaximumY;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipByXAxis;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ClipByYAxis;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 9, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 11, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 12, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 14, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 15, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 16, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 25, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 26, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 27, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Annotations.RectangleAnnotation();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("MinimumX")) obj.MinimumX = MinimumX;
            if (bp.ContainsKey("MaximumX")) obj.MaximumX = MaximumX;
            if (bp.ContainsKey("MinimumY")) obj.MinimumY = MinimumY;
            if (bp.ContainsKey("MaximumY")) obj.MaximumY = MaximumY;
            if (bp.ContainsKey("ClipByXAxis")) obj.ClipByXAxis = ClipByXAxis;
            if (bp.ContainsKey("ClipByYAxis")) obj.ClipByYAxis = ClipByYAxis;
            if (bp.ContainsKey("Fill")) obj.Fill = Fill;
            if (bp.ContainsKey("Stroke")) obj.Stroke = Stroke;
            if (bp.ContainsKey("StrokeThickness")) obj.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("Text")) obj.Text = Text;
            if (bp.ContainsKey("TextPosition")) obj.TextPosition = new Horker.OxyPlotCli.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) obj.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) obj.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) obj.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) obj.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) obj.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Annotations.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

    [Cmdlet("New", "OxyTextAnnotation")]
    [Alias("oxy.ann.text")]
    [OutputType(typeof(OxyPlot.Annotations.TextAnnotation))]
    public class NewOxyTextAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Offset;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Padding;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 5, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 7, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 8, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 11, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 12, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 13, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 21, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 22, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 23, Mandatory = false)]
        public string Style = null;

        protected override void BeginProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var obj = new OxyPlot.Annotations.TextAnnotation();
            style.ApplyStyleTo(obj);

            if (bp.ContainsKey("Background")) obj.Background = Background;
            if (bp.ContainsKey("Offset")) obj.Offset = new Horker.OxyPlotCli.TypeAdaptors.ScreenVector(Offset);
            if (bp.ContainsKey("Padding")) obj.Padding = new Horker.OxyPlotCli.TypeAdaptors.OxyThickness(Padding);
            if (bp.ContainsKey("Stroke")) obj.Stroke = Stroke;
            if (bp.ContainsKey("StrokeThickness")) obj.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("Text")) obj.Text = Text;
            if (bp.ContainsKey("TextPosition")) obj.TextPosition = new Horker.OxyPlotCli.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) obj.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) obj.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) obj.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) obj.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) obj.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) obj.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) obj.Font = Font;
            if (bp.ContainsKey("FontSize")) obj.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) obj.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) obj.Tag = Tag;
            if (bp.ContainsKey("TextColor")) obj.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) obj.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) obj.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) obj.SelectionMode = SelectionMode;

            if (AddTo != null)
            {
                AddTo.Annotations.Add(obj);
            
                if (PassThru)
                    WriteObject(obj);
            }
            else
            {
                WriteObject(obj);
            }
        }
    }

}
