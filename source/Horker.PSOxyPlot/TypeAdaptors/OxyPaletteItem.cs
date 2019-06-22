using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class OxyPaletteItem
    {
        public object Value { get; set; }

        public OxyPaletteItem(object value)
        {
            if (value is PSObject pso)
                value = pso.BaseObject;

            Value = value;
        }
    }
}
