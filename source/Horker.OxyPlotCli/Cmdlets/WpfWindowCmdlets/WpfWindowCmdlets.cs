using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Windows;
using System.Windows.Markup;
using Horker.OxyPlotCli.Wpf;

#pragma warning disable CS1591

namespace Horker.OxyPlotCli.Cmdlets
{
    [Cmdlet("New", "WpfWindow")]
    public class OpenWpfWindow : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public string XamlString { get; set; }

        [Parameter(Position = 1, Mandatory = false)]
        public UIElement Content { get; set; }

        [Parameter(Position = 2, Mandatory = false)]
        public Hashtable Options { get; set; }

        [Parameter(Position = 3, Mandatory = false)]
        public SwitchParameter PassThru { get; set; }

        protected override void BeginProcessing()
        {
            var window = WpfWindow.OpenWindow(XamlString, Content, Options);

            if (PassThru)
                WriteObject(window);
        }
    }

    [Cmdlet("Close", "WpfWindow")]
    public class CloseWpfWindow : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true)]
        public Window Window { get; set; }

        protected override void BeginProcessing()
        {
            Window.Dispatcher.Invoke(() => {
                Window.Close();
            });
        }
    }

    [Cmdlet("Invoke", "WpfWindowAction")]
    public class InvokeWpfWindowAction : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true)]
        public ScriptBlock Action { get; set; }

        protected override void BeginProcessing()
        {
            System.Collections.ObjectModel.Collection<PSObject> results = null;
            WpfWindow.RootWindow.Dispatcher.Invoke(() => {
                results = InvokeCommand.InvokeScript(false, Action, null);
            });

            foreach (var r in results)
                WriteObject(r);
        }
    }

    [Cmdlet("Test", "WpfWindowClosed")]
    public class TestWpfWindowClosed : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true)]
        public Window Window { get; set; }

        protected override void BeginProcessing()
        {
            WriteObject(WpfWindow.IsWindowClosed(Window));
        }
    }

    [Cmdlet("Get", "WpfWindowList")]
    public class GetWpfWindowList : PSCmdlet
    {
        protected override void BeginProcessing()
        {
            foreach (var w in WpfWindow.WindowList)
                WriteObject(w);
        }
    }
}