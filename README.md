---
page_type: sample
products:
- office-365
languages:
- csharp
extensions:
  contentType: sdks
  createdDate: 6/5/2014 9:11:17 AM
---
Open XML SDK
============

[![NuGet](https://img.shields.io/nuget/v/DocumentFormat.OpenXml.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml)
[![Downloads](https://img.shields.io/nuget/dt/DocumentFormat.OpenXml.svg)](https://www.nuget.org/packages/DocumentFormat.OpenXml)
[![master](https://img.shields.io/appveyor/ci/openxmlsdk/Open-XML-SDK/master.svg)](https://ci.appveyor.com/project/openxmlsdk/open-xml-sdk)
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
  - [Supported platforms](#supported-platforms)
  - [WindowsBase or System.IO.Packaging](#windowsbase-or-systemiopackaging)
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

Supported platforms
-----------------

This library supports many platforms. There are builds for .NET 3.5, .NET 4.0, .NET 4.6, and .NET Standard 1.3. The following platforms are currently supported:

|    Platform     | Minimum Version |
|-----------------|-----------------|
| .NET Framework  | 3.5             |
| .NET Core       | 1.0             |
| UWP             | 10.0            |
| Mono            | 3.5             |
| Xamarin.iOS     | 10.0            |
| Xamarin.Mac     | 3.0             |
| Xamarin.Android | 7.0             |

WindowsBase or System.IO.Packaging
----------------------------------

There is a known issue in `WindowsBase` that causes crashes when handling large data sources. This is fixed in later versions of the library, based on the platform availability of the `System.IO.Packaging` package. When possible, we use this package instead of `WindowsBase`. This not only fixes the crash seen by some users, but is available cross platform. However, it is only available on .NET Standard 1.3+ and .NET Framework 4.6+. For this reason, the NuGet package has multiple targets to bring in, when possible. The targets are determined by NuGet at installation and build time and are listed in the table below.

| Platform      | System.IO.Packing Source | Tested by     |
| --------      | ------------------------ | ------------- |
| .NET 3.5      | WindowsBase              | N/A           |
| .NET 4.0      | WindowsBase              | .NET 4.5.2    |
| .NET 4.6      | NuGet                    | .NET 4.6      |
| .NET Standard | NuGet                    | .NET Core 1.0 |

Keep in mind, though, that the `System.IO.Packaging` on .NET 4.6+ is simply a facade over WindowsBase, and thus everything running on .NET 4.6 will use WindowsBase instead of the newer implementation.

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

  **Note:** Once `System.IO.Packaging` on .NET Core has feature parity with `WindowsBase` (i.e. streaming support), we can investigate using the new .NET Core on .NET Framework.

Documentation
-------------

The functionality of the specific classes in this version of the Open XML SDK is similar to version 2.5, therefore the [Open XML SDK 2.5 for Office](http://msdn.microsoft.com/en-us/library/office/bb448854.aspx) documentation available on MSDN is still accurate.

In addition to open sourcing of the SDK, Microsoft has opened up the conceptual documentation for public review / contributions.  A copy of the documentation is  available for you to edit and review [in GitHub](https://github.com/OfficeDev/office-content).

Build Instructions
------------------

This project uses the csproj format and the release versions of the tooling in Visual Studio 2017. For more information on how to use this project type to build your project, see the [release notes for Visual Studio 2017]( https://www.visualstudio.com/en-us/news/releasenotes/vs2017-relnotes#dotnetcore). Other editors that support the latest .NET project files include Visual Studio Code, Visual Studio for Mac, or .NET CLI. See [.NET Downloads](https://www.microsoft.com/net/download/core) for details.

The project often requires the latest release of the C# compiler as many new features come on-line that greatly aid in ease of development. As of now, the C# 7.2 compiler is required (which was released in December 2017) and comes standard in Visual Studio 2017 Update 5, with other IDEs providing updates to the compiler, as well.

To build the Open XML SDK
-------------------------

1. Clone the [Open-XML-SDK](https://github.com/OfficeDev/Open-XML-SDK) repository.
1. Open the solution with an editor that supports the latest .NET project files.
1. Build the solution (using either Debug or Release configuration).
1. Run the Xunit tests to verify the installation.

If you want to use a command line approach:

1. Go to the directory that contains the solution.
1. Run `dotnet restore` in the directory.
1. Run `dotnet test DocumentFormat.OpenXml.Tests` to run the tests.
1. Run `dotnet pack DocumentFormat.OpenXml` to generate a nupkg.

Related tools
-------------

- **Open XML Powertools**: This is available on in the [Open-Xml-PowerTools](https://github.com/OfficeDev/Open-Xml-PowerTools) repository on GitHub and provides example code and guidance for implementing a wide range of Open XML scenarios.

Code of Conduct
---------------

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
