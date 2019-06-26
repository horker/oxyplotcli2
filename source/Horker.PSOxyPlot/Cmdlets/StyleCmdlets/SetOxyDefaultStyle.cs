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

        protected override void BeginProcessing()
        {
            StyleRegistry.DefaultStyle = Style;
        }
    }
}
