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

namespace Horker.OxyPlotCli.Styles
{
    public class Style
    {
        private static List<Type> _types;

        private string _name;
        private Dictionary<Type, List<Decorator>> _decorators;
        private Dictionary<Type, List<HookAction>> _typeHooks;
        private Dictionary<EventType, List<HookAction>> _eventHooks;
        private IColorScheme _colorScheme;
        private string _defaultFont;
        private bool _temporary;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public IDictionary<Type, List<Decorator>> Decorators => _decorators;
        public IDictionary<Type, List<HookAction>> TypeHooks => _typeHooks;
        public IDictionary<EventType, List<HookAction>> EventHooks => _eventHooks;

        public IColorScheme ColorScheme
        {
            get => _colorScheme;
            set => _colorScheme = value;
        }

        public string DefaultFont
        {
            get => _defaultFont;
            set => _defaultFont = value;
        }

        public bool Temporary
        {
            get => _temporary;
            set => _temporary = value;
        }

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

        public Style(string name)
        {
            _name = name;
            _decorators = new Dictionary<Type, List<Decorator>>();
            _typeHooks = new Dictionary<Type, List<HookAction>>();
            _eventHooks = new Dictionary<EventType, List<HookAction>>();
            _colorScheme = new VanillaColorScheme();
        }

        public Style(string name, Style baseStyle)
            : this(name)
        {
            if (baseStyle != null)
            {
                foreach (var d in baseStyle._decorators)
                    _decorators.Add(d.Key, new List<Decorator>(d.Value));

                foreach (var t in baseStyle._typeHooks)
                    _typeHooks.Add(t.Key, new List<HookAction>(t.Value));

                foreach (var e in baseStyle._eventHooks)
                    _eventHooks.Add(e.Key, new List<HookAction>(e.Value));
            }
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

        private void AddEventHook(EventType eventType, HookAction action)
        {
            if (!_eventHooks.TryGetValue(eventType, out var actions))
            {
                actions = new List<HookAction>();
                _eventHooks.Add(eventType, actions);
            }

            actions.Add(action);
        }

        public static Style Create(string name, Dictionary<string, object> config, Style baseStyle)
        {
            var style = new Style(name, baseStyle);

            foreach (var entry in config)
            {
                var typeFilter = entry.Key.Trim();
                var value = entry.Value;

                if (typeFilter.StartsWith("["))
                {
                    if (!typeFilter.EndsWith("]"))
                        throw new ArgumentException($"Invalid type filter or event name: '{typeFilter}'");

                    var eventName = typeFilter.Substring(1, typeFilter.Length - 2).ToLower();

                    if (eventName == "defaultcolorscheme")
                    {
                        style._colorScheme = ColorSchemeRegistry.Get((string)value);
                        continue;
                    }

                    if (eventName == "defaultfont")
                    {
                        style._defaultFont = value.ToString();
                        continue;
                    }

                    var enumNames = typeof(EventType).GetEnumNames();
                    var enumValues = (EventType[])typeof(EventType).GetEnumValues();
                    var found = false;
                    for (var i = 0; i < enumNames.Length; ++i)
                    {
                        if (enumNames[i].ToLower() == eventName)
                        {
                            style.AddEventHook(enumValues[i], HookAction.Create(value));
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

                        if (HookAction.CanTakeAsScript(value))
                        {
                            style.AddDecorator(type, prop, HookAction.Create(value));
                        }
                        else
                        {
                            var v = TypeAdaptors.Helpers.ConvertObjectType(prop.PropertyType, value);
                            style.AddDecorator(type, prop, v);
                        }
                    }
                }
            }

            return style;
        }

        public static Style Create(string name, Hashtable config, Style baseStyle)
        {
            var c = new Dictionary<string, object>();

            foreach (DictionaryEntry entry in config)
                c.Add((string)entry.Key, entry.Value);

            return Create(name, c, baseStyle);
        }

        public void ApplyStyleTo(object target)
        {
            if (target == null)
                return;

            var type = target.GetType();

            if (_decorators.TryGetValue(type, out var decorators))
            {
                foreach (var d in decorators)
                {
                    if (d.Value is HookAction a)
                        a.Invoke(target, this);
                    else
                        d.Property.SetValue(target, d.Value);
                }
            }

            if (_typeHooks.TryGetValue(type, out var actions))
            {
                foreach (var a in actions)
                    a.Invoke(target, this);
            }
        }

        public void ApplyEventHook(PlotModel model, EventType e)
        {
            if (!_eventHooks.TryGetValue(e, out var actions))
                return;

            foreach (var a in actions)
                a.Invoke(model, this);
        }

        public void ApplyColorScheme(PlotModel model)
        {
            ColorSchemeHelper.ApplyColorScheme(model, _colorScheme);
        }
    }
}
