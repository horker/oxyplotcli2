using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Axes;

namespace Horker.PSOxyPlot.Styles
{
    public class PaletteColorScheme : IColorScheme
    {
        public string Name { get; private set; }
        public IList<OxyColor> Colors { get; private set; }
        public int PaletteSize { get; private set; }

        public PaletteColorScheme(string name, IList<OxyColor> colors, int paletteSize)
        {
            Name = name;
            Colors = colors;
            PaletteSize = paletteSize;
        }

        public IList<OxyColor> GetDefaultColors(int count)
        {
            return OxyPalette.Interpolate(count, Colors.ToArray()).Colors;
        }

        public Tuple<OxyColor, OxyColor> GetCandleStickColors()
        {
            var colors = OxyPalette.Interpolate(2, Colors.ToArray()).Colors;
            return Tuple.Create(colors[0], colors[1]);
        }

        public OxyPalette GetColorAxisPalette(Axis axis)
        {
            return OxyPalette.Interpolate(PaletteSize, Colors.ToArray());
        }

        public Tuple<OxyColor, OxyColor> GetBoxPlotColors()
        {
            var colors = OxyPalette.Interpolate(2, Colors.ToArray()).Colors;
            return Tuple.Create(OxyColors.Black, colors[0]);
        }
    }
}
