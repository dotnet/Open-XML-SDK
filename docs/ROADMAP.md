# Roadmap

Below are the near term plans for the SDK. These are not set in stone and may be moved to later releases or cut.

## December 2021 - 2.15.0
- Release support for latest Office schema updates
- Release `DocumentFormat.OpenXml.Features` and `DocumentFormat.OpenXml.Features.Linq` libraries
- Initial internal source generator support for generation of namespaces

## March 2022 - 2.16.0
- Release support for latest Office schema updates
- Move source generation to SDK repo as source generator ([Project Board](https://github.com/OfficeDev/Open-XML-SDK/projects/6))
- Convert LINQ gneration to use source generator

## June 2022 - 2.17.0
- Release support for latest Office schema updates
- Identify issues for AOT (i.e. Blazor WebAssembly, Xamarin Mac, etc) (projects/8)
- Isolate functional services behind [features infrastructure](Features.md)

## September 2022 - 2.18.0
- Release support for latest Office schema updates

## [Future] - v3.0.0
- Separate out strongly typed classes into separate assembly ([Project Board](https://github.com/OfficeDev/Open-XML-SDK/projects/2))
- Ship source generator for users to generate subset of classes that they need ([Project Board](https://github.com/OfficeDev/Open-XML-SDK/projects/6))
- Incoporate updates for System.IO.Packaging shipping with .NET 7
- Remove obsoleted patterns ([Project Board](https://github.com/OfficeDev/Open-XML-SDK/projects/1))
- Investigate simplifying target frameworks to .NET 4.6, .NET Standard 2.0, and .NET 6
