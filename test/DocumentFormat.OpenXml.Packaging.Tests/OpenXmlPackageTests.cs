// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Packaging.Tests
{
    public class OpenXmlPackageTests
    {
        private static readonly XNamespace Pkg = "http://schemas.microsoft.com/office/2006/xmlPackage";
        private const WordprocessingDocumentType Document = WordprocessingDocumentType.Document;

        // This is a sample XHTML document.
        private const string XhtmlString =
            @"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN""
""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">

<html xmlns=""http://www.w3.org/1999/xhtml"">
<head>
  <title>Title of XHTML Document</title>
</head>
<body>
  <h1>XHTML Document Heading</h1>
  <p>This is a paragraph.</p>
</body>
</html>";

        // This is a sample XML document.
        private const string XmlString =
            @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?><root><element>Some text</element></root>";

        // The following are some of the content types of AlternativeFormatInputParts.
        // Note that all of those end in "xml" or even "+xml". And note that the content
        // type of AlternativeFormatInputParts containing WordprocessingML documents is
        // identical to the content type of the MainDocumentPart.
        private const string XhtmlContentType = "application/xhtml+xml";
        private const string XmlContentType = "application/xml";
        private const string WordprocessingMLContentType =
            "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml";

        private static AltChunk CreateWordprocessingMLAltChunk(WordprocessingDocument wordDocument, string text)
        {
            using (Stream stream = CreateWordprocessingDocument(text))
            {
                string altChunkId = "DocxAltChunkId-" + Guid.NewGuid();
                AlternativeFormatImportPart chunk = wordDocument.MainDocumentPart.AddAlternativeFormatImportPart(
                    AlternativeFormatImportPartType.WordprocessingML, altChunkId);

                chunk.FeedData(stream);
                return new AltChunk { Id = altChunkId };
            }
        }

        private static Stream CreateWordprocessingDocument(string text)
        {
            var stream = new MemoryStream();

            using (WordprocessingDocument chunkDocument = WordprocessingDocument.Create(stream, Document))
            {
                MainDocumentPart mainDocumentPart = chunkDocument.AddMainDocumentPart();
                mainDocumentPart.Document = new Document(new Body(new Paragraph(new Run(new Text(text)))));
            }

            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }

        private static AltChunk CreateXhtmlAltChunk(WordprocessingDocument wordDocument)
        {
            string altChunkId = "XhtmlAltChunkId-" + Guid.NewGuid();
            AlternativeFormatImportPart chunk = wordDocument.MainDocumentPart.AddAlternativeFormatImportPart(
                AlternativeFormatImportPartType.Xhtml, altChunkId);

            using (Stream stream = chunk.GetStream(FileMode.Create))
            using (var writer = new StreamWriter(stream))
            {
                writer.WriteLine(XhtmlString);
            }

            return new AltChunk { Id = altChunkId };
        }

        private static AltChunk CreateXmlAltChunk(WordprocessingDocument wordDocument)
        {
            string altChunkId = "XmlAltChunkId-" + Guid.NewGuid();
            AlternativeFormatImportPart chunk = wordDocument.MainDocumentPart.AddAlternativeFormatImportPart(
                AlternativeFormatImportPartType.Xml, altChunkId);

            using (Stream stream = chunk.GetStream(FileMode.Create))
            using (var writer = new StreamWriter(stream))
            {
                writer.WriteLine(XmlString);
            }

            return new AltChunk { Id = altChunkId };
        }

        [Fact]
        public void CanTransformWordprocessingDocumentWithAltChunksToFlatOpc()
        {
            using (var stream = new MemoryStream())
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(stream, Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document =
                    new Document(
                        new Body(
                            CreateWordprocessingMLAltChunk(wordDocument, Guid.NewGuid().ToString()),
                            CreateXhtmlAltChunk(wordDocument),
                            CreateXmlAltChunk(wordDocument)));

                XDocument flatOpcDocument = wordDocument.ToFlatOpcDocument();

                XElement mainDocumentPart = flatOpcDocument
                    .Descendants(Pkg + "part")
                    .First(p => p.Attributes(Pkg + "name").Any(a => a.Value == "/word/document.xml"));

                IEnumerable<XElement> altChunkParts = flatOpcDocument
                    .Descendants(Pkg + "part")
                    .Where(p => p.Attributes(Pkg + "name").Any(a => a.Value.Contains("afchunk")))
                    .ToList();

                // We want our MainDocumentPart to contain XML data.
                Assert.Equal(WordprocessingMLContentType, (string) mainDocumentPart.Attribute(Pkg + "contentType"));
                Assert.NotEmpty(mainDocumentPart.Elements(Pkg + "xmlData"));

                // We want to see each one of our AlternativeFormatImportParts.
                Assert.Contains(altChunkParts, p => (string) p.Attribute(Pkg + "contentType") == XhtmlContentType);
                Assert.Contains(altChunkParts, p => (string) p.Attribute(Pkg + "contentType") == XmlContentType);
                Assert.Contains(altChunkParts, p => (string) p.Attribute(Pkg + "contentType") == WordprocessingMLContentType);

                // We want all of our AlternativeFormatImportParts to contain binary data,
                // even though two of them have a content type ending with "+xml".
                Assert.All(altChunkParts, p => Assert.NotEmpty(p.Elements(Pkg + "binaryData")));
            }
        }
    }
}
