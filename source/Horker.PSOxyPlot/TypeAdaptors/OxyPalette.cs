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
                throw new ArgumentException("Specify a palette name and an optional palette size to create an OxyPalette; Palette names are: BlackWhiteRed, BlueWhiteRed, Cool, Gray, Hot, Hue, HueDistinct, Jet or Rainbow");

            string name = values[0].ToString();

            var paletteSize = 100;
            if (values.Length == 2)
                paletteSize = SmartConverter.ToInt32(values[1]);

            switch (name.ToLower())
            {
                case "bluewhitered31":
                    Value = OxyPlot.OxyPalettes.BlueWhiteRed31;
                    break;

                case "hot64":
                    Value = OxyPlot.OxyPalettes.Hot64;
                    break;

                case "hue64":
                    Value = OxyPlot.OxyPalettes.Hue64;
                    break;

                case "blackwhitered":
                    Value = OxyPlot.OxyPalettes.BlackWhiteRed(paletteSize);
                    break;

                case "bluewhitered":
                    Value = OxyPlot.OxyPalettes.BlueWhiteRed(paletteSize);
                    break;

                case "cool":
                    Value = OxyPlot.OxyPalettes.Cool(paletteSize);
                    break;

                case "gray":
                    Value = OxyPlot.OxyPalettes.Gray(paletteSize);
                    break;

                case "hot":
                    Value = OxyPlot.OxyPalettes.Hot(paletteSize);
                    break;

                case "hue":
                    Value = OxyPlot.OxyPalettes.Hue(paletteSize);
                    break;

                case "huedistinct":
                    Value = OxyPlot.OxyPalettes.HueDistinct(paletteSize);
                    break;

                case "jet":
                    Value = OxyPlot.OxyPalettes.Jet(paletteSize);
                    break;

                case "rainbow":
                    Value = OxyPlot.OxyPalettes.Rainbow(paletteSize);
                    break;

                default:
                    throw new ArgumentException($"Unknown palette name '{name}'; A palette name is: BlackWhiteRed, BlueWhiteRed, Cool, Gray, Hot, Hue, HueDistinct, Jet or Rainbow");
            }
        }

        public static implicit operator OxyPlot.OxyPalette(OxyPalette value)
        {
            return value.Value;
        }
    }
}
