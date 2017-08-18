$currentDirectory = split-path $MyInvocation.MyCommand.Definition

# Setup Variables we need to pass into the sign client tool
$appSettings = "$currentDirectory\SignClientSettings.json"
$appPath = "$currentDirectory\SignClient\tools\SignClient.dll"

$nupkg = Get-ChildItem $currentDirectory\..\DocumentFormat.OpenXML\*.nupkg -Recurse

if($nupkg.Count -ne 1)
{
    throw  "Should only find 1 nupkg"
}

# See if we have the ClientSecret available
if(![string]::IsNullOrEmpty($env:SignClientSecret)){
    Write-Host "Submitting $nupkg for signing"

    dotnet $appPath 'zip' -c $appSettings -i $nupkg -s $env:SignClientSecret -n 'DocumentFormat.OpenXML' -d 'DocumentFormat.OpenXML' -u 'https://github.com/OfficeDev/Open-XML-SDK' 

    Write-Host "Finished signing $nupkg"
} else {
    Write-Host "Client Secret not found, not signing package $nupkg"
}

appveyor PushArtifact $nupkg
