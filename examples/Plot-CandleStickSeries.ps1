Set-StrictMode -Version Latest

$modulePath = Split-Path -Parent (Get-Module oxyplotcli).Path

$params = @{
    OutFile = "$PSScriptRoot\images\CandleStickSeries.png"
    OutWidth = 800
    OutHeight = 800
}

$orcl = Import-Csv $modulePath\datasets\stock\ORCL.csv | where { $_.Date.StartsWith("2017-") } |
    oxy.candle -XName Date -OpenName Open -HighName High -LowName Low -CloseName Close -Title ORCL -YAxisKey orcl

$dji = Import-Csv $modulePath\datasets\stock\^DJI.csv | where { $_.Date.StartsWith("2017-") } |
    oxy.candle -XName Date -OpenName Open -HighName High -LowName Low -CloseName Close -Title "Dow Jones Index" -YAxisKey dji

$orclAxis = oxy.axis.linear -Key orcl -Position Left -Title "Price" -EndPosition .7
$djiAxis = oxy.axis.linear -Key dji -Position Right -Title "Price" -MajorGridlineStyle Dash -StartPosition .7
$xAxis = oxy.axis.dateTime -StringFormat "yyyy/MMM" -IntervalType Months -Title "Date"

$orcl, $dji | oxy.model -Axis $xAxis, $orclAxis, $djiAxis -Title "Historical Stock Prices" @params
