$size = 1000
$values = New-Object double[] $size
$random = New-Object Random

for ($i = 0; $i -lt $size; ++$i) {
    # Pseudo normal distribution
    $values[$i] = $random.NextDouble() + $random.NextDouble() + $random.NextDouble() + $random.NextDouble() +
        $random.NextDouble() + $random.NextDouble() + $random.NextDouble() + $random.NextDouble() +
        $random.NextDouble() + $random.NextDouble() + $random.NextDouble() + $random.NextDouble()
}

oxy.hist2 -data $values -Show
