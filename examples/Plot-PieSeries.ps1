Set-StrictMode -Version Latest

$params = @{
    OutFile = "$PSScriptRoot\images\PieSeries.png"
    OutWidth = 800
    OutHeight = 800
}

dir -file c:\windows |
    group Extension |
    oxy.pie -LabelName Name -ValueName Count |
    oxy.model -Title "Counting Extensions in the C:\Windows Directory" @params

