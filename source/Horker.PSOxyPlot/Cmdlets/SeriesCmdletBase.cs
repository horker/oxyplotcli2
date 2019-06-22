using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Horker.PSOxyPlot.Initializers;
using Horker.PSOxyPlot.SeriesBuilders;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.Cmdlets
{
    public class SeriesCmdletBase : PSCmdlet
    {
        private bool IsAxisParametersSpecified()
        {
            foreach (var entry in MyInvocation.BoundParameters)
            {
                if (entry.Key.StartsWith("Ax") || entry.Key.StartsWith("Ay") || entry.Key.StartsWith("Az"))
                    return true;
            }
            return false;
        }

        protected void PostProcess(PlotModel model, ISeriesInfo si, string outFile, int outWidth, int outHeight, bool svgIsDocument, bool passThru)
        {
            var bp = MyInvocation.BoundParameters;

            // When Ax/Ay parameters are specified, creates axis objects.

            Axis xAxis = null;
            Axis yAxis = null;
            Axis zAxis = null;
            if (si.Series.Count > 0)
            {
                xAxis = AxisInitializer.CreateWithPrefixedParameters(
                    bp,
                    "Ax",
                    si.AxisTypes[0] ?? SeriesBuilderStore.OfType(si.Series[0].GetType()).DefaultAxisTypes[0],
                    AxisPosition.Bottom);

                yAxis = AxisInitializer.CreateWithPrefixedParameters(
                    bp,
                    "Ay",
                    si.AxisTypes[1] ?? SeriesBuilderStore.OfType(si.Series[0].GetType()).DefaultAxisTypes[1],
                    AxisPosition.Left);

                zAxis = AxisInitializer.CreateWithPrefixedParameters(
                    bp,
                    "Az",
                    si.AxisTypes[2] ?? SeriesBuilderStore.OfType(si.Series[0].GetType()).DefaultAxisTypes[2],
                    AxisPosition.Right);
            }

            // Creates a model if necessary.

            if (model == null && (!string.IsNullOrEmpty(outFile) || xAxis != null || yAxis != null || zAxis != null))
                model = PlotModelInitializer.CreateWithSeriesInfo(new ISeriesInfo[] { si });

            // Returns a SeriesInfo object when a model object is not necessary.

            if (model == null)
            {
                WriteObject(si);
                return;
            }

            // Adds series and axes to a model.

            if (xAxis != null)
                model.Axes.Add(xAxis);

            if (yAxis != null)
                model.Axes.Add(yAxis);

            if (zAxis != null)
                model.Axes.Add(zAxis);

            foreach (var s in si.Series)
            {
                model.Series.Add(s);

                if (s is XYAxisSeries xy)
                {
                    if (xAxis != null)
                        xy.XAxisKey = xAxis.Key;

                    if (yAxis != null)
                        xy.YAxisKey = yAxis.Key;
                }

                if (s is CandleStickAndVolumeSeries candlev)
                {
                    if (zAxis != null)
                        candlev.VolumeAxisKey = zAxis.Key;
                }
                else if (s is HeatMapSeries h)
                {
                    if (zAxis != null)
                        h.ColorAxisKey = zAxis.Key;
                }
                else if (s is RectangleSeries r)
                {
                    if (zAxis != null)
                        r.ColorAxisKey = zAxis.Key;
                }
            }

            // Exports a model.

            if (bp.ContainsKey("OutFile"))
            {
                ModelExporter.Export(model, outFile, outWidth, outHeight, svgIsDocument);
                if (!passThru)
                    return;
            }

            // Returns a model.

            WriteObject(model);
        }
    }
}
