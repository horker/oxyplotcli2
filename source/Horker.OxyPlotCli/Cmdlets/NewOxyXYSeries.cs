
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using OxyPlot;
using OxyPlot.Series;
using Horker.OxyPlotCli.SeriesBuilders;
using Horker.OxyPlotCli.Initializers;
using Horker.OxyPlotCli.Styles;

namespace Horker.OxyPlotCli.Cmdlets
{
    [Cmdlet("New", "OxyAreaSeries")]
    [Alias("oxy.area", "oxyarea")]
    [OutputType(typeof(SeriesInfo<AreaSeries>))]
    public class NewOxyAreaSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string X1Name = "X1";

        [Parameter(Position = 2, Mandatory = false)]
        public string Y1Name = "Y1";

        [Parameter(Position = 3, Mandatory = false)]
        public string X2Name = "X2";

        [Parameter(Position = 4, Mandatory = false)]
        public string Y2Name = "Y2";

        [Parameter(Position = 5, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X1;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y1;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X2;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y2;

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
        public string Style = null;

        [Parameter(Position = 18, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 19, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 20, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ConstantY2;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String DataFieldX2;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String DataFieldY2;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color2;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Reverse2;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 29, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Dashes;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 35, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 36, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 37, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] MarkerOutline;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 44, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.InterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CanTrackerInterpolatePoints;

        [Parameter(Position = 49, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 50, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 51, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 53, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 59, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 64, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 66, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 68, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 69, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 74, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 82, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 88, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 91, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 98, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 99, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 100, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 102, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 115, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 120, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 122, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 124, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 125, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 127, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 130, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 133, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 135, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 137, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 140, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 142, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 144, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 147, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 148, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

        [Parameter(Position = 151, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 152, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 153, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 154, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 155, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 162, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 167, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 175, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 181, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 184, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 191, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 192, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 193, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 195, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 208, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 213, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 215, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 217, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 218, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 220, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 223, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 226, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 228, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 230, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 233, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 235, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 237, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 239, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 240, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 241, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 242, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 243, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 250, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 251, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 252, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 253, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 254, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.AreaSeriesBuilder _builder;

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
            if (bp.ContainsKey("Dashes")) series.Dashes = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(Dashes);
            if (bp.ContainsKey("Decimator")) series.Decimator = Decimator;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("LineJoin")) series.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) series.LineStyle = LineStyle;
            if (bp.ContainsKey("LineLegendPosition")) series.LineLegendPosition = LineLegendPosition;
            if (bp.ContainsKey("MarkerFill")) series.MarkerFill = MarkerFill;
            if (bp.ContainsKey("MarkerOutline")) series.MarkerOutline = Horker.OxyPlotCli.TypeAdaptors.ScreenPoint.ConvertArray(MarkerOutline);
            if (bp.ContainsKey("MarkerResolution")) series.MarkerResolution = MarkerResolution;
            if (bp.ContainsKey("MarkerSize")) series.MarkerSize = MarkerSize;
            if (bp.ContainsKey("MarkerStroke")) series.MarkerStroke = MarkerStroke;
            if (bp.ContainsKey("MarkerStrokeThickness")) series.MarkerStrokeThickness = MarkerStrokeThickness;
            if (bp.ContainsKey("MarkerType")) series.MarkerType = MarkerType;
            if (bp.ContainsKey("MinimumSegmentLength")) series.MinimumSegmentLength = MinimumSegmentLength;
            if (bp.ContainsKey("InterpolationAlgorithm")) series.InterpolationAlgorithm = InterpolationAlgorithm.Value;
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.AreaSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyBarSeries")]
    [Alias("oxy.bar", "oxybar")]
    [OutputType(typeof(SeriesInfo<BarSeries>))]
    public class NewOxyBarSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string ValueName = "Value";

        [Parameter(Position = 2, Mandatory = false)]
        public string CategoryName = "Category";

        [Parameter(Position = 3, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Value;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Category[] Category;

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
        public string Style = null;

        [Parameter(Position = 14, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 15, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 16, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BarWidth;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BaseValue;

        [Parameter(Position = 19, Mandatory = false)]
        public System.String ColorField;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsStacked;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.Series.LabelPlacement LabelPlacement;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor NegativeFillColor;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String StackGroup;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String ValueField;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 46, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 47, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 60, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 66, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 76, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 77, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 78, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 80, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 93, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 98, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 100, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 102, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 103, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 105, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 108, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 111, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 113, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 115, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 118, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 120, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 122, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 125, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 126, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 140, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 145, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 153, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 159, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 162, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 169, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 170, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 171, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 173, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 186, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 191, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 193, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 195, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 196, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 198, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 201, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 204, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 208, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 211, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 213, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 215, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 218, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 219, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

        [Parameter(Position = 222, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 223, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 224, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 225, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 226, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.BarSeriesBuilder _builder;

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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.BarSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyBoxPlotSeries")]
    [Alias("oxy.boxPlot", "oxy.box", "oxybox")]
    [OutputType(typeof(SeriesInfo<BoxPlotSeries>))]
    public class NewOxyBoxPlotSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string CategoryName = "Category";

        [Parameter(Position = 2, Mandatory = false)]
        public string LowerWhiskerName = "LowerWhisker";

        [Parameter(Position = 3, Mandatory = false)]
        public string BoxBottomName = "BoxBottom";

        [Parameter(Position = 4, Mandatory = false)]
        public string MedianName = "Median";

        [Parameter(Position = 5, Mandatory = false)]
        public string BoxTopName = "BoxTop";

        [Parameter(Position = 6, Mandatory = false)]
        public string UpperWhiskerName = "UpperWhisker";

        [Parameter(Position = 7, Mandatory = false)]
        public string OutliersName = "Outliers";

        [Parameter(Position = 8, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Category[] Category;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] LowerWhisker;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] BoxBottom;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Median;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] BoxTop;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] UpperWhisker;

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
        public string Style = null;

        [Parameter(Position = 24, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 25, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 26, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BoxWidth;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Collections.Generic.IList<OxyPlot.Series.BoxPlotItem> Items;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MedianPointSize;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MedianThickness;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MeanPointSize;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MeanThickness;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double OutlierSize;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String OutlierTrackerFormatString;

        [Parameter(Position = 37, Mandatory = false)]
        public OxyPlot.MarkerType OutlierType;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] OutlierOutline;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ShowBox;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ShowMedianAsDot;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool ShowMeanAsDot;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double WhiskerWidth;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 50, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 53, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 57, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 59, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 61, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 62, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 67, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 75, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 81, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 84, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 91, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 92, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 93, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 95, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 108, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 113, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 115, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 117, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 118, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 120, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 123, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 126, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 128, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 130, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 133, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 135, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 137, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 140, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 141, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 155, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 160, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 168, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 174, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 177, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 184, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 185, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 186, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 188, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 201, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 206, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 208, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 210, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 211, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 213, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 216, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 219, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 221, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 223, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 226, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 228, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 230, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 233, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 234, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 235, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

        [Parameter(Position = 237, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 238, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 239, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 240, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 241, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 242, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 243, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 244, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 245, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 246, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 247, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.BoxPlotSeriesBuilder _builder;

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
            if (bp.ContainsKey("OutlierOutline")) series.OutlierOutline = Horker.OxyPlotCli.TypeAdaptors.ScreenPoint.ConvertArray(OutlierOutline);
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.BoxPlotSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyCandleStickSeries")]
    [Alias("oxy.candleStick", "oxy.candle", "oxycandle")]
    [OutputType(typeof(SeriesInfo<CandleStickSeries>))]
    public class NewOxyCandleStickSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName = "X";

        [Parameter(Position = 2, Mandatory = false)]
        public string HighName = "High";

        [Parameter(Position = 3, Mandatory = false)]
        public string LowName = "Low";

        [Parameter(Position = 4, Mandatory = false)]
        public string OpenName = "Open";

        [Parameter(Position = 5, Mandatory = false)]
        public string CloseName = "Close";

        [Parameter(Position = 6, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] High;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Low;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Open;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Close;

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
        public string Style = null;

        [Parameter(Position = 20, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 21, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 22, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor IncreasingColor;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor DecreasingColor;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double CandleWidth;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Dashes;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String DataFieldClose;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String DataFieldHigh;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String DataFieldLow;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String DataFieldOpen;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 34, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.Series.HighLowItem> Mapping;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TickLength;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 54, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 55, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 68, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 74, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 77, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 84, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 85, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 86, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 88, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 101, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 106, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 108, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 110, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 111, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 113, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 116, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 119, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 121, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 123, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 126, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 128, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 130, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 133, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 134, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 148, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 153, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 161, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 167, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 170, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 177, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 178, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 179, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 181, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 194, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 199, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 201, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 203, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 204, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 212, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 214, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 216, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 219, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 221, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 223, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 226, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 227, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 239, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 240, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.CandleStickSeriesBuilder _builder;

        private void AssignParameters(CandleStickSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("IncreasingColor")) series.IncreasingColor = IncreasingColor;
            if (bp.ContainsKey("DecreasingColor")) series.DecreasingColor = DecreasingColor;
            if (bp.ContainsKey("CandleWidth")) series.CandleWidth = CandleWidth;
            if (bp.ContainsKey("Color")) series.Color = Color;
            if (bp.ContainsKey("Dashes")) series.Dashes = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(Dashes);
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.CandleStickSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyCandleStickAndVolumeSeries")]
    [Alias("oxy.candleStickAndVolume", "oxy.candlev", "oxycandlev")]
    [OutputType(typeof(SeriesInfo<CandleStickAndVolumeSeries>))]
    public class NewOxyCandleStickAndVolumeSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName = "X";

        [Parameter(Position = 2, Mandatory = false)]
        public string OpenName = "Open";

        [Parameter(Position = 3, Mandatory = false)]
        public string HighName = "High";

        [Parameter(Position = 4, Mandatory = false)]
        public string LowName = "Low";

        [Parameter(Position = 5, Mandatory = false)]
        public string CloseName = "Close";

        [Parameter(Position = 6, Mandatory = false)]
        public string BuyVolumeName = "BuyVolume";

        [Parameter(Position = 7, Mandatory = false)]
        public string SellVolumeName = "SellVolume";

        [Parameter(Position = 8, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Open;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] High;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Low;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Close;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] BuyVolume;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] SellVolume;

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
        public string Style = null;

        [Parameter(Position = 24, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 25, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 26, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Collections.Generic.List<OxyPlot.Series.OhlcvItem> Items;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String VolumeAxisKey;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String BarAxisKey;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.Series.VolumeStyle VolumeStyle;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeIntensity;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double SeparatorStrokeThickness;

        [Parameter(Position = 34, Mandatory = false)]
        public OxyPlot.LineStyle SeparatorLineStyle;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor PositiveColor;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor NegativeColor;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor SeparatorColor;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool PositiveHollow;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool NegativeHollow;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double CandleWidth;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 49, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 50, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 57, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 58, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 71, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 77, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 80, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 87, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 88, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 89, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 91, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 104, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 109, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 111, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 113, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 114, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 116, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 119, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 124, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 126, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 129, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 131, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 133, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 136, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 137, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 151, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 156, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 164, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 170, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 173, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 180, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 181, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 182, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 184, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 197, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 202, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 204, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 207, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 212, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 217, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 219, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 222, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 224, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 226, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 229, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 230, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 239, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 240, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 241, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 242, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 243, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        [Parameter(Position = 244, Mandatory = false)]
        public string AzType;

        [Parameter(Position = 245, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzStartAngle;

        [Parameter(Position = 246, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzEndAngle;

        [Parameter(Position = 247, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzFormatAsFractions;

        [Parameter(Position = 248, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzFractionUnit;

        [Parameter(Position = 249, Mandatory = false)]
        public System.String AzFractionUnitSymbol;

        [Parameter(Position = 250, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzAbsoluteMaximum;

        [Parameter(Position = 251, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzAbsoluteMinimum;

        [Parameter(Position = 252, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzAngle;

        [Parameter(Position = 253, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzAxisTickToLabelDistance;

        [Parameter(Position = 254, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzAxisTitleDistance;

        [Parameter(Position = 255, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzAxisDistance;

        [Parameter(Position = 256, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzAxislineColor;

        [Parameter(Position = 257, Mandatory = false)]
        public OxyPlot.LineStyle AzAxislineStyle;

        [Parameter(Position = 258, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzAxislineThickness;

        [Parameter(Position = 259, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzClipTitle;

        [Parameter(Position = 260, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzCropGridlines;

        [Parameter(Position = 261, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzEndPosition;

        [Parameter(Position = 262, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzExtraGridlineColor;

        [Parameter(Position = 263, Mandatory = false)]
        public OxyPlot.LineStyle AzExtraGridlineStyle;

        [Parameter(Position = 264, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzExtraGridlineThickness;

        [Parameter(Position = 265, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AzExtraGridlines;

        [Parameter(Position = 266, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AzFilterFunction;

        [Parameter(Position = 267, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzFilterMaxValue;

        [Parameter(Position = 268, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzFilterMinValue;

        [Parameter(Position = 269, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzIntervalLength;

        [Parameter(Position = 270, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzIsAxisVisible;

        [Parameter(Position = 271, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzIsPanEnabled;

        [Parameter(Position = 272, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzIsZoomEnabled;

        [Parameter(Position = 273, Mandatory = false)]
        public System.String AzKey;

        [Parameter(Position = 274, Mandatory = false)]
        public System.Func<System.Double,System.String> AzLabelFormatter;

        [Parameter(Position = 275, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AzLayer;

        [Parameter(Position = 276, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzMajorGridlineColor;

        [Parameter(Position = 277, Mandatory = false)]
        public OxyPlot.LineStyle AzMajorGridlineStyle;

        [Parameter(Position = 278, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMajorGridlineThickness;

        [Parameter(Position = 279, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMajorStep;

        [Parameter(Position = 280, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMajorTickSize;

        [Parameter(Position = 281, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMaximum;

        [Parameter(Position = 282, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMaximumPadding;

        [Parameter(Position = 283, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMaximumRange;

        [Parameter(Position = 284, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinimum;

        [Parameter(Position = 285, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinimumMajorStep;

        [Parameter(Position = 286, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinimumMinorStep;

        [Parameter(Position = 287, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinimumPadding;

        [Parameter(Position = 288, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinimumRange;

        [Parameter(Position = 289, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzMinorGridlineColor;

        [Parameter(Position = 290, Mandatory = false)]
        public OxyPlot.LineStyle AzMinorGridlineStyle;

        [Parameter(Position = 291, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinorGridlineThickness;

        [Parameter(Position = 292, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinorStep;

        [Parameter(Position = 293, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzMinorTicklineColor;

        [Parameter(Position = 294, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinorTickSize;

        [Parameter(Position = 295, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AzPosition;

        [Parameter(Position = 296, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzPositionAtZeroCrossing;

        [Parameter(Position = 297, Mandatory = false)]
        public System.Int32 AzPositionTier;

        [Parameter(Position = 298, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzStartPosition;

        [Parameter(Position = 299, Mandatory = false)]
        public System.String AzStringFormat;

        [Parameter(Position = 300, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AzTickStyle;

        [Parameter(Position = 301, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzTicklineColor;

        [Parameter(Position = 302, Mandatory = false)]
        public System.String AzTitle;

        [Parameter(Position = 303, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzTitleClippingLength;

        [Parameter(Position = 304, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzTitleColor;

        [Parameter(Position = 305, Mandatory = false)]
        public System.String AzTitleFont;

        [Parameter(Position = 306, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzTitleFontSize;

        [Parameter(Position = 307, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzTitleFontWeight;

        [Parameter(Position = 308, Mandatory = false)]
        public System.String AzTitleFormatString;

        [Parameter(Position = 309, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzTitlePosition;

        [Parameter(Position = 310, Mandatory = false)]
        public System.String AzUnit;

        [Parameter(Position = 311, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzUseSuperExponentialFormat;

        [Parameter(Position = 312, Mandatory = false)]
        public System.String AzFont;

        [Parameter(Position = 313, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzFontSize;

        [Parameter(Position = 314, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzFontWeight;

        [Parameter(Position = 315, Mandatory = false)]
        public System.Object AzTag;

        [Parameter(Position = 316, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzTextColor;

        [Parameter(Position = 317, Mandatory = false)]
        public System.String AzToolTip;

        [Parameter(Position = 318, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzSelectable;

        [Parameter(Position = 319, Mandatory = false)]
        public OxyPlot.SelectionMode AzSelectionMode;

        [Parameter(Position = 320, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzGapWidth;

        [Parameter(Position = 321, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzIsTickCentered;

        [Parameter(Position = 322, Mandatory = false)]
        public System.Collections.IEnumerable AzItemsSource;

        [Parameter(Position = 323, Mandatory = false)]
        public System.String AzLabelField;

        [Parameter(Position = 324, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzInvalidCategoryColor;

        [Parameter(Position = 325, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AzPalette;

        [Parameter(Position = 326, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AzCalendarWeekRule;

        [Parameter(Position = 327, Mandatory = false)]
        public System.DayOfWeek AzFirstDayOfWeek;

        [Parameter(Position = 328, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AzIntervalType;

        [Parameter(Position = 329, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AzMinorIntervalType;

        [Parameter(Position = 330, Mandatory = false)]
        public System.TimeZoneInfo AzTimeZone;

        [Parameter(Position = 331, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzInvalidNumberColor;

        [Parameter(Position = 332, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzHighColor;

        [Parameter(Position = 333, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzLowColor;

        [Parameter(Position = 334, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzRenderAsImage;

        [Parameter(Position = 335, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzBase;

        [Parameter(Position = 336, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.CandleStickAndVolumeSeriesBuilder _builder;

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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.CandleStickAndVolumeSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyColumnSeries")]
    [Alias("oxy.column", "oxy.col", "oxycol")]
    [OutputType(typeof(SeriesInfo<ColumnSeries>))]
    public class NewOxyColumnSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string ValueName = "Value";

        [Parameter(Position = 2, Mandatory = false)]
        public string CategoryName = "Category";

        [Parameter(Position = 3, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Value;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Category[] Category;

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
        public string Style = null;

        [Parameter(Position = 14, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 15, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 16, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ColumnWidth;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BaseValue;

        [Parameter(Position = 19, Mandatory = false)]
        public System.String ColorField;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsStacked;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.Series.LabelPlacement LabelPlacement;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor NegativeFillColor;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String StackGroup;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String ValueField;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 46, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 47, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 60, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 66, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 69, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 76, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 77, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 78, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 80, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 93, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 98, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 100, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 102, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 103, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 105, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 108, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 111, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 113, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 115, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 118, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 120, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 122, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 125, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 126, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 140, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 145, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 153, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 159, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 162, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 169, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 170, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 171, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 173, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 186, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 191, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 193, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 195, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 196, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 198, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 201, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 204, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 208, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 211, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 213, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 215, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 218, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 219, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

        [Parameter(Position = 222, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 223, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 224, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 225, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 226, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.ColumnSeriesBuilder _builder;

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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.ColumnSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyContourSeries")]
    [Alias("oxy.contour", "oxycontour")]
    [OutputType(typeof(SeriesInfo<ContourSeries>))]
    public class NewOxyContourSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName = "X";

        [Parameter(Position = 2, Mandatory = false)]
        public string YName = "Y";

        [Parameter(Position = 3, Mandatory = false)]
        public string ZName = "Z";

        [Parameter(Position = 4, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Z;

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
        public string Style = null;

        [Parameter(Position = 16, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 17, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 18, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ColumnCoordinates;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ContourLevelStep;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ContourLevels;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor[] ContourColors;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Object Data;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor LabelBackground;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelSpacing;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Int32 LabelStep;

        [Parameter(Position = 29, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] RowCoordinates;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 49, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 62, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 68, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 71, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 78, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 79, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 80, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 82, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 95, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 100, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 102, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 104, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 105, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 107, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 110, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 113, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 115, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 117, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 120, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 124, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 127, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 128, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 142, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 147, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 155, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 161, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 164, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 171, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 172, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 173, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 175, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 188, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 193, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 195, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 197, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 198, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 200, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 203, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 208, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 210, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 213, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 217, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 220, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 221, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.ContourSeriesBuilder _builder;

        private void AssignParameters(ContourSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("Color")) series.Color = Color;
            if (bp.ContainsKey("ColumnCoordinates")) series.ColumnCoordinates = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(ColumnCoordinates);
            if (bp.ContainsKey("ContourLevelStep")) series.ContourLevelStep = ContourLevelStep;
            if (bp.ContainsKey("ContourLevels")) series.ContourLevels = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(ContourLevels);
            if (bp.ContainsKey("ContourColors")) series.ContourColors = Horker.OxyPlotCli.TypeAdaptors.OxyColor.ConvertArray(ContourColors);
            if (bp.ContainsKey("Data")) series.Data = Horker.OxyPlotCli.TypeAdaptors.TwoDimensionalArray.ConvertFrom(Data);
            if (bp.ContainsKey("LabelBackground")) series.LabelBackground = LabelBackground;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelSpacing")) series.LabelSpacing = LabelSpacing;
            if (bp.ContainsKey("LabelStep")) series.LabelStep = LabelStep;
            if (bp.ContainsKey("LineStyle")) series.LineStyle = LineStyle;
            if (bp.ContainsKey("RowCoordinates")) series.RowCoordinates = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(RowCoordinates);
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.ContourSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyErrorColumnSeries")]
    [Alias("oxy.errorColumn", "oxy.ecol", "oxyecol")]
    [OutputType(typeof(SeriesInfo<ErrorColumnSeries>))]
    public class NewOxyErrorColumnSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string ValueName = "Value";

        [Parameter(Position = 2, Mandatory = false)]
        public string ErrorName = "Error";

        [Parameter(Position = 3, Mandatory = false)]
        public string CategoryName = "Category";

        [Parameter(Position = 4, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Value;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Error;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Category[] Category;

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
        public string Style = null;

        [Parameter(Position = 16, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 17, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 18, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ErrorStrokeThickness;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ErrorWidth;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ColumnWidth;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BaseValue;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String ColorField;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsStacked;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 28, Mandatory = false)]
        public OxyPlot.Series.LabelPlacement LabelPlacement;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor NegativeFillColor;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String StackGroup;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String ValueField;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 36, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 50, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 51, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 56, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 64, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 70, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 80, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 81, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 82, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 84, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 97, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 102, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 104, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 106, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 107, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 109, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 112, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 115, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 117, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 119, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 122, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 124, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 126, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 129, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 130, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 144, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 149, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 157, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 163, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 166, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 173, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 174, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 175, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 177, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 190, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 195, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 197, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 199, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 200, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 202, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 205, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 208, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 210, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 212, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 215, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 217, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 219, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 222, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 223, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

        [Parameter(Position = 226, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 227, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 228, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 229, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 230, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 235, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.ErrorColumnSeriesBuilder _builder;

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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.ErrorColumnSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyHighLowSeries")]
    [Alias("oxy.highLow", "oxyhighlow")]
    [OutputType(typeof(SeriesInfo<HighLowSeries>))]
    public class NewOxyHighLowSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName = "X";

        [Parameter(Position = 2, Mandatory = false)]
        public string HighName = "High";

        [Parameter(Position = 3, Mandatory = false)]
        public string LowName = "Low";

        [Parameter(Position = 4, Mandatory = false)]
        public string OpenName = "Open";

        [Parameter(Position = 5, Mandatory = false)]
        public string CloseName = "Close";

        [Parameter(Position = 6, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] High;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Low;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Open;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Close;

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
        public string Style = null;

        [Parameter(Position = 20, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 21, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 22, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Dashes;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String DataFieldClose;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String DataFieldHigh;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String DataFieldLow;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String DataFieldOpen;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 31, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.Series.HighLowItem> Mapping;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TickLength;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 47, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 49, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 51, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 52, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 65, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 71, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 74, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 81, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 82, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 83, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 85, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 98, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 103, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 105, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 107, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 108, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 110, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 113, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 116, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 118, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 120, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 123, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 125, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 127, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 130, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 131, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

        [Parameter(Position = 134, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 135, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 136, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 137, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 138, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 145, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 150, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 158, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 164, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 167, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 174, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 175, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 176, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 178, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 191, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 196, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 198, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 200, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 201, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 203, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 211, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 213, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 216, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 218, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 220, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 223, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 224, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 235, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.HighLowSeriesBuilder _builder;

        private void AssignParameters(HighLowSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("Color")) series.Color = Color;
            if (bp.ContainsKey("Dashes")) series.Dashes = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(Dashes);
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.HighLowSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyHistogramSeries")]
    [Alias("oxy.histogram", "oxy.hist", "oxyhist")]
    [OutputType(typeof(SeriesInfo<HistogramSeries>))]
    public class NewOxyHistogramSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string RangeStartName = "RangeStart";

        [Parameter(Position = 2, Mandatory = false)]
        public string RangeEndName = "RangeEnd";

        [Parameter(Position = 3, Mandatory = false)]
        public string AreaName = "Area";

        [Parameter(Position = 4, Mandatory = false)]
        public string CountName = "Count";

        [Parameter(Position = 5, Mandatory = false)]
        public string DataName = "Data";

        [Parameter(Position = 6, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] RangeStart;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] RangeEnd;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Area;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Count;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Data;

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
        public string Style = null;

        [Parameter(Position = 20, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 21, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 22, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor NegativeFillColor;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelFontSize;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.Series.LabelPlacement LabelPlacement;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CanTrackerInterpolatePoints;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.Series.HistogramItem> Mapping;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 49, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 50, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 63, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 69, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 72, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 79, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 80, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 81, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 83, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 96, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 101, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 103, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 105, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 106, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 108, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 111, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 114, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 116, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 118, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 121, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 123, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 125, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 128, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 129, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 143, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 148, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 156, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 162, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 165, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 172, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 173, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 174, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 176, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 189, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 194, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 196, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 198, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 199, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 201, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 204, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 207, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 211, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 214, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 216, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 218, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 221, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 222, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 235, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.HistogramSeriesBuilder _builder;

        private void AssignParameters(HistogramSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("FillColor")) series.FillColor = FillColor;
            if (bp.ContainsKey("NegativeFillColor")) series.NegativeFillColor = NegativeFillColor;
            if (bp.ContainsKey("StrokeColor")) series.StrokeColor = StrokeColor;
            if (bp.ContainsKey("StrokeThickness")) series.StrokeThickness = StrokeThickness;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelFontSize")) series.LabelFontSize = LabelFontSize;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("LabelPlacement")) series.LabelPlacement = LabelPlacement;
            if (bp.ContainsKey("CanTrackerInterpolatePoints")) series.CanTrackerInterpolatePoints = CanTrackerInterpolatePoints;
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.HistogramSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyHistogramSeries2")]
    [Alias("oxy.histogram2", "oxy.hist2", "oxyhist2")]
    [OutputType(typeof(SeriesInfo<ColumnSeries>))]
    public class NewOxyHistogramSeries2 : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string DataName = "Data";

        [Parameter(Position = 2, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 3, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Data;

        [Parameter(Position = 4, Mandatory = false)]
        public object[] Group = null;

        [Parameter(Position = 5, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 6, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 7, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 8, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 9, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 10, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 11, Mandatory = false)]
        public string Style = null;

        [Parameter(Position = 12, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 13, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 14, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ColumnWidth;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BaseValue;

        [Parameter(Position = 17, Mandatory = false)]
        public System.String ColorField;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsStacked;

        [Parameter(Position = 20, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 22, Mandatory = false)]
        public OxyPlot.Series.LabelPlacement LabelPlacement;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor NegativeFillColor;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String StackGroup;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String ValueField;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 44, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 45, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 50, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 58, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 64, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 74, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 75, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 76, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 78, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 91, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 96, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 98, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 100, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 101, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 103, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 106, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 109, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 111, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 113, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 116, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 118, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 120, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 123, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 124, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

        [Parameter(Position = 127, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 128, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 129, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 130, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 131, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 138, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 143, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 151, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 157, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 160, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 167, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 168, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 169, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 171, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 184, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 189, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 191, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 193, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 194, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 196, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 199, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 202, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 204, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 209, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 211, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 213, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 216, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 217, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.Histogram2SeriesBuilder _builder;

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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.Histogram2SeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyIntervalBarSeries")]
    [Alias("oxy.intervalBar", "oxy.ibar", "oxyibar")]
    [OutputType(typeof(SeriesInfo<IntervalBarSeries>))]
    public class NewOxyIntervalBarSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string StartName = "Start";

        [Parameter(Position = 2, Mandatory = false)]
        public string EndName = "End";

        [Parameter(Position = 3, Mandatory = false)]
        public string BarTitleName = "BarTitle";

        [Parameter(Position = 4, Mandatory = false)]
        public string CategoryName = "Category";

        [Parameter(Position = 5, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Start;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] End;

        [Parameter(Position = 8, Mandatory = false)]
        public System.String[] BarTitle;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Category[] Category;

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
        public string Style = null;

        [Parameter(Position = 18, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 19, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 20, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BarWidth;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor LabelColor;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String LabelField;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String MaximumField;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String MinimumField;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 47, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 48, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 53, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 61, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 67, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 70, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 77, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 78, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 79, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 81, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 94, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 99, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 101, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 103, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 104, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 106, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 109, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 112, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 114, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 116, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 119, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 121, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 123, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 126, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 127, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

        [Parameter(Position = 130, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 131, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 132, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 133, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 134, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 141, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 146, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 154, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 160, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 163, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 170, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 171, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 172, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 174, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 187, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 192, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 194, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 196, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 197, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 199, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 202, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 205, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 207, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 212, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 214, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 216, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 219, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 220, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.IntervalBarSeriesBuilder _builder;

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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.IntervalBarSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyLinearBarSeries")]
    [Alias("oxy.linearBar", "oxy.lbar", "oxylbar")]
    [OutputType(typeof(SeriesInfo<LinearBarSeries>))]
    public class NewOxyLinearBarSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName = "X";

        [Parameter(Position = 2, Mandatory = false)]
        public string YName = "Y";

        [Parameter(Position = 3, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y;

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
        public string Style = null;

        [Parameter(Position = 14, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 15, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 16, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BarWidth;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor NegativeFillColor;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor NegativeStrokeColor;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CanTrackerInterpolatePoints;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 43, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 44, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 49, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 57, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 63, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 66, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 73, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 74, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 75, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 77, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 90, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 95, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 97, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 99, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 100, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 102, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 105, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 108, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 110, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 112, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 115, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 117, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 119, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 122, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 123, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 137, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 142, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 150, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 156, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 159, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 166, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 167, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 168, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 170, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 183, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 188, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 190, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 192, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 193, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 195, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 198, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 201, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 203, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 205, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 208, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 210, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 212, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 215, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 216, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

        [Parameter(Position = 219, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 220, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 221, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 222, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 223, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.LinearBarSeriesBuilder _builder;

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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.LinearBarSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyLineSeries")]
    [Alias("oxy.line", "oxyline")]
    [OutputType(typeof(SeriesInfo<LineSeries>))]
    public class NewOxyLineSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName = "X";

        [Parameter(Position = 2, Mandatory = false)]
        public string YName = "Y";

        [Parameter(Position = 3, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y;

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
        public string Style = null;

        [Parameter(Position = 14, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 15, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 16, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 19, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Dashes;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 25, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 26, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 27, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] MarkerOutline;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 34, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.InterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CanTrackerInterpolatePoints;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 49, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 50, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 56, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 58, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 59, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 64, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 72, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 78, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 81, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 88, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 89, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 90, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 92, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 105, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 110, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 112, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 114, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 115, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 117, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 120, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 123, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 125, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 127, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 130, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 132, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 134, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 137, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 138, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 152, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 157, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 165, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 171, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 174, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 181, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 182, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 183, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 185, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 198, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 203, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 205, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 207, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 208, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 210, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 213, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 216, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 218, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 220, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 223, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 225, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 227, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 230, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 231, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

        [Parameter(Position = 234, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 235, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 236, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 237, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 238, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 239, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 240, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 241, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 242, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 243, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 244, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.LineSeriesBuilder _builder;

        private void AssignParameters(LineSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("Color")) series.Color = Color;
            if (bp.ContainsKey("BrokenLineColor")) series.BrokenLineColor = BrokenLineColor;
            if (bp.ContainsKey("BrokenLineStyle")) series.BrokenLineStyle = BrokenLineStyle;
            if (bp.ContainsKey("BrokenLineThickness")) series.BrokenLineThickness = BrokenLineThickness;
            if (bp.ContainsKey("Dashes")) series.Dashes = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(Dashes);
            if (bp.ContainsKey("Decimator")) series.Decimator = Decimator;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("LineJoin")) series.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) series.LineStyle = LineStyle;
            if (bp.ContainsKey("LineLegendPosition")) series.LineLegendPosition = LineLegendPosition;
            if (bp.ContainsKey("MarkerFill")) series.MarkerFill = MarkerFill;
            if (bp.ContainsKey("MarkerOutline")) series.MarkerOutline = Horker.OxyPlotCli.TypeAdaptors.ScreenPoint.ConvertArray(MarkerOutline);
            if (bp.ContainsKey("MarkerResolution")) series.MarkerResolution = MarkerResolution;
            if (bp.ContainsKey("MarkerSize")) series.MarkerSize = MarkerSize;
            if (bp.ContainsKey("MarkerStroke")) series.MarkerStroke = MarkerStroke;
            if (bp.ContainsKey("MarkerStrokeThickness")) series.MarkerStrokeThickness = MarkerStrokeThickness;
            if (bp.ContainsKey("MarkerType")) series.MarkerType = MarkerType;
            if (bp.ContainsKey("MinimumSegmentLength")) series.MinimumSegmentLength = MinimumSegmentLength;
            if (bp.ContainsKey("InterpolationAlgorithm")) series.InterpolationAlgorithm = InterpolationAlgorithm.Value;
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.LineSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyPieSeries")]
    [Alias("oxy.pie", "oxypie")]
    [OutputType(typeof(SeriesInfo<PieSeries>))]
    public class NewOxyPieSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string LabelName = "Label";

        [Parameter(Position = 2, Mandatory = false)]
        public string ValueName = "Value";

        [Parameter(Position = 3, Mandatory = false)]
        public string FillName = "Fill";

        [Parameter(Position = 4, Mandatory = false)]
        public string IsExplodedName = "IsExploded";

        [Parameter(Position = 5, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 6, Mandatory = false)]
        public System.String[] Label;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Value;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor[] Fill;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool[] IsExploded;

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
        public string Style = null;

        [Parameter(Position = 18, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 19, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 20, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AngleIncrement;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AngleSpan;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AreInsideLabelsAngled;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String ColorField;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Diameter;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ExplodedDistance;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double InnerDiameter;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor InsideLabelColor;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String InsideLabelFormat;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double InsideLabelPosition;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String IsExplodedField;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String LabelField;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String LegendFormat;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String OutsideLabelFormat;

        [Parameter(Position = 35, Mandatory = false)]
        public System.Collections.Generic.IList<OxyPlot.Series.PieSlice> Slices;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StartAngle;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Stroke;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TickDistance;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TickHorizontalLength;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TickLabelDistance;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TickRadialLength;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String ValueField;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 49, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 50, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 56, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 58, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        private Horker.OxyPlotCli.SeriesBuilders.PieSeriesBuilder _builder;

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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.PieSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyRectangleBarSeries")]
    [Alias("oxy.rectangleBar", "oxy.rbar", "oxyrbar")]
    [OutputType(typeof(SeriesInfo<RectangleBarSeries>))]
    public class NewOxyRectangleBarSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string X0Name = "X0";

        [Parameter(Position = 2, Mandatory = false)]
        public string Y0Name = "Y0";

        [Parameter(Position = 3, Mandatory = false)]
        public string X1Name = "X1";

        [Parameter(Position = 4, Mandatory = false)]
        public string Y1Name = "Y1";

        [Parameter(Position = 5, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X0;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y0;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X1;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y1;

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
        public string Style = null;

        [Parameter(Position = 18, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 19, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 20, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor FillColor;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor LabelColor;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 42, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 43, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 56, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 62, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 65, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 72, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 73, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 74, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 76, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 89, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 94, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 96, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 98, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 99, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 101, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 104, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 107, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 109, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 111, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 114, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 116, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 118, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 121, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 136, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 141, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 149, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 155, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 158, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 165, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 166, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 167, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 169, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 182, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 187, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 189, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 191, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 192, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 194, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 197, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 200, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 202, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 204, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 207, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 211, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 214, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.RectangleBarSeriesBuilder _builder;

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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.RectangleBarSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyRectangleSeries")]
    [Alias("oxy.rectangle", "oxy.rec", "oxyrec")]
    [OutputType(typeof(SeriesInfo<RectangleSeries>))]
    public class NewOxyRectangleSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string X1Name = "X1";

        [Parameter(Position = 2, Mandatory = false)]
        public string X2Name = "X2";

        [Parameter(Position = 3, Mandatory = false)]
        public string Y1Name = "Y1";

        [Parameter(Position = 4, Mandatory = false)]
        public string Y2Name = "Y2";

        [Parameter(Position = 5, Mandatory = false)]
        public string ValueName = "Value";

        [Parameter(Position = 6, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X1;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X2;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y1;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y2;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Value;

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
        public string Style = null;

        [Parameter(Position = 20, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 21, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 22, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String ColorAxisKey;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelFontSize;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CanTrackerInterpolatePoints;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.Series.RectangleItem> Mapping;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 44, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 45, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 50, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 58, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 64, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 67, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 74, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 75, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 76, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 78, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 91, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 96, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 98, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 100, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 101, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 103, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 106, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 109, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 111, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 113, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 116, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 118, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 120, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 123, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 124, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

        [Parameter(Position = 127, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 128, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 129, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 130, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 131, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 138, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 143, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 151, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 157, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 160, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 167, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 168, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 169, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 171, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 184, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 189, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 191, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 193, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 194, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 196, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 199, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 202, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 204, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 209, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 211, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 213, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 216, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 217, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        [Parameter(Position = 231, Mandatory = false)]
        public string AzType;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzStartAngle;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzEndAngle;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzFormatAsFractions;

        [Parameter(Position = 235, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzFractionUnit;

        [Parameter(Position = 236, Mandatory = false)]
        public System.String AzFractionUnitSymbol;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzAbsoluteMaximum;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzAbsoluteMinimum;

        [Parameter(Position = 239, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzAngle;

        [Parameter(Position = 240, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzAxisTickToLabelDistance;

        [Parameter(Position = 241, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzAxisTitleDistance;

        [Parameter(Position = 242, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzAxisDistance;

        [Parameter(Position = 243, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzAxislineColor;

        [Parameter(Position = 244, Mandatory = false)]
        public OxyPlot.LineStyle AzAxislineStyle;

        [Parameter(Position = 245, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzAxislineThickness;

        [Parameter(Position = 246, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzClipTitle;

        [Parameter(Position = 247, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzCropGridlines;

        [Parameter(Position = 248, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzEndPosition;

        [Parameter(Position = 249, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzExtraGridlineColor;

        [Parameter(Position = 250, Mandatory = false)]
        public OxyPlot.LineStyle AzExtraGridlineStyle;

        [Parameter(Position = 251, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzExtraGridlineThickness;

        [Parameter(Position = 252, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AzExtraGridlines;

        [Parameter(Position = 253, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AzFilterFunction;

        [Parameter(Position = 254, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzFilterMaxValue;

        [Parameter(Position = 255, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzFilterMinValue;

        [Parameter(Position = 256, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzIntervalLength;

        [Parameter(Position = 257, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzIsAxisVisible;

        [Parameter(Position = 258, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzIsPanEnabled;

        [Parameter(Position = 259, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzIsZoomEnabled;

        [Parameter(Position = 260, Mandatory = false)]
        public System.String AzKey;

        [Parameter(Position = 261, Mandatory = false)]
        public System.Func<System.Double,System.String> AzLabelFormatter;

        [Parameter(Position = 262, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AzLayer;

        [Parameter(Position = 263, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzMajorGridlineColor;

        [Parameter(Position = 264, Mandatory = false)]
        public OxyPlot.LineStyle AzMajorGridlineStyle;

        [Parameter(Position = 265, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMajorGridlineThickness;

        [Parameter(Position = 266, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMajorStep;

        [Parameter(Position = 267, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMajorTickSize;

        [Parameter(Position = 268, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMaximum;

        [Parameter(Position = 269, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMaximumPadding;

        [Parameter(Position = 270, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMaximumRange;

        [Parameter(Position = 271, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinimum;

        [Parameter(Position = 272, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinimumMajorStep;

        [Parameter(Position = 273, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinimumMinorStep;

        [Parameter(Position = 274, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinimumPadding;

        [Parameter(Position = 275, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinimumRange;

        [Parameter(Position = 276, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzMinorGridlineColor;

        [Parameter(Position = 277, Mandatory = false)]
        public OxyPlot.LineStyle AzMinorGridlineStyle;

        [Parameter(Position = 278, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinorGridlineThickness;

        [Parameter(Position = 279, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinorStep;

        [Parameter(Position = 280, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzMinorTicklineColor;

        [Parameter(Position = 281, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzMinorTickSize;

        [Parameter(Position = 282, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AzPosition;

        [Parameter(Position = 283, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzPositionAtZeroCrossing;

        [Parameter(Position = 284, Mandatory = false)]
        public System.Int32 AzPositionTier;

        [Parameter(Position = 285, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzStartPosition;

        [Parameter(Position = 286, Mandatory = false)]
        public System.String AzStringFormat;

        [Parameter(Position = 287, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AzTickStyle;

        [Parameter(Position = 288, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzTicklineColor;

        [Parameter(Position = 289, Mandatory = false)]
        public System.String AzTitle;

        [Parameter(Position = 290, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzTitleClippingLength;

        [Parameter(Position = 291, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzTitleColor;

        [Parameter(Position = 292, Mandatory = false)]
        public System.String AzTitleFont;

        [Parameter(Position = 293, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzTitleFontSize;

        [Parameter(Position = 294, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzTitleFontWeight;

        [Parameter(Position = 295, Mandatory = false)]
        public System.String AzTitleFormatString;

        [Parameter(Position = 296, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzTitlePosition;

        [Parameter(Position = 297, Mandatory = false)]
        public System.String AzUnit;

        [Parameter(Position = 298, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzUseSuperExponentialFormat;

        [Parameter(Position = 299, Mandatory = false)]
        public System.String AzFont;

        [Parameter(Position = 300, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzFontSize;

        [Parameter(Position = 301, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzFontWeight;

        [Parameter(Position = 302, Mandatory = false)]
        public System.Object AzTag;

        [Parameter(Position = 303, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzTextColor;

        [Parameter(Position = 304, Mandatory = false)]
        public System.String AzToolTip;

        [Parameter(Position = 305, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzSelectable;

        [Parameter(Position = 306, Mandatory = false)]
        public OxyPlot.SelectionMode AzSelectionMode;

        [Parameter(Position = 307, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzGapWidth;

        [Parameter(Position = 308, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzIsTickCentered;

        [Parameter(Position = 309, Mandatory = false)]
        public System.Collections.IEnumerable AzItemsSource;

        [Parameter(Position = 310, Mandatory = false)]
        public System.String AzLabelField;

        [Parameter(Position = 311, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzInvalidCategoryColor;

        [Parameter(Position = 312, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AzPalette;

        [Parameter(Position = 313, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AzCalendarWeekRule;

        [Parameter(Position = 314, Mandatory = false)]
        public System.DayOfWeek AzFirstDayOfWeek;

        [Parameter(Position = 315, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AzIntervalType;

        [Parameter(Position = 316, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AzMinorIntervalType;

        [Parameter(Position = 317, Mandatory = false)]
        public System.TimeZoneInfo AzTimeZone;

        [Parameter(Position = 318, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzInvalidNumberColor;

        [Parameter(Position = 319, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzHighColor;

        [Parameter(Position = 320, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AzLowColor;

        [Parameter(Position = 321, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzRenderAsImage;

        [Parameter(Position = 322, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AzBase;

        [Parameter(Position = 323, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AzPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.RectangleSeriesBuilder _builder;

        private void AssignParameters(RectangleSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("ColorAxisKey")) series.ColorAxisKey = ColorAxisKey;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelFontSize")) series.LabelFontSize = LabelFontSize;
            if (bp.ContainsKey("CanTrackerInterpolatePoints")) series.CanTrackerInterpolatePoints = CanTrackerInterpolatePoints;
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.RectangleSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyScatterSeries")]
    [Alias("oxy.scatter", "oxy.scat", "oxyscat")]
    [OutputType(typeof(SeriesInfo<ScatterSeries>))]
    public class NewOxyScatterSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName = "X";

        [Parameter(Position = 2, Mandatory = false)]
        public string YName = "Y";

        [Parameter(Position = 3, Mandatory = false)]
        public string SizeName = "Size";

        [Parameter(Position = 4, Mandatory = false)]
        public string ValueName = "Value";

        [Parameter(Position = 5, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Size;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Value;

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
        public string Style = null;

        [Parameter(Position = 18, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 19, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 20, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 21, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.Series.ScatterPoint> Mapping;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Int32 BinSize;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String ColorAxisKey;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String DataFieldSize;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String DataFieldTag;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String DataFieldValue;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] MarkerOutline;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 36, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 39, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 53, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 54, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 59, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 67, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 73, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 76, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 83, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 84, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 85, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 87, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 100, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 105, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 107, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 109, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 110, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 112, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 115, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 118, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 120, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 125, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 127, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 129, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 132, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 133, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 147, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 152, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 160, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 166, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 169, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 176, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 177, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 178, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 180, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 193, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 198, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 200, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 202, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 203, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 205, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 208, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 211, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 213, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 218, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 220, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 222, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 225, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 226, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 235, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 239, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.ScatterSeriesBuilder _builder;

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
            if (bp.ContainsKey("MarkerOutline")) series.MarkerOutline = Horker.OxyPlotCli.TypeAdaptors.ScreenPoint.ConvertArray(MarkerOutline);
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.ScatterSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyScatterErrorSeries")]
    [Alias("oxy.scatterError", "oxy.scate", "oxyscate")]
    [OutputType(typeof(SeriesInfo<ScatterErrorSeries>))]
    public class NewOxyScatterErrorSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName = "X";

        [Parameter(Position = 2, Mandatory = false)]
        public string YName = "Y";

        [Parameter(Position = 3, Mandatory = false)]
        public string ErrorXName = "ErrorX";

        [Parameter(Position = 4, Mandatory = false)]
        public string ErrorYName = "ErrorY";

        [Parameter(Position = 5, Mandatory = false)]
        public string SizeName = "Size";

        [Parameter(Position = 6, Mandatory = false)]
        public string ValueName = "Value";

        [Parameter(Position = 7, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ErrorX;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] ErrorY;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Size;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Value;

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
        public string Style = null;

        [Parameter(Position = 22, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 23, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 24, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String DataFieldErrorX;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String DataFieldErrorY;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor ErrorBarColor;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ErrorBarStopWidth;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ErrorBarStrokeThickness;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumErrorSize;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 33, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.Series.ScatterErrorPoint> Mapping;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Int32 BinSize;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String ColorAxisKey;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String DataFieldSize;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String DataFieldTag;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String DataFieldValue;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] MarkerOutline;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 46, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 56, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 59, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 63, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 64, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 69, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 77, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 83, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 86, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 93, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 94, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 95, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 97, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 110, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 115, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 117, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 119, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 120, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 125, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 128, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 130, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 132, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 135, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 137, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 139, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 142, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 143, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 157, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 162, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 170, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 176, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 179, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 186, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 187, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 188, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 190, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 203, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 208, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 210, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 212, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 213, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 218, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 221, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 223, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 225, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 228, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 230, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 232, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 235, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 236, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

        [Parameter(Position = 239, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 240, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 241, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 242, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 243, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 244, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 245, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 246, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 247, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 248, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 249, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.ScatterErrorSeriesBuilder _builder;

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
            if (bp.ContainsKey("MarkerOutline")) series.MarkerOutline = Horker.OxyPlotCli.TypeAdaptors.ScreenPoint.ConvertArray(MarkerOutline);
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.ScatterErrorSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyStairStepSeries")]
    [Alias("oxy.stairStep", "oxy.stair", "oxystair")]
    [OutputType(typeof(SeriesInfo<StairStepSeries>))]
    public class NewOxyStairStepSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName = "X";

        [Parameter(Position = 2, Mandatory = false)]
        public string YName = "Y";

        [Parameter(Position = 3, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y;

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
        public string Style = null;

        [Parameter(Position = 14, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 15, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 16, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double VerticalStrokeThickness;

        [Parameter(Position = 18, Mandatory = false)]
        public OxyPlot.LineStyle VerticalLineStyle;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Dashes;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 27, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 28, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 29, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] MarkerOutline;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 36, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.InterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CanTrackerInterpolatePoints;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 49, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 53, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 56, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 60, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 61, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 66, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 74, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 80, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 83, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 90, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 91, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 92, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 94, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 107, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 112, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 114, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 116, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 117, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 119, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 125, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 127, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 129, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 132, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 134, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 136, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 139, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 140, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

        [Parameter(Position = 143, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 144, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 145, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 146, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 147, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 154, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 159, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 167, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 173, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 176, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 183, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 184, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 185, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 187, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 200, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 205, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 207, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 210, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 212, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 218, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 220, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 222, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 225, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 227, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 229, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 232, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 233, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 235, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 242, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 243, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 244, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 245, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 246, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.StairStepSeriesBuilder _builder;

        private void AssignParameters(StairStepSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("VerticalStrokeThickness")) series.VerticalStrokeThickness = VerticalStrokeThickness;
            if (bp.ContainsKey("VerticalLineStyle")) series.VerticalLineStyle = VerticalLineStyle;
            if (bp.ContainsKey("Color")) series.Color = Color;
            if (bp.ContainsKey("BrokenLineColor")) series.BrokenLineColor = BrokenLineColor;
            if (bp.ContainsKey("BrokenLineStyle")) series.BrokenLineStyle = BrokenLineStyle;
            if (bp.ContainsKey("BrokenLineThickness")) series.BrokenLineThickness = BrokenLineThickness;
            if (bp.ContainsKey("Dashes")) series.Dashes = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(Dashes);
            if (bp.ContainsKey("Decimator")) series.Decimator = Decimator;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("LineJoin")) series.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) series.LineStyle = LineStyle;
            if (bp.ContainsKey("LineLegendPosition")) series.LineLegendPosition = LineLegendPosition;
            if (bp.ContainsKey("MarkerFill")) series.MarkerFill = MarkerFill;
            if (bp.ContainsKey("MarkerOutline")) series.MarkerOutline = Horker.OxyPlotCli.TypeAdaptors.ScreenPoint.ConvertArray(MarkerOutline);
            if (bp.ContainsKey("MarkerResolution")) series.MarkerResolution = MarkerResolution;
            if (bp.ContainsKey("MarkerSize")) series.MarkerSize = MarkerSize;
            if (bp.ContainsKey("MarkerStroke")) series.MarkerStroke = MarkerStroke;
            if (bp.ContainsKey("MarkerStrokeThickness")) series.MarkerStrokeThickness = MarkerStrokeThickness;
            if (bp.ContainsKey("MarkerType")) series.MarkerType = MarkerType;
            if (bp.ContainsKey("MinimumSegmentLength")) series.MinimumSegmentLength = MinimumSegmentLength;
            if (bp.ContainsKey("InterpolationAlgorithm")) series.InterpolationAlgorithm = InterpolationAlgorithm.Value;
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.StairStepSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyStemSeries")]
    [Alias("oxy.stem", "oxystem")]
    [OutputType(typeof(SeriesInfo<StemSeries>))]
    public class NewOxyStemSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName = "X";

        [Parameter(Position = 2, Mandatory = false)]
        public string YName = "Y";

        [Parameter(Position = 3, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y;

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
        public string Style = null;

        [Parameter(Position = 14, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 15, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 16, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Base;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Dashes;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 24, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 26, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 27, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 28, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] MarkerOutline;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 35, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.InterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CanTrackerInterpolatePoints;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 42, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 45, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 50, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 55, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 59, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 60, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 73, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 79, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 82, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 89, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 90, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 91, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 93, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 106, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 111, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 113, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 115, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 116, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 118, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 121, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 124, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 126, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 128, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 131, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 133, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 135, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 138, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 139, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

        [Parameter(Position = 142, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 143, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 144, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 145, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 146, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 153, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 158, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 166, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 172, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 175, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 182, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 183, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 184, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 186, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 199, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 204, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 206, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 208, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 209, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 211, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 214, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 217, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 219, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 221, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 224, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 226, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 228, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 231, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 232, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

        [Parameter(Position = 235, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 236, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 237, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 238, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 239, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 240, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 241, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 242, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 243, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 244, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 245, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.StemSeriesBuilder _builder;

        private void AssignParameters(StemSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("Base")) series.Base = Base;
            if (bp.ContainsKey("Color")) series.Color = Color;
            if (bp.ContainsKey("BrokenLineColor")) series.BrokenLineColor = BrokenLineColor;
            if (bp.ContainsKey("BrokenLineStyle")) series.BrokenLineStyle = BrokenLineStyle;
            if (bp.ContainsKey("BrokenLineThickness")) series.BrokenLineThickness = BrokenLineThickness;
            if (bp.ContainsKey("Dashes")) series.Dashes = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(Dashes);
            if (bp.ContainsKey("Decimator")) series.Decimator = Decimator;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("LineJoin")) series.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) series.LineStyle = LineStyle;
            if (bp.ContainsKey("LineLegendPosition")) series.LineLegendPosition = LineLegendPosition;
            if (bp.ContainsKey("MarkerFill")) series.MarkerFill = MarkerFill;
            if (bp.ContainsKey("MarkerOutline")) series.MarkerOutline = Horker.OxyPlotCli.TypeAdaptors.ScreenPoint.ConvertArray(MarkerOutline);
            if (bp.ContainsKey("MarkerResolution")) series.MarkerResolution = MarkerResolution;
            if (bp.ContainsKey("MarkerSize")) series.MarkerSize = MarkerSize;
            if (bp.ContainsKey("MarkerStroke")) series.MarkerStroke = MarkerStroke;
            if (bp.ContainsKey("MarkerStrokeThickness")) series.MarkerStrokeThickness = MarkerStrokeThickness;
            if (bp.ContainsKey("MarkerType")) series.MarkerType = MarkerType;
            if (bp.ContainsKey("MinimumSegmentLength")) series.MinimumSegmentLength = MinimumSegmentLength;
            if (bp.ContainsKey("InterpolationAlgorithm")) series.InterpolationAlgorithm = InterpolationAlgorithm.Value;
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.StemSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyThreeColorLineSeries")]
    [Alias("oxy.ThreeColorLine", "oxy.3cLine", "oxy3cline")]
    [OutputType(typeof(SeriesInfo<ThreeColorLineSeries>))]
    public class NewOxyThreeColorLineSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName = "X";

        [Parameter(Position = 2, Mandatory = false)]
        public string YName = "Y";

        [Parameter(Position = 3, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y;

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
        public string Style = null;

        [Parameter(Position = 14, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 15, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 16, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor ColorLo;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor ColorHi;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LimitHi;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LimitLo;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] DashesHi;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] DashesLo;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.LineStyle LineStyleHi;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.LineStyle LineStyleLo;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 27, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Dashes;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 31, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 34, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 35, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] MarkerOutline;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 42, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.InterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CanTrackerInterpolatePoints;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 50, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 52, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 59, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 62, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 64, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 66, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 67, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 72, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 80, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 86, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 89, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 96, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 97, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 98, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 100, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 113, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 118, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 120, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 123, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 125, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 128, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 131, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 133, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 135, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 138, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 140, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 142, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 145, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 146, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

        [Parameter(Position = 149, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 150, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 151, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 152, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 153, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 160, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 165, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 173, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 179, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 182, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 189, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 190, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 191, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 193, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 206, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 211, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 213, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 216, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 218, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 221, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 224, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 226, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 228, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 231, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 233, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 234, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 235, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 238, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 239, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 240, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 241, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

        [Parameter(Position = 242, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 243, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 244, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 245, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 246, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 247, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 248, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 249, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 250, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 251, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 252, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.ThreeColorLineSeriesBuilder _builder;

        private void AssignParameters(ThreeColorLineSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("ColorLo")) series.ColorLo = ColorLo;
            if (bp.ContainsKey("ColorHi")) series.ColorHi = ColorHi;
            if (bp.ContainsKey("LimitHi")) series.LimitHi = LimitHi;
            if (bp.ContainsKey("LimitLo")) series.LimitLo = LimitLo;
            if (bp.ContainsKey("DashesHi")) series.DashesHi = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(DashesHi);
            if (bp.ContainsKey("DashesLo")) series.DashesLo = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(DashesLo);
            if (bp.ContainsKey("LineStyleHi")) series.LineStyleHi = LineStyleHi;
            if (bp.ContainsKey("LineStyleLo")) series.LineStyleLo = LineStyleLo;
            if (bp.ContainsKey("Color")) series.Color = Color;
            if (bp.ContainsKey("BrokenLineColor")) series.BrokenLineColor = BrokenLineColor;
            if (bp.ContainsKey("BrokenLineStyle")) series.BrokenLineStyle = BrokenLineStyle;
            if (bp.ContainsKey("BrokenLineThickness")) series.BrokenLineThickness = BrokenLineThickness;
            if (bp.ContainsKey("Dashes")) series.Dashes = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(Dashes);
            if (bp.ContainsKey("Decimator")) series.Decimator = Decimator;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("LineJoin")) series.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) series.LineStyle = LineStyle;
            if (bp.ContainsKey("LineLegendPosition")) series.LineLegendPosition = LineLegendPosition;
            if (bp.ContainsKey("MarkerFill")) series.MarkerFill = MarkerFill;
            if (bp.ContainsKey("MarkerOutline")) series.MarkerOutline = Horker.OxyPlotCli.TypeAdaptors.ScreenPoint.ConvertArray(MarkerOutline);
            if (bp.ContainsKey("MarkerResolution")) series.MarkerResolution = MarkerResolution;
            if (bp.ContainsKey("MarkerSize")) series.MarkerSize = MarkerSize;
            if (bp.ContainsKey("MarkerStroke")) series.MarkerStroke = MarkerStroke;
            if (bp.ContainsKey("MarkerStrokeThickness")) series.MarkerStrokeThickness = MarkerStrokeThickness;
            if (bp.ContainsKey("MarkerType")) series.MarkerType = MarkerType;
            if (bp.ContainsKey("MinimumSegmentLength")) series.MinimumSegmentLength = MinimumSegmentLength;
            if (bp.ContainsKey("InterpolationAlgorithm")) series.InterpolationAlgorithm = InterpolationAlgorithm.Value;
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.ThreeColorLineSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyTornadoBarSeries")]
    [Alias("oxy.tornadoBar", "oxy.tornado", "oxytornado")]
    [OutputType(typeof(SeriesInfo<TornadoBarSeries>))]
    public class NewOxyTornadoBarSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string MinimumName = "Minimum";

        [Parameter(Position = 2, Mandatory = false)]
        public string MaximumName = "Maximum";

        [Parameter(Position = 3, Mandatory = false)]
        public string BarBaseValueName = "BarBaseValue";

        [Parameter(Position = 4, Mandatory = false)]
        public string MinimumColorName = "MinimumColor";

        [Parameter(Position = 5, Mandatory = false)]
        public string MaximumColorName = "MaximumColor";

        [Parameter(Position = 6, Mandatory = false)]
        public string CategoryName = "Category";

        [Parameter(Position = 7, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Minimum;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Maximum;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] BarBaseValue;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor[] MinimumColor;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor[] MaximumColor;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Category[] Category;

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
        public string Style = null;

        [Parameter(Position = 22, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 23, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 24, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BarWidth;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BaseValue;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor LabelColor;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String LabelField;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String MaximumField;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MaximumFillColor;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String MaximumLabelFormatString;

        [Parameter(Position = 33, Mandatory = false)]
        public System.String MinimumField;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MinimumFillColor;

        [Parameter(Position = 35, Mandatory = false)]
        public System.String MinimumLabelFormatString;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor StrokeColor;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 43, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 45, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 54, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 55, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 68, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 74, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 77, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 84, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 85, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 86, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 88, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 101, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 106, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 108, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 110, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 111, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 113, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 116, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 119, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 121, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 123, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 126, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 128, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 130, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 133, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 134, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 148, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 153, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 161, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 167, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 170, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 177, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 178, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 179, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 181, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 194, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 199, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 201, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 203, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 204, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 206, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 209, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 212, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 214, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 216, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 219, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 221, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 223, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 226, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 227, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 239, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 240, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.TornadoBarSeriesBuilder _builder;

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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.TornadoBarSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyTwoColorAreaSeries")]
    [Alias("oxy.twoColorArea", "oxy.2cArea", "oxy2carea")]
    [OutputType(typeof(SeriesInfo<TwoColorAreaSeries>))]
    public class NewOxyTwoColorAreaSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string X1Name = "X1";

        [Parameter(Position = 2, Mandatory = false)]
        public string Y1Name = "Y1";

        [Parameter(Position = 3, Mandatory = false)]
        public string X2Name = "X2";

        [Parameter(Position = 4, Mandatory = false)]
        public string Y2Name = "Y2";

        [Parameter(Position = 5, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X1;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y1;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X2;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y2;

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
        public string Style = null;

        [Parameter(Position = 18, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 19, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 20, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Fill2;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Dashes2;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle2;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerFill2;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerStroke2;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Limit;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double ConstantY2;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String DataFieldX2;

        [Parameter(Position = 29, Mandatory = false)]
        public System.String DataFieldY2;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color2;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Fill;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Reverse2;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 35, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Dashes;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 41, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 42, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 43, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] MarkerOutline;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 50, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.InterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CanTrackerInterpolatePoints;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 56, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 57, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

        [Parameter(Position = 58, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 59, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 60, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 63, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 65, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 66, Mandatory = false)]
        public System.String TrackerKey;

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
        public string AxType;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 80, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 88, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 94, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 97, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 104, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 105, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 106, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 108, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 121, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 126, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 128, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 130, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 131, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 133, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 136, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 139, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 141, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 143, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 146, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 148, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 150, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 153, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 154, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

        [Parameter(Position = 157, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 158, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 159, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 160, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 161, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 168, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 173, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 181, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 187, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 190, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 197, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 198, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 199, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 201, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 207, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 214, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 219, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 221, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 223, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 224, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 226, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 229, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 232, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 234, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 235, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 236, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 239, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 240, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 241, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 242, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 243, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 244, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 245, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 246, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 247, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 248, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 249, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

        [Parameter(Position = 250, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 251, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 252, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 253, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 254, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 255, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 256, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 257, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 258, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 259, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 260, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.TwoColorAreaSeriesBuilder _builder;

        private void AssignParameters(TwoColorAreaSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("Fill2")) series.Fill2 = Fill2;
            if (bp.ContainsKey("Dashes2")) series.Dashes2 = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(Dashes2);
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
            if (bp.ContainsKey("Dashes")) series.Dashes = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(Dashes);
            if (bp.ContainsKey("Decimator")) series.Decimator = Decimator;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("LineJoin")) series.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) series.LineStyle = LineStyle;
            if (bp.ContainsKey("LineLegendPosition")) series.LineLegendPosition = LineLegendPosition;
            if (bp.ContainsKey("MarkerFill")) series.MarkerFill = MarkerFill;
            if (bp.ContainsKey("MarkerOutline")) series.MarkerOutline = Horker.OxyPlotCli.TypeAdaptors.ScreenPoint.ConvertArray(MarkerOutline);
            if (bp.ContainsKey("MarkerResolution")) series.MarkerResolution = MarkerResolution;
            if (bp.ContainsKey("MarkerSize")) series.MarkerSize = MarkerSize;
            if (bp.ContainsKey("MarkerStroke")) series.MarkerStroke = MarkerStroke;
            if (bp.ContainsKey("MarkerStrokeThickness")) series.MarkerStrokeThickness = MarkerStrokeThickness;
            if (bp.ContainsKey("MarkerType")) series.MarkerType = MarkerType;
            if (bp.ContainsKey("MinimumSegmentLength")) series.MinimumSegmentLength = MinimumSegmentLength;
            if (bp.ContainsKey("InterpolationAlgorithm")) series.InterpolationAlgorithm = InterpolationAlgorithm.Value;
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.TwoColorAreaSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyTwoColorLineSeries")]
    [Alias("oxy.twoColorLine", "oxy.2cLine", "oxy2cline")]
    [OutputType(typeof(SeriesInfo<TwoColorLineSeries>))]
    public class NewOxyTwoColorLineSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName = "X";

        [Parameter(Position = 2, Mandatory = false)]
        public string YName = "Y";

        [Parameter(Position = 3, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 4, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X;

        [Parameter(Position = 5, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Y;

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
        public string Style = null;

        [Parameter(Position = 14, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 15, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 16, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color2;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double Limit;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Dashes2;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle2;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Dashes;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 29, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 31, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] MarkerOutline;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 38, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.InterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CanTrackerInterpolatePoints;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 53, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 54, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 58, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 62, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 63, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 68, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 76, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 82, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 85, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 92, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 93, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 94, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 96, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 109, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 114, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 116, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 118, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 119, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 120, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 121, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 124, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 127, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 129, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 131, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 134, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 136, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 138, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 141, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 142, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

        [Parameter(Position = 145, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 146, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 147, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 148, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 149, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 156, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 161, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 169, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 175, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 178, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 179, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 185, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 186, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 187, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 189, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 202, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 207, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 209, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 210, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 211, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 212, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 213, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 214, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 217, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 220, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 222, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 224, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 227, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 229, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 231, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 234, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 235, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 244, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 245, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 246, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 247, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 248, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.TwoColorLineSeriesBuilder _builder;

        private void AssignParameters(TwoColorLineSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("Color2")) series.Color2 = Color2;
            if (bp.ContainsKey("Limit")) series.Limit = Limit;
            if (bp.ContainsKey("Dashes2")) series.Dashes2 = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(Dashes2);
            if (bp.ContainsKey("LineStyle2")) series.LineStyle2 = LineStyle2;
            if (bp.ContainsKey("Color")) series.Color = Color;
            if (bp.ContainsKey("BrokenLineColor")) series.BrokenLineColor = BrokenLineColor;
            if (bp.ContainsKey("BrokenLineStyle")) series.BrokenLineStyle = BrokenLineStyle;
            if (bp.ContainsKey("BrokenLineThickness")) series.BrokenLineThickness = BrokenLineThickness;
            if (bp.ContainsKey("Dashes")) series.Dashes = Horker.OxyPlotCli.TypeAdaptors.Double.ConvertArray(Dashes);
            if (bp.ContainsKey("Decimator")) series.Decimator = Decimator;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("LineJoin")) series.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) series.LineStyle = LineStyle;
            if (bp.ContainsKey("LineLegendPosition")) series.LineLegendPosition = LineLegendPosition;
            if (bp.ContainsKey("MarkerFill")) series.MarkerFill = MarkerFill;
            if (bp.ContainsKey("MarkerOutline")) series.MarkerOutline = Horker.OxyPlotCli.TypeAdaptors.ScreenPoint.ConvertArray(MarkerOutline);
            if (bp.ContainsKey("MarkerResolution")) series.MarkerResolution = MarkerResolution;
            if (bp.ContainsKey("MarkerSize")) series.MarkerSize = MarkerSize;
            if (bp.ContainsKey("MarkerStroke")) series.MarkerStroke = MarkerStroke;
            if (bp.ContainsKey("MarkerStrokeThickness")) series.MarkerStrokeThickness = MarkerStrokeThickness;
            if (bp.ContainsKey("MarkerType")) series.MarkerType = MarkerType;
            if (bp.ContainsKey("MinimumSegmentLength")) series.MinimumSegmentLength = MinimumSegmentLength;
            if (bp.ContainsKey("InterpolationAlgorithm")) series.InterpolationAlgorithm = InterpolationAlgorithm.Value;
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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.TwoColorLineSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

    [Cmdlet("New", "OxyVolumeSeries")]
    [Alias("oxy.volume", "oxyvolume")]
    [OutputType(typeof(SeriesInfo<VolumeSeries>))]
    public class NewOxyVolumeSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 1, Mandatory = false)]
        public string XName = "X";

        [Parameter(Position = 2, Mandatory = false)]
        public string OpenName = "Open";

        [Parameter(Position = 3, Mandatory = false)]
        public string HighName = "High";

        [Parameter(Position = 4, Mandatory = false)]
        public string LowName = "Low";

        [Parameter(Position = 5, Mandatory = false)]
        public string CloseName = "Close";

        [Parameter(Position = 6, Mandatory = false)]
        public string BuyVolumeName = "BuyVolume";

        [Parameter(Position = 7, Mandatory = false)]
        public string SellVolumeName = "SellVolume";

        [Parameter(Position = 8, Mandatory = false)]
        public string GroupName = null;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] X;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Open;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] High;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Low;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Close;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] BuyVolume;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] SellVolume;

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
        public string Style = null;

        [Parameter(Position = 24, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 25, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 26, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 27, Mandatory = false)]
        public System.Collections.Generic.List<OxyPlot.Series.OhlcvItem> Items;

        [Parameter(Position = 28, Mandatory = false)]
        public OxyPlot.Series.VolumeStyle VolumeStyle;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeIntensity;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor PositiveColor;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor NegativeColor;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor InterceptColor;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double InterceptStrokeThickness;

        [Parameter(Position = 35, Mandatory = false)]
        public OxyPlot.LineStyle InterceptLineStyle;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool PositiveHollow;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool NegativeHollow;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BarWidth;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 41, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 44, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontSize;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 51, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 53, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 55, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 56, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 69, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 75, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 78, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 85, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 86, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 87, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 89, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 96, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 102, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 107, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 109, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 111, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 112, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 114, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 117, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 118, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 120, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 121, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 122, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 124, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 127, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 129, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 131, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 133, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 134, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 135, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 149, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 150, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 154, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 161, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 162, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 168, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 171, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 178, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 179, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 180, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 181, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 182, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 186, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 189, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 192, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 194, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 195, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 196, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 199, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 200, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 201, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 202, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 203, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 204, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 205, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 206, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 207, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 210, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 211, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 212, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 213, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 214, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 215, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 217, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 220, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 221, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 222, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 224, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 226, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 227, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 228, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AyPalette;

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
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 239, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 240, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AyBase;

        [Parameter(Position = 241, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AyPowerPadding;

        private Horker.OxyPlotCli.SeriesBuilders.VolumeSeriesBuilder _builder;

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
            _builder = new Horker.OxyPlotCli.SeriesBuilders.VolumeSeriesBuilder();
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = _builder.CreateSeriesInfo(style);

            foreach (var s in si.Series)
                AssignParameters(s, bp);

            PostProcess(AddTo, new[] { si }, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }

}
