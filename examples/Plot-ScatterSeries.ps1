Set-StrictMode -Version Latest

$modulePath = Split-Path -Parent (Get-Module oxyplotcli).Path

$params = @{
    OutFile = "$PSScriptRoot\images\ScatterSeries.png"
    OutWidth = 800
    OutHeight = 800
}

Import-Csv $modulePath\datasets\r\diamonds.csv |
    oxy.scat -XName carat -YName price -GroupName clarity |
    oxy.model -Title "Diamond Prices" @params
