using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.Styles
{
    public static class ColorSchemeRegistry
    {
        private static Dictionary<string, IColorScheme> _colorSchemes;

        public static IEnumerable<IColorScheme> ColorSchemes => _colorSchemes.Values;

        static ColorSchemeRegistry()
        {
            _colorSchemes = new Dictionary<string, IColorScheme>();

            _colorSchemes.Add("vanilla", new VanillaColorScheme());
            _colorSchemes.Add("ggplot", new GgplotColorScheme());
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
