param(
    [Hashtable]$OutParams = $null
)

$OutPath = "$PSScriptRoot\images"

if (-not (Test-Path $OutPath)) {
    New-Item -Type Directory -Name $OutPath
}

$commandName = $MyInvocation.MyCommand.Name

dir $PSScriptRoot\*.ps1 | foreach {
    if ($_.Name -notmatch $commandName) {
        Write-Host $_

        $p = $OutParams
        if ($null -eq $p) {
            $outFile = $_.Name -Replace "^Plot-(\w+).ps1", "$OutPath\`$1.png"
            if ($outFile -Match "Summary") {
                $p = @{ OutFile = $outFile; OutWidth = 1600; OutHeight = 1600 }
            }
            else {
                $p = @{ OutFile = $outFile; OutWidth = 800; OutHeight = 800 }
            }
        }

        & $_.FullName -OutParams $p
    }
}
