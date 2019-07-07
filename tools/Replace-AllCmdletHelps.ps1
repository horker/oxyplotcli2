[CmdletBinding()]
param(
    [string]$SourceDir = "$PSScriptRoot\..\docs\generated",
    [string]$DestinationDir = "$PSScriptRoot\..\docs"
)

Set-StrictMode -Version Latest

get-command -module oxyplotcli |
    where { $_.Name -match "(Series|Axis|Annotation)$" } |
    select -expand Name |
    foreach {
        Write-Host $_
        & "$PSScriptRoot\Replace-CmdletHelp.ps1" $_ $SourceDir $DestinationDir
    }
