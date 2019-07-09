﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using OxyPlot;
using OxyPlot.Series;
using Horker.OxyPlotCli.Initializers;
using Horker.OxyPlotCli.Styles;

namespace Horker.OxyPlotCli.Cmdlets
{
    [Cmdlet("New", "OxyFunctionSeries")]
    [Alias("oxy.function", "oxy.func", "oxyfunc")]
    [OutputType(typeof(FunctionSeries))]
    public class NewOxyFunctionSeries : SeriesCmdletBase
    {
        [Parameter(ParameterSetName = "Explicit", Position = 0, Mandatory = true)]
        public Horker.OxyPlotCli.TypeAdaptors.ScriptBlock[] F = null;

        [Parameter(ParameterSetName = "Explicit", Position = 1, Mandatory = false)]
        public double X0 = -1;

        [Parameter(ParameterSetName = "Explicit", Position = 2, Mandatory = false)]
        public double X1 = 1;

        [Parameter(ParameterSetName = "Implicit", Position = 0, Mandatory = true)]
        public Horker.OxyPlotCli.TypeAdaptors.ScriptBlock[] Fx = null;

        [Parameter(ParameterSetName = "Implicit", Position = 1, Mandatory = true)]
        public Horker.OxyPlotCli.TypeAdaptors.ScriptBlock[] Fy = null;

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

        [Parameter(Position = 12, Mandatory = false)]
        public string Style = null;

        [Parameter(Position = 13, Mandatory = false)]
        public SwitchParameter AsUIElement = false;

        [Parameter(Position = 14, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 15, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Color;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor BrokenLineColor;

        [Parameter(Position = 18, Mandatory = false)]
        public OxyPlot.LineStyle BrokenLineStyle;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double BrokenLineThickness;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Dashes;

        [Parameter(Position = 21, Mandatory = false)]
        public System.Action<System.Collections.Generic.List<OxyPlot.ScreenPoint>,System.Collections.Generic.List<OxyPlot.ScreenPoint>> Decimator;

        [Parameter(Position = 22, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LabelMargin;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.LineJoin LineJoin;

        [Parameter(Position = 25, Mandatory = false)]
        public OxyPlot.LineStyle LineStyle;

        [Parameter(Position = 26, Mandatory = false)]
        public OxyPlot.Series.LineLegendPosition LineLegendPosition;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerFill;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] MarkerOutline;

        [Parameter(Position = 29, Mandatory = false)]
        public System.Int32 MarkerResolution;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerSize;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor MarkerStroke;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MarkerStrokeThickness;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.MarkerType MarkerType;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double MinimumSegmentLength;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.InterpolationAlgorithm InterpolationAlgorithm;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double StrokeThickness;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool CanTrackerInterpolatePoints;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String DataFieldX;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String DataFieldY;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Func<System.Object,OxyPlot.DataPoint> Mapping;

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

        private void AssignParameters(FunctionSeries series, Dictionary<string, object> bp)
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
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var si = new SeriesInfo<FunctionSeries>();

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
                    style.ApplyStyleTo(series);

                    if (F.Length > 1)
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
                    style.ApplyStyleTo(series);

                    if (Fx.Length > 1)
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

            PostProcess(AddTo, si, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style, AsUIElement, Show, ReuseWindow);
        }
    }
}