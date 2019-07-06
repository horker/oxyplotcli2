
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using OxyPlot.Annotations;
using Horker.OxyPlotCli.Initializers;
using Horker.OxyPlotCli.Styles;

namespace Horker.OxyPlotCli.Cmdlets
{
    [Cmdlet("New", "OxyPlotModel")]
    [Alias("oxy.model", "oxymodel")]
    [OutputType(typeof(PlotModel))]
    public class NewOxyPlotModel : SeriesCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public Series Series = null;

        [Parameter(Position = 1, Mandatory = false, ValueFromPipeline = true)]
        public ISeriesInfo SeriesInfo = null;

        [Parameter(Position = 2, Mandatory = false)]
        public Axis[] Axis = null;

        [Parameter(Position = 3, Mandatory = false)]
        public Annotation[] Annotation = null;

        [Parameter(Position = 4, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 5, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 6, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 7, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 8, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 9, Mandatory = false)]
        public string Style = null;

        [Parameter(Position = 10, Mandatory = false)]
        public System.String DefaultFont;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double DefaultFontSize;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 13, Mandatory = false)]
        public System.Globalization.CultureInfo Culture;

        [Parameter(Position = 14, Mandatory = false)]
        public System.Collections.Generic.IList<OxyPlot.OxyColor> DefaultColors;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool IsLegendVisible;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor LegendBackground;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor LegendBorder;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LegendBorderThickness;

        [Parameter(Position = 19, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LegendColumnSpacing;

        [Parameter(Position = 20, Mandatory = false)]
        public System.String LegendFont;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LegendFontSize;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor LegendTextColor;

        [Parameter(Position = 23, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LegendFontWeight;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.HorizontalAlignment LegendItemAlignment;

        [Parameter(Position = 25, Mandatory = false)]
        public OxyPlot.LegendItemOrder LegendItemOrder;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LegendItemSpacing;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LegendLineSpacing;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LegendMargin;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LegendMaxWidth;

        [Parameter(Position = 30, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LegendMaxHeight;

        [Parameter(Position = 31, Mandatory = false)]
        public OxyPlot.LegendOrientation LegendOrientation;

        [Parameter(Position = 32, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LegendPadding;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.LegendPlacement LegendPlacement;

        [Parameter(Position = 34, Mandatory = false)]
        public OxyPlot.LegendPosition LegendPosition;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LegendSymbolLength;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LegendSymbolMargin;

        [Parameter(Position = 37, Mandatory = false)]
        public OxyPlot.LegendSymbolPlacement LegendSymbolPlacement;

        [Parameter(Position = 38, Mandatory = false)]
        public System.String LegendTitle;

        [Parameter(Position = 39, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor LegendTitleColor;

        [Parameter(Position = 40, Mandatory = false)]
        public System.String LegendTitleFont;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LegendTitleFontSize;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double LegendTitleFontWeight;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] Padding;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxisTierDistance;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor PlotAreaBackground;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor PlotAreaBorderColor;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] PlotAreaBorderThickness;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] PlotMargins;

        [Parameter(Position = 49, Mandatory = false)]
        public OxyPlot.PlotType PlotType;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Func<OxyPlot.IRenderContext,OxyPlot.IRenderContext> RenderingDecorator;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String Subtitle;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String SubtitleFont;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double SubtitleFontSize;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double SubtitleFontWeight;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 56, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String TitleToolTip;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 59, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor SubtitleColor;

        [Parameter(Position = 60, Mandatory = false)]
        public OxyPlot.TitleHorizontalAlignment TitleHorizontalAlignment;

        [Parameter(Position = 61, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double TitlePadding;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor SelectionColor;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 68, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxFormatAsFractions;

        [Parameter(Position = 69, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFractionUnit;

        [Parameter(Position = 70, Mandatory = false)]
        public System.String AxFractionUnitSymbol;

        [Parameter(Position = 71, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMaximum;

        [Parameter(Position = 72, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAbsoluteMinimum;

        [Parameter(Position = 73, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAngle;

        [Parameter(Position = 74, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTickToLabelDistance;

        [Parameter(Position = 75, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisTitleDistance;

        [Parameter(Position = 76, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxisDistance;

        [Parameter(Position = 77, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxAxislineColor;

        [Parameter(Position = 78, Mandatory = false)]
        public OxyPlot.LineStyle AxAxislineStyle;

        [Parameter(Position = 79, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxAxislineThickness;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 81, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxCropGridlines;

        [Parameter(Position = 82, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxEndPosition;

        [Parameter(Position = 83, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxExtraGridlineColor;

        [Parameter(Position = 84, Mandatory = false)]
        public OxyPlot.LineStyle AxExtraGridlineStyle;

        [Parameter(Position = 85, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxExtraGridlineThickness;

        [Parameter(Position = 86, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double[] AxExtraGridlines;

        [Parameter(Position = 87, Mandatory = false)]
        public System.Func<System.Double,System.Boolean> AxFilterFunction;

        [Parameter(Position = 88, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMaxValue;

        [Parameter(Position = 89, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFilterMinValue;

        [Parameter(Position = 90, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxIntervalLength;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 93, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsZoomEnabled;

        [Parameter(Position = 94, Mandatory = false)]
        public System.String AxKey;

        [Parameter(Position = 95, Mandatory = false)]
        public System.Func<System.Double,System.String> AxLabelFormatter;

        [Parameter(Position = 96, Mandatory = false)]
        public OxyPlot.Axes.AxisLayer AxLayer;

        [Parameter(Position = 97, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMajorGridlineColor;

        [Parameter(Position = 98, Mandatory = false)]
        public OxyPlot.LineStyle AxMajorGridlineStyle;

        [Parameter(Position = 99, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorGridlineThickness;

        [Parameter(Position = 100, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorStep;

        [Parameter(Position = 101, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMajorTickSize;

        [Parameter(Position = 102, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximum;

        [Parameter(Position = 103, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumPadding;

        [Parameter(Position = 104, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMaximumRange;

        [Parameter(Position = 105, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimum;

        [Parameter(Position = 106, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMajorStep;

        [Parameter(Position = 107, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumMinorStep;

        [Parameter(Position = 108, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumPadding;

        [Parameter(Position = 109, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinimumRange;

        [Parameter(Position = 110, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorGridlineColor;

        [Parameter(Position = 111, Mandatory = false)]
        public OxyPlot.LineStyle AxMinorGridlineStyle;

        [Parameter(Position = 112, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorGridlineThickness;

        [Parameter(Position = 113, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorStep;

        [Parameter(Position = 114, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxMinorTicklineColor;

        [Parameter(Position = 115, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxMinorTickSize;

        [Parameter(Position = 116, Mandatory = false)]
        public OxyPlot.Axes.AxisPosition AxPosition;

        [Parameter(Position = 117, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPositionAtZeroCrossing;

        [Parameter(Position = 118, Mandatory = false)]
        public System.Int32 AxPositionTier;

        [Parameter(Position = 119, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxStartPosition;

        [Parameter(Position = 120, Mandatory = false)]
        public System.String AxStringFormat;

        [Parameter(Position = 121, Mandatory = false)]
        public OxyPlot.Axes.TickStyle AxTickStyle;

        [Parameter(Position = 122, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTicklineColor;

        [Parameter(Position = 123, Mandatory = false)]
        public System.String AxTitle;

        [Parameter(Position = 124, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleClippingLength;

        [Parameter(Position = 125, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTitleColor;

        [Parameter(Position = 126, Mandatory = false)]
        public System.String AxTitleFont;

        [Parameter(Position = 127, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontSize;

        [Parameter(Position = 128, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitleFontWeight;

        [Parameter(Position = 129, Mandatory = false)]
        public System.String AxTitleFormatString;

        [Parameter(Position = 130, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxTitlePosition;

        [Parameter(Position = 131, Mandatory = false)]
        public System.String AxUnit;

        [Parameter(Position = 132, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxUseSuperExponentialFormat;

        [Parameter(Position = 133, Mandatory = false)]
        public System.String AxFont;

        [Parameter(Position = 134, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontSize;

        [Parameter(Position = 135, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxFontWeight;

        [Parameter(Position = 136, Mandatory = false)]
        public System.Object AxTag;

        [Parameter(Position = 137, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxTextColor;

        [Parameter(Position = 138, Mandatory = false)]
        public System.String AxToolTip;

        [Parameter(Position = 139, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 140, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 142, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxIsTickCentered;

        [Parameter(Position = 143, Mandatory = false)]
        public System.Collections.IEnumerable AxItemsSource;

        [Parameter(Position = 144, Mandatory = false)]
        public System.String AxLabelField;

        [Parameter(Position = 145, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidCategoryColor;

        [Parameter(Position = 146, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[] AxPalette;

        [Parameter(Position = 147, Mandatory = false)]
        public System.Globalization.CalendarWeekRule AxCalendarWeekRule;

        [Parameter(Position = 148, Mandatory = false)]
        public System.DayOfWeek AxFirstDayOfWeek;

        [Parameter(Position = 149, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxIntervalType;

        [Parameter(Position = 150, Mandatory = false)]
        public OxyPlot.Axes.DateTimeIntervalType AxMinorIntervalType;

        [Parameter(Position = 151, Mandatory = false)]
        public System.TimeZoneInfo AxTimeZone;

        [Parameter(Position = 152, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxInvalidNumberColor;

        [Parameter(Position = 153, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxHighColor;

        [Parameter(Position = 154, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.OxyColor AxLowColor;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Double AxBase;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.OxyPlotCli.TypeAdaptors.Bool AxPowerPadding;

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

        private List<Series> _seriesList;
        private List<ISeriesInfo> _seriesInfoList;

        protected override void BeginProcessing()
        {
            _seriesList = new List<Series>();
            _seriesInfoList = new List<ISeriesInfo>();
        }

        protected override void ProcessRecord()
        {
            if (Series != null)
                _seriesList.Add(Series);

            if (SeriesInfo != null)
                _seriesInfoList.Add(SeriesInfo);
        }

        protected override void EndProcessing()
        {
            var bp = MyInvocation.BoundParameters;
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var model = PlotModelInitializer.Create(_seriesInfoList, style);

            if (bp.ContainsKey("DefaultFont")) model.DefaultFont = DefaultFont;
            if (bp.ContainsKey("DefaultFontSize")) model.DefaultFontSize = DefaultFontSize;
            if (bp.ContainsKey("Background")) model.Background = Background;
            if (bp.ContainsKey("Culture")) model.Culture = Culture;
            if (bp.ContainsKey("DefaultColors")) model.DefaultColors = DefaultColors;
            if (bp.ContainsKey("IsLegendVisible")) model.IsLegendVisible = IsLegendVisible;
            if (bp.ContainsKey("LegendBackground")) model.LegendBackground = LegendBackground;
            if (bp.ContainsKey("LegendBorder")) model.LegendBorder = LegendBorder;
            if (bp.ContainsKey("LegendBorderThickness")) model.LegendBorderThickness = LegendBorderThickness;
            if (bp.ContainsKey("LegendColumnSpacing")) model.LegendColumnSpacing = LegendColumnSpacing;
            if (bp.ContainsKey("LegendFont")) model.LegendFont = LegendFont;
            if (bp.ContainsKey("LegendFontSize")) model.LegendFontSize = LegendFontSize;
            if (bp.ContainsKey("LegendTextColor")) model.LegendTextColor = LegendTextColor;
            if (bp.ContainsKey("LegendFontWeight")) model.LegendFontWeight = LegendFontWeight;
            if (bp.ContainsKey("LegendItemAlignment")) model.LegendItemAlignment = LegendItemAlignment;
            if (bp.ContainsKey("LegendItemOrder")) model.LegendItemOrder = LegendItemOrder;
            if (bp.ContainsKey("LegendItemSpacing")) model.LegendItemSpacing = LegendItemSpacing;
            if (bp.ContainsKey("LegendLineSpacing")) model.LegendLineSpacing = LegendLineSpacing;
            if (bp.ContainsKey("LegendMargin")) model.LegendMargin = LegendMargin;
            if (bp.ContainsKey("LegendMaxWidth")) model.LegendMaxWidth = LegendMaxWidth;
            if (bp.ContainsKey("LegendMaxHeight")) model.LegendMaxHeight = LegendMaxHeight;
            if (bp.ContainsKey("LegendOrientation")) model.LegendOrientation = LegendOrientation;
            if (bp.ContainsKey("LegendPadding")) model.LegendPadding = LegendPadding;
            if (bp.ContainsKey("LegendPlacement")) model.LegendPlacement = LegendPlacement;
            if (bp.ContainsKey("LegendPosition")) model.LegendPosition = LegendPosition;
            if (bp.ContainsKey("LegendSymbolLength")) model.LegendSymbolLength = LegendSymbolLength;
            if (bp.ContainsKey("LegendSymbolMargin")) model.LegendSymbolMargin = LegendSymbolMargin;
            if (bp.ContainsKey("LegendSymbolPlacement")) model.LegendSymbolPlacement = LegendSymbolPlacement;
            if (bp.ContainsKey("LegendTitle")) model.LegendTitle = LegendTitle;
            if (bp.ContainsKey("LegendTitleColor")) model.LegendTitleColor = LegendTitleColor;
            if (bp.ContainsKey("LegendTitleFont")) model.LegendTitleFont = LegendTitleFont;
            if (bp.ContainsKey("LegendTitleFontSize")) model.LegendTitleFontSize = LegendTitleFontSize;
            if (bp.ContainsKey("LegendTitleFontWeight")) model.LegendTitleFontWeight = LegendTitleFontWeight;
            if (bp.ContainsKey("Padding")) model.Padding = new Horker.OxyPlotCli.TypeAdaptors.OxyThickness(Padding);
            if (bp.ContainsKey("AxisTierDistance")) model.AxisTierDistance = AxisTierDistance;
            if (bp.ContainsKey("PlotAreaBackground")) model.PlotAreaBackground = PlotAreaBackground;
            if (bp.ContainsKey("PlotAreaBorderColor")) model.PlotAreaBorderColor = PlotAreaBorderColor;
            if (bp.ContainsKey("PlotAreaBorderThickness")) model.PlotAreaBorderThickness = new Horker.OxyPlotCli.TypeAdaptors.OxyThickness(PlotAreaBorderThickness);
            if (bp.ContainsKey("PlotMargins")) model.PlotMargins = new Horker.OxyPlotCli.TypeAdaptors.OxyThickness(PlotMargins);
            if (bp.ContainsKey("PlotType")) model.PlotType = PlotType;
            if (bp.ContainsKey("RenderingDecorator")) model.RenderingDecorator = RenderingDecorator;
            if (bp.ContainsKey("Subtitle")) model.Subtitle = Subtitle;
            if (bp.ContainsKey("SubtitleFont")) model.SubtitleFont = SubtitleFont;
            if (bp.ContainsKey("SubtitleFontSize")) model.SubtitleFontSize = SubtitleFontSize;
            if (bp.ContainsKey("SubtitleFontWeight")) model.SubtitleFontWeight = SubtitleFontWeight;
            if (bp.ContainsKey("TextColor")) model.TextColor = TextColor;
            if (bp.ContainsKey("Title")) model.Title = Title;
            if (bp.ContainsKey("TitleToolTip")) model.TitleToolTip = TitleToolTip;
            if (bp.ContainsKey("TitleColor")) model.TitleColor = TitleColor;
            if (bp.ContainsKey("SubtitleColor")) model.SubtitleColor = SubtitleColor;
            if (bp.ContainsKey("TitleHorizontalAlignment")) model.TitleHorizontalAlignment = TitleHorizontalAlignment;
            if (bp.ContainsKey("TitleFont")) model.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) model.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) model.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitlePadding")) model.TitlePadding = TitlePadding;
            if (bp.ContainsKey("SelectionColor")) model.SelectionColor = SelectionColor;

            if (Axis != null)
            {
                foreach (var a in Axis)
                    model.Axes.Add(a);
            }

            if (Annotation != null)
            {
                foreach (var a in Annotation)
                    model.Annotations.Add(a);
            }

            var si = _seriesInfoList.Count > 0 ? _seriesInfoList[0] : null;

            PostProcess(model, si, OutFile, OutWidth, OutHeight, SvgIsDocument, PassThru, style);
        }
    }
}
