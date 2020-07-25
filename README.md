Open XML SDK
============

[![NuGet](https://img.shields.io/nuget/v/DocumentFormat.OpenXml.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml)
[![Downloads](https://img.shields.io/nuget/dt/DocumentFormat.OpenXml.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml)
[![Build Status](https://office.visualstudio.com/OC/_apis/build/status/OpenXmlSdk/OfficeDev.Open-XML-SDK?branchName=master)](https://office.visualstudio.com/OC/_build/latest?definitionId=7420&branchName=master)
[![MyGet](https://img.shields.io/dotnet.myget/open-xml-sdk/vpre/DocumentFormat.OpenXml.svg)](https://dotnet.myget.org/feed/open-xml-sdk/package/nuget/DocumentFormat.OpenXml)

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
- [How to install the NuGet package](#how-to-install-the-nuget-package)
- [If You Have Problems](#if-you-have-problems)
- [Known Issues](#known-issues)
- [Documentation](#documentation)
- [Build Instructions](#build-instructions)
- [To build the Open XML SDK](#to-build-the-open-xml-sdk)
- [Related tools](#related-tools)
- [Code of Conduct](#code-of-conduct)

Releases
--------------------------------

The official release NuGet packages for Open XML SDK are [available on Nuget.org](https://www.nuget.org/packages/DocumentFormat.OpenXml).

The NuGet package for the latest builds of the Open XML SDK is available as a custom feed on MyGet. You can trust this package source, since the custom feed is locked and only this project feeds into the source. Stable releases here will be mirrored onto NuGet and will be identical.

For latests changes, please see the [changelog](CHANGELOG.md)

This library supports many platforms. There are builds for .NET 3.5, .NET 4.0, .NET 4.6, .NET Standard 1.3, .NET Standard 2.0. The following platforms are currently supported:

How to install the NuGet package
---------------------------------

The package you want to install is DocumentFormat.OpenXml.

NuGet packages are available for [release builds](https://www.nuget.org/packages/DocumentFormat.OpenXml) or [CI Builds](https://dotnet.myget.org/gallery/open-xml-sdk) and follow [semantic versioning](http://www.semver.org/).

The package feed or the package source is specified by the feed URL. Depending on your version of Visual Studio, choose the appropriate feed URL from the table below.

**Table 1:** The latest builds are available via a MyGet feed.

| Client | Feed URL |
| ------ | -------- |
| NuGet V3 (Visual Studio 2015+) | [https://dotnet.myget.org/F/open-xml-sdk/api/v3/index.json](https://dotnet.myget.org/F/open-xml-sdk/api/v3/index.json) |
| NuGet V2 (Visual Studio 2012+) | [https://dotnet.myget.org/F/open-xml-sdk/api/v2](https://dotnet.myget.org/F/open-xml-sdk/api/v2) |

The `Install-Package` command considers the package source either via configuration or argument. Also, the package version can vary. For the latest version info, see the [feed for the DocumentFormat.OpenXml package](https://dotnet.myget.org/feed/open-xml-sdk/package/nuget/DocumentFormat.OpenXml).

- To specify the package source via a configuration option, see [Configuring NuGet behavior](https://docs.microsoft.com/en-us/nuget/consume-packages/configuring-nuget-behavior). Note that usually a NuGet.config file is placed in the directory and the configuration options are added there to ensure the sources are persisted in the version control.

  ```shell
  PM> Install-Package DocumentFormat.OpenXml -Version <version retrieved from the web>
  ```

- To pass the feed URL as an argument, here is an example for Visual Studio 2015 and later.

  ```shell
  PM> Install-Package DocumentFormat.OpenXml -Version <version retrieved from the web> -Source https://dotnet.myget.org/F/open-xml-sdk/api/v3/index.json
  ```

**Note**: If you have trouble installing the package, try restarting Visual Studio. Package sources could be cached and changes you've made to any NuGet.config files may not be detected.

If You Have Problems
--------------------

If you want to report a problem (bug, behavior, build, distribution, feature request, etc...) with the SDK built by this repository, please feel free to post a new issue and someone will try to help.

If you have "how-to" questions please post to one of the following resources:

- [Open XML SDK forum](https://social.msdn.microsoft.com/Forums/office/en-US/home?forum=oxmlsdk)
- [Stack Overflow](http://stackoverflow.com) (tags: **openxml** or **openxml-sdk**)

Known Issues
------------

- On .NET Core, zip packages do not have a way to stream data. Thus, the working set can explode in certain situations. This is a [known issue](https://github.com/dotnet/corefx/issues/24457).
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

Code of Conduct
---------------

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
