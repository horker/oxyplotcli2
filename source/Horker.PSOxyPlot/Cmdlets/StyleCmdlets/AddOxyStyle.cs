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
    [Cmdlet("Add", "OxyStyle")]
    public class AddOxyStyle : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true)]
        public string Name;

        [Parameter(Position = 1, Mandatory = false)]
        public Hashtable Config = new Hashtable();

        [Parameter(Position = 2, Mandatory = false)]
        public string ColorScheme = null;

        [Parameter(Position = 3, Mandatory = false)]
        public string BaseStyle;

        protected override void BeginProcessing()
        {
            Style style;
            if (MyInvocation.BoundParameters.ContainsKey("BaseStyle"))
            {
                var baseStyle = StyleRegistry.Get(BaseStyle);
                style = Style.Create(Name, Config, baseStyle);
            }
            else
            {
                style = Style.Create(Name, Config, StyleRegistry.VanillaStyle);
            }

            if (MyInvocation.BoundParameters.ContainsKey("ColorScheme"))
                style.ColorScheme = ColorSchemeRegistry.Get(ColorScheme);

            StyleRegistry.Register(Name, style);
        }
    }
}
