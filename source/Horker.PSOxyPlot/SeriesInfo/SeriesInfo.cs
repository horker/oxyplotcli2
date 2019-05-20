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
        Series[] ISeriesInfo.Series => Series;

        public SeriesT[] Series;
        public string XAxisTitle;
        public string YAxisTitle;
        public Type XAxisType;
        public Type YAxisType;
        public string GroupName;
        public string[] CategoryNames;
    }
}
