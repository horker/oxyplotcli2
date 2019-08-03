[CmdletBinding()]
param(
    [string]$CmdletName,
    [string]$SourceDir = "$PSScriptRoot\..\docs\generated",
    [string]$DestinationDir = "$PSScriptRoot\..\docs\autofilled",
    [xml]$XmlDocument = (Get-Content "$PSScriptRoot\OxyPlot.xml")
)

Set-StrictMode -Version Latest

############################################################
# Setup
############################################################

$inFile = Join-Path $SourceDir "$CmdletName.md"
$outFile = Join-Path $DestinationDir "$CmdletName.md"

$objectName = $CmdletName -replace "New-Oxy", ""

if ($objectName -eq "HistogramSeries2") {
    $className = "OxyPlot.Series.ColumnSeries"
}
elseif ($objectName.EndsWith("Series")) {
    $className = "OxyPlot.Series.$objectName"
}
elseif ($objectName.EndsWith("Axis")) {
    $className = "OxyPlot.Axes.$objectName"
}
elseif ($objectName.EndsWith("Annotation")) {
    $className = "OxyPlot.Annotations.$objectName"
}
else {
    $className = "OxyPlot.$objectName"
}

Write-Verbose $className

$HelpItems = & "$PSScriptRoot\Get-HelpItems.ps1" $objectName $className $XmlDocument

############################################################
# Get-ParameterDescription
############################################################

function Get-ParameterDescription {
    param(
        [string]$Name
    )

    if ($Name -eq "AxType") {
        return "Specifies the (partial) type name of the x-axis."
    }

    if ($Name -eq "AyType") {
        return "Specifies the (partial) type name of the y-axis."
    }

    if ($Name -eq "AzType") {
        return "Specifies the (partial) type name of the series-specific additional axis."
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

    return $HelpItems.Parameters[$Name]
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
        [void]$out.AppendLine($HelpItems.Synopsis)
        [void]$out.AppendLine()
        $skipToNextSection = $true
    }
    elseif ($line -match "^## DESCRIPTION") {
        [void]$out.AppendLine($line)
        [void]$out.AppendLine()
        [void]$out.AppendLine($HelpItems.Description)
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
        foreach ($l in $HelpItems.Links) {
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
