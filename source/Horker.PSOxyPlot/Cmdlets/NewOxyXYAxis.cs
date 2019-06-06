
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
    [Cmdlet("New", "OxyLinearAxis")]
    [Alias("oxy.linearAxis", "oxylinearAxis")]
    [OutputType(typeof(OxyPlot.Axes.LinearAxis))]
    public class NewOxyLinearAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public System.Boolean FormatAsFractions;

        [Parameter(Position = 1, Mandatory = false)]
        public System.Double FractionUnit;

        [Parameter(Position = 2, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 3, Mandatory = false)]
        public System.Double AbsoluteMaximum;

        [Parameter(Position = 4, Mandatory = false)]
        public System.Double AbsoluteMinimum;

        [Parameter(Position = 5, Mandatory = false)]
        public System.Double Angle;

        [Parameter(Position = 6, Mandatory = false)]
        public System.Double AxisTickToLabelDistance;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double AxisTitleDistance;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double AxisDistance;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 11, Mandatory = false)]
        public System.Double AxislineThickness;

        [Parameter(Position = 12, Mandatory = false)]
        public System.Boolean ClipTitle;

        [Parameter(Position = 13, Mandatory = false)]
        public System.Boolean CropGridlines;

        [Parameter(Position = 14, Mandatory = false)]
        public System.Double EndPosition;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 16, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Double ExtraGridlineThickness;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Double[] ExtraGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Double FilterMaxValue;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Double FilterMinValue;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Double IntervalLength;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Boolean IsAxisVisible;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Boolean IsPanEnabled;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Boolean IsZoomEnabled;

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
        public System.Double MajorGridlineThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Double MajorStep;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Double MajorTickSize;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Double Maximum;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Double MaximumPadding;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Double MaximumRange;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Double Minimum;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Double MinimumMajorStep;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Double MinimumMinorStep;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Double MinimumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Double MinimumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 43, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Double MinorGridlineThickness;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Double MinorStep;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Double MinorTickSize;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Boolean PositionAtZeroCrossing;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 51, Mandatory = false)]
        public System.Double StartPosition;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 56, Mandatory = false)]
        public System.Double TitleClippingLength;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 59, Mandatory = false)]
        public System.Double TitleFontSize;

        [Parameter(Position = 60, Mandatory = false)]
        public System.Double TitleFontWeight;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 62, Mandatory = false)]
        public System.Double TitlePosition;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 64, Mandatory = false)]
        public System.Boolean UseSuperExponentialFormat;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 66, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Boolean Selectable;

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
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = ExtraGridlines;
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
    [Alias("oxy.logarithmicAxis", "oxylogarithmicAxis")]
    [OutputType(typeof(OxyPlot.Axes.LogarithmicAxis))]
    public class NewOxyLogarithmicAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public System.Double Base;

        [Parameter(Position = 1, Mandatory = false)]
        public System.Boolean PowerPadding;

        [Parameter(Position = 2, Mandatory = false)]
        public System.Double AbsoluteMaximum;

        [Parameter(Position = 3, Mandatory = false)]
        public System.Double AbsoluteMinimum;

        [Parameter(Position = 4, Mandatory = false)]
        public System.Double Angle;

        [Parameter(Position = 5, Mandatory = false)]
        public System.Double AxisTickToLabelDistance;

        [Parameter(Position = 6, Mandatory = false)]
        public System.Double AxisTitleDistance;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double AxisDistance;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 9, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 10, Mandatory = false)]
        public System.Double AxislineThickness;

        [Parameter(Position = 11, Mandatory = false)]
        public System.Boolean ClipTitle;

        [Parameter(Position = 12, Mandatory = false)]
        public System.Boolean CropGridlines;

        [Parameter(Position = 13, Mandatory = false)]
        public System.Double EndPosition;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Double ExtraGridlineThickness;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Double[] ExtraGridlines;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Double FilterMaxValue;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Double FilterMinValue;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Double IntervalLength;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Boolean IsAxisVisible;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Boolean IsPanEnabled;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Boolean IsZoomEnabled;

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
        public System.Double MajorGridlineThickness;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Double MajorStep;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Double MajorTickSize;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Double Maximum;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Double MaximumPadding;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Double MaximumRange;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Double Minimum;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Double MinimumMajorStep;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Double MinimumMinorStep;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Double MinimumPadding;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Double MinimumRange;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 42, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Double MinorGridlineThickness;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Double MinorStep;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Double MinorTickSize;

        [Parameter(Position = 47, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 48, Mandatory = false)]
        public System.Boolean PositionAtZeroCrossing;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Double StartPosition;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 52, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 55, Mandatory = false)]
        public System.Double TitleClippingLength;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 58, Mandatory = false)]
        public System.Double TitleFontSize;

        [Parameter(Position = 59, Mandatory = false)]
        public System.Double TitleFontWeight;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 61, Mandatory = false)]
        public System.Double TitlePosition;

        [Parameter(Position = 62, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 63, Mandatory = false)]
        public System.Boolean UseSuperExponentialFormat;

        [Parameter(Position = 64, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 65, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 66, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 69, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Boolean Selectable;

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
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = ExtraGridlines;
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
    [Alias("oxy.datetimeAxis", "oxydatetimeAxis")]
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
        public System.Boolean FormatAsFractions;

        [Parameter(Position = 6, Mandatory = false)]
        public System.Double FractionUnit;

        [Parameter(Position = 7, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double AbsoluteMaximum;

        [Parameter(Position = 9, Mandatory = false)]
        public System.Double AbsoluteMinimum;

        [Parameter(Position = 10, Mandatory = false)]
        public System.Double Angle;

        [Parameter(Position = 11, Mandatory = false)]
        public System.Double AxisTickToLabelDistance;

        [Parameter(Position = 12, Mandatory = false)]
        public System.Double AxisTitleDistance;

        [Parameter(Position = 13, Mandatory = false)]
        public System.Double AxisDistance;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Double AxislineThickness;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Boolean ClipTitle;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Boolean CropGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Double EndPosition;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Double ExtraGridlineThickness;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Double[] ExtraGridlines;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Double FilterMaxValue;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Double FilterMinValue;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Double IntervalLength;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Boolean IsAxisVisible;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Boolean IsPanEnabled;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Boolean IsZoomEnabled;

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
        public System.Double MajorGridlineThickness;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Double MajorStep;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Double MajorTickSize;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Double Maximum;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Double MaximumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Double MaximumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Double Minimum;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Double MinimumMajorStep;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Double MinimumMinorStep;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Double MinimumPadding;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Double MinimumRange;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Double MinorGridlineThickness;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Double MinorStep;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 52, Mandatory = false)]
        public System.Double MinorTickSize;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Boolean PositionAtZeroCrossing;

        [Parameter(Position = 55, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 56, Mandatory = false)]
        public System.Double StartPosition;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 58, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 61, Mandatory = false)]
        public System.Double TitleClippingLength;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 64, Mandatory = false)]
        public System.Double TitleFontSize;

        [Parameter(Position = 65, Mandatory = false)]
        public System.Double TitleFontWeight;

        [Parameter(Position = 66, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Double TitlePosition;

        [Parameter(Position = 68, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Boolean UseSuperExponentialFormat;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 75, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 76, Mandatory = false)]
        public System.Boolean Selectable;

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
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = ExtraGridlines;
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
    [Alias("oxy.timespanAxis", "oxytimespanAxis")]
    [OutputType(typeof(OxyPlot.Axes.TimeSpanAxis))]
    public class NewOxyTimeSpanAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public System.Boolean FormatAsFractions;

        [Parameter(Position = 1, Mandatory = false)]
        public System.Double FractionUnit;

        [Parameter(Position = 2, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 3, Mandatory = false)]
        public System.Double AbsoluteMaximum;

        [Parameter(Position = 4, Mandatory = false)]
        public System.Double AbsoluteMinimum;

        [Parameter(Position = 5, Mandatory = false)]
        public System.Double Angle;

        [Parameter(Position = 6, Mandatory = false)]
        public System.Double AxisTickToLabelDistance;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double AxisTitleDistance;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double AxisDistance;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 11, Mandatory = false)]
        public System.Double AxislineThickness;

        [Parameter(Position = 12, Mandatory = false)]
        public System.Boolean ClipTitle;

        [Parameter(Position = 13, Mandatory = false)]
        public System.Boolean CropGridlines;

        [Parameter(Position = 14, Mandatory = false)]
        public System.Double EndPosition;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 16, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Double ExtraGridlineThickness;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Double[] ExtraGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Double FilterMaxValue;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Double FilterMinValue;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Double IntervalLength;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Boolean IsAxisVisible;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Boolean IsPanEnabled;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Boolean IsZoomEnabled;

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
        public System.Double MajorGridlineThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Double MajorStep;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Double MajorTickSize;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Double Maximum;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Double MaximumPadding;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Double MaximumRange;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Double Minimum;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Double MinimumMajorStep;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Double MinimumMinorStep;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Double MinimumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Double MinimumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 43, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Double MinorGridlineThickness;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Double MinorStep;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Double MinorTickSize;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Boolean PositionAtZeroCrossing;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 51, Mandatory = false)]
        public System.Double StartPosition;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 56, Mandatory = false)]
        public System.Double TitleClippingLength;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 59, Mandatory = false)]
        public System.Double TitleFontSize;

        [Parameter(Position = 60, Mandatory = false)]
        public System.Double TitleFontWeight;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 62, Mandatory = false)]
        public System.Double TitlePosition;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 64, Mandatory = false)]
        public System.Boolean UseSuperExponentialFormat;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 66, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Boolean Selectable;

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
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = ExtraGridlines;
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
    [Alias("oxy.categoryAxis", "oxycategoryAxis")]
    [OutputType(typeof(OxyPlot.Axes.CategoryAxis))]
    public class NewOxyCategoryAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public System.Double GapWidth;

        [Parameter(Position = 1, Mandatory = false)]
        public System.Boolean IsTickCentered;

        [Parameter(Position = 2, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 3, Mandatory = false)]
        public System.String LabelField;

        [Parameter(Position = 4, Mandatory = false)]
        public System.Boolean FormatAsFractions;

        [Parameter(Position = 5, Mandatory = false)]
        public System.Double FractionUnit;

        [Parameter(Position = 6, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double AbsoluteMaximum;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double AbsoluteMinimum;

        [Parameter(Position = 9, Mandatory = false)]
        public System.Double Angle;

        [Parameter(Position = 10, Mandatory = false)]
        public System.Double AxisTickToLabelDistance;

        [Parameter(Position = 11, Mandatory = false)]
        public System.Double AxisTitleDistance;

        [Parameter(Position = 12, Mandatory = false)]
        public System.Double AxisDistance;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 14, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 15, Mandatory = false)]
        public System.Double AxislineThickness;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Boolean ClipTitle;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Boolean CropGridlines;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Double EndPosition;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Double ExtraGridlineThickness;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Double[] ExtraGridlines;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Double FilterMaxValue;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Double FilterMinValue;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Double IntervalLength;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Boolean IsAxisVisible;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Boolean IsPanEnabled;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Boolean IsZoomEnabled;

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
        public System.Double MajorGridlineThickness;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Double MajorStep;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Double MajorTickSize;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Double Maximum;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Double MaximumPadding;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Double MaximumRange;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Double Minimum;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Double MinimumMajorStep;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Double MinimumMinorStep;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Double MinimumPadding;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Double MinimumRange;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 47, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 48, Mandatory = false)]
        public System.Double MinorGridlineThickness;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Double MinorStep;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 51, Mandatory = false)]
        public System.Double MinorTickSize;

        [Parameter(Position = 52, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Boolean PositionAtZeroCrossing;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 55, Mandatory = false)]
        public System.Double StartPosition;

        [Parameter(Position = 56, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 57, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 59, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 60, Mandatory = false)]
        public System.Double TitleClippingLength;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 62, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 63, Mandatory = false)]
        public System.Double TitleFontSize;

        [Parameter(Position = 64, Mandatory = false)]
        public System.Double TitleFontWeight;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 66, Mandatory = false)]
        public System.Double TitlePosition;

        [Parameter(Position = 67, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Boolean UseSuperExponentialFormat;

        [Parameter(Position = 69, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 74, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 75, Mandatory = false)]
        public System.Boolean Selectable;

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
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = ExtraGridlines;
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
    [Alias("oxy.linearcolorAxis", "oxylinearcolorAxis")]
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
        public System.Boolean RenderAsImage;

        [Parameter(Position = 5, Mandatory = false)]
        public System.Boolean FormatAsFractions;

        [Parameter(Position = 6, Mandatory = false)]
        public System.Double FractionUnit;

        [Parameter(Position = 7, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double AbsoluteMaximum;

        [Parameter(Position = 9, Mandatory = false)]
        public System.Double AbsoluteMinimum;

        [Parameter(Position = 10, Mandatory = false)]
        public System.Double Angle;

        [Parameter(Position = 11, Mandatory = false)]
        public System.Double AxisTickToLabelDistance;

        [Parameter(Position = 12, Mandatory = false)]
        public System.Double AxisTitleDistance;

        [Parameter(Position = 13, Mandatory = false)]
        public System.Double AxisDistance;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Double AxislineThickness;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Boolean ClipTitle;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Boolean CropGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Double EndPosition;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Double ExtraGridlineThickness;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Double[] ExtraGridlines;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Double FilterMaxValue;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Double FilterMinValue;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Double IntervalLength;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Boolean IsAxisVisible;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Boolean IsPanEnabled;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Boolean IsZoomEnabled;

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
        public System.Double MajorGridlineThickness;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Double MajorStep;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Double MajorTickSize;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Double Maximum;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Double MaximumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Double MaximumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Double Minimum;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Double MinimumMajorStep;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Double MinimumMinorStep;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Double MinimumPadding;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Double MinimumRange;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Double MinorGridlineThickness;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Double MinorStep;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 52, Mandatory = false)]
        public System.Double MinorTickSize;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Boolean PositionAtZeroCrossing;

        [Parameter(Position = 55, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 56, Mandatory = false)]
        public System.Double StartPosition;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 58, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 61, Mandatory = false)]
        public System.Double TitleClippingLength;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 64, Mandatory = false)]
        public System.Double TitleFontSize;

        [Parameter(Position = 65, Mandatory = false)]
        public System.Double TitleFontWeight;

        [Parameter(Position = 66, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Double TitlePosition;

        [Parameter(Position = 68, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Boolean UseSuperExponentialFormat;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 75, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 76, Mandatory = false)]
        public System.Boolean Selectable;

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
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = ExtraGridlines;
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
    [Alias("oxy.rangecolorAxis", "oxyrangecolorAxis")]
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
        public System.Boolean FormatAsFractions;

        [Parameter(Position = 4, Mandatory = false)]
        public System.Double FractionUnit;

        [Parameter(Position = 5, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 6, Mandatory = false)]
        public System.Double AbsoluteMaximum;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double AbsoluteMinimum;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double Angle;

        [Parameter(Position = 9, Mandatory = false)]
        public System.Double AxisTickToLabelDistance;

        [Parameter(Position = 10, Mandatory = false)]
        public System.Double AxisTitleDistance;

        [Parameter(Position = 11, Mandatory = false)]
        public System.Double AxisDistance;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 13, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 14, Mandatory = false)]
        public System.Double AxislineThickness;

        [Parameter(Position = 15, Mandatory = false)]
        public System.Boolean ClipTitle;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Boolean CropGridlines;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Double EndPosition;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 19, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Double ExtraGridlineThickness;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Double[] ExtraGridlines;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Double FilterMaxValue;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Double FilterMinValue;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Double IntervalLength;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Boolean IsAxisVisible;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Boolean IsPanEnabled;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Boolean IsZoomEnabled;

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
        public System.Double MajorGridlineThickness;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Double MajorStep;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Double MajorTickSize;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Double Maximum;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Double MaximumPadding;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Double MaximumRange;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Double Minimum;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Double MinimumMajorStep;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Double MinimumMinorStep;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Double MinimumPadding;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Double MinimumRange;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 46, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Double MinorGridlineThickness;

        [Parameter(Position = 48, Mandatory = false)]
        public System.Double MinorStep;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Double MinorTickSize;

        [Parameter(Position = 51, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 52, Mandatory = false)]
        public System.Boolean PositionAtZeroCrossing;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Double StartPosition;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 56, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 59, Mandatory = false)]
        public System.Double TitleClippingLength;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 62, Mandatory = false)]
        public System.Double TitleFontSize;

        [Parameter(Position = 63, Mandatory = false)]
        public System.Double TitleFontWeight;

        [Parameter(Position = 64, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 65, Mandatory = false)]
        public System.Double TitlePosition;

        [Parameter(Position = 66, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Boolean UseSuperExponentialFormat;

        [Parameter(Position = 68, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 73, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 74, Mandatory = false)]
        public System.Boolean Selectable;

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
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = ExtraGridlines;
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
    [Alias("oxy.magnitudeAxis", "oxymagnitudeAxis")]
    [OutputType(typeof(OxyPlot.Axes.MagnitudeAxis))]
    public class NewOxyMagnitudeAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public System.Boolean FormatAsFractions;

        [Parameter(Position = 1, Mandatory = false)]
        public System.Double FractionUnit;

        [Parameter(Position = 2, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 3, Mandatory = false)]
        public System.Double AbsoluteMaximum;

        [Parameter(Position = 4, Mandatory = false)]
        public System.Double AbsoluteMinimum;

        [Parameter(Position = 5, Mandatory = false)]
        public System.Double Angle;

        [Parameter(Position = 6, Mandatory = false)]
        public System.Double AxisTickToLabelDistance;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double AxisTitleDistance;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double AxisDistance;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 10, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 11, Mandatory = false)]
        public System.Double AxislineThickness;

        [Parameter(Position = 12, Mandatory = false)]
        public System.Boolean ClipTitle;

        [Parameter(Position = 13, Mandatory = false)]
        public System.Boolean CropGridlines;

        [Parameter(Position = 14, Mandatory = false)]
        public System.Double EndPosition;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 16, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Double ExtraGridlineThickness;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Double[] ExtraGridlines;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Double FilterMaxValue;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Double FilterMinValue;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Double IntervalLength;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Boolean IsAxisVisible;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Boolean IsPanEnabled;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Boolean IsZoomEnabled;

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
        public System.Double MajorGridlineThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Double MajorStep;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Double MajorTickSize;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Double Maximum;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Double MaximumPadding;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Double MaximumRange;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Double Minimum;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Double MinimumMajorStep;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Double MinimumMinorStep;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Double MinimumPadding;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Double MinimumRange;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 43, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Double MinorGridlineThickness;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Double MinorStep;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Double MinorTickSize;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Boolean PositionAtZeroCrossing;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 51, Mandatory = false)]
        public System.Double StartPosition;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 56, Mandatory = false)]
        public System.Double TitleClippingLength;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 59, Mandatory = false)]
        public System.Double TitleFontSize;

        [Parameter(Position = 60, Mandatory = false)]
        public System.Double TitleFontWeight;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 62, Mandatory = false)]
        public System.Double TitlePosition;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 64, Mandatory = false)]
        public System.Boolean UseSuperExponentialFormat;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 66, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Boolean Selectable;

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
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = ExtraGridlines;
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

    [Cmdlet("New", "OxyAngleAxis")]
    [Alias("oxy.angleAxis", "oxyangleAxis")]
    [OutputType(typeof(OxyPlot.Axes.AngleAxis))]
    public class NewOxyAngleAxis : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public System.Double StartAngle;

        [Parameter(Position = 1, Mandatory = false)]
        public System.Double EndAngle;

        [Parameter(Position = 2, Mandatory = false)]
        public System.Boolean FormatAsFractions;

        [Parameter(Position = 3, Mandatory = false)]
        public System.Double FractionUnit;

        [Parameter(Position = 4, Mandatory = false)]
        public System.String FractionUnitSymbol;

        [Parameter(Position = 5, Mandatory = false)]
        public System.Double AbsoluteMaximum;

        [Parameter(Position = 6, Mandatory = false)]
        public System.Double AbsoluteMinimum;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double Angle;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double AxisTickToLabelDistance;

        [Parameter(Position = 9, Mandatory = false)]
        public System.Double AxisTitleDistance;

        [Parameter(Position = 10, Mandatory = false)]
        public System.Double AxisDistance;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxislineColor;

        [Parameter(Position = 12, Mandatory = false)]
        public OxyPlot.LineStyle AxislineStyle;

        [Parameter(Position = 13, Mandatory = false)]
        public System.Double AxislineThickness;

        [Parameter(Position = 14, Mandatory = false)]
        public System.Boolean ClipTitle;

        [Parameter(Position = 15, Mandatory = false)]
        public System.Boolean CropGridlines;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Double EndPosition;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor ExtraGridlineColor;

        [Parameter(Position = 18, Mandatory = false)]
        public OxyPlot.LineStyle ExtraGridlineStyle;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Double ExtraGridlineThickness;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Double[] ExtraGridlines;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> FilterFunction;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Double FilterMaxValue;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Double FilterMinValue;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Double IntervalLength;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Boolean IsAxisVisible;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Boolean IsPanEnabled;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Boolean IsZoomEnabled;

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
        public System.Double MajorGridlineThickness;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Double MajorStep;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Double MajorTickSize;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Double Maximum;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Double MaximumPadding;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Double MaximumRange;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Double Minimum;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Double MinimumMajorStep;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Double MinimumMinorStep;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Double MinimumPadding;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Double MinimumRange;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorGridlineColor;

        [Parameter(Position = 45, Mandatory = false)]
        public OxyPlot.LineStyle MinorGridlineStyle;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Double MinorGridlineThickness;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Double MinorStep;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor MinorTicklineColor;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Double MinorTickSize;

        [Parameter(Position = 50, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition Position;

        [Parameter(Position = 51, Mandatory = false)]
        public System.Boolean PositionAtZeroCrossing;

        [Parameter(Position = 52, Mandatory = false)]
        public System.Int32 PositionTier;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Double StartPosition;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String StringFormat;

        [Parameter(Position = 55, Mandatory = false)]
        public OxyPlot.Axes.TickStyle TickStyle;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TicklineColor;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 58, Mandatory = false)]
        public System.Double TitleClippingLength;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 61, Mandatory = false)]
        public System.Double TitleFontSize;

        [Parameter(Position = 62, Mandatory = false)]
        public System.Double TitleFontWeight;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String TitleFormatString;

        [Parameter(Position = 64, Mandatory = false)]
        public System.Double TitlePosition;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String Unit;

        [Parameter(Position = 66, Mandatory = false)]
        public System.Boolean UseSuperExponentialFormat;

        [Parameter(Position = 67, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Double FontSize;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Double FontWeight;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 72, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Boolean Selectable;

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
            if (bp.ContainsKey("ExtraGridlines")) axis.ExtraGridlines = ExtraGridlines;
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

}
