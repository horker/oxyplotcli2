using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;

namespace Horker.PSOxyPlot
{
    [Cmdlet("New", "OxyModel")]
    [Alias("oxy.model")]
    [OutputType(typeof(PlotModel))]
    public class NewOxyModel : PSCmdlet
    {
        protected override void BeginProcessing()
        {
            var model = new PlotModel();
            WriteObject(model);
        }
    }
}
