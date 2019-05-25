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
        Series[] Series { get; set;  }
        string[] AxisTitles { get; set; }
        Type[] DataTypes { get; set; }
        string GroupName { get; set; }
        string[] CategoryNames { get; set; }
    }
}
