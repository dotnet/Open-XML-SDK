// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.IO;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    public class CreateFromTemplateTests
    {
        [Fact]
        public void CanCreatePresentationFromTemplate()
        {
            using (var stream = OpenFile(TestFiles.Templates.Presentation, FileAccess.ReadWrite))
            using (var packageDocument = PresentationDocument.CreateFromTemplate(stream.Path))
            {
                var part = packageDocument.PresentationPart;
                var root = part.Presentation;

                packageDocument.SaveAs(Path.GetTempFileName()).Close();

                // We are fine if we have not run into an exception.
                Assert.True(true);
            }
        }

        [Fact]
        public void CanCreateSpreadsheetFromTemplate()
        {
            using (var stream = OpenFile(TestFiles.Templates.Spreadsheet, FileAccess.ReadWrite))
            using (var packageDocument = SpreadsheetDocument.CreateFromTemplate(stream.Path))
            {
                var part = packageDocument.WorkbookPart;
                var root = part.Workbook;

                packageDocument.SaveAs(Path.GetTempFileName()).Close();

                // We are fine if we have not run into an exception.
                Assert.True(true);
            }
        }

        [Fact]
        public void CanCreateWordprocessingDocumentFromTemplate()
        {
            using (var stream = OpenFile(TestFiles.Templates.Document, FileAccess.ReadWrite))
            using (var packageDocument = WordprocessingDocument.CreateFromTemplate(stream.Path))
            {
                var part = packageDocument.MainDocumentPart;
                var root = part.Document;

                packageDocument.SaveAs(Path.GetTempFileName()).Close();

                // We are fine if we have not run into an exception.
                Assert.True(true);
            }
        }
    }
}
