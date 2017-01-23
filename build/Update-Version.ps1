param([Parameter(Mandatory = $true)] $version)

$root = "$PSScriptRoot\..\"
Write-Host "Updating version to $version"

$project = "$root\DocumentFormat.OpenXml\project.json"
$content = Get-Content $project
$newcontent = $content.Replace("`"version`": `"0.0.1-*`"","`"version`": `"$version`"")
Set-Content $project $newcontent

$project = "$root\DocumentFormat.OpenXml.Tests\project.json"
$content = Get-Content $project
$newcontent = $content.Replace("`"DocumentFormat.OpenXml`": `"0.0.1-*`"","`"DocumentFormat.OpenXml`": `"$version`"")
Set-Content $project $newcontent