msbuild "/t:restore;build" /p:Configuration=Release /p:ProjectLoadStyle=All /m

$bin = [System.IO.Path]::Combine($PSScriptRoot, "bin", "release")
$output =  Join-Path $bin "benchmarks"
$net46output = Join-Path $output "net46"
$netcoreoutput = Join-Path $output "netcore"

Push-Location bin\Release\DocumentFormat.OpenXml.Benchmarks\net46
.\DocumentFormat.OpenXml.Benchmarks.exe "-output:$net46output"
Pop-Location

Push-Location bin\Release\DocumentFormat.OpenXml.Benchmarks\netcoreapp1.1
dotnet .\DocumentFormat.OpenXml.Benchmarks.dll "-output:$netcoreoutput"
Pop-Location

