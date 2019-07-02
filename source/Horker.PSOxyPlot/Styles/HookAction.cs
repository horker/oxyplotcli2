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
        private Action<object, Style> _action;
        private ScriptBlock _scriptBlock;

        public HookAction(Action<object, Style> action)
        {
            _action = action;
        }

        public HookAction(ScriptBlock scriptBlock)
        {
            _scriptBlock = scriptBlock;
        }

        public static HookAction Create(object value)
        {
            if (value is HookAction ha)
                return ha;

            if (value is Action<object, Style> a)
                return new HookAction(a);

            if (value is ScriptBlock sb)
                return new HookAction(sb);

            throw new ArgumentException("Failed to create a HookAction object");
        }

        public void Invoke(object target, Style style)
        {
            if (_action != null)
                _action.Invoke(target, style);
            else
                _scriptBlock.Invoke(new object[] { target, style });
        }

        public static bool CanTakeAsScript(object value)
        {
            return value is Action<object, Style> || value is ScriptBlock || value is HookAction;
        }
    }
}
