# Roadmap

Below are the near term plans for the SDK. These are not set in stone and may be moved to later releases or cut.

## December 2021 - 2.15.0
- Release support for latest Office schema updates
- Release `DocumentFormat.OpenXml.Features` and `DocumentFormat.OpenXml.Features.Linq` libraries
- Initial internal source generator support for generation of Linq namespaces

## March 2022 - 2.16.0
- Release support for latest Office schema updates
- Isolate functional services behind features infrastructure
- Move source generation to SDK repo as command line tool (projects/6)

## June 2022 - 2.17.0
- Release support for latest Office schema updates
- Identify issues for AOT (i.e. Blazor WebAssembly, Xamarin Mac, etc) (projects/8)
- Convert code generator into C# Source Generator (projects/6)

## September 2022 - 3.0.0
- Release support for latest Office schema updates
- Separate out strongly typed classes into separate assembly (projects/2)
- Ship source generator for users to generate subset of classes that they need (projects/6)
- Incoporate updates for System.IO.Packaging shipping with .NET 7
- Remove obsoleted patterns (projects/1)
- Investigate simplifying target frameworks to .NET 4.6, .NET Standard 2.0, and .NET 6
