using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.SeriesBuilders
{
    public interface ISeriesBuilder
    {
        Type SeriesType { get; }
        string[] DataPointItemNames { get; }
        bool[] DataPointItemMandatoriness { get; }
        int[] AxisItemIndexes { get; }
        Type[] DefaultAxisTypes { get; }
        string[] Aliases { get; }
    }
}
