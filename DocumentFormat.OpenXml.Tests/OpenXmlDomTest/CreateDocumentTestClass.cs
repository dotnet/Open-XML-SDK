// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using OxTest;
using System;
using System.IO;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests
{
    public class CreateDocumentTestClass : OpenXmlDomTestBase
    {
        public CreateDocumentTestClass(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void CreateWithFalseAutoSaveTest()
        {
            var testfiles = CopyTestFiles("bvt")
                .Where(fi => fi.IsOpenXmlFile());

            bool autoSave = false;
            OpenXmlPackage createdPackage = null;
            foreach (var testfile in testfiles)
            {
                string newlyCreatedName = null;
                if (testfile.IsWordprocessingFile())
                    newlyCreatedName = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
                else if (testfile.IsSpreadsheetFile())
                    newlyCreatedName = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
                else if (testfile.IsPresentationFile())
                    newlyCreatedName = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");

                Log.Comment("Opening source package in readOnly mode...");
                var sourcePackage = testfile.OpenPackage(false);
                Log.Comment("Creating new package with AutoSave={0}...", autoSave);
                if (testfile.IsWordprocessingFile())
                    createdPackage = WordprocessingDocument.Create(newlyCreatedName, WordprocessingDocumentType.Document, autoSave);
                else if (testfile.IsSpreadsheetFile())
                    createdPackage = SpreadsheetDocument.Create(newlyCreatedName, SpreadsheetDocumentType.Workbook, autoSave);
                else if (testfile.IsPresentationFile())
                    createdPackage = PresentationDocument.Create(newlyCreatedName, PresentationDocumentType.Presentation, autoSave);
                else
                    Log.Fail("Unexpected document type passed in.");
                if (createdPackage != null)
                {
                    Log.Comment("Feeding main part with DOM operations...");
                    duplicteMainPart(sourcePackage, createdPackage);
                    Log.Comment("Closing package...");
                    createdPackage.Close();
                }

                Log.Warning("Reopening...Expecting null for root element of main part as AutoSave is false thus no DOM changes will be saved.");
                if (testfile.IsWordprocessingFile())
                    createdPackage = WordprocessingDocument.Open(newlyCreatedName, false);
                else if (testfile.IsSpreadsheetFile())
                    createdPackage = SpreadsheetDocument.Open(newlyCreatedName, false);
                else if (testfile.IsPresentationFile())
                    createdPackage = PresentationDocument.Open(newlyCreatedName, false);
                else
                    Log.Fail("Unexpected document type passed in.");
                var mainpart = createdPackage.MainPart();
                var dom = mainpart.RootElement;
                if (dom == null)
                    Log.Pass("Null root element of main part just as expected.");
                else
                    Log.Fail("Root element of main part is not null. Something must be wrong.");
                createdPackage.Close();
                FileInfo fz = new FileInfo(newlyCreatedName);
                if (fz.Exists)
                    fz.Delete();
            }
        }

        [Fact]
        public void CreateWithTrueAutoSaveTest()
        {
            var testfiles = CopyTestFiles("bvt")
                .Where(fi => fi.IsOpenXmlFile());

            bool autoSave = true;
            OpenXmlPackage createdPackage = null;
            foreach (var testfile in testfiles)
            {
                string newlyCreatedName = null;
                if (testfile.IsWordprocessingFile())
                    newlyCreatedName = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
                else if (testfile.IsSpreadsheetFile())
                    newlyCreatedName = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
                else if (testfile.IsPresentationFile())
                    newlyCreatedName = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");

                Log.Comment("Opening source package in readOnly mode...");
                var sourcePackage = testfile.OpenPackage(false);
                Log.Comment("Creating new package with AutoSave={0}...", autoSave);
                if (testfile.IsWordprocessingFile())
                    createdPackage = WordprocessingDocument.Create(newlyCreatedName, WordprocessingDocumentType.Document, autoSave);
                else if (testfile.IsSpreadsheetFile())
                    createdPackage = SpreadsheetDocument.Create(newlyCreatedName, SpreadsheetDocumentType.Workbook, autoSave);
                else if (testfile.IsPresentationFile())
                    createdPackage = PresentationDocument.Create(newlyCreatedName, PresentationDocumentType.Presentation, autoSave);
                else
                    Log.Fail("Unexpected document type passed in.");
                if (createdPackage != null)
                {
                    Log.Comment("Feeding main part with DOM operations...");
                    duplicteMainPart(sourcePackage, createdPackage);
                    Log.Comment("Closing package...");
                    createdPackage.Close();
                }

                Log.Warning("Reopening...Expecting Non-null for root element of main part as AutoSave is true thus DOM changes will be saved.");
                if (testfile.IsWordprocessingFile())
                    createdPackage = WordprocessingDocument.Open(newlyCreatedName, false);
                else if (testfile.IsSpreadsheetFile())
                    createdPackage = SpreadsheetDocument.Open(newlyCreatedName, false);
                else if (testfile.IsPresentationFile())
                    createdPackage = PresentationDocument.Open(newlyCreatedName, false);
                else
                    Log.Fail("Unexpected document type passed in.");
                var mainpart = createdPackage.MainPart();
                var dom = mainpart.RootElement;
                if (dom != null)
                    Log.Pass("Root element of main part is not null just as expected.");
                else
                    Log.Fail("Null root element of main part. Something must be wrong.");

                createdPackage.Close();
                FileInfo fz = new FileInfo(newlyCreatedName);
                if (fz.Exists)
                    fz.Delete();
            }
        }

        [Fact]
        public void CreateWithNoAutoSaveTest()
        {
            var testfiles = CopyTestFiles("bvt")
                .Where(fi => fi.IsOpenXmlFile());

            OpenXmlPackage createdPackage = null;
            foreach (var testfile in testfiles)
            {
                string newlyCreatedName = null;
                if (testfile.IsWordprocessingFile())
                    newlyCreatedName = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
                else if (testfile.IsSpreadsheetFile())
                    newlyCreatedName = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
                else if (testfile.IsPresentationFile())
                    newlyCreatedName = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");

                Log.Comment("Opening source package in readOnly mode...");
                var sourcePackage = testfile.OpenPackage(false);
                Log.Comment("Creating new package with overload that no autoSave option");
                if (testfile.IsWordprocessingFile())
                    createdPackage = WordprocessingDocument.Create(newlyCreatedName, WordprocessingDocumentType.Document);
                else if (testfile.IsSpreadsheetFile())
                    createdPackage = SpreadsheetDocument.Create(newlyCreatedName, SpreadsheetDocumentType.Workbook);
                else if (testfile.IsPresentationFile())
                    createdPackage = PresentationDocument.Create(newlyCreatedName, PresentationDocumentType.Presentation);
                else
                    Log.Fail("Unexpected document type passed in.");
                if (createdPackage != null)
                {
                    Log.Comment("Feeding main part with DOM operations...");
                    duplicteMainPart(sourcePackage, createdPackage);
                    Log.Comment("Closing package...");
                    createdPackage.Close();
                }

                Log.Warning("Reopening...Expecting null for root element of main part as AutoSave default value is true thus DOM changes will be saved.");
                if (testfile.IsWordprocessingFile())
                    createdPackage = WordprocessingDocument.Open(newlyCreatedName, false);
                else if (testfile.IsSpreadsheetFile())
                    createdPackage = SpreadsheetDocument.Open(newlyCreatedName, false);
                else if (testfile.IsPresentationFile())
                    createdPackage = PresentationDocument.Open(newlyCreatedName, false);
                else
                    Log.Fail("Unexpected document type passed in.");
                var mainpart = createdPackage.MainPart();
                var dom = mainpart.RootElement;
                if (dom != null)
                    Log.Pass("Root element of main part is not null just as expected.");
                else
                    Log.Fail("Null root element of main part. Something must be wrong.");

                createdPackage.Close();
                FileInfo fz = new FileInfo(newlyCreatedName);
                if (fz.Exists)
                    fz.Delete();
            }
        }

        private void duplicteMainPart(OpenXmlPackage source, OpenXmlPackage result)
        {
            if (source is WordprocessingDocument)
            {
                var part = (result as WordprocessingDocument).AddMainDocumentPart();
                part.Document = (Document)(source as WordprocessingDocument).MainDocumentPart.Document.CloneNode(true);
            }
            else if (source is PresentationDocument)
            {
                var part = (result as PresentationDocument).AddPresentationPart();
                part.Presentation = new Presentation.Presentation((source as PresentationDocument).PresentationPart.Presentation.OuterXml);
            }
            else if (source is SpreadsheetDocument)
            {
                var part = (result as SpreadsheetDocument).AddWorkbookPart();
                part.Workbook = new Workbook();
                part.Workbook.Append((source as SpreadsheetDocument).WorkbookPart.Workbook.ChildElements.Select(c => c.CloneNode(true)));
            }
        }
    }
}
