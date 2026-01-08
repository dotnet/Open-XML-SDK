# DocumentFormat.OpenXml

The core Open XML SDK library for working with Office Word, Excel, and PowerPoint documents using strongly-typed .NET APIs.

## Getting started

Create a simple Word document:

```csharp
using (var doc = WordprocessingDocument.Create("example.docx", WordprocessingDocumentType.Document))
{
    var mainPart = doc.AddMainDocumentPart();
    mainPart.Document = new Document(new Body(new Paragraph(new Run(new Text("Hello, Open XML!")))));
}
```

## Documentation and feedback

- Official SDK docs: https://learn.microsoft.com/en-us/office/open-xml/open-xml-sdk
- Source: https://github.com/dotnet/Open-XML-SDK
- Samples: https://github.com/dotnet/Open-XML-SDK/tree/main/samples
- Issues and feature requests: https://github.com/dotnet/Open-XML-SDK/issues
