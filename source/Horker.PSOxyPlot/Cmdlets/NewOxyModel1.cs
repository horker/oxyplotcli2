
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
    [Cmdlet("New", "OxyModel")]
    [Alias("oxy.model")]
    [OutputType(typeof(PlotModel))]
    public class NewOxyModel : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public Series[] Series = new Series[0];

        [Parameter(Position = 0, Mandatory = false)]
        public System.String DefaultFont;

        [Parameter(Position = 1, Mandatory = false)]
        public System.Double DefaultFontSize;

        [Parameter(Position = 2, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 3, Mandatory = false)]
        public System.Globalization.CultureInfo Culture;

        [Parameter(Position = 4, Mandatory = false)]
        public System.Collections.Generic.IList<OxyPlot.OxyColor> DefaultColors;

        [Parameter(Position = 5, Mandatory = false)]
        public System.Boolean IsLegendVisible;

        [Parameter(Position = 6, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LegendBackground;

        [Parameter(Position = 7, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LegendBorder;

        [Parameter(Position = 8, Mandatory = false)]
        public System.Double LegendBorderThickness;

        [Parameter(Position = 9, Mandatory = false)]
        public System.Double LegendColumnSpacing;

        [Parameter(Position = 10, Mandatory = false)]
        public System.String LegendFont;

        [Parameter(Position = 11, Mandatory = false)]
        public System.Double LegendFontSize;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LegendTextColor;

        [Parameter(Position = 13, Mandatory = false)]
        public System.Double LegendFontWeight;

        [Parameter(Position = 14, Mandatory = false)]
        public OxyPlot.HorizontalAlignment LegendItemAlignment;

        [Parameter(Position = 15, Mandatory = false)]
        public OxyPlot.LegendItemOrder LegendItemOrder;

        [Parameter(Position = 16, Mandatory = false)]
        public System.Double LegendItemSpacing;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Double LegendLineSpacing;

        [Parameter(Position = 18, Mandatory = false)]
        public System.Double LegendMargin;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Double LegendMaxWidth;

        [Parameter(Position = 20, Mandatory = false)]
        public System.Double LegendMaxHeight;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.LegendOrientation LegendOrientation;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Double LegendPadding;

        [Parameter(Position = 23, Mandatory = false)]
        public OxyPlot.LegendPlacement LegendPlacement;

        [Parameter(Position = 24, Mandatory = false)]
        public OxyPlot.LegendPosition LegendPosition;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Double LegendSymbolLength;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Double LegendSymbolMargin;

        [Parameter(Position = 27, Mandatory = false)]
        public OxyPlot.LegendSymbolPlacement LegendSymbolPlacement;

        [Parameter(Position = 28, Mandatory = false)]
        public System.String LegendTitle;

        [Parameter(Position = 29, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LegendTitleColor;

        [Parameter(Position = 30, Mandatory = false)]
        public System.String LegendTitleFont;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Double LegendTitleFontSize;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Double LegendTitleFontWeight;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.OxyThickness Padding;

        [Parameter(Position = 34, Mandatory = false)]
        public System.Double AxisTierDistance;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor PlotAreaBackground;

        [Parameter(Position = 36, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor PlotAreaBorderColor;

        [Parameter(Position = 37, Mandatory = false)]
        public OxyPlot.OxyThickness PlotAreaBorderThickness;

        [Parameter(Position = 38, Mandatory = false)]
        public OxyPlot.OxyThickness PlotMargins;

        [Parameter(Position = 39, Mandatory = false)]
        public OxyPlot.PlotType PlotType;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Func<OxyPlot.IRenderContext,OxyPlot.IRenderContext> RenderingDecorator;

        [Parameter(Position = 41, Mandatory = false)]
        public System.String Subtitle;

        [Parameter(Position = 42, Mandatory = false)]
        public System.String SubtitleFont;

        [Parameter(Position = 43, Mandatory = false)]
        public System.Double SubtitleFontSize;

        [Parameter(Position = 44, Mandatory = false)]
        public System.Double SubtitleFontWeight;

        [Parameter(Position = 45, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 46, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String TitleToolTip;

        [Parameter(Position = 48, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 49, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor SubtitleColor;

        [Parameter(Position = 50, Mandatory = false)]
        public OxyPlot.TitleHorizontalAlignment TitleHorizontalAlignment;

        [Parameter(Position = 51, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 52, Mandatory = false)]
        public System.Double TitleFontSize;

        [Parameter(Position = 53, Mandatory = false)]
        public System.Double TitleFontWeight;

        [Parameter(Position = 54, Mandatory = false)]
        public System.Double TitlePadding;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor SelectionColor;

        protected override void BeginProcessing()
        {
			var bp = MyInvocation.BoundParameters;
            var model = new PlotModel();

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
            if (bp.ContainsKey("Padding")) model.Padding = Padding;
            if (bp.ContainsKey("AxisTierDistance")) model.AxisTierDistance = AxisTierDistance;
            if (bp.ContainsKey("PlotAreaBackground")) model.PlotAreaBackground = PlotAreaBackground;
            if (bp.ContainsKey("PlotAreaBorderColor")) model.PlotAreaBorderColor = PlotAreaBorderColor;
            if (bp.ContainsKey("PlotAreaBorderThickness")) model.PlotAreaBorderThickness = PlotAreaBorderThickness;
            if (bp.ContainsKey("PlotMargins")) model.PlotMargins = PlotMargins;
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

            foreach (var s in Series)
                model.Series.Add(s);

            WriteObject(model);
        }
    }
}
