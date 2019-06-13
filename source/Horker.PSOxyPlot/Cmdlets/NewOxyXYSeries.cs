
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

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 69, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 77, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 79, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 80, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 83, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 85, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 86, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 90, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 91, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 92, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 93, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 94, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 95, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 97, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 110, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 115, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 116, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 117, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 119, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 120, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 125, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 128, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 130, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 131, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 132, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 135, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 137, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 138, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 139, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 141, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 142, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 143, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 145, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 146, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 147, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 148, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 149, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 150, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 154, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 156, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 159, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 161, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 169, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 171, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 172, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 175, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 177, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 178, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 182, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 183, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 184, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 185, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 186, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 187, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 189, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 202, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 207, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 208, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 209, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 211, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 212, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 214, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 217, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 220, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 222, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 223, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 224, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 227, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 229, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 230, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 231, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 233, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 234, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 235, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 237, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 238, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 239, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 240, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 241, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 242, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 243, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 244, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 245, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 246, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 247, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 248, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 55, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 57, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 58, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 61, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 63, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 64, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 71, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 73, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 75, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 88, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 93, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 94, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 95, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 97, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 98, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 100, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 103, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 106, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 108, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 109, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 110, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 113, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 115, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 116, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 117, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 119, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 120, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 121, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 123, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 124, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 125, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 126, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 127, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 128, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 132, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 134, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 137, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 139, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 147, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 149, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 150, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 153, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 155, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 156, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 160, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 161, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 162, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 163, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 164, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 165, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 167, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 180, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 185, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 186, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 187, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 189, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 190, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 192, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 195, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 198, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 200, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 201, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 202, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 205, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 207, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 208, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 209, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 211, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 212, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 213, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 215, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 216, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 217, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 218, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 219, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 220, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 224, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 226, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 60, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 62, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 70, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 76, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 78, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 79, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 83, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 84, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 85, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 86, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 87, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 88, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 90, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 103, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 108, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 109, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 110, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 112, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 113, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 115, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 118, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 121, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 123, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 124, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 125, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 128, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 130, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 131, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 132, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 134, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 135, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 136, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 138, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 139, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 140, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 141, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 142, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 143, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 147, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 149, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 152, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 154, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 162, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 164, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 165, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 168, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 170, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 171, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 175, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 176, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 177, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 178, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 179, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 180, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 182, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 195, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 200, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 201, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 202, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 204, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 205, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 207, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 210, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 213, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 216, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 217, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 220, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 222, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 223, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 224, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 226, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 227, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 228, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 230, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 231, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 232, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 233, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 234, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 235, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 239, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 240, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 241, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 63, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 65, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 66, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 69, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 76, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 77, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 78, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 79, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 80, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 81, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 83, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 96, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 101, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 102, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 103, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 105, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 106, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 108, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 111, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 114, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 116, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 117, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 118, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 121, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 123, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 124, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 125, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 127, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 128, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 129, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 131, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 132, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 133, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 134, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 135, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 136, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 140, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 142, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 145, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 147, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 155, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 157, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 158, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 161, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 163, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 164, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 168, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 169, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 170, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 171, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 172, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 173, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 175, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 188, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 193, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 194, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 195, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 197, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 198, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 200, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 203, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 208, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 209, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 210, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 213, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 216, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 217, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 219, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 220, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 221, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 223, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 224, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 225, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 226, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 227, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 228, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 232, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 234, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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
    [Alias("oxy.candleStickAndVolume", "oxy.candlev", "oxycandlev")]
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

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 56, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 66, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 72, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 74, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 75, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 79, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 80, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 81, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 82, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 83, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 84, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 86, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 99, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 104, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 105, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 106, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 108, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 109, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 111, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 114, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 117, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 119, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 120, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 121, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 124, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 126, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 127, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 128, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 130, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 131, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 132, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 134, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 135, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 136, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 137, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 138, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 139, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 143, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 145, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 148, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 150, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 158, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 160, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 161, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 164, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 166, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 167, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 171, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 172, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 173, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 174, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 175, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 176, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 178, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 191, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 196, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 197, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 198, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 200, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 201, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 203, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 211, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 212, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 213, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 216, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 218, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 219, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 220, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 222, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 223, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 224, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 226, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 227, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 228, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 229, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 230, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 231, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 235, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 237, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 55, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 57, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 58, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 61, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 63, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 64, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 71, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 73, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 75, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 88, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 93, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 94, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 95, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 97, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 98, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 100, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 103, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 106, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 108, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 109, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 110, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 113, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 115, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 116, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 117, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 119, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 120, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 121, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 123, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 124, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 125, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 126, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 127, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 128, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 132, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 134, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 137, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 139, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 147, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 149, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 150, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 153, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 155, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 156, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 160, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 161, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 162, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 163, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 164, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 165, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 167, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 180, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 185, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 186, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 187, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 189, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 190, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 192, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 195, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 198, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 200, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 201, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 202, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 205, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 207, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 208, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 209, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 211, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 212, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 213, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 215, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 216, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 217, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 218, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 219, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 220, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 224, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 226, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 49, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 57, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 59, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 60, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 63, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 65, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 66, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 73, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 74, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 75, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 77, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 90, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 95, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 96, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 97, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 99, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 100, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 102, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 105, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 108, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 110, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 111, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 112, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 115, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 117, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 118, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 119, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 121, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 122, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 123, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 125, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 126, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 127, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 128, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 129, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 130, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 134, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 136, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 139, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 141, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 149, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 151, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 152, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 155, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 157, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 158, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 162, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 163, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 164, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 165, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 166, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 167, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 169, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 182, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 187, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 188, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 189, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 191, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 192, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 194, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 197, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 200, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 202, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 203, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 204, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 207, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 210, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 211, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 213, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 214, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 217, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 218, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 219, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 220, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 221, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 222, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 226, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 228, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 59, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 61, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 62, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 65, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 74, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 75, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 76, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 77, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 79, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 92, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 97, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 98, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 99, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 101, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 102, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 104, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 107, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 110, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 112, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 113, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 114, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 117, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 119, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 120, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 121, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 123, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 124, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 125, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 127, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 128, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 129, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 130, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 131, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 132, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 136, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 138, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 141, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 143, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 151, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 153, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 154, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 157, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 159, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 160, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 164, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 165, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 166, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 167, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 168, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 169, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 171, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 184, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 189, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 190, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 191, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 193, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 194, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 196, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 199, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 202, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 204, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 205, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 209, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 211, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 212, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 213, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 215, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 216, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 217, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 219, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 220, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 221, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 222, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 223, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 224, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 228, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 230, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 60, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 62, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 63, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 66, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 74, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 75, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 76, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 77, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 78, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 80, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 93, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 98, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 99, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 100, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 102, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 103, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 105, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 108, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 111, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 113, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 114, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 115, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 118, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 120, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 121, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 122, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 124, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 125, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 126, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 128, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 129, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 130, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 131, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 132, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 133, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 137, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 139, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 142, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 144, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 152, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 154, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 155, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 158, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 160, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 161, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 165, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 166, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 167, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 168, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 169, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 170, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 172, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 185, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 190, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 191, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 192, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 194, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 195, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 197, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 200, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 203, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 205, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 206, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 207, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 210, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 212, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 213, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 214, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 216, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 217, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 218, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 220, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 221, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 222, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 223, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 224, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 225, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 229, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 231, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 56, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 58, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 59, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 62, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 64, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 65, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 72, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 74, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 76, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 89, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 94, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 95, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 96, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 98, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 99, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 101, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 104, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 107, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 109, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 110, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 111, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 114, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 116, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 117, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 118, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 120, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 121, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 124, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 125, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 126, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 127, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 128, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 129, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 133, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 135, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 138, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 140, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 148, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 150, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 151, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 154, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 156, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 157, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 161, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 162, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 163, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 164, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 165, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 166, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 168, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 181, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 186, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 187, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 188, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 190, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 191, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 193, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 196, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 199, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 201, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 202, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 203, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 206, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 208, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 209, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 210, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 212, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 213, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 214, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 216, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 217, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 218, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 219, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 220, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 221, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 225, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 227, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 52, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 55, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 58, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 60, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 61, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 65, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 66, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 68, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 70, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 72, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 85, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 90, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 91, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 92, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 94, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 95, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 97, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 100, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 103, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 105, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 106, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 107, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 110, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 112, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 113, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 114, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 116, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 117, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 118, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 120, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 121, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 122, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 123, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 124, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 125, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 129, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 131, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 134, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 136, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 144, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 146, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 147, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 150, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 152, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 153, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 157, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 158, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 159, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 160, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 161, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 162, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 164, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 177, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 182, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 183, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 184, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 186, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 187, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 189, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 192, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 195, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 197, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 198, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 199, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 202, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 204, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 205, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 206, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 208, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 209, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 210, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 212, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 213, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 214, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 215, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 216, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 217, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 221, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 223, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 57, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 59, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 67, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 73, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 75, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 76, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 80, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 81, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 82, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 83, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 84, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 85, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 87, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 100, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 105, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 106, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 107, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 109, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 110, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 112, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 115, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 118, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 120, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 121, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 125, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 127, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 128, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 129, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 131, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 132, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 133, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 135, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 136, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 137, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 138, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 139, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 140, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 144, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 146, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 149, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 151, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 159, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 161, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 162, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 165, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 167, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 168, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 172, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 173, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 174, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 175, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 176, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 177, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 179, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 192, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 197, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 198, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 199, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 201, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 202, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 204, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 207, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 210, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 212, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 213, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 214, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 217, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 219, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 220, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 221, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 223, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 224, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 225, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 227, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 228, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 229, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 230, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 231, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 232, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 235, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 236, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 238, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 57, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 59, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 67, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 73, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 75, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 76, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 80, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 81, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 82, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 83, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 84, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 85, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 87, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 100, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 105, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 106, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 107, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 109, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 110, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 112, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 115, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 118, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 120, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 121, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 125, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 127, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 128, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 129, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 131, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 132, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 133, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 135, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 136, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 137, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 138, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 139, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 140, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 144, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 146, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 149, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 151, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 159, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 161, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 162, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 165, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 167, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 168, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 172, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 173, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 174, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 175, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 176, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 177, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 179, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 192, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 197, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 198, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 199, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 201, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 202, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 204, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 207, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 210, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 212, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 213, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 214, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 217, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 219, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 220, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 221, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 223, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 224, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 225, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 227, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 228, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 229, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 230, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 231, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 232, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 235, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 236, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 238, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 51, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 57, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 59, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 60, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 64, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 65, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 66, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 67, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 68, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 69, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 71, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 84, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 89, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 90, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 91, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 93, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 94, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 96, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 99, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 102, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 104, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 105, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 106, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 109, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 111, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 112, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 113, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 115, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 116, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 117, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 119, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 120, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 121, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 122, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 123, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 124, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 128, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 130, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 133, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 135, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 143, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 145, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 146, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 149, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 151, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 152, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 156, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 157, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 158, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 159, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 160, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 161, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 163, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 176, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 181, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 182, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 183, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 185, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 186, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 188, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 191, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 194, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 196, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 197, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 198, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 201, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 203, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 204, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 205, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 207, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 208, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 211, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 212, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 213, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 214, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 215, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 216, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 220, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 222, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 52, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 62, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 64, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 65, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 68, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 75, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 76, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 77, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 78, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 79, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 80, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 82, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 95, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 100, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 101, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 102, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 104, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 105, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 107, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 110, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 113, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 115, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 116, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 117, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 120, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 123, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 124, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 126, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 127, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 128, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 130, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 131, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 132, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 133, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 134, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 135, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 139, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 141, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 144, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 146, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 154, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 156, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 157, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 160, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 162, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 163, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 167, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 168, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 169, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 170, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 171, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 172, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 174, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 187, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 192, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 193, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 194, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 196, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 197, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 199, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 202, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 205, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 207, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 208, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 212, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 214, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 215, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 216, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 218, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 219, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 220, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 222, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 223, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 224, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 225, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 226, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 227, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 231, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 233, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 62, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 64, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 72, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 74, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 75, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 78, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 80, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 81, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 85, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 86, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 87, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 88, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 89, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 90, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 92, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 105, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 110, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 111, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 112, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 114, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 115, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 117, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 120, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 123, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 125, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 126, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 127, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 130, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 132, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 133, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 134, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 136, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 137, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 138, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 140, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 141, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 142, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 143, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 144, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 145, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 149, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 151, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 154, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 156, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 164, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 166, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 167, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 170, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 172, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 173, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 177, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 178, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 179, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 180, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 181, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 182, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 184, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 197, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 202, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 203, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 204, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 207, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 212, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 217, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 218, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 219, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 222, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 224, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 225, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 226, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 228, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 229, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 230, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 232, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 233, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 234, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 235, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 236, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 237, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 239, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 240, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 241, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 242, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 243, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 59, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 69, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 75, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 77, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 78, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 82, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 83, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 84, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 85, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 86, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 87, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 89, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 102, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 107, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 108, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 109, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 111, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 112, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 114, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 117, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 120, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 123, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 124, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 127, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 129, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 130, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 131, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 133, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 134, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 135, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 137, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 138, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 139, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 140, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 141, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 142, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 146, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 148, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 151, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 153, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 161, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 163, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 164, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 167, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 169, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 170, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 174, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 175, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 176, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 177, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 178, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 179, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 181, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 194, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 199, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 200, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 201, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 203, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 204, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 212, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 214, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 215, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 216, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 219, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 221, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 222, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 223, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 225, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 226, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 227, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 229, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 230, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 231, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 232, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 233, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 234, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 235, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 238, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 239, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 240, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 58, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 68, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 74, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 76, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 77, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 81, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 82, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 83, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 84, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 85, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 86, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 88, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 101, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 106, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 107, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 108, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 110, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 111, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 113, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 116, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 119, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 121, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 122, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 123, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 126, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 128, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 129, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 130, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 132, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 133, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 134, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 136, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 137, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 138, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 139, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 140, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 141, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 145, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 147, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 150, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 152, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 160, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 162, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 163, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 166, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 168, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 169, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 173, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 174, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 175, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 176, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 177, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 178, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 180, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 193, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 198, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 199, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 200, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 202, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 203, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 205, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 208, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 211, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 213, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 214, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 218, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 220, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 221, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 222, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 224, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 225, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 226, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 228, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 229, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 230, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 231, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 232, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 233, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 235, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 237, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 239, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 65, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 67, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 75, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 77, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 78, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 81, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 83, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 84, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 88, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 89, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 90, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 91, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 92, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 93, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 95, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 108, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 113, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 114, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 115, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 117, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 118, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 120, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 123, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 126, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 128, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 129, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 130, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 133, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 135, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 136, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 137, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 139, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 140, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 141, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 143, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 144, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 145, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 146, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 147, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 148, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 152, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 154, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 157, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 159, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 167, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 169, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 170, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 173, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 175, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 176, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 180, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 181, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 182, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 183, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 184, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 185, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 187, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 200, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 205, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 206, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 207, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 210, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 212, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 218, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 220, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 221, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 222, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 225, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 227, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 228, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 229, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 231, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 232, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 233, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 235, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 236, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 237, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 238, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 239, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 240, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 241, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 242, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 243, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 244, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 245, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 246, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 63, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 65, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 66, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 69, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 76, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 77, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 78, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 79, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 80, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 81, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 83, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 96, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 101, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 102, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 103, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 105, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 106, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 108, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 111, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 114, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 116, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 117, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 118, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 121, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 123, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 124, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 125, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 127, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 128, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 129, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 131, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 132, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 133, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 134, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 135, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 136, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 140, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 142, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 145, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 147, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 155, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 157, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 158, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 161, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 163, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 164, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 168, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 169, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 170, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 171, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 172, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 173, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 175, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 188, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 193, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 194, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 195, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 197, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 198, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 200, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 203, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 208, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 209, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 210, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 213, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 216, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 217, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 219, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 220, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 221, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 223, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 224, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 225, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 226, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 227, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 228, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 232, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 234, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 75, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 83, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 85, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 86, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 89, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 91, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 92, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 96, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 97, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 98, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 99, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 100, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 101, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 103, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 116, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 121, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 122, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 123, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 125, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 126, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 128, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 131, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 134, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 136, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 137, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 138, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 141, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 143, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 144, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 145, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 147, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 148, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 149, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 151, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 152, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 153, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 154, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 155, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 156, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 160, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 162, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 165, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 167, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 175, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 177, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 178, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 181, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 183, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 184, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 188, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 189, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 190, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 191, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 192, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 193, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 195, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 208, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 213, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 214, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 215, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 217, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 218, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 220, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 223, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 226, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 228, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 229, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 230, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 233, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 235, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 236, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 237, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 239, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 240, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 241, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 242, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 243, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 244, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 245, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 246, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 247, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 248, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 249, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 250, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 251, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 252, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 253, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 254, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 61, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 71, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 74, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 77, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 79, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 80, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 84, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 85, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 86, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 87, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 88, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 89, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 91, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 104, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 109, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 110, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 111, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 113, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 114, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 116, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 119, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 124, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 125, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 126, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 129, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 131, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 132, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 133, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 135, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 136, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 137, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 139, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 140, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 141, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 142, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 143, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 144, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 148, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 150, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 153, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 155, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 163, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 165, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 166, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 169, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 171, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 172, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 176, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 177, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 178, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 179, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 180, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 181, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 183, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 196, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 201, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 202, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 203, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 205, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 206, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 208, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 211, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 214, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 216, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 217, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 218, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 221, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 223, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 224, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 225, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 227, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 228, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 229, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 231, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 232, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 233, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 234, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 235, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 236, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 239, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 240, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 241, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 242, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Boolean AxFormatAsFractions;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 56, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 64, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 66, Mandatory = false)]
        public System.Boolean AxClipTitle;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Boolean AxCropGridlines;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 70, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Double[] AxExtraGridlines;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 77, Mandatory = false)]
        public System.Boolean AxIsAxisVisible;

        [Parameter(Position = 78, Mandatory = false)]
        public System.Boolean AxIsPanEnabled;

        [Parameter(Position = 79, Mandatory = false)]
        public System.Boolean AxIsZoomEnabled;

        [Parameter(Position = 80, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 81, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 82, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 84, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 97, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 102, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 103, Mandatory = false)]
        public System.Boolean AxPositionAtZeroCrossing;

        [Parameter(Position = 104, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 106, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 107, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 109, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 112, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 115, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 117, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 118, Mandatory = false)]
        public System.Boolean AxUseSuperExponentialFormat;

        [Parameter(Position = 119, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 122, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 124, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 125, Mandatory = false)]
        public System.Boolean AxSelectable;

        [Parameter(Position = 126, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 128, Mandatory = false)]
        public System.Boolean AxIsTickCentered;

        [Parameter(Position = 129, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 130, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 132, Mandatory = false)]
        public OxyPlot.OxyPalette AxPalette;

        [Parameter(Position = 133, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 134, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 135, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 136, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 137, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 141, Mandatory = false)]
        public System.Boolean AxRenderAsImage;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 143, Mandatory = false)]
        public System.Boolean AxPowerPadding;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 146, Mandatory = false)]
        public System.Boolean AyFormatAsFractions;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 148, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 156, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 158, Mandatory = false)]
        public System.Boolean AyClipTitle;

        [Parameter(Position = 159, Mandatory = false)]
        public System.Boolean AyCropGridlines;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 162, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 164, Mandatory = false)]
        public System.Double[] AyExtraGridlines;

        [Parameter(Position = 165, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 169, Mandatory = false)]
        public System.Boolean AyIsAxisVisible;

        [Parameter(Position = 170, Mandatory = false)]
        public System.Boolean AyIsPanEnabled;

        [Parameter(Position = 171, Mandatory = false)]
        public System.Boolean AyIsZoomEnabled;

        [Parameter(Position = 172, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 173, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 174, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 176, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 189, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 194, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 195, Mandatory = false)]
        public System.Boolean AyPositionAtZeroCrossing;

        [Parameter(Position = 196, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 198, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 199, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 201, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 204, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 207, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 210, Mandatory = false)]
        public System.Boolean AyUseSuperExponentialFormat;

        [Parameter(Position = 211, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 214, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 216, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 217, Mandatory = false)]
        public System.Boolean AySelectable;

        [Parameter(Position = 218, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 220, Mandatory = false)]
        public System.Boolean AyIsTickCentered;

        [Parameter(Position = 221, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 222, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 224, Mandatory = false)]
        public OxyPlot.OxyPalette AyPalette;

        [Parameter(Position = 225, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 226, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 227, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 228, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 229, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 233, Mandatory = false)]
        public System.Boolean AyRenderAsImage;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 235, Mandatory = false)]
        public System.Boolean AyPowerPadding;

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
                model = ObjectFactory.CreatePlotModel(si, bp);

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
