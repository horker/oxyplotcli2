using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Horker.OxyPlotCli.TypeAdaptors
{
    public class Double
    {
        private object _value;
        public double Value => ConvertFrom(_value);

        public Double()
        {
            _value = double.NaN;
        }

        public Double(object value)
        {
            if (value is PSObject pso)
                _value = pso.BaseObject;
            _value = value;
        }

        public static double ConvertFrom(object value)
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
            else if (value is DateTime dt)
                v = ConvertFrom(dt);
            else if (value is DateTimeOffset dto)
                v = ConvertFrom(dto);
            else if (value is TimeSpan ts)
                v = ConvertFrom(ts);
            else
                v = ConvertFrom(value.ToString());

            return v;
        }

        private static readonly Regex UnitPattern = new Regex("^(.+)(px|in|cm|pt)\\w*$", RegexOptions.IgnoreCase);

        private static readonly int DpiX;
        private static readonly int DpiY;

        static Double()
        {
            // ref. https://stackoverflow.com/questions/1918877/how-can-i-get-the-dpi-in-wpf

            var dpiXProperty = typeof(SystemParameters).GetProperty("DpiX", BindingFlags.NonPublic | BindingFlags.Static);
            var dpiYProperty = typeof(SystemParameters).GetProperty("Dpi", BindingFlags.NonPublic | BindingFlags.Static);

            DpiX = (int)dpiXProperty.GetValue(null, null);
            DpiY = (int)dpiYProperty.GetValue(null, null);
        }

        public Type InferValueType()
        {
            var t = _value.GetType();
            if (t == typeof(double) || t == typeof(float) || t == typeof(long) || t == typeof(int) ||
                t == typeof(short) || t == typeof(byte) || t == typeof(sbyte))
                return typeof(double);

            if (t == typeof(DateTime) || t == typeof(DateTimeOffset))
                return typeof(DateTime);

            if (t == typeof(TimeSpan))
                return typeof(TimeSpan);

            try
            {
                var dummy = SmartConverter.ToDouble(_value);
                return typeof(double);
            }
            catch (Exception)
            {
                try
                {
                    var dummy = DateTime.Parse(_value.ToString());
                    return typeof(DateTime);
                }
                catch (Exception)
                {
                    try
                    {
                        var dummy = TimeSpan.Parse(_value.ToString());
                        return typeof(TimeSpan);
                    }
                    catch (Exception)
                    {
                        return _value.GetType();
                    }
                }
            }
        }

        public static double ConvertFrom(string value)
        {
            try
            {
                return SmartConverter.ToDouble(value);
            }
            catch (Exception)
            {
                try
                {
                    return OxyPlot.Axes.DateTimeAxis.ToDouble(SmartConverter.ToDateTime(value));
                }
                catch (Exception)
                {
                    try
                    {
                        return OxyPlot.Axes.TimeSpanAxis.ToDouble(TimeSpan.Parse(value));
                    }
                    catch (Exception)
                    {
                        try
                        {
                            var m = UnitPattern.Match(value);
                            if (m.Success)
                            {
                                value = m.Groups[1].Value;
                                var unit = m.Groups[2].Value.ToLower();
                                var unitMultiply = 1.0;
                                if (unit == "px")
                                    unitMultiply = 1.0;
                                else if (unit == "in")
                                    unitMultiply = DpiX;
                                else if (unit == "cm")
                                    unitMultiply = DpiX / 2.54;
                                else if (unit == "pt")
                                    unitMultiply = DpiX / 72.0;

                                return SmartConverter.ToDouble(value) * unitMultiply;
                            }
                            throw new ArgumentException($"Can't convert to double, DateTime nor TimeSpan: {value}");
                        }
                        catch (Exception)
                        {
                            throw new ArgumentException($"Can't convert to double, DateTime nor TimeSpan: {value}");
                        }
                    }
                }
            }
        }

        public static double ConvertFrom(DateTime value)
        {
            return OxyPlot.Axes.DateTimeAxis.ToDouble(value);
        }

        public static double ConvertFrom(DateTimeOffset value)
        {
            return OxyPlot.Axes.DateTimeAxis.ToDouble(value.DateTime);
        }

        public static double ConvertFrom(TimeSpan value)
        {
            return OxyPlot.Axes.TimeSpanAxis.ToDouble(value);
        }

        public static implicit operator double(Double value)
        {
            return value.Value;
        }

        public static implicit operator Double(byte value)
        {
            return new Double(value);
        }

        public static implicit operator Double(sbyte value)
        {
            return new Double(value);
        }

        public static implicit operator Double(short value)
        {
            return new Double(value);
        }

        public static implicit operator Double(int value)
        {
            return new Double(value);
        }

        public static implicit operator Double(long value)
        {
            return new Double(value);
        }

        public static implicit operator Double(float value)
        {
            return new Double(value);
        }

        public static implicit operator Double(double value)
        {
            return new Double(value);
        }

        public static implicit operator Double(decimal value)
        {
            return new Double(value);
        }

        public static implicit operator Double(DateTime value)
        {
            return new Double(value);
        }

        public static implicit operator Double(DateTimeOffset value)
        {
            return new Double(value);
        }

        public static implicit operator Double(TimeSpan value)
        {
            return new Double(value);
        }

        public static implicit operator Double(string value)
        {
            return new Double(value);
        }

        public static double[] ConvertArray(Double[] array)
        {
            var result = new double[array.Length];
            for (var i = 0; i < result.Length; ++i)
                result[i] = array[i];

            return result;
        }
    }
}
