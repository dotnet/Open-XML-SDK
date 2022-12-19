# Roadmap

Below are the near term plans for the SDK. These are not set in stone and may be moved to later releases or cut.

## March 2022 - 2.20.0
- Release support for latest Office schema updates
- Obsolete APIs that will be removed to help developers remove usage before moving to v3.0.0

## March 2022 - v3.0.0 (preview)
- Release support for latest Office schema updates
- Separate out strongly typed classes into separate assembly ([Project Board](https://github.com/OfficeDev/Open-XML-SDK/projects/2))
- Incoporate updates for System.IO.Packaging shipping with .NET 7
- Remove obsoleted patterns ([Project Board](https://github.com/OfficeDev/Open-XML-SDK/projects/1))
- Investigate simplifying target frameworks to .NET 4.6, .NET Standard 2.0, and .NET 6
- Expose internal features to enable more customizations
- Stretch goals:
    - Support writing large parts with minimal impact on working set
    - Support URIs that System.Uri does not support in a transparent way

## May 2022 - v3.0.0
- Release support for latest Office schema updates

## Aug 2022 - v3.1.0
- Ship source generator for users to generate subset of classes that they need ([Project Board](https://github.com/OfficeDev/Open-XML-SDK/projects/6))