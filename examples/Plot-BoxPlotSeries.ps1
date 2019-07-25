Set-StrictMode -Version Latest

$modulePath = Split-Path -Parent (Get-Module oxyplotcli).Path

$params = @{
    OutFile = "$PSScriptRoot\images\BoxPlotSeries.png"
    OutWidth = 800
    OutHeight = 800
}

Import-Csv $modulePath\datasets\r\iris.csv |
    oxy.boxPlot -CategoryName Species -DataName Sepal.Width |
    oxy.model -Title "Sepal Widths by Species" @params
