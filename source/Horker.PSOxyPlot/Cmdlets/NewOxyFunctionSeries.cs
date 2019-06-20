
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
    [Alias("oxy.function", "oxy.func", "oxyfunc")]
    [OutputType(typeof(FunctionSeries))]
    public class NewOxyFunctionSeries : PSCmdlet
    {
        [Parameter(ParameterSetName = "Explicit", Position = 0, Mandatory = true)]
        public Horker.PSOxyPlot.TypeAdaptors.ScriptBlock[] F = null;

        [Parameter(ParameterSetName = "Explicit", Position = 1, Mandatory = false)]
        public double X0 = -1;

        [Parameter(ParameterSetName = "Explicit", Position = 2, Mandatory = false)]
        public double X1 = 1;

        [Parameter(ParameterSetName = "Implicit", Position = 0, Mandatory = true)]
        public Horker.PSOxyPlot.TypeAdaptors.ScriptBlock[] Fx = null;

        [Parameter(ParameterSetName = "Implicit", Position = 1, Mandatory = true)]
        public Horker.PSOxyPlot.TypeAdaptors.ScriptBlock[] Fy = null;

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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Dashes;

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
        public Horker.PSOxyPlot.TypeAdaptors.Double[] MarkerOutline;

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
        public Horker.PSOxyPlot.TypeAdaptors.InterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool CanTrackerInterpolatePoints;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool RenderInLegend;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 52, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 53, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxFormatAsFractions;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 72, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 75, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxIsZoomEnabled;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxPositionAtZeroCrossing;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxUseSuperExponentialFormat;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 128, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxIsTickCentered;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 146, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 147, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyFormatAsFractions;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 165, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 168, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 174, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyIsZoomEnabled;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyPositionAtZeroCrossing;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyUseSuperExponentialFormat;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 221, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyIsTickCentered;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyPowerPadding;

        private void AssignParameters(FunctionSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("Color")) series.Color = Color;
            if (bp.ContainsKey("BrokenLineColor")) series.BrokenLineColor = BrokenLineColor;
            if (bp.ContainsKey("BrokenLineStyle")) series.BrokenLineStyle = BrokenLineStyle;
            if (bp.ContainsKey("BrokenLineThickness")) series.BrokenLineThickness = BrokenLineThickness;
            if (bp.ContainsKey("Dashes")) series.Dashes = Horker.PSOxyPlot.TypeAdaptors.Double.ConvertArray(Dashes);
            if (bp.ContainsKey("Decimator")) series.Decimator = Decimator;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelMargin")) series.LabelMargin = LabelMargin;
            if (bp.ContainsKey("LineJoin")) series.LineJoin = LineJoin;
            if (bp.ContainsKey("LineStyle")) series.LineStyle = LineStyle;
            if (bp.ContainsKey("LineLegendPosition")) series.LineLegendPosition = LineLegendPosition;
            if (bp.ContainsKey("MarkerFill")) series.MarkerFill = MarkerFill;
            if (bp.ContainsKey("MarkerOutline")) series.MarkerOutline = Horker.PSOxyPlot.TypeAdaptors.ScreenPoint.ConvertArray(MarkerOutline);
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
            if (isExplicit)
            {
				foreach (var f in F)
				{
					var series = new FunctionSeries();
					series.Title = f.ToString();
                    AssignParameters(series, bp);
                    si.Series.Add(series);

                    f.SetParameterName("x");
					for (var i = X0; i <= X1 + Dx * .5; i += Dx)
					{
						var y = f.Invoke(i);
						series.Points.Add(new DataPoint(i, y));
					}
                }
            }
            else
            {
				for (var i = 0; i < Fx.Length; ++i)
				{
					var series = new FunctionSeries();
					series.Title = Fx[i].ToString() + ", " + Fy[i].ToString();
                    AssignParameters(series, bp);
                    si.Series.Add(series);

                    Fx[i].SetParameterName("t");
                    Fy[i].SetParameterName("t");
                    for (var j = T0; j <= T1 + Dx * .5; j += Dx)
                    {
                        var x = Fx[i].Invoke(j);
                        var y = Fy[i].Invoke(j);
                        series.Points.Add(new DataPoint(x, y));
                    }
                }
            }

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
