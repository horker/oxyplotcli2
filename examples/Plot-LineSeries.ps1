param(
    [Hashtable]$OutParams = @{ Show = $true }
)

Set-StrictMode -Version Latest

$r = New-Object Random 1234

function Get-RandomSequence {
    param(
        [int]$Size
    )

    $y0 = $r.NextDouble()
    $y0
    for ($i = 1; $i -lt $Size; ++$i) {
        $y0 + $r.NextDouble()
    }
}

$size = 100
$x = 0..($size-1)

$global:model = oxy.model -Title "Line Series Example"

$palette = Get-OxyPalette yellow, green 100

1..10 | foreach {
    $y = Get-RandomSequence $size
    $color = $palette.Colors[[int]([Math]::Abs($y[0]) * 100)]
    $series = oxy.line -X $x -Y $y -Color $color
    $model.Series.Add($series.Series[0])
}

$model | oxy.model @OutParams
