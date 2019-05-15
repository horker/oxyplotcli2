using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace Horker.PSOxyPlot
{
    internal class PointFactory
    {
        public static DataPoint CreateLineSeriesPoint(Dictionary<string, object> boundParameters, PSObject inputObject)
        {
            var x = SmartConverter.ToDouble(inputObject.Properties[(string)boundParameters["XName"]].Value);
            var y = SmartConverter.ToDouble(inputObject.Properties[(string)boundParameters["YName"]].Value);
            return new DataPoint(x, y);
        }

        public static void AddLineSeriesPoints(LineSeries series, Dictionary<string, object> boundParameters)
        {
            var x = (double[])boundParameters["X"];
            var y = (double[])boundParameters["Y"];
            for (var i = 0; i < x.Length; ++i)
                series.Points.Add(new DataPoint(x[i], y[i]));
        }

        public static ScatterPoint CreateScatterSeriesPoint(Dictionary<string, object> boundParameters, PSObject inputObject)
        {
            var x = SmartConverter.ToDouble(inputObject.Properties[(string)boundParameters["XName"]].Value);
            var y = SmartConverter.ToDouble(inputObject.Properties[(string)boundParameters["YName"]].Value);
            return new ScatterPoint(x, y);
        }

        public static void AddScatterSeriesPoints(ScatterSeries series, Dictionary<string, object> boundParameters)
        {
            var x = (double[])boundParameters["X"];
            var y = (double[])boundParameters["Y"];
            for (var i = 0; i < x.Length; ++i)
                series.Points.Add(new ScatterPoint(x[i], y[i]));
        }
    }
}
