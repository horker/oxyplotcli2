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
            Value = Parse(value);
        }

        public Double(object value)
        {
            if (value is byte b)
                Value = b;
            else if (value is sbyte sb)
                Value = sb;
            else if (value is short s)
                Value = s;
            else if (value is int i)
                Value = i;
            else if (value is long l)
                Value = l;
            else if (value is float f)
                Value = f;
            else if (value is double d)
                Value = d;
            else if (value is decimal dec)
                Value = (double)dec;
            else if (value is DateTime dt)
                Value = Parse(dt);
            else if (value is DateTimeOffset dto)
                Value = Parse(dto);
            else if (value is TimeSpan ts)
                Value = Parse(ts);

            Value = Parse(value.ToString());
        }

        public static double Parse(string value)
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

        public static double Parse(DateTime value)
        {
            return OxyPlot.Axes.DateTimeAxis.ToDouble(value);
        }

        public static double Parse(DateTimeOffset value)
        {
            return OxyPlot.Axes.DateTimeAxis.ToDouble(value.DateTime);
        }

        public static double Parse(TimeSpan value)
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
            return new Double(Parse(value));
        }

        public static implicit operator Double(DateTimeOffset value)
        {
            return new Double(Parse(value));
        }

        public static implicit operator Double(TimeSpan value)
        {
            return new Double(Parse(value));
        }

        public static implicit operator Double(string value)
        {
            return new Double(Parse(value));
        }
    }
}
