param(
    [Hashtable]$OutParams = @{ Show = $true }
)

Set-StrictMode -Version Latest

$modulePath = Split-Path -Parent (Get-Module oxyplotcli).Path

Import-Csv $modulePath\datasets\r\iris.csv |
    oxy.hist2 -DataName Sepal.Width -GroupName Species |
    oxy.model -Title "Sepal Widths by Species" @OutParams
