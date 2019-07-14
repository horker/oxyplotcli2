using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horker.OxyPlotCli.SeriesBuilders;
using Horker.OxyPlotCli.Styles;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.OxyPlotCli.Initializers
{
    public static class AxisInitializer
    {
        private static List<Type> _axisClasses;

        static AxisInitializer()
        {
            _axisClasses = new List<Type>();

            var types = typeof(LinearAxis).Assembly.GetTypes().Where(t => t.IsPublic && !t.IsAbstract && t.Name.EndsWith("Axis"));

            foreach (var t in types)
                _axisClasses.Add(t);
        }

        private static Type GetAxisTypeByPartialName(string typeName)
        {
            var n = typeName.ToLower();
            var matches = _axisClasses.Where(t => t.Name.ToLower().IndexOf(n) == 0).ToList();

            if (matches.Count == 0)
                throw new ArgumentException($"No axis types found for '{typeName}'");

            // Returns found first 
            return matches[0];
        }

        private static Axis GetDefaultAxisObject(AxisKind axisKind, Series series, ISeriesInfo seriesInfo, Type userSpecifiedAxisType, Style style)
        {
            // Determine the axis type.

            Type axisType = userSpecifiedAxisType ?? seriesInfo?.AxisTypes[(int)axisKind];

            if (axisType == SeriesBuilderStore.OfType(series.GetType()).DefaultAxisTypes[(int)axisKind])
                axisType = null;

            // Create an axis instance.

            Axis axis;
            if (axisType != null)
            {
                axis = (Axis)axisType.GetConstructor(new Type[0]).Invoke(new object[0]);
                axis.Position = axisKind.GetDefaultPosition();
            }
            else
            {
                axis = SeriesBuilderStore.OfType(series.GetType()).GetDefaultAxisObject(axisKind);
            }

            if (axisKind == AxisKind.Az && series is CandleStickAndVolumeSeries candlev)
            {
                var key = "Volume Axis_" + Guid.NewGuid().ToString();
                axis.Key = key;
                candlev.VolumeAxisKey = axis.Key;
            }

            if (axis != null)
            {
                var title = seriesInfo?.AxisTitles[(int)axisKind];
                if (!string.IsNullOrEmpty(title))
                    axis.Title = title;

                if (axis is CategoryAxis ca && seriesInfo?.CategoryNames != null)
                {
                    foreach (var n in seriesInfo.CategoryNames)
                        ca.Labels.Add(n);
                }

                style.ApplyStyleTo(axis);
            }

            return axis;
        }

        public static void EnsureAxes(PlotModel model, ISeriesInfo si, Style style)
        {
            if (!string.IsNullOrEmpty(si?.GroupName) && string.IsNullOrEmpty(model.LegendTitle))
                model.LegendTitle = si.GroupName;

            bool hasXAxis = false;
            bool hasYAxis = false;
            bool hasZAxis = false;

            foreach (var s in model.Series)
            {
                if (!s.IsVisible)
                    continue;

                if (s is XYAxisSeries xy)
                {
                    hasXAxis = hasXAxis || !string.IsNullOrEmpty(xy.XAxisKey) || xy.XAxis != null || model.Axes.Any(a => a.IsXyAxis() && a.IsHorizontal());
                    hasYAxis = hasYAxis || !string.IsNullOrEmpty(xy.YAxisKey) || xy.YAxis != null || model.Axes.Any(a => a.IsXyAxis() && a.IsVertical());
                }

                // CandleStickAndVolumeSeries doesn't remain VolumeAxisKey to be null.
                if (s is CandleStickAndVolumeSeries candlev)
                    hasZAxis = hasZAxis || !string.IsNullOrEmpty(candlev.VolumeAxisKey) || candlev.VolumeAxis != null;
                else if (s is HeatMapSeries h)
                    hasZAxis = hasZAxis || !string.IsNullOrEmpty(h.ColorAxisKey) || h.ColorAxis != null;
                else if (s is RectangleSeries r)
                    hasZAxis = hasZAxis || !string.IsNullOrEmpty(r.ColorAxisKey) || r.ColorAxis != null;
            }

            if (!hasXAxis)
            {
                foreach (var s in si?.Series ?? model.Series)
                {
                    if (s.IsVisible)
                    {
                        var ax = GetDefaultAxisObject(AxisKind.Ax, s, si, null, style);
                        if (ax != null)
                        {
                            model.Axes.Add(ax);
                            break;
                        }
                    }
                }
            }

            if (!hasYAxis)
            {
                foreach (var s in si?.Series ?? model.Series)
                {
                    if (s.IsVisible)
                    {
                        var ay = GetDefaultAxisObject(AxisKind.Ay, s, si, null, style);
                        if (ay != null)
                        {
                            model.Axes.Add(ay);
                            break;
                        }
                    }
                }
            }

            if (!hasZAxis)
            {
                foreach (var s in si?.Series ?? model.Series)
                {
                    if (s.IsVisible)
                    {
                        var az = GetDefaultAxisObject(AxisKind.Az, s, si, null, style);
                        if (az != null)
                        {
                            model.Axes.Add(az);
                            break;
                        }
                    }
                }
            }
        }

        public static void AssignParameters(Axis axis, Dictionary<string, object> parameters, string prefix)
        {
            foreach (var prop in axis.GetType().GetProperties())
            {
                if (!prop.CanWrite || prop.SetMethod == null || !prop.SetMethod.IsPublic)
                    continue;

                if (!parameters.TryGetValue(prefix + prop.Name, out var value))
                    continue;

                prop.SetValue(axis, TypeAdaptors.Helpers.StripOffTypeAdaptors(value));
            }
        }

        public static Axis CreateWithPrefixedParameters(Dictionary<string, object> parameters, AxisKind axisKind, Series series, ISeriesInfo seriesInfo, Style style)
        {
            var prefix = axisKind.GetParameterPrefix();

            // Check if any parameters with the prefix are specified. If not, return without do anything.

            bool create = false;
            foreach (var entry in parameters)
            {
                if (entry.Key.StartsWith(prefix) && char.IsUpper(entry.Key[2]))
                {
                    create = true;
                    break;
                }
            }

            if (!create)
                return null;

            // Determine the user specified axis type.

            Type axisType = null;
            if (parameters.TryGetValue(prefix + "Type", out var typeName))
                axisType = GetAxisTypeByPartialName(typeName.ToString());

            // Create an axis instance.

            Axis axis = GetDefaultAxisObject(axisKind, series, seriesInfo, axisType, style);

            // Assign the command-line parameters to the axis.

            AssignParameters(axis, parameters, prefix);

            return axis;
        }
    }
}
