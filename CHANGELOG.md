# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

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
