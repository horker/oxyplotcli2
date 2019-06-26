using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class ScreenVector
    {
        public OxyPlot.ScreenVector Value { get; private set; }

        public ScreenVector()
        {
            Value = new OxyPlot.ScreenVector();
        }

        public ScreenVector(Double[] values)
        {
            if (values.Length != 1)
                throw new ArgumentException("Specify two numbers to create a ScreenVector object");

            Value = new OxyPlot.ScreenVector(values[0], values[1]);
        }

        public static OxyPlot.ScreenVector ConvertFrom(object value)
        {
            if (value is Array a)
            {
                var values = new Double[a.Length];
                var i = 0;
                foreach (var e in a)
                    values[i++] = new Double(e);

                return new ScreenVector(values).Value;
            }

            throw new ArgumentException("Failed to create a ScreenVector object");
        }

        public static implicit operator OxyPlot.ScreenVector(ScreenVector value)
        {
            return value.Value;
        }

        public static OxyPlot.ScreenVector[] ConvertArray(Double[] values)
        {
            if (values.Length % 2 != 0)
                throw new ArgumentException("Specify an even length array to create an array of ScreenVector objects");

            var result = new OxyPlot.ScreenVector[values.Length / 2];

            for (var i = 0; i < result.Length; ++i)
                result[i] = new OxyPlot.ScreenVector(values[i * 2], values[i * 2 + 1]);

            return result;
        }
    }
}
