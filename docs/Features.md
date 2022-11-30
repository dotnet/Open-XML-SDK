# Features

Features are a new concept in v2.14 and later that allows for behavior and state to be contained within the document or part. This is accessed via `Features` property  on packages, parts, and elements. Elements inherit part features, and parts inherit package features.

This is inspired by the pattern ASP.NET Core uses to modify behavior of HttpContext: https://learn.microsoft.com/aspnet/core/fundamentals/request-features

## Current Features

The features that are currently available are described below and at what scope they are available. This is important, because and element by itself will not have any features available, while an element in one part may have different features than another part.

### IPackageEventsFeature

This feature allows getting event notifications of when a package is changed:

```csharp
OpenXmlPackage package = GetSomePackage();
package.TryAddPackageEventsFeature();

var feature = package.Features.GetRequired<IPackageEventsFeature>();
```

> Note: There may be times when the package is changed but an event is not fired. Not all areas have been identified where it would make sense to raise an event. Please file an issue if you find one.

### IPartEventsFeature

This feature allows getting event notifications of when an event is being created. This is a feature that is added to the part or package:

```csharp
OpenXmlPart part = GetSomePackage();
package.AddPartEventsFeature();

var feature = part.Features.GetRequired<IPartEventsFeature>();
```

Generally, assume that there may be a singleton implementation for the events and verify that the part is the correct part.

> Note: There may be times when the part is changed but an event is not fired. Not all areas have been identified where it would make sense to raise an event. Please file an issue if you find one.

### IPartRootEventsFeature

This feature allows getting event notifications of when a part root is being modified/loaded/created/etc. This is a feature that is added to the part level feature:

```csharp
OpenXmlPart part = GetSomePart();
part.AddPartRootEventsFeature();

var feature = part.Features.GetRequired<IPartRootEventsFeature>();
```

Generally, assume that there may be a singleton implementation for the events and verify that the part is the correct part.

> Note: There may be times when the part root is changed but an event is not fired. Not all areas have been identified where it would make sense to raise an event. Please file an issue if you find one.

## DocumentFormat.OpenXml.Features - unreleased

This library contains additional (non-core) features that build on top of built-in features and functionality.

### IDisposableFeature

This feature allows for registering features that need to be disposed at the same time as the feature goes out of scope. This allows a feature to be created, but its lifetime managed concurrently with the collection it is added to. The recommended way to use it is simply to call the following method:

```csharp
OpenXmlPackage package = GetSomePackage();
package.TryAddDisposableFeature();

OpenXmlPart part = GetSomePart();
part.SetDisposable(new ExampleFeature());

public class ExampleFeature : IDisposable
{
}
```

This will add `ExampleFeature` to the part feature, and register it to be disposed when the part is disposed.

### IRandomNumberGeneratorFeature
This feature allows for a shared service to generate random numbers and fill an array.

### IParagraphIdGeneratorFeature

This feature allows for population and tracking of elements that contain paragraph ids. By default, this will ensure uniqueness of values and ensure that values that do exist are valid per the constraints of the standard. To use this feature:

```csharp
WordprocessingDocument document = CreateWordDocument();
document.TryAddParagraphIdFeature();

var part = doc.AddMainDocumentPart();
var body = new Body();
part.Document = new Document(body);

var p = new Paragraph();
body.AddChild(p); // After adding p.ParagraphId will be set to a unique, valid value
```

This feature can also be used to ensure uniqueness among multiple documents with a slight change:

```csharp
using var doc1 = CreateDocument1();
using var doc2 = CreateDocument2();

var shared = doc1
    .AddSharedParagraphIdFeature()
    .Add(doc2);

// Add item to doc1
var part1 = doc1.AddMainDocumentPart();
var body1 = new Body();
var p1 = new Paragraph();
part1.Document = new Document(body1);
body1.AddChild(p1);

// Add item with same ID to doc2
var part2 = doc2.AddMainDocumentPart();
var body2 = new Body();
var p2 = new Paragraph { ParagraphId = p1.ParagraphId };
part2.Document = new Document(body2);
body2.AddChild(p2);

// Assert
Assert.NotEqual(p1.ParagraphId, p2.ParagraphId);
Assert.Equal(2, shared.Count);
```

## DocumentFormat.OpenXml.Linq - unreleased

### IPartRootXElementFeature

This feature allows operating on an `OpenXmlPart` by using XLinq features and directly manipulating `XElement` nodes.

```csharp
OpenXmlPart part = GetSomePart();

var node = new(W.document, new XAttribute(XNamespace.Xmlns + "w", W.w),
    new XElement(W.body,
        new XElement(W.p,
            new XElement(W.r,
                new XElement(W.t, "Hello World!")))));

part.SetXElement(node);
```

This `XElement` is cached but will be kept in sync with the underlying part if it were to change.
