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

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using OxTest;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class FlatOpcFixture : BaseFixture
    {
        private static string s_SubDirectory = "FlatOpc";

        private static string TestResultsDirectory
        {
            get
            {
                return Path.Combine(TestUtil.TestResultsDirectory, s_SubDirectory);
            }
        }

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
            : base(TestResultsDirectory)
        {
            Directory.CreateDirectory(TestResultsDirectory);

            File.Copy(GetTestFilePath(DocumentPath), Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), true);
            File.Copy(GetTestFilePath(PresentationPath), Path.Combine(TestUtil.TestResultsDirectory, PresentationPath), true);
            File.Copy(GetTestFilePath(SpreadsheetPath), Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath), true);

            PrepareWordprocessingDocument(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath));
            PreparePresentationDocument(Path.Combine(TestUtil.TestResultsDirectory, PresentationPath));
            PrepareSpreadsheetDocument(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath));
        }

        [Fact]
        public void CanCreateFlatOpcPresentationDocuments()
        {
            using (var source = PresentationDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, PresentationPath), true))
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
                using (PresentationDocument.FromFlatOpcDocument(flatOpcDoc, Path.Combine(TestUtil.TestResultsDirectory, PresentationClonePath), false))
                using (var dest = PresentationDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, PresentationClonePath), false))
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
                using (PresentationDocument.FromFlatOpcString(flatOpcString, Path.Combine(TestUtil.TestResultsDirectory, PresentationClonePath), false))
                using (var dest = PresentationDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, PresentationClonePath), false))
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
            using (var source = SpreadsheetDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath), true))
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
                using (SpreadsheetDocument.FromFlatOpcDocument(flatOpcDoc, Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetClonePath), false))
                using (var dest = SpreadsheetDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetClonePath), false))
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
                using (SpreadsheetDocument.FromFlatOpcString(flatOpcString, Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetClonePath), false))
                using (var dest = SpreadsheetDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetClonePath), false))
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
            using (var source = WordprocessingDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), true))
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
                using (WordprocessingDocument.FromFlatOpcDocument(flatOpcDoc, Path.Combine(TestUtil.TestResultsDirectory, DocumentClonePath), false))
                using (var dest = WordprocessingDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, DocumentClonePath), false))
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
                using (WordprocessingDocument.FromFlatOpcString(flatOpcString, Path.Combine(TestUtil.TestResultsDirectory, DocumentClonePath), false))
                using (var dest = WordprocessingDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, DocumentClonePath), false))
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