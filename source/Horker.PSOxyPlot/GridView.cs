using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace Horker.PSOxyPlot
{
    public class GridView
    {
        private List<PlotModel> _models;
        private List<double> _widths;
        private List<double> _heights;

        public List<PlotModel> Models => _models;
        public List<double> Widths => _widths;
        public List<double> Heights => _heights;

        public GridView()
        {
            _models = new List<PlotModel>();
            _widths = new List<double>();
            _heights = new List<double>();
        }

        public void AddModels(object[] models)
        {
            foreach (var model in models)
                AddModel(model);
        }

        private void AddModel(object modelOrSeries)
        {
            Array items;
            if (modelOrSeries is Array array)
                items = array;
            else
                items = new object[] { modelOrSeries };

            PlotModel model = null;
            foreach (var item in items)
            {
                var i = item;
                if (item is PSObject psobj)
                    i = psobj.BaseObject;

                if (i is PlotModel m)
                {
                    _models.Add(m);
                }
                else if (i is Series series)
                {
                    if (model == null)
                        model = new PlotModel();
                    model.Series.Add(series);
                }
                else
                    throw new ArgumentException("Specify a PlotModel, a Series or an array of these objects as argument");
            }

            if (model != null)
                _models.Add(model);

        }

        public void SetWidths(params double[] widths)
        {
            _widths = new List<double>(widths);
        }

        public void SetWidths(params object[] widths)
        {
            foreach (var w in widths)
            {
                var ww = w;
                if (w is PSObject psobj)
                    ww = psobj.BaseObject;

                _widths.Add(SmartConverter.ToDouble(ww));
            }
        }

        public void SetHeights(params double[] heights)
        {
            _heights = new List<double>(heights);
        }

        public void SetHeights(params object[] heights)
        {
            foreach (var h in heights)
            {
                var hh = h;
                if (h is PSObject psobj)
                    hh = psobj.BaseObject;

                _heights.Add(SmartConverter.ToDouble(hh));
            }
        }

        public Tuple<IList<double>, IList<double>> GetAdjustedWidthHeight()
        {
            IList<double> w = _widths;
            IList<double> h = _heights;

            if (_widths.Count == 0)
            {
                if (_heights.Count == 0)
                {
                    var wc = (int)Math.Ceiling(Math.Sqrt(_models.Count));
                    var hc = (int)Math.Ceiling((double)_models.Count / wc);

                    w = Enumerable.Range(0, wc).Select(x => 1.0).ToList<double>();
                    h = Enumerable.Range(0, hc).Select(x => 1.0).ToList<double>();
                }
                else
                {
                    var wc = (int)Math.Ceiling((double)_models.Count / _heights.Count);
                    w = Enumerable.Range(0, wc).Select(x => 1.0).ToList<double>();
                }
            }
            else
            {
                if (_heights.Count == 0)
                {
                    var hc = (int)Math.Ceiling((double)_models.Count / _widths.Count);
                    h = Enumerable.Range(0, hc).Select(x => 1.0).ToList<double>();
                }
            }

            return Tuple.Create(w, h);
        }

        public void Save(string path, int width = 800, int height = 600)
        {
            var svgString = GridViewExporter.ExportToSvgString(this, width, height);

            using (var f = new StreamWriter(path))
            {
                f.Write(svgString);
            }
        }
    }
}
