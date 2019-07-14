Set-StrictMode -Version Latest

$modulePath = Split-Path -Parent (Get-Module oxyplotcli).Path

$params = @{
    OutFile = "$PSScriptRoot\images\ColumnSeries.png"
    OutWidth = 800
    OutHeight = 800
}

Import-Csv $modulePath\datasets\r\titanic.csv |
    Group-Object Class, Survived |
    Select-Object `
        @{ n="Class"; e={ ($_.Name -split ",")[0] } },
        @{ n="Survived"; e={ if (($_.Name -split ",")[1] -match "Yes") { "Survived" } else { "Dead" } } },
        @{ n="Count"; e={ $_.Group | Measure-Object -Sum Freq | Select-Object -Expand Sum } } |
    oxy.col -CategoryName Class -ValueName Count -GroupName Survived -IsStacked $true |
    oxy.model -title "Titanic Survivors" @params
