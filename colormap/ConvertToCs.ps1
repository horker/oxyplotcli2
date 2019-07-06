# Commandline:
# .\ConvertToCs.ps1 | sc ..\source\Horker.OxyPlotCli\Matplotlib\MatplotlibColormaps.cs

Set-StrictMode -Version Latest
$doc = Get-Content "$PSScriptRoot\colormaps.py"

@"
// This code is converted from the following file:
//     https://github.com/BIDS/colormap/blob/master/colormaps.py
//
// The following comment is the original copyright notice:
//
// New matplotlib colormaps by Nathaniel J. Smith, Stefan van der Walt,
//  and (in the case of viridis) Eric Firing.
//
//  This file and the colormaps in it are released under the CC0 license /
//  public domain dedication. We would appreciate credit if you use or
//  redistribute these colormaps, but do not impose any legal restrictions.
//
//  To the extent possible under law, the persons who associated CC0 with
//  mpl-colormaps have waived all copyright and related or neighboring rights
//  to mpl-colormaps.
//
//  You should have received a copy of the CC0 legalcode along with this
//  work.  If not, see <http://creativecommons.org/publicdomain/zero/1.0/>."

using OxyPlot;

namespace Horker.OxyPlotCli.Styles
{
    public static class MatplotlibColormaps
    {
        private static OxyColor GetOxyColor(double r, double g, double b)
        {
            return OxyColor.FromRgb((byte)(r * 255), (byte)(g * 255), (byte)(b * 255));
        }

"@

foreach ($line in $doc) {
    $orig = $line
    $line = $line -replace "^\s*_+(\w+)_data\s*=\s*\[", "        public static readonly OxyColor[] `$1 = new[] {"
    $line = $line -replace "]]$", "]};"
    $line = $line -replace "\[([\d\., ]+)\]", "GetOxyColor(`$1)"
    if ($orig -ne $line) {
        $line
    }
}

@"
    }
}
"@
