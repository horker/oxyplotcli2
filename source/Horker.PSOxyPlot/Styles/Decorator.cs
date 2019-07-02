using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.Styles
{
    public class Decorator
    {
        public Type Type { get; private set; }
        public PropertyInfo Property { get; private set; }
        public object Value { get; private set; }

        public bool IsScript => Value is HookAction;

        public Decorator(Type type, PropertyInfo property, object value)
        {
            Type = type;
            Property = property;
            Value = value;
        }
    }
}
