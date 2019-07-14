using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horker.OxyPlotCli.Initializers;
using OxyPlot.Axes;

namespace Horker.OxyPlotCli.SeriesBuilders
{
    public interface ISeriesBuilder
    {
        Type SeriesType { get; }
        string[] DataPointItemNames { get; }
        bool[] DataPointItemMandatoriness { get; }
        int[] AxisItemIndexes { get; }
        Type[] DefaultAxisTypes { get; }
        string[] Aliases { get; }

        Axis GetDefaultAxisObject(AxisKind kind);
    }
}
