using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class OxyImage
    {
        public OxyPlot.OxyImage Value { get; private set; }

        public OxyImage(OxyPlot.OxyImage image)
        {
            Value = image;
        }

        public OxyImage(string fileName)
        {
            var bytes = File.ReadAllBytes(fileName);
            Value = new OxyPlot.OxyImage(bytes);
        }

        public OxyImage(byte[] bytes)
        {
            Value = new OxyPlot.OxyImage(bytes);
        }

        public static OxyPlot.OxyImage ConvertFrom(object value)
        {
            if (value is OxyPlot.OxyImage im)
                return im;

            if (value is byte[] b)
                return new OxyImage(b).Value;

            return new OxyImage((string)value).Value;
        }

        public static implicit operator OxyPlot.OxyImage(OxyImage value)
        {
            return value.Value;
        }

        public static implicit operator OxyImage(OxyPlot.OxyImage value)
        {
            return new OxyImage(value);
        }

        public static implicit operator OxyImage(string value)
        {
            var bytes = File.ReadAllBytes(value);
            var image = new OxyPlot.OxyImage(bytes);
            return new OxyImage(image);
        }

        public static implicit operator OxyImage(byte[] value)
        {
            return new OxyImage(value);
        }
    }
}
