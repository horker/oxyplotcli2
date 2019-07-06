using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.Series;

namespace Horker.OxyPlotCli
{
    public interface ISeriesInfo
    {
        IList<Series> Series { get; set;  }
        string[] AxisTitles { get; set; }
        Type[] AxisTypes { get; set; }
        string GroupName { get; set; }
        string[] CategoryNames { get; set; }
    }
}
