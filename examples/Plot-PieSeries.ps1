param(
    [Hashtable]$OutParams = @{ Show = $true }
)

Set-StrictMode -Version Latest

dir -file c:\windows |
    group Extension |
    oxy.pie -LabelName Name -ValueName Count -FontSize 16 -Diameter .8 |
    oxy.model -Title "File Extensions in the C:\Windows Directory" @OutParams
