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

        private static void AddPaletteColorScheme(string name, IList<OxyColor> colors, bool reverse = false)
        {
            var p = new PaletteColorScheme(name, colors, 200);
            Register(p);

            if (reverse)
            {
                var r = new PaletteColorScheme(name + "-rev", colors.Reverse().ToArray(), 200);
                Register(r);
            }
        }

        static ColorSchemeRegistry()
        {
            _colorSchemes = new Dictionary<string, IColorScheme>();

            // OxyPlot default colors

            _colorSchemes.Add("vanilla", new VanillaColorScheme());

            // OxyPlot preset palettes that are hard-written in OxyPalettes.

            AddPaletteColorScheme("BlueWhiteRed", new[] { OxyColors.Blue, OxyColors.White, OxyColors.Red });

            AddPaletteColorScheme("Cool", new[] { OxyColors.Cyan, OxyColors.Magenta });

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

            // ggplot's default color schemea obtained by R's hue_pal()

            _colorSchemes.Add("ggplot", new GgplotColorScheme());

            // Monotone palettes (stolen from Excel 2016)

            AddPaletteColorScheme("navy", new[] { OxyColor.FromRgb(64, 109, 187), OxyColor.FromRgb(192, 201, 228) }, true);
            AddPaletteColorScheme("orange", new[] { OxyColor.FromRgb(174, 90, 33), OxyColor.FromRgb(246, 204, 190) }, true);
            AddPaletteColorScheme("gray", new[] { OxyColor.FromRgb(120,120,120), OxyColor.FromRgb(216, 216,216) }, true);
            AddPaletteColorScheme("gold", new[] { OxyColor.FromRgb(188,140,0), OxyColor.FromRgb(255, 226, 188) }, true);
            AddPaletteColorScheme("blue", new[] { OxyColor.FromRgb(65,113,156), OxyColor.FromRgb(196, 213, 235) }, true);
            AddPaletteColorScheme("green", new[] { OxyColor.FromRgb(80, 126, 50), OxyColor.FromRgb(201, 219, 193) }, true);
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
