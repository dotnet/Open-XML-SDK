# DocumentFormat.OpenXml.Features

Optional feature extensions that add incremental functionality on top of the core Open XML SDK.

This package is intended for advanced scenarios where you need specific feature sets layered over `DocumentFormat.OpenXml`.

## Scenarios

- Paragraph ID management for Word documents (generate and track unique paragraph IDs, optionally ensuring uniqueness across existing content and new paragraphs).
- Random number generation as a reusable feature attached to an `OpenXmlPackage`, used by higher-level features such as paragraph ID generation.
- Element and part change events so you can react when parts or elements are added, removed, or reloaded in a package.
- Shared/composed features that aggregate the same feature type (for example, paragraph ID tracking) across multiple documents.

## Documentation and feedback

- Official SDK docs: https://learn.microsoft.com/en-us/office/open-xml/open-xml-sdk
- Source and feature examples: https://github.com/dotnet/Open-XML-SDK
- Issues and ideas: https://github.com/dotnet/Open-XML-SDK/issues
