using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class OxyColorArray
    {
        public OxyPlot.OxyColor[] Value;

        public OxyColorArray(object value)
        {
            if (value is IEnumerable<OxyPlot.OxyColor> c)
                Value = c.ToArray();
            else if (value is IEnumerable<object> o)
                Value = o.Select(x => new OxyColor(x).Value).ToArray();
            else
                throw new ArgumentException("Can't convert to a OxyColor array");
        }

        public static implicit operator OxyPlot.OxyColor[](OxyColorArray value)
        {
            return new OxyColorArray(value).Value;
        }
    }
}
