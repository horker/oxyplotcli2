﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;

namespace Horker.PSOxyPlot.Cmdlets
{
    [Cmdlet("New", "OxyPalette")]
    [CmdletBinding(DefaultParameterSetName = "Preset")]
    public class NewOxyPalette : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true, ParameterSetName = "Preset")]
        [ValidateSet("BlueWhiteRed31", "Hot64", "Hue64", "BlackWhiteRed", "BlueWhiteRed", "Cool", "Gray", "Hot", "Hue", "HueDistinct", "Jet", "Rainbow")]
        [Alias("Type")]
        public string Preset;

        [Parameter(Position = 0, Mandatory = true, ParameterSetName = "Colors")]
        public TypeAdaptors.OxyColor[] Colors;

        [Parameter(Position = 1, Mandatory = false, ParameterSetName = "Preset")]
        [Parameter(Position = 1, Mandatory = false, ParameterSetName = "Colors")]
        [Alias("NumberOfColors")]
        public int PaletteSize = -1;

        protected override void BeginProcessing()
        {
            OxyPalette palette;
            if (ParameterSetName == "Preset")
            {
                if (PaletteSize == -1)
                    PaletteSize = 100;

                palette = new TypeAdaptors.OxyPalette(Preset, PaletteSize).Value;
            }
            else
            {
                var colors = TypeAdaptors.OxyColor.ConvertArray(Colors);
                if (PaletteSize == -1)
                    palette = new OxyPalette(colors);
                else
                    palette = OxyPalette.Interpolate(PaletteSize, colors);
            }

            WriteObject(palette);
        }
    }
}