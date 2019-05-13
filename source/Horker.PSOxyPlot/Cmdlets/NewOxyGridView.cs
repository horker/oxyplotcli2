using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;

namespace Horker.PSOxyPlot
{
    [Cmdlet("New", "OxyGridView")]
    [Alias("oxy.grid")]
    [OutputType(typeof(GridView))]
    public class NewOxyGridView : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public object[] Models;

        [Parameter(Position = 1, Mandatory = false)]
        public double[] Widths;

        [Parameter(Position = 2, Mandatory = false)]
        public double[] Heights;

        [Parameter(Position = 3, Mandatory = false)]
        public int ColumnCount;

        [Parameter(Position = 4, Mandatory = false)]
        public int RowCount;

        protected override void BeginProcessing()
        {
            var grid = new GridView();

            grid.AddModels(Models);

            if (MyInvocation.BoundParameters.ContainsKey("Widths"))
                grid.SetWidths(Widths);

            if (MyInvocation.BoundParameters.ContainsKey("Heights"))
                grid.SetHeights(Heights);

            if (MyInvocation.BoundParameters.ContainsKey("ColumnCount"))
                grid.SetWidths(Enumerable.Range(0, ColumnCount).Select(x => 1.0).ToArray());

            if (MyInvocation.BoundParameters.ContainsKey("RowCount"))
                grid.SetHeights(Enumerable.Range(0, RowCount).Select(x => 1.0).ToArray());

            WriteObject(grid);
        }
    }
}
