using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.Styles
{
    public static class StyleRegistry
    {
        private static Dictionary<string, Style> _styles;

        public static IEnumerable<Style> Styles => _styles.Values;

        public static readonly string FallbackStyleName = "__fallback__";
        public static readonly string VanillaStyleName = "vanilla";

        public static Style FallbackStyle { get; private set; }
        public static Style VanillaStyle { get; private set; }

        public static string DefaultStyleName { get; set; } = VanillaStyleName;

        public static Style DefaultStyle
        {
            get => _styles[DefaultStyleName];
            set => DefaultStyleName = value.Name;
        }

        static StyleRegistry()
        {
            _styles = new Dictionary<string, Style>();

            // Fallback style:
            // Implements scripts applying color scheme. To make color schemes work correctly, every style should inherit this style.

            var fallbackStyle = Style.Create(FallbackStyleName, new Dictionary<string, object>()
            {
                // CandleStickSeries

                {
                    "CandleStickSeries.IncreasingColor",
                    new Action<object, Style>((target, style) => {
                        var series = (CandleStickSeries)target;
                        series.IncreasingColor = style.ColorScheme.GetCandleStickColors().Item1;
                    })
                },
                {
                    "CandleStickSeries.DecreasingColor",
                    new Action<object, Style>((target, style) => {
                        var series = (CandleStickSeries)target;
                        series.DecreasingColor = style.ColorScheme.GetCandleStickColors().Item2;
                    })
                },

                // CandleStickAndVolumeSeries

                {
                    "CandleStickAndVolumeSeries.PositiveColor",
                    new Action<object, Style>((target, style) => {
                        var series = (CandleStickAndVolumeSeries)target;
                        series.PositiveHollow = false;
                        series.PositiveColor = style.ColorScheme.GetCandleStickColors().Item1;
                    })
                },
                {
                    "CandleStickAndVolumeSeries.NegativeColor",
                    new Action<object, Style>((target, style) => {
                        var series = (CandleStickAndVolumeSeries)target;
                        series.NegativeColor = style.ColorScheme.GetCandleStickColors().Item2;
                    })
                },

                // ThreeColorLineSeries

                {
                    "ThreeColorLineSeries.Color",
                    new Action<object, Style>((target, style) => {
                        var series = (ThreeColorLineSeries)target;
                        series.Color = OxyColors.Automatic;
                    })
                },
                {
                    "ThreeColorLineSeries.ColorHi",
                    new Action<object, Style>((target, style) => {
                        var series = (ThreeColorLineSeries)target;
                        series.ColorHi = OxyColors.Automatic;
                    })
                },
                {
                    "ThreeColorLineSeries.ColorLo",
                    new Action<object, Style>((target, style) => {
                        var series = (ThreeColorLineSeries)target;
                        series.ColorLo = OxyColors.Automatic;
                    })
                },

                // TornardoBarSeries

                {
                    "TornadoBarSeries.MinimumFillColor",
                    new Action<object, Style>((target, style) => {
                        var series = (TornadoBarSeries)target;
                        series.MinimumFillColor = OxyColors.Automatic;
                    })
                },
                {
                    "TornadoBarSeries.MaximumFillColor",
                    new Action<object, Style>((target, style) => {
                        var series = (TornadoBarSeries)target;
                        series.MaximumFillColor = OxyColors.Automatic;
                    })
                },

                // TwoColorAreaSeries

                {
                    "TwoColorAreaSeries.Color",
                    new Action<object, Style>((target, style) => {
                        var series = (TwoColorAreaSeries)target;
                        series.Color = OxyColors.Automatic;
                    })
                },
                {
                    "TwoColorAreaSeries.Color2",
                    new Action<object, Style>((target, style) => {
                        var series = (TwoColorAreaSeries)target;
                        series.Color2 = OxyColors.Automatic;
                    })
                },

                // TwoColorLineSeries

                {
                    "TwoColorLineSeries.Color",
                    new Action<object, Style>((target, style) => {
                        var series = (TwoColorLineSeries)target;
                        series.Color = OxyColors.Automatic;
                    })
                },
                {
                    "TwoColorLineSeries.Color2",
                    new Action<object, Style>((target, style) => {
                        var series = (TwoColorLineSeries)target;
                        series.Color2 = OxyColors.Automatic;
                    })
                },

                // LinearColorSeries

                {
                    "LinearColorAxis.Palette",
                    new Action<object, Style>((target, style) => {
                        var axis = (LinearColorAxis)target;
                        axis.Palette = style.ColorScheme.GetColorAxisPalette(axis);
                    })
                },

                // VolumeSeries

                {
                    "VolumeSeries.PositiveColor",
                    new Action<object, Style>((target, style) => {
                        var series = (VolumeSeries)target;
                        series.PositiveHollow = false;
                        series.PositiveColor = style.ColorScheme.GetCandleStickColors().Item1;
                    })
                },
                {
                    "VolumeSeries.NegativeColor",
                    new Action<object, Style>((target, style) => {
                        var series = (VolumeSeries)target;
                        series.NegativeColor = style.ColorScheme.GetCandleStickColors().Item2;
                    })
                },


            }, null);

            FallbackStyle = fallbackStyle;
            _styles.Add(FallbackStyleName, fallbackStyle);

            // Vanilla style:
            // Minimum settings for proper display.

            var vanillaStyle = Style.Create(VanillaStyleName, new Dictionary<string, object>()
            {
                // PieSeries

                {
                    "PieSeries.Diameter", .75
                },

                // CategoryAxis

                {
                    "CategoryAxis.Angle",
                    new Action<object, Style>((target, style) => {
                        var axis = (CategoryAxis)target;
                        if (axis.IsHorizontal() && axis.Labels.Max(x => x.Length) >= 3) 
                            axis.Angle = -45;
                    })
                },

                // DatetimeAxis

                {
                    "DateTimeAxis.Angle",
                    new Action<object, Style>((target, style) => {
                        var axis = (DateTimeAxis)target;
                        if (axis.IsHorizontal())
                            axis.Angle = -45;
                    })
                },

                // TimeSpanAxis

                {
                    "TimeSpanAxis.Angle",
                    new Action<object, Style>((target, style) => {
                        var axis = (TimeSpanAxis)target;
                        if (axis.IsHorizontal())
                            axis.Angle = -45;
                    })
                }
            }, fallbackStyle);

            VanillaStyle = vanillaStyle;
            _styles.Add(VanillaStyleName, vanillaStyle);

            // Empty style

            var emptyStyle = Style.Create("empty", new Dictionary<string, object>(), null);
            _styles.Add("empty", emptyStyle);
        }

        public static void Register(string name, Style style)
        {
            _styles[name] = style;
        }

        public static void Unregister(string name)
        {
            _styles.Remove(name);
        }

        public static Style Get(string name)
        {
            if (string.IsNullOrEmpty(name))
                return DefaultStyle;

            if (_styles.TryGetValue(name, out var style))
                return style;

            throw new ArgumentException($"No style found: '{name}'");
        }
    }
}
