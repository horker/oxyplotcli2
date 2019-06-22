using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class TwoDimensionalArray
    {
        public double[,] Value { get; private set; }

        public TwoDimensionalArray()
        {
            Value = new double[0, 0];
        }

        public TwoDimensionalArray(double[,] values)
        {
            Value = values;
        }

        public TwoDimensionalArray(double[][] values)
        {
            var columnLength = values[0].Length;
            var result = new double[values.Length, columnLength];

            for (var i = 0; i < values.Length; ++i)
            {
                var row = values[i];
                for (var j = 0; j < columnLength; ++j)
                {
                    result[i, j] = row[j];
                }
            }

            Value = result;
        }

        public static implicit operator double[,](TwoDimensionalArray value)
        {
            return value.Value;
        }

        public static double[,] ConvertFrom(object value)
        {
            if (value is PSObject pso)
                value = pso.BaseObject;

            if (value is double[,] array2d)
                return array2d;

            if (value is double[][] jaggedDouble)
                return ConvertFrom(jaggedDouble);

            if (value is object[] jagged)
                return ConvertFrom(jagged);

            throw new ArgumentException("Failed to convert to a two-dimensional array");
        }

        public static double[,] ConvertFrom(double[][] values)
        {
            var columnLength = values[0].Length;
            var result = new double[values.Length, columnLength];

            for (var i = 0; i < values.Length; ++i)
            {
                var row = values[i];
                for (var j = 0; j < columnLength; ++j)
                {
                    result[i, j] = row[j];
                }
            }

            return result;
        }

        public static double[,] ConvertFrom(object[] values)
        {
            var first = values[0];
            if (first is PSObject pso)
                first = pso.BaseObject;

            if (!(first is Array firstRow))
                throw new ArgumentException("Failed to convert to a two-dimensional array");

            var columnLength = firstRow.Length;
            var result = new double[columnLength, values.Length];

            for (var i = 0; i < values.Length; ++i)
            {
                var v = values[i];
                if (v is PSObject p)
                    v = p.BaseObject;

                if (!(v is Array row))
                    throw new ArgumentException("Failed to convert to a two-dimensional array");

                var j = 0;
                foreach (var e in row)
                {
                    result[j, i] = SmartConverter.ToDouble(e);
                    ++j;
                }
            }

            return result;
        }
    }
}
