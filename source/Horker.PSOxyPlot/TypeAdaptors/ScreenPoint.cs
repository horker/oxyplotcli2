using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class ScreenPoint
    {
        public OxyPlot.ScreenPoint Value { get; private set; }

        public ScreenPoint()
        {
            Value = new OxyPlot.ScreenPoint();
        }

        public ScreenPoint(Double[] values)
        {
            if (values.Length != 2)
                throw new ArgumentException("Specify two numbers to create a ScreenPoint object");

            Value = new OxyPlot.ScreenPoint(values[0], values[1]);
        }

        public static OxyPlot.ScreenPoint ConvertFrom(object value)
        {
            if (value is Array a)
            {
                var values = new Double[a.Length];
                var i = 0;
                foreach (var e in a)
                    values[i++] = new Double(e);

                return new ScreenPoint(values).Value;
            }

            throw new ArgumentException("Failed to create a ScreenPoint object");
        }

        public static implicit operator OxyPlot.ScreenPoint(ScreenPoint value)
        {
            return value.Value;
        }

        public static OxyPlot.ScreenPoint[] ConvertArray(Double[] values)
        {
            if (values.Length % 2 != 0)
                throw new ArgumentException("Specify an even length array to create an array of ScreenPoint objects");

            var result = new OxyPlot.ScreenPoint[values.Length / 2];

            for (var i = 0; i < result.Length; ++i)
                result[i] = new OxyPlot.ScreenPoint(values[i * 2], values[i * 2 + 1]);

            return result;
        }
    }
}
