using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public static class Helpers
    {
        public static object ConvertObjectType(object value)
        {
            if (value is Double d)
                return d.Value;
            if (value is OxyColor c)
                return c.Value;
            if (value is Category cat)
                return cat.CategoryName;

            return value;
        }
    }
}
