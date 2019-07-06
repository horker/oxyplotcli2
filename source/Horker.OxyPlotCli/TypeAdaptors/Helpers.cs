using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.OxyPlotCli.TypeAdaptors
{
    public static class Helpers
    {
        public static object StripOffTypeAdaptors(object value)
        {
            if (value is Bool b)
                return b.Value;

            if (value is Category cat)
                return cat.CategoryName;

            if (value is Double d)
                return d.Value;

            if (value is OxyColor c)
                return c.Value;

            if (value is OxyPaletteItem[] p)
                return new OxyPalette(p).Value;

            return value;
        }

        public static T ConvertObjectType<T>(object value)
        {
            if (typeof(T) == typeof(bool))
                return (T)(object)Bool.ConvertFrom(value);

            if (typeof(T) == typeof(Category))
                return (T)(object)new Category(value.ToString());

            if (typeof(T) == typeof(double))
                return (T)(object)Double.ConvertFrom(value);

            if (typeof(T) == typeof(int))
                return (T)(object)SmartConverter.ToInt(value);

            if (typeof(T) == typeof(string))
                return (T)(object)value.ToString();

            if (typeof(T) == typeof(OxyColor))
                return (T)(object)OxyColor.ConvertFrom(value);

            return (T)value;
        }

        public static object ConvertObjectType(Type type, object value)
        {
            if (type == typeof(bool))
                return Bool.ConvertFrom(value);

            if (type == typeof(Category))
                return Category.Create(value);

            if (type == typeof(double))
                return Double.ConvertFrom(value);

            if (type == typeof(OxyPlot.DataPoint))
                return DataPoint.ConvertFrom(value);

            if (type == typeof(OxyPlot.IInterpolationAlgorithm))
                return InterpolationAlgorithm.ConvertFrom(value);

            if (type == typeof(OxyPlot.OxyColor))
                return OxyColor.ConvertFrom(value);

            if (type == typeof(OxyPlot.OxyImage))
                return OxyImage.ConvertFrom(value);

            if (type == typeof(OxyPlot.OxyPalette))
                return OxyPalette.ConvertFrom(value);

            if (type == typeof(OxyPlot.OxyThickness))
                return OxyThickness.ConvertFrom(value);

            if (type == typeof(OxyPlot.PlotLength))
                return PlotLength.ConvertFrom(value);

            if (type == typeof(OxyPlot.ScreenPoint))
                return ScreenPoint.ConvertFrom(value);

            if (type == typeof(OxyPlot.ScreenVector))
                return ScreenVector.ConvertFrom(value);

            if (type == typeof(int))
                return SmartConverter.ToInt(value);

            if (type == typeof(string))
                return (string)value;

            if (type.IsEnum)
            {
                var name = ((string)value).ToLower();
                var enumNames = type.GetEnumNames();
                var enumValues = type.GetEnumValues();
                var i = 0;
                foreach (var v in enumValues)
                {
                    if (enumNames[i++].ToLower() == name)
                        return v;
                }

                throw new ArgumentException($"Unknown enum value '{value}' for {type.FullName}");
            }

            return value;
        }
    }
}
