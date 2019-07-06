using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;

namespace Horker.OxyPlotCli.R
{
    // Source:
    // https://github.com/hadley/scales/blob/master/R/pal-hue.r
    //
    // Equivalent to in R:
    // library("scale")
    // hue_pal()(4)

    public static class HuePalette
    {
        public static IList<OxyColor> GetPalette(
            int n,
            double hFrom = 15,
            double hTo = 360 + 15,
            double C = 100,
            double l = 65,
            double hStart = 0.0,
            int direction = 1
        )
        {
            if ((hTo - hFrom) % 360 < 1.0) {
                hTo -= 360.0 / n;
            }

            var result = new List<OxyColor>();

            for (var i = 0; i < n; ++i)
            {
                var h0 = hFrom + (hTo - hFrom) / (n - 1) * i * direction;
                var h = (h0 + hStart) % 360;
                var rgb = ColorConverter.ConvertHclToRgb(h, C, l);
                rgb.Fixup();
                result.Add(OxyColor.FromRgb(
                    (byte)(rgb.R * 255 + .5),
                    (byte)(rgb.G * 255 + .5),
                    (byte)(rgb.B * 255 + .5)
                ));
            }

            return result;
        }
    }
}
