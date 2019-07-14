using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.Axes;

namespace Horker.OxyPlotCli.Initializers
{
    public enum AxisKind
    {
        Ax = 0,
        Ay = 1,
        Az = 2
    };

    public static class AxisKindExtension
    {
        public static string GetParameterPrefix(this AxisKind kind)
        {
            switch (kind)
            {
                case AxisKind.Ax:
                    return "Ax";
                case AxisKind.Ay:
                    return "Ay";
                case AxisKind.Az:
                    return "Az";
                default:
                    throw new ArgumentException($"Unknown axis kind: {kind}");
            }
        }

        public static AxisPosition GetDefaultPosition(this AxisKind kind)
        {
            switch (kind)
            {
                case AxisKind.Ax:
                    return AxisPosition.Bottom;
                case AxisKind.Ay:
                    return AxisPosition.Left;
                case AxisKind.Az:
                    return AxisPosition.Right;
                default:
                    throw new ArgumentException($"Unknown axis kind: {kind}");
            }
        }
    }
}
