/*
 * CreateFromTemplateFixture.cs - Testing Create From Template functionality in Open XML SDK
 * 
 * Copyright 2014-2015 Thomas Barnekow
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * Developer: Thomas Barnekow
 * Email: thomas<at/>barnekow<dot/>info
 */

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
            using (var stream = OpenAsFile(TestFiles.Templates.Presentation, FileAccess.ReadWrite))
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
            using (var stream = OpenAsFile(TestFiles.Templates.Spreadsheet, FileAccess.ReadWrite))
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
            using (var stream = OpenAsFile(TestFiles.Templates.Document, FileAccess.ReadWrite))
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
