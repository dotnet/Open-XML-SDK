
$gitversion = gitversion | ConvertFrom-Json

Write-Host "Updating to $($gitversion.NuGetVersionV2)"

$props = "$PSScriptRoot\..\DocumentFormat.OpenXml.Package.props"
[xml]$xml = Get-Content $props

$xml.Project.PropertyGroup.Version = $gitversion.NuGetVersionV2
$xml.Project.PropertyGroup.AssemblyInformationalVersion = $gitversion.InformationalVersion

$xml.Save($props)