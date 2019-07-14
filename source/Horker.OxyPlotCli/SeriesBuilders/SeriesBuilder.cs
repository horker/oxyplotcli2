using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Horker.OxyPlotCli.Initializers;
using Horker.OxyPlotCli.Styles;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.OxyPlotCli.SeriesBuilders
{
    public class VoidT { }

    public abstract class SeriesBuilder<SeriesT, DataPointT, E1, E2, E3, E4, E5, E6, E7> : ISeriesBuilder
        where SeriesT : Series, new()
    {
        public Type SeriesType => typeof(SeriesT);

        // Abstract properties

        public abstract string[] DataPointItemNames { get; }
        public abstract bool[] DataPointItemMandatoriness { get; }
        public abstract int[] AxisItemIndexes { get; }
        public abstract Type[] DefaultAxisTypes { get; }
        public abstract string[] Aliases { get; }

        protected string[] _propertyNames;

        protected List<E1> _e1;
        protected List<E2> _e2;
        protected List<E3> _e3;
        protected List<E4> _e4;
        protected List<E5> _e5;
        protected List<E6> _e6;
        protected List<E7> _e7;

        protected string _groupName;
        protected List<object> _groups;

        protected SeriesInfo<SeriesT> _info;

        protected static readonly string DefaultGroupName = "default group!!??##$%&' ";

        protected abstract void AddDataPointToSeries(SeriesT series, E1 e1, E2 e2, E3 e3, E4 e4, E5 e5, E6 e6, E7 e7);

        protected virtual void Postprocess(SeriesT series) { }

        private T GetNaN<T>()
        {
            if (typeof(T) == typeof(double))
                return (T)(object)double.NaN;

            if (typeof(T) == typeof(float))
                return (T)(object)float.NaN;

            if (typeof(T) == typeof(OxyColor))
                return (T)(object)OxyColors.Automatic;

            return default(T);
        }

        private Type InferAxisTypeBasedOnValueType(int axisIndex, object value)
        {
            // Use a default type except a linear axis.
            if (DefaultAxisTypes[axisIndex] != typeof(LinearAxis))
                return DefaultAxisTypes[axisIndex];

            if (value == null)
                return null;

            Type t;

            if (value is TypeAdaptors.Double d)
                t = d.InferValueType();
            else
                t = value.GetType();

            if (t == typeof(double) || t == typeof(float) || t == typeof(long) || t == typeof(int) ||
                t == typeof(short) || t == typeof(byte) || t == typeof(sbyte))
                return typeof(LinearAxis);

            if (t == typeof(DateTime) || t == typeof(DateTimeOffset))
                return typeof(DateTimeAxis);

            if (t == typeof(TimeSpan))
                return typeof(TimeSpanAxis);

            try
            {
                var dummy = SmartConverter.ToDouble(value);
                return typeof(LinearAxis);
            }
            catch (Exception)
            {
                try
                {
                    var dummy = DateTime.Parse(value.ToString());
                    return typeof(DateTimeAxis);
                }
                catch (Exception)
                {
                    try
                    {
                        var dummy = TimeSpan.Parse(value.ToString());
                        return typeof(TimeSpanAxis);
                    }
                    catch (Exception)
                    {
                        return typeof(LinearAxis);
                    }
                }
            }
        }

        private void ReadDataPointElementFromPipeline<T>(List<T> elements, PSObject inputObject, int argIndex)
        {
            var name = _propertyNames[argIndex];

            if (string.IsNullOrEmpty(name) || inputObject.Properties.Match(name).Count == 0)
                return;

            var value = inputObject.Properties[name].Value;
            var converted = TypeAdaptors.Helpers.ConvertObjectType<T>(value);

            elements.Add(converted);
        }

        /// <summary>
        /// Read a single data item from the pipeline.
        /// </summary>
        /// <param name="inputObject">The pipeline value.</param>
        public void ReadPSObject(PSObject inputObject)
        {
            if (inputObject.Properties.Match(_groupName).Count > 0)
            {
                var g = inputObject.Properties[_groupName].Value;
                _groups.Add(g);
            }

            for (var i = 0; i < 2; ++i)
            {
                if (_info.AxisTypes[i] == null)
                {
                    if (AxisItemIndexes.Length > i && AxisItemIndexes[i] >= 0)
                    {
                        var name = _propertyNames[AxisItemIndexes[i]];
                        if (inputObject.Properties.Match(name).Count > 0)
                        {
                            var value = inputObject.Properties[name].Value;
                            _info.AxisTypes[i] = InferAxisTypeBasedOnValueType(i, value);
                        }
                    }
                }
            }

            if (typeof(E1) != typeof(VoidT))
            {
                ReadDataPointElementFromPipeline(_e1, inputObject, 0);
                if (typeof(E2) != typeof(VoidT))
                {
                    ReadDataPointElementFromPipeline(_e2, inputObject, 1);
                    if (typeof(E3) != typeof(VoidT))
                    {
                        ReadDataPointElementFromPipeline(_e3, inputObject, 2);
                        if (typeof(E4) != typeof(VoidT))
                        {
                            ReadDataPointElementFromPipeline(_e4, inputObject, 3);
                            if (typeof(E5) != typeof(VoidT))
                            {
                                ReadDataPointElementFromPipeline(_e5, inputObject, 4);
                                if (typeof(E6) != typeof(VoidT))
                                {
                                    ReadDataPointElementFromPipeline(_e6, inputObject, 5);
                                    if (typeof(E7) != typeof(VoidT))
                                        ReadDataPointElementFromPipeline(_e7, inputObject, 6);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ReadArray<T>(List<T> elements, Dictionary<string, object> boundParameters, int index)
        {
            var name = DataPointItemNames[index];
            if (boundParameters.TryGetValue(name, out object value))
            {
                if (typeof(T) == typeof(double))
                {
                    var array = (IEnumerable<TypeAdaptors.Double>)value;
                    foreach (var e in array)
                        elements.Add((T)(object)(double)e);
                }
                else if (typeof(T) == typeof(OxyColor))
                {
                    var array = (IEnumerable<TypeAdaptors.OxyColor>)value;
                    foreach (var e in array)
                        elements.Add((T)(object)(OxyColor)e);
                }
                else
                    elements.AddRange((IEnumerable<T>)value);
            }
        }

        /// <summary>
        /// Read the parameters given to the cmdlet and configure overall
        /// settings such as a group name and axis titles, and load data points.
        /// </summary>
        /// <param name="boundParameters"></param>
        public void ReadBoundParameters(Dictionary<string, object> boundParameters)
        {
            // Initialize instance variables.
            // Initialization should be done here instead of in the constructor for efficiency.
            // The subclasses of SeriesBuilder are instantiated in SeriesBuilderStore
            // to prepare for the query about Series object properties.

            _e1 = new List<E1>();
            _e2 = new List<E2>();
            _e3 = new List<E3>();
            _e4 = new List<E4>();
            _e5 = new List<E5>();
            _e6 = new List<E6>();
            _e7 = new List<E7>();

            _groups = new List<object>();

            // Initialize property names and a group name.

            _propertyNames = DataPointItemNames.Select(p => {
                object v;
                if (boundParameters.TryGetValue(p + "Name", out v))
                    return (string)v;
                return null;
            }).ToArray();

            _groupName = DefaultGroupName;
            if (boundParameters.TryGetValue("GroupName", out object groupName))
                _groupName = (string)groupName;

            // Infer axis types and initialize axis names based on bound parameters.

            _info = new SeriesInfo<SeriesT>();

            for (var i = 0; i < 2; ++i)
            {
                if (AxisItemIndexes.Length > i && AxisItemIndexes[i] >= 0)
                {
                    if (boundParameters.TryGetValue(DataPointItemNames[AxisItemIndexes[i]] + "Name", out object name))
                        _info.AxisTitles[i] = (string)name;

                    // Infer axis types. If data points are given through the pipeline,
                    // inference will be done the first time we read pipeline values in ReadPSObject().
                    if (boundParameters.TryGetValue(DataPointItemNames[AxisItemIndexes[i]], out object value))
                    {
                        var a = value as object[];
                        if (a != null)
                        {
                            foreach (var v in a)
                            {
                                if (v == null)
                                    continue;
                                _info.AxisTypes[i] = InferAxisTypeBasedOnValueType(i, v);
                            }
                        }
                    }
                }
            }

            // Read data points.

            if (typeof(E1) != typeof(VoidT))
                ReadArray(_e1, boundParameters, 0);
            if (typeof(E2) != typeof(VoidT))
                ReadArray(_e2, boundParameters, 1);
            if (typeof(E3) != typeof(VoidT))
                ReadArray(_e3, boundParameters, 2);
            if (typeof(E4) != typeof(VoidT))
                ReadArray(_e4, boundParameters, 3);
            if (typeof(E5) != typeof(VoidT))
                ReadArray(_e5, boundParameters, 4);
            if (typeof(E6) != typeof(VoidT))
                ReadArray(_e6, boundParameters, 5);
            if (typeof(E7) != typeof(VoidT))
                ReadArray(_e7, boundParameters, 6);

            // Read groups.

            if (boundParameters.TryGetValue("Group", out var groups))
                _groups.AddRange((IEnumerable<object>)groups);
        }

        protected virtual void ValidateInputData()
        {
            int count = (new int[] { _e1.Count, _e2.Count, _e3.Count, _e4.Count, _e5.Count, _e6.Count, _e7.Count }).Max();
            var ma = DataPointItemMandatoriness;

            if (typeof(E1) != typeof(VoidT))
            {
                if (ma[0] && _e1.Count == 0)
                    throw new ArgumentException($"{DataPointItemNames[0]} is mandatory but not specified");
                if (_e1.Count > 0 && _e1.Count != count)
                    throw new ArgumentException($"Length of {DataPointItemNames[0]} is different from the other items");
            }

            if (typeof(E2) != typeof(VoidT))
            {
                if (ma[1] && _e2.Count == 0)
                    throw new ArgumentException($"{DataPointItemNames[1]} is mandatory but not specified");
                if (_e2.Count > 0 && _e2.Count != count)
                    throw new ArgumentException($"Length of {DataPointItemNames[1]} is different from the other items");
            }

            if (typeof(E3) != typeof(VoidT))
            {
                if (ma[2] && _e3.Count == 0)
                    throw new ArgumentException($"{DataPointItemNames[2]} is mandatory but not specified");
                if (_e3.Count > 0 && _e3.Count != count)
                    throw new ArgumentException($"Length of {DataPointItemNames[2]} is different from the other items");
            }

            if (typeof(E4) != typeof(VoidT))
            {
                if (ma[3] && _e4.Count == 0)
                    throw new ArgumentException($"{DataPointItemNames[3]} is mandatory but not specified");
                if (_e4.Count > 0 && _e4.Count != count)
                    throw new ArgumentException($"Length of {DataPointItemNames[3]} is different from the other items");
            }

            if (typeof(E5) != typeof(VoidT))
            {
                if (ma[4] && _e5.Count == 0)
                    throw new ArgumentException($"{DataPointItemNames[4]} is mandatory but not specified");
                if (_e5.Count > 0 && _e5.Count != count)
                    throw new ArgumentException($"Length of {DataPointItemNames[4]} is different from the other items");
            }

            if (typeof(E6) != typeof(VoidT))
            {
                if (ma[5] && _e6.Count == 0)
                    throw new ArgumentException($"{DataPointItemNames[5]} is mandatory but not specified");
                if (_e6.Count > 0 && _e6.Count != count)
                    throw new ArgumentException($"Length of {DataPointItemNames[5]} is different from the other items");
            }

            if (typeof(E7) != typeof(VoidT))
            {
                if (ma[6] && _e7.Count == 0)
                    throw new ArgumentException($"{DataPointItemNames[6]} is mandatory but not specified");
                if (_e7.Count > 0 && _e7.Count != count)
                    throw new ArgumentException($"Length of {DataPointItemNames[6]} is different from the other items");
            }

            if (!(_groups.Count == count || _groups.Count == 0))
                throw new ArgumentException("Length of grouping items is different from the others");

        }

        protected virtual string[] GetCategoryNames()
        {
            return new string[0];
        }

        /// <summary>
        /// Create a SeriesInfo object based on the cmdlet parameters.
        /// </summary>
        /// <returns>A SeriesInfo object.</returns>
        public virtual SeriesInfo<SeriesT> CreateSeriesInfo(Style style)
        {
            int count = (new int[] { _e1.Count, _e2.Count, _e3.Count, _e4.Count, _e5.Count, _e6.Count, _e7.Count }).Max();

            if (count == 0)
            {
                var s = new SeriesT();
                style.ApplyStyleTo(s);
                _info.Series = new[] { s };
                return _info;
            }

            // Validate data lengths.

            ValidateInputData();

            // Create a set of series.

            var seriesSet = new Dictionary<object, SeriesT>();
            for (var i = 0; i < count; ++i)
            {
                object g = DefaultGroupName;
                if (i < _groups.Count)
                    g = _groups[i];

                SeriesT s;
                if (!seriesSet.TryGetValue(g, out s))
                {
                    s = new SeriesT();
                    if (g.ToString() != DefaultGroupName)
                        s.Title = g.ToString();
                    seriesSet.Add(g, s);
                }

                AddDataPointToSeries(
                    s,
                    i < _e1.Count ? _e1[i] : GetNaN<E1>(),
                    i < _e2.Count ? _e2[i] : GetNaN<E2>(),
                    i < _e3.Count ? _e3[i] : GetNaN<E3>(),
                    i < _e4.Count ? _e4[i] : GetNaN<E4>(),
                    i < _e5.Count ? _e5[i] : GetNaN<E5>(),
                    i < _e6.Count ? _e6[i] : GetNaN<E6>(),
                    i < _e7.Count ? _e7[i] : GetNaN<E7>()
                );

                Postprocess(s);
            }

            var keys = seriesSet.Keys.ToArray();
            Array.Sort(keys);
            _info.Series = keys.Select(k => seriesSet[k]).ToArray();

            _info.CategoryNames = GetCategoryNames();

            foreach (var s in _info.Series)
                style.ApplyStyleTo(s);

            return _info;
        }

        public virtual Axis GetDefaultAxisObject(AxisKind kind)
        {
            var type = DefaultAxisTypes[(int)kind];
            if (type == null)
                return null;

            var axis = (Axis)type.GetConstructor(new Type[0]).Invoke(new object[0]);

            switch (kind)
            {
                case AxisKind.Ax:
                    axis.Position = AxisPosition.Bottom;
                    break;
                case AxisKind.Ay:
                    axis.Position = AxisPosition.Left;
                    break;
                case AxisKind.Az:
                    axis.Position = AxisPosition.Right;
                    break;
                default:
                    throw new ArgumentException($"Unknown axis kind: {kind}");
            }

            return axis;
        }
    }
}
