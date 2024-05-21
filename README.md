<!-- omit in toc -->
Open XML SDK
============

> [!NOTE]
>  
> [v3.0.0](https://www.nuget.org/packages/DocumentFormat.OpenXml/3.0.0) refactors and addresses some technical debt while retaining source compatibility as much as possible. You should be able to update your package and recompile with limited changes. However, binary compatibility was not a goal and will break that for some changes which are documented. PRs that introduced such changes are marked with a `breaking-change` label and were added to a list to help migrating to v3.0.0.
>
> Please see the [v3.0.0 milestone](https://github.com/OfficeDev/Open-XML-SDK/milestone/1) for issues and PRs that are included. For discussions, please join us at [this issue](https://github.com/OfficeDev/Open-XML-SDK/issues/1270).


> [!IMPORTANT]
> The CI feed URL has changed as of 2 April, 2024. Please update to the new URL if using CI builds.

[![Downloads](https://img.shields.io/nuget/dt/DocumentFormat.OpenXml.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml)
[![Build Status](https://office.visualstudio.com/OC/_apis/build/status/OpenXmlSdk/OfficeDev.Open-XML-SDK?branchName=main)](https://office.visualstudio.com/OC/_build/latest?definitionId=7420&branchName=main)
[![Backend Status](https://ointprotocol.visualstudio.com/OInteropTools/_apis/build/status/OpenXML-Schemas?branchName=main)](https://ointprotocol.visualstudio.com/OInteropTools/_build/latest?definitionId=21&branchName=main)

The Open XML SDK provides tools for working with Office Word, Excel, and PowerPoint documents. It supports scenarios such as:

- High-performance generation of word-processing documents, spreadsheets, and presentations.
- Document modification, such as adding, updating, and removing content and metadata.
- Search and replace content using regular expressions.
- Splitting up (shredding) a file into multiple files, and combining multiple files into a single file.
- Updating cached data and embedded spreadsheets for charts in Word/PowerPoint.

<!-- omit in toc -->
# Table of Contents

- [Packages](#packages)
  - [Daily Builds](#daily-builds)
  - [Framework Support](#framework-support)
- [Known Issues](#known-issues)
- [Documentation](#documentation)
- [If You Have How-To Questions](#if-you-have-how-to-questions)
- [Related tools](#related-tools)

# Packages

The official release NuGet packages for Open XML SDK are on NuGet.org:

| Package | Download | Prerelease |
|---------|----------|------------|
| DocumentFormat.OpenXml.Framework | [![NuGet](https://img.shields.io/nuget/v/DocumentFormat.OpenXml.Framework.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml.Framework) | [![NuGet](https://img.shields.io/nuget/vpre/DocumentFormat.OpenXml.Framework.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml.Framework) |
| DocumentFormat.OpenXml | [![NuGet](https://img.shields.io/nuget/v/DocumentFormat.OpenXml.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml) | [![NuGet](https://img.shields.io/nuget/vpre/DocumentFormat.OpenXml.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml)  |
| DocumentFormat.OpenXml.Linq | [![NuGet](https://img.shields.io/nuget/v/DocumentFormat.OpenXml.Linq.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml.Linq) | [![NuGet](https://img.shields.io/nuget/vpre/DocumentFormat.OpenXml.Linq.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml.Linq) |
| DocumentFormat.OpenXml.Features | [![NuGet](https://img.shields.io/nuget/v/DocumentFormat.OpenXml.Features.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml.Features) | [![NuGet](https://img.shields.io/nuget/vpre/DocumentFormat.OpenXml.Features.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml.Features)  |

## Daily Builds

The NuGet package for the latest builds of the Open XML SDK is available as a custom feed on an Azure blob. Stable releases here will be mirrored onto NuGet and will be identical. You must set up a [NuGet.config](https://docs.microsoft.com/en-us/nuget/reference/nuget-config-file) file that looks similar to this:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="OpenXmlCI" value="https://ooxml.blob.core.windows.net/feed/index.json" />
  </packageSources>
</configuration>
```

For latests changes, please see the [changelog](CHANGELOG.md)

## Framework Support

The package currently supports the following targets:

- .NET Framework 3.5, 4.0, 4.6
- .NET Standard 2.0
- .NET 6.0

For details on platform support, including other runtimes such as Mono and Unity, please see the docs at https://docs.microsoft.com/en-us/dotnet/standard/net-standard.

# Known Issues

- On .NET Core and .NET 5 and following, ZIP packages do not have a way to stream data. Thus, the working set can explode in certain situations. This is a [known issue](https://github.com/dotnet/runtime/issues/1544).
- On .NET Framework, an `IsolatedStorageException` may be thrown under certain circumstances. This generally occurs when manipulating a large document in an environment with an AppDomain that does not have enough evidence. A sample with a workaround is available [here](/samples/IsolatedStorageExceptionWorkaround).

# Documentation

Please see [Open XML SDK](https://learn.microsoft.com/en-us/office/open-xml/open-xml-sdk) for the official documentation.

# If you have how-to questions

- [Stack Overflow](http://stackoverflow.com) (tags: **openxml** or **openxml-sdk**)
- How-to samples:
  - [Spreadsheet Samples](https://learn.microsoft.com/en-us/office/open-xml/spreadsheet/overview)
  - [Presentation Samples](https://learn.microsoft.com/en-us/office/open-xml/presentation/overview)
  - [Wordprocessing Samples](https://learn.microsoft.com/en-us/office/open-xml/word/overview)
  
# Related tools

- **[Open XML SDK 2.5 Productivity Tool](https://github.com/OfficeDev/Open-XML-SDK/releases/tag/v2.5)**: The Productivity Tool provides viewing and code generation compatible with the Open XML SDK 2.5.
- **[Open XML Powertools](https://github.com/EricWhiteDev/Open-Xml-PowerTools)**: This provides example code and guidance for implementing a wide range of Open XML scenarios.
- **[ClosedXml](https://github.com/closedxml/closedxml)**: This library provides a simplified object model on top of the OpenXml SDK for manipulating and creating Excel documents.
- **[OfficeIMO](https://github.com/EvotecIT/OfficeIMO)**: This library provides a simplified object model on top of the OpenXml SDK manipulating and creating Word documents.
- **[OpenXML-Office](https://github.com/DraviaVemal/OpenXML-Office)**: This nuget library provides a simplified object model on top of the OpenXml SDK manipulating and creating PPT and Excel documents.
- **[Serialize.OpenXml.CodeGen](https://github.com/rmboggs/Serialize.OpenXml.CodeGen)**: This is a tool that converts an OpenXml document into the .NET code required to create it.
- **[Html2OpenXml](https://github.com/onizet/html2openxml)**: This is a tool that takes HTML and converts it to an OpenXml document.
- **[DocxToSource](https://github.com/rmboggs/DocxToSource)**: This is a tool designed to be a replacement for the old OpenXML SDK Productivity Tool.
- **[OOXML Viewer](https://github.com/yuenm18/ooxml-viewer-vscode)**: This is an extension for Visual Studio Code to View and Edit the xml parts of an Office Open XML file and to view a diff with the previous version of an OOXML part when saved from an outside program. Search "OOXML" in the VS Code extensions tab or download it from the [VS Code Marketplace](https://marketplace.visualstudio.com/items?itemName=yuenm18.ooxml-viewer)
- **[ShapeCrawler](https://github.com/ShapeCrawler/ShapeCrawler)**: This library provides a simplified object model on top of the OpenXml SDK to manipulate PowerPoint documents.
- **[OOXML Validator](https://github.com/mikeebowen/ooxml-validator-vscode)**: VS Code extension to validate Office Open XML files.  Search "OOXML" in the VS Code extensions tab or download it from the [VS Code Marketplace](https://marketplace.visualstudio.com/items?itemName=mikeebowen.ooxml-validator-vscode)

# How can I contribute?

We welcome contributions! Many people all over the world have helped make this project better.

- [Contributing](./CONTRIBUTING.md) explains what kinds of contributions we welcome

# Reporting security issues and security bugs

Security issues and bugs should be reported privately, via email, to the Microsoft Security Response Center (MSRC) secure@microsoft.com. You should receive a response within 24 hours. If for some reason you do not, please follow up via email to ensure we received your original message. Further information, including the MSRC PGP key, can be found in the [Security TechCenter](https://www.microsoft.com/en-us/msrc/faqs-report-an-issue?rtc=1).

# .NET Foundation
The Open XML SDK is a [.NET Foundation](https://dotnetfoundation.org/projects) project.

This project has adopted the code of conduct defined by the [Contributor Covenant](https://www.contributor-covenant.org/) to clarify expected behavior in our community. For more information, see the [.NET Foundation Code of Conduct](https://dotnetfoundation.org/about/code-of-conduct).

# License

The Open XML SDK is licensed under the [MIT](./LICENSE) license.
