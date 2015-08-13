Open-XML-SDK
============
The Open XML SDK provides open-source libraries for working with Open XML
Documents (DOCX, XLSX, and PPTX).  It supports scenarios such as:
- High-performance generation of word-processing documents, spreadsheets,
  and presentations
- Document modification, such as removing tracked revisions or removing
  unacceptable content from documents
- Data and content querying and extraction, such as transformation from
  DOCX to HTML, or extraction of data from spreadsheets

Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.
Licensed under the Apache License, Version 2.0.
See License.txt in the project root for license information.

News
====
We are happy to announce the release of the Open XML SDK Version 2.6.  The
big feature in 2.6 is the inclusion of a replacement for System.IO.Packaging, which
has a serious bug that causes it (albeit rarely and in specific circumstances)
to throw exceptions (ObjectDisposedException and NullReferenceException).  You can
find out more about this bug and whether it affects you in [the blog post that announces the release of the new System.IO.Packaging](http://openxmldeveloper.org/blog/b/openxmldeveloper/archive/2015/06/29/announcing-the-release-of-a-new-system-io-packaging-implementation.aspx).

Going forward, the Open XML SDK will be based on this new implementation of System.IO.Packaging.

We are also happy to announce the release of Open-Xml-PowerTools on GitHub.  Open-Xml-PowerTools provides
example code and guidance for implementing a wide range of Open XML scenarios.  This new release is version 4.0 of
PowerTools for Open XML, which previously lived at http://powertools.codeplex.com.  The repo name on
GitHub is https://github.com/OfficeDev/Open-Xml-PowerTools.

Documentation
=============

This functionality of the Open XML SDK is the same as for version 2.5, therefore
the documentation available on MSDN is still accurate.

[Open XML SDK 2.5 for Office](http://msdn.microsoft.com/en-us/library/office/bb448854.aspx)

In addition to open sourcing of the SDK, Microsoft has opened up the
conceptual documentation for public review / contributions.  A copy of
the documentation is [now in GitHub](https://github.com/OfficeDev/office-content) for you to edit and review.

Build Instructions
==================

Note: for this first release, you must have some version of Visual Studio
installed.  Visual Studio 2012 Express Edition will work just fine:
http://www.microsoft.com/en-us/download/details.aspx?id=34673

To build the Open XML SDK:
- clone the repo at https://github.com/OfficeDev/Open-XML-SDK
- Start a Visual Studio command prompt, and check into the directory that contains the repo
- Use MSBUILD to build the SDK  (C:> MSBUILD Open-Xml-Sdk.sln)
- If you want to continue to use the System.IO.Packaging that comes with the .NET Framework, use MSBUILD as follows  (C:> MSBUILD Open-XML-SDK-Orig-SIP.sln)
- In your program that uses the Open XML SDK, add references to the newly built libraries in build/OpenXmlSdkLib/Debug

Previously, we were using PowerShell to generate a new version number for each build.  This is no longer required, and it is more convenient to build the SDK using MSBUILD, therefore I have removed the instructions for building using the PowerShell script.

Instead of using MSBUILD, you can also open the solution using Visual Studio and build it.

Building with Mono
=================
- First, ensure you have mono installed in a manner appropriate to your linux/unix distribution.
- `make -f Makefile-Linux-Mono build`
- Find libraries in the folder: ./build/OpenXmlSdkLib
- [Screen-Cast: Using the Open XML SDK on Linux using Mono](http://openxmldeveloper.org/blog/b/openxmldeveloper/archive/2014/07/03/screen-cast-using-open-xml-sdk-on-linux-using-mono.aspx)
