// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.Validation
{
    /// <summary>
    /// The OpenXmlValidator caches some items, and at one point cached the documents themselves which we do not want them to do
    /// </summary>
    public class ReferenceReleaseTests
    {
        [Fact]
        public void WordprocessingDocumentValidationReferenceCount()
        {
            var validator = new OpenXmlValidator();
            var result = RunWordprocessing(validator);
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);

            Assert.False(result.IsAlive);
        }

        [Fact]
        public void SpreadsheetDocumentValidationReferenceCount()
        {
            var validator = new OpenXmlValidator();
            var result = RunSpreadsheet(validator);
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);

            Assert.False(result.IsAlive);
        }

        [Fact]
        public void PresentationDocumentValidationReferenceCount()
        {
            var validator = new OpenXmlValidator();
            var result = RunPresentation(validator);
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);

            Assert.False(result.IsAlive);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private WeakReference RunWordprocessing(OpenXmlValidator validator)
        {
            using (var ms = new MemoryStream())
            {
                using (var document = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document))
                {
                    var part = document.AddMainDocumentPart();
                    part.Document = new Document();
                }

                using (var document = WordprocessingDocument.Open(ms, false))
                {
                    validator.Validate(document);

                    return new WeakReference(document);
                }
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private WeakReference RunSpreadsheet(OpenXmlValidator validator)
        {
            using (var ms = new MemoryStream())
            {
                using (var spreadsheet = SpreadsheetDocument.Create(ms, SpreadsheetDocumentType.Workbook))
                {
                    var part = spreadsheet.AddWorkbookPart();
                    part.Workbook = new Workbook();
                }

                using (var spreadsheet = SpreadsheetDocument.Open(ms, false))
                {
                    validator.Validate(spreadsheet);

                    return new WeakReference(spreadsheet);
                }
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private WeakReference RunPresentation(OpenXmlValidator validator)
        {
            using (var ms = new MemoryStream())
            {
                using (var presentation = PresentationDocument.Create(ms, PresentationDocumentType.Presentation))
                {
                    var presentationPart = presentation.AddPresentationPart();
                    presentationPart.Presentation = new Presentation.Presentation();
                }

                using (var presentation = PresentationDocument.Open(ms, false))
                {
                    validator.Validate(presentation);

                    return new WeakReference(presentation);
                }
            }
        }
    }
}
