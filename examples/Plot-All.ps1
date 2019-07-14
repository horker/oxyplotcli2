$commandName = $MyInvocation.MyCommand.Name

dir $PSScriptRoot\*.ps1 | foreach {
    if ($_.Name -notmatch $commandName) {
        Write-Host $_
        & $_.FullName
    }
}
