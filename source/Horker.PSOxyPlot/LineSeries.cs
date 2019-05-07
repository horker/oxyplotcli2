using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using OxyPlot;
using OxyPlot.Series;

namespace Horker.PSOxyPlot
{
    [Cmdlet("New", "OxyLineSeries2")]
    [Alias("oxy.line2")]
    [OutputType(typeof(LineSeries))]
    public class NewOxyLineSeries2 : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true)]
        public PSObject InputObject;

        [Parameter(Position = 0, Mandatory = false)]
        public string XName = "X";

        [Parameter(Position = 1, Mandatory = false)]
        public string YName = "Y";

        [Parameter(Position = 99, Mandatory = false)]
        public PlotModel AddTo = null;

        private List<double> _x;
        private List<double> _y;

        protected override void BeginProcessing()
        {
            _x = new List<double>();
            _y = new List<double>();
        }

        protected override void ProcessRecord()
        {
            _x.Add(SmartConverter.ToDouble(InputObject.Properties[XName].Value));
            _y.Add(SmartConverter.ToDouble(InputObject.Properties[YName].Value));
        }

        protected override void EndProcessing()
        {
            var series = new LineSeries();

            var xEnum = _x.GetEnumerator();
            var yEnum = _y.GetEnumerator();
            while (xEnum.MoveNext() && yEnum.MoveNext())
            {
                var x = xEnum.Current;
                var y = yEnum.Current;
                series.Points.Add(new DataPoint(x, y));
            }

            if (MyInvocation.BoundParameters.ContainsKey("AddTo"))
            {
                var model = AddTo ?? new PlotModel();
                model.Series.Add(series);
            }
            else
            {
                WriteObject(series);
            }
        }
    }
}
