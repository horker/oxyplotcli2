﻿using System;
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

        public static Type GetAxisTypeByPartialName(string typeName)
        {
            var n = typeName.ToLower();
            var matches = _axisClasses.Where(t => t.Name.ToLower().IndexOf(n) == 0).ToList();

            if (matches.Count == 0)
                throw new ArgumentException($"No axis types found for '{typeName}'");

            // Returns found first 
            return matches[0];
        }

        public static void EnsureAxes(PlotModel model, ISeriesInfo si, Style style)
        {
            if (!string.IsNullOrEmpty(si?.GroupName))
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
                    hasXAxis = hasXAxis || !string.IsNullOrEmpty(xy.XAxisKey);
                    hasYAxis = hasYAxis || !string.IsNullOrEmpty(xy.YAxisKey);
                }

                // CandleStickAndVolumeSeries doesn't remain VolumeAxisKey to be null.
                if (s is CandleStickAndVolumeSeries candlev)
                    hasZAxis = hasZAxis || candlev.VolumeAxis != null;
                else if (s is HeatMapSeries h)
                    hasZAxis = hasZAxis || !string.IsNullOrEmpty(h.ColorAxisKey);
                else if (s is RectangleSeries r)
                    hasZAxis = hasZAxis || !string.IsNullOrEmpty(r.ColorAxisKey);
            }

            if (!hasXAxis)
            {
                foreach (var s in si?.Series ?? model.Series)
                {
                    if (s.IsVisible)
                    {
                        var selector = AxisSelector.GetInstanceOf(s.GetType());
                        var ax = selector.GetXAxisObject(s, si, style);
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
                        var selector = AxisSelector.GetInstanceOf(s.GetType());
                        var ay = selector.GetYAxisObject(s, si, style);
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
                        var selector = AxisSelector.GetInstanceOf(s.GetType());
                        var az = selector.GetAdditionalAxisObject(s, si, style);
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

        public static Axis CreateWithPrefixedParameters(Dictionary<string, object> parameters, string prefix, Type defaultAxisType, AxisPosition position, Style style)
        {
            bool create = false;
            foreach (var entry in parameters)
            {
                if (entry.Key.StartsWith(prefix))
                {
                    create = true;
                    break;
                }
            }

            if (!create)
                return null;

            var axisType = defaultAxisType;
            if (parameters.TryGetValue(prefix + "Type", out var typeName))
                axisType = GetAxisTypeByPartialName(typeName.ToString());

            var axis = (Axis)axisType.GetConstructor(new Type[0]).Invoke(new object[0]);
            axis.Position = position;
            axis.Key = axisType.Name + "_" + Guid.NewGuid().ToString();

            style.ApplyStyleTo(axis);

            AssignParameters(axis, parameters, prefix);

            return axis;
        }
    }
}
