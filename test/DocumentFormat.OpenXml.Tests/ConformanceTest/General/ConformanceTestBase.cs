// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests
{
    public abstract class ConformanceTestBase<TGeneratedCode, TPackage, TElement> : OpenXmlTestBase
        where TElement : OpenXmlElement
        where TPackage : OpenXmlPackage
        where TGeneratedCode : IGeneratedDocument, new()
    {
        public ConformanceTestBase(ITestOutputHelper output)
            : base(output)
        {
        }

        protected delegate void ElementHandler(TElement element);

        protected void SimpleReadWriteTest(ElementHandler preTest, ElementHandler update, ElementHandler postTest)
        {
            using (var stream = new MemoryStream())
            {
                var generator = new TGeneratedCode();
                generator.CreatePackage(stream);

                using (var package = OpenDocument(stream, true))
                {
                    var elements = GetElements(package);

                    preTest(elements.First());
                    update(elements.First());
                }

                using (var package = OpenDocument(stream, false))
                {
                    var elements = GetElements(package);

                    postTest(elements.First());
                }
            }
        }

        /// <summary>
        /// Opens an existing document
        /// </summary>
        /// <param name="path">file path to open</param>
        /// <param name="enableEdit">open the file in writable mode</param>
        /// <returns>document package</returns>
        protected OpenXmlPackage OpenDocument(Stream stream, bool enableEdit)
        {
            OpenSettings settings = new OpenSettings()
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(
                        MarkupCompatibilityProcessMode.ProcessAllParts,
                        DocumentFormat.OpenXml.FileFormatVersions.Office2013),
            };

            if (typeof(TPackage) == typeof(WordprocessingDocument))
            {
                return WordprocessingDocument.Open(stream, enableEdit, settings);
            }
            else if (typeof(TPackage) == typeof(PresentationDocument))
            {
                return PresentationDocument.Open(stream, enableEdit, settings);
            }
            else if (typeof(TPackage) == typeof(SpreadsheetDocument))
            {
                return SpreadsheetDocument.Open(stream, enableEdit, settings);
            }

            throw new ArgumentOutOfRangeException(nameof(TPackage));
        }

        /// <summary>
        /// Obtains elements in a document package
        /// </summary>
        /// <typeparam name="TElement">Element type</typeparam>
        /// <param name="package">Target document</param>
        /// <returns>Found elements</returns>
        protected IEnumerable<TElement> GetElements(OpenXmlPackage package)
        {
            List<TElement> elements = new List<TElement>();

            WordprocessingDocument wordprocessing = package as WordprocessingDocument;
            PresentationDocument presentation = package as PresentationDocument;
            SpreadsheetDocument spreadsheet = package as SpreadsheetDocument;

            if (wordprocessing != null)
            {
                elements.AddRange(wordprocessing.MainDocumentPart.Document.Descendants<TElement>());
            }
            else if (presentation != null)
            {
                foreach (var slidePart in presentation.PresentationPart.SlideParts)
                {
                    elements.AddRange(slidePart.Slide.Descendants<TElement>());
                }
            }
            else if (spreadsheet != null)
            {
                foreach (var sheet in spreadsheet.WorkbookPart.Workbook.Sheets)
                {
                    elements.AddRange(sheet.Descendants<TElement>());
                }
            }

            Log.VerifyTrue(
                elements.Count > 0,
                string.Format(
                    "Elements [{0}] are detected in [{1}]",
                    typeof(TElement).ToString(),
                    package.Package.PackageProperties.Title));

            return elements;
        }
    }
}
