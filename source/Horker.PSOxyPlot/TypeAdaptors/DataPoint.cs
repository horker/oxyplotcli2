using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class DataPoint
    {
        public OxyPlot.DataPoint Value { get; private set; }

        public DataPoint()
        {
            Value = new OxyPlot.DataPoint();
        }

        public DataPoint(Double[] values)
        {
            if (values.Length != 2)
                throw new ArgumentException("Specify two numbers to create a DataPoint object");

            Value = new OxyPlot.DataPoint(values[0], values[1]);
        }

        public static OxyPlot.DataPoint ConvertFrom(object value)
        {
            if (value is Array a)
            {
                var values = new Double[a.Length];
                var i = 0;
                foreach (var e in a)
                    values[i++] = new Double(e);

                return new DataPoint(values);
            }

            throw new ArgumentException("Failed to create a DataPoint object");
        }

        public static implicit operator OxyPlot.DataPoint(DataPoint value)
        {
            return value.Value;
        }
    }
}
