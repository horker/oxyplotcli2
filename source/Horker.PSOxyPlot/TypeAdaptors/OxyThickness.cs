using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class OxyThickness
    {
        public OxyPlot.OxyThickness Value { get; private set; }

        public OxyThickness()
        {
            Value = new OxyPlot.OxyThickness();
        }

        public OxyThickness(Double[] values)
        {
            if (values.Length == 1)
                Value = new OxyPlot.OxyThickness(values[0]);
            else if (values.Length == 2)
                Value = new OxyPlot.OxyThickness(values[0], values[1], values[0], values[1]);
            else if (values.Length == 4)
                Value = new OxyPlot.OxyThickness(values[0], values[1], values[2], values[3]);
            else
                throw new ArgumentException("Specify one, two or four numbers to create OxyThickness object");
        }

        public static implicit operator OxyPlot.OxyThickness(OxyThickness value)
        {
            return value.Value;
        }
    }
}
