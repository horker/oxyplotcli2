using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;

namespace Horker.PSOxyPlot
{
    public class FunctionCompiler
    {
        private static readonly Dictionary<string, Func<double, double>> CodeCache = new Dictionary<string, Func<double, double>>();

        private static int classNameSuffix = 0;

        private static readonly string Namespace = "Horker.PSOxyPlot.DynamicallyGeneratedClasses";

        private static readonly string SourceCodeTemplate = @"
using System;
namespace {0} {{
    public static class {1}
    {{
        public static Func<double, double> f()
        {{
            return new Func<double, double>({2});
        }}
    }}
}}
";

        private static Assembly CompileString(string sourceString, string compilerVersion)
        {
            var provider = new CSharpCodeProvider(new Dictionary<string, string> { { "CompilerVersion", compilerVersion } });

            var param = new CompilerParameters()
            {
                GenerateExecutable = false,
                CompilerOptions = "/optimize"
            };

            param.ReferencedAssemblies.Add("System.dll");
            param.ReferencedAssemblies.Add("System.Core.dll");

            var cr = provider.CompileAssemblyFromSource(param, sourceString);
            
            if(cr.Errors.Count > 0)
            {
                var sb = new StringBuilder();
                sb.AppendFormat("Error on compiling: {0}", sourceString);
                sb.AppendLine();
                foreach (var ce in cr.Errors)
                {
                    sb.Append("  ");
                    sb.Append(ce.ToString());
                    sb.AppendLine();
                }

                throw new ArgumentException(sb.ToString());
            }

            return cr.CompiledAssembly;
        }

        public static Func<double, double> Compile(string funcString, string compilerVersion = "v3.5")
        {
            if (CodeCache.TryGetValue(funcString, out Func<double, double> f))
                return f;

            var className = "Func" + classNameSuffix++;
            var sourceString = string.Format(SourceCodeTemplate, Namespace, className, funcString);

            var assembly = CompileString(sourceString, "v3.5");

            var t = assembly.GetTypes().Where(c => c.Name == className).First();
            var m = t.GetMethod("f", BindingFlags.Static | BindingFlags.Public);
            return (Func<double, double>)m.Invoke(null, new object[0]);

        }
    }
}
