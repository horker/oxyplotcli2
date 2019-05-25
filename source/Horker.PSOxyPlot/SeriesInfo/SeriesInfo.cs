using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.Series;

namespace Horker.PSOxyPlot
{
    public class SeriesInfo<SeriesT> : ISeriesInfo
        where SeriesT: Series
    {
        Series[] ISeriesInfo.Series { get => Series; set => Series = (SeriesT[])value; }
        public SeriesT[] Series { get; set; }

        public string[] AxisTitles { get; set; }
        public Type[] DataTypes { get; set; }
        public string GroupName { get; set; }
        public string[] CategoryNames { get; set; }

        public SeriesInfo()
        {
            AxisTitles = new string[] { null, null };
            DataTypes = new Type[] { null, null };
        }
    }
}
