Open-XML-SDK
============

Release Version 2.6.1

    News: The Office2016 branch on this repo contains a preview of the Open-Xml-Sdk v3.0, which
	supports the Office 2016 extensions in the file format.  The biggest change to the markup was
	the introduction of the ExtendedChartPart, which support the new chart types, such as Waterfall,
	Box and Whisker, and Sunburst.  You can specify FileFormatVersions.Office2016 to validate this
	markup.  This version of the SDK also supports using the strongly-typed OM to access the markup
	in the new parts.
	
	We will merge the Office2016 branch into vNext at some point in the future, after receiving
	feedback.

The Open XML SDK provides open-source libraries for working with Open XML
Documents (DOCX, XLSX, and PPTX).  It supports scenarios such as:
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

News
====
The most recent release of the Open XML SDK is Version 2.6.1, which includes a total of 1333 XUnit tests.

We are also happy to announce the release of Open-Xml-PowerTools on GitHub.  Open-Xml-PowerTools provides
example code and guidance for implementing a wide range of Open XML scenarios.  You can find PowerTools
for Open XML, which previously lived at [PowerTools.CodePlex.com](http://powertools.codeplex.com) at
[github.com/OfficeDev/Open-Xml-PowerTools](https://github.com/OfficeDev/Open-Xml-PowerTools).

Change Log
==========

Version 2.6.1 : January 15, 2016
- Added hundreds of XUnit tests.  There are now a total of 1333 tests.  They take about 20 minutes to run, so be patient.

Version 2.6.0 : June 29, 2015
- The big feature in 2.6 is the inclusion of a replacement for System.IO.Packaging, which
has a serious bug that causes it (albeit rarely and in specific circumstances)
to throw exceptions (ObjectDisposedException and NullReferenceException).  You can
find out more about this bug and whether it affects you in [the blog post that announces the release of the new System.IO.Packaging](http://openxmldeveloper.org/blog/b/openxmldeveloper/archive/2015/06/29/announcing-the-release-of-a-new-system-io-packaging-implementation.aspx).

Going forward, the Open XML SDK will be based on this new implementation of System.IO.Packaging.

Documentation
=============

The functionality of the specific classes in Open XML SDK Version 2.6.0 is the same as for version 2.5, therefore
the documentation available on MSDN is still accurate.

[Open XML SDK 2.5 for Office](http://msdn.microsoft.com/en-us/library/office/bb448854.aspx)

In addition to open sourcing of the SDK, Microsoft has opened up the
conceptual documentation for public review / contributions.  A copy of
the documentation is [now in GitHub](https://github.com/OfficeDev/office-content) for you to edit and review.

Build Instructions
==================

This project uses the `project.json` for the project system. Please see the [.NET Core SDK](https://www.microsoft.com/net/core#windows) for more information on how to use this project type.

To build the Open XML SDK:
- Clone the repo at https://github.com/OfficeDev/Open-XML-SDK
- Open the solution using Visual Studio 2015.  Community Edition of VS2015 works just fine.
- Build the solution (using either Debug or Release configuration)
- Run the Xunit tests to verify the installation

If you want to use a command line approach:
- Go to the directory the solution is in
- Run `dotnet restore` in the directory
- Run `dotnet test DocumentFormat.OpenXml.Tests` to run the tests
- RUn `dotnet pack DocumentFormat.OpenXml` to generate a nupkg