﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using OxyPlot;
using OxyPlot.Series;
using Horker.PSOxyPlot.Initializers;
using Horker.PSOxyPlot.Styles;

namespace Horker.PSOxyPlot.Cmdlets
{
    [Cmdlet("New", "OxyHeatMapSeries")]
    [Alias("oxy.heatMap", "oxy.heat", "oxyheat")]
    [OutputType(typeof(HeatMapSeries))]
    public class NewOxyHeatMapSeries : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false)]
        public PlotModel AddTo = null;

        [Parameter(Position = 1, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 2, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 3, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 4, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 5, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 6, Mandatory = false)]
        public string Style = null;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double X0;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double X1;

        [Parameter(Position = 9, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Y0;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double Y1;

        [Parameter(Position = 11, Mandatory = false)]
        public System.Object Data;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Interpolate;

        [Parameter(Position = 13, Mandatory = false)]
        public System.String ColorAxisKey;

        [Parameter(Position = 14, Mandatory = false)]
        public OxyPlot.Series.HeatMapCoordinateDefinition CoordinateDefinition;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.Series.HeatMapRenderMethod RenderMethod;

        [Parameter(Position = 16, Mandatory = false)]
        public System.String LabelFormatString;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LabelFontSize;

        [Parameter(Position = 18, Mandatory = false)]
        public System.String XAxisKey;

        [Parameter(Position = 19, Mandatory = false)]
        public System.String YAxisKey;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Collections.IEnumerable ItemsSource;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsVisible;

        [Parameter(Position = 23, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 24, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool RenderInLegend;

        [Parameter(Position = 25, Mandatory = false)]
        public System.String TrackerFormatString;

        [Parameter(Position = 26, Mandatory = false)]
        public System.String TrackerKey;

        [Parameter(Position = 27, Mandatory = false)]
        public System.String Font;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontSize;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double FontWeight;

        [Parameter(Position = 30, Mandatory = false)]
        public System.Object Tag;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 32, Mandatory = false)]
        public System.String ToolTip;

        [Parameter(Position = 33, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool Selectable;

        [Parameter(Position = 34, Mandatory = false)]
        public OxyPlot.SelectionMode SelectionMode;

        [Parameter(Position = 35, Mandatory = false)]
        public string AxType;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 37, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 50, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 54, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 56, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 57, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 60, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 64, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 65, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 66, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 68, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 70, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 78, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 81, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 84, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 86, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 87, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 88, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 90, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 91, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 93, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 94, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 95, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 96, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 98, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 99, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 101, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 103, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 106, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 108, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 110, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 111, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 113, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 114, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 116, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyPaletteItem[] AxPalette;

        [Parameter(Position = 117, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 118, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 119, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 120, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 121, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 123, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 126, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 128, Mandatory = false)]
        public string AyType;

        [Parameter(Position = 129, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 131, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyFormatAsFractions;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFractionUnit;

        [Parameter(Position = 133, Mandatory = false)]
        public System.String AyFractionUnitSymbol;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMaximum;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAbsoluteMinimum;

        [Parameter(Position = 136, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAngle;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTickToLabelDistance;

        [Parameter(Position = 138, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisTitleDistance;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxisDistance;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyAxislineColor;

        [Parameter(Position = 141, Mandatory = false)]
        public OxyPlot.LineStyle AyAxislineStyle;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyAxislineThickness;

        [Parameter(Position = 143, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 144, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyCropGridlines;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndPosition;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyExtraGridlineColor;

        [Parameter(Position = 147, Mandatory = false)]
        public OxyPlot.LineStyle AyExtraGridlineStyle;

        [Parameter(Position = 148, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyExtraGridlineThickness;

        [Parameter(Position = 149, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] AyExtraGridlines;

        [Parameter(Position = 150, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AyFilterFunction;

        [Parameter(Position = 151, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMaxValue;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFilterMinValue;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyIntervalLength;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyIsZoomEnabled;

        [Parameter(Position = 157, Mandatory = false)]
        public System.String AyKey;

        [Parameter(Position = 158, Mandatory = false)]
        public System.Func<System.Double,System.String> AyLabelFormatter;

        [Parameter(Position = 159, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AyLayer;

        [Parameter(Position = 160, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMajorGridlineColor;

        [Parameter(Position = 161, Mandatory = false)]
        public OxyPlot.LineStyle AyMajorGridlineStyle;

        [Parameter(Position = 162, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorGridlineThickness;

        [Parameter(Position = 163, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorStep;

        [Parameter(Position = 164, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMajorTickSize;

        [Parameter(Position = 165, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximum;

        [Parameter(Position = 166, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumPadding;

        [Parameter(Position = 167, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMaximumRange;

        [Parameter(Position = 168, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimum;

        [Parameter(Position = 169, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMajorStep;

        [Parameter(Position = 170, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumMinorStep;

        [Parameter(Position = 171, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumPadding;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinimumRange;

        [Parameter(Position = 173, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorGridlineColor;

        [Parameter(Position = 174, Mandatory = false)]
        public OxyPlot.LineStyle AyMinorGridlineStyle;

        [Parameter(Position = 175, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorGridlineThickness;

        [Parameter(Position = 176, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorStep;

        [Parameter(Position = 177, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyMinorTicklineColor;

        [Parameter(Position = 178, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyMinorTickSize;

        [Parameter(Position = 179, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AyPosition;

        [Parameter(Position = 180, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyPositionAtZeroCrossing;

        [Parameter(Position = 181, Mandatory = false)]
        public System.Int32 AyPositionTier;

        [Parameter(Position = 182, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartPosition;

        [Parameter(Position = 183, Mandatory = false)]
        public System.String AyStringFormat;

        [Parameter(Position = 184, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AyTickStyle;

        [Parameter(Position = 185, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTicklineColor;

        [Parameter(Position = 186, Mandatory = false)]
        public System.String AyTitle;

        [Parameter(Position = 187, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleClippingLength;

        [Parameter(Position = 188, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTitleColor;

        [Parameter(Position = 189, Mandatory = false)]
        public System.String AyTitleFont;

        [Parameter(Position = 190, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontSize;

        [Parameter(Position = 191, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitleFontWeight;

        [Parameter(Position = 192, Mandatory = false)]
        public System.String AyTitleFormatString;

        [Parameter(Position = 193, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyTitlePosition;

        [Parameter(Position = 194, Mandatory = false)]
        public System.String AyUnit;

        [Parameter(Position = 195, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyUseSuperExponentialFormat;

        [Parameter(Position = 196, Mandatory = false)]
        public System.String AyFont;

        [Parameter(Position = 197, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontSize;

        [Parameter(Position = 198, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyFontWeight;

        [Parameter(Position = 199, Mandatory = false)]
        public System.Object AyTag;

        [Parameter(Position = 200, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyTextColor;

        [Parameter(Position = 201, Mandatory = false)]
        public System.String AyToolTip;

        [Parameter(Position = 202, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 203, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 204, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 205, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyIsTickCentered;

        [Parameter(Position = 206, Mandatory = false)]
        public System.Collections.IEnumerable AyItemsSource;

        [Parameter(Position = 207, Mandatory = false)]
        public System.String AyLabelField;

        [Parameter(Position = 208, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidCategoryColor;

        [Parameter(Position = 209, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyPaletteItem[] AyPalette;

        [Parameter(Position = 210, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AyCalendarWeekRule;

        [Parameter(Position = 211, Mandatory = false)]
        public System.DayOfWeek AyFirstDayOfWeek;

        [Parameter(Position = 212, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyIntervalType;

        [Parameter(Position = 213, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AyMinorIntervalType;

        [Parameter(Position = 214, Mandatory = false)]
        public System.TimeZoneInfo AyTimeZone;

        [Parameter(Position = 215, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyInvalidNumberColor;

        [Parameter(Position = 216, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyHighColor;

        [Parameter(Position = 217, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AyLowColor;

        [Parameter(Position = 218, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 219, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 220, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyPowerPadding;

        [Parameter(Position = 221, Mandatory = false)]
        public string AzType;

        [Parameter(Position = 222, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzStartAngle;

        [Parameter(Position = 223, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzEndAngle;

        [Parameter(Position = 224, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AzFormatAsFractions;

        [Parameter(Position = 225, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzFractionUnit;

        [Parameter(Position = 226, Mandatory = false)]
        public System.String AzFractionUnitSymbol;

        [Parameter(Position = 227, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzAbsoluteMaximum;

        [Parameter(Position = 228, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzAbsoluteMinimum;

        [Parameter(Position = 229, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzAngle;

        [Parameter(Position = 230, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzAxisTickToLabelDistance;

        [Parameter(Position = 231, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzAxisTitleDistance;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzAxisDistance;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AzAxislineColor;

        [Parameter(Position = 234, Mandatory = false)]
        public OxyPlot.LineStyle AzAxislineStyle;

        [Parameter(Position = 235, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzAxislineThickness;

        [Parameter(Position = 236, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AzClipTitle;

        [Parameter(Position = 237, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AzCropGridlines;

        [Parameter(Position = 238, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzEndPosition;

        [Parameter(Position = 239, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AzExtraGridlineColor;

        [Parameter(Position = 240, Mandatory = false)]
        public OxyPlot.LineStyle AzExtraGridlineStyle;

        [Parameter(Position = 241, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzExtraGridlineThickness;

        [Parameter(Position = 242, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] AzExtraGridlines;

        [Parameter(Position = 243, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AzFilterFunction;

        [Parameter(Position = 244, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzFilterMaxValue;

        [Parameter(Position = 245, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzFilterMinValue;

        [Parameter(Position = 246, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzIntervalLength;

        [Parameter(Position = 247, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AzIsAxisVisible;

        [Parameter(Position = 248, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AzIsPanEnabled;

        [Parameter(Position = 249, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AzIsZoomEnabled;

        [Parameter(Position = 250, Mandatory = false)]
        public System.String AzKey;

        [Parameter(Position = 251, Mandatory = false)]
        public System.Func<System.Double,System.String> AzLabelFormatter;

        [Parameter(Position = 252, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AzLayer;

        [Parameter(Position = 253, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AzMajorGridlineColor;

        [Parameter(Position = 254, Mandatory = false)]
        public OxyPlot.LineStyle AzMajorGridlineStyle;

        [Parameter(Position = 255, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzMajorGridlineThickness;

        [Parameter(Position = 256, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzMajorStep;

        [Parameter(Position = 257, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzMajorTickSize;

        [Parameter(Position = 258, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzMaximum;

        [Parameter(Position = 259, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzMaximumPadding;

        [Parameter(Position = 260, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzMaximumRange;

        [Parameter(Position = 261, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzMinimum;

        [Parameter(Position = 262, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzMinimumMajorStep;

        [Parameter(Position = 263, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzMinimumMinorStep;

        [Parameter(Position = 264, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzMinimumPadding;

        [Parameter(Position = 265, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzMinimumRange;

        [Parameter(Position = 266, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AzMinorGridlineColor;

        [Parameter(Position = 267, Mandatory = false)]
        public OxyPlot.LineStyle AzMinorGridlineStyle;

        [Parameter(Position = 268, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzMinorGridlineThickness;

        [Parameter(Position = 269, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzMinorStep;

        [Parameter(Position = 270, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AzMinorTicklineColor;

        [Parameter(Position = 271, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzMinorTickSize;

        [Parameter(Position = 272, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AzPosition;

        [Parameter(Position = 273, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AzPositionAtZeroCrossing;

        [Parameter(Position = 274, Mandatory = false)]
        public System.Int32 AzPositionTier;

        [Parameter(Position = 275, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzStartPosition;

        [Parameter(Position = 276, Mandatory = false)]
        public System.String AzStringFormat;

        [Parameter(Position = 277, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AzTickStyle;

        [Parameter(Position = 278, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AzTicklineColor;

        [Parameter(Position = 279, Mandatory = false)]
        public System.String AzTitle;

        [Parameter(Position = 280, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzTitleClippingLength;

        [Parameter(Position = 281, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AzTitleColor;

        [Parameter(Position = 282, Mandatory = false)]
        public System.String AzTitleFont;

        [Parameter(Position = 283, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzTitleFontSize;

        [Parameter(Position = 284, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzTitleFontWeight;

        [Parameter(Position = 285, Mandatory = false)]
        public System.String AzTitleFormatString;

        [Parameter(Position = 286, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzTitlePosition;

        [Parameter(Position = 287, Mandatory = false)]
        public System.String AzUnit;

        [Parameter(Position = 288, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AzUseSuperExponentialFormat;

        [Parameter(Position = 289, Mandatory = false)]
        public System.String AzFont;

        [Parameter(Position = 290, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzFontSize;

        [Parameter(Position = 291, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzFontWeight;

        [Parameter(Position = 292, Mandatory = false)]
        public System.Object AzTag;

        [Parameter(Position = 293, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AzTextColor;

        [Parameter(Position = 294, Mandatory = false)]
        public System.String AzToolTip;

        [Parameter(Position = 295, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AzSelectable;

        [Parameter(Position = 296, Mandatory = false)]
        public OxyPlot.SelectionMode AzSelectionMode;

        [Parameter(Position = 297, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzGapWidth;

        [Parameter(Position = 298, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AzIsTickCentered;

        [Parameter(Position = 299, Mandatory = false)]
        public System.Collections.IEnumerable AzItemsSource;

        [Parameter(Position = 300, Mandatory = false)]
        public System.String AzLabelField;

        [Parameter(Position = 301, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AzInvalidCategoryColor;

        [Parameter(Position = 302, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyPaletteItem[] AzPalette;

        [Parameter(Position = 303, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AzCalendarWeekRule;

        [Parameter(Position = 304, Mandatory = false)]
        public System.DayOfWeek AzFirstDayOfWeek;

        [Parameter(Position = 305, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AzIntervalType;

        [Parameter(Position = 306, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AzMinorIntervalType;

        [Parameter(Position = 307, Mandatory = false)]
        public System.TimeZoneInfo AzTimeZone;

        [Parameter(Position = 308, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AzInvalidNumberColor;

        [Parameter(Position = 309, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AzHighColor;

        [Parameter(Position = 310, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor AzLowColor;

        [Parameter(Position = 311, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AzRenderAsImage;

        [Parameter(Position = 312, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AzBase;

        [Parameter(Position = 313, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AzPowerPadding;

        private void AssignParameters(HeatMapSeries series, Dictionary<string, object> bp)
        {
            if (bp.ContainsKey("X0")) series.X0 = X0;
            if (bp.ContainsKey("X1")) series.X1 = X1;
            if (bp.ContainsKey("Y0")) series.Y0 = Y0;
            if (bp.ContainsKey("Y1")) series.Y1 = Y1;
            if (bp.ContainsKey("Data")) series.Data = Horker.PSOxyPlot.TypeAdaptors.TwoDimensionalArray.ConvertFrom(Data);
            if (bp.ContainsKey("Interpolate")) series.Interpolate = Interpolate;
            if (bp.ContainsKey("ColorAxisKey")) series.ColorAxisKey = ColorAxisKey;
            if (bp.ContainsKey("CoordinateDefinition")) series.CoordinateDefinition = CoordinateDefinition;
            if (bp.ContainsKey("RenderMethod")) series.RenderMethod = RenderMethod;
            if (bp.ContainsKey("LabelFormatString")) series.LabelFormatString = LabelFormatString;
            if (bp.ContainsKey("LabelFontSize")) series.LabelFontSize = LabelFontSize;
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

            var si = new SeriesInfo<HeatMapSeries>();
            var series = new HeatMapSeries();
            style.ApplyStyleTo(series);

            AssignParameters(series, bp);

            si.Series = new [] { series };

            if (!bp.ContainsKey("X0") && !bp.ContainsKey("X1"))
            {
                series.X0 = 0.0;
                series.X1 = 1.0;
            }

            if (!bp.ContainsKey("Y0") && !bp.ContainsKey("Y1"))
            {
                series.Y0 = 1.0;
                series.Y1 = 0.0;
            }

            PostProcess(AddTo, si, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style);
        }
    }
}