﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class OxyColor
    {
        private static readonly Dictionary<string, OxyPlot.OxyColor> _colorMap;
        private OxyPlot.OxyColor _color;

        public static IDictionary<string, OxyPlot.OxyColor> Colors => _colorMap;

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

        public OxyColor(string colorString)
        {
            _color = Parse(colorString);
        }

        private OxyPlot.OxyColor Parse(string colorString)
        {
            OxyPlot.OxyColor color;
            if (_colorMap.TryGetValue(colorString.ToLower(), out color))
                return color;

            throw new ArgumentException($"Unknown color name: {colorString}");
        }

        public static implicit operator OxyPlot.OxyColor(OxyColor adaptor)
        {
            return adaptor._color;
        }
    }
}

