// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Features
{
    public class RandomParagraphIdGeneratorTests
    {
        private static int CreateTestDocument(Stream stream, int count)
        {
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            wordDocument.AddParagraphIdFeature();

            var paraIdCollection = wordDocument.Features.GetRequired<IParagraphIdCollectionFeature>();

            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            var body = new Body();
            part.Document = new Document(body);

            for (var i = 0; i < count; i++)
            {
                Paragraph paragraph = new();

                body.AppendChild(paragraph);
                paragraph.AppendChild(new Run(new Text(paragraph.ParagraphId!.Value!)));
            }

            Assert.Equal(count, paraIdCollection.Count);

            return count;
        }

        private static int UpdateTestDocument(Stream stream, int start, int end)
        {
            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            wordDocument.AddParagraphIdFeature();

            var paraIdCollection = wordDocument.Features.GetRequired<IParagraphIdCollectionFeature>();

            MainDocumentPart part = wordDocument.MainDocumentPart!;
            Body body = part.Document.Body!;

            // The MainDocumentPart's DOM tree must have been loaded by accessing
            // the Document property before determining the number of w14:paraId
            // values currently existing in the scope of the WordprocessingDocument.
            Assert.Equal(start, paraIdCollection.Count);

            for (var i = start; i < end; i++)
            {
                var paragraph = body.AppendChild(new Paragraph());
                paragraph.AppendChild(new Run(new Text(paragraph.ParagraphId!.Value!)));
            }

            Assert.Equal(end, paraIdCollection.Count);

            return end - start;
        }

        private static int AddOtherParts(Stream stream, int count)
        {
            const int firstId = 0;

            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            wordDocument.AddParagraphIdFeature();

            MainDocumentPart mainDocumentPart = wordDocument.MainDocumentPart!;

            // Add Header.
            var headerParagraph = new Paragraph(new Run(new Text("Header")));

            var headerPart = mainDocumentPart.AddNewPart<HeaderPart>();
            headerPart.Header = new Header(headerParagraph);

            // Add Footer.
            var footerParagraph = new Paragraph(new Run(new Text("Footer")));

            var footerPart = mainDocumentPart.AddNewPart<FooterPart>();
            footerPart.Footer = new Footer(footerParagraph);

            // Add Comments.
            var comments = new Comments();

            for (var id = firstId; id < firstId + count; id++)
            {
                var paragraph = new Paragraph(new Run(new Text($"Comment #{id}")));

                comments.AppendChild(new Comment(paragraph)
                {
                    Id = id.ToString(),
                    Author = $"Author #{id}",
                });
            }

            var commentsPart = mainDocumentPart.AddNewPart<WordprocessingCommentsPart>();
            commentsPart.Comments = comments;

            // Add Footnotes
            var footnotes = new Footnotes();

            for (var id = firstId; id < firstId + count; id++)
            {
                var paragraph = new Paragraph(new Run(new Text($"Footnote #{id}")));

                footnotes.AppendChild(new Footnote(paragraph) { Id = id });
            }

            var footnotesPart = mainDocumentPart.AddNewPart<FootnotesPart>();
            footnotesPart.Footnotes = footnotes;

            // Add Endnotes.
            var endnotes = new Endnotes();

            for (var id = firstId; id < firstId + count; id++)
            {
                var paragraph = new Paragraph(new Run(new Text($"Endnote #{id}")));

                endnotes.AppendChild(new Endnote(paragraph) { Id = id });
            }

            var endnotesPart = mainDocumentPart.AddNewPart<EndnotesPart>();
            endnotesPart.Endnotes = endnotes;

            return (3 * count) + 2;
        }

        [Fact]
        public void AssignUniqueParagraphIds_WordDocumentWithNonUniqueIds_AllParaIdsUnique()
        {
            // Arrange.
            // Construct a document with 100 different w14:paraId values and many duplicates.
            const int count = 1000;
            const int divisor = 100;
            var body = new Body();

            for (var i = 0; i < count; i++)
            {
                string paragraphId = HexStringFactory.Create(0x00, 0x00, 0x00, (byte)(i % divisor))!;
                body.AppendChild(new Paragraph(new Run(new Text(paragraphId))) { ParagraphId = paragraphId });
            }

            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            wordDocument.AddParagraphIdFeature();
            var paraIdCollection = wordDocument.Features.GetRequired<IParagraphIdCollectionFeature>();

            var part = wordDocument.AddMainDocumentPart();
            part.Document = new Document(body);

            // Assert.
            // We have as many registered w14:paraId values as we have w:p elements.
            Assert.Equal(count, paraIdCollection.Count);

            // When checked independently, the number of w14:paraId values matches.
            var newParaIds = new HashSet<string>(body.Elements<Paragraph>().Select(p => p.ParagraphId!.Value!));
            Assert.Equal(count, newParaIds.Count);

            // The first 100 w:p elements did not have their w14:paraId value changed.
            Assert.All(body.Elements<Paragraph>().Take(divisor), p => Assert.Equal(p.InnerText, p.ParagraphId!.InnerText));

            // The following 900 w:p elements did have their w14:paraId values changed.
            Assert.All(body.Elements<Paragraph>().Skip(divisor), p => Assert.NotEqual(p.InnerText, p.ParagraphId!.InnerText));
        }

        [Fact]
        public void Constructor_WordprocessingDocument_ExistingParaIds_ParaIdsRegistered()
        {
            // Arrange, creating a new WordprocessingDocument.
            const int count = 100;
            using var stream = new MemoryStream();
            var total = CreateTestDocument(stream, count);
            total += AddOtherParts(stream, count);

            using var wordDocument = WordprocessingDocument.Open(stream, true);
            wordDocument.AddParagraphIdFeature();
            var collection = wordDocument.Features.GetRequired<IParagraphIdCollectionFeature>();

            // Assert that we have the expected number of registered w14:paraId values.
            Assert.Equal(total, collection.Count);
        }

        [Fact]
        public void CreateUniqueParagraphId_IterativelyUpdatedWordDocument_AllParaIdsUnique()
        {
            const int iterations = 3;
            const int count = 10000;

            // Create new document in first iteration.
            using var stream = new MemoryStream();
            var total = CreateTestDocument(stream, count);

            for (var i = 1; i < iterations; i++)
            {
                // Update document in second and following iterations.
                total += UpdateTestDocument(stream, i * count, (i + 1) * count);
            }

            // Assert that we have the expected total number of w14:paraId values
            // and no duplicates.
            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            wordDocument.AddParagraphIdFeature();
            var paraIdCollection = wordDocument.Features.GetRequired<IParagraphIdCollectionFeature>();

            Body body = wordDocument.MainDocumentPart!.Document!.Body!;

            Assert.Equal(total, body.Elements<Paragraph>().Count());
            Assert.Equal(total, paraIdCollection.Count);
        }

        [Fact]
        public void RegisterAllParagraphIds_WordDocumentWithMultipleParts_AllParagraphIdsRegistered()
        {
            // Arrange, creating a new WordprocessingDocument.
            const int count = 100;
            using var stream = new MemoryStream();
            var total = CreateTestDocument(stream, count);
            total += AddOtherParts(stream, count);

            using var wordDocument = WordprocessingDocument.Open(stream, true);
            wordDocument.AddParagraphIdFeature();
            var paraIdCollection = wordDocument.Features.GetRequired<IParagraphIdCollectionFeature>();

            // Assert that all w14:paraId values have been registered.
            Assert.Equal(total, paraIdCollection.Count);
        }
    }
}
