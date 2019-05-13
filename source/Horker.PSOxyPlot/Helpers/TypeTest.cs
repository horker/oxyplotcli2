using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot
{
    public static class TypeTest
    {
        public static bool IsNumeric(Type type)
        {
            return type == typeof(byte) ||
                type == typeof(sbyte) ||
                type == typeof(short) ||
                type == typeof(int) ||
                type == typeof(long) ||
                type == typeof(float) ||
                type == typeof(double);
        }

        public static bool IsFloatingPoint(Type type)
        {
            return type == typeof(float) || type == typeof(double);
        }
    }
}
