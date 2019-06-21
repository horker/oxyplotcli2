using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class OxyPalette
    {
        public OxyPlot.OxyPalette Value { get; private set; }

        public OxyPalette(OxyPlot.OxyPalette palette)
        {
            Value = palette;
        }

        public OxyPalette(string paletteName, int paletteSize)
        {
            Value = ConvertFrom(paletteName, paletteSize);
        }

        public OxyPalette(object[] values)
        {
            if (values.Length == 0)
            {
                Value = new OxyPlot.OxyPalette();
                return;
            }

            if (values.Length == 1)
            {
                var v = values[0];
                if (v is PSObject pso)
                    v = pso.BaseObject;
                if (v is OxyPlot.OxyPalette p)
                {
                    Value = p;
                    return;
                }
            }

            if (values.Length > 2)
                throw new ArgumentException("Specify a palette name and an optional palette size to create an OxyPalette; A palette name is one of BlueWhiteRed31, Hot64, Hue64, BlackWhiteRed, BlueWhiteRed, Cool, Gray, Hot, Hue, HueDistinct, Jet or Rainbow");

            string name = values[0].ToString();

            var paletteSize = 100;
            if (values.Length == 2)
                paletteSize = SmartConverter.ToInt32(values[1]);

            Value = ConvertFrom(name, paletteSize);
        }

        private OxyPlot.OxyPalette ConvertFrom(string paletteName, int paletteSize)
        {
            switch (paletteName.ToLower())
            {
                case "bluewhitered31":
                    return OxyPlot.OxyPalettes.BlueWhiteRed31;

                case "hot64":
                    return OxyPlot.OxyPalettes.Hot64;

                case "hue64":
                    return OxyPlot.OxyPalettes.Hue64;

                case "blackwhitered":
                    return OxyPlot.OxyPalettes.BlackWhiteRed(paletteSize);

                case "bluewhitered":
                    return OxyPlot.OxyPalettes.BlueWhiteRed(paletteSize);

                case "cool":
                    return OxyPlot.OxyPalettes.Cool(paletteSize);

                case "gray":
                    return OxyPlot.OxyPalettes.Gray(paletteSize);

                case "hot":
                    return OxyPlot.OxyPalettes.Hot(paletteSize);

                case "hue":
                    return OxyPlot.OxyPalettes.Hue(paletteSize);

                case "huedistinct":
                    return OxyPlot.OxyPalettes.HueDistinct(paletteSize);

                case "jet":
                    return OxyPlot.OxyPalettes.Jet(paletteSize);

                case "rainbow":
                    return OxyPlot.OxyPalettes.Rainbow(paletteSize);

                default:
                    throw new ArgumentException($"Unknown palette name '{paletteName}'; A palette name is one of BlueWhiteRed31, Hot64, Hue64, BlackWhiteRed, BlueWhiteRed, Cool, Gray, Hot, Hue, HueDistinct, Jet or Rainbow");
            }
        }

        public static implicit operator OxyPlot.OxyPalette(OxyPalette value)
        {
            return value.Value;
        }
    }
}
