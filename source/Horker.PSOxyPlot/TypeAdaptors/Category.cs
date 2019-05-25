using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class Category
    {
        public string CategoryName { get; private set; }

        public Category()
        { }

        public Category(string categoryname)
        {
            CategoryName = categoryname;
        }

        public static implicit operator string(Category category)
        {
            return category.CategoryName;
        }
    }
}
