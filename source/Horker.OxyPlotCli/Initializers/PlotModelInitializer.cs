using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horker.OxyPlotCli.Styles;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.OxyPlotCli.Initializers
{
    public class PlotModelInitializer
    {
        public static PlotModel Create(IList<ISeriesInfo> siList, Style style)
        {
            var model = new PlotModel();
            var defaultColorsSave = model.DefaultColors;
            var defaultFontSave = model.DefaultFont;

            style.ApplyStyleTo(model);

            if (ReferenceEquals(model.DefaultFont, defaultFontSave))
                model.DefaultFont = style.DefaultFont;

            var updated = false;

            model.Updating += (object sender, EventArgs e) =>
            {
                if (updated)
                    return;

                updated = true;

                style.ApplyEventHook(model, EventType.BeforeAxesFixup);

                if (siList == null)
                    AxisInitializer.EnsureAxes((PlotModel)sender, null, style);
                else
                {
                    foreach (var si in siList)
                        AxisInitializer.EnsureAxes((PlotModel)sender, si, style);
                }

                if (style.ColorScheme != null && ReferenceEquals(model.DefaultColors, defaultColorsSave))
                    style.ApplyColorScheme(model);

                style.ApplyEventHook(model, EventType.BeforeRendering);
            };

            return model;
        }
    }
}
