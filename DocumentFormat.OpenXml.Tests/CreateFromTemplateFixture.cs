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

using System.Diagnostics.CodeAnalysis;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using Xunit;

// to run the X64 tests:
// packages\xunit.runner.console.2.0.0\tools\xunit.console DocumentFormat.OpenXml.Tests.64\bin\Debug\DocumentFormat.OpenXml.Tests.dll

#if X64
namespace DocumentFormat.OpenXml.Tests.X64
#else
namespace DocumentFormat.OpenXml.Tests
#endif
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedVariable")]
    public class CreateFromTemplateFixture : BaseFixture
    {
        private const string DirectoryPath = "CreateFromTemplate";

        private const string DocumentPath = DirectoryPath + "\\Document.docx";
        private const string PresentationPath = DirectoryPath + "\\Presentation.pptx";
        private const string SpreadsheetPath = DirectoryPath + "\\Spreadsheet.xlsx";

        private const string DocumentTemplatePath = DirectoryPath + "\\Document.dotx";
        private const string PresentationTemplatePath = DirectoryPath + "\\Presentation.potx";
        private const string SpreadsheetTemplatePath = DirectoryPath + "\\Spreadsheet.xltx";

        /// <summary>
        /// Creates a new instance of this test fixture, registering our test folder
        /// with the base fixture for cleanup after testing.
        /// </summary>
        public CreateFromTemplateFixture()
            : base(DirectoryPath)
        {
            Directory.CreateDirectory(DirectoryPath);

            File.Copy(GetTestFilePath(DocumentTemplatePath), DocumentTemplatePath, true);
            File.Copy(GetTestFilePath(PresentationTemplatePath), PresentationTemplatePath, true);
            File.Copy(GetTestFilePath(SpreadsheetTemplatePath), SpreadsheetTemplatePath, true);
        }

        [Fact]
        public void CanCreatePresentationFromTemplate()
        {
            using (var packageDocument = PresentationDocument.CreateFromTemplate(PresentationTemplatePath))
            {
                var part = packageDocument.PresentationPart;
                var root = part.Presentation;

                packageDocument.SaveAs(PresentationPath).Close();

                // We are fine if we have not run into an exception.
                Assert.True(true);
            }
        }

        [Fact]
        public void CanCreateSpreadsheetFromTemplate()
        {
            using (var packageDocument = SpreadsheetDocument.CreateFromTemplate(SpreadsheetTemplatePath))
            {
                var part = packageDocument.WorkbookPart;
                var root = part.Workbook;

                packageDocument.SaveAs(SpreadsheetPath).Close();

                // We are fine if we have not run into an exception.
                Assert.True(true);
            }
        }

        [Fact]
        public void CanCreateWordprocessingDocumentFromTemplate()
        {
            using (var packageDocument = WordprocessingDocument.CreateFromTemplate(DocumentTemplatePath))
            {
                var part = packageDocument.MainDocumentPart;
                var root = part.Document;

                packageDocument.SaveAs(DocumentPath).Close();

                // We are fine if we have not run into an exception.
                Assert.True(true);
            }
        }
    }
}