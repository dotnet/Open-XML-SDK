# Features

Features are a new concept in v2.14 and later that allows for behavior and state to be contained within the document or part. This is accessed via `OpenXmlPartContainer.Features` property and a document's features will be inherited into a part. All elements within a part will have a read-only access to the part's features (and thus the document's as well).

## Current Features

The features that are currently available are described below and at what scope they are available. This is important, because and element by itself will not have any features available, while an element in one part may have different features than another part.

### IPartEventsFeature

This feature allows getting event notifications of when an event is being created. This is a feature that is added to the package level feature:

```csharp
OpenXmlPackage package = GetSomePackage();
package.AddPartEventsFeature();

var feature = package.Features.GetRequired<IPartEventsFeature>();
```

### IPackageClosingEventsFeature

This feature allows getting event notifications of when a package is being closed:

```csharp
OpenXmlPackage package = GetSomePackage();
package.TryAddPackageEventsFeature();

var feature = package.Features.GetRequired<IPackageClosingEventsFeature>();
```

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
