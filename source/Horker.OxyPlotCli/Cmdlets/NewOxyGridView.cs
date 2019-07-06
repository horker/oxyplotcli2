using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;

namespace Horker.OxyPlotCli.Cmdlets
{
    [Cmdlet("New", "OxyGridView")]
    [Alias("oxy.gridView")]
    [OutputType(typeof(GridView))]
    public class NewOxyGridView : SeriesCmdletBase
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

        [Parameter(Position = 5, Mandatory = false)]
        public string OutFile = null;

        [Parameter(Position = 6, Mandatory = false)]
        public int OutWidth = 800;

        [Parameter(Position = 7, Mandatory = false)]
        public int OutHeight = 600;

        [Parameter(Position = 8, Mandatory = false)]
        public SwitchParameter SvgIsDocument = false;

        [Parameter(Position = 9, Mandatory = false)]
        public SwitchParameter PassThru = false;

        [Parameter(Position = 10, Mandatory = false)]
        public string Style = null;

        [Parameter(Position = 11, Mandatory = false)]
        public SwitchParameter Show = false;

        [Parameter(Position = 12, Mandatory = false)]
        public SwitchParameter ReuseWindow = false;

        protected override void BeginProcessing()
        {
            var style = TypeAdaptors.Style.ConvertFrom(Style);

            var grid = new GridView(style);

            grid.AddModels(Models);

            if (MyInvocation.BoundParameters.ContainsKey("Widths"))
                grid.SetWidths(Widths);

            if (MyInvocation.BoundParameters.ContainsKey("Heights"))
                grid.SetHeights(Heights);

            if (MyInvocation.BoundParameters.ContainsKey("ColumnCount"))
                grid.SetWidths(Enumerable.Range(0, ColumnCount).Select(x => 1.0).ToArray());

            if (MyInvocation.BoundParameters.ContainsKey("RowCount"))
                grid.SetHeights(Enumerable.Range(0, RowCount).Select(x => 1.0).ToArray());

            if (MyInvocation.BoundParameters.ContainsKey("OutFile"))
                GridViewExporter.Export(grid, OutFile, OutWidth, OutHeight, SvgIsDocument);

            if (Show)
            {
                var control = grid.ToGridControl();

                var window = CreateWindow(ReuseWindow);

                window.Dispatcher.Invoke(() => {
                    window.Content = control;
                    if (string.IsNullOrEmpty(window.Title))
                        window.Title = MyInvocation.Line;
                });
            }

            if (!MyInvocation.BoundParameters.ContainsKey("OutFile") && !Show)
                WriteObject(grid);
        }
    }
}
