param(
    [Hashtable]$OutParams = @{ Show = $true }
)

Set-StrictMode -Version Latest

$modulePath = Split-Path -Parent (Get-Module oxyplotcli).Path

Import-Csv $modulePath\datasets\r\iris.csv |
    oxy.boxPlot -CategoryName Species -DataName Sepal.Width |
    oxy.model -Title "Sepal Widths by Species" @OutParams
