param(
    [Hashtable]$OutParams = @{ Show = $true }
)

Set-StrictMode -Version Latest

$modulePath = Split-Path -Parent (Get-Module oxyplotcli).Path

Import-Csv $modulePath\datasets\r\diamonds.csv |
    oxy.scat -XName carat -YName price -GroupName clarity |
    oxy.model -Title "Diamond Prices by Carats" @OutParams
