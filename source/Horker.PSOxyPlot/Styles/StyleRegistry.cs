using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.Styles
{
    public static class StyleRegistry
    {
        private static Dictionary<string, Style> _styles;

        public static readonly string FallbackStyleName = "__fallback__";

        public static string DefaultStyleName { get; set; }
        public static Style DefaultStyle
        {
            get => _styles[DefaultStyleName];
            set => _styles[DefaultStyleName] = value;
        }

        static StyleRegistry()
        {
            _styles = new Dictionary<string, Style>();

            var fallbackStyle = Style.Create(new Dictionary<string, object>()
            {
                {
                    "PieSeries.Diameter", .75
                },
                {
                    "CategoryAxis.*",
                    new Action<object>(value => {
                        var axis = (CategoryAxis)value;
                        if (axis.IsHorizontal() && axis.Labels.Max(x => x.Length) >= 3) 
                            axis.Angle = -45;
                    })
                },
                {
                    "DateTimeAxis.*",
                    new Action<object>(value => {
                        var axis = (DateTimeAxis)value;
                        if (axis.IsHorizontal())
                            axis.Angle = -45;
                    })
                },
                {
                    "TimeSpanAxis.*",
                    new Action<object>(value => {
                        var axis = (TimeSpanAxis)value;
                        if (axis.IsHorizontal())
                            axis.Angle = -45;
                    })
                }
            });

            _styles.Add(FallbackStyleName, fallbackStyle);

            DefaultStyleName = FallbackStyleName;
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
