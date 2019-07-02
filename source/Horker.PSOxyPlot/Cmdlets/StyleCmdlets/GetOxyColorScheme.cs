using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Horker.PSOxyPlot.Styles;

namespace Horker.PSOxyPlot.Cmdlets
{
    [Cmdlet("Get", "OxyColorScheme")]
    public class GetOxyColorScheme : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public string Name;

        protected override void BeginProcessing()
        {
            if (string.IsNullOrEmpty(Name))
            {
                foreach (var s in ColorSchemeRegistry.ColorSchemes)
                    WriteObject(s);
            }
            else
            {
                var style = ColorSchemeRegistry.Get(Name);
                WriteObject(style);
            }
        }
    }
}
