﻿// Copyright (c) Microsoft. All rights reserved.
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
        // Type of WordprocessingDocuments to be created for unit tests.
        private const WordprocessingDocumentType Document = WordprocessingDocumentType.Document;

        // XML namespace of Flat OPC documents.
        private static readonly XNamespace Pkg = "http://schemas.microsoft.com/office/2006/xmlPackage";

        // The following are some of the content types of AlternativeFormatInputParts.
        // Note that all of those end in "xml" or even "+xml". And note that the content
        // type of AlternativeFormatInputParts containing WordprocessingML documents is
        // identical to the content type of the MainDocumentPart.
        private const string XhtmlContentType = "application/xhtml+xml";
        private const string XmlContentType = "application/xml";
        private const string WordprocessingMLContentType =
            "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml";

        // Contents of the application/xhtml+xml altChunk part.
        private const string XhtmlString =
            @"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"">
<head>
  <title>Title of XHTML Document</title>
</head>
<body>
  <h1>XHTML Document Heading</h1>
  <p>This is a paragraph.</p>
</body>
</html>";

        // Contents of the application/xml altChunk part.
        private const string XmlString =
            @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?><root><element>Some text</element></root>";

        // Contents of the WordprocessingML altChunk part.
        private static readonly byte[] WordprocessingMLBytes = CreateWordprocessingMLBytes();

        private static byte[] CreateWordprocessingMLBytes()
        {
            var stream = new MemoryStream();

            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(stream, Document))
            {
                MainDocumentPart mainDocumentPart = wordDocument.AddMainDocumentPart();
                mainDocumentPart.Document =
                    new Document(
                        new Body(
                            new Paragraph(
                                new Run(
                                    new Text("AltChunk Document")))));
            }

            return stream.ToArray();
        }

        private static MemoryStream CreateWordprocessingDocumentWithAltChunks()
        {
            var stream = new MemoryStream();

            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(stream, Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document =
                    new Document(
                        new Body(
                            CreateWordprocessingMLAltChunk(wordDocument),
                            CreateXhtmlAltChunk(wordDocument),
                            CreateXmlAltChunk(wordDocument)));
            }

            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }

        private static AltChunk CreateWordprocessingMLAltChunk(WordprocessingDocument wordDocument)
        {
            string altChunkId = "BinaryAltChunkId-" + Guid.NewGuid();
            AlternativeFormatImportPart chunk = wordDocument.MainDocumentPart.AddAlternativeFormatImportPart(
                AlternativeFormatImportPartType.WordprocessingML, altChunkId);

            using (Stream stream = chunk.GetStream(FileMode.Create))
            using (var writer = new BinaryWriter(stream))
            {
                writer.Write(WordprocessingMLBytes);
            }

            return new AltChunk { Id = altChunkId };
        }

        private static AltChunk CreateXhtmlAltChunk(WordprocessingDocument wordDocument)
        {
            return CreateAltChunkWithXmlContent(wordDocument, AlternativeFormatImportPartType.Xhtml, XhtmlString);
        }

        private static AltChunk CreateXmlAltChunk(WordprocessingDocument wordDocument)
        {
            return CreateAltChunkWithXmlContent(wordDocument, AlternativeFormatImportPartType.Xml, XmlString);
        }

        private static AltChunk CreateAltChunkWithXmlContent(
            WordprocessingDocument wordDocument,
            AlternativeFormatImportPartType contentType,
            string xmlContent)
        {
            string altChunkId = "XmlAltChunkId-" + Guid.NewGuid();
            AlternativeFormatImportPart chunk = wordDocument.MainDocumentPart.AddAlternativeFormatImportPart(
                contentType, altChunkId);

            using (Stream stream = chunk.GetStream(FileMode.Create))
            using (var writer = new StreamWriter(stream))
            {
                writer.WriteLine(xmlContent);
            }

            return new AltChunk { Id = altChunkId };
        }

        private static void AssertXmlContentEquals(OpenXmlPart part, string expected)
        {
            using (Stream stream = part.GetStream(FileMode.Open))
            using (var reader = new StreamReader(stream))
            {
                Assert.Equal(expected, reader.ReadToEnd().Trim());
            }
        }

        private static void AssertBinaryContentEquals(OpenXmlPart part, byte[] expected)
        {
            using (Stream stream = part.GetStream(FileMode.Open))
            {
                var buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                Assert.Equal(expected, buffer);
            }
        }

        [Fact]
        public void CanRoundTripWordprocessingDocumentWithAltChunks()
        {
            using (MemoryStream stream = CreateWordprocessingDocumentWithAltChunks())
            using (WordprocessingDocument original = WordprocessingDocument.Open(stream, false))
            {
                XDocument flatOpcDocument = original.ToFlatOpcDocument();

                using (WordprocessingDocument roundTripped = WordprocessingDocument.FromFlatOpcDocument(flatOpcDocument))
                {
                    List<AlternativeFormatImportPart> altChunkParts = roundTripped.MainDocumentPart
                        .GetPartsOfType<AlternativeFormatImportPart>()
                        .ToList();

                    AssertXmlContentEquals(
                        altChunkParts.First(p => p.ContentType == XhtmlContentType),
                        XhtmlString);

                    AssertXmlContentEquals(
                        altChunkParts.First(p => p.ContentType == XmlContentType),
                        XmlString);

                    AssertBinaryContentEquals(
                        altChunkParts.First(p => p.ContentType == WordprocessingMLContentType),
                        WordprocessingMLBytes);
                }
            }
        }

        [Fact]
        public void CanTransformWordprocessingDocumentWithAltChunksToFlatOpc()
        {
            using (Stream stream = CreateWordprocessingDocumentWithAltChunks())
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, false))
            {
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
