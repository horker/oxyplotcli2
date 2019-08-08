using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using Horker.OxyPlotCli.Helpers;

namespace Horker.OxyPlotCli.Cmdlets
{
    [Cmdlet("Get", "OxyPlotViewDispatcher")]
    [OutputType(typeof(Dispatcher))]
    public class GetOxyPlotViewDispatcher : PSCmdlet
    {
        protected override void BeginProcessing()
        {
            WriteObject(PlotViewDispatcherHolder.Get());
        }
    }
}
