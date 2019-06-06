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
            return OxyPlot.Axes.DateTimeAxis.ToDouble(value);
        }

        public static implicit operator Double(TimeSpan value)
        {
            return OxyPlot.Axes.TimeSpanAxis.ToDouble(value);
        }

        public static implicit operator Double(string value)
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
    }
}
