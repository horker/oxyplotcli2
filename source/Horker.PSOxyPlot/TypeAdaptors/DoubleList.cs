using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class DoubleList
    {
        public List<double> Values { get; private set; }

        public DoubleList(object values)
        {
            Values = new List<double>();

            object v = values;
            if (values is PSObject psobj)
                v = psobj.BaseObject;

            if (v is ICollection<double> dc)
            {
                foreach (var e in dc)
                    Values.Add(e);
            }
            else if (v is ICollection<object> oc)
            {
                foreach (var e in oc)
                    Values.Add(SmartConverter.ToDouble(e));
            }
            else
                throw new ArgumentException("Can't convert into a sequence of type double");
        }

        public static implicit operator List<double>(DoubleList values)
        {
            return values.Values;
        }
    }
}
