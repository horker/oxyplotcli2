Set-StrictMode -Version Latest

$params = @{
    OutFile = "$PSScriptRoot\images\FunctionSeries.png"
    OutWidth = 800
    OutHeight = 800
}

$s = oxy.func `
  -Fx "t => Math.Sin(t) * (Math.Exp(Math.Cos(t)) - 2 * Math.Cos(4 * t) - Math.Pow(Math.Sin(t / 12), 5))" `
  -Fy "t => Math.Cos(t) * (Math.Exp(Math.Cos(t)) - 2 * Math.Cos(4 * t) - Math.Pow(Math.Sin(t / 12), 5))" `
  -T0 0 -T1 ([Math]::PI * 24) -Dt 0.01

oxy.model -SeriesInfo $s -Title "Butterfly Curve" @params
