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

        public OxyPalette(object values)
        {
            if (values is PSObject pso)
                values = pso.BaseObject;

            if (values is OxyPlot.OxyPalette p)
            {
                Value = p;
                return;
            }

            if (!(values is string[] v))
                throw new ArgumentException("Specify a palette name and an optional palette size to create an OxyPalette");

            if (v.Length > 2)
                throw new ArgumentException("Specify a palette name and an optional palette size to create an OxyPalette");

            var paletteSize = 100;
            if (v.Length == 2)
                paletteSize = int.Parse(v[1]);

            var name = v[0].ToLower();

            switch (name)
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
                    throw new ArgumentException($"Unknown predefined palette name: '{v[0]}'; Specify one of BlackWhiteRed, BlueWhiteRed, Cool, Gray, Hot, Hue, HueDistinct, Jet or Rainbow");
            }
        }

        public static implicit operator OxyPlot.OxyPalette(OxyPalette value)
        {
            return value.Value;
        }
    }
}
