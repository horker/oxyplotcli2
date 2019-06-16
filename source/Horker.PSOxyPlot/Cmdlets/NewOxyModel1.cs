
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
using Horker.PSOxyPlot.ObjectFactories;

namespace Horker.PSOxyPlot
{
    [Cmdlet("New", "OxyPlotModel")]
    [Alias("oxy.model", "oxymodel")]
    [OutputType(typeof(PlotModel))]
    public class NewOxyPlotModel : PSCmdlet
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
        public System.String DefaultFont;

        [Parameter(Position = 10, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double DefaultFontSize;

        [Parameter(Position = 11, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 12, Mandatory = false)]
        public System.Globalization.CultureInfo Culture;

        [Parameter(Position = 13, Mandatory = false)]
        public System.Collections.Generic.IList<OxyPlot.OxyColor> DefaultColors;

        [Parameter(Position = 14, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool IsLegendVisible;

        [Parameter(Position = 15, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LegendBackground;

        [Parameter(Position = 16, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LegendBorder;

        [Parameter(Position = 17, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LegendBorderThickness;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LegendColumnSpacing;

        [Parameter(Position = 19, Mandatory = false)]
        public System.String LegendFont;

        [Parameter(Position = 20, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LegendFontSize;

        [Parameter(Position = 21, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LegendTextColor;

        [Parameter(Position = 22, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LegendFontWeight;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.HorizontalAlignment LegendItemAlignment;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.LegendItemOrder LegendItemOrder;

        [Parameter(Position = 25, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LegendItemSpacing;

        [Parameter(Position = 26, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LegendLineSpacing;

        [Parameter(Position = 27, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LegendMargin;

        [Parameter(Position = 28, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LegendMaxWidth;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LegendMaxHeight;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LegendOrientation LegendOrientation;

        [Parameter(Position = 31, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LegendPadding;

        [Parameter(Position = 32, Mandatory = false)]
        public OxyPlot.LegendPlacement LegendPlacement;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.LegendPosition LegendPosition;

        [Parameter(Position = 34, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LegendSymbolLength;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LegendSymbolMargin;

        [Parameter(Position = 36, Mandatory = false)]
        public OxyPlot.LegendSymbolPlacement LegendSymbolPlacement;

        [Parameter(Position = 37, Mandatory = false)]
        public System.String LegendTitle;

        [Parameter(Position = 38, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LegendTitleColor;

        [Parameter(Position = 39, Mandatory = false)]
        public System.String LegendTitleFont;

        [Parameter(Position = 40, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LegendTitleFontSize;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double LegendTitleFontWeight;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] Padding;

        [Parameter(Position = 43, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxisTierDistance;

        [Parameter(Position = 44, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor PlotAreaBackground;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor PlotAreaBorderColor;

        [Parameter(Position = 46, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] PlotAreaBorderThickness;

        [Parameter(Position = 47, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double[] PlotMargins;

        [Parameter(Position = 48, Mandatory = false)]
        public OxyPlot.PlotType PlotType;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Func<OxyPlot.IRenderContext,OxyPlot.IRenderContext> RenderingDecorator;

        [Parameter(Position = 50, Mandatory = false)]
        public System.String Subtitle;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String SubtitleFont;

        [Parameter(Position = 52, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double SubtitleFontSize;

        [Parameter(Position = 53, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double SubtitleFontWeight;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 55, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 56, Mandatory = false)]
        public System.String TitleToolTip;

        [Parameter(Position = 57, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 58, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor SubtitleColor;

        [Parameter(Position = 59, Mandatory = false)]
        public OxyPlot.TitleHorizontalAlignment TitleHorizontalAlignment;

        [Parameter(Position = 60, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontSize;

        [Parameter(Position = 62, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitleFontWeight;

        [Parameter(Position = 63, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double TitlePadding;

        [Parameter(Position = 64, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor SelectionColor;

        [Parameter(Position = 65, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxStartAngle;

        [Parameter(Position = 66, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxEndAngle;

        [Parameter(Position = 67, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxFormatAsFractions;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxClipTitle;

        [Parameter(Position = 80, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxCropGridlines;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxIsAxisVisible;

        [Parameter(Position = 91, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxIsPanEnabled;

        [Parameter(Position = 92, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxIsZoomEnabled;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxPositionAtZeroCrossing;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxUseSuperExponentialFormat;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxSelectable;

        [Parameter(Position = 139, Mandatory = false)]
        public OxyPlot.SelectionMode AxSelectionMode;

        [Parameter(Position = 140, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxGapWidth;

        [Parameter(Position = 141, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxIsTickCentered;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxRenderAsImage;

        [Parameter(Position = 155, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AxBase;

        [Parameter(Position = 156, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AxPowerPadding;

        [Parameter(Position = 157, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyStartAngle;

        [Parameter(Position = 158, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyEndAngle;

        [Parameter(Position = 159, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyFormatAsFractions;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyClipTitle;

        [Parameter(Position = 172, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyCropGridlines;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyIsAxisVisible;

        [Parameter(Position = 183, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyIsPanEnabled;

        [Parameter(Position = 184, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyIsZoomEnabled;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyPositionAtZeroCrossing;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyUseSuperExponentialFormat;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AySelectable;

        [Parameter(Position = 231, Mandatory = false)]
        public OxyPlot.SelectionMode AySelectionMode;

        [Parameter(Position = 232, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyGapWidth;

        [Parameter(Position = 233, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyIsTickCentered;

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
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyRenderAsImage;

        [Parameter(Position = 247, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Double AyBase;

        [Parameter(Position = 248, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.Bool AyPowerPadding;

        private PlotModel _model;

        protected override void BeginProcessing()
        {
            _model = new PlotModel();

            if (Axis != null)
                foreach (var a in Axis)
                    _model.Axes.Add(a);

            if (Annotation != null)
                foreach (var a in Annotation)
                    _model.Annotations.Add(a);
        }

        protected override void ProcessRecord()
        {
            if (Series != null)
                _model.Series.Add(Series);

            if (SeriesInfo != null)
            {
                AxisInitializer.WithSeriesInfo(_model, SeriesInfo);
                AxisInitializer.AssignParametersToModelAxes(_model, MyInvocation.BoundParameters);

                foreach (var s in SeriesInfo.Series)
                    _model.Series.Add(s);
            }
        }

        protected override void EndProcessing()
        {
            var bp = MyInvocation.BoundParameters;

            if (bp.ContainsKey("DefaultFont")) _model.DefaultFont = DefaultFont;
            if (bp.ContainsKey("DefaultFontSize")) _model.DefaultFontSize = DefaultFontSize;
            if (bp.ContainsKey("Background")) _model.Background = Background;
            if (bp.ContainsKey("Culture")) _model.Culture = Culture;
            if (bp.ContainsKey("DefaultColors")) _model.DefaultColors = DefaultColors;
            if (bp.ContainsKey("IsLegendVisible")) _model.IsLegendVisible = IsLegendVisible;
            if (bp.ContainsKey("LegendBackground")) _model.LegendBackground = LegendBackground;
            if (bp.ContainsKey("LegendBorder")) _model.LegendBorder = LegendBorder;
            if (bp.ContainsKey("LegendBorderThickness")) _model.LegendBorderThickness = LegendBorderThickness;
            if (bp.ContainsKey("LegendColumnSpacing")) _model.LegendColumnSpacing = LegendColumnSpacing;
            if (bp.ContainsKey("LegendFont")) _model.LegendFont = LegendFont;
            if (bp.ContainsKey("LegendFontSize")) _model.LegendFontSize = LegendFontSize;
            if (bp.ContainsKey("LegendTextColor")) _model.LegendTextColor = LegendTextColor;
            if (bp.ContainsKey("LegendFontWeight")) _model.LegendFontWeight = LegendFontWeight;
            if (bp.ContainsKey("LegendItemAlignment")) _model.LegendItemAlignment = LegendItemAlignment;
            if (bp.ContainsKey("LegendItemOrder")) _model.LegendItemOrder = LegendItemOrder;
            if (bp.ContainsKey("LegendItemSpacing")) _model.LegendItemSpacing = LegendItemSpacing;
            if (bp.ContainsKey("LegendLineSpacing")) _model.LegendLineSpacing = LegendLineSpacing;
            if (bp.ContainsKey("LegendMargin")) _model.LegendMargin = LegendMargin;
            if (bp.ContainsKey("LegendMaxWidth")) _model.LegendMaxWidth = LegendMaxWidth;
            if (bp.ContainsKey("LegendMaxHeight")) _model.LegendMaxHeight = LegendMaxHeight;
            if (bp.ContainsKey("LegendOrientation")) _model.LegendOrientation = LegendOrientation;
            if (bp.ContainsKey("LegendPadding")) _model.LegendPadding = LegendPadding;
            if (bp.ContainsKey("LegendPlacement")) _model.LegendPlacement = LegendPlacement;
            if (bp.ContainsKey("LegendPosition")) _model.LegendPosition = LegendPosition;
            if (bp.ContainsKey("LegendSymbolLength")) _model.LegendSymbolLength = LegendSymbolLength;
            if (bp.ContainsKey("LegendSymbolMargin")) _model.LegendSymbolMargin = LegendSymbolMargin;
            if (bp.ContainsKey("LegendSymbolPlacement")) _model.LegendSymbolPlacement = LegendSymbolPlacement;
            if (bp.ContainsKey("LegendTitle")) _model.LegendTitle = LegendTitle;
            if (bp.ContainsKey("LegendTitleColor")) _model.LegendTitleColor = LegendTitleColor;
            if (bp.ContainsKey("LegendTitleFont")) _model.LegendTitleFont = LegendTitleFont;
            if (bp.ContainsKey("LegendTitleFontSize")) _model.LegendTitleFontSize = LegendTitleFontSize;
            if (bp.ContainsKey("LegendTitleFontWeight")) _model.LegendTitleFontWeight = LegendTitleFontWeight;
            if (bp.ContainsKey("Padding")) _model.Padding = new Horker.PSOxyPlot.TypeAdaptors.OxyThickness(Padding);
            if (bp.ContainsKey("AxisTierDistance")) _model.AxisTierDistance = AxisTierDistance;
            if (bp.ContainsKey("PlotAreaBackground")) _model.PlotAreaBackground = PlotAreaBackground;
            if (bp.ContainsKey("PlotAreaBorderColor")) _model.PlotAreaBorderColor = PlotAreaBorderColor;
            if (bp.ContainsKey("PlotAreaBorderThickness")) _model.PlotAreaBorderThickness = new Horker.PSOxyPlot.TypeAdaptors.OxyThickness(PlotAreaBorderThickness);
            if (bp.ContainsKey("PlotMargins")) _model.PlotMargins = new Horker.PSOxyPlot.TypeAdaptors.OxyThickness(PlotMargins);
            if (bp.ContainsKey("PlotType")) _model.PlotType = PlotType;
            if (bp.ContainsKey("RenderingDecorator")) _model.RenderingDecorator = RenderingDecorator;
            if (bp.ContainsKey("Subtitle")) _model.Subtitle = Subtitle;
            if (bp.ContainsKey("SubtitleFont")) _model.SubtitleFont = SubtitleFont;
            if (bp.ContainsKey("SubtitleFontSize")) _model.SubtitleFontSize = SubtitleFontSize;
            if (bp.ContainsKey("SubtitleFontWeight")) _model.SubtitleFontWeight = SubtitleFontWeight;
            if (bp.ContainsKey("TextColor")) _model.TextColor = TextColor;
            if (bp.ContainsKey("Title")) _model.Title = Title;
            if (bp.ContainsKey("TitleToolTip")) _model.TitleToolTip = TitleToolTip;
            if (bp.ContainsKey("TitleColor")) _model.TitleColor = TitleColor;
            if (bp.ContainsKey("SubtitleColor")) _model.SubtitleColor = SubtitleColor;
            if (bp.ContainsKey("TitleHorizontalAlignment")) _model.TitleHorizontalAlignment = TitleHorizontalAlignment;
            if (bp.ContainsKey("TitleFont")) _model.TitleFont = TitleFont;
            if (bp.ContainsKey("TitleFontSize")) _model.TitleFontSize = TitleFontSize;
            if (bp.ContainsKey("TitleFontWeight")) _model.TitleFontWeight = TitleFontWeight;
            if (bp.ContainsKey("TitlePadding")) _model.TitlePadding = TitlePadding;
            if (bp.ContainsKey("SelectionColor")) _model.SelectionColor = SelectionColor;

            if (bp.ContainsKey("OutFile"))
            {
                ModelExporter.Export(_model, OutFile, OutWidth, OutHeight, SvgIsDocument);
                if (!PassThru)
                    return;
            }

            WriteObject(_model);
        }
    }
}
