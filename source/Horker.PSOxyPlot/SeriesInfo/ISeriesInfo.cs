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
        Series[] GetSeries();
    }
}
