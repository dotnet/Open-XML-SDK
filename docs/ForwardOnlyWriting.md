# Forward-Only Document Writing

> **Experimental**: This API is marked with `OOXML0005` and is subject to change.

The `OpenXmlPackageWriter` enables forward-only creation of OpenXML documents (.docx, .xlsx, .pptx) directly to any writable stream, including non-seekable streams. This eliminates the need for a temporary `MemoryStream` that the standard `Create` methods require.

## When to Use

- Writing documents to HTTP response streams (`HttpResponse.Body`)
- Writing to network streams or cloud storage upload streams
- Generating large documents where you want to avoid buffering the entire package in memory
- Any scenario where the target stream is not seekable

## Quick Start

### Word Document

```csharp
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using var writer = WordprocessingDocument.CreateForwardOnly(
    outputStream, WordprocessingDocumentType.Document, leaveOpen: true);

writer.WritePart(
    new Uri("/word/document.xml", UriKind.Relative),
    "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml",
    new Document(
        new Body(
            new Paragraph(
                new Run(new Text("Hello, forward-only world!"))))));
```

### Spreadsheet

```csharp
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

using var writer = SpreadsheetDocument.CreateForwardOnly(
    outputStream, SpreadsheetDocumentType.Workbook);

// Write the worksheet first
writer.WritePart(
    new Uri("/xl/worksheets/sheet1.xml", UriKind.Relative),
    "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml",
    new Worksheet(new SheetData(
        new Row(new Cell { CellValue = new CellValue("42"), DataType = CellValues.Number }))));

// Write the workbook, referencing the worksheet
writer.WritePart(
    new Uri("/xl/workbook.xml", UriKind.Relative),
    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml",
    new Workbook(new Sheets(
        new Sheet { Name = "Sheet1", SheetId = 1, Id = "rId1" })),
    relationships: new[]
    {
        new PartRelationship(
            new Uri("worksheets/sheet1.xml", UriKind.Relative),
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet",
            id: "rId1"),
    });
```

## Core API

### OpenXmlPackageWriter

The main writer class. Created via the constructor or typed factory methods.

```csharp
// Direct construction
var writer = new OpenXmlPackageWriter(stream, leaveOpen: false);

// Typed factory methods (pre-register main part relationship)
var writer = WordprocessingDocument.CreateForwardOnly(stream, type, leaveOpen);
var writer = SpreadsheetDocument.CreateForwardOnly(stream, type, leaveOpen);
var writer = PresentationDocument.CreateForwardOnly(stream, type, leaveOpen);
```

**Methods:**

| Method | Description |
|--------|-------------|
| `AddRelationship(partUri, relationshipType, id?)` | Adds a package-level relationship (written to `_rels/.rels`) |
| `CreatePart(partUri, contentType)` | Creates a part and returns an `OpenXmlPartEntry` for streaming writes |
| `WritePart(partUri, contentType, rootElement, relationships?)` | One-shot: writes an element tree as a complete part |
| `Finish()` | Finalizes the package (writes content types and relationships) |
| `Dispose()` / `DisposeAsync()` | Calls `Finish()` if needed, then closes the underlying ZIP |

### OpenXmlPartEntry

Returned by `CreatePart`. Provides access to the part's output stream for streaming XML writing.

```csharp
using var entry = writer.CreatePart(partUri, contentType);

// Add part-level relationships
entry.AddRelationship(targetUri, relationshipType, targetMode, id);

// Write XML content using OpenXmlWriter
using var xmlWriter = OpenXmlWriter.Create(entry.Stream);
xmlWriter.WriteStartDocument();
xmlWriter.WriteStartElement(new Worksheet());
xmlWriter.WriteStartElement(new SheetData());
foreach (var row in GetRows())
{
    xmlWriter.WriteElement(row);
}
xmlWriter.WriteEndElement(); // SheetData
xmlWriter.WriteEndElement(); // Worksheet
```

### PartRelationship

Used with `WritePart` to declare part-level relationships inline.

```csharp
new PartRelationship(
    targetUri: new Uri("styles.xml", UriKind.Relative),
    relationshipType: "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles",
    targetMode: TargetMode.Internal, // default
    id: "rId1") // optional, auto-generated if null
```

