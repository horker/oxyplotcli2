using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Reflection;
using Horker.OxyPlotCli.Wpf;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Windows.Markup;
using System.Collections;
using System;

#pragma warning disable CS1591

namespace Horker.OxyPlotCli.Wpf
{
    public class WpfWindow
    {
        static private PropertyInfo IsDisposedMethod = typeof(Window).GetProperty("IsDisposed", BindingFlags.NonPublic | BindingFlags.Instance);

        static public bool IsWindowClosed(Window w)
        {
            return (bool)IsDisposedMethod.GetValue(w);
        }

        static private Window _rootWindow;
        static private PowerShell _powerShell;

        static public Window RootWindow
        {
            get
            {
                OpenRootWindow();
                return _rootWindow;
            }
        }

        public static bool IsRootWindowOpen()
        {
            return _rootWindow != null && !IsWindowClosed(_rootWindow);
        }

        public static void OpenRootWindow()
        {
            if (IsRootWindowOpen())
                return;

            var runspace = RunspaceFactory.CreateRunspace();
            runspace.ApartmentState = ApartmentState.STA;
            runspace.ThreadOptions = PSThreadOptions.UseNewThread;
            runspace.Open();

            _powerShell = PowerShell.Create();
            _powerShell.Runspace = runspace;

            var result = new List<Window>();
            var e = new AutoResetEvent(false);

            _powerShell.AddScript(@"
                param($result, $event)
                [Horker.OxyPlotCli.Wpf.WpfWindow]::OpenRootWindowInternal($result, $event)");
            _powerShell.AddParameter("result", result);
            _powerShell.AddParameter("event", e);

            _powerShell.BeginInvoke();

            e.WaitOne();

            _rootWindow = result[0];
        }

        public static void OpenRootWindowInternal(List<Window> result, AutoResetEvent e)
        {
            var window = new Window();
            window.AllowsTransparency = true;
            window.Background = Brushes.Transparent;
            window.WindowStyle = WindowStyle.None;
            window.ResizeMode = ResizeMode.NoResize;
            window.ShowInTaskbar = false;

            window.Loaded += (sender, args) => {
                Win32Api.MakeWindowInvisibleInTaskSwitcher((Window)sender);
            };

            result.Add(window);

            e.Set();

            window.ShowDialog();
        }

        public static Window OpenWindow(string xamlString, UIElement content, Hashtable options)
        {
            Window window = null;

            OpenRootWindow();

            RootWindow.Dispatcher.Invoke(delegate
            {
                if (xamlString != null)
                    window = (Window)XamlReader.Parse(xamlString);
                else
                    window = new Window();

                if (content != null)
                    window.Content = content;

                if (options != null)
                {
                    var type = window.GetType();
                    foreach (DictionaryEntry entry in options)
                    {
                        var prop = type.GetProperty(entry.Key.ToString());
                        if (prop == null)
                            throw new ArgumentException($"Property not found: {entry.Key}");

                        prop.SetValue(window, entry.Value);
                    }
                }

                window.Show();
            });

            return window;
        }
    }
}