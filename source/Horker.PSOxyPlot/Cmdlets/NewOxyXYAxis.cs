
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace Horker.PSOxyPlot
{
    [Cmdlet("New", "OxyAngleAxis")]
    [Alias("oxy.axis.angle")]
    [OutputType(typeof(OxyPlot.Axes.AngleAxis))]
    public class NewOxyAngleAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StartAngle;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double EndAngle;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 4, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Angle;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 12, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 18, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 32, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Maximum;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Minimum;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 45, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 50, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 52, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 55, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 67, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 72, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 74, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Axes.AngleAxis();

            if (bp.ContainsKey("StartAngle")) axis.StartAngle = StartAngle;
            if (bp.ContainsKey("EndAngle")) axis.EndAngle = EndAngle;
            if (bp.ContainsKey("FormatAsFractions")) axis.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) axis.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) axis.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) axis.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) axis.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) axis.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) axis.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) axis.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) axis.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) axis.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) axis.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) axis.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) axis.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) axis.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) axis.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) axis.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) axis.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) axis.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = Horker.PSOxyPlot.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) axis.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) axis.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) axis.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) axis.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) axis.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) axis.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) axis.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) axis.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) axis.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) axis.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) axis.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) axis.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) axis.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) axis.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) axis.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) axis.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) axis.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) axis.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) axis.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) axis.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) axis.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) axis.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) axis.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) axis.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) axis.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) axis.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) axis.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) axis.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) axis.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) axis.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) axis.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) axis.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) axis.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) axis.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) axis.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) axis.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) axis.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) axis.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) axis.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) axis.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) axis.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) axis.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) axis.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) axis.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) axis.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyCategoryAxis")]
    [Alias("oxy.axis.category")]
    [OutputType(typeof(OxyPlot.Axes.CategoryAxis))]
    public class NewOxyCategoryAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double GapWidth;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsTickCentered;

        [Parameter(Position = 2, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 3, Mandatory = false)]
        public System.String LabelField;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 6, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Angle;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 14, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 32, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 34, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Maximum;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Minimum;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 47, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 52, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 56, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 57, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 59, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 62, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 67, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 69, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 74, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 76, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Axes.CategoryAxis();

            if (bp.ContainsKey("GapWidth")) axis.GapWidth = GapWidth;
            if (bp.ContainsKey("IsTickCentered")) axis.IsTickCentered = IsTickCentered;
            if (bp.ContainsKey("ItemsSource")) axis.ItemsSource = ItemsSource;
            if (bp.ContainsKey("LabelField")) axis.LabelField = LabelField;
            if (bp.ContainsKey("FormatAsFractions")) axis.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) axis.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) axis.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) axis.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) axis.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) axis.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) axis.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) axis.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) axis.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) axis.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) axis.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) axis.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) axis.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) axis.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) axis.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) axis.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) axis.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) axis.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = Horker.PSOxyPlot.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) axis.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) axis.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) axis.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) axis.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) axis.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) axis.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) axis.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) axis.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) axis.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) axis.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) axis.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) axis.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) axis.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) axis.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) axis.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) axis.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) axis.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) axis.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) axis.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) axis.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) axis.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) axis.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) axis.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) axis.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) axis.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) axis.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) axis.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) axis.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) axis.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) axis.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) axis.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) axis.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) axis.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) axis.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) axis.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) axis.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) axis.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) axis.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) axis.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) axis.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) axis.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) axis.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) axis.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) axis.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) axis.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyCategoryColorAxis")]
    [Alias("oxy.axis.categorycolor")]
    [OutputType(typeof(OxyPlot.Axes.CategoryColorAxis))]
    public class NewOxyCategoryColorAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor InvalidCategoryColor;

        [Parameter(Position = 1, Mandatory = false)]
        public OxyPlot.OxyPalette Palette;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double GapWidth;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsTickCentered;

        [Parameter(Position = 4, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 5, Mandatory = false)]
        public System.String LabelField;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 8, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Angle;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 16, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 22, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 34, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 36, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Maximum;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Minimum;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 49, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 54, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 56, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 59, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 64, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 67, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 69, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 71, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 74, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 76, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 78, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Axes.CategoryColorAxis();

            if (bp.ContainsKey("InvalidCategoryColor")) axis.InvalidCategoryColor = InvalidCategoryColor;
            if (bp.ContainsKey("Palette")) axis.Palette = Palette;
            if (bp.ContainsKey("GapWidth")) axis.GapWidth = GapWidth;
            if (bp.ContainsKey("IsTickCentered")) axis.IsTickCentered = IsTickCentered;
            if (bp.ContainsKey("ItemsSource")) axis.ItemsSource = ItemsSource;
            if (bp.ContainsKey("LabelField")) axis.LabelField = LabelField;
            if (bp.ContainsKey("FormatAsFractions")) axis.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) axis.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) axis.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) axis.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) axis.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) axis.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) axis.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) axis.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) axis.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) axis.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) axis.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) axis.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) axis.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) axis.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) axis.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) axis.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) axis.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) axis.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = Horker.PSOxyPlot.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) axis.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) axis.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) axis.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) axis.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) axis.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) axis.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) axis.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) axis.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) axis.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) axis.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) axis.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) axis.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) axis.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) axis.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) axis.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) axis.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) axis.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) axis.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) axis.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) axis.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) axis.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) axis.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) axis.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) axis.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) axis.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) axis.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) axis.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) axis.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) axis.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) axis.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) axis.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) axis.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) axis.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) axis.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) axis.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) axis.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) axis.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) axis.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) axis.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) axis.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) axis.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) axis.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) axis.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) axis.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) axis.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyDateTimeAxis")]
    [Alias("oxy.axis.datetime")]
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
        public Horker.PSOxyPlot.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 7, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Angle;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 35, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Maximum;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Minimum;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 55, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 58, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 66, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 68, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 75, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 77, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Axes.DateTimeAxis();

            if (bp.ContainsKey("CalendarWeekRule")) axis.CalendarWeekRule = CalendarWeekRule;
            if (bp.ContainsKey("FirstDayOfWeek")) axis.FirstDayOfWeek = FirstDayOfWeek;
            if (bp.ContainsKey("IntervalType")) axis.IntervalType = IntervalType;
            if (bp.ContainsKey("MinorIntervalType")) axis.MinorIntervalType = MinorIntervalType;
            if (bp.ContainsKey("TimeZone")) axis.TimeZone = TimeZone;
            if (bp.ContainsKey("FormatAsFractions")) axis.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) axis.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) axis.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) axis.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) axis.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) axis.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) axis.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) axis.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) axis.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) axis.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) axis.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) axis.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) axis.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) axis.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) axis.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) axis.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) axis.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) axis.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = Horker.PSOxyPlot.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) axis.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) axis.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) axis.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) axis.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) axis.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) axis.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) axis.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) axis.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) axis.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) axis.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) axis.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) axis.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) axis.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) axis.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) axis.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) axis.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) axis.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) axis.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) axis.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) axis.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) axis.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) axis.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) axis.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) axis.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) axis.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) axis.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) axis.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) axis.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) axis.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) axis.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) axis.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) axis.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) axis.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) axis.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) axis.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) axis.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) axis.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) axis.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) axis.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) axis.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) axis.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) axis.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) axis.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) axis.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) axis.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyLinearAxis")]
    [Alias("oxy.axis.linear")]
    [OutputType(typeof(OxyPlot.Axes.LinearAxis))]
    public class NewOxyLinearAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 2, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Angle;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 16, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 28, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Maximum;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Minimum;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 43, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 72, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Axes.LinearAxis();

            if (bp.ContainsKey("FormatAsFractions")) axis.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) axis.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) axis.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) axis.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) axis.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) axis.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) axis.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) axis.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) axis.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) axis.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) axis.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) axis.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) axis.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) axis.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) axis.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) axis.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) axis.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) axis.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = Horker.PSOxyPlot.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) axis.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) axis.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) axis.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) axis.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) axis.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) axis.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) axis.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) axis.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) axis.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) axis.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) axis.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) axis.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) axis.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) axis.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) axis.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) axis.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) axis.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) axis.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) axis.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) axis.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) axis.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) axis.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) axis.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) axis.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) axis.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) axis.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) axis.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) axis.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) axis.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) axis.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) axis.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) axis.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) axis.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) axis.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) axis.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) axis.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) axis.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) axis.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) axis.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) axis.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) axis.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) axis.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) axis.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) axis.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) axis.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyLinearColorAxis")]
    [Alias("oxy.axis.linearcolor")]
    [OutputType(typeof(OxyPlot.Axes.LinearColorAxis))]
    public class NewOxyLinearColorAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor InvalidNumberColor;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor HighColor;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LowColor;

        [Parameter(Position = 3, Mandatory = false)]
        public OxyPlot.OxyPalette Palette;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool RenderAsImage;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 7, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Angle;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 35, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Maximum;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Minimum;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 55, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 58, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 66, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 68, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 75, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 77, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Axes.LinearColorAxis();

            if (bp.ContainsKey("InvalidNumberColor")) axis.InvalidNumberColor = InvalidNumberColor;
            if (bp.ContainsKey("HighColor")) axis.HighColor = HighColor;
            if (bp.ContainsKey("LowColor")) axis.LowColor = LowColor;
            if (bp.ContainsKey("Palette")) axis.Palette = Palette;
            if (bp.ContainsKey("RenderAsImage")) axis.RenderAsImage = RenderAsImage;
            if (bp.ContainsKey("FormatAsFractions")) axis.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) axis.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) axis.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) axis.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) axis.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) axis.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) axis.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) axis.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) axis.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) axis.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) axis.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) axis.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) axis.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) axis.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) axis.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) axis.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) axis.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) axis.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = Horker.PSOxyPlot.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) axis.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) axis.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) axis.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) axis.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) axis.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) axis.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) axis.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) axis.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) axis.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) axis.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) axis.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) axis.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) axis.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) axis.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) axis.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) axis.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) axis.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) axis.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) axis.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) axis.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) axis.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) axis.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) axis.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) axis.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) axis.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) axis.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) axis.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) axis.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) axis.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) axis.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) axis.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) axis.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) axis.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) axis.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) axis.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) axis.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) axis.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) axis.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) axis.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) axis.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) axis.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) axis.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) axis.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) axis.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) axis.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyLogarithmicAxis")]
    [Alias("oxy.axis.logarithmic")]
    [OutputType(typeof(OxyPlot.Axes.LogarithmicAxis))]
    public class NewOxyLogarithmicAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Base;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool PowerPadding;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Angle;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 9, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 27, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 29, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Maximum;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Minimum;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 42, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 47, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 52, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 62, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 64, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 69, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 71, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Axes.LogarithmicAxis();

            if (bp.ContainsKey("Base")) axis.Base = Base;
            if (bp.ContainsKey("PowerPadding")) axis.PowerPadding = PowerPadding;
            if (bp.ContainsKey("AbsoluteMaximum")) axis.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) axis.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) axis.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) axis.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) axis.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) axis.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) axis.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) axis.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) axis.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) axis.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) axis.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) axis.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) axis.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) axis.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) axis.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = Horker.PSOxyPlot.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) axis.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) axis.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) axis.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) axis.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) axis.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) axis.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) axis.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) axis.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) axis.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) axis.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) axis.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) axis.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) axis.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) axis.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) axis.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) axis.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) axis.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) axis.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) axis.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) axis.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) axis.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) axis.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) axis.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) axis.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) axis.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) axis.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) axis.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) axis.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) axis.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) axis.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) axis.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) axis.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) axis.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) axis.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) axis.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) axis.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) axis.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) axis.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) axis.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) axis.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) axis.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) axis.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) axis.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) axis.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) axis.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyMagnitudeAxis")]
    [Alias("oxy.axis.magnitude")]
    [OutputType(typeof(OxyPlot.Axes.MagnitudeAxis))]
    public class NewOxyMagnitudeAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 2, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Angle;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 16, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 28, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Maximum;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Minimum;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 43, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 72, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Axes.MagnitudeAxis();

            if (bp.ContainsKey("FormatAsFractions")) axis.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) axis.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) axis.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) axis.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) axis.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) axis.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) axis.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) axis.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) axis.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) axis.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) axis.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) axis.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) axis.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) axis.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) axis.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) axis.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) axis.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) axis.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = Horker.PSOxyPlot.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) axis.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) axis.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) axis.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) axis.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) axis.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) axis.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) axis.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) axis.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) axis.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) axis.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) axis.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) axis.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) axis.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) axis.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) axis.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) axis.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) axis.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) axis.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) axis.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) axis.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) axis.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) axis.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) axis.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) axis.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) axis.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) axis.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) axis.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) axis.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) axis.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) axis.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) axis.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) axis.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) axis.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) axis.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) axis.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) axis.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) axis.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) axis.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) axis.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) axis.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) axis.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) axis.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) axis.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) axis.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) axis.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyRangeColorAxis")]
    [Alias("oxy.axis.rangecolor")]
    [OutputType(typeof(OxyPlot.Axes.RangeColorAxis))]
    public class NewOxyRangeColorAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor InvalidNumberColor;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor HighColor;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LowColor;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 5, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Angle;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 13, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 19, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 31, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Maximum;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Minimum;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 46, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 51, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 56, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 64, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 66, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 68, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 73, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 75, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Axes.RangeColorAxis();

            if (bp.ContainsKey("InvalidNumberColor")) axis.InvalidNumberColor = InvalidNumberColor;
            if (bp.ContainsKey("HighColor")) axis.HighColor = HighColor;
            if (bp.ContainsKey("LowColor")) axis.LowColor = LowColor;
            if (bp.ContainsKey("FormatAsFractions")) axis.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) axis.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) axis.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) axis.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) axis.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) axis.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) axis.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) axis.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) axis.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) axis.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) axis.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) axis.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) axis.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) axis.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) axis.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) axis.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) axis.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) axis.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = Horker.PSOxyPlot.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) axis.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) axis.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) axis.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) axis.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) axis.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) axis.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) axis.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) axis.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) axis.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) axis.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) axis.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) axis.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) axis.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) axis.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) axis.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) axis.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) axis.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) axis.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) axis.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) axis.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) axis.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) axis.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) axis.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) axis.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) axis.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) axis.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) axis.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) axis.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) axis.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) axis.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) axis.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) axis.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) axis.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) axis.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) axis.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) axis.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) axis.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) axis.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) axis.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) axis.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) axis.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) axis.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) axis.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) axis.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) axis.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyTimeSpanAxis")]
    [Alias("oxy.axis.timespan")]
    [OutputType(typeof(OxyPlot.Axes.TimeSpanAxis))]
    public class NewOxyTimeSpanAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool FormatAsFractions;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FractionUnit;

        [Parameter(Position = 2, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMaximum;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AbsoluteMinimum;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Angle;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTickToLabelDistance;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTitleDistance;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisDistance;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxislineThickness;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipTitle;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool CropGridlines;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double EndPosition;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 16, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double ExtraGridlineThickness;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] ExtraGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMaxValue;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FilterMinValue;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double IntervalLength;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsAxisVisible;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsPanEnabled;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsZoomEnabled;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String Key;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Func<System.Double,System.String> LabelFormatter;

        [Parameter(Position = 28, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer Layer;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MajorGridlineColor;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LineStyle MajorGridlineStyle;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorGridlineThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorStep;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MajorTickSize;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Maximum;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumPadding;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumRange;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Minimum;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMajorStep;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumMinorStep;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 43, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorGridlineThickness;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorStep;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinorTickSize;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool PositionAtZeroCrossing;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StartPosition;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleClippingLength;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitlePosition;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool UseSuperExponentialFormat;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 72, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Axes.TimeSpanAxis();

            if (bp.ContainsKey("FormatAsFractions")) axis.FormatAsFractions = FormatAsFractions;
            if (bp.ContainsKey("FractionUnit")) axis.FractionUnit = FractionUnit;
            if (bp.ContainsKey("FractionUnitSymbol")) axis.FractionUnitSymbol = FractionUnitSymbol;
            if (bp.ContainsKey("AbsoluteMaximum")) axis.AbsoluteMaximum = AbsoluteMaximum;
            if (bp.ContainsKey("AbsoluteMinimum")) axis.AbsoluteMinimum = AbsoluteMinimum;
            if (bp.ContainsKey("Angle")) axis.Angle = Angle;
            if (bp.ContainsKey("AxisTickToLabelDistance")) axis.AxisTickToLabelDistance = AxisTickToLabelDistance;
            if (bp.ContainsKey("AxisTitleDistance")) axis.AxisTitleDistance = AxisTitleDistance;
            if (bp.ContainsKey("AxisDistance")) axis.AxisDistance = AxisDistance;
            if (bp.ContainsKey("AxislineColor")) axis.AxislineColor = AxislineColor;
            if (bp.ContainsKey("AxislineStyle")) axis.AxislineStyle = AxislineStyle;
            if (bp.ContainsKey("AxislineThickness")) axis.AxislineThickness = AxislineThickness;
            if (bp.ContainsKey("ClipTitle")) axis.ClipTitle = ClipTitle;
            if (bp.ContainsKey("CropGridlines")) axis.CropGridlines = CropGridlines;
            if (bp.ContainsKey("EndPosition")) axis.EndPosition = EndPosition;
            if (bp.ContainsKey("ExtraGridlineColor")) axis.ExtraGridlineColor = ExtraGridlineColor;
            if (bp.ContainsKey("ExtraGridlineStyle")) axis.ExtraGridlineStyle = ExtraGridlineStyle;
            if (bp.ContainsKey("ExtraGridlineThickness")) axis.ExtraGridlineThickness = ExtraGridlineThickness;
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = Horker.PSOxyPlot.TypeAdaptors.Double.ConvertArray(ExtraGridlines);
            if (bp.ContainsKey("FilterFunction")) axis.FilterFunction = FilterFunction;
            if (bp.ContainsKey("FilterMaxValue")) axis.FilterMaxValue = FilterMaxValue;
            if (bp.ContainsKey("FilterMinValue")) axis.FilterMinValue = FilterMinValue;
            if (bp.ContainsKey("IntervalLength")) axis.IntervalLength = IntervalLength;
            if (bp.ContainsKey("IsAxisVisible")) axis.IsAxisVisible = IsAxisVisible;
            if (bp.ContainsKey("IsPanEnabled")) axis.IsPanEnabled = IsPanEnabled;
            if (bp.ContainsKey("IsZoomEnabled")) axis.IsZoomEnabled = IsZoomEnabled;
            if (bp.ContainsKey("Key")) axis.Key = Key;
            if (bp.ContainsKey("LabelFormatter")) axis.LabelFormatter = LabelFormatter;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("MajorGridlineColor")) axis.MajorGridlineColor = MajorGridlineColor;
            if (bp.ContainsKey("MajorGridlineStyle")) axis.MajorGridlineStyle = MajorGridlineStyle;
            if (bp.ContainsKey("MajorGridlineThickness")) axis.MajorGridlineThickness = MajorGridlineThickness;
            if (bp.ContainsKey("MajorStep")) axis.MajorStep = MajorStep;
            if (bp.ContainsKey("MajorTickSize")) axis.MajorTickSize = MajorTickSize;
            if (bp.ContainsKey("Maximum")) axis.Maximum = Maximum;
            if (bp.ContainsKey("MaximumPadding")) axis.MaximumPadding = MaximumPadding;
            if (bp.ContainsKey("MaximumRange")) axis.MaximumRange = MaximumRange;
            if (bp.ContainsKey("Minimum")) axis.Minimum = Minimum;
            if (bp.ContainsKey("MinimumMajorStep")) axis.MinimumMajorStep = MinimumMajorStep;
            if (bp.ContainsKey("MinimumMinorStep")) axis.MinimumMinorStep = MinimumMinorStep;
            if (bp.ContainsKey("MinimumPadding")) axis.MinimumPadding = MinimumPadding;
            if (bp.ContainsKey("MinimumRange")) axis.MinimumRange = MinimumRange;
            if (bp.ContainsKey("MinorGridlineColor")) axis.MinorGridlineColor = MinorGridlineColor;
            if (bp.ContainsKey("MinorGridlineStyle")) axis.MinorGridlineStyle = MinorGridlineStyle;
            if (bp.ContainsKey("MinorGridlineThickness")) axis.MinorGridlineThickness = MinorGridlineThickness;
            if (bp.ContainsKey("MinorStep")) axis.MinorStep = MinorStep;
            if (bp.ContainsKey("MinorTicklineColor")) axis.MinorTicklineColor = MinorTicklineColor;
            if (bp.ContainsKey("MinorTickSize")) axis.MinorTickSize = MinorTickSize;
            if (bp.ContainsKey("Position")) axis.Position = Position;
            if (bp.ContainsKey("PositionAtZeroCrossing")) axis.PositionAtZeroCrossing = PositionAtZeroCrossing;
            if (bp.ContainsKey("PositionTier")) axis.PositionTier = PositionTier;
            if (bp.ContainsKey("StartPosition")) axis.StartPosition = StartPosition;
            if (bp.ContainsKey("StringFormat")) axis.StringFormat = StringFormat;
            if (bp.ContainsKey("TickStyle")) axis.TickStyle = TickStyle;
            if (bp.ContainsKey("TicklineColor")) axis.TicklineColor = TicklineColor;
            if (bp.ContainsKey("Title")) axis.Title = Title;
            if (bp.ContainsKey("TitleClippingLength")) axis.TitleClippingLength = TitleClippingLength;
            if (bp.ContainsKey("TitleColor")) axis.TitleColor = TitleColor;
            if (bp.ContainsKey("TitleFont")) axis.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) axis.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) axis.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitleFormatString")) axis.TitleFormatString = TitleFormatString;
            if (bp.ContainsKey("TitlePosition")) axis.TitlePosition = TitlePosition;
            if (bp.ContainsKey("Unit")) axis.Unit = Unit;
            if (bp.ContainsKey("UseSuperExponentialFormat")) axis.UseSuperExponentialFormat = UseSuperExponentialFormat;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyArrowAnnotation")]
    [Alias("oxy.ann.arrow")]
    [OutputType(typeof(OxyPlot.Annotations.ArrowAnnotation))]
    public class NewOxyArrowAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] ArrowDirection;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] EndPoint;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double HeadLength;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double HeadWidth;

        [Parameter(Position = 5, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 6, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] StartPoint;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Veeness;

        [Parameter(Position = 10, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 12, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 13, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 16, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 25, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Annotations.ArrowAnnotation();

            if (bp.ContainsKey("ArrowDirection")) axis.ArrowDirection = new Horker.PSOxyPlot.TypeAdaptors.ScreenVector(ArrowDirection);
            if (bp.ContainsKey("Color")) axis.Color = Color;
            if (bp.ContainsKey("EndPoint")) axis.EndPoint = new Horker.PSOxyPlot.TypeAdaptors.DataPoint(EndPoint);
            if (bp.ContainsKey("HeadLength")) axis.HeadLength = HeadLength;
            if (bp.ContainsKey("HeadWidth")) axis.HeadWidth = HeadWidth;
            if (bp.ContainsKey("LineJoin")) axis.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) axis.LineStyle = LineStyle;
            if (bp.ContainsKey("StartPoint")) axis.StartPoint = new Horker.PSOxyPlot.TypeAdaptors.DataPoint(StartPoint);
            if (bp.ContainsKey("StrokeThickness")) axis.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("Veeness")) axis.Veeness = Veeness;
            if (bp.ContainsKey("Text")) axis.Text = Text;
            if (bp.ContainsKey("TextPosition")) axis.TextPosition = new Horker.PSOxyPlot.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) axis.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) axis.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) axis.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) axis.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) axis.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyEllipseAnnotation")]
    [Alias("oxy.ann.ellipse")]
    [OutputType(typeof(OxyPlot.Annotations.EllipseAnnotation))]
    public class NewOxyEllipseAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double X;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Y;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Width;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Height;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 7, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 9, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 12, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 13, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 14, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 15, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 20, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 22, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Annotations.EllipseAnnotation();

            if (bp.ContainsKey("X")) axis.X = X;
            if (bp.ContainsKey("Y")) axis.Y = Y;
            if (bp.ContainsKey("Width")) axis.Width = Width;
            if (bp.ContainsKey("Height")) axis.Height = Height;
            if (bp.ContainsKey("Fill")) axis.Fill = Fill;
            if (bp.ContainsKey("Stroke")) axis.Stroke = Stroke;
            if (bp.ContainsKey("StrokeThickness")) axis.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("Text")) axis.Text = Text;
            if (bp.ContainsKey("TextPosition")) axis.TextPosition = new Horker.PSOxyPlot.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) axis.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) axis.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) axis.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) axis.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) axis.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
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
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 4, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 5, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumX;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumY;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumX;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumY;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextMargin;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextPadding;

        [Parameter(Position = 13, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationTextOrientation TextOrientation;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextLinePosition;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipText;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipByXAxis;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipByYAxis;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Annotations.FunctionAnnotation();

            if (bp.ContainsKey("Type")) axis.Type = Type;
            if (bp.ContainsKey("Equation")) axis.Equation = Equation;
            if (bp.ContainsKey("Resolution")) axis.Resolution = Resolution;
            if (bp.ContainsKey("Color")) axis.Color = Color;
            if (bp.ContainsKey("LineJoin")) axis.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) axis.LineStyle = LineStyle;
            if (bp.ContainsKey("MaximumX")) axis.MaximumX = MaximumX;
            if (bp.ContainsKey("MaximumY")) axis.MaximumY = MaximumY;
            if (bp.ContainsKey("MinimumX")) axis.MinimumX = MinimumX;
            if (bp.ContainsKey("MinimumY")) axis.MinimumY = MinimumY;
            if (bp.ContainsKey("StrokeThickness")) axis.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("TextMargin")) axis.TextMargin = TextMargin;
            if (bp.ContainsKey("TextPadding")) axis.TextPadding = TextPadding;
            if (bp.ContainsKey("TextOrientation")) axis.TextOrientation = TextOrientation;
            if (bp.ContainsKey("TextLinePosition")) axis.TextLinePosition = TextLinePosition;
            if (bp.ContainsKey("ClipText")) axis.ClipText = ClipText;
            if (bp.ContainsKey("ClipByXAxis")) axis.ClipByXAxis = ClipByXAxis;
            if (bp.ContainsKey("ClipByYAxis")) axis.ClipByYAxis = ClipByYAxis;
            if (bp.ContainsKey("Text")) axis.Text = Text;
            if (bp.ContainsKey("TextPosition")) axis.TextPosition = new Horker.PSOxyPlot.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) axis.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) axis.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) axis.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) axis.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) axis.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyImageAnnotation")]
    [Alias("oxy.ann.image")]
    [OutputType(typeof(OxyPlot.Annotations.ImageAnnotation))]
    public class NewOxyImageAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyImage ImageSource;

        [Parameter(Position = 1, Mandatory = false)]
        public OxyPlot.HorizontalAlignment HorizontalAlignment;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.PlotLength X;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.PlotLength Y;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.PlotLength OffsetX;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.PlotLength OffsetY;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.PlotLength Width;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.PlotLength Height;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Opacity;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Interpolate;

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
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 19, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Annotations.ImageAnnotation();

            if (bp.ContainsKey("ImageSource")) axis.ImageSource = ImageSource;
            if (bp.ContainsKey("HorizontalAlignment")) axis.HorizontalAlignment = HorizontalAlignment;
            if (bp.ContainsKey("X")) axis.X = X;
            if (bp.ContainsKey("Y")) axis.Y = Y;
            if (bp.ContainsKey("OffsetX")) axis.OffsetX = OffsetX;
            if (bp.ContainsKey("OffsetY")) axis.OffsetY = OffsetY;
            if (bp.ContainsKey("Width")) axis.Width = Width;
            if (bp.ContainsKey("Height")) axis.Height = Height;
            if (bp.ContainsKey("Opacity")) axis.Opacity = Opacity;
            if (bp.ContainsKey("Interpolate")) axis.Interpolate = Interpolate;
            if (bp.ContainsKey("VerticalAlignment")) axis.VerticalAlignment = VerticalAlignment;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) axis.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) axis.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyLineAnnotation")]
    [Alias("oxy.ann.line")]
    [OutputType(typeof(OxyPlot.Annotations.LineAnnotation))]
    public class NewOxyLineAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Intercept;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Slope;

        [Parameter(Position = 2, Mandatory = false)]
        public OxyPlot.Annotations.LineAnnotationType Type;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double X;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Y;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 6, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 7, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumX;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumY;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumX;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumY;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextMargin;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextPadding;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationTextOrientation TextOrientation;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextLinePosition;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipText;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipByXAxis;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipByYAxis;

        [Parameter(Position = 20, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 22, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 25, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 35, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Annotations.LineAnnotation();

            if (bp.ContainsKey("Intercept")) axis.Intercept = Intercept;
            if (bp.ContainsKey("Slope")) axis.Slope = Slope;
            if (bp.ContainsKey("Type")) axis.Type = Type;
            if (bp.ContainsKey("X")) axis.X = X;
            if (bp.ContainsKey("Y")) axis.Y = Y;
            if (bp.ContainsKey("Color")) axis.Color = Color;
            if (bp.ContainsKey("LineJoin")) axis.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) axis.LineStyle = LineStyle;
            if (bp.ContainsKey("MaximumX")) axis.MaximumX = MaximumX;
            if (bp.ContainsKey("MaximumY")) axis.MaximumY = MaximumY;
            if (bp.ContainsKey("MinimumX")) axis.MinimumX = MinimumX;
            if (bp.ContainsKey("MinimumY")) axis.MinimumY = MinimumY;
            if (bp.ContainsKey("StrokeThickness")) axis.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("TextMargin")) axis.TextMargin = TextMargin;
            if (bp.ContainsKey("TextPadding")) axis.TextPadding = TextPadding;
            if (bp.ContainsKey("TextOrientation")) axis.TextOrientation = TextOrientation;
            if (bp.ContainsKey("TextLinePosition")) axis.TextLinePosition = TextLinePosition;
            if (bp.ContainsKey("ClipText")) axis.ClipText = ClipText;
            if (bp.ContainsKey("ClipByXAxis")) axis.ClipByXAxis = ClipByXAxis;
            if (bp.ContainsKey("ClipByYAxis")) axis.ClipByYAxis = ClipByYAxis;
            if (bp.ContainsKey("Text")) axis.Text = Text;
            if (bp.ContainsKey("TextPosition")) axis.TextPosition = new Horker.PSOxyPlot.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) axis.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) axis.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) axis.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) axis.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) axis.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyPointAnnotation")]
    [Alias("oxy.ann.point")]
    [OutputType(typeof(OxyPlot.Annotations.PointAnnotation))]
    public class NewOxyPointAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double X;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Y;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Size;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextMargin;

        [Parameter(Position = 4, Mandatory = false)]
        public OxyPlot.MarkerType Shape;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] CustomOutline;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 9, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 11, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 12, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 14, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 15, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 16, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Annotations.PointAnnotation();

            if (bp.ContainsKey("X")) axis.X = X;
            if (bp.ContainsKey("Y")) axis.Y = Y;
            if (bp.ContainsKey("Size")) axis.Size = Size;
            if (bp.ContainsKey("TextMargin")) axis.TextMargin = TextMargin;
            if (bp.ContainsKey("Shape")) axis.Shape = Shape;
            if (bp.ContainsKey("CustomOutline")) axis.CustomOutline = Horker.PSOxyPlot.TypeAdaptors.ScreenPoint.ConvertArray(CustomOutline);
            if (bp.ContainsKey("Fill")) axis.Fill = Fill;
            if (bp.ContainsKey("Stroke")) axis.Stroke = Stroke;
            if (bp.ContainsKey("StrokeThickness")) axis.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("Text")) axis.Text = Text;
            if (bp.ContainsKey("TextPosition")) axis.TextPosition = new Horker.PSOxyPlot.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) axis.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) axis.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) axis.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) axis.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) axis.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
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
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 5, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 7, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 8, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 11, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 12, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 13, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Annotations.PolygonAnnotation();

            if (bp.ContainsKey("LineJoin")) axis.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) axis.LineStyle = LineStyle;
            if (bp.ContainsKey("Fill")) axis.Fill = Fill;
            if (bp.ContainsKey("Stroke")) axis.Stroke = Stroke;
            if (bp.ContainsKey("StrokeThickness")) axis.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("Text")) axis.Text = Text;
            if (bp.ContainsKey("TextPosition")) axis.TextPosition = new Horker.PSOxyPlot.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) axis.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) axis.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) axis.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) axis.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) axis.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyPolylineAnnotation")]
    [Alias("oxy.ann.polyline")]
    [OutputType(typeof(OxyPlot.Annotations.PolylineAnnotation))]
    public class NewOxyPolylineAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 1, Mandatory = false)]
        public OxyPlot.IInterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 3, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 4, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumX;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumY;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumX;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumY;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextMargin;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextPadding;

        [Parameter(Position = 12, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationTextOrientation TextOrientation;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextLinePosition;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipText;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipByXAxis;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipByYAxis;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 19, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 22, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 32, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Annotations.PolylineAnnotation();

            if (bp.ContainsKey("MinimumSegmentLength")) axis.MinimumSegmentLength = MinimumSegmentLength;
            if (bp.ContainsKey("InterpolationAlgorithm")) axis.InterpolationAlgorithm = InterpolationAlgorithm;
            if (bp.ContainsKey("Color")) axis.Color = Color;
            if (bp.ContainsKey("LineJoin")) axis.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) axis.LineStyle = LineStyle;
            if (bp.ContainsKey("MaximumX")) axis.MaximumX = MaximumX;
            if (bp.ContainsKey("MaximumY")) axis.MaximumY = MaximumY;
            if (bp.ContainsKey("MinimumX")) axis.MinimumX = MinimumX;
            if (bp.ContainsKey("MinimumY")) axis.MinimumY = MinimumY;
            if (bp.ContainsKey("StrokeThickness")) axis.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("TextMargin")) axis.TextMargin = TextMargin;
            if (bp.ContainsKey("TextPadding")) axis.TextPadding = TextPadding;
            if (bp.ContainsKey("TextOrientation")) axis.TextOrientation = TextOrientation;
            if (bp.ContainsKey("TextLinePosition")) axis.TextLinePosition = TextLinePosition;
            if (bp.ContainsKey("ClipText")) axis.ClipText = ClipText;
            if (bp.ContainsKey("ClipByXAxis")) axis.ClipByXAxis = ClipByXAxis;
            if (bp.ContainsKey("ClipByYAxis")) axis.ClipByYAxis = ClipByYAxis;
            if (bp.ContainsKey("Text")) axis.Text = Text;
            if (bp.ContainsKey("TextPosition")) axis.TextPosition = new Horker.PSOxyPlot.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) axis.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) axis.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) axis.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) axis.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) axis.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyRectangleAnnotation")]
    [Alias("oxy.ann.rectangle")]
    [OutputType(typeof(OxyPlot.Annotations.RectangleAnnotation))]
    public class NewOxyRectangleAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumX;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumX;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MinimumY;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double MaximumY;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipByXAxis;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool ClipByYAxis;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 9, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 11, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 12, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 14, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 15, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 16, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Annotations.RectangleAnnotation();

            if (bp.ContainsKey("MinimumX")) axis.MinimumX = MinimumX;
            if (bp.ContainsKey("MaximumX")) axis.MaximumX = MaximumX;
            if (bp.ContainsKey("MinimumY")) axis.MinimumY = MinimumY;
            if (bp.ContainsKey("MaximumY")) axis.MaximumY = MaximumY;
            if (bp.ContainsKey("ClipByXAxis")) axis.ClipByXAxis = ClipByXAxis;
            if (bp.ContainsKey("ClipByYAxis")) axis.ClipByYAxis = ClipByYAxis;
            if (bp.ContainsKey("Fill")) axis.Fill = Fill;
            if (bp.ContainsKey("Stroke")) axis.Stroke = Stroke;
            if (bp.ContainsKey("StrokeThickness")) axis.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("Text")) axis.Text = Text;
            if (bp.ContainsKey("TextPosition")) axis.TextPosition = new Horker.PSOxyPlot.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) axis.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) axis.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) axis.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) axis.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) axis.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

    [Cmdlet("New", "OxyTextAnnotation")]
    [Alias("oxy.ann.text")]
    [OutputType(typeof(OxyPlot.Annotations.TextAnnotation))]
    public class NewOxyTextAnnotation : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 1, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Offset;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Padding;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 5, Mandatory = false)]
        public System.String Text;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] TextPosition;

        [Parameter(Position = 7, Mandatory = false)]
        public OxyPlot.HorizontalAlignment TextHorizontalAlignment;

        [Parameter(Position = 8, Mandatory = false)]
        public OxyPlot.VerticalAlignment TextVerticalAlignment;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TextRotation;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.Annotations.AnnotationLayer Layer;

        [Parameter(Position = 11, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 12, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 13, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var axis = new OxyPlot.Annotations.TextAnnotation();

            if (bp.ContainsKey("Background")) axis.Background = Background;
            if (bp.ContainsKey("Offset")) axis.Offset = new Horker.PSOxyPlot.TypeAdaptors.ScreenVector(Offset);
            if (bp.ContainsKey("Padding")) axis.Padding = new Horker.PSOxyPlot.TypeAdaptors.OxyThickness(Padding);
            if (bp.ContainsKey("Stroke")) axis.Stroke = Stroke;
            if (bp.ContainsKey("StrokeThickness")) axis.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("Text")) axis.Text = Text;
            if (bp.ContainsKey("TextPosition")) axis.TextPosition = new Horker.PSOxyPlot.TypeAdaptors.DataPoint(TextPosition);
            if (bp.ContainsKey("TextHorizontalAlignment")) axis.TextHorizontalAlignment = TextHorizontalAlignment;
            if (bp.ContainsKey("TextVerticalAlignment")) axis.TextVerticalAlignment = TextVerticalAlignment;
            if (bp.ContainsKey("TextRotation")) axis.TextRotation = TextRotation;
            if (bp.ContainsKey("Layer")) axis.Layer = Layer;
            if (bp.ContainsKey("XAxisKey")) axis.XAxisKey = XAxisKey;
            if (bp.ContainsKey("YAxisKey")) axis.YAxisKey = YAxisKey;
            if (bp.ContainsKey("Font")) axis.Font = Font;
            if (bp.ContainsKey("FontSize")) axis.FontSize = FontSize;
            if (bp.ContainsKey("FontWeight")) axis.FontWeight = FontWeight;
            if (bp.ContainsKey("Tag")) axis.Tag = Tag;
            if (bp.ContainsKey("TextColor")) axis.TextColor = TextColor;
            if (bp.ContainsKey("ToolTip")) axis.ToolTip = ToolTip;
            if (bp.ContainsKey("Selectable")) axis.Selectable = Selectable;
            if (bp.ContainsKey("SelectionMode")) axis.SelectionMode = SelectionMode;

            WriteObject(axis);
        }
    }

}
