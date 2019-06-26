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

        [Parameter(Position = 1, Mandatory = true)]
        public Hashtable Config;

        protected override void BeginProcessing()
        {
            var style = Style.Create(Config);
            StyleRegistry.Register(Name, style);
        }
    }
}
