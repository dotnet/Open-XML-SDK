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

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using OxTest;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedVariable")]
    public class CreateFromTemplateFixture : BaseFixture
    {
        private static string s_SubDirectory = "CreateFromTemplate";

        private static string TestResultsDirectory
        {
            get
            {
                return Path.Combine(TestUtil.TestResultsDirectory, s_SubDirectory);
            }
        }

        private string DocumentPath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
        private string PresentationPath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private string SpreadsheetPath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");

        //private string DocumentTemplatePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".dotx");
        //private string PresentationTemplatePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".potx");
        //private string SpreadsheetTemplatePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xltx");

        private string DocumentTemplatePath = "Document.dotx";
        private string PresentationTemplatePath = "Presentation.potx";
        private string SpreadsheetTemplatePath = "Spreadsheet.xltx";

        /// <summary>
        /// Creates a new instance of this test fixture, registering our test folder
        /// with the base fixture for cleanup after testing.
        /// </summary>
        public CreateFromTemplateFixture()
            : base(TestResultsDirectory)
        {
            Directory.CreateDirectory(TestResultsDirectory);

            File.Copy(GetTestFilePath(DocumentTemplatePath), DocumentTemplatePath, true);
            File.Copy(GetTestFilePath(PresentationTemplatePath), PresentationTemplatePath, true);
            File.Copy(GetTestFilePath(SpreadsheetTemplatePath), SpreadsheetTemplatePath, true);
        }

        [Fact]
        public void CanCreatePresentationFromTemplate()
        {
            using (var packageDocument = PresentationDocument.CreateFromTemplate(GetTestFilePath(PresentationTemplatePath)))
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
            using (var packageDocument = SpreadsheetDocument.CreateFromTemplate(GetTestFilePath(SpreadsheetTemplatePath)))
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
            using (var packageDocument = WordprocessingDocument.CreateFromTemplate(GetTestFilePath(DocumentTemplatePath)))
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