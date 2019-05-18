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
    internal class VoidT { }

    internal abstract class SeriesBuilder<SeriesT, DataPointT, E1, E2, E3, E4, E5, E6>
        where SeriesT : Series, new()
    {
        protected abstract string[] PropertyNameArguments { get; }

        protected abstract bool[] PropertyMandatoriness { get; }

        protected abstract void AddDataPointToSeries(SeriesT series, E1 e1, E2 e2, E3 e3, E4 e4, E5 e5, E6 e6);

        private string[] _propertyNames;

        private List<E1> _e1;
        private List<E2> _e2;
        private List<E3> _e3;
        private List<E4> _e4;
        private List<E5> _e5;
        private List<E6> _e6;

        private string _groupName;
        private List<object> _groups;

        public static readonly string DefaultGroupName = "default group!!??##$%&' ";

        public SeriesBuilder(Dictionary<string, object> boundParameters)
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

            _propertyNames = PropertyNameArguments.Select(p => {
                object v;
                if (boundParameters.TryGetValue(p + "Name", out v))
                    return (string)v;
                return null;
            }).ToArray();

            ReadArguments(boundParameters);
        }

        private T ConvertObjectType<T>(object value)
        {
            if (typeof(T) == typeof(double))
                return (T)(object)SmartConverter.ToDouble(value);

            if (typeof(T) == typeof(int))
                return (T)(object)SmartConverter.ToInt(value);

            if (typeof(T) == typeof(bool))
                return (T)(object)SmartConverter.ToBool(value);

            if (typeof(T) == typeof(string))
                return (T)(object)value.ToString();

            throw new ApplicationException("Internal error; type {typeof(T)} is not supported as argument");
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

            return default(T);
        }

        private void ReadInputObject<T>(List<T> elements, PSObject inputObject, string name)
        {
            if (string.IsNullOrEmpty(name) || inputObject.Properties.Match(name).Count == 0)
                return;

            var value = inputObject.Properties[name].Value;
            var converted = ConvertObjectType<T>(value);

            elements.Add(converted);
        }

        public void ReadPSObject(PSObject inputObject)
        {
            object g = DefaultGroupName;
            if (inputObject.Properties.Match(_groupName).Count > 0)
                g = inputObject.Properties[_groupName].Value;
            _groups.Add(g);

            if (typeof(E1) != typeof(VoidT))
            {
                ReadInputObject(_e1, inputObject, _propertyNames[0]);
                if (typeof(E2) != typeof(VoidT))
                {
                    ReadInputObject(_e2, inputObject, _propertyNames[1]);
                    if (typeof(E3) != typeof(VoidT))
                    {
                        ReadInputObject(_e3, inputObject, _propertyNames[2]);
                        if (typeof(E4) != typeof(VoidT))
                        {
                            ReadInputObject(_e4, inputObject, _propertyNames[3]);
                            if (typeof(E5) != typeof(VoidT))
                            {
                                ReadInputObject(_e5, inputObject, _propertyNames[4]);
                                if (typeof(E6) != typeof(VoidT))
                                    ReadInputObject(_e6, inputObject, _propertyNames[5]);
                            }
                        }
                    }
                }
            }
        }

        private void ReadArray<T>(List<T> elements, Dictionary<string, object> boundParameters, string name)
        {
            if (boundParameters.TryGetValue(name, out object value))
                elements.AddRange((IEnumerable<T>)value);
        }

        public void ReadArguments(Dictionary<string, object> boundParameters)
        {
            var argumentNames = PropertyNameArguments;
            if (typeof(E1) != typeof(VoidT))
                ReadArray(_e1, boundParameters, argumentNames[0]);
            if (typeof(E2) != typeof(VoidT))
                ReadArray(_e2, boundParameters, argumentNames[1]);
            if (typeof(E3) != typeof(VoidT))
                ReadArray(_e3, boundParameters, argumentNames[2]);
            if (typeof(E4) != typeof(VoidT))
                ReadArray(_e4, boundParameters, argumentNames[3]);
            if (typeof(E5) != typeof(VoidT))
                ReadArray(_e5, boundParameters, argumentNames[4]);
            if (typeof(E6) != typeof(VoidT))
                ReadArray(_e6, boundParameters, argumentNames[5]);

            object groups;
            if (boundParameters.TryGetValue(_groupName, out groups))
                _groups.AddRange((IEnumerable<object>)groups);
        }

        public SeriesT[] CreateSeries()
        {
            // Validate data lengths.

            int count = (new int[] { _e1.Count, _e2.Count, _e3.Count, _e4.Count, _e5.Count, _e6.Count }).Max();
            var ma = PropertyMandatoriness;
            if (typeof(E1) != typeof(VoidT) && !(_e1.Count == count || (!ma[0] && _e1.Count == 0)))
                throw new ArgumentException($"Length of {_propertyNames[0]} is different from the other items");
            if (typeof(E2) != typeof(VoidT) && !(_e2.Count == count || (!ma[1] && _e2.Count == 0)))
                throw new ArgumentException($"Length of {_propertyNames[1]} is different from the other items");
            if (typeof(E3) != typeof(VoidT) && !(_e3.Count == count || (!ma[2] && _e3.Count == 0)))
                throw new ArgumentException($"Length of {_propertyNames[2]} is different from the other items");
            if (typeof(E4) != typeof(VoidT) && !(_e4.Count == count || (!ma[3] && _e4.Count == 0)))
                throw new ArgumentException($"Length of {_propertyNames[3]} is different from the other items");
            if (typeof(E5) != typeof(VoidT) && !(_e5.Count == count || (!ma[4] && _e5.Count == 0)))
                throw new ArgumentException($"Length of {_propertyNames[4]} is different from the other items");
            if (typeof(E6) != typeof(VoidT) && !(_e6.Count == count || (!ma[5] && _e6.Count == 0)))
                throw new ArgumentException($"Length of {_propertyNames[5]} is different from the other items");

            if (!(_groups.Count == count || _groups.Count == 0))
                throw new ArgumentException($"Length of grouping elements is different from the others");

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
                    i < _e6.Count ? _e6[i] : GetNaN<E6>()
                );
            }

            var keys = seriesSet.Keys.ToArray();
            Array.Sort(keys);
            return keys.Select(k => seriesSet[k]).ToArray();
        }
    }
}
