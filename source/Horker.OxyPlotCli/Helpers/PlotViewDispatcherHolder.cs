using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using Horker.OxyPlotCli.Wpf;

namespace Horker.OxyPlotCli.Helpers
{
    public class PlotViewDispatcherHolder
    {
        private static Dispatcher _dispatcher = null;

        public static Dispatcher Get()
        {
            if (_dispatcher == null)
                return WpfWindow.RootWindow.Dispatcher;

            return _dispatcher;
        }

        public static void Set(Dispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }
    }
}
