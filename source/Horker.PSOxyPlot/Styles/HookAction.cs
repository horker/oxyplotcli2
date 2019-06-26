using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.Styles
{
    public class HookAction
    {
        private Action<object> _action;
        private ScriptBlock _scriptBlock;

        public HookAction(Action<object> action)
        {
            _action = action;
        }

        public HookAction(ScriptBlock scriptBlock)
        {
            _scriptBlock = scriptBlock;
        }

        public static HookAction Create(object value)
        {
            if (value is Action<object> a)
                return new HookAction(a);

            if (value is ScriptBlock sb)
                return new HookAction(sb);

            throw new ArgumentException("Failed to create a HookAction object");
        }

        public void Invoke(object argument)
        {
            if (_action != null)
                _action.Invoke(argument);
            else
                _scriptBlock.Invoke(new object[] { argument });
        }
    }
}
