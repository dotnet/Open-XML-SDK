// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

#nullable enable

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class RandomParagraphIdGeneratorTests
    {
        public RandomParagraphIdGeneratorTests()
        {
            Generator = new RandomParagraphIdGenerator();
        }

        private IParagraphIdGenerator Generator { get; }

        private static int CreateTestDocument(Stream stream, int count)
        {
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            var paraIdGenerator = new RandomParagraphIdGenerator();
            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            var body = new Body();

            for (var i = 0; i < count; i++)
            {
                Paragraph paragraph = new()
                {
                    ParagraphId = paraIdGenerator.CreateUniqueParagraphId(),
                };

                paragraph.AppendChild(new Run(new Text(paragraph.ParagraphId.Value!)));
                body.AppendChild(paragraph);
            }

            part.Document = new Document(body);

            Assert.Equal(count, paraIdGenerator.RegisteredParagraphIds.Count());

            return count;
        }

        private static int UpdateTestDocument(Stream stream, int start, int end)
        {
            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            var paraIdGenerator = new RandomParagraphIdGenerator(wordDocument);
            MainDocumentPart part = wordDocument.MainDocumentPart!;
            Body body = part.Document.Body!;

            // The MainDocumentPart's DOM tree must have been loaded by accessing
            // the Document property before determining the number of w14:paraId
            // values currently existing in the scope of the WordprocessingDocument.
            Assert.Equal(start, paraIdGenerator.RegisteredParagraphIds.Count());

            for (var i = start; i < end; i++)
            {
                Paragraph paragraph = new()
                {
                    ParagraphId = paraIdGenerator.CreateUniqueParagraphId(),
                };

                paragraph.AppendChild(new Run(new Text(paragraph.ParagraphId.Value!)));
                body.AppendChild(paragraph);
            }

            Assert.Equal(end, paraIdGenerator.RegisteredParagraphIds.Count());

            return end - start;
        }

        private static int AddOtherParts(Stream stream, int count)
        {
            const int firstId = 0;

            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            var paraIdGenerator = new RandomParagraphIdGenerator(wordDocument);
            MainDocumentPart mainDocumentPart = wordDocument.MainDocumentPart!;

            // Add Header.
            var headerParagraph = new Paragraph(new Run(new Text("Header")))
            {
                ParagraphId = paraIdGenerator.CreateUniqueParagraphId(),
            };

            var headerPart = mainDocumentPart.AddNewPart<HeaderPart>();
            headerPart.Header = new Header(headerParagraph);

            // Add Footer.
            var footerParagraph = new Paragraph(new Run(new Text("Footer")))
            {
                ParagraphId = paraIdGenerator.CreateUniqueParagraphId(),
            };

            var footerPart = mainDocumentPart.AddNewPart<FooterPart>();
            footerPart.Footer = new Footer(footerParagraph);

            // Add Comments.
            var comments = new Comments();

            for (var id = firstId; id < firstId + count; id++)
            {
                var paragraph = new Paragraph(new Run(new Text($"Comment #{id}")))
                {
                    ParagraphId = paraIdGenerator.CreateUniqueParagraphId(),
                };

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
                var paragraph = new Paragraph(new Run(new Text($"Footnote #{id}")))
                {
                    ParagraphId = paraIdGenerator.CreateUniqueParagraphId(),
                };

                footnotes.AppendChild(new Footnote(paragraph) { Id = id });
            }

            var footnotesPart = mainDocumentPart.AddNewPart<FootnotesPart>();
            footnotesPart.Footnotes = footnotes;

            // Add Endnotes.
            var endnotes = new Endnotes();

            for (var id = firstId; id < firstId + count; id++)
            {
                var paragraph = new Paragraph(new Run(new Text($"Endnote #{id}")))
                {
                    ParagraphId = paraIdGenerator.CreateUniqueParagraphId(),
                };

                endnotes.AppendChild(new Endnote(paragraph) { Id = id });
            }

            var endnotesPart = mainDocumentPart.AddNewPart<EndnotesPart>();
            endnotesPart.Endnotes = endnotes;

            return 3 * count + 2;
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
                string paragraphId = HexStringFactory.Create(0x00, 0x00, 0x00, (byte) (i % divisor));
                body.AppendChild(new Paragraph(new Run(new Text(paragraphId))) { ParagraphId = paragraphId });
            }

            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            var part = wordDocument.AddMainDocumentPart();
            part.Document = new Document(body);

            IParagraphIdGenerator paraIdGenerator = new RandomParagraphIdGenerator(wordDocument);
            Assert.Equal(divisor, paraIdGenerator.RegisteredParagraphIds.Count());

            // Act.
            // Assign unique w14:paraId values.
            paraIdGenerator.AssignUniqueParagraphIds(wordDocument);

            // Assert.
            // We have as many registered w14:paraId values as we have w:p elements.
            Assert.Equal(count, paraIdGenerator.RegisteredParagraphIds.Count());

            // When checked independently, the number of w14:paraId values matches.
            var newParaIds = new HashSet<string>(body.Elements<Paragraph>().Select(p => p.ParagraphId!.Value!));
            Assert.Equal(count, newParaIds.Count);

            // The first 100 w:p elements did not have their w14:paraId value changed.
            Assert.All(body.Elements<Paragraph>().Take(divisor), p => Assert.Equal(p.InnerText, p.ParagraphId!.InnerText));

            // The following 900 w:p elements did have their w14:paraId values changed.
            Assert.All(body.Elements<Paragraph>().Skip(divisor), p => Assert.NotEqual(p.InnerText, p.ParagraphId!.InnerText));
        }

        [Fact]
        public void Constructor_Default_NoParagraphIdsRegistered()
        {
            var generator = new RandomParagraphIdGenerator();

            Assert.Empty(generator.RegisteredParagraphIds);
        }

        [Fact]
        public void Constructor_IEnumerable_NonEmptyCollection_ParaIdsRegistered()
        {
            var paraId = Generator.CreateUniqueParagraphId();

            var generator = new RandomParagraphIdGenerator(Generator.RegisteredParagraphIds);

            Assert.Contains(paraId, generator.RegisteredParagraphIds);
        }

        [Fact]
        public void Constructor_IEnumerable_UpperAndLowerCase_SingleParaIdRegistered()
        {
            const string paraId = "789ABCDE";
            var paraIds = new[] { paraId, paraId.ToLowerInvariant() };

            var generator = new RandomParagraphIdGenerator(paraIds);

            Assert.Equal(paraId, generator.RegisteredParagraphIds.Single());
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

            // Act, creating a new generator.
            var generator = new RandomParagraphIdGenerator(wordDocument);

            // Assert that we have the expected number of registered w14:paraId values.
            Assert.Equal(total, generator.RegisteredParagraphIds.Count());
        }

        [Fact]
        public void Constructor_WordprocessingDocument_Duplicates_Success()
        {
            // Arrange.
            const string paraId = "789ABCDE";
            var paraIds = new[] { paraId, paraId.ToLowerInvariant() };

            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            var part = wordDocument.AddMainDocumentPart();
            part.Document = new Document(new Body(paraIds.Select(id => new Paragraph { ParagraphId = id })));

            // Act.
            var generator = new RandomParagraphIdGenerator(wordDocument);

            // Assert.
            Assert.Equal(paraId, generator.RegisteredParagraphIds.Single());
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
            var paraIdGenerator = new RandomParagraphIdGenerator(wordDocument);
            Body body = wordDocument.MainDocumentPart!.Document!.Body!;

            Assert.Equal(total, body.Elements<Paragraph>().Count());
            Assert.Equal(total, paraIdGenerator.RegisteredParagraphIds.Count());
        }

        [Fact]
        public void CreateUniqueParagraphId_ManyValuesCreated_AllGeneratedValuesAreValidAndUnique()
        {
            const int count = 10000;

            for (var i = 0; i < count; i++)
            {
                string paraId = Generator.CreateUniqueParagraphId();
                var hexBinaryValue = new HexBinaryValue(paraId);
                var value = Convert.ToUInt32(paraId, 16);

                // Assert that the HexBinaryValue is deemed valid. Note, however, that
                // the rules for w14:paraId (ParagraphId) values are stricter and the
                // convention seems to be all uppercase letters.
                Assert.True(hexBinaryValue.IsValid);

                // Assert that the value is both greater than 0x00000000 and less than
                // 0x80000000 as specified in MS-DOCX, section 2.6.2.3.
                Assert.True(value > 0x00000000);
                Assert.True(value < 0x80000000);

                // Assert that the value is all uppercase, as produced by Microsoft Word.
                Assert.Equal(paraId.ToUpperInvariant(), paraId);
            }

            Assert.Equal(count, Generator.RegisteredParagraphIds.Count());
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

            // Act, registering all paragraphIds.
            Generator.RegisterAllParagraphIds(wordDocument);

            // Assert that all w14:paraId values have been registered.
            Assert.Equal(total, Generator.RegisteredParagraphIds.Count());
        }
    }
}
