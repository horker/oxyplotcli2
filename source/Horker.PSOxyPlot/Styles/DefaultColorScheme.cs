using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Axes;

namespace Horker.OxyPlotCli.Styles
{
    public class VanillaColorScheme : IColorScheme
    {
        public string Name => "vanilla";

        // PlotModel's default colors are hard-written in its constructor.
        public IList<OxyColor> DefaultColors { get; } = (new PlotModel()).DefaultColors;

        // LinearColorAxis's default palette is hard-written in its constructor.
        public OxyPalette DefaultPalette { get; } = (new LinearColorAxis()).Palette;

        public OxyPalette GetColorAxisPalette(Axis axis)
        {
            return DefaultPalette;
        }

        public IList<OxyColor> GetDefaultColors(int count)
        {
            return DefaultColors;
        }

        public Tuple<OxyColor, OxyColor> GetCandleStickColors()
        {
            return Tuple.Create(DefaultColors[0], DefaultColors[1]);
        }

        public Tuple<OxyColor, OxyColor> GetBoxPlotColors()
        {
            return Tuple.Create(OxyColors.Black, DefaultColors[0]);
        }
    }
}
