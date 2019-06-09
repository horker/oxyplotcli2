using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class Double
    {
        public double Value;

        public Double()
        {
            Value = double.NaN;
        }

        public Double(double value)
        {
            Value = value;
        }

        public Double(string value)
        {
            Value = ConvertFrom(value);
        }

        public static double ConvertFrom(object value)
        {
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
                        throw new ArgumentException($"Can't convert to double, DateTime nor TimeSpan: {value}");
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
            return new Double((double)value);
        }

        public static implicit operator Double(DateTime value)
        {
            return new Double(ConvertFrom(value));
        }

        public static implicit operator Double(DateTimeOffset value)
        {
            return new Double(ConvertFrom(value));
        }

        public static implicit operator Double(TimeSpan value)
        {
            return new Double(ConvertFrom(value));
        }

        public static implicit operator Double(string value)
        {
            return new Double(ConvertFrom(value));
        }
    }
}
