# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## Version 2.9.0 - 2018-06-08
### Added
- `ListValue` now implements `IEnumerable<T>` (#385)
- Added a `WebExtension.Frozen` and obsoleted misspelled `Fronzen` property (#460)
- Added an `OpenXmlPackage.CanSave` property that indicates whether a platform supports saving without closing the package (#468)
- Simple types (except `EnumValue` and `ListValue`) now implement `IComparable<T>` and `IEquatable<T>` (#487)

### Changed
- Removed state that was carried in validators that would hold onto packages when not in use (#390)
- `EnumSimpleType` parsing was improved and uses less allocations and caches for future use (#408)
- Fixed a number of spelling mistakes in documentation (#462)
- When calling `OpenXmlPackage.Save` on .NET Framework, the package is now flushed to the stream (#468)
- Fixed race condition while performing strict translation of attributes (#480)
- Schema data for validation uses a more compact format leading to a reduction in dll size and performance improvements for loading (#482, #483)
- A number of APIs are marked as obsolete as they have simple workarounds and will be removed in the next major change
- Fixed some constraint values for validation that contained Office 2007, even when it was only supported in later versions
- Updated `System.IO.Packaging` to 4.5.0 which fixes some issues on Xamarin platforms as well as minimizes dependencies on .NET Framework

## Version 2.8.1 - 2018-01-03
### Changed
- Corrected package license file reference to show updated MIT License

## Version 2.8.0 - 2017-12-28
### Added
- Default runtime directive for better .NET Native support.

### Changed
- Fixed part saving to be encoded with UTF8 but no byte order mark. This caused some renderers to not be able to open the generated document.
- Fixed exceptions thrown when errors are encountered while opening packages to be consistent across platforms.
- Fixed issue on Mono platforms using System.IO.Packaging NuGet package (Xamarin, etc) when creating a document.
- Fixed manual saving of a package when autosave is false.
- Fixed schema constraint data and standardized serialization across platforms.
- Upgraded to `System.IO.Packaging` version 4.4.0 which fixes some consistency with .NET Framework in opening packages.

## Version 2.7.2 - 2017-06-06
### Added
- Package now supports .NET 3.5 and .NET 4.0 in addition to .NET Standard 1.3 and .NET Framework 4.6

### Changed
- Fixed issue where assembly version wasn't set in assembly. 

## Version 2.7.1 - 2017-01-31
### Changed
- Fixed crash when validation is invoked on .NET Framework with strong-naming enforced.

## Version 2.7.0 - 2017-01-24
### Added
- SDK now  supports .NET Standard 1.3

### Changed
- Moved to using System.IO.Packaging from dotnet/corefx for .NET Standard 1.3 and WindowsBase for .NET 4.5.
- Cleaned up project build system to use .NET CLI.

## Version 2.6.1 - 2016-01-15
### Added
- Added hundreds of XUnit tests. There are now a total of 1333 tests. They take about 20 minutes to run, so be patient.

## Version 2.6.0 - 2015-06-29
### Added
- Incorporated a replacement `System.IO.Packaging` that fixes some serious (but exceptional) bugs found in the WindowsBase implementation
