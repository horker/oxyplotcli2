﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horker.PSOxyPlot.Styles;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.Initializers
{
    public class PlotModelInitializer
    {
        public static PlotModel Create(IList<ISeriesInfo> siList, Style style)
        {
            var model = new PlotModel();
            var defaultColorsSave = model.DefaultColors;

            style.ApplyStyleTo(model);

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
