[CmdletBinding()]
param(
    [string]$SourceDir = "$PSScriptRoot\..\docs\generated",
    [string]$DestinationDir = "$PSScriptRoot\..\docs\autofilled"
)

Set-StrictMode -Version Latest

$xmlDocument = [xml](Get-Content -Encoding utf8 "$PSScriptRoot\OxyPlot.xml")

get-command -module oxyplotcli |
    where { $_.Name -match "(Series2?|Axis|Annotation|PlotModel)$" } |
    select -expand Name |
    foreach {
        Write-Host $_
        & "$PSScriptRoot\Autofill-CmdletHelp.ps1" $_ $SourceDir $DestinationDir $xmlDocument
    }
