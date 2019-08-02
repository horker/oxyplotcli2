param(
    [Hashtable]$OutParams = @{ Show = $true }
)

Set-StrictMode -Version Latest

$modulePath = Split-Path -Parent (Get-Module oxyplotcli).Path

$orcl = Import-Csv $modulePath\datasets\stock\ORCL.csv |
    where { $_.Date.StartsWith("2017-1") } |
    oxy.candle -XName Date -OpenName Open -HighName High -LowName Low -CloseName Close -YAxisKey orcl

$dji = Import-Csv $modulePath\datasets\stock\^DJI.csv |
    where { $_.Date.StartsWith("2017-1") } |
    oxy.candle -XName Date -OpenName Open -HighName High -LowName Low -CloseName Close -YAxisKey dji

$xAxis = oxy.axis.dateTime -StringFormat "yyyy/MMM/dd" -IntervalType Weeks -Title "Date"
$orclAxis = oxy.axis.linear -Key orcl -Position Left -Title "Price (ORCL)" -EndPosition .65
$djiAxis = oxy.axis.linear -Key dji -Position Right -Title "Price (DJI)" -MajorGridlineStyle Dash -StartPosition .7 -StringFormat "###,000"

$orclText = oxy.ann.text -text "ORCL" -TextPosition "2017/11/20", 50.2 -Background white -YAxisKey orcl
$djiText = oxy.ann.text -text "DJI" -TextPosition "2017/11/15", 23950 -Background white -YAxisKey dji

oxy.model -SeriesInfo $orcl, $dji `
    -Axis $xAxis, $orclAxis, $djiAxis `
    -Annotation $orclText, $djiText `
    -Title "Stock Prices: ORCL vs DJI" `
    @OutParams
