using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class ScriptBlock
    {
        private Func<double, double> _func;

        private System.Management.Automation.ScriptBlock _scriptBlock;
        private List<PSVariable> _variables;
        private PSVariable _param;

        private string _toString;

        public ScriptBlock(string functionString)
        {
            _func = FunctionCompiler.Compile(functionString);
            _toString = functionString;
        }

        public ScriptBlock(System.Management.Automation.ScriptBlock scriptBlock)
        {
            _scriptBlock = scriptBlock;
            _variables = new List<PSVariable>();
            _toString = _scriptBlock.ToString();
        }

        public void SetParameterName(string p)
        {
            if (_variables != null)
            {
                _param = new PSVariable(p);
                _variables.Add(_param);
            }
        }

        public double Invoke(double arg)
        {
            if (_func != null)
                return _func.Invoke(arg);

            _param.Value = arg;
            return (double)_scriptBlock.InvokeWithContext(null, _variables, null)[0].BaseObject;
        }

        public override string ToString()
        {
            return _toString;
        }

        public static implicit operator ScriptBlock(string value)
        {
            return new ScriptBlock(value);
        }

        public static implicit operator ScriptBlock(System.Management.Automation.ScriptBlock value)
        {
            return new ScriptBlock(value);
        }
    }
}
