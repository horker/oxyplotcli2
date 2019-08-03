task . Compile, Build, ImportDebug, Test

Set-StrictMode -Version 4

############################################################
# Settings
############################################################

$SOURCE_PATH = "$PSScriptRoot\source\bin"
$SCRIPT_PATH = "$PSScriptRoot\scripts"

$MODULE_PATH = "$PSScriptRoot\module\oxyplotcli"
$MODULE_PATH_DEBUG = "$PSScriptRoot\module\debug\oxyplotcli"

$MODULE_STYLE_PATH =   "$MODULE_PATH\styles"
$MODULE_STYLE_PATH_DEBUG =   "$MODULE_PATH_DEBUG\styles"

$SOLUTION_FILE = "$PSScriptRoot\source\oxyplotcli.sln"

$OBJECT_FILES = @(
  "Horker.OxyPlotCli.dll"
  "Horker.OxyPlotCli.pdb"
  "OxyPlot.dll"
  "OxyPlot.Wpf.dll"
)

#$TEMPLATE_INPUT_PATH = "$PSScriptRoot\templates"
#$TEMPLATE_OUTPUT_PATH = "$PSScriptRoot\source\Horker.PSCNTK\Generated files"

#$HELP_INPUT =  "$SOURCE_PATH\bin\Release\Horker.Math.dll"
#$HELP_INTERM = "$SOURCE_PATH\bin\Release\Horker.Data.dll-Help.xml"
#$HELP_OUTPUT = "$MODULE_PATH\Horker.Data.dll-Help.xml"
#$HELPGEN = "$PSScriptRoot\vendor\XmlDoc2CmdletDoc.0.2.10\tools\XmlDoc2CmdletDoc.exe"

############################################################
# Helper cmdlets
############################################################

function New-Folder2 {
  param(
    [string]$Path
  )

  try {
    $null = New-Item -Type Directory $Path -EA Stop
    Write-Host -ForegroundColor DarkCyan "$Path created"
  }
  catch {
    Write-Host -ForegroundColor DarkYellow $_
  }
}

function Copy-Item2 {
  param(
    [string]$Source,
    [string]$Dest,
    [switch]$Recurse
  )

  try {
    Copy-Item $Source $Dest -EA Stop -Recurse:$Recurse -Force
    Write-Host -ForegroundColor DarkCyan "Copy from $Source to $Dest done"
  }
  catch {
    Write-Host -ForegroundColor DarkYellow $_
  }
}

function Remove-Item2 {
  param(
    [string]$Path
  )

  Resolve-Path $PATH | foreach {
    try {
      Remove-Item $_ -EA Stop -Recurse -Force
      Write-Host -ForegroundColor DarkCyan "$_ removed"
    }
    catch {
      Write-Host -ForegroundColor DarkYellow $_
    }
  }
}

############################################################
# Tasks
############################################################

task Compile {
  msbuild $SOLUTION_FILE /p:Configuration=Debug /nologo /v:minimal
  msbuild $SOLUTION_FILE /p:Configuration=Release /nologo /v:minimal
}

task Build {
  . {
    $ErrorActionPreference = "Continue"

    function Copy-ObjectFiles {
      param(
        [string]$ObjectPath,
        [string]$TargetPath
      )

      # Scripts
      New-Folder2 $TargetPath
      Copy-Item2 "$SCRIPT_PATH\*" $TargetPath

      # Styles
      New-Folder2 "$TargetPath\styles"
      Copy-Item2 "$PSScriptRoot\styles\*" "$TargetPath\styles"

      # Datasets
      New-Folder2 "$TargetPath\datasets"
      Copy-Item2 "$PSScriptRoot\datasets\*" "$TargetPath\datasets" -Recurse

      # Help topics
      Copy-Item2 "$DOC_WORK\xml\*" "$TargetPath"

      # DLL files
      $OBJECT_FILES | foreach {
        $path = Join-Path $objectPath $_
        Copy-Item2 $path $targetPath
      }
    }

    Copy-ObjectFiles "$SOURCE_PATH\Release" $MODULE_PATH
    Copy-ObjectFiles "$SOURCE_PATH\Debug" $MODULE_PATH_DEBUG
  }
}

task Test Build, ImportDebug, {
  Invoke-Pester "$PSScriptRoot\tests"
}

task ImportDebug {
    Import-Module $MODULE_PATH_DEBUG -Force
}

task Clean {
  Remove-Item2 "$MODULE_PATH\*"
  Remove-Item2 "$MODULE_PATH_DEBUG\*"
}

############################################################
# Building Help topics
############################################################

$DOC_ROOT = "$PSScriptRoot\docs"
$DOC_WORK = "$DOC_ROOT\work"
$DOC_OUT = "$DOC_ROOT\cmdlets"

task GenerateBaseHelpFile {
    New-MarkdownHelp -Module oxyplotcli -OutputFolder $DOC_WORK\generated -Locale en-US -UseFullTypeName -Force
}

task AutofillHelp {
    tools\Autofill-AllCmdletHelps.ps1 $DOC_WORK\generated $DOC_WORK\autofilled
}

task UpdateHandwrittenHelp {
    Update-MarkdownHelp -Path $DOC_WORK\handwritten -UseFullTypeName -Force
}

task CompileHelp {
    Copy-Item $DOC_WORK\autofilled\*.md $DOC_OUT
    Copy-Item $DOC_WORK\handwritten\*.md $DOC_OUT
    Copy-Item $DOC_OUT\*.md $DOC_WORK\xml_source

    # ***HACK***
    # platyPS gets panicked by too many cmdlet parameters in the markdown file.
    # To avoid this, just delete the contents of the SYNTAX section at all before invoking New-ExternalHelp.

    $file = "$DOC_WORK\xml_source\New-OxyCandleStickAndVolumeSeries.md"
    $doc = Get-Content -Encoding utf8 $file
    Clear-Content $file
    $skip = $false

    foreach ($_ in $doc) {
        if ($skip -and $_ -notmatch "^#") {
            continue
        }
        $skip = $false
        if ($_ -match "^## SYNTAX") {
            $skip = $true
        }
        $_ | Add-Content $file
    }

    New-ExternalHelp -Path $DOC_WORK\xml_source -OutputPath $DOC_WORK\xml -Force

    Remove-Item $DOC_WORK\xml_source\*
}
