param(
    [Hashtable]$OutParams = @{ Show = $true }
)

Set-StrictMode -Version Latest

$modulePath = Split-Path -Parent (Get-Module oxyplotcli).Path

$model = Import-Csv $modulePath\datasets\stock\ORCL.csv | where { $_.Date.StartsWith("2017-") } |
    oxy.candlev -XName Date -OpenName Open -HighName High -LowName Low -CloseName Close -BuyVolumeName Volume `
    -AxType DateTime -AxStringFormat "yyyy/MMM" -AxIntervalType Months -AxTitle "Date" `
    -AyTitle "Price" `
    -AzTitle "Volume" -AzStringFormat "n0"

$model | oxy.model -Title "Historical Stock Prices (ORCL 2017)" @OutParams
