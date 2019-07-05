using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Axes;

namespace Horker.PSOxyPlot.Styles
{
    class ColorfulColorScheme : IColorScheme
    {
        private Dictionary<int, IList<OxyColor>> _cache;
        private OxyPalette _palette;

        private static readonly int AxisPaletteColorCount = 6;

        public string Name { get; private set; }
        public OxyColor[] Colors { get; private set; }

        public OxyPalette Palette
        {
            get
            {
                EnsurePaletteColors();
                return _palette;
            }
        }

        private void EnsurePaletteColors()
        {
            if (_palette != null)
                return;

            var c = new OxyColor[AxisPaletteColorCount];
            Array.Copy(Colors, c, AxisPaletteColorCount);
            _palette = new OxyPalette(OxyPalette.Interpolate(200, c).Colors);
        }

        public ColorfulColorScheme(string name, IList<OxyColor> colors)
        {
            Name = name;
            Colors = colors.ToArray();

            _cache = new Dictionary<int, IList<OxyColor>>();
            _palette = null;
        }

        public Tuple<OxyColor, OxyColor> GetBoxPlotColors()
        {
            return Tuple.Create(OxyColors.Black, Colors[0]);
        }

        public Tuple<OxyColor, OxyColor> GetCandleStickColors()
        {
            return Tuple.Create(Colors[0], Colors[1]);
        }

        public OxyPalette GetColorAxisPalette(Axis axis)
        {
            return Palette;
        }

        public IList<OxyColor> GetDefaultColors(int count)
        {
            if (_cache.TryGetValue(count, out var value))
                return value;

            var colors = new OxyColor[count];

            int c = count;
            int start = 0;
            while (Colors.Length <= c)
            {
                Array.Copy(Colors, 0, colors, start, Colors.Length);
                start += Colors.Length;
                c -= Colors.Length;
            }

            if (c > 0)
                Array.Copy(Colors, 0, colors, start, c);

            _cache.Add(count, colors);

            return colors;
        }

    }
}
