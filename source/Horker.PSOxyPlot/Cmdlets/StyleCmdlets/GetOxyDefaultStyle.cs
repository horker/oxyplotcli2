using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Horker.OxyPlotCli.Styles;

namespace Horker.OxyPlotCli.Cmdlets
{
    [Cmdlet("Get", "OxyDefaultStyle")]
    public class GetOxyDefaultStyle : PSCmdlet
    {
        protected override void BeginProcessing()
        {
            WriteObject(StyleRegistry.DefaultStyle);
        }
    }
}
