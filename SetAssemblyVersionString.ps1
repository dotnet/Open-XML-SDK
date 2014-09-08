"PowerShell script for creating AssemblyInfo.cs with the correct version string."
"Licensed under the Apache License, Version 2.0."
"See License.txt in the project root for license information."

function GetVersionString
{
    # Released, signed by Microsoft OpenXmlSdk version number is 2.5.5631.0

    # This script will always result in a version number greater than this.
    # This script hard codes major version = 2, minor version = 5.
    # The version number will only depend on the day and not on the time as
    # defined in the original script, because the Debug and Release DLLs would
    # typically have different version strings even in a batch build. 
    # By ignoring hours and minutes, DLLs produced on the same day will have the 
    # same version string.

    $major = [int]2;
    $minor = [int]5;

    $nowDate = [DateTime]::UtcNow
    $referenceDate = New-Object DateTime(2014, 6, 1);
    $delta = [TimeSpan]($nowDate - $referenceDate);
    $third = [int]($delta.TotalDays + 5632);
    $fourth = 0;
    $versionString = [string]::Format("{0}.{1}.{2}.{3}", $major, $minor, $third, $fourth);
    return $versionString
}

function WriteAssemblyVersionString($versionString)
{
    # Produce new AssemblyInfo.cs using version string
    gc .\src\ofapi\Properties\AssemblyInfo.cs.source | % { $_ -replace "2.0.3302.0", "$versionString" } > .\src\ofapi\Properties\AssemblyInfo.cs

    # Remember last used version string
    sc .\build\version.txt $versionString
}

function SetAssemblyVersionString
{
    # Compute new version string.
    $computedVersion = GetVersionString

    if (test-path .\build\version.txt)
    {
        # version.txt file exists, so read last-used version string
        $lastVersion = gc .\build\version.txt

        # Write AssemblyInfo.cs if computed version is different from last used version
        if ($lastVersion -ne $computedVersion)
        {
            WriteAssemblyVersionString $computedVersion
        }
    }
    else
    {
        # version.txt file does not exist, so write AssemblyInfo.cs
        WriteAssemblyVersionString $computedVersion

    }    

}

. SetAssemblyVersionString