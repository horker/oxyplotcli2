using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public static class Helpers
    {
        public static object StripOffTypeAdaptors(object value)
        {
            if (value is Double d)
                return d.Value;
            if (value is Bool b)
                return b.Value;
            if (value is OxyColor c)
                return c.Value;
            if (value is Category cat)
                return cat.CategoryName;

            return value;
        }

        public static T ConvertObjectType<T>(object value)
        {
            if (typeof(T) == typeof(double))
                return (T)(object)Double.ConvertFrom(value);

            if (typeof(T) == typeof(int))
                return (T)(object)SmartConverter.ToInt(value);

            if (typeof(T) == typeof(bool))
                return (T)(object)Bool.ConvertFrom(value);

            if (typeof(T) == typeof(string))
                return (T)(object)value.ToString();

            if (typeof(T) == typeof(OxyColor))
                return (T)(object)OxyColor.ConvertFrom(value);

            if (typeof(T) == typeof(Category))
                return (T)(object)new Category((string)value);

            return (T)value;
        }
    }
}
