using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horker.PSOxyPlot.SeriesBuilders;
using Horker.PSOxyPlot.Styles;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.Initializers
{
    public class AxisSelector
    {
        static private AxisSelector _commonAxisSelectorInstance;
        static private CandleStickAndVolumeSeriesAxisSelector _candleStickAndVolumeSeriesAxisSelectorInstance;
        static private HeatMapSeriesAxisSelector _heatMapSeriesAxisSelectorInstance;

        static AxisSelector()
        {
            _commonAxisSelectorInstance = new AxisSelector();
            _candleStickAndVolumeSeriesAxisSelectorInstance = new CandleStickAndVolumeSeriesAxisSelector();
            _heatMapSeriesAxisSelectorInstance = new HeatMapSeriesAxisSelector();
        }

        public static AxisSelector GetInstanceOf(Type type)
        {
            if (type == typeof(CandleStickAndVolumeSeries))
                return _candleStickAndVolumeSeriesAxisSelectorInstance;
            else if (type == typeof(HeatMapSeries))
                return _heatMapSeriesAxisSelectorInstance;

            return _commonAxisSelectorInstance;
        }

        public Axis GetXAxisObject(Series series, ISeriesInfo si, Style style)
        {
            var axis = GetXAxisObjectInternal(series, si);
            style.ApplyStyleTo(axis);
            return axis;
        }

        public Axis GetYAxisObject(Series series, ISeriesInfo si, Style style)
        {
            var axis = GetYAxisObjectInternal(series, si);
            style.ApplyStyleTo(axis);
            return axis;
        }

        public Axis GetAdditionalAxisObject(Series series, ISeriesInfo si, Style style)
        {
            var axis = GetAdditionalAxisObjectInternal(series, si);
            style.ApplyStyleTo(axis);
            return axis;
        }

        protected Axis GetAxisObject(Series series, ISeriesInfo si, int index)
        {
            var axisType = si?.AxisTypes[index];
            if (axisType == null)
            {
                axisType = SeriesBuilderStore.OfType(series.GetType()).DefaultAxisTypes[index];
                if (axisType == null)
                    return null;
            }

            var axis = (Axis)axisType.GetConstructor(new Type[0]).Invoke(new object[0]);

            if (axis is CategoryAxis ca && si?.CategoryNames != null)
            {
                foreach (var n in si.CategoryNames)
                    ca.Labels.Add(n);
            }

            return axis;
        }

        protected virtual Axis GetXAxisObjectInternal(Series series, ISeriesInfo si)
        {
            var axis = GetAxisObject(series, si, 0);
            if (axis != null)
                axis.Position = AxisPosition.Bottom;
            return axis;
        }

        protected virtual Axis GetYAxisObjectInternal(Series series, ISeriesInfo si)
        {
            var axis = GetAxisObject(series, si, 1);
            if (axis != null)
                axis.Position = AxisPosition.Left;
            return axis;
        }

        protected virtual Axis GetAdditionalAxisObjectInternal(Series series, ISeriesInfo si)
        {
            var axis = GetAxisObject(series, si, 2);
            if (axis != null)
                axis.Position = AxisPosition.Right;
            return axis;
        }

        public virtual bool HasAdditionalAxisObject(Series series)
        {
            return false;
        }
    }

    public class CandleStickAndVolumeSeriesAxisSelector : AxisSelector
    {
        protected override Axis GetYAxisObjectInternal(Series series, ISeriesInfo si)
        {
            var axis = GetAxisObject(series, si, 1);
            axis.Position = AxisPosition.Left;
            axis.StartPosition = .25;
            return axis;
        }

        protected override Axis GetAdditionalAxisObjectInternal(Series series, ISeriesInfo si)
        {
            var s = series as CandleStickAndVolumeSeries;
            if (s.VolumeAxis != null)
                return null;

            var key = Guid.NewGuid().ToString();

            var axis = new LinearAxis()
            {
                Position = AxisPosition.Left,
                EndPosition = .22,
                Key = key
            };

            s.VolumeAxisKey = key;
            
            return axis;
        }
    }

    public class HeatMapSeriesAxisSelector : AxisSelector
    {
        protected override Axis GetAdditionalAxisObjectInternal(Series series, ISeriesInfo si)
        {
            var s = series as HeatMapSeries;
            if (s.ColorAxis != null)
                return null;

            var key = Guid.NewGuid().ToString();

            var axis = new LinearColorAxis()
            {
                Position = AxisPosition.Right,
                Key = key
            };

            s.ColorAxisKey = key;

            return axis;
        }

        public override bool HasAdditionalAxisObject(Series series)
        {
            var s = series as HeatMapSeries;
            return s.ColorAxis != null;
        }
    }

    public class RectangleSeriesAxisSelector : AxisSelector
    {
        public override bool HasAdditionalAxisObject(Series series)
        {
            var s = series as RectangleSeries;
            return s.ColorAxis != null;
        }
    }
}
