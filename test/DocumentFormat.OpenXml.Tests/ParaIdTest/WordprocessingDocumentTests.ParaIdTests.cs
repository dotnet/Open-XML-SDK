// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
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
            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            var body = new Body();

            for (var i = 0; i < count; i++)
            {
                Paragraph paragraph = new();
                string paragraphId = paragraph.SetUniqueParagraphId(wordDocument);
                paragraph.AppendChild(new Run(new Text(paragraphId)));
                body.AppendChild(paragraph);
            }

            part.Document = new Document(body);

            Assert.Equal(count, wordDocument.ParagraphIds.Count);

            return count;
        }

        private static int UpdateTestDocument(Stream stream, int start, int end)
        {
            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            MainDocumentPart part = wordDocument.MainDocumentPart!;
            Body body = part.Document.Body!;

            // The MainDocumentPart's DOM tree must have been loaded by accessing
            // the Document property before determining the number of w14:paraId
            // values currently existing in the scope of the WordprocessingDocument.
            Assert.Equal(start, wordDocument.ParagraphIds.Count);

            for (int i = start; i < end; i++)
            {
                Paragraph paragraph = new();
                string paragraphId = paragraph.SetUniqueParagraphId(wordDocument);
                paragraph.AppendChild(new Run(new Text(paragraphId)));
                body.AppendChild(paragraph);
            }

            Assert.Equal(end, wordDocument.ParagraphIds.Count);

            return end - start;
        }

        private static int AddOtherParts(Stream stream, int count)
        {
            const int firstId = 0;

            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            MainDocumentPart mainDocumentPart = wordDocument.MainDocumentPart!;

            // Add Header.
            var headerParagraph = new Paragraph(new Run(new Text("Header")));
            headerParagraph.SetUniqueParagraphId(wordDocument);

            var headerPart = mainDocumentPart.AddNewPart<HeaderPart>();
            headerPart.Header = new Header(headerParagraph);

            // Add Footer.
            var footerParagraph = new Paragraph(new Run(new Text("Footer")));
            footerParagraph.SetUniqueParagraphId(wordDocument);

            var footerPart = mainDocumentPart.AddNewPart<FooterPart>();
            footerPart.Footer = new Footer(footerParagraph);

            // Add Comments.
            var comments = new Comments();

            for (int id = firstId; id < firstId + count; id++)
            {
                var paragraph = new Paragraph(new Run(new Text($"Comment #{id}")));
                paragraph.SetUniqueParagraphId(wordDocument);

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

            for (int id = firstId; id < firstId + count; id++)
            {
                var paragraph = new Paragraph(new Run(new Text($"Footnote #{id}")));
                paragraph.SetUniqueParagraphId(wordDocument);

                footnotes.AppendChild(new Footnote(paragraph) { Id = id });
            }

            var footnotesPart = mainDocumentPart.AddNewPart<FootnotesPart>();
            footnotesPart.Footnotes = footnotes;

            // Add Endnotes.
            var endnotes = new Endnotes();

            for (int id = firstId; id < firstId + count; id++)
            {
                var paragraph = new Paragraph(new Run(new Text($"Endnote #{id}")));
                paragraph.SetUniqueParagraphId(wordDocument);

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
            int total = CreateTestDocument(stream, count);

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
            Assert.Equal(total, wordDocument.ParagraphIds.Count);
            Assert.Empty(wordDocument.DuplicateParagraphIds);
        }

        [Fact]
        public void CanLoadParagraphIds()
        {
            using var stream = new MemoryStream();
            int count = CreateTestDocument(stream, 10000);
            count += AddOtherParts(stream, 1000);

            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            var paragraphIds = wordDocument.GetAllParagraphIds();

            Assert.Equal(count, paragraphIds.Count);
        }
    }
}
