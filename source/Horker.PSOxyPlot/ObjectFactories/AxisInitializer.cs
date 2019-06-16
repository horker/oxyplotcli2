﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horker.PSOxyPlot.SeriesBuilders;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.ObjectFactories
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
            var matches = _axisClasses.Where(t => t.Name.ToLower().IndexOf(typeName) >= 0).ToList();

            if (matches.Count == 0)
                throw new ArgumentException($"No axis types found for '{typeName}'");

            if (matches.Count > 1)
                throw new ArgumentException($"Mulptile axis types found for '{typeName}'");

            return matches[0];
        }

        private static Axis GetAxisObject(Series series, ISeriesInfo si, int index)
        {
            var axisType = si.AxisTypes[index];
            if (axisType == null)
            {
                axisType = SeriesBuilderStore.OfType(series.GetType()).DefaultAxisTypes[index];
                if (axisType == null)
                    return null;
            }

            var axis = (Axis)axisType.GetConstructor(new Type[0]).Invoke(new object[0]);

            if (series is HeatMapSeries hs)
            {
                var colorAxis = (LinearColorAxis)axis;
                var axisKey = Guid.NewGuid().ToString();
                colorAxis.Key = axisKey;
                hs.ColorAxisKey = axisKey;

                colorAxis.Position = AxisPosition.Right;
            }
            else
            {
                if (axis is CategoryAxis ca && si.CategoryNames != null)
                {
                    foreach (var n in si.CategoryNames)
                        ca.Labels.Add(n);
                }

                if (index == 0)
                    axis.Position = AxisPosition.Bottom;
                else
                    axis.Position = AxisPosition.Left;
            }

            return axis;
        }

        public static void WithSeriesInfo(PlotModel model, ISeriesInfo si)
        {
            foreach (var s in model.Series)
            {
                if (s.IsVisible && !string.IsNullOrEmpty(si.GroupName))
                {
                    model.LegendTitle = si.GroupName;
                    break;
                }
            }

            Axis ax = null;
            Axis ay = null;

            foreach (var a in model.Axes)
            {
                if (ax == null && a.IsHorizontal())
                    ax = a;
                else if (ay == null && a.IsVertical())
                    ay = a;
            }

            if (ax == null)
            {
                foreach (var s in si.Series)
                {
                    if (s.IsVisible)
                    {
                        ax = GetAxisObject(s, si, 0);
                        if (ax != null)
                        {
                            ax.Position = AxisPosition.Bottom;
                            model.Axes.Add(ax);
                            break;
                        }
                    }
                }
            }

            if (ay == null)
            {
                foreach (var s in si.Series)
                {
                    if (s.IsVisible)
                    {
                        ay = GetAxisObject(s, si, 1);
                        if (ay != null)
                        {
                            ay.Position = AxisPosition.Left;
                            model.Axes.Add(ay);
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

        public static void AssignParametersToModelAxes(PlotModel model, Dictionary<string, object> parameters)
        {
            foreach (var a in model.Axes)
            {
                if (a.Position == AxisPosition.Top || a.Position == AxisPosition.Bottom)
                    AxisInitializer.AssignParameters(a, parameters, "Ax");
                if (a.Position == AxisPosition.Left || a.Position == AxisPosition.Right)
                    AxisInitializer.AssignParameters(a, parameters, "Ay");
            }
        }
    }
}
