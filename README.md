Open XML SDK
============

[![NuGet](https://img.shields.io/nuget/v/DocumentFormat.OpenXml.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml)
[![Downloads](https://img.shields.io/nuget/dt/DocumentFormat.OpenXml.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml)
[![Build Status](https://office.visualstudio.com/OC/_apis/build/status/OpenXmlSdk/OfficeDev.Open-XML-SDK?branchName=master)](https://office.visualstudio.com/OC/_build/latest?definitionId=7420&branchName=master)

> # Office 2019 Support Available!
> The latest release 2.13.0 provides support for Office 2019 types, including for: 
>- Rich data types in Excel
>- Threaded comments in Excel
>- Word CommentIds
>- Hyperlink color
>- SVG
>- 3D models and animated 3D models  
>
> Please file any issues you find and label them with `Office2019`.  

&nbsp;
> # Microsoft DevDays Redmond 2021 Online
> Join us at the Virtual Microsoft DevDays for a session on File Formats and the OpenXML SDK.  
> Register for this and other sessions (no cost) at www.interopevents.com/redmond2021  


&nbsp;

The Open XML SDK provides tools for working with Office Word, Excel, and PowerPoint documents. It supports scenarios such as:

- High-performance generation of word-processing documents, spreadsheets, and presentations.
- Populating content in Word files from an XML data source.
- Splitting up (shredding) a Word or PowerPoint file into multiple files, and combining multiple Word/PowerPoint files into a single file.
- Extraction of data from Excel documents.
- Searching and replacing content in Word/PowerPoint using regular expressions.
- Updating cached data and embedded spreadsheets for charts in Word/PowerPoint.
- Document modification, such as adding, updating, and removing content and metadata.

Table of Contents
-----------------

- [Releases](#releases)
- [If You Have Problems](#if-you-have-problems)
- [Known Issues](#known-issues)
- [Documentation](#documentation)
- [Related tools](#related-tools)
- [Code of Conduct](#code-of-conduct)

Releases
--------------------------------

The official release NuGet packages for Open XML SDK are [available on Nuget.org](https://www.nuget.org/packages/DocumentFormat.OpenXml).

The NuGet package for the latest builds of the Open XML SDK is available as a custom feed on MyGet. You can trust this package source, since the custom feed is locked and only this project feeds into the source. Stable releases here will be mirrored onto NuGet and will be identical.

For latests changes, please see the [changelog](CHANGELOG.md)

The package currently supports the following frameworks:

- .NET Framework 3.5+
- .NET Standard 1.3+
- .NET Core 1.0+
- .NET 5+
- Mono 4.6+
- Xamarin.iOS 10.0+
- Xamarin.Mac 3.0+
- Xamarin.Android 7.0+
- UWP 10.0+
- Unity 2018.1+

For details on platform support, please see the docs at https://docs.microsoft.com/en-us/dotnet/standard/net-standard.

If You Have Problems
--------------------

If you want to report a problem (bug, behavior, build, distribution, feature request, etc...) with the SDK built by this repository, please feel free to post a new issue and someone will try to help.

If you have "how-to" questions please post to one of the following resources:

- [Microsoft Q&A Forums](https://docs.microsoft.com/en-us/answers/topics/office-addins-dev.html) (tag: **office-addins-dev**)
- [Stack Overflow](http://stackoverflow.com) (tags: **openxml** or **openxml-sdk**)

Known Issues
------------

- On .NET Core and .NET 5, zip packages do not have a way to stream data. Thus, the working set can explode in certain situations. This is a [known issue](https://github.com/dotnet/runtime/issues/1544).
- On .NET Core, targeting .NET Framework 4.5+, and .NET 5, `System.Uri` will not parse invalid links. This causes an exception. A workaround in v2.12.0+ of OpenXml SDK is to use `OpenSettings.RelationshipErrorRewriter` to rewrite them to something that can be parsed. A discussion is available [here](https://github.com/dotnet/runtime/issues/26084) to enable something more robust in `System.IO.Packaging`.
- On .NET Framework, an `IsolatedStorageException` may be thrown under certain circumstances. This generally occurs when manipulating a large document in an environment with an AppDomain that does not have enough evidence. A sample with a workaround is available [here](/samples/IsolatedStorageExceptionWorkaround).

Documentation
-------------

The functionality of the specific classes in this version of the Open XML SDK is similar to version 2.5, therefore the [Open XML SDK 2.5 for Office](http://msdn.microsoft.com/en-us/library/office/bb448854.aspx) documentation available on MSDN is still accurate.

In addition to open sourcing of the SDK, Microsoft has opened up the conceptual documentation for public review / contributions.  A copy of the documentation is  available for you to edit and review [in GitHub](https://github.com/OfficeDev/office-content).

Related tools
-------------

- **[Open XML Powertools](https://github.com/EricWhiteDev/Open-Xml-PowerTools)**: This provides example code and guidance for implementing a wide range of Open XML scenarios.
- **[ClosedXml](https://github.com/closedxml/closedxml)**: This library provides a simplified object model on top of the OpenXml SDK for manipulating and creating Excel documents.
- **[Serialize.OpenXml.CodeGen](https://github.com/rmboggs/Serialize.OpenXml.CodeGen)**: This is a tool that converts an OpenXml document into the .NET code required to create it.
- **[Html2OpenXml](https://github.com/onizet/html2openxml)**: This is a tool that takes HTML and converts it to an OpenXml document.
- **[DocxToSource](https://github.com/rmboggs/DocxToSource)**: This is a tool designed to be a replacement for the old OpenXML SDK Productivity Tool.
- **[OOXML Viewer](https://github.com/yuenm18/ooxml-viewer-vscode)**: This is an extension for Visual Studio Code to View and Edit the xml parts of an Office Open XML file and to view a diff with the previous version of an OOXML part when saved from an outside program. Search OOXML in the VS Code extensions tab or get it from the [VS Code Marketplace](https://marketplace.visualstudio.com/items?itemName=yuenm18.ooxml-viewer)
- **[ShapeCrawler](https://github.com/ShapeCrawler/ShapeCrawler)**: This library provides a simplified object model on top of the OpenXml SDK to manipulate PowerPoint documents.

Code of Conduct
---------------

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
