using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Horker.OxyPlotCli.Helpers;
using Horker.OxyPlotCli.Initializers;
using Horker.OxyPlotCli.SeriesBuilders;
using Horker.OxyPlotCli.Styles;
using Horker.OxyPlotCli.Wpf;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.OxyPlotCli.Cmdlets
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

        protected System.Windows.Window CreateWindow(bool reuseWindow)
        {
            System.Windows.Window window = null;

            if (reuseWindow)
            {
                var windows = WpfWindow.WindowList;
                if (windows.Count > 0)
                    window = windows.Last();
            }

            if (window == null)
                window = WpfWindow.OpenWindow(null, null, null);

            return window;
        }

        protected void PostProcess(PlotModel model, IList<ISeriesInfo> siList, string outFile, int outWidth, int outHeight, bool svgIsDocument, bool passThru, Style style, bool asPlotView, bool show, bool reuseWindow)
        {
            var bp = MyInvocation.BoundParameters;

            var si = siList != null && siList.Count > 0 ? siList[0] : null;

            // When Ax/Ay parameters are specified, creates axis objects.

            Axis xAxis = null;
            Axis yAxis = null;
            Axis zAxis = null;
            if (si?.Series?.Count > 0)
            {
                xAxis = AxisInitializer.CreateWithPrefixedParameters(bp, AxisKind.Ax, si.Series[0], si, style);
                yAxis = AxisInitializer.CreateWithPrefixedParameters(bp, AxisKind.Ay, si.Series[0], si, style);
                zAxis = AxisInitializer.CreateWithPrefixedParameters(bp, AxisKind.Az, si.Series[0], si, style);
            }

            // Creates a model if necessary.

            if (model == null && (!string.IsNullOrEmpty(outFile) || xAxis != null || yAxis != null || zAxis != null || asPlotView || show))
                model = PlotModelInitializer.Create(siList, style);

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

            foreach (var si2 in siList)
            {
                foreach (var s in si2.Series)
                {
                    model.Series.Add(s);
/*
                    if (s is XYAxisSeries xy)
                    {
                        if (xAxis != null)
                            xy.XAxisKey = xAxis.Key;

                        if (yAxis != null)
                            xy.YAxisKey = yAxis.Key;
                    }
*/
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
            }

            // Export a model.

            if (bp.ContainsKey("OutFile"))
                ModelExporter.Export(model, outFile, outWidth, outHeight, svgIsDocument);

            // Show a model in the window;

            if (show)
            {
                var window = CreateWindow(reuseWindow);

                window.Dispatcher.Invoke(() => {
                    window.Content = new OxyPlot.Wpf.PlotView() { Model = model };
                    if (!reuseWindow && string.IsNullOrEmpty(window.Title))
                        window.Title = MyInvocation.Line;
                });
            }

            // Return a model.

            if (asPlotView)
            {
                OxyPlot.Wpf.PlotView e = null;
                PlotViewDispatcherHolder.Get().Invoke(() => {
                    e = new OxyPlot.Wpf.PlotView() { Model = model };
                });
                WriteObject(e);
            }
            else
            {
                if (passThru || (!bp.ContainsKey("OutFile") && !show))
                    WriteObject(model);
            }
        }
    }
}
