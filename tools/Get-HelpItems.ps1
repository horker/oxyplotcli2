[cmdletbinding()]
param(
  [string]$ObjectName,
  [string]$ClassName,
  [string]$Prefix,
  [xml]$HelpDocument = (Get-Content "$PSScriptRoot\OxyPlot.xml")
)

Set-StrictMode -Version 3

############################################################
# Get-PlainText
############################################################

$links = New-Object Collections.Generic.List[string]

function Get-PlainText {
  param(
    [xml.XmlElement]$Xml
  )

  if ($null -eq $Xml) {
    return
  }

  $out = New-Object Text.StringBuilder

  foreach ($node in $Xml.ChildNodes) {
    switch ($node.Name) {
      "#text" {
        # Modify descriptions for properties to those for cmdlet parameters
        $s = $node.InnerText -replace "^\s*Gets or sets ", "Sets "

        # .NET XML component returns multiple lines that end with LF.
        $s = $s -replace "`n", "`r`n"

        [void]$out.Append($s)
      }
      "see" {
        if ($node.SelectSingleNode("@cref")) {
            [void]$out.Append(($node.cref -replace "^.:", ""))
        }
        elseif ($node.SelectSingleNode("@href")) {
            [void]$out.Append("`r`n`r`nSee $($node.href).")
            $links.Add($node.href)
        }
        else {
            Write-Error "Invalid node: $($node.ToString())"
        }
      }
      "a" {
        $text = Get-PlainText $node
        [void]$out.Append("[$text]($($node.href))")
        $links.Add($node.href)
      }
      "value" {
        # Skip the <value> element because it contains little valuable information
      }
      default {
        [void]$out.Append((Get-PlainText $node))
      }
    }
  }

  if ($Xml.Name -eq "summary" -or $Xml.Name -eq "remarks" -or $Xml.Name -eq "para") {
    [void]$out.Append("`r`n")
  }

  $out.ToString().TrimStart() -replace "[ \t]+", " "
}

############################################################
# Get-DefaultParameterItems
############################################################

function Get-DefaultParamterItems {
    $result = @{
        InputObject = "Specifies a dataset that represents the data points of the series."
        Group = "Specifies groups to which each data point belongs. If this parameter is specified, the data points will be grouped by these values, and multiple series will be produced for each group."
        GroupName = "Specifies the property name of the input object to be treated as groups."
        Style = "Specifies the style."
        AddTo = "Specifies the PlotModel object to which the object is added."
        OutFile = "Specifies the output file name. The output format is determined based on the file extension, which should be either `".png`" or `".svg`"."
        OutWidth = "Specifies the width of the output image. Use with the -OutFile parameter."
        OutHeight = "Specifies the height of the output image. Use with the -OutFile parameter."
        SvgIsDocument = "Indicates that a SVG file should be generated as a complete document. Use with the -OutFile parameter."
        AsUIElement = "Returns an object as a PlotView object."
        Show = "Shows the chart in the GUI window."
        ReuseWindow = "Indicates to reuse the most recently used window to show the chart instead of creating a new one. Use with the -Show parameter."
        PassThru = "Returns a created object when the -AddTo, -OutFile or -Show parameter is specified."
    }

    if ($ClassName.EndsWith("Series")) {
        $c = Invoke-Expression "[$ClassName]"
        $itemNames = [Horker.OxyPlotCli.SeriesBuilders.SeriesBuilderStore]::OfType($c).DataPointItemNames
        foreach ($i in $itemNames) {
            $result[$i + "Name"] = "Specifies the property name of the input object to be processed as the element $i of the data point."
            $result[$i] = "Specifies the sequence of the element $i of the data point."
        }
    }

    $result
}

############################################################
# Class description
############################################################

$members = $HelpDocument.doc.members.member

if ($ObjectName -eq "HistogramSeries2") {
    $desc = "represents a histogram."
}
else {
    $desc = $members |
        where { $_.name -match "^T:" -and $ClassName -Contains ($_.name -replace "^.:") }
    $desc = Get-PlainText $desc
}

if ($null -eq $desc) {
    Write-Error "$ClassName not found"
    exit
}

$synopsis = "Returns an object that " + $desc.Substring(0, 1).ToLower() + $desc.Substring(1)
$description = $synopsis

############################################################
# Properties
############################################################

$h = @{}
$c = Invoke-Expression "[$ClassName]"
while ($c) {
    $h[$c.FullName] = 1
    $c = $c.BaseType
}

$classes = $h.Keys

$props = $members |
    where { $_.name -match "^P:" -and $_.name -notmatch "#ctor$" } |
    where { $classes -Contains ($_.name -replace "^.:", "" -replace "\.([^.]+)$") }

$params = Get-DefaultParamterItems

foreach ($p in $props) {
    $params["$Prefix$($p.name -replace "^.+\.", '')"] = Get-PlainText $p
}

############################################################
# Results
############################################################

[PSCustomObject]@{
    Synopsis = $synopsis
    Description = $description
    Parameters = $params
    Links = $links
}
