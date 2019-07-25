Set-StrictMode -Version Latest

$params = @{
    OutFile = "$PSScriptRoot\images\HistogramSeries.png"
    OutWidth = 800
    OutHeight = 800
}

$size = 1000
$values = New-Object double[] $size
$random = New-Object Random 1234

for ($i = 0; $i -lt $size; ++$i) {
    # Pseudo normal distribution
    $values[$i] = $random.NextDouble() + $random.NextDouble() + $random.NextDouble() + $random.NextDouble() +
        $random.NextDouble() + $random.NextDouble() + $random.NextDouble() + $random.NextDouble() +
        $random.NextDouble() + $random.NextDouble() + $random.NextDouble() + $random.NextDouble()
}

oxy.hist -data $values -Normalize | oxy.model -Title "Normal Distibution" @params
