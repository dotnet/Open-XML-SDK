// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.Linq;
using Xunit;

#nullable enable

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class ParagraphTests
    {
        private static WordprocessingDocument CreateTestDocument()
        {
            var wordDocument = WordprocessingDocument.Create(new MemoryStream(), WordprocessingDocumentType.Document);
            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            part.Document =
                new Document(
                    new Body(
                        new Paragraph(new Run(new Text("Hello World!"))),
                        new Paragraph(new Run(new Text("What a Wonderful World")))));

            return wordDocument;
        }

        [Fact]
        public void ParagraphId_AssociatedWithWordprocessingDocument_ParagraphIdAndDupliateRegistered()
        {
            // Arrange.
            const string hexString = "12345678";

            WordprocessingDocument wordDocument = CreateTestDocument();
            MainDocumentPart part = wordDocument.MainDocumentPart!;
            Body body = part.Document.Body!;
            Paragraph firstParagraph = body.Elements<Paragraph>().ElementAt(0);
            Paragraph secondParagraph = body.Elements<Paragraph>().ElementAt(1);

            Assert.Null(firstParagraph.ParagraphId);
            Assert.Null(secondParagraph.ParagraphId);

            // Act, setting duplicate w14:paraId values.
            firstParagraph.ParagraphId = new HexBinaryValue(hexString);
            secondParagraph.ParagraphId = new HexBinaryValue(hexString);

            // Assert.
            Assert.NotNull(firstParagraph.ParagraphId?.Value);
            Assert.NotNull(secondParagraph.ParagraphId?.Value);
            Assert.Equal(firstParagraph.ParagraphId, secondParagraph.ParagraphId);

            Assert.Contains(hexString, wordDocument.ParagraphIds);
            Assert.Contains(hexString, wordDocument.DuplicateParagraphIds);
        }

        [Fact]
        public void ParagraphId_NotAssociatedWithWordprocessingDocument_ParagraphIdAndDuplicateNotRegistered()
        {
            // Arrange.
            const string hexString = "12345678";

            var firstParagraph = new Paragraph(new Run(new Text("Hello World!")));
            var secondParagraph = new Paragraph(new Run(new Text("What a Wonderful World")));

            // Act.
            // Set duplicate w14:paraId values while paragraphs are not associated with a WordprocessingDocument.
            firstParagraph.ParagraphId = new HexBinaryValue(hexString);
            secondParagraph.ParagraphId = new HexBinaryValue(hexString);

            // Create a WordprocessingDocument and add the paragraphs to the MainDocumentPart.
            var wordDocument = WordprocessingDocument.Create(new MemoryStream(), WordprocessingDocumentType.Document);
            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            part.Document = new Document(new Body(firstParagraph, secondParagraph));

            // Assert.
            // Note that we have identical w14:paraId values.
            Assert.NotNull(firstParagraph.ParagraphId?.Value);
            Assert.NotNull(secondParagraph.ParagraphId?.Value);
            Assert.Equal(firstParagraph.ParagraphId, secondParagraph.ParagraphId);

            // Note that the ParagraphIdService does not know about those w14:paraId values.
            Assert.Empty(wordDocument.ParagraphIds);
            Assert.Empty(wordDocument.DuplicateParagraphIds);
        }

        [Fact]
        public void SetUniqueParagraphId_AssociatedWithWordprocessingDocument_Success()
        {
            WordprocessingDocument wordDocument = CreateTestDocument();
            MainDocumentPart part = wordDocument.MainDocumentPart!;
            Paragraph paragraph = part!.Document.Descendants<Paragraph>().First();
            Assert.Null(paragraph.ParagraphId);

            string paragraphId = paragraph.SetUniqueParagraphId();

            Assert.NotNull(paragraph.ParagraphId?.Value);
            Assert.Equal(paragraphId, paragraph.ParagraphId!.Value);
        }

        [Fact]
        public void SetUniqueParagraphId_NotAssociatedWithWordprocessingDocument_IParagraphIdService_Success()
        {
            var paragraphIdService = new RandomParagraphIdService();
            var run = new Run(new Text("Hello World!"));

            Paragraph paragraph = new(run);
            string paragraphId = paragraph.SetUniqueParagraphId(paragraphIdService);

            Assert.NotNull(paragraph.ParagraphId?.Value);
            Assert.Equal(paragraphId, paragraph.ParagraphId?.Value);
        }

        [Fact]
        public void SetUniqueParagraphId_NotAssociatedWithWordprocessingDocument_NoParameter_InvalidOperationExceptionThrown()
        {
            var paragraph = new Paragraph();

            Assert.Throws<InvalidOperationException>(() => paragraph.SetUniqueParagraphId());
        }

        [Fact]
        public void SetUniqueParagraphId_NotAssociatedWithWordprocessingDocument_WordprocessingDocument_Success()
        {
            using var wordDocument = WordprocessingDocument.Create(new MemoryStream(), WordprocessingDocumentType.Document);
            var run = new Run(new Text("Hello World!"));

            Paragraph paragraph = new(run);
            string paragraphId = paragraph.SetUniqueParagraphId(wordDocument);

            Assert.NotNull(paragraph.ParagraphId?.Value);
            Assert.Equal(paragraphId, paragraph.ParagraphId!.Value);
        }
    }
}
