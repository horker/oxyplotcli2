using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class Style
    {
        public Styles.Style Value { get; private set; }

        public Style(string name)
        {
            Value = Styles.StyleRegistry.Get(name);
        }

        public Style(Styles.Style style)
        {
            if (style == null)
                Value = Styles.StyleRegistry.DefaultStyle;

            Value = style;
        }

        public static Styles.Style ConvertFrom(object value)
        {
            if (value == null)
                return Styles.StyleRegistry.DefaultStyle;

            if (value is string s)
                return new Style(s).Value;

            if (value is Styles.Style style)
                return style;

            return new Style(value.ToString()).Value;
        }

        public static implicit operator Styles.Style(Style value)
        {
            return value.Value;
        }
    }
}
