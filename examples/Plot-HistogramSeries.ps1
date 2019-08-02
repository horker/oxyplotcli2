param(
    [Hashtable]$OutParams = @{ Show = $true }
)

Set-StrictMode -Version Latest

$size = 100
$values = New-Object double[] $size
$random = New-Object Random 1234

for ($i = 0; $i -lt $size; ++$i) {
    # Pseudo normal distribution
    $values[$i] = $random.NextDouble() + $random.NextDouble() + $random.NextDouble() + $random.NextDouble() +
        $random.NextDouble() + $random.NextDouble() + $random.NextDouble() + $random.NextDouble() +
        $random.NextDouble() + $random.NextDouble() + $random.NextDouble() + $random.NextDouble()
}

oxy.hist -data $values -Normalize | oxy.model -Title "Normal Distibution" @OutParams
