param([Parameter(Mandatory = $true)] $version)

$root = "$PSScriptRoot\..\"
Write-Host "Updating version to $version"

$project = "$root\DocumentFormat.OpenXml\project.json"
$content = Get-Content $project
$newcontent = $content.Replace("`"version`": `"3.0.0-*`"","`"version`": `"$version`"")
Set-Content $project $newcontent

$project = "$root\DocumentFormat.OpenXml.Tests\project.json"
$content = Get-Content $project
$newcontent = $content.Replace("`"DocumentFormat.OpenXml`": `"3.0.0-*`"","`"DocumentFormat.OpenXml`": `"$version`"")
Set-Content $project $newcontent