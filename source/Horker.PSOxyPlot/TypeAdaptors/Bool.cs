using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class Bool
    {
        public bool Value { get; set; }

        public Bool()
        {
            Value = false;
        }

        public Bool(bool value)
        {
            Value = value;
        }

        public Bool(object value)
        {
            Value = SmartConverter.ToBool(value);
        }

        public static bool ConvertFrom(object value)
        {
            return new Bool(value).Value;
        }

        public static implicit operator bool(Bool value)
        {
            return value.Value;
        }

        public static implicit operator Bool(bool value)
        {
            return new Bool(value);
        }

        public static implicit operator Bool(byte value)
        {
            return new Bool(value != 0);
        }

        public static implicit operator Bool(sbyte value)
        {
            return new Bool(value != 0);
        }

        public static implicit operator Bool(short value)
        {
            return new Bool(value != 0);
        }

        public static implicit operator Bool(int value)
        {
            return new Bool(value != 0);
        }

        public static implicit operator Bool(long value)
        {
            return new Bool(value != 0);
        }

        public static implicit operator Bool(float value)
        {
            return new Bool(value != 0);
        }

        public static implicit operator Bool(double value)
        {
            return new Bool(value != 0);
        }

        public static implicit operator Bool(decimal value)
        {
            return new Bool(value != 0);
        }

        public static implicit operator Bool(string value)
        {
            return SmartConverter.ToBool(value);
        }
    }
}
