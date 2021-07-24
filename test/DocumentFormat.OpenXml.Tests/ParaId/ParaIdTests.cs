// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

#nullable enable

namespace DocumentFormat.OpenXml.Tests
{
    public class ParaIdTests
    {
        public ParaIdTests(ITestOutputHelper output)
        {
            Output = output;
        }

        private ITestOutputHelper Output { get; }

        private int CreateTestDocument(Stream stream, int start, int end)
        {
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            MainDocumentPart part = wordDocument.AddMainDocumentPart();

            var body = new Body();
            var document = new Document(body);

            for (int i = start; i < end; i++)
            {
                // Use WithUniqueParagraphId(document) to create random and unique w14:paraId.
                Paragraph paragraph = new Paragraph().WithUniqueParagraphId(document);

                var run = new Run(new Text(paragraph.ParagraphId!.InnerText!));
                paragraph.AppendChild(run);

                body.AppendChild(paragraph);
            }

            part.Document = document;

            return document.PreventedParagraphIdCollisions;
        }

        private int UpdateTestDocument(Stream stream, int start, int end)
        {
            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            MainDocumentPart part = wordDocument.MainDocumentPart!;

            Document document = part.Document;
            Body body = document.Body!;

            for (int i = start; i < end; i++)
            {
                // Use WithUniqueParagraphId(document) to create random and unique w14:paraId.
                Paragraph paragraph = new Paragraph().WithUniqueParagraphId(document);

                var run = new Run(new Text(paragraph.ParagraphId!.InnerText!));
                paragraph.AppendChild(run);

                body.AppendChild(paragraph);
            }

            return document.PreventedParagraphIdCollisions;
        }

        [Fact]
        public void PerformTest()
        {
            const int iterations = 10;
            const int count = 10000;

            Output.WriteLine($"Performing {iterations} iterations with {count} paragraphs each ...");

            using var stream = new MemoryStream();

            int preventedCollisions = CreateTestDocument(stream, 0, count);
            Output.WriteLine($"Iteration 0: Prevented {preventedCollisions} collisions in total up to now.");

            for (var i = 1; i < iterations; i++)
            {
                preventedCollisions += UpdateTestDocument(stream, i * count, (i + 1) * count);
                Output.WriteLine($"Iteration {i}: Prevented {preventedCollisions} collisions in total up to now.");
            }

            Output.WriteLine($"Prevented {preventedCollisions} collisions in total.");

            using WordprocessingDocument wordDocument = WordprocessingDocument.Open(stream, true);
            Body body = wordDocument.MainDocumentPart!.Document!.Body!;
            List<string> paragraphIds = body.Elements<Paragraph>().Select(p => p.ParagraphId!.InnerText!).ToList();
            var uniqueParagraphIds = new HashSet<string>(paragraphIds);

            Output.WriteLine($"Have {uniqueParagraphIds.Count} different w14:paraId values.");

            Assert.Equal(iterations * count, paragraphIds.Count);
            Assert.Equal(iterations * count, uniqueParagraphIds.Count);
        }
    }
}
