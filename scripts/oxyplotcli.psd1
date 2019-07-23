#
# Module manifest for module 'oxyplotcli'
#
# Generated by: horker
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'oxyplotcli.psm1'

# Version number of this module.
ModuleVersion = '2.0.0'

# Supported PSEditions
#CompatiblePSEditions = ''

# ID used to uniquely identify this module
GUID = '10a77f13-43c9-4a13-b9ba-5215623f5941'

# Author of this module
Author = 'horker'

# Company or vendor of this module
CompanyName = 'horker'

# Copyright statement for this module
Copyright = '(c) 2019 horker. All rights reserved.'

# Description of the functionality provided by this module
Description = @"
PowerShell module for OxyPlot.

For more details, see https://github.com/horker/oxyplotcli2
"@

# Minimum version of the Windows PowerShell engine required by this module
# PowerShellVersion = ''

# Name of the Windows PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the Windows PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.5.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
# RequiredModules = @()

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = @(
    "OxyPlot.dll"
    "OxyPlot.Wpf.dll"
)

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @(
    "Horker.OxyPlotCli.dll"
)

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @(
    "Add-OxyAxisShare"
    "Add-OxyStyle"
    "Get-OxyColorScheme"
    "Get-OxyDefaultStyle"
    "Get-OxyPalette"
    "Get-OxyStyle"
    "New-OxyAngleAxis"
    "New-OxyAreaSeries"
    "New-OxyArrowAnnotation"
    "New-OxyBarSeries"
    "New-OxyBoxPlotSeries"
    "New-OxyCandleStickAndVolumeSeries"
    "New-OxyCandleStickSeries"
    "New-OxyCategoryAxis"
    "New-OxyCategoryColorAxis"
    "New-OxyColumnSeries"
    "New-OxyContourSeries"
    "New-OxyDateTimeAxis"
    "New-OxyEllipseAnnotation"
    "New-OxyErrorColumnSeries"
    "New-OxyFunctionAnnotation"
    "New-OxyFunctionSeries"
    "New-OxyGridView"
    "New-OxyHeatMapSeries"
    "New-OxyHighLowSeries"
    "New-OxyHistogramSeries"
    "New-OxyHistogramSeries2"
    "New-OxyImageAnnotation"
    "New-OxyIntervalBarSeries"
    "New-OxyLineAnnotation"
    "New-OxyLinearAxis"
    "New-OxyLinearBarSeries"
    "New-OxyLinearColorAxis"
    "New-OxyLineSeries"
    "New-OxyLogarithmicAxis"
    "New-OxyMagnitudeAxis"
    "New-OxyPieSeries"
    "New-OxyPlotModel"
    "New-OxyPointAnnotation"
    "New-OxyPolygonAnnotation"
    "New-OxyPolylineAnnotation"
    "New-OxyRangeColorAxis"
    "New-OxyRectangleAnnotation"
    "New-OxyRectangleBarSeries"
    "New-OxyRectangleSeries"
    "New-OxyScatterErrorSeries"
    "New-OxyScatterSeries"
    "New-OxyStairStepSeries"
    "New-OxyStemSeries"
    "New-OxyTextAnnotation"
    "New-OxyThreeColorLineSeries"
    "New-OxyTimeSpanAxis"
    "New-OxyTornadoBarSeries"
    "New-OxyTwoColorAreaSeries"
    "New-OxyTwoColorLineSeries"
    "New-OxyVolumeSeries"
    "Remove-OxyStyle"
    "Set-OxyDefaultStyle"
)

# Variables to export from this module
VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @(
    "oxy.2cArea"
    "oxy.2cLine"
    "oxy.3cLine"
    "oxy.ann.arrow"
    "oxy.ann.ellipse"
    "oxy.ann.function"
    "oxy.ann.image"
    "oxy.ann.line"
    "oxy.ann.point"
    "oxy.ann.polygon"
    "oxy.ann.polyline"
    "oxy.ann.rectangle"
    "oxy.ann.text"
    "oxy.area"
    "oxy.axis.angle"
    "oxy.axis.category"
    "oxy.axis.categoryColor"
    "oxy.axis.dateTime"
    "oxy.axis.linear"
    "oxy.axis.linearColor"
    "oxy.axis.logarithmic"
    "oxy.axis.magnitude"
    "oxy.axis.rangeColor"
    "oxy.axis.timeSpan"
    "oxy.bar"
    "oxy.box"
    "oxy.boxPlot"
    "oxy.candle"
    "oxy.candleStick"
    "oxy.candleStickAndVolume"
    "oxy.candlev"
    "oxy.col"
    "oxy.column"
    "oxy.contour"
    "oxy.ecol"
    "oxy.errorColumn"
    "oxy.func"
    "oxy.function"
    "oxy.gridView"
    "oxy.heat"
    "oxy.heatMap"
    "oxy.highLow"
    "oxy.hist"
    "oxy.hist2"
    "oxy.histogram"
    "oxy.histogram2"
    "oxy.ibar"
    "oxy.intervalBar"
    "oxy.lbar"
    "oxy.line"
    "oxy.linearBar"
    "oxy.model"
    "oxy.pie"
    "oxy.rbar"
    "oxy.rec"
    "oxy.rectangle"
    "oxy.rectangleBar"
    "oxy.scat"
    "oxy.scate"
    "oxy.scatter"
    "oxy.scatterError"
    "oxy.stair"
    "oxy.stairStep"
    "oxy.stem"
    "oxy.ThreeColorLine"
    "oxy.tornado"
    "oxy.tornadoBar"
    "oxy.twoColorArea"
    "oxy.twoColorLine"
    "oxy.volume"
)

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = @(
            'OxyPlot', 'cli',
            'chart', 'plot', 'graphic', 'line', 'bar', 'column', 'pie', 'histogram',
            'visualization', 'interactive', 'data', 'analysis',
            'wpf', 'window',
            'ggplot', 'matplotlib'
        )

        # A URL to the license for this module.
        LicenseUri = 'https://opensource.org/licenses/MIT'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/horker/oxyplotcli2'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = @"
v2.0.0.beta2
v2 beta2 release

v2.0.0-beta
v2 beta release
"@

        # Prerelease
        Prerelease = 'beta'

    } # End of PSData hashtable

} # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}
