/*
 * FlatOpcFixture.cs - Testing Flat OPC functionality in Open XML SDK
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
using System.IO.Packaging;
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
    public class FlatOpcFixture : BaseFixture
    {
        private const string DirectoryPath = "FlatOpc";

        private const string DocumentPath = DirectoryPath + "\\Document.docx";
        private const string PresentationPath = DirectoryPath + "\\Presentation.pptx";
        private const string SpreadsheetPath = DirectoryPath + "\\Spreadsheet.xlsx";

        private const string DocumentClonePath = DirectoryPath + "\\Document Clone.docx";
        private const string PresentationClonePath = DirectoryPath + "\\Presentation Clone.pptx";
        private const string SpreadsheetClonePath = DirectoryPath + "\\Spreadsheet Clone.xlsx";

        /// <summary>
        /// Creates a new instance of this test fixture, registering our test folder
        /// with the base fixture for cleanup after testing.
        /// </summary>
        public FlatOpcFixture()
            : base(DirectoryPath)
        {
            Directory.CreateDirectory(DirectoryPath);

            File.Copy(GetTestFilePath(DocumentPath), DocumentPath, true);
            File.Copy(GetTestFilePath(PresentationPath), PresentationPath, true);
            File.Copy(GetTestFilePath(SpreadsheetPath), SpreadsheetPath, true);

            PrepareWordprocessingDocument(DocumentPath);
            PreparePresentationDocument(PresentationPath);
            PrepareSpreadsheetDocument(SpreadsheetPath);
        }

        [Fact]
        public void CanCreateFlatOpcPresentationDocuments()
        {
            using (var source = PresentationDocument.Open(PresentationPath, true))
            {
                // Test FlatOpcDocument methods. 
                // Check ToFlatOpcDocument() and FromFlatOpcDocument(XDocument).
                var flatOpcDoc = source.ToFlatOpcDocument();
                using (var dest = PresentationDocument.FromFlatOpcDocument(flatOpcDoc))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcDocument(XDocument, Stream, bool).
                using (Stream stream = new MemoryStream())
                using (PresentationDocument.FromFlatOpcDocument(flatOpcDoc, stream, false))
                using (var dest = PresentationDocument.Open(stream, false))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcDocument(XDocument, string, bool).
                using (PresentationDocument.FromFlatOpcDocument(flatOpcDoc, PresentationClonePath, false))
                using (var dest = PresentationDocument.Open(PresentationClonePath, false))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcDocument(XDocument, Package).
                using (var stream = new MemoryStream())
                using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
                using (var dest = PresentationDocument.FromFlatOpcDocument(flatOpcDoc, package))
                    AssertThatPackagesAreEqual(source, dest);

                // Test FlatOpcString methods.
                // Check ToFlatOpcString() and FromFlatOpcString(string).
                var flatOpcString = source.ToFlatOpcString();
                using (var dest = PresentationDocument.FromFlatOpcString(flatOpcString))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcString(string, Stream, bool).
                using (Stream stream = new MemoryStream())
                using (PresentationDocument.FromFlatOpcString(flatOpcString, stream, false))
                using (var dest = PresentationDocument.Open(stream, false))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcString(string, string, bool).
                using (PresentationDocument.FromFlatOpcString(flatOpcString, PresentationClonePath, false))
                using (var dest = PresentationDocument.Open(PresentationClonePath, false))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcString(string, Package).
                using (var stream = new MemoryStream())
                using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
                using (var dest = PresentationDocument.FromFlatOpcString(flatOpcString, package))
                    AssertThatPackagesAreEqual(source, dest);
            }
        }

        [Fact]
        public void CanCreateFlatOpcSpreadsheetDocuments()
        {
            using (var source = SpreadsheetDocument.Open(SpreadsheetPath, true))
            {
                // Test FlatOpcDocument methods. 
                // Check ToFlatOpcDocument() and FromFlatOpcDocument(XDocument).
                var flatOpcDoc = source.ToFlatOpcDocument();
                using (var dest = SpreadsheetDocument.FromFlatOpcDocument(flatOpcDoc))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcDocument(XDocument, Stream, bool).
                using (Stream stream = new MemoryStream())
                using (SpreadsheetDocument.FromFlatOpcDocument(flatOpcDoc, stream, false))
                using (var dest = SpreadsheetDocument.Open(stream, false))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcDocument(XDocument, string, bool).
                using (SpreadsheetDocument.FromFlatOpcDocument(flatOpcDoc, SpreadsheetClonePath, false))
                using (var dest = SpreadsheetDocument.Open(SpreadsheetClonePath, false))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcDocument(XDocument, Package).
                using (var stream = new MemoryStream())
                using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
                using (var dest = SpreadsheetDocument.FromFlatOpcDocument(flatOpcDoc, package))
                    AssertThatPackagesAreEqual(source, dest);

                // Test FlatOpcString methods.
                // Check ToFlatOpcString() and FromFlatOpcString(string).
                var flatOpcString = source.ToFlatOpcString();
                using (var dest = SpreadsheetDocument.FromFlatOpcString(flatOpcString))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcString(string, Stream, bool).
                using (Stream stream = new MemoryStream())
                using (SpreadsheetDocument.FromFlatOpcString(flatOpcString, stream, false))
                using (var dest = SpreadsheetDocument.Open(stream, false))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcString(string, string, bool).
                using (SpreadsheetDocument.FromFlatOpcString(flatOpcString, SpreadsheetClonePath, false))
                using (var dest = SpreadsheetDocument.Open(SpreadsheetClonePath, false))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcString(string, Package).
                using (var stream = new MemoryStream())
                using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
                using (var dest = SpreadsheetDocument.FromFlatOpcString(flatOpcString, package))
                    AssertThatPackagesAreEqual(source, dest);
            }
        }

        [Fact]
        public void CanCreateFlatOpcWordprocessingDocuments()
        {
            using (var source = WordprocessingDocument.Open(DocumentPath, true))
            {
                // Test FlatOpcDocument methods. 
                // Check ToFlatOpcDocument() and FromFlatOpcDocument(XDocument).
                var flatOpcDoc = source.ToFlatOpcDocument();
                using (var dest = WordprocessingDocument.FromFlatOpcDocument(flatOpcDoc))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcDocument(XDocument, Stream, bool).
                using (Stream stream = new MemoryStream())
                using (WordprocessingDocument.FromFlatOpcDocument(flatOpcDoc, stream, false))
                using (var dest = WordprocessingDocument.Open(stream, false))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcDocument(XDocument, string, bool).
                using (WordprocessingDocument.FromFlatOpcDocument(flatOpcDoc, DocumentClonePath, false))
                using (var dest = WordprocessingDocument.Open(DocumentClonePath, false))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcDocument(XDocument, Package).
                using (var stream = new MemoryStream())
                using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
                using (var dest = WordprocessingDocument.FromFlatOpcDocument(flatOpcDoc, package))
                    AssertThatPackagesAreEqual(source, dest);

                // Test FlatOpcString methods.
                // Check ToFlatOpcString() and FromFlatOpcString(string).
                var flatOpcString = source.ToFlatOpcString();
                using (var dest = WordprocessingDocument.FromFlatOpcString(flatOpcString))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcString(string, Stream, bool).
                using (Stream stream = new MemoryStream())
                using (WordprocessingDocument.FromFlatOpcString(flatOpcString, stream, false))
                using (var dest = WordprocessingDocument.Open(stream, false))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcString(string, string, bool).
                using (WordprocessingDocument.FromFlatOpcString(flatOpcString, DocumentClonePath, false))
                using (var dest = WordprocessingDocument.Open(DocumentClonePath, false))
                    AssertThatPackagesAreEqual(source, dest);

                // Check FromFlatOpcString(string, Package).
                using (var stream = new MemoryStream())
                using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
                using (var dest = WordprocessingDocument.FromFlatOpcString(flatOpcString, package))
                    AssertThatPackagesAreEqual(source, dest);
            }
        }
    }
}