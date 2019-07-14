Set-StrictMode -Version Latest

$modulePath = Split-Path -Parent (Get-Module oxyplotcli).Path

$params = @{
    OutFile = "$PSScriptRoot\images\CandleStickAndVolumeSeries.png"
    OutWidth = 1200
    OutHeight = 1200
}

$global:model = Import-Csv $modulePath\datasets\stock\ORCL.csv | where { $_.Date.StartsWith("2017-") } |
    oxy.candlev -XName Date -OpenName Open -HighName High -LowName Low -CloseName Close -BuyVolumeName Volume `
    -AxType DateTime -AxStringFormat "yyyy/MMM" -AxIntervalType Months -AxTitle "Date" `
    -AyTitle "Price" `
    -AzTitle "Volume" -AzStringFormat "n0"

$model | oxy.model -Title "Historical Stock Prices (ORCL)" @params
