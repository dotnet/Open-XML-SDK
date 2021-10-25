// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Features
{
    public class SharedParagraphIdGeneratorTests
    {
        [Fact]
        public void SingleSharedDocument()
        {
            using var ms = new MemoryStream();
            using var doc = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document);

            doc.AddSharedParagraphIdFeature();

            var part = doc.AddMainDocumentPart();
            var body = new Body();
            part.Document = new Document(body);

            var p = new Paragraph();

            Assert.Null(p.ParagraphId);
            body.AddChild(p);
            Assert.NotNull(p.ParagraphId);
        }

        [Fact]
        public void DoubleSharedDocument()
        {
            using var ms1 = new MemoryStream();
            using var doc1 = WordprocessingDocument.Create(ms1, WordprocessingDocumentType.Document);

            using var ms2 = new MemoryStream();
            using var doc2 = WordprocessingDocument.Create(ms2, WordprocessingDocumentType.Document);

            var shared = doc1.AddSharedParagraphIdFeature()
                .Add(doc2);

            // Add item to doc1
            var part1 = doc1.AddMainDocumentPart();
            var body1 = new Body();
            var p1 = new Paragraph();
            part1.Document = new Document(body1);
            body1.AddChild(p1);

            // Add item with same ID to doc2
            var part2 = doc2.AddMainDocumentPart();
            var body2 = new Body();
            var p2 = new Paragraph { ParagraphId = p1.ParagraphId };
            part2.Document = new Document(body2);
            body2.AddChild(p2);

            // Assert
            Assert.NotEqual(p1.ParagraphId, p2.ParagraphId);
            Assert.Equal(2, shared.Count);
        }

        [Fact]
        public void DoubleSharedDocumentAfterDisposal()
        {
            using var ms2 = new MemoryStream();
            using var doc2 = WordprocessingDocument.Create(ms2, WordprocessingDocumentType.Document);

            var shared = doc2.AddSharedParagraphIdFeature();
            var previousValue = default(HexBinaryValue);

            using (var ms1 = new MemoryStream())
            using (var doc1 = WordprocessingDocument.Create(ms1, WordprocessingDocumentType.Document))
            {
                shared.Add(doc1);

                // Add item to doc1
                var part1 = doc1.AddMainDocumentPart();
                var body1 = new Body();
                var p1 = new Paragraph();
                part1.Document = new Document(body1);
                body1.AddChild(p1);

                previousValue = p1.ParagraphId;
            }

            // Add item with same ID to doc2
            var part2 = doc2.AddMainDocumentPart();
            var body2 = new Body();
            var p2 = new Paragraph { ParagraphId = previousValue };
            part2.Document = new Document(body2);
            body2.AddChild(p2);

            // Assert
            Assert.NotNull(previousValue);
            Assert.NotEqual(previousValue, p2.ParagraphId);
            Assert.Equal(2, shared.Count);
        }
    }
}
