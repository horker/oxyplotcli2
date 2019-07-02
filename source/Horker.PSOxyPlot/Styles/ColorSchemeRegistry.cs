using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;

namespace Horker.PSOxyPlot.Styles
{
    public static class ColorSchemeRegistry
    {
        private static Dictionary<string, IColorScheme> _colorSchemes;

        public static IEnumerable<IColorScheme> ColorSchemes => _colorSchemes.Values;

        private static void AddPaletteColorScheme(string name, IList<OxyColor> colors)
        {
            var p = new PaletteColorScheme(name, colors, 200);
            Register(p);
        }

        static ColorSchemeRegistry()
        {
            _colorSchemes = new Dictionary<string, IColorScheme>();

            _colorSchemes.Add("vanilla", new VanillaColorScheme());
            _colorSchemes.Add("ggplot", new GgplotColorScheme());

            // OxyPlot's preset palettes that are hard-written in OxyPalettes.

            AddPaletteColorScheme("BlueWhiteRed", new[] { OxyColors.Blue, OxyColors.White, OxyColors.Red });

            AddPaletteColorScheme("Cool", new[] { OxyColors.Cyan, OxyColors.Magenta });

            // AddPaletteColorScheme("Gray", new[] { OxyColors.Black, OxyColors.White });
            AddPaletteColorScheme("Gray", OxyPalettes.Gray(200).Colors);

            AddPaletteColorScheme("Hot", new[] {
                OxyColors.Black,
                OxyColor.FromRgb(127, 0, 0),
                OxyColor.FromRgb(255, 127, 0),
                OxyColor.FromRgb(255, 255, 127),
                OxyColors.White
            });

            AddPaletteColorScheme("Hue", new[] {
                OxyColors.Red,
                OxyColors.Yellow,
                OxyColors.Green,
                OxyColors.Cyan,
                OxyColors.Blue,
                OxyColors.Magenta,
            });


            AddPaletteColorScheme("HueDistinct", new[] {
                OxyColors.Magenta,
                OxyColors.Blue,
                OxyColors.Cyan,
                OxyColors.Green,
                OxyColors.Yellow,
                OxyColors.Red
            });

            AddPaletteColorScheme("Jet", new[] {
                OxyColors.DarkBlue,
                OxyColors.Cyan,
                OxyColors.Yellow,
                OxyColors.Orange,
                OxyColors.DarkRed
            });

            AddPaletteColorScheme("Rainbow", new[] {
                OxyColors.Violet,
                OxyColors.Indigo,
                OxyColors.Blue,
                OxyColors.Green,
                OxyColors.Yellow,
                OxyColors.Orange,
                OxyColors.Red
            });
        }

        public static void Register(IColorScheme colorScheme)
        {
            _colorSchemes.Add(colorScheme.Name.ToLower(), colorScheme);
        }

        public static void Unregister(string name)
        {
            _colorSchemes.Remove(name.ToLower());
        }

        public static IColorScheme Get(string name)
        {
            if (_colorSchemes.TryGetValue(name.ToLower(), out var colorScheme))
                return colorScheme;

            throw new ArgumentException($"No color scheme found: '{name}'");
        }
    }
}
