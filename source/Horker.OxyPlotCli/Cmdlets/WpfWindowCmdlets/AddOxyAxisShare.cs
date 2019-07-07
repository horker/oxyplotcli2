using System;
using System.Linq;
using System.Management.Automation;
using OxyPlot.Axes;

#pragma warning disable CS1591

namespace Horker.OxyPlotCli.Cmdlets
{
    [Cmdlet("Add", "OxyAxisShare")]
    public class AddOxyAxisShare : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true)]
        public Axis[] Axis { get; set; }

        [Parameter(Position = 1, Mandatory = false)]
        public TypeAdaptors.Double[] Multiplier { get; set; }

        [Parameter(Position = 2, Mandatory = false)]
        public TypeAdaptors.Double[] Offset { get; set; }

        protected override void BeginProcessing()
        {
            double[] multiplier;
            if (Multiplier != null)
            {
                multiplier = TypeAdaptors.Double.ConvertArray(Multiplier);
                if (multiplier.Contains(0.0))
                {
                    WriteError(new ErrorRecord(new ArgumentException(), "Multiplier should not be zero", ErrorCategory.InvalidArgument, null));
                    return;
                }
            }
            else
            {
                multiplier = new double[Axis.Length];
                for (var i = 0; i < multiplier.Length; ++i)
                    multiplier[i] = 1.0;
            }

            double[] offset;
            if (Offset != null)
            {
                offset = TypeAdaptors.Double.ConvertArray(Offset);
            }
            else
            {
                offset = new double[Axis.Length];
                for (var i = 0; i < offset.Length; ++i)
                    offset[i] = 0.0;
            }

            if (Axis.Length != multiplier.Length || multiplier.Length != offset.Length)
            {
                WriteError(new ErrorRecord(new ArgumentException(), "Parameter lengths mismatch", ErrorCategory.InvalidArgument, null));
                return;
            }

            for (var i = 1; i < Axis.Length; ++i) {
                Axis[i].Minimum = (Axis[0].Minimum - offset[0]) / multiplier[0] * multiplier[i] + offset[i];
                Axis[i].Maximum = (Axis[0].Maximum - offset[0]) / multiplier[0] * multiplier[i] + offset[i];
            }

            // defensive copy
            Axis[] sharedAxes = new Axis[Axis.Length];
            Array.Copy(Axis, sharedAxes, Axis.Length);

            bool isInternalChange = false;
            for (var i = 0; i < Axis.Length; ++i)
            {
                Axis[i].AxisChanged += (sender, eventArgs) =>
                {
                    if (isInternalChange)
                        return;

                    var a1 = (Axis)sender;
                    int p;
                    for (p = 0; p < sharedAxes.Length; ++p)
                    {
                        if (Axis[p] == a1)
                            break;
                    }

                    isInternalChange = true;

                    for (var j = 0; j < sharedAxes.Length; ++j)
                    {
                        var a2 = Axis[j];
                        if (a1 == a2)
                            continue;

                        var min = (a1.ActualMinimum - offset[p]) / multiplier[p] * multiplier[j] + offset[j];
                        var max = (a1.ActualMaximum - offset[p]) / multiplier[p] * multiplier[j] + offset[j];

                        a2.Zoom(min, max);
                        a2.PlotModel.InvalidatePlot(false);
                    }

                    isInternalChange = false;
                };
            }

        }

    }
}
