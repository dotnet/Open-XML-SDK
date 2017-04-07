Open-XML-SDK
============

Release Version 2.7

    News: The Office2016 branch on this repo contains a preview of the Open-Xml-Sdk v2.7, which
	supports the Office 2016 extensions in the file format.  The biggest change to the markup was
	the introduction of the ExtendedChartPart, which support the new chart types, such as Waterfall,
	Box and Whisker, and Sunburst.  You can specify FileFormatVersions.Office2016 to validate this
	markup.  This version of the SDK also supports using the strongly-typed OM to access the markup
	in the new parts.
	
	We will merge the Office2016 branch into vNext at some point in the future, after receiving
	feedback.

The Open XML SDK provides open-source libraries for working with Open XML Documents (DOCX, XLSX, and PPTX).  It supports scenarios such as:
- High-performance generation of word-processing documents, spreadsheets, and presentations.
- Populating content in DOCX files from an XML data source.
- Splitting up (shredding) a DOCX or PPTX file into multiple files, and combining
  multiple DOCX / PPTX files into a single file.
- High fidelity conversion of DOCX => HTML/CSS and HTML/CSS => DOCX.
- Extraction of data from XLSX.
- Searching and replacing content in DOCX / PPTX using regular expressions.
- Updating cached data and embedded spreadsheets for charts in DOCX / PPTX.
- Document modification, such as removing tracked revisions or removing
  unacceptable content from documents.

[Open-Xml-PowerTools](https://github.com/OfficeDev/Open-Xml-PowerTools) provides example code and guidance for implementing many of the above important Open XML scenarios.  Be sure to check it out
before re-inventing your own solutions.

Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.
Licensed under the Apache License, Version 2.0.
See License.txt in the project root for license information.

Portions of this project are licensed under the MIT license.
See MIT-License.txt in the project root for license information.


The Latest Builds
=================

##Where to get the NuGet package?
The NuGet package for Open XML SDK is currently available as a custom feed on MyGet. You can trust this package source, since the custom feed is locked and only this project feeds into the source.

##How to install the NuGet package?
The package you want to install is DocumentFormat.OpenXml. See https://dotnet.myget.org/gallery/open-xml-sdk 

The package feed or the package source is specified by the feed URL. Depending on your version of Visual Studio, choose the appropriate feed URL from the table below. 

Table 1: The latest builds are available via a MyGet feed

| Client | Feed URL |
| ------ | -------- |
| NuGet V3 (Visual Studio 2015+) | https://dotnet.myget.org/F/open-xml-sdk/api/v3/index.json |
| NuGet V2 (Visual Studio 2012+) | https://dotnet.myget.org/F/open-xml-sdk/api/v2 |

The **Install-Package** command considers the package source either via configuration or argument. Also the package version can vary. For the latest version info, see https://dotnet.myget.org/feed/open-xml-sdk/package/nuget/DocumentFormat.OpenXml 

- To specify the package source via a configuration option, see https://docs.microsoft.com/en-us/nuget/consume-packages/configuring-nuget-behavior. Note that usually a NuGet.config file is placed in the directory and the configuration options are added there to ensure the sources are persisted in the version control.

	```
	PM> Install-Package DocumentFormat.OpenXml -Version <version retrieved from the web>
	```

- To pass the feed URL as an argument, here is an example for Visual Studio 2015 and later. 

	```
	PM> Install-Package DocumentFormat.OpenXml -Version <version retrieved from the web> -Source https://dotnet.myget.org/F/open-xml-sdk/api/v3/index.json 
	```

**Note**:  If you have trouble installing the package, try restarting Visual Studio. Package sources could be cached, and changes you've made to any NuGet.config files may not be detected.
	
	
News
====
We are also happy to announce the release of Open-Xml-PowerTools on GitHub.  Open-Xml-PowerTools provides example code and guidance for implementing a wide range of Open XML scenarios.  You can find PowerTools for Open XML, which previously lived at [PowerTools.CodePlex.com](http://powertools.codeplex.com) at [github.com/OfficeDev/Open-Xml-PowerTools] https://github.com/OfficeDev/Open-Xml-PowerTools).

Change Log
==========

Version 2.7.1 : January 31, 2017
- Fixed crash when validation is invoked on .NET Framework with strong-naming enforced

Version 2.7.0 : January 24, 2017
- Added support for .NET Standard 1.3
- Moved to using System.IO.Packaging from dotnet/corefx for .NET Standard 1.3 and WindowsBase for .NET 4.5
- Cleaned up project build system to use .NET CLI

Version 2.6.1 : January 15, 2016
- Added hundreds of XUnit tests.  There are now a total of 1333 tests.  They take about 20 minutes to run, so be patient.

Version 2.6.0 : June 29, 2015
- The big feature in 2.6 is the inclusion of a replacement for System.IO.Packaging, which has a serious bug that causes it (albeit rarely and in specific circumstances) to throw exceptions (ObjectDisposedException and NullReferenceException).  You can find out more about this bug and whether it affects you in [the blog post that announces the release of the new System.IO.Packaging] (http://openxmldeveloper.org/blog/b/openxmldeveloper/archive/2015/06/29/announcing-the-release-of-a-new-system-io-packaging-implementation.aspx).


Documentation
=============

The functionality of the specific classes in Open XML SDK Version 2.7.0 is similar to version 2.5, therefore the documentation available on MSDN is still accurate.

[Open XML SDK 2.5 for Office](http://msdn.microsoft.com/en-us/library/office/bb448854.aspx)

In addition to open sourcing of the SDK, Microsoft has opened up the conceptual documentation for public review / contributions.  A copy of the documentation is [now in GitHub](https://github.com/OfficeDev/office-content) for you to edit and review.

Build Instructions
==================

This project uses the new csproj format and the release versions of the tooling in Visual Studio 2017. For more info on how to use this project type to build your project, see the release notes for Visual Studio 2017: https://www.visualstudio.com/en-us/news/releasenotes/vs2017-relnotes#dotnetcore

To build the Open XML SDK:
- Clone the repo at https://github.com/OfficeDev/Open-XML-SDK
- Open the solution with an editor that supports the latest .NET project files, such as Visual Studio 2017, VS Code, VS for Mac, or .NET CLI. See https://www.microsoft.com/net/download/core for details.
- Build the solution (using either Debug or Release configuration)
- Run the Xunit tests to verify the installation

If you want to use a command line approach:
- Go to the directory the solution is in
- Run `dotnet restore` in the directory
- Run `dotnet test DocumentFormat.OpenXml.Tests` to run the tests
- Run `dotnet pack DocumentFormat.OpenXml` to generate a nupkg

Schema Files
============

The data for schema validation is contained in static binary files that are not compatible in .NET Standard. At this moment, a converter tool is used to transform the binary file into a set of POCO objects that will not require deserialization at runtime. This tool is located in the `BinaryFormatConverter` folder. In order to run it:

- Run `dotnet restore` in the solution directory
- `cd BinaryFormatConverter`
- `dotnet run`

This will go through and update schema files in the form of `DocumentFormat.OpenXml/src/GeneratedCode/Office*Schema.cs`. This update only needs to be run when there is a change to the binary files; otherwise, they will return the same result. These updated files are only used in the .NET Sandard implementation, while the binary files will continue to be used in the .NET 4.5 builds.
