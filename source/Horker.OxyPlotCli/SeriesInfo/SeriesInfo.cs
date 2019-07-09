﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.Series;

namespace Horker.OxyPlotCli
{
    public class SeriesInfo<SeriesT> : ISeriesInfo
        where SeriesT: Series
    {
        IList<Series> ISeriesInfo.Series { get => Series.Cast<Series>().ToList(); set => Series = (IList<SeriesT>)value; }
        public IList<SeriesT> Series { get; set; }

        public string[] AxisTitles { get; set; }
        public Type[] AxisTypes { get; set; }
        public string GroupName { get; set; }
        public string[] CategoryNames { get; set; }

        public SeriesInfo()
        {
            AxisTitles = new string[] { null, null, null };
            AxisTypes = new Type[] { null, null, null };
        }
    }
}