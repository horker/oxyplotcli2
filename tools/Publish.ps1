$key = cat $PSScriptRoot\..\private\NugetApiKey.txt

Publish-Module -Path $PSScriptRoot\..\module\oxyplotcli -NugetApiKey $key -Verbose
