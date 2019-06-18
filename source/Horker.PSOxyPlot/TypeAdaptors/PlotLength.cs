using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class PlotLength
    {
        public OxyPlot.PlotLength Value { get; private set; }

        public PlotLength()
        {
            Value = new OxyPlot.PlotLength();
        }

        public PlotLength(double value)
        {
            Value = new OxyPlot.PlotLength(value, OxyPlot.PlotLengthUnit.Data);
        }

        public static OxyPlot.PlotLength ConvertFrom(object value)
        {
            if (value is PSObject pso)
                value = pso.BaseObject;

            double v;
            if (value is byte b)
                v = b;
            else if (value is sbyte sb)
                v = sb;
            else if (value is short s)
                v = s;
            else if (value is int i)
                v = i;
            else if (value is long l)
                v = l;
            else if (value is float f)
                v = f;
            else if (value is double d)
                v = d;
            else if (value is decimal dec)
                v = (double)dec;
            else
                return ConvertFrom(value.ToString());

            return new OxyPlot.PlotLength(v, OxyPlot.PlotLengthUnit.Data);
        }

        private static readonly Regex UnitPattern = new Regex("^(.+)(px|in|cm|pt|viewport|plotarea)\\w*$", RegexOptions.IgnoreCase);

        private static readonly int DpiX;
        private static readonly int DpiY;

        static PlotLength()
        {
            // ref. https://stackoverflow.com/questions/1918877/how-can-i-get-the-dpi-in-wpf

            var dpiXProperty = typeof(SystemParameters).GetProperty("DpiX", BindingFlags.NonPublic | BindingFlags.Static);
            var dpiYProperty = typeof(SystemParameters).GetProperty("Dpi", BindingFlags.NonPublic | BindingFlags.Static);

            DpiX = (int)dpiXProperty.GetValue(null, null);
            DpiY = (int)dpiYProperty.GetValue(null, null);
        }

        public static OxyPlot.PlotLength ConvertFrom(string value)
        {
            var unitMultiply = 1.0;
            var plotLengthUnit = OxyPlot.PlotLengthUnit.Data;

            var m = UnitPattern.Match(value);
            if (m.Success)
            {
                value = m.Groups[1].Value;
                var unit = m.Groups[2].Value.ToLower();

                switch (unit)
                {
                    case "px":
                        unitMultiply = 1.0;
                        break;
                    case "in":
                        unitMultiply = DpiX;
                        break;
                    case "cm":
                        unitMultiply = DpiX / 2.54;
                        break;
                    case "pt":
                        unitMultiply = DpiX / 72.0;
                        break;
                    case "viewport":
                        plotLengthUnit = OxyPlot.PlotLengthUnit.RelativeToViewport;
                        break;
                    case "plotarea":
                        plotLengthUnit = OxyPlot.PlotLengthUnit.RelativeToPlotArea;
                        break;
                    default:
                        throw new ArgumentException($"Unknown unit: {m.Groups[2].Value}");
                }
            }

            return new OxyPlot.PlotLength(SmartConverter.ToDouble(value) * unitMultiply, plotLengthUnit);
        }

        public static implicit operator OxyPlot.PlotLength(PlotLength value)
        {
            return value.Value;
        }

        public static implicit operator PlotLength(byte value)
        {
            return new PlotLength(value);
        }

        public static implicit operator PlotLength(sbyte value)
        {
            return new PlotLength(value);
        }

        public static implicit operator PlotLength(short value)
        {
            return new PlotLength(value);
        }

        public static implicit operator PlotLength(int value)
        {
            return new PlotLength(value);
        }

        public static implicit operator PlotLength(long value)
        {
            return new PlotLength(value);
        }

        public static implicit operator PlotLength(float value)
        {
            return new PlotLength(value);
        }

        public static implicit operator PlotLength(double value)
        {
            return new PlotLength(value);
        }

        public static implicit operator PlotLength(decimal value)
        {
            return new PlotLength((double)value);
        }

        public static implicit operator PlotLength(string value)
        {
            return new PlotLength() { Value = ConvertFrom(value) };
        }
    }
}
