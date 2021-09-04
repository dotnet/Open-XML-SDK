// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

#nullable enable

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class WordprocessingDocumentTests
    {
        private static int CreateTestDocument(Stream stream, int count)
        {
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            var paragraphIdGenerator = wordDocument.ParagraphIdGenerator;
            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            var body = new Body();

            for (var i = 0; i < count; i++)
            {
                Paragraph paragraph = new();
                string paragraphId = paragraph.SetUniqueParagraphId(paragraphIdGenerator);
                paragraph.AppendChild(new Run(new Text(paragraphId)));
                body.AppendChild(paragraph);
            }

            part.Document = new Document(body);

            Assert.Equal(count, wordDocument.RegisteredParagraphIds.Count());

            return count;
        }

        private static int UpdateTestDocument(Stream stream, int start, int end)
        {
            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            var paragraphIdGenerator = wordDocument.ParagraphIdGenerator;
            MainDocumentPart part = wordDocument.MainDocumentPart!;
            Body body = part.Document.Body!;

            // The MainDocumentPart's DOM tree must have been loaded by accessing
            // the Document property before determining the number of w14:paraId
            // values currently existing in the scope of the WordprocessingDocument.
            Assert.Equal(start, wordDocument.RegisteredParagraphIds.Count());

            for (var i = start; i < end; i++)
            {
                Paragraph paragraph = new();
                string paragraphId = paragraph.SetUniqueParagraphId(paragraphIdGenerator);
                paragraph.AppendChild(new Run(new Text(paragraphId)));
                body.AppendChild(paragraph);
            }

            Assert.Equal(end, wordDocument.RegisteredParagraphIds.Count());

            return end - start;
        }

        private static int AddOtherParts(Stream stream, int count)
        {
            const int firstId = 0;

            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            var paragraphIdGenerator = wordDocument.ParagraphIdGenerator;
            MainDocumentPart mainDocumentPart = wordDocument.MainDocumentPart!;

            // Add Header.
            var headerParagraph = new Paragraph(new Run(new Text("Header")));
            headerParagraph.SetUniqueParagraphId(paragraphIdGenerator);

            var headerPart = mainDocumentPart.AddNewPart<HeaderPart>();
            headerPart.Header = new Header(headerParagraph);

            // Add Footer.
            var footerParagraph = new Paragraph(new Run(new Text("Footer")));
            footerParagraph.SetUniqueParagraphId(paragraphIdGenerator);

            var footerPart = mainDocumentPart.AddNewPart<FooterPart>();
            footerPart.Footer = new Footer(footerParagraph);

            // Add Comments.
            var comments = new Comments();

            for (var id = firstId; id < firstId + count; id++)
            {
                var paragraph = new Paragraph(new Run(new Text($"Comment #{id}")));
                paragraph.SetUniqueParagraphId(paragraphIdGenerator);

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
                paragraph.SetUniqueParagraphId(paragraphIdGenerator);

                footnotes.AppendChild(new Footnote(paragraph) { Id = id });
            }

            var footnotesPart = mainDocumentPart.AddNewPart<FootnotesPart>();
            footnotesPart.Footnotes = footnotes;

            // Add Endnotes.
            var endnotes = new Endnotes();

            for (var id = firstId; id < firstId + count; id++)
            {
                var paragraph = new Paragraph(new Run(new Text($"Endnote #{id}")));
                paragraph.SetUniqueParagraphId(paragraphIdGenerator);

                endnotes.AppendChild(new Endnote(paragraph) { Id = id });
            }

            var endnotesPart = mainDocumentPart.AddNewPart<EndnotesPart>();
            endnotesPart.Endnotes = endnotes;

            return 3 * count + 2;
        }

        [Fact]
        public void CanCreateAndIterativelyUpdateDocumentWhileEnsuringParagraphIdsAreUnique()
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

            // Assert that we have the expected total number of w14:paraId values.
            // and no duplicates.
            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            Body body = wordDocument.MainDocumentPart!.Document!.Body!;

            Assert.Equal(total, body.Elements<Paragraph>().Count());
            Assert.Equal(total, wordDocument.RegisteredParagraphIds.Count());
        }

        [Fact]
        public void CanRegisterAllParagraphIds()
        {
            // Arrange.
            using var stream = new MemoryStream();
            var count = CreateTestDocument(stream, 10000);
            count += AddOtherParts(stream, 1000);

            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            Assert.Empty(wordDocument.RegisteredParagraphIds);

            // Act.
            IEnumerable<string> paragraphIds = wordDocument.RegisterAllParagraphIds();

            // Assert.
            Assert.Equal(count, wordDocument.RegisteredParagraphIds.Count());
            Assert.Equal(wordDocument.RegisteredParagraphIds, paragraphIds);
        }

        [Fact]
        public void CanAssignUniqueParagraphIds()
        {
            // Arrange.
            // Construct a document with 100 different w14:paraId values and many duplicates.
            const int count = 1000;
            const int divisor = 100;
            var body = new Body();

            for (var i = 0; i < count; i++)
            {
                string paragraphId = HexStringFactory.Create(0x00, 0x00, 0x00, (byte) (i % divisor));
                body.AppendChild(new Paragraph(new Run(new Text(paragraphId))) { ParagraphId = paragraphId });
            }

            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            part.Document = new Document(body);

            IEnumerable<string> paragraphIds = wordDocument.RegisterAllParagraphIds();

            Assert.Equal(divisor, paragraphIds.Count());

            // Act.
            // Assign unique w14:paraId values.
            wordDocument.AssignUniqueParagraphIds();

            // Assert.
            // We have as many registered w14:paraId values as we have w:p elements.
            Assert.Equal(count, wordDocument.RegisteredParagraphIds.Count());

            // When checked independently, the number of w14:paraId values matches.
            var newParaIds = new HashSet<string>(body.Elements<Paragraph>().Select(p => p.ParagraphId!.Value!));
            Assert.Equal(count, newParaIds.Count);

            // The first 100 w:p elements did not have their w14:paraId value changed.
            Assert.All(body.Elements<Paragraph>().Take(divisor), p => Assert.Equal(p.InnerText, p.ParagraphId!.InnerText));

            // The following 900 w:p elements did have their w14:paraId values changed.
            Assert.All(body.Elements<Paragraph>().Skip(divisor), p => Assert.NotEqual(p.InnerText, p.ParagraphId!.InnerText));
        }

        [Fact]
        public void CanReassignParagraphIdsToParagraphIdHolders()
        {
            // Create a test document with some paragraphs and establish the uniqueness
            // of the w14:paraId values.
            using var stream = new MemoryStream();
            var count = CreateTestDocument(stream, 1000);

            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            List<string> paragraphIds = wordDocument.RegisterAllParagraphIds().ToList();

            Assert.Equal(count, wordDocument.RegisteredParagraphIds.Count());
            Assert.Equal(wordDocument.RegisteredParagraphIds, paragraphIds);

            // Create a new w14:paraId service and assign new w14:paraId values to the
            // w14:paraId holders (i.e., w:p and w:tr elements).
            // This might be relevant when copying w:p or w:tr elements over to another
            // main document part, for example.
            var newParagraphIdService = new RandomParagraphIdGenerator(paragraphIds);

            Document document = wordDocument.MainDocumentPart!.Document!;
            IEnumerable<IParagraphIdHolder> paraIdHolders = document.Descendants().OfType<IParagraphIdHolder>();

            foreach (var paraIdHolder in paraIdHolders)
            {
                var value = paraIdHolder.ParagraphId?.Value;

                Assert.NotNull(value);
                Assert.Contains(value!, newParagraphIdService.RegisteredParagraphIds);

                string newValue = paraIdHolder.SetUniqueParagraphId(newParagraphIdService);

                Assert.DoesNotContain(newValue, wordDocument.RegisteredParagraphIds);
            }

            // At this point, the new w14:paraId service has registered both the old and
            // new w14:paraId values.
            Assert.Equal(2 * count, newParagraphIdService.RegisteredParagraphIds.Count());
        }
    }
}
