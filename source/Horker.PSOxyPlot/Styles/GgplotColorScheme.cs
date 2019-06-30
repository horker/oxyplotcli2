﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.Styles
{
    public class GgplotColorScheme : IColorScheme
    {
        public string Name => "ggplot";

        public OxyPalette GetColorAxisPalette(Axis axis)
        {
            return OxyPalette.Interpolate(64, R.HuePalette.GetPalette(64, 15, 15 + 315).ToArray());
        }

        public IList<OxyColor> GetDefaultColors(int count)
        {
            if (count == 1)
                return new OxyColor[] { OxyColors.Black };

            return R.HuePalette.GetPalette(count);
        }
    }
}
