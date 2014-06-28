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

Documentation
=============

This release of the SDK is the exact source code for version 2.5, therefore
the documentation available on MSDN is still accurate.

[Open XML SDK 2.5 for Office](http://msdn.microsoft.com/en-us/library/office/bb448854.aspx)

In addition to open sourcing of the SDK, Microsoft has opened up the
conceptual documentation for public review / contributions.  A copy of
the documentation is [now in GitHub](https://github.com/OfficeDev/office-content) for you to edit and review.

Build Instructions
==================

For a video that shows how to get and build the SDK, see [this blog post](http://openxmldeveloper.org/blog/b/openxmldeveloper/archive/2014/06/25/the-open-xml-sdk-is-now-open-source.aspx)
at [OpenXmlDeveloper.org](http://OpenXmlDeveloper.org).

Note: for this first release, you must have some version of Visual Studio
installed.  Visual Studio 2012 Express Edition will work just fine:
http://www.microsoft.com/en-us/download/details.aspx?id=34673

Set Execution Policy for PowerShell
===================================
In order to run the script that builds the Open XML SDK, you need to set
the execution policy.  To set the execution policy, you must run
PowerShell as administrator.
- Right click on the PowerShell shortcut, and click "Run as administrator".
An easy way to find the PowerShell shortcut is to click the Start
button, then type PowerShell.  The PowerShell shortcut will be in the
search results above the start menu.
- Click the Yes button in the User Account Control dialog box.
- Run the command to set the execution policy:
The the PowerShell prompt, type:
Set-ExecutionPolicy Unrestricted<Enter>
- The Set-ExecutionPolicy cmdlet asks:
Do you want to change the execution policy?
[Y] Yes  [N] No  [S] Suspend  [?] Help (default is "Y"):
Press Y Enter
- You can exit the PowerShell session that is running as administrator.
At the PowerShell prompt, type: Exit

Build the Open XML SDK Libraries
================================
- Start a Visual Studio command prompt.  It does not need to run as
administrator.
- Change directories into the directory that contains this README.md,
and the PowerShell script BldSdk.ps1
For instance, type:
CD C:\users\username\Documents\Open-Xml-Sdk<Enter>
- Start PowerShell.
At the DOS command prompt, type: PowerShell Enter
- Run the PowerShell script to build the libraries:
Type: ./BldSdk.ps1 Enter
- The build will commence - it can take a few seconds, up to a minute,
depending on the speed of your computer.
- Find the debug libraries in the folder: ./build/OpenXmlSdkLib/Debug.
Find the release libraries in the folder: ./build/OpenXmlSdkLib/Release
