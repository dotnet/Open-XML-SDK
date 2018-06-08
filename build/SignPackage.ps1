$currentDirectory = split-path $MyInvocation.MyCommand.Definition

# Setup Variables we need to pass into the sign client tool
$appSettings = "$currentDirectory\SignClientSettings.json"
$appPath = "$currentDirectory\SignClient.exe"

$nupkg = Get-ChildItem $currentDirectory\..\bin\*.nupkg -Recurse

if($nupkg.Count -ne 1)
{
    throw  "Should only find 1 nupkg"
}

Write-Host "Found package: $nupkg"

# See if we have the ClientSecret available
if(![string]::IsNullOrEmpty($env:SignClientSecret)){
    Write-Host "Submitting $nupkg for signing"

    & $appPath 'sign' -c $appSettings -i $nupkg -r $env:SignClientUser -s $env:SignClientSecret -n 'DocumentFormat.OpenXML' -d 'DocumentFormat.OpenXML' -u 'https://github.com/OfficeDev/Open-XML-SDK' 

    Write-Host "Finished signing $nupkg"
} else {
    Write-Host "Client Secret not found, not signing package $nupkg"
}
