using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.Styles
{
    public interface IColorScheme
    {
        string Name { get; }
        OxyPalette GetColorAxisPalette(Axis axis);
        IList<OxyColor> GetDefaultColors(int count);
        Tuple<OxyColor, OxyColor> GetCandleStickColors();
    }
}
