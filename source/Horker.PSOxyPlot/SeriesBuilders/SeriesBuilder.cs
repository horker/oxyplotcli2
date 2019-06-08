using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.SeriesBuilders
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
        public abstract string ShortName { get; }

        protected abstract void AddDataPointToSeries(SeriesT series, E1 e1, E2 e2, E3 e3, E4 e4, E5 e5, E6 e6, E7 e7);
        protected virtual void Postprocess(SeriesT series) { }

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

        private T ConvertObjectType<T>(object value)
        {
            if (typeof(T) == typeof(double))
                return (T)(object)new TypeAdaptors.Double(value).Value;

            if (typeof(T) == typeof(int))
                return (T)(object)SmartConverter.ToInt(value);

            if (typeof(T) == typeof(bool))
                return (T)(object)SmartConverter.ToBool(value);

            if (typeof(T) == typeof(string))
                return (T)(object)value.ToString();

            if (typeof(T) == typeof(OxyColor))
                return (T)(object)new TypeAdaptors.OxyColor(value).Value;

            if (typeof(T) == typeof(TypeAdaptors.Category))
                return (T)(object)new TypeAdaptors.Category((string)value);

            return (T)value;
        }

        private IEnumerable<T> ConvertCollectionType<T>(IEnumerable<object> coll)
        {
            return coll.Select(x => ConvertObjectType<T>(x));
        }

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

        private AxisType InferAxisType<T>(object value)
        {
            if (typeof(T) != typeof(double))
                return AxisType.Numeric;

            var t = value.GetType();
            if (t == typeof(double) || t == typeof(float) || t == typeof(long) || t == typeof(int) ||
                t == typeof(short) || t == typeof(byte) || t == typeof(sbyte))
                return AxisType.Numeric;

            if (t == typeof(DateTime) || t == typeof(DateTimeOffset))
                return AxisType.DateTime;

            if (t == typeof(TimeSpan))
                return AxisType.TimeSpan;

            try
            {
                var dummy = SmartConverter.ToDouble(value);
                return AxisType.Numeric;
            }
            catch (Exception)
            {
                try
                {
                    var dummy = DateTime.Parse(value.ToString());
                    return AxisType.DateTime;
                }
                catch (Exception)
                {
                    try
                    {
                        var dummy = TimeSpan.Parse(value.ToString());
                        return AxisType.TimeSpan;
                    }
                    catch (Exception)
                    {
                        return AxisType.Numeric;
                    }
                }
            }
        }

        private void ReadInputObject<T>(List<T> elements, PSObject inputObject, int argIndex)
        {
            var name = _propertyNames[argIndex];

            if (string.IsNullOrEmpty(name) || inputObject.Properties.Match(name).Count == 0)
                return;

            var value = inputObject.Properties[name].Value;
            var converted = ConvertObjectType<T>(value);

            elements.Add(converted);
        }

        public void ReadPSObject(PSObject inputObject)
        {
            if (inputObject.Properties.Match(_groupName).Count > 0)
            {
                var g = inputObject.Properties[_groupName].Value;
                _groups.Add(g);
            }

            if (typeof(E1) != typeof(VoidT))
            {
                ReadInputObject(_e1, inputObject, 0);
                if (typeof(E2) != typeof(VoidT))
                {
                    ReadInputObject(_e2, inputObject, 1);
                    if (typeof(E3) != typeof(VoidT))
                    {
                        ReadInputObject(_e3, inputObject, 2);
                        if (typeof(E4) != typeof(VoidT))
                        {
                            ReadInputObject(_e4, inputObject, 3);
                            if (typeof(E5) != typeof(VoidT))
                            {
                                ReadInputObject(_e5, inputObject, 4);
                                if (typeof(E6) != typeof(VoidT))
                                {
                                    ReadInputObject(_e6, inputObject, 5);
                                    if (typeof(E7) != typeof(VoidT))
                                        ReadInputObject(_e7, inputObject, 6);
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

        private void ReadArguments(Dictionary<string, object> boundParameters)
        {
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

            object groups;
            if (boundParameters.TryGetValue("Group", out groups))
                _groups.AddRange((IEnumerable<object>)groups);
        }

        public void ReadBoundParameters(Dictionary<string, object> boundParameters)
        {
            _groupName = DefaultGroupName;
            if (boundParameters.TryGetValue("GroupName", out object groupName))
                _groupName = (string)groupName;

            _groups = new List<object>();

            _e1 = new List<E1>();
            _e2 = new List<E2>();
            _e3 = new List<E3>();
            _e4 = new List<E4>();
            _e5 = new List<E5>();
            _e6 = new List<E6>();
            _e7 = new List<E7>();

            _propertyNames = DataPointItemNames.Select(p => {
                object v;
                if (boundParameters.TryGetValue(p + "Name", out v))
                    return (string)v;
                return null;
            }).ToArray();

            _info = new SeriesInfo<SeriesT>();

            if (AxisItemIndexes.Length > 0 && AxisItemIndexes[0] >= 0 && boundParameters.TryGetValue(DataPointItemNames[AxisItemIndexes[0]] + "Name", out object xName))
                _info.AxisTitles[0] = (string)xName;

            if (AxisItemIndexes.Length > 1 && AxisItemIndexes[1] >= 0 && boundParameters.TryGetValue(DataPointItemNames[AxisItemIndexes[1]] + "Name", out object yName))
                _info.AxisTitles[1] = (string)yName;

            ReadArguments(boundParameters);
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

        private void SetCategoryNames<T>(List<T> values)
        {
            var count = values.Count;
            var cat = new string[count];
            for (var i = 0; i < count; ++i)
                cat[i] = values[i].ToString();
            _info.CategoryNames = cat;
        }

        public virtual SeriesInfo<SeriesT> CreateSeriesInfo()
        {
            // Validate data lengths.
            ValidateInputData();

            // Create a set of series.

            int count = (new int[] { _e1.Count, _e2.Count, _e3.Count, _e4.Count, _e5.Count, _e6.Count, _e7.Count }).Max();
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
                    if (g is string && g as string != DefaultGroupName)
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

            if (typeof(E1) == typeof(TypeAdaptors.Category))
                SetCategoryNames(_e1);
            if (typeof(E2) == typeof(TypeAdaptors.Category))
                SetCategoryNames(_e2);
            if (typeof(E3) == typeof(TypeAdaptors.Category))
                SetCategoryNames(_e3);
            if (typeof(E4) == typeof(TypeAdaptors.Category))
                SetCategoryNames(_e4);
            if (typeof(E5) == typeof(TypeAdaptors.Category))
                SetCategoryNames(_e5);
            if (typeof(E6) == typeof(TypeAdaptors.Category))
                SetCategoryNames(_e6);
            if (typeof(E7) == typeof(TypeAdaptors.Category))
                SetCategoryNames(_e7);

            return _info;
        }
    }
}
