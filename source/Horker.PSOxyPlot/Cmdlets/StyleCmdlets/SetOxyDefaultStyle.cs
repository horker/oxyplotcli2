using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Horker.PSOxyPlot.Styles;

namespace Horker.PSOxyPlot.Cmdlets
{
    [Cmdlet("Set", "OxyDefaultStyle")]
    public class SetOxyDefaultStyle : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true)]
        public TypeAdaptors.Style Style;

        [Parameter(Position = 1, Mandatory = false)]
        public string ColorScheme = null;

        [Parameter(Position = 2, Mandatory = false)]
        public string DefaultFont = null;

        protected override void BeginProcessing()
        {
            if (MyInvocation.BoundParameters.ContainsKey("ColorScheme") || MyInvocation.BoundParameters.ContainsKey("DefaultFont"))
            {
                var baseName = Style.Value.Name + "-" + ColorScheme + "-" + DefaultFont;

                var name = baseName;
                var count = 1;
                while (ColorSchemeRegistry.Contains(name))
                    name = $"{baseName}-{count++}";

                var newStyle = Styles.Style.Create(name, new Dictionary<string, object>(), Style);

                if (MyInvocation.BoundParameters.ContainsKey("ColorScheme"))
                    newStyle.ColorScheme = ColorSchemeRegistry.Get(ColorScheme);

                if (MyInvocation.BoundParameters.ContainsKey("DefaultFont"))
                    newStyle.DefaultFont = DefaultFont;

                newStyle.Temporary = true;

                StyleRegistry.DefaultStyle = newStyle;
            }
            else
            {
                StyleRegistry.DefaultStyle = Style;
            }
        }
    }
}
