# DocumentFormat.OpenXml.Linq

LINQ-friendly extensions for the Open XML SDK, providing XLINQ-based APIs for querying and transforming Open XML documents.

## Getting started

Basic usage with LINQ to XML:

```csharp
using (var doc = WordprocessingDocument.Open("example.docx", false))
{
    var xDoc = doc.MainDocumentPart!.GetXDocument();
    var paragraphs = from p in xDoc.Descendants(W.p)
                     select p;
}
```

## Documentation and feedback

- Official SDK docs: https://learn.microsoft.com/en-us/office/open-xml/open-xml-sdk
- LINQ samples: https://github.com/dotnet/Open-XML-SDK/tree/main/samples/Linq
- Issues and suggestions: https://github.com/dotnet/Open-XML-SDK/issues
