# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [2.17.1] - 2022-06-28

### Removed
- Removed the preview namespace DocumentFormat.OpenXml.Office.Comments.Y2020.Reactions because this namespace will currently create invalid documents.

### Fixed
- Restored the PowerPointCommentPart relationship to PresentationPart.

### Deprecated
- The relationship between the PowerPointCommentPart and the PresentationPart is deprecated and will be removed in a future version.

## [2.17.0] - Unreleased

### Added
- Added DocumentFormat.OpenXml.Office.Comments.Y2020.Reactions namespace (#1151)
- Added DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo namespace (#1151)

### Fixed
- Moved PowerPointCommentPart relationship to SlidePart (#1137)

### Updated
- Removed public API analyzers in favor of EnablePackageValidation (#1154)

## [2.16.0] - 2022-03-14

### Added
- Added method `OpenXmlPart.UnloadRootElement` that will unload the root element if it is loaded (#1126)

### Updated
- Schema code generation was moved to the SDK project using C# code generators

Thanks to the following for their contribution:

@f1nzer

## [2.15.0] - 2021-12-16

### Added
- Added samples for strongly typed classes and Linq-to-XML in the `./samples` directory (#1101, #1087)
- Shipping additional libraries for some additional functionality in `DocumentFormat.OpenXml.Features` and `DocumentFormat.OpenXml.Linq`. See documentation in repo for additional details.
- Added extension method to support getting image part type (#1082)
- Added generated classes and `FileFormatVersions.Microsoft365` for new subscription model types and constraints (#1097).

### Fixed
- Fixed issue for changed mime type `model/gltf.binary` (#1069)
- DocumentFormat.OpenXml.Office.Drawing.ShapeTree is now available only in Office 2010 and above, not 2007.
- Correctly serialize `new CellValue(bool)` values (#1070)
- Updated known namespaces to be generated via an in-repo source generator (#1092)
- Some documentation issues around `FileFormatVersions` enum

Thanks to the following for their contributions:

@ThomasBarnekow
@stevenhansen
@JaimeStill
@jnyrup

## [2.14.0] - 2021-10-28

### Added
- Added generated classes for Office 2021 types and constraints (#1030)
- Added `Features` property to `OpenXmlPartContainer` and `OpenXmlElement` to enable a per-part or per-document state storage
- Added public constructors for `XmlPath` (#1013)
- Added parts for Rich Data types (#1002)

Thanks to the following for their contributions:

@rmboggs
@ThomasBarnekow

## [2.14.0-beta1] - 2021-09-20

### Added
- Added `Features` property to `OpenXmlPartContainer` and `OpenXmlElement` to enable a per-part or per-document state storage
- Added public constructors for `XmlPath` (#1013)
- Added parts for Rich Data types (#1002)
- Added methods to generate unique paragraph ids (#1000)
- Added generated classes for Office 2021 types and constraints (#1030)

Thanks to the following for their contributions:

@rmboggs
@ThomasBarnekow

## [2.13.1] - 2021-08-17

### Fixed
- Fixed some nullability annotations that were incorrectly defined (#953, #955)
- Fixed issue that would dispose a `TextReader` when creating an `XmlReader` under certain circumstances (#940)
- Fixed a documentation type (#937)
- Fixed an issue with adding additional children to data parts (#934)
- Replaced some documentation entries that were generic values with helpful comments (#992)
- Fixed a regression in AddDataPartRelationship (#954)

Thanks to the following for their contributions:

@ThomasBarnekow
@sorensenmatias
@lklein53
@lindexi

## [2.13.0] - 2021-05-13

### Added
- Additional O19 types to match Open Specifications (#916)
- Added generated classes for Office 2019 types and constraints (#882)
- Added nullability attributes (#840, #849)
- Added overload for `OpenXmlPartReader` and `OpenXmlReader.Create(...)` to ignore whitespace (#857)
- Added `HexBinaryValue.TryGetBytes(...)` and `HexBinaryValue.Create(byte[])` to manage the encoding and decoding of bytes (#867)
- Implemented `IEquatable<IdPartPair>` on `IdPartPair` to fix equality implementation there and obsoleted setters (#871)

### Fixed
- Fixed serialization of `CellValue` constructors to use invariant cultures (#903)
- Fixed parsing to allow exponents for numeric cell values (#901)
- Fixed massive performance bottleneck when `UniqueAttributeValueConstraint` is involved (#924)

### Deprecated
- Deprecated Office2013.Word.Person.Contact property. It no longer persists and will be removed in a future version (#912)

Thanks to the following for their contributions:

@lklein53  
@igitur

## [2.13.0-beta2] - 2021-04-20

### Added
- Additional O19 types to match Open Specifications (#916)

### Deprecated
- Deprecated Office2013.Word.Person.Contact property. It no longer persists and will be removed in a future version (#912)

## [2.13.0-beta1] - 2021-03-09

### Added
- Added nullability attributes (#840, #849)
- Added overload for `OpenXmlPartReader` and `OpenXmlReader.Create(...)` to ignore whitespace (#857)
- Added `HexBinaryValue.TryGetBytes(...)` and `HexBinaryValue.Create(byte[])` to manage the encoding and decoding of bytes (#867)
- Implemented `IEquatable<IdPartPair>` on `IdPartPair` to fix equality implementation there and obsoleted setters (#871)
- Added generated classes for Office 2019 types and constraints (#882)

### Fixed
- Fixed serialization of `CellValue` constructors to use invariant cultures (#903)
- Fixed parsing to allow exponents for numeric cell values (#901)

## [2.12.3] - 2021-02-24

### Fixed
- Fixed issue where `CellValue` may validate incorrectly for boolean values (#890)

## [2.12.2] - 2021-02-16

### Fixed
- Fixed issue where `OpenSettings.RelationshipErrorHandlerFactory` creates invalid XML if the resulting URI is smaller than the input (#883)

## [2.12.1] - 2021-01-11

### Fixed
- Fixed bug where properties on `OpenXmlCompositeElement` instances could not be set to null to remove element (#850)
- Fixed `OpenXmlElement.RawOuterXml` to properly set null values without throwing (#818)
- Allow rewriting of all malformed URIs regardless of target value (#835)

## [2.12.0] - 2020-12-09

### Added
- Added `OpenSettings.RelationshipErrorHandlerFactory` to provide a way to handle URIs that break parsing documents with malformed links (#793)
- Added `OpenXmlCompositeElement.AddChild(OpenXmlElement)` to add children in the correct order per schema (#774)
- Added `SmartTagClean` and `SmartTagId` in place of `SmtClean` and `SmtId` (#747)
- Added `OpenXmlValidator.Validate(..., CancellationToken)` overrides to allow easier cancellation of long running validation on .NET 4.0+ (#773)
- Added overloads for `CellValue` to take `decimal`, `double`, and `int`, as well as convenience methods to parse them (#782)
- Added validation for `CellType` for numbers and date formats (#782)
- Added `OpenXmlReader.GetLineInfo()` to retrieve `IXmlLineInfo` of the underlying reader if available (#804)

### Fixed
- Fixed exception that would be thrown if attempting to save a document as FlatOPC if it contains SVG files (#822)
- Added `SchemaAttrAttribute` attributes back for backwards compatibility (#825)

### Removed
- Removed explicit reference to `System.IO.Packaging` on .NET 4.6 builds (#774)

## [2.11.3] - 2020-07-17
### Fixed
- Fixed massive performance bottleneck when `IndexReferenceConstraint` and `ReferenceExistConstraint` are involved (#763)
- Fixed `CellValue` to only include three most signficant digits on second fractions to correct issue loading dates (#741)
- Fixed a couple of validation indexing errors that might cause erroneous validation errors (#767)
- Updated internal validation system to not use recursion, allowing for better short-circuiting (#766)

## [2.11.2] - 2020-07-10

### Fixed
- Fixed broken source link (#749)
- Ensured compilation is deterministic (#749)
- Removed extra file in NuGet package (#749)

## [2.11.1] - 2020-07-10

### Fixed
- Ensure .NET Framework builds pass PEVerify (#744)
- `OpenXmlPartContainer.DeletePart` no longer throws an exception if there isn't a match for the identifier given (#740)
- Mark obsolete members to not show up with Intellisense (#745)
- Fixed issue with `AttributeRequiredConditionToValue` semantic constraint where validation could fail on correct input (#746)

## [2.11.0] - 2020-05-21
### Added
- Added `FileFormatVersions.2019` enum (#695)
- Added `ChartSpace` and chart elements for the new 2016 namespaces. This allows the connecting pieces for building a chart part with chart styles like "Sunburst" (#687).
- Added `OpenXmlElementFunctionalExtensions.With(...)` extension methods, which offer flexible means for constructing `OpenXmlElement` instances in the context of pure functional transformations (#679)
- Added minimum Office versions for enum types and values (#707)
- Added additional `CompatSettingNameValues` values: `UseWord2013TrackBottomHyphenation`, `AllowHyphenationAtTrackBottom`, and `AllowTextAfterFloatingTableBreak` (#706)
- Added gfxdata attribue to Arc, Curve, Line, PolyLine, Group, Image, Oval, Rect, and RoundRect shape complex types per MS-OI29500 2.1.1783-1799 (#709)
- Added `OpenXmlPartContainer.TryGetPartById` to enable child part retrieval without exception if it does not exist (#714)
- Added `OpenXmlPackage.StrictRelationshipFound` property that indicates whether this package contains Transitional relationships converted from Strict (#716)

### Fixed
- Custom derived parts did not inherit known parts from its parent, causing failure when adding parts (#722)

### Changed
- Marked the property setters in `OpenXmlAttribute` as obsolete as structs should not have mutable state (#698)

## [2.10.1] - 2020-02-28
### Fixed
- Ensured attributes are available when `OpenXmlElement` is initialized with outer XML (#684, #692)
- Some documentation errors (#681)
- Removed state that made it non-thread safe to validate elements under certain conditions (#686)
- Correctly inserts strongly-typed elements before known elements that are not strongly-typed (#690)

## [2.10.0] - 2020-01-10
### Added
- Added initial Office 2016 support, including `FileFormatVersion.Office2016`, `ExtendedChartPart` and other new schema elements (#586)
- Added .NET Standard 2.0 target (#587)
- Included symbols support for debugging (#650)
- Exposed `IXmlNamespaceResolver` from `XmlPath` instead of formatted list of strings to expose namespace/prefix mapping (#536)
- Implemented `IComparable<T>` and `IEquatable<T>` on `OpenXmlComparableSimpleValue` to allow comparisons without boxing (#550)
- Added `OpenXmlPackage.RootPart` to easily access the root part on any package (#661)

### Changed
- Updated to v4.7.0 of System.IO.Packaging which brings in a number of perf fixes (#660)
- Consolidated data for element children/properties to reduce duplication (#540, #547, #548)
- Replaced opaque binary data for element children constraints with declarative model (#603)
- A number of performance fixes to minimize allocations where possible
- 20% size reduction from 5.5mb to 4.3mb
- The validation subsystem went through a drastic redesign. This may cause changes in what errors are reported.

### Fixed
- Fixed some documentation inconsistencies (#582)
- Fixed `ToFlatOpcDocument`, `ToFlatOpcString`, `FromFlatOpcDocument`, and `FromFlatOpcString` to correctly process Alternative Format Import Parts, or "altChunk parts" (#659)

## [2.9.1] - 2019-03-13
### Changed
- Added a workaround for a .NET Native compiler issue that doesn't support calling Marshal.SizeOf<T> with a struct that contains auto-implemented properties (#569)
- Fixed a documentation error (#528)

## [2.9.0] - 2018-06-08
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

## [2.8.1] - 2018-01-03
### Changed
- Corrected package license file reference to show updated MIT License

## [2.8.0] - 2017-12-28
### Added
- Default runtime directive for better .NET Native support.

### Changed
- Fixed part saving to be encoded with UTF8 but no byte order mark. This caused some renderers to not be able to open the generated document.
- Fixed exceptions thrown when errors are encountered while opening packages to be consistent across platforms.
- Fixed issue on Mono platforms using System.IO.Packaging NuGet package (Xamarin, etc) when creating a document.
- Fixed manual saving of a package when autosave is false.
- Fixed schema constraint data and standardized serialization across platforms.
- Upgraded to `System.IO.Packaging` version 4.4.0 which fixes some consistency with .NET Framework in opening packages.

## [2.7.2] - 2017-06-06
### Added
- Package now supports .NET 3.5 and .NET 4.0 in addition to .NET Standard 1.3 and .NET Framework 4.6

### Changed
- Fixed issue where assembly version wasn't set in assembly. 

## [2.7.1] - 2017-01-31
### Changed
- Fixed crash when validation is invoked on .NET Framework with strong-naming enforced.

## [2.7.0] - 2017-01-24
### Added
- SDK now  supports .NET Standard 1.3

### Changed
- Moved to using System.IO.Packaging from dotnet/corefx for .NET Standard 1.3 and WindowsBase for .NET 4.5.
- Cleaned up project build system to use .NET CLI.

## [2.6.1] - 2016-01-15
### Added
- Added hundreds of XUnit tests. There are now a total of 1333 tests. They take about 20 minutes to run, so be patient.

## [2.6.0] - 2015-06-29
### Added
- Incorporated a replacement `System.IO.Packaging` that fixes some serious (but exceptional) bugs found in the WindowsBase implementation
