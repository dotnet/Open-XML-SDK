"PowerShell script for creating AssemblyInfo.cs with the correct version string."
"Licensed under the Apache License, Version 2.0."
"See License.txt in the project root for license information."

function GetVersionString
{
    # Released, signed by Microsoft OpenXmlSdk version number is 2.5.5631.0

    # This script will always result in a version number greater than this.
    # This script hard codes major version = 2, minor version = 5.
	# The version number will only depend on the hour and not on the minute as
	# defined in the original script, because the Debug and Release DLLs would
	# typically have different version strings even in a batch build. 
	# By ignoring minutes, DLLs produced during the same hour will have the 
	# same version string.

    $major = [int]2;
    $minor = [int]5;

    $nowDate = [DateTime]::Now
    $referenceDate = New-Object DateTime(2014, 6, 1);
    $delta = [TimeSpan]($nowDate - $referenceDate);
    $third = [int]($delta.TotalDays + 5632);
    # $fourth = [int]($nowDate.Hour * 60 + $nowDate.Minute);
    $fourth = [int]($nowDate.Hour * 60);
    $versionString = [string]::Format("{0}.{1}.{2}.{3}", $major, $minor, $third, $fourth);
    return $versionString
}

function SetAssemblyVersionString
{
	# Get new version string.
	$paramVersion = GetVersionString

	# Produce new AssemblyInfo.cs using new version string.
    gc .\src\ofapi\Properties\AssemblyInfo.cs.source | % { $_ -replace "2.0.3302.0", "$paramVersion" } > .\src\ofapi\Properties\AssemblyInfo.cs
}

. SetAssemblyVersionString