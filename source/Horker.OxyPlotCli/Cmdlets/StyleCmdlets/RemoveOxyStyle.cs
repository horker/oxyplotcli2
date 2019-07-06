using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Horker.OxyPlotCli.Styles;

namespace Horker.OxyPlotCli.Cmdlets
{
    [Cmdlet("Remove", "OxyStyle")]
    public class RemoveOxyStyle : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true)]
        public string Name;

        protected override void BeginProcessing()
        {
            StyleRegistry.Unregister(Name);
        }

    }
}
