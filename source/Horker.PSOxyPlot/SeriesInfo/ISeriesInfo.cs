using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.Series;

namespace Horker.PSOxyPlot
{
    public interface ISeriesInfo
    {
        IList<Series> Series { get; set;  }
        string[] AxisTitles { get; set; }
        AxisType[] AxisTypes { get; set; }
        string GroupName { get; set; }
        string[] CategoryNames { get; set; }
    }
}
