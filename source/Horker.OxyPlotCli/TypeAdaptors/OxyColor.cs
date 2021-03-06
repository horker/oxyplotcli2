﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Horker.OxyPlotCli.TypeAdaptors
{
    public class OxyColor
    {
        private static readonly Dictionary<string, OxyPlot.OxyColor> _colorMap;
        private static readonly Regex ColorFormat = new Regex("^(.+)-([\\d.]+)$");

        private OxyPlot.OxyColor _color;

        public static IDictionary<string, OxyPlot.OxyColor> Colors => _colorMap;
        public OxyPlot.OxyColor Value => _color;

        static OxyColor()
        {
            _colorMap = new Dictionary<string, OxyPlot.OxyColor>();
            var ps = typeof(OxyPlot.OxyColors).GetFields();

            foreach (var p in ps)
            {
                if (p.FieldType == typeof(OxyPlot.OxyColor))
                    _colorMap.Add(p.Name.ToLower(), (OxyPlot.OxyColor)p.GetValue(null));
            }
        }

        public OxyColor()
        {
            _color = OxyPlot.OxyColors.Automatic;
        }

        public OxyColor(OxyPlot.OxyColor color)
        {
            _color = color;
        }
        
        public OxyColor(string value)
        {
            _color = ConvertFrom(value);
        }

        public static OxyPlot.OxyColor ConvertFrom(object value)
        {
            if (value is OxyPlot.OxyColor c)
                return c;
            else 
                return ConvertFrom(value.ToString());
        }

        public static OxyPlot.OxyColor ConvertFrom(string colorString)
        {
            double alpha = double.NaN;

            var m = ColorFormat.Match(colorString);
            if (m.Success)
            {
                colorString = m.Groups[1].Value;
                alpha = double.Parse(m.Groups[2].Value) / 100;
            }

            OxyPlot.OxyColor color;
            if (!_colorMap.TryGetValue(colorString.ToLower(), out color))
                color = OxyPlot.OxyColor.Parse(colorString);

            if (!double.IsNaN(alpha))
                color = OxyPlot.OxyColor.FromAColor((byte)(alpha * 255), color);

            return color;
        }

        public static implicit operator OxyPlot.OxyColor(OxyColor value)
        {
            return value._color;
        }

        public static implicit operator OxyColor(string value)
        {
            return new OxyColor(ConvertFrom(value));
        }

        public static implicit operator OxyColor(OxyPlot.OxyColor value)
        {
            return new OxyColor(value);
        }

        public static OxyPlot.OxyColor[] ConvertArray(OxyColor[] array)
        {
            var result = new OxyPlot.OxyColor[array.Length];
            for (var i = 0; i < result.Length; ++i)
                result[i] = array[i];

            return result;

        }
    }
}

