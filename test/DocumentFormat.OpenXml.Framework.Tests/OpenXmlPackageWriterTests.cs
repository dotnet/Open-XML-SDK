// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;
using System.IO.Packaging;
using Xunit;

using W = DocumentFormat.OpenXml.Wordprocessing;
using S = DocumentFormat.OpenXml.Spreadsheet;
using P = DocumentFormat.OpenXml.Presentation;

namespace DocumentFormat.OpenXml.Framework.Tests;

#pragma warning disable OOXML0005

public class OpenXmlPackageWriterTests
{
    [Fact]
    public void WriteMinimalDocx_RoundTrips()
    {
        using var ms = new MemoryStream();

        using (var writer = new OpenXmlPackageWriter(ms, leaveOpen: true))
        {
            writer.AddRelationship(
                new Uri("/word/document.xml", UriKind.Relative),
                "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",
                "rId1");

            writer.WritePart(
                new Uri("/word/document.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml",
                new Document(new Body(new Paragraph(new Run(new Text("Hello!"))))));
        }

        ms.Position = 0;

        using var doc = WordprocessingDocument.Open(ms, false);
        Assert.NotNull(doc.MainDocumentPart);
        Assert.NotNull(doc.MainDocumentPart!.Document);
        Assert.Equal("Hello!", doc.MainDocumentPart.Document.Body!.InnerText);
    }

    [Fact]
    public void CreateForwardOnly_WordDocument_RoundTrips()
    {
        using var ms = new MemoryStream();

        using (var writer = WordprocessingDocument.CreateForwardOnly(ms, WordprocessingDocumentType.Document, leaveOpen: true))
        {
            writer.WritePart(
                new Uri("/word/document.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml",
                new Document(new Body(new Paragraph(new Run(new Text("Forward-only!"))))));
        }

        ms.Position = 0;

        using var doc = WordprocessingDocument.Open(ms, false);
        Assert.NotNull(doc.MainDocumentPart);
        Assert.Equal("Forward-only!", doc.MainDocumentPart!.Document!.Body!.InnerText);
    }

    [Fact]
    public void WriteToNonSeekableStream()
    {
        using var ms = new MemoryStream();
        using var nonSeekable = new NonSeekableStream(ms);

        using (var writer = new OpenXmlPackageWriter(nonSeekable, leaveOpen: true))
        {
            writer.AddRelationship(
                new Uri("/word/document.xml", UriKind.Relative),
                "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",
                "rId1");

            writer.WritePart(
                new Uri("/word/document.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml",
                new Document(new Body(new Paragraph(new Run(new Text("Non-seekable!"))))));
        }

        ms.Position = 0;

        using var doc = WordprocessingDocument.Open(ms, false);
        Assert.NotNull(doc.MainDocumentPart);
        Assert.Equal("Non-seekable!", doc.MainDocumentPart!.Document!.Body!.InnerText);
    }

    [Fact]
    public void CreatePart_WithOpenXmlWriter()
    {
        using var ms = new MemoryStream();

        using (var writer = new OpenXmlPackageWriter(ms, leaveOpen: true))
        {
            writer.AddRelationship(
                new Uri("/word/document.xml", UriKind.Relative),
                "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",
                "rId1");

            using (var entry = writer.CreatePart(
                new Uri("/word/document.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml"))
            {
                using var xmlWriter = OpenXmlWriter.Create(entry.Stream);
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement(new Document());
                xmlWriter.WriteStartElement(new Body());
                xmlWriter.WriteElement(new Paragraph(new Run(new Text("Streamed!"))));
                xmlWriter.WriteEndElement(); // Body
                xmlWriter.WriteEndElement(); // Document
            }
        }

        ms.Position = 0;

        using var doc = WordprocessingDocument.Open(ms, false);
        Assert.NotNull(doc.MainDocumentPart);
        Assert.Equal("Streamed!", doc.MainDocumentPart!.Document!.Body!.InnerText);
    }

    [Fact]
    public void PartRelationships_AreWritten()
    {
        using var ms = new MemoryStream();

        using (var writer = new OpenXmlPackageWriter(ms, leaveOpen: true))
        {
            writer.AddRelationship(
                new Uri("/word/document.xml", UriKind.Relative),
                "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",
                "rId1");

            using (var entry = writer.CreatePart(
                new Uri("/word/document.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml"))
            {
                entry.AddRelationship(
                    new Uri("styles.xml", UriKind.Relative),
                    "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles",
                    id: "rId1");

                using var xmlWriter = OpenXmlWriter.Create(entry.Stream);
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement(new Document());
                xmlWriter.WriteStartElement(new Body());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }

            writer.WritePart(
                new Uri("/word/styles.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.wordprocessingml.styles+xml",
                new Styles());
        }

        ms.Position = 0;

        using var doc = WordprocessingDocument.Open(ms, false);
        Assert.NotNull(doc.MainDocumentPart);

        // Verify the part-level relationship was written
        var rels = doc.MainDocumentPart!.GetPartsOfType<StyleDefinitionsPart>();
        Assert.NotEmpty(rels);
    }

    [Fact]
    public void DuplicatePartUri_Throws()
    {
        using var ms = new MemoryStream();
        using var writer = new OpenXmlPackageWriter(ms);

        writer.WritePart(
            new Uri("/word/document.xml", UriKind.Relative),
            "application/xml",
            new Document());

        Assert.Throws<InvalidOperationException>(() =>
            writer.WritePart(
                new Uri("/word/document.xml", UriKind.Relative),
                "application/xml",
                new Document()));
    }

    [Fact]
    public void OperationsAfterFinish_Throw()
    {
        using var ms = new MemoryStream();
        var writer = new OpenXmlPackageWriter(ms, leaveOpen: true);
        writer.Finish();

        Assert.Throws<InvalidOperationException>(() =>
            writer.AddRelationship(new Uri("/foo.xml", UriKind.Relative), "type"));

        Assert.Throws<InvalidOperationException>(() =>
            writer.CreatePart(new Uri("/foo.xml", UriKind.Relative), "type"));
    }

    [Fact]
    public void AutoDisposesPreviousPartEntry()
    {
        using var ms = new MemoryStream();

        using var writer = new OpenXmlPackageWriter(ms, leaveOpen: true);

        writer.AddRelationship(
            new Uri("/word/document.xml", UriKind.Relative),
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",
            "rId1");

        // Create first part - don't dispose it manually
        var entry1 = writer.CreatePart(
            new Uri("/word/document.xml", UriKind.Relative),
            "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml");

        // Writing to it should work
        using (var xmlWriter = OpenXmlWriter.Create(entry1.Stream))
        {
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement(new Document());
            xmlWriter.WriteEndElement();
        }

        // Creating a second part should auto-dispose the first
        var entry2 = writer.CreatePart(
            new Uri("/word/styles.xml", UriKind.Relative),
            "application/vnd.openxmlformats-officedocument.wordprocessingml.styles+xml");

        // The first entry's stream should now be disposed
        Assert.Throws<ObjectDisposedException>(() => entry1.Stream);

        entry2.Dispose();
    }

    [Fact]
    public void CreateForwardOnly_SpreadsheetDocument_RoundTrips()
    {
        using var ms = new MemoryStream();

        using (var writer = SpreadsheetDocument.CreateForwardOnly(ms, SpreadsheetDocumentType.Workbook, leaveOpen: true))
        {
            writer.WritePart(
                new Uri("/xl/workbook.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml",
                new S.Workbook(new S.Sheets(new S.Sheet { Name = "Sheet1", SheetId = 1, Id = "rId1" })),
                new[]
                {
                    new PartRelationship(
                        new Uri("worksheets/sheet1.xml", UriKind.Relative),
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet",
                        id: "rId1"),
                });

            writer.WritePart(
                new Uri("/xl/worksheets/sheet1.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml",
                new S.Worksheet(new S.SheetData(
                    new S.Row(new S.Cell { CellValue = new S.CellValue("42"), DataType = S.CellValues.Number }))));
        }

        ms.Position = 0;

        using var doc = SpreadsheetDocument.Open(ms, false);
        Assert.NotNull(doc.WorkbookPart);
        Assert.NotNull(doc.WorkbookPart!.Workbook);
        Assert.NotEmpty(doc.WorkbookPart.Workbook.Sheets!);
    }

    [Fact]
    public void CreateForwardOnly_PresentationDocument_RoundTrips()
    {
        using var ms = new MemoryStream();

        using (var writer = PresentationDocument.CreateForwardOnly(ms, PresentationDocumentType.Presentation, leaveOpen: true))
        {
            writer.WritePart(
                new Uri("/ppt/presentation.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.presentationml.presentation.main+xml",
                new P.Presentation(new P.SlideIdList()));
        }

        ms.Position = 0;

        using var doc = PresentationDocument.Open(ms, false);
        Assert.NotNull(doc.PresentationPart);
        Assert.NotNull(doc.PresentationPart!.Presentation);
    }

    [Fact]
    public void ExternalRelationship_IsWritten()
    {
        using var ms = new MemoryStream();

        using (var writer = new OpenXmlPackageWriter(ms, leaveOpen: true))
        {
            writer.AddRelationship(
                new Uri("/word/document.xml", UriKind.Relative),
                "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",
                "rId1");

            using (var entry = writer.CreatePart(
                new Uri("/word/document.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml"))
            {
                entry.AddRelationship(
                    new Uri("https://example.com", UriKind.Absolute),
                    "http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink",
                    TargetMode.External,
                    "rId1");

                using var xmlWriter = OpenXmlWriter.Create(entry.Stream);
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement(new Document());
                xmlWriter.WriteStartElement(new Body());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }
        }

        ms.Position = 0;

        using var doc = WordprocessingDocument.Open(ms, false);
        Assert.NotNull(doc.MainDocumentPart);

        var hyperlinks = doc.MainDocumentPart!.HyperlinkRelationships;
        Assert.NotEmpty(hyperlinks);
    }

    [Fact]
    public void NullStream_Throws()
    {
        Assert.Throws<ArgumentNullException>(() => new OpenXmlPackageWriter(null!));
    }

    [Fact]
    public void NullPartUri_Throws()
    {
        using var ms = new MemoryStream();
        using var writer = new OpenXmlPackageWriter(ms);
        Assert.Throws<ArgumentNullException>(() => writer.CreatePart(null!, "text/xml"));
    }

    [Fact]
    public void NullContentType_Throws()
    {
        using var ms = new MemoryStream();
        using var writer = new OpenXmlPackageWriter(ms);
        Assert.Throws<ArgumentNullException>(() => writer.CreatePart(new Uri("/foo.xml", UriKind.Relative), null!));
    }

    [Fact]
    public void NullRootElement_Throws()
    {
        using var ms = new MemoryStream();
        using var writer = new OpenXmlPackageWriter(ms);
        Assert.Throws<ArgumentNullException>(() => writer.WritePart(new Uri("/foo.xml", UriKind.Relative), "text/xml", null!));
    }

    [Fact]
    public void AddRelationship_AutoGeneratesId()
    {
        using var ms = new MemoryStream();
        using var writer = new OpenXmlPackageWriter(ms);
        var id = writer.AddRelationship(new Uri("/foo.xml", UriKind.Relative), "type");
        Assert.StartsWith("rId", id);
    }

    [Fact]
    public void PartEntry_AddRelationship_AutoGeneratesId()
    {
        using var ms = new MemoryStream();
        using var writer = new OpenXmlPackageWriter(ms);
        using var entry = writer.CreatePart(new Uri("/foo.xml", UriKind.Relative), "text/xml");
        var id = entry.AddRelationship(new Uri("bar.xml", UriKind.Relative), "type");
        Assert.StartsWith("rId", id);
    }

    [Fact]
    public void PartEntry_AddRelationship_AfterDispose_Throws()
    {
        using var ms = new MemoryStream();
        using var writer = new OpenXmlPackageWriter(ms);
        var entry = writer.CreatePart(new Uri("/foo.xml", UriKind.Relative), "text/xml");
        entry.Dispose();
        Assert.Throws<ObjectDisposedException>(() =>
            entry.AddRelationship(new Uri("bar.xml", UriKind.Relative), "type"));
    }

    [Fact]
    public void FinishCalledTwice_DoesNotThrow()
    {
        using var ms = new MemoryStream();
        var writer = new OpenXmlPackageWriter(ms, leaveOpen: true);
        writer.Finish();
        writer.Finish(); // second call should be no-op
        writer.Dispose();
    }

    [Fact]
    public void PartRelationship_Properties()
    {
        var uri = new Uri("foo.xml", UriKind.Relative);
        var rel = new PartRelationship(uri, "type", TargetMode.External, "rId1");
        Assert.Equal(uri, rel.TargetUri);
        Assert.Equal("type", rel.RelationshipType);
        Assert.Equal(TargetMode.External, rel.TargetMode);
        Assert.Equal("rId1", rel.Id);
    }

    [Fact]
    public void PartRelationship_DefaultValues()
    {
        var uri = new Uri("foo.xml", UriKind.Relative);
        var rel = new PartRelationship(uri, "type");
        Assert.Equal(TargetMode.Internal, rel.TargetMode);
        Assert.Null(rel.Id);
    }

#if NET6_0_OR_GREATER
    [Fact]
    public async System.Threading.Tasks.Task DisposeAsync_FinalizesPackage()
    {
        using var ms = new MemoryStream();

        await using (var writer = new OpenXmlPackageWriter(ms, leaveOpen: true))
        {
            writer.AddRelationship(
                new Uri("/word/document.xml", UriKind.Relative),
                "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",
                "rId1");

            writer.WritePart(
                new Uri("/word/document.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml",
                new Document(new Body()));
        }

        ms.Position = 0;

        using var doc = WordprocessingDocument.Open(ms, false);
        Assert.NotNull(doc.MainDocumentPart);
    }
#endif

    private class NonSeekableStream : Stream
    {
        private readonly Stream _inner;

        public NonSeekableStream(Stream inner) => _inner = inner;

        public override bool CanRead => false;

        public override bool CanSeek => false;

        public override bool CanWrite => _inner.CanWrite;

        public override long Length => throw new NotSupportedException();

        public override long Position
        {
            get => throw new NotSupportedException();
            set => throw new NotSupportedException();
        }

        public override void Flush() => _inner.Flush();

        public override int Read(byte[] buffer, int offset, int count)
            => throw new NotSupportedException();

        public override long Seek(long offset, SeekOrigin origin)
            => throw new NotSupportedException();

        public override void SetLength(long value)
            => throw new NotSupportedException();

        public override void Write(byte[] buffer, int offset, int count)
            => _inner.Write(buffer, offset, count);
    }
}