## Key Behaviors

- **Only one part can be open at a time.** Creating a new part auto-closes the previous one.
- **Parts cannot be modified after writing.** This is a forward-only writer.
- **Content types and relationships are written last** (during `Finish()`/`Dispose()`), so they capture all parts.
- **The stream does not need to be seekable.** The writer uses `ZipArchive` in create mode.
- **`Dispose()` finalizes the package.** You don't need to call `Finish()` explicitly.

## Comparison with Standard API

| | Standard `Create` | `CreateForwardOnly` |
|---|---|---|
| Requires seekable stream | Yes | No |
| Requires `MemoryStream` | Often | Never |
| Can modify parts after creation | Yes | No |
| Can read parts | Yes | No |
| DOM support | Full | Write-only |
| `OpenXmlWriter` support | Yes | Yes |
| Memory usage for large docs | Higher | Lower |

## Benchmarks

Measured on .NET 10.0 with BenchmarkDotNet (`MemoryDiagnoser`). Each scenario compares the standard `Create` API (backed by `System.IO.Packaging`) against `CreateForwardOnly` (backed by `ZipArchive`).

### Word

| Scenario | Approach | Mean | Allocated | Alloc vs Standard |
|---|---|---:|---:|---:|
| Simple (1 paragraph) | Standard | 23.29 us | 53.56 KB | 1.00 |
| | ForwardOnly | 28.73 us | 26.99 KB | **0.50** |
| Medium (20 paragraphs) | Standard | 51.48 us | 80.98 KB | 1.00 |
| | ForwardOnly | 52.56 us | 52.87 KB | **0.65** |
| Complex (100 paragraphs + styles) | Standard | 339.88 us | 366.91 KB | 1.00 |
| | ForwardOnly | 286.56 us | 287.82 KB | **0.78** |

### Spreadsheet

| Scenario | Approach | Mean | Allocated | Alloc vs Standard |
|---|---|---:|---:|---:|
| Simple (1 sheet, 1 row) | Standard | 70.66 us | 84.23 KB | 1.00 |
| | ForwardOnly | 49.94 us | 45.84 KB | **0.54** |
| Medium (100 rows x 10 cols) | Standard | 724.24 us | 809.52 KB | 1.00 |
| | ForwardOnly | 642.55 us | 681.31 KB | **0.84** |
| Complex (3 sheets, 500x10 each) | Standard | 17,602 us | 10,946 KB | 1.00 |
| | ForwardOnly | 9,934 us | 9,755 KB | **0.89** |

### Presentation

| Scenario | Approach | Mean | Allocated | Alloc vs Standard |
|---|---|---:|---:|---:|
| Simple (1 slide) | Standard | 67.68 us | 84.23 KB | 1.00 |
| | ForwardOnly | 48.75 us | 45.61 KB | **0.54** |
| Medium (10 slides) | Standard | 251.36 us | 283.25 KB | 1.00 |
| | ForwardOnly | 164.86 us | 160.09 KB | **0.57** |
| Complex (30 slides, 5 shapes each) | Standard | 1,373 us | 1,207 KB | 1.00 |
| | ForwardOnly | 998 us | 829 KB | **0.69** |

### Summary

- **Memory**: ForwardOnly allocates 50-89% of what Standard does. Biggest wins on simple documents where `System.IO.Packaging` overhead dominates.
- **Speed**: ForwardOnly is faster at scale -- up to 1.77x on large spreadsheets (17.6ms vs 9.9ms). Simple Word documents are roughly equivalent in speed.
- **GC pressure**: ForwardOnly consistently triggers fewer Gen0/Gen1 collections and avoids Gen2 collections entirely (Standard hit Gen2 on the complex spreadsheet benchmark).

Run the benchmarks yourself with:
```
dotnet run --project test/DocumentFormat.OpenXml.Benchmarks -c Release -- --filter "*ForwardOnly*"
```

## Platform Support

Available on `netstandard2.0` and .NET 6+. Not available on .NET Framework 3.5, 4.0, or 4.6.
