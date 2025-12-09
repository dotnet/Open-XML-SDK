// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace DocumentFormat.OpenXml.Packaging.Tests
{
    public class OpenXmlPackageTests
    {
        // Type of WordprocessingDocuments to be created for unit tests.
        private const WordprocessingDocumentType Document = WordprocessingDocumentType.Document;

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

        // XML namespace of Flat OPC documents.
        private static readonly XNamespace Pkg = "http://schemas.microsoft.com/office/2006/xmlPackage";

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
            PartTypeInfo partType,
            string xmlContent)
        {
            string altChunkId = "XmlAltChunkId-" + Guid.NewGuid();
            AlternativeFormatImportPart chunk = wordDocument.MainDocumentPart.AddAlternativeFormatImportPart(
                partType, altChunkId);

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
                    List<AlternativeFormatImportPart> altChunkParts = roundTripped.MainDocumentPart!
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
                Assert.Equal(WordprocessingMLContentType, (string?)mainDocumentPart.Attribute(Pkg + "contentType"));
                Assert.NotEmpty(mainDocumentPart.Elements(Pkg + "xmlData"));

                // We want to see each one of our AlternativeFormatImportParts.
                Assert.Contains(altChunkParts, p => (string?)p.Attribute(Pkg + "contentType") == XhtmlContentType);
                Assert.Contains(altChunkParts, p => (string?)p.Attribute(Pkg + "contentType") == XmlContentType);
                Assert.Contains(altChunkParts, p => (string?)p.Attribute(Pkg + "contentType") == WordprocessingMLContentType);

                // We want all of our AlternativeFormatImportParts to contain binary data,
                // even though two of them have a content type ending with "+xml".
                Assert.All(altChunkParts, p => Assert.NotEmpty(p.Elements(Pkg + "binaryData")));
            }
        }

        private static MemoryStream CreatePresentationDocumentWithDataReference()
        {
            var stream = new MemoryStream();

            using (var ppt = PresentationDocument.Create(stream, PresentationDocumentType.Presentation))
            {
                var mainPart = ppt.AddPresentationPart();
                var slide = new Slide();
                var slidePart = mainPart.AddNewPart<SlidePart>();
                var dataPart = new MediaDataPart(ppt.InternalOpenXmlPackage, MediaDataPartType.Mp3);
                var dataPartReferenceRelationship = DataPartReferenceRelationship.Create(slidePart, dataPart, MediaReferenceRelationship.RelationshipTypeConst, "rId2");
                slidePart.AddDataPartReferenceRelationship(dataPartReferenceRelationship);
                slide.Save(slidePart);
                mainPart.Presentation = new Presentation.Presentation(slide);
                mainPart.Presentation.Save();
            }

            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }

        // This is a regression test case for issue #931
        // Saving a office documents opened using the OpenXML SDK removed data references from the saved document.
        // This lead to invalid documents that couldn't be opened by office.
        [Fact]
        public void TestDataReferenceRelationshipsAreClonedCorrectly()
        {
            using var stream = CreatePresentationDocumentWithDataReference();
            using var ppt = PresentationDocument.Open(stream, true);
            Assert.NotNull(ppt.PresentationPart);
            Assert.NotNull(ppt.PresentationPart.Presentation);
            Assert.Single(ppt.PresentationPart.SlideParts);
            var slidePart = ppt.PresentationPart.SlideParts.First();
            Assert.NotEmpty(slidePart.DataPartReferenceRelationships);
            var clonedStream = new MemoryStream();
            ppt.Clone(clonedStream);
            using var clonedPpt = PresentationDocument.Open(clonedStream, false);
            Assert.NotNull(clonedPpt.PresentationPart);
            Assert.NotNull(clonedPpt.PresentationPart.Presentation);
            Assert.Single(clonedPpt.PresentationPart.SlideParts);
            var clonedSlidePart = clonedPpt.PresentationPart.SlideParts.First();
            Assert.NotEmpty(clonedSlidePart.DataPartReferenceRelationships);

            // Additional test for related 1issue #949
            // Verify that the id requested in AddDataPartReferenceRelationship was used.
            var mediaDataPart = new MediaDataPart(ppt.InternalOpenXmlPackage, MediaDataPartType.Mp3);
            MediaReferenceRelationship mrr = slidePart.AddMediaReferenceRelationship(mediaDataPart, "rId4");
            Assert.Equal("rId4", mrr.Id);
        }

        // Regression test for issue #1069
        // Opening a PowerPoint presentation with a 3d model graphic will fail if the Model3dReferenceRelationshipPart doesn't
        //     accept both model/gltf-binary *and* model/gltf.binary MIME types. PowerPoint writes the latter.
        [Fact]
        public void TestOpenModel3DWrittenByPowerPoint_DotMime()
        {
            using var testFile = GetStream(TestFiles._3DTestDot, false);

            using var presDoc = PresentationDocument.Open(testFile, false);

            Assert.NotNull(presDoc);
            Assert.NotNull(presDoc.PresentationPart);

            // Check to see that the Model3DReferenceRelationshippart has content type 'model/gltf-binary'
            PresentationPart? presentationPart = presDoc.PresentationPart;
            IEnumerable<SlidePart>? slideParts = presentationPart.GetPartsOfType<SlidePart>();

            Assert.NotNull(slideParts);

            Assert.True(slideParts.Count<SlidePart>() > 0);

            SlidePart? slidePart = slideParts.First();

            IEnumerable<Model3DReferenceRelationshipPart> model3DReferenceRelationshipParts = slidePart.Model3DReferenceRelationshipParts;

            Assert.True(model3DReferenceRelationshipParts.Count<Model3DReferenceRelationshipPart>() > 0);

            Model3DReferenceRelationshipPart model3DReferenceRelationshipPart = model3DReferenceRelationshipParts.First();

            Assert.Equal("model/gltf-binary", model3DReferenceRelationshipPart.ContentType);
        }

        // Also test the acceptance of model/gltf-binary that the SDK writes.
        [Fact]
        public void TestOpenModel3DWrittenByPowerPoint_DashMime()
        {
            using var testFile = GetStream(TestFiles._3DTestDash, false);

            using var presDoc = PresentationDocument.Open(testFile, false);

            Assert.NotNull(presDoc);

            // Check to see that the Model3DReferenceRelationshippart has content type 'model/gltf-binary'
            SlidePart slidePart = presDoc.PresentationPart!.GetPartsOfType<SlidePart>().First();
            IEnumerable<Model3DReferenceRelationshipPart> model3DReferenceRelationshipParts = slidePart.Model3DReferenceRelationshipParts;
            Model3DReferenceRelationshipPart model3DReferenceRelationshipPart = model3DReferenceRelationshipParts.First();

            Assert.Equal("model/gltf-binary", model3DReferenceRelationshipPart.ContentType);
        }

        // When opening a workbook (SpreadsheetDocument.Open) with a missing calcChain part we should throw an exception.
        // Test for https://github.com/OfficeDev/Open-XML-SDK/issues/1281
        [Fact]
        public void ThrowWithMissingCalcChainPart()
        {
            using var stmSpd = GetStream(TestFiles.MissingCalcChainPart, false);
            using var doc = SpreadsheetDocument.Open(stmSpd, false);

            Assert.Throws<InvalidOperationException>(() => doc.LoadAllParts());
        }

        // When opening a workbook (SpreadsheetDocument.Open) with a missing calcChain part and OpenSettings
        // set to ignore, we should succeed the opening.
        // Test for https://github.com/OfficeDev/Open-XML-SDK/issues/1281
        [Fact]
        public void SucceedWithMissingCalcChainPart()
        {
            Stream stmSpd = GetStream(TestFiles.MissingCalcChainPart, false);

            using SpreadsheetDocument spd = SpreadsheetDocument.Open(stmSpd, false);

            spd.IgnoreCalculationChainPartRelationship();

            spd.LoadAllParts();

            Assert.NotNull(spd);
        }

        [Fact]
        public void IsEncryptedOfficeFile_ReturnsTrue_ForEncryptedFile()
        {
            using (Stream stream = GetStream(TestFiles.Encrypted_pptx, false))
            {
                Assert.True(OpenXmlPackage.IsEncryptedOfficeFile(stream));
            }
        }

        [Fact]
        public void IsEncryptedOfficeFile_ReturnsFalse_ForUnencryptedFile()
        {
            using (Stream stream = GetStream(TestFiles.Presentation, false))
            {
                Assert.False(OpenXmlPackage.IsEncryptedOfficeFile(stream));
            }
        }

        [Fact]
        public void IsEncryptedOfficeFile_ThrowsArgumentNullException_ForNullStream()
        {
            Assert.Throws<ArgumentNullException>(() => OpenXmlPackage.IsEncryptedOfficeFile((Stream)null!));
        }

        [Fact]
        public void IsEncryptedOfficeFile_ThrowsArgumentException_ForUnseekableStream()
        {
            var unseekable = new UnseekableStream();
            Assert.Throws<ArgumentException>(() => OpenXmlPackage.IsEncryptedOfficeFile(unseekable));
        }

        private class UnseekableStream : MemoryStream
        {
            public override bool CanSeek => false;
        }

        [Fact]
        public void IsEncryptedOfficeFile_ReturnsTrue_ForEncryptedFilePath()
        {
            string filePath = GetTestFilePath(TestFiles.Encrypted_pptx);
            Assert.True(OpenXmlPackage.IsEncryptedOfficeFile(filePath));

            // Clean up the test file path
            File.Delete(filePath);
        }

        [Fact]
        public void IsEncryptedOfficeFile_ReturnsFalse_ForUnencryptedFile_FromString()
        {
            string filePath = GetTestFilePath(TestFiles.Presentation);
            Assert.False(OpenXmlPackage.IsEncryptedOfficeFile(filePath));

            // Clean up the test file path
            File.Delete(filePath);
        }
    }
}
