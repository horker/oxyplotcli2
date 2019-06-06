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

        public static implicit operator Double(double value)
        {
            return new Double(value);
        }

        public static implicit operator Double(int value)
        {
            return new Double(value);
        }

        public static implicit operator Double(string value)
        {
            return SmartConverter.ToDouble(value);
        }
    }
}
