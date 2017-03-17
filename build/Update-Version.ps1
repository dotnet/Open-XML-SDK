param([Parameter(Mandatory = $true)] $version)

$root = "$PSScriptRoot\..\"
Write-Host "Updating version to $version"

$props = "$root\dir.props"
[xml]$dirprops = Get-Content $props
$dirprops.Project.PropertyGroup.VersionPrefix = $version
$dirprops.Save($props)
