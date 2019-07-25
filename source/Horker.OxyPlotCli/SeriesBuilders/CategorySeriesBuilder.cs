using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.Series;

namespace Horker.OxyPlotCli.SeriesBuilders
{
    public abstract class CategorySeriesBuilder<SeriesT, DataPointT, E1, E2, E3, E4, E5, E6, E7, E8> : SeriesBuilder<SeriesT, DataPointT, E1, E2, E3, E4, E5, E6, E7, E8>
        where SeriesT : Series, new()
    {
        private List<string> _categories = new List<string>();

        protected int GetCategoryIndex(TypeAdaptors.Category category)
        {
            var index = _categories.FindIndex(x => x == category.CategoryName);
            if (index == -1)
            {
                index = _categories.Count;
                _categories.Add(category);
            }

            return index;
        }

        protected override string[] GetCategoryNames()
        {
            return _categories.ToArray();
        }
    }
}