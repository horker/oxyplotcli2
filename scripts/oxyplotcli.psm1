Set-StrictMode -Version Latest

# Define extension methods

function script:Define-PowerShellMethods {
    param(
        [Type]$Class,
        [Type]$MethodDefined
    )

    $flags = [Reflection.BindingFlags]::Static -bor [Reflection.BindingFlags]::Public
    foreach ($mi in $MethodDefined.GetMethods($flags)) {
        Update-TypeData -TypeName $Class -MemberName $mi.Name -MemberType CodeMethod -Value $mi -Force
    }
}

$typesAndMethods = (
    ([OxyPlot.PlotModel], [Horker.OxyPlotCli.PowerShellMethods.PlotModelMethods]),
    ([OxyPlot.Series.LineSeries], [Horker.OxyPlotCli.PowerShellMethods.SeriesMethods]),
    ([OxyPlot.Series.ScatterSeries], [Horker.OxyPlotCli.PowerShellMethods.SeriesMethods])
)

foreach ($tm in $typesAndMethods) {
    Define-PowerShellMethods $tm[0] $tm[1]
}

# Load style files

Get-ChildItem "$PSScriptRoot\styles\*.ps1" | foreach {
    . $_.FullName
}

# Set default style

Set-OxyDefaultStyle xl2016
