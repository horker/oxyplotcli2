Set-StrictMode -Version Latest

$modulePath = Split-Path -Parent (Get-Module oxyplotcli).Path

$params = @{
    OutFile = "$PSScriptRoot\images\HistogramSeries2.png"
    OutWidth = 1200
    OutHeight = 1200
}

Import-Csv $modulePath\datasets\r\iris.csv |
    oxy.hist2 -DataName Sepal.Width -GroupName Species |
    oxy.model -Title "Sepal Width by Species" @params
