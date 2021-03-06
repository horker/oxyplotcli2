﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Horker.OxyPlotCli.Styles;
using Horker.OxyPlotCli.Wpf;
using OxyPlot;
using OxyPlot.Series;

namespace Horker.OxyPlotCli
{
    using Windows = System.Windows;

    public class GridView
    {
        private List<PlotModel> _models;
        private List<double> _widths;
        private List<double> _heights;
        private Style _style;

        public List<PlotModel> Models => _models;
        public List<double> Widths => _widths;
        public List<double> Heights => _heights;
        public Style Style => _style;

        public GridView(Style style)
        {
            _models = new List<PlotModel>();
            _widths = new List<double>();
            _heights = new List<double>();

            _style = style;
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
                        model = Initializers.PlotModelInitializer.Create(null, _style);
                    model.Series.Add(series);
                }
                else if (i is ISeriesInfo si)
                {
                    if (model == null)
                        model = Initializers.PlotModelInitializer.Create(null, _style);
                    foreach (var s in si.Series)
                        model.Series.Add(s);
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

        public void SaveAsSvg(string path, int width = 800, int height = 600, bool isDocument = true)
        {
            var svgString = GridViewExporter.ExportToSvgString(this, width, height, isDocument);

            using (var f = new StreamWriter(path))
            {
                f.Write(svgString);
            }
        }

        public void SaveAsPngImage(string path, int width = 800, int height = 600)
        {
            GridViewExporter.ExportToPng(this, path, width, height);
        }

        public void Save(string path, int width = 800, int height = 600, bool isDocument = true)
        {
            var p = path.ToLower();
            if (p.EndsWith(".png"))
                GridViewExporter.ExportToPng(this, path, width, height);
            else
                GridViewExporter.ExportToSvg(this, path, width, height, isDocument);
        }

        public Windows.Controls.Grid ToGridControl()
        {
            var adjusted = GetAdjustedWidthHeight();
            var widths = adjusted.Item1;
            var heights = adjusted.Item2;

            Windows.Controls.Grid grid = null;

            WpfWindow.RootWindow.Dispatcher.Invoke(() => {
                grid = new Windows.Controls.Grid();
                grid.HorizontalAlignment = Windows.HorizontalAlignment.Stretch;
                grid.VerticalAlignment = Windows.VerticalAlignment.Stretch;

                for (var i = 0; i < heights.Count; ++i)
                {
                    var def = heights[i];
                    var converter = new Windows.GridLengthConverter();
                    var length = (Windows.GridLength)converter.ConvertFrom($"{def}*");

                    var rowDef = new Windows.Controls.RowDefinition();
                    rowDef.Height = length;
                    grid.RowDefinitions.Add(rowDef);
                }

                for (var i = 0; i < widths.Count; ++i)
                {
                    var def = widths[i];
                    var converter = new Windows.GridLengthConverter();
                    var length = (Windows.GridLength)converter.ConvertFrom($"{def}*");

                    var columnDef = new Windows.Controls.ColumnDefinition();
                    columnDef.Width = length;
                    grid.ColumnDefinitions.Add(columnDef);
                }

                var count = 0;
                var exit = false;
                for (var h = 0; h < heights.Count; ++h)
                {
                    if (exit)
                        break;
                    for (var w = 0; w < widths.Count; ++w)
                    {
                        if (count >= _models.Count)
                        {
                            exit = true;
                            break;
                        }

                        var content = new OxyPlot.Wpf.PlotView() { Model = _models[count++] };
                        grid.Children.Add(content);
                        Windows.Controls.Grid.SetRow(content, h);
                        Windows.Controls.Grid.SetColumn(content, w);
                    }
                }
            });

            return grid;
        }

        public static implicit operator Windows.Controls.Grid(GridView self)
        {
            return self.ToGridControl();
        }
    }
}
