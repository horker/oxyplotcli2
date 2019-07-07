[CmdletBinding()]
param(
    [string]$CmdletName,
    [string]$SourceDir = "$PSScriptRoot\..\docs\generated",
    [string]$DestinationDir = "$PSScriptRoot\..\docs"
)

Set-StrictMode -Version Latest

############################################################
# Setup
############################################################

$inFile = Join-Path $SourceDir "$CmdletName.md"
$outFile = Join-Path $DestinationDir "$CmdletName.md"

$objectName = $CmdletName -replace "New-Oxy", ""

if ($ObjectName.EndsWith("Series")) {
    $className = "OxyPlot.Series.$objectName"
}
elseif ($ObjectName.EndsWith("Axis")) {
    $className = "OxyPlot.Axes.$objectName"
}
else {
    $className = "OxyPlot.Annotations.$objectName"
}

Write-Verbose $className

$items = & "$PSScriptRoot\Get-HelpItems.ps1" $className

############################################################
# Get-ParameterDescription
############################################################

function Get-ParameterDescription {
    param(
        [string]$Name
    )

    if ($Name -eq "AxType") {
        return "Specifies the type name of the x-axis."
    }

    if ($Name -eq "AyType") {
        return "Specifies the type name of the y-axis."
    }

    if ($Name -eq "AzType") {
        return "Specifies the type name of the series-specific additional axis."
    }

    if ($Name -match "^A([xyz])(\w+)$") {
        $axis = $matches[1]
        if ($axis -eq "z") {
            $axis = "series-specific additional "
        }
        else {
            $axis = $axis + "-"
        }

        $propName = $matches[2]

        return "Specifies the $propName parameter of the $($axis)axis. For more details, refer to the help topic of the axis of interest."
    }

    return $items.Parameters[$Name]
}

############################################################

$out = New-Object Text.StringBuilder

$doc = Get-Content -Encoding utf8 $inFile
$skipToNextSection = $false
$skipToCodeBlock = $false

foreach ($line in $doc) {
    if ($skipToNextSection -and !$line.StartsWith("#")) {
        continue
    }
    if ($skipToCodeBlock -and !$line.StartsWith("#") -and !$line.StartsWith("``")) {
        continue
    }
    $skipToNextSection = $false
    $skipToCodeBlock = $false

    if ($line -match "^## SYNOPSIS") {
        [void]$out.AppendLine($line)
        [void]$out.AppendLine()
        [void]$out.AppendLine($items.Synopsis)
        [void]$out.AppendLine()
        $skipToNextSection = $true
    }
    elseif ($line -match "^## DESCRIPTION") {
        [void]$out.AppendLine($line)
        [void]$out.AppendLine()
        [void]$out.AppendLine($items.Description)
        [void]$out.AppendLine()
        $skipToNextSection = $true
    }
    elseif ($line -match "^## EXAMPLES") {
        $skipToNextSection = $true
    }
    elseif ($line -match "^### Example \d+") {
        $skipToNextSection = $true
    }
    elseif ($line -match "^## RELATED LINKS") {
        [void]$out.AppendLine($line)
        [void]$out.AppendLine()
        foreach ($l in $items.Links) {
            [void]$out.AppendLine("[$l]($l)")
        }
        $skipToNextSection = $true
    }
    elseif ($line -match "^### -(\w+)") {
        $desc = Get-ParameterDescription $matches[1]
        [void]$out.AppendLine($line)
        [void]$out.AppendLine()
        [void]$out.AppendLine($desc)
        [void]$out.AppendLine()
        $skipToCodeBlock = $true
    }
    else {
        [void]$out.AppendLine($line)
    }
}

$out.ToString() | Set-Content -Encoding utf8 $outFile
