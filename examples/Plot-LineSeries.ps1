Set-StrictMode -Version Latest

$params = @{
    OutFile = "$PSScriptRoot\images\LineSeries.png"
    OutWidth = 800
    OutHeight = 800
}

$r = New-Object Random 1234

function Get-RandomWalkSequence {
    param(
        [int]$Size
    )

    $v = 0
    for ($i = 0; $i -lt $Size; ++$i) {
        $v
        $v += $r.Next(3) - 1
    }
}

$size = 100
$x = 0..($size-1)

$global:model = oxy.model -Title "Random Walk"

$palette = Get-OxyPalette yellow, green 100

1..100 | foreach {
    $y = Get-RandomWalkSequence $size
    $color = $palette.Colors[([Math]::Abs($y[$size - 1]) / 30) * 100]
    $series = oxy.line -X $x -Y $y -InterpolationAlgorithm spline -Color $color
    $model.Series.Add($series.Series[0])
}

$model | oxy.model @params
