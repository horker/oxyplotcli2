
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
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

        [Parameter(Position = 2, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 3, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 4, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 5, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 6, Mandatory = false)]
        public System.String DefaultFont;

        [Parameter(Position = 7, Mandatory = false)]
        public System.Double DefaultFontSize;

        [Parameter(Position = 8, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor Background;

        [Parameter(Position = 9, Mandatory = false)]
        public System.Globalization.CultureInfo Culture;

        [Parameter(Position = 10, Mandatory = false)]
        public System.Collections.Generic.IList<OxyPlot.OxyColor> DefaultColors;

        [Parameter(Position = 11, Mandatory = false)]
        public System.Boolean IsLegendVisible;

        [Parameter(Position = 12, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LegendBackground;

        [Parameter(Position = 13, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LegendBorder;

        [Parameter(Position = 14, Mandatory = false)]
        public System.Double LegendBorderThickness;

        [Parameter(Position = 15, Mandatory = false)]
        public System.Double LegendColumnSpacing;

        [Parameter(Position = 16, Mandatory = false)]
        public System.String LegendFont;

        [Parameter(Position = 17, Mandatory = false)]
        public System.Double LegendFontSize;

        [Parameter(Position = 18, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LegendTextColor;

        [Parameter(Position = 19, Mandatory = false)]
        public System.Double LegendFontWeight;

        [Parameter(Position = 20, Mandatory = false)]
        public OxyPlot.HorizontalAlignment LegendItemAlignment;

        [Parameter(Position = 21, Mandatory = false)]
        public OxyPlot.LegendItemOrder LegendItemOrder;

        [Parameter(Position = 22, Mandatory = false)]
        public System.Double LegendItemSpacing;

        [Parameter(Position = 23, Mandatory = false)]
        public System.Double LegendLineSpacing;

        [Parameter(Position = 24, Mandatory = false)]
        public System.Double LegendMargin;

        [Parameter(Position = 25, Mandatory = false)]
        public System.Double LegendMaxWidth;

        [Parameter(Position = 26, Mandatory = false)]
        public System.Double LegendMaxHeight;

        [Parameter(Position = 27, Mandatory = false)]
        public OxyPlot.LegendOrientation LegendOrientation;

        [Parameter(Position = 28, Mandatory = false)]
        public System.Double LegendPadding;

        [Parameter(Position = 29, Mandatory = false)]
        public OxyPlot.LegendPlacement LegendPlacement;

        [Parameter(Position = 30, Mandatory = false)]
        public OxyPlot.LegendPosition LegendPosition;

        [Parameter(Position = 31, Mandatory = false)]
        public System.Double LegendSymbolLength;

        [Parameter(Position = 32, Mandatory = false)]
        public System.Double LegendSymbolMargin;

        [Parameter(Position = 33, Mandatory = false)]
        public OxyPlot.LegendSymbolPlacement LegendSymbolPlacement;

        [Parameter(Position = 34, Mandatory = false)]
        public System.String LegendTitle;

        [Parameter(Position = 35, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor LegendTitleColor;

        [Parameter(Position = 36, Mandatory = false)]
        public System.String LegendTitleFont;

        [Parameter(Position = 37, Mandatory = false)]
        public System.Double LegendTitleFontSize;

        [Parameter(Position = 38, Mandatory = false)]
        public System.Double LegendTitleFontWeight;

        [Parameter(Position = 39, Mandatory = false)]
        public OxyPlot.OxyThickness Padding;

        [Parameter(Position = 40, Mandatory = false)]
        public System.Double AxisTierDistance;

        [Parameter(Position = 41, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor PlotAreaBackground;

        [Parameter(Position = 42, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor PlotAreaBorderColor;

        [Parameter(Position = 43, Mandatory = false)]
        public OxyPlot.OxyThickness PlotAreaBorderThickness;

        [Parameter(Position = 44, Mandatory = false)]
        public OxyPlot.OxyThickness PlotMargins;

        [Parameter(Position = 45, Mandatory = false)]
        public OxyPlot.PlotType PlotType;

        [Parameter(Position = 46, Mandatory = false)]
        public System.Func<OxyPlot.IRenderContext,OxyPlot.IRenderContext> RenderingDecorator;

        [Parameter(Position = 47, Mandatory = false)]
        public System.String Subtitle;

        [Parameter(Position = 48, Mandatory = false)]
        public System.String SubtitleFont;

        [Parameter(Position = 49, Mandatory = false)]
        public System.Double SubtitleFontSize;

        [Parameter(Position = 50, Mandatory = false)]
        public System.Double SubtitleFontWeight;

        [Parameter(Position = 51, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TextColor;

        [Parameter(Position = 52, Mandatory = false)]
        public System.String Title;

        [Parameter(Position = 53, Mandatory = false)]
        public System.String TitleToolTip;

        [Parameter(Position = 54, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor TitleColor;

        [Parameter(Position = 55, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor SubtitleColor;

        [Parameter(Position = 56, Mandatory = false)]
        public OxyPlot.TitleHorizontalAlignment TitleHorizontalAlignment;

        [Parameter(Position = 57, Mandatory = false)]
        public System.String TitleFont;

        [Parameter(Position = 58, Mandatory = false)]
        public System.Double TitleFontSize;

        [Parameter(Position = 59, Mandatory = false)]
        public System.Double TitleFontWeight;

        [Parameter(Position = 60, Mandatory = false)]
        public System.Double TitlePadding;

        [Parameter(Position = 61, Mandatory = false)]
        public Horker.PSOxyPlot.TypeAdaptors.OxyColor SelectionColor;

        private PlotModel _model;

        protected override void BeginProcessing()
        {
            _model = new PlotModel();

            if (Axis != null)
                foreach (var a in Axis)
                    _model.Axes.Add(a);
        }

        protected override void ProcessRecord()
        {
            if (Series != null)
                _model.Series.Add(Series);

            if (SeriesInfo != null)
            {
                AxisInitializer.WithSeriesInfo(_model, SeriesInfo);
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
            if (bp.ContainsKey("Padding")) _model.Padding = Padding;
            if (bp.ContainsKey("AxisTierDistance")) _model.AxisTierDistance = AxisTierDistance;
            if (bp.ContainsKey("PlotAreaBackground")) _model.PlotAreaBackground = PlotAreaBackground;
            if (bp.ContainsKey("PlotAreaBorderColor")) _model.PlotAreaBorderColor = PlotAreaBorderColor;
            if (bp.ContainsKey("PlotAreaBorderThickness")) _model.PlotAreaBorderThickness = PlotAreaBorderThickness;
            if (bp.ContainsKey("PlotMargins")) _model.PlotMargins = PlotMargins;
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
                ModelExporter.Export(_model, OutFile, OutWidth, OutHeight, SvgIsDocument);
            else
                WriteObject(_model);
        }
    }
}
