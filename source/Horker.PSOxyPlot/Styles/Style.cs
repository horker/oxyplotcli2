using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Horker.PSOxyPlot.Styles
{
    public class Style
    {
        private static List<Type> _types;

        private Dictionary<Type, List<Decorator>> _decorators;
        private Dictionary<Type, List<HookAction>> _typeHooks;
        private Dictionary<EventType, List<HookAction>> _eventHooks;

        public IDictionary<Type, List<Decorator>> Decorators => _decorators;
        public IDictionary<Type, List<HookAction>> TypeHooks => _typeHooks;
        public IDictionary<EventType, List<HookAction>> EventHooks => _eventHooks;

        static Style()
        {
            _types = new List<Type>();

            _types.Add(typeof(PlotModel));

            var types = typeof(LineSeries).Assembly.GetTypes();
            foreach (var type in types)
            {
                if (!type.IsPublic || type.IsAbstract)
                    continue;

                if (type.Name.EndsWith("Series") || type.Name.EndsWith("Axis") || type.Name.EndsWith("Annotation"))
                    _types.Add(type);
            }
        }

        public Style()
        {
            _decorators = new Dictionary<Type, List<Decorator>>();
            _typeHooks = new Dictionary<Type, List<HookAction>>();
            _eventHooks = new Dictionary<EventType, List<HookAction>>();
        }

        private void AddDecorator(Type type, PropertyInfo property, object value)
        {
            if (!_decorators.TryGetValue(type, out var decorators))
            {
                decorators = new List<Decorator>();
                _decorators.Add(type, decorators);
            }

            decorators.Add(new Decorator(type, property, value));
        }

        private void AddTypeHook(Type type, HookAction action)
        {
            if (!_typeHooks.TryGetValue(type, out var actions))
            {
                actions = new List<HookAction>();
                _typeHooks.Add(type, actions);
            }

            actions.Add(action);
        }

        public static Style Create(Dictionary<string, object> config)
        {
            var style = new Style();

            foreach (var entry in config)
            {
                // TODO: take a glob for type filters.

                var typeFilter = entry.Key.Trim();
                var value = entry.Value;

                if (typeFilter.StartsWith("["))
                {
                    if (!typeFilter.EndsWith("]"))
                        throw new ArgumentException($"Invalid type filter or event name: '{typeFilter}'");

                    var eventName = typeFilter.Substring(1, typeFilter.Length - 2).ToLower();

                    var enumNames = typeof(EventType).GetEnumNames();
                    var enumValues = (EventType[])typeof(EventType).GetEnumValues();
                    var found = false;
                    for (var i = 0; i < enumNames.Length; ++i)
                    {
                        if (enumNames[i].ToLower() == eventName)
                        {
                            var e = enumValues[i];
                            if (!style._eventHooks.TryGetValue(e, out var actions))
                            {
                                actions = new List<HookAction>();
                                style._eventHooks.Add(e, actions);
                            }
                            actions.Add(HookAction.Create(value));
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                        throw new ArgumentException($"Invalid event name: '{typeFilter}'");

                    continue;
                }

                var elements = typeFilter.Split(new char[] { '.' }, 2);
                if (elements.Length != 2)
                    throw new ArgumentException($"Invalid type filter format: '{typeFilter}'");

                var typeName = elements[0];
                var propertyName = elements[1];

                // Find a corresponding type.

                var types = new List<Type>();
                if (!typeName.Contains("?") && !typeName.Contains("*"))
                {
                    foreach (var t in _types)
                    {
                        if (t.Name == typeName)
                        {
                            types.Add(t);
                            break;
                        }
                    }
                }
                else
                {
                    var p = Regex.Escape(typeName);
                    p = p.Replace("\\?", ".");
                    p = p.Replace("\\*", ".*");
                    var re = new Regex("^" + p + "$");

                    foreach (var t in _types)
                    {
                        if (re.IsMatch(t.Name))
                            types.Add(t);
                    }
                }

                if (types.Count == 0)
                    throw new ArgumentException($"No matching type for '{typeName}'");

                // Find a corresponding property.

                foreach (var type in types)
                {
                    if (propertyName == "*")
                    {
                        style.AddTypeHook(type, HookAction.Create(value));
                    }
                    else
                    {
                        var prop = type.GetProperty(propertyName);

                        if (prop == null)
                            throw new ArgumentException($"No matching property '{propertyName}' for '{typeName}'");

                        if (!prop.CanWrite || prop.SetMethod == null || !prop.SetMethod.IsPublic)
                            throw new ArgumentException($"Property '{propertyName}' has no public setter");

                        // Obtain an acceptable value for the specified type.

                        var v = TypeAdaptors.Helpers.ConvertObjectType(prop.PropertyType, value);

                        style.AddDecorator(type, prop, v);
                    }
                }
            }

            return style;
        }

        public static Style Create(Hashtable config)
        {
            var c = new Dictionary<string, object>();

            foreach (DictionaryEntry entry in config)
                c.Add((string)entry.Key, entry.Value);

            return Create(c);
        }

        public void ApplyStyleTo(object target)
        {
            if (target == null)
                return;

            var type = target.GetType();

            if (_decorators.TryGetValue(type, out var decorators))
            {
                foreach (var d in decorators)
                    d.Property.SetValue(target, d.Value);
            }

            if (_typeHooks.TryGetValue(type, out var actions))
            {
                foreach (var a in actions)
                    a.Invoke(target);
            }
        }

        public void ApplyEventHook(PlotModel model, EventType e)
        {
            if (!_eventHooks.TryGetValue(e, out var actions))
                return;

            foreach (var a in actions)
                a.Invoke(model);
        }
    }
}
