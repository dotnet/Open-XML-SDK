#!/bin/bash

# Restore all NuGet packages
nuget restore Open-XML-SDK.sln

# Build the solution
xbuild /p:Configuration=Release Open-XML-SDK.sln

# Run unit tests
# Note that these will not even run at the moment due to a bug in Mono (last tested on Mono 4.0.2 on Mac OS X).
# Once they run, they will likely fail due to an issue with System.IO.Compression on Mono.
mono ./packages/xunit.runner.console.2.0.0/tools/xunit.console.exe System.IO.Packaging.Tests/bin/Release/System.IO.Packaging.Tests.dll
mono ./packages/xunit.runner.console.2.0.0/tools/xunit.console.exe DocumentFormat.OpenXml.Tests/bin/Release/DocumentFormat.OpenXml.Tests.dll
