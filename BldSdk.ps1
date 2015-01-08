"PowerShell script for building the Open XML SDK - June 22, 2014"
"Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved."
"Licensed under the Apache License, Version 2.0."
"See License.txt in the project root for license information."

function Main {
    param (
        $a
    )

    if ($a[0] -eq "clean") {
        if ([string]$a[1] -eq "debug" -or [string]$a[1] -eq "all") {
            Clean "debug"
        }
        if ([string]$a[1] -eq "release" -or [string]$a[1] -eq "all") {
            Clean "release"
        }
        if ([string]$a[1] -eq "all") {
            if (Test-Path -Path "build") {
                RemoveDir "build"
            }
        }
    }
    elseif ($a[0] -eq "build") {
        # Make the version string

        $paramVersion = GetVersionString;
        "Setting assembly version to " + $paramVersion

        if ($a[1] -eq "debug" -or $a[1] -eq "all") {
            Clean "debug"
            Build "debug" $paramVersion $env:OPENXMLDLL
        }
        if ($a[1] -eq "release" -or $a[1] -eq "all") {
            Clean "release"
            Build "release" $paramVersion $env:OPENXMLDLL
        }
    }
}

function Build
{
    param (
        [string] $config,
        [string] $paramVersion,
        [string] $openxmldll
    )

    SetEnvironmentVariables $config
    CreateBuildDirectories

    "Building $config"

    # (Build tools need the DEBUG condition defined for both Debug/Release. Don't remove the nmake option "/E VDEBUG=1".)

    gc .\src\ofapi\Properties\AssemblyInfo.cs.source | % { $_ -replace "2.0.3302.0", "$paramVersion" } > .\src\ofapi\Properties\AssemblyInfo.cs

    # ==================================== Build Open XML SDK ====================================
    "Building Open XML SDK"
    nmake -f .\src\ofapi\makefile 
}

function SetEnvironmentVariables
{
    param (
        [string] $config
    )

    $env:MAKEFILE_DEF = 'makefile.def'
    $env:DIR_TOOLS_BIN_URT_WPF = 'C:/Windows/Microsoft.NET/Framework/v4.0.30319/WPF'
    if ($config -eq "debug") {
	    $env:VDEBUG = 1
	    $env:CONFIG = "Debug"
    }
    else {
	    $env:VDEBUG = ""
	    $env:CONFIG = "Release"
    }
    $env:OPENXMLDLL = "DocumentFormat.OpenXml.dll"
    $env:OPENXMLDLLDOC = "DocumentFormat.OpenXml.xml"
}

function CreateBuildDirectories
{
    $c = $env:CONFIG;
    MakeDir "./build"
    MakeDir "./build/OpenXmlSdkLib/$c"
}

function MakeDir
{
    param (
        [string] $dir
    )

    if (!(Test-Path -path "$dir")) {
        New-Item "$dir" -type directory | out-null
    }
}

function RemoveDir
{
    param (
        [string] $dir
    )

    if (Test-Path -path $dir) {
        Remove-Item -Recurse -Force $dir
    }
}

function Clean
{
    param (
        [string] $config
    )

    SetEnvironmentVariables $config
    CreateBuildDirectories
    "Cleaning $config"
    nmake -f ./src/ofapi/makefile clean
    if (Test-Path -Path ".\src\ofapi\Properties\AssemblyInfo.cs") {
        Remove-Item -Force ".\src\ofapi\Properties\AssemblyInfo.cs"
    }
}

function GetVersionString
{
    # released, signed by Microsoft OpenXmlSdk version number is 2.5.5631.0

    # This script will always result in a version number greater than this.
    # This script hard codes major version = 2, minor version = 5

    $major = [int]2;
    $minor = [int]5;

    $nowDate = [DateTime]::Now
    $referenceDate = New-Object DateTime(2014, 6, 1);
    $delta = [TimeSpan]($nowDate - $referenceDate);
    $third = [int]($delta.TotalDays + 5632);
    $fourth = [int]($nowDate.Hour * 60 + $nowDate.Minute);
    $versionString = [string]::Format("{0}.{1}.{2}.{3}", $major, $minor, $third, $fourth);
    return $versionString
}

$usage = "usage: ./BldSdk.ps1 (build all)" + [Environment]::NewLine +
         "usage: ./BldSdk.ps1 build (all)" + [Environment]::NewLine +
         "usage: ./BldSdk.ps1 clean (all)" + [Environment]::NewLine +
         "usage: ./BldSdk.ps1 { build | clean } { debug | release | all }"

if ($args.Length -eq 0) {
    $args = ("build", "all")
    . Main $args
}
else {
    if ($args.Length -eq 1 -and ($args[0] -eq "clean" -or $args[0] -eq "build")) {
        $args = ($args[0], "all")
        . Main $args
    }
    else {
        if ($args.Length -eq 2) {
            if (($args[0] -eq "build" -or $args[0] -eq "clean") -and
                ($args[1] -eq "debug" -or $args[1] -eq "release" -or $args[1] -eq "all")) {
                . Main $args
            }
            else {
                $usage
            }
        }
        else {
            $usage
        }
    }
}
