@echo off

REM Restore NuGet packages
.nuget\nuget.exe restore Open-XML-SDK.sln

REM Build release
set FrameworkVersion=v4.0.30319
set FrameworkDir=%SystemRoot%\Microsoft.NET\Framework

if exist "%SystemRoot%\Microsoft.NET\Framework64" (
  set FrameworkDir=%SystemRoot%\Microsoft.NET\Framework64
)

"%FrameworkDir%\%FrameworkVersion%\msbuild.exe" /p:Configuration=Release Open-XML-SDK.sln

REM Run tests
packages\xunit.runner.console.2.0.0\tools\xunit.console.exe System.IO.Packaging.Tests\bin\Release\System.IO.Packaging.Tests.dll
packages\xunit.runner.console.2.0.0\tools\xunit.console.exe DocumentFormat.OpenXml.Tests\bin\Release\DocumentFormat.OpenXml.Tests.dll
