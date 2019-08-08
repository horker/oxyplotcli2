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
    [Cmdlet("Set", "OxyPlotViewDispatcher")]
    [OutputType(typeof(void))]
    public class SetOxyPlotViewDispatcher : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true)]
        public Dispatcher Dispatcher = null;

        protected override void BeginProcessing()
        {
            PlotViewDispatcherHolder.Set(Dispatcher);
        }
    }
}
