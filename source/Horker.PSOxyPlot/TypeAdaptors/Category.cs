using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.OxyPlotCli.TypeAdaptors
{
    public class Category
    {
        public string CategoryName { get; private set; }

        public Category()
        { }

        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }

        public static Category Create(object value)
        {
            return new Category((string)value);
        }

        public static implicit operator string(Category category)
        {
            return category.CategoryName;
        }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
