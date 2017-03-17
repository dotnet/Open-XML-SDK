// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using OxTest;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Validation;

using Xunit;
using System.IO.Packaging;

using DocumentFormat.OpenXml.Tests;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Summary description for AutoSaveTestClass
    /// </summary>

    public class AutoSaveTestClass : OpenXmlDomTestBase
    {
        internal bool[] IsEditable;
        internal bool[] AutoSave;
        public AutoSaveTestClass()
        {
            IsEditable = new bool[] { true, false };
            AutoSave = new bool[] { true, false };
        }

        [Fact]
        public void DefaultStreamReadOnly()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt")
               .Where(f => f.IsOpenXmlFile());
            foreach (var testfile in testfiles)
            {
                Log.BeginGroup(testfile.FullName);

                Log.Comment("Opening stream with FileAccess:{0}...", FileAccess.Read);
                Stream st = testfile.Open(FileMode.Open, FileAccess.Read);

                if (testfile.IsWordprocessingFile())
                {
                    using (var package = WordprocessingDocument.Open(st, false))
                    {
                        package.MainPart().RootElement.FirstChild.Remove();
                        Log.Comment("AutoSave: {0}", package.AutoSave);
                        Log.Comment("ProcessMode: {0}", package.MarkupCompatibilityProcessSettings.ProcessMode);
                        Log.Comment("FileFormat: {0}", package.MarkupCompatibilityProcessSettings.TargetFileFormatVersions);
                        package.Close();
                        Log.Pass("closed, autosave=false");

                        try
                        {
                            using (var package2 = WordprocessingDocument.Open(st, true))
                            {
                                Log.VerifyShouldNotReachHere("Expected IOException is not thrown");
                                Log.Comment("AutoSave: {0}", package.AutoSave);
                                Log.Comment("ProcessMode: {0}", package.MarkupCompatibilityProcessSettings.ProcessMode);
                                Log.Comment("FileFormat: {0}", package.MarkupCompatibilityProcessSettings.TargetFileFormatVersions);
                            }
                        }
                        catch (ArgumentException)
                        {
                            Log.Pass("Expected ArgumentException is thrown");
                        }
                        catch (IOException)
                        {
                            Log.Pass("Expected IOException is thrown");
                        }
                    }
                }
                if (testfile.IsSpreadsheetFile())
                {
                    using (var package = SpreadsheetDocument.Open(st, false))
                    {
                        package.MainPart().RootElement.FirstChild.Remove();
                        package.Close();
                        Log.Pass("closed, autosave=false");

                        try
                        {
                            using (var package2 = SpreadsheetDocument.Open(st, true))
                            {
                                Log.VerifyShouldNotReachHere("Expected IOException is not thrown");
                            }
                        }
                        catch (ArgumentException)
                        {
                            Log.Pass("Expected ArgumentException is thrown");
                        }
                        catch (IOException)
                        {
                            Log.Pass("Expected IOException is thrown");
                        }
                    }
                }
                if (testfile.IsPresentationFile())
                {
                    var package = PresentationDocument.Open(st, false);
                    package.MainPart().RootElement.FirstChild.Remove();
                    package.Close();
                    Log.Pass("closed, autosave=false");

                    try
                    {
                        package = PresentationDocument.Open(st, true);
                        Log.VerifyShouldNotReachHere("Expected IOException is not thrown");
                    }
                    catch (ArgumentException)
                    {
                        Log.Pass("Expected ArgumentException is thrown");
                    }
                    catch (IOException)
                    {
                        Log.Pass("Expected IOException is thrown");
                    }
                }
            }
        }

        [Fact]
        public void DefaultStreamReadWrite()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt")
               .Where(f => f.IsOpenXmlFile());
            foreach (var testfile in testfiles)
            {
                Log.BeginGroup(testfile.FullName);

                Log.Comment("Opening stream with FileAccess:{0}...", FileAccess.ReadWrite);
                Stream st = testfile.Open(FileMode.Open, FileAccess.ReadWrite);

                if (testfile.IsWordprocessingFile())
                {
                    using (var package = WordprocessingDocument.Open(st, true, new OpenSettings() { AutoSave = true }))
                    {
                        package.MainPart().RootElement.FirstChild.FirstChild.Remove();
                        Log.Comment("AutoSave: {0}", package.AutoSave);
                        Log.Comment("ProcessMode: {0}", package.MarkupCompatibilityProcessSettings.ProcessMode);
                        Log.Comment("FileFormat: {0}", package.MarkupCompatibilityProcessSettings.TargetFileFormatVersions);
                        package.Close();
                        Log.Pass("closed, autosave=true");

                        using (var package2 = WordprocessingDocument.Open(st, false, new OpenSettings() { AutoSave = false }))
                        {
                            package2.MainPart().RootElement.FirstChild.FirstChild.Remove();
                            Log.Comment("AutoSave: {0}", package2.AutoSave);
                            Log.Comment("ProcessMode: {0}", package2.MarkupCompatibilityProcessSettings.ProcessMode);
                            Log.Comment("FileFormat: {0}", package2.MarkupCompatibilityProcessSettings.TargetFileFormatVersions);
                        }
                        Log.Pass("closed, autosave=false");
                    }
                }
                if (testfile.IsSpreadsheetFile())
                {
                    using (var package = SpreadsheetDocument.Open(st, true, new OpenSettings() { AutoSave = true }))
                    {
                        package.MainPart().RootElement.FirstChild.Remove();
                        package.Close();
                        Log.Pass("closed, autosave=true");

                        using (var package2 = SpreadsheetDocument.Open(st, false, new OpenSettings() { AutoSave = false }))
                        {
                            package2.MainPart().RootElement.FirstChild.Remove();
                            package2.Close();
                        }
                    }
                    Log.Pass("closed, autosave=false");
                }
                if (testfile.IsPresentationFile())
                {
                    using (var package = PresentationDocument.Open(st, true, new OpenSettings() { AutoSave = true }))
                    {
                        package.MainPart().RootElement.FirstChild.Remove();
                        package.Close();
                        Log.Pass("closed, autosave=true");

                        using (var package2 = PresentationDocument.Open(st, false, new OpenSettings() { AutoSave = false }))
                        {
                            package2.MainPart().RootElement.FirstChild.Remove();
                            package2.Close();
                        }
                        Log.Pass("closed, autosave=false");
                    }
                }
            }
        }

        [Fact]
        public void DefaultStreamWrite()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt")
               .Where(f => f.IsOpenXmlFile());
            foreach (var testfile in testfiles)
            {
                Log.BeginGroup(testfile.FullName);

                Log.Comment("Opening stream with FileAccess:{0}...", FileAccess.Write);
                Stream st = testfile.Open(FileMode.Open, FileAccess.Write);

                if (testfile.IsWordprocessingFile())
                {
                    try
                    {
                        using (var package = WordprocessingDocument.Open(st, true))
                        {
                            Log.VerifyShouldNotReachHere("Expected IOException is not thrown");
                            Log.Comment("AutoSave: {0}", package.AutoSave);
                            Log.Comment("ProcessMode: {0}", package.MarkupCompatibilityProcessSettings.ProcessMode);
                            Log.Comment("FileFormat: {0}", package.MarkupCompatibilityProcessSettings.TargetFileFormatVersions);
                        }
                    }
                    catch (ArgumentException)
                    {
                        Log.Pass("Expected ArgumentException is thrown");
                    }
                    catch (IOException)
                    {
                        Log.Pass("Expected IOException is thrown");
                    }
                }
                if (testfile.IsSpreadsheetFile())
                {
                    try
                    {
                        using (var package = SpreadsheetDocument.Open(st, true))
                        {
                            Log.VerifyShouldNotReachHere("Expected IOException is not thrown");
                        }
                    }
                    catch (ArgumentException)
                    {
                        Log.Pass("Expected ArgumentException is thrown");
                    }
                    catch (IOException)
                    {
                        Log.Pass("Expected IOException is thrown");
                    }
                }
                if (testfile.IsPresentationFile())
                {
                    try
                    {
                        var package = PresentationDocument.Open(st, true);
                        Log.VerifyShouldNotReachHere("Expected IOException is not thrown");
                    }
                    catch (ArgumentException)
                    {
                        Log.Pass("Expected ArgumentException is thrown");
                    }
                    catch (IOException)
                    {
                        Log.Pass("Expected IOException is thrown");
                    }
                }
            }
        }

        [Fact]
        public void DefaultWithFilePath()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt")
               .Where(f => f.IsOpenXmlFile());
            foreach (var testfile in testfiles)
            {
                Log.BeginGroup(testfile.FullName);

                Log.Comment("Opening Package with file path...");
                if (testfile.IsWordprocessingFile())
                {
                    using (var package = WordprocessingDocument.Open(testfile.FullName, true))
                    {
                        Log.Comment("AutoSave: {0}", package.AutoSave);
                        Log.Comment("ProcessMode: {0}", package.MarkupCompatibilityProcessSettings.ProcessMode);
                        Log.Comment("FileFormat: {0}", package.MarkupCompatibilityProcessSettings.TargetFileFormatVersions);
                        package.Close();
                    }
                    Log.Pass("Package closed without any error.");

                    using (var package = WordprocessingDocument.Open(testfile.FullName, false))
                    {
                        Log.Comment("AutoSave: {0}", package.AutoSave);
                        Log.Comment("ProcessMode: {0}", package.MarkupCompatibilityProcessSettings.ProcessMode);
                        Log.Comment("FileFormat: {0}", package.MarkupCompatibilityProcessSettings.TargetFileFormatVersions);
                        package.Close();
                    }
                    Log.Pass("Package closed without any error.");
                }
                if (testfile.IsSpreadsheetFile())
                {
                    using (var package = SpreadsheetDocument.Open(testfile.FullName, true))
                    {
                        package.Close();
                    }
                    Log.Pass("Package closed without any error, autosave=true");

                    using (var package = SpreadsheetDocument.Open(testfile.FullName, false))
                    {
                        package.Close();
                    }
                    Log.Pass("Package closed without any error, autosave=false");
                }
                if (testfile.IsPresentationFile())
                {
                    using (var package = PresentationDocument.Open(testfile.FullName, true))
                    {
                        package.Close();
                    }
                    Log.Pass("Package closed without any error, autosave=true");

                    using (var package = PresentationDocument.Open(testfile.FullName, false))
                    {
                        package.Close();
                    }
                    Log.Pass("Package closed without any error, autosave=false");
                }
            }
        }

        [Fact]
        public void DefaultPackage_Read_Editable()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            OpenPackage(FileAccess.Read, true);
        }

        [Fact]
        public void DefaultPackage_Read_NonEditable()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            OpenPackage(FileAccess.Read, false);
        }

        [Fact]
        public void DefaultPackage_ReadWrite_Editable()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            OpenPackage(FileAccess.ReadWrite, true);
        }

        [Fact]
        public void DefaultPackage_ReadWrite_NonEditable()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            OpenPackage(FileAccess.ReadWrite, false);
        }

        private void OpenPackage(FileAccess access, bool edit) // no editable argument needed to Open() Package.
        {
            var testfiles = CopyTestFiles(@"bvt")
               .Where(f => f.IsOpenXmlFile());
            foreach (var testfile in testfiles)
            {

                Log.BeginGroup(testfile.FullName);

                Log.Comment("Opening System.IO.Package with FileAccess: {0}...", access);
                Package p = Package.Open(testfile.FullName, FileMode.Open, access);

                Log.Comment("Opening SDK Package from System.IO.Package...");
                if (testfile.IsWordprocessingFile())
                {
                    using (var package = WordprocessingDocument.Open(p))
                    {
                        package.MainPart().RootElement.FirstChild.Remove();
                        Log.Comment("AutoSave: {0}", package.AutoSave);
                        Log.Comment("ProcessMode: {0}", package.MarkupCompatibilityProcessSettings.ProcessMode);
                        Log.Comment("FileFormat: {0}", package.MarkupCompatibilityProcessSettings.TargetFileFormatVersions);
                        package.Close();
                    }
                }
                if (testfile.IsSpreadsheetFile())
                {
                    using (var package = SpreadsheetDocument.Open(p))
                    {
                        package.MainPart().RootElement.FirstChild.Remove();
                        package.Close();
                    }
                }
                if (testfile.IsPresentationFile())
                {
                    using (var package = PresentationDocument.Open(p))
                    {
                        package.MainPart().RootElement.FirstChild.Remove();
                        package.Close();
                    }
                }
                Log.Pass("Package closed without any error.");
            }
        }

        [Fact]
        public void AutoSaveStream2x2()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            foreach (bool e in IsEditable)
            {
                foreach (bool s in AutoSave)
                {
                    AutoSaveStream(e, s, FileAccess.ReadWrite);
                }
            }
        }

        private void AutoSaveStream(bool edit, bool save, FileAccess read)
        {
            var testfiles = CopyTestFiles(@"bvt")
               .Where(f => f.IsOpenXmlFile());

            foreach (var testfile in testfiles)
            {
                string logGroupName = testfile.FullName;
                Log.BeginGroup(logGroupName);

                Log.Comment("Opening stream with {0}...", read);
                Stream st = testfile.Open(FileMode.Open, read);

                Log.Comment("Opening Package with AutoSave:{0}...", save);
                if (testfile.IsWordprocessingFile())
                {
                    var package = WordprocessingDocument.Open(st, edit, new OpenSettings() { AutoSave = save });
                    package.MainPart().RootElement.FirstChild.Remove();
                    package.Close();
                }
                if (testfile.IsSpreadsheetFile())
                {
                    var package = SpreadsheetDocument.Open(st, edit, new OpenSettings() { AutoSave = save });
                    package.MainPart().RootElement.FirstChild.Remove();
                    package.Close();
                }
                if (testfile.IsPresentationFile())
                {
                    var package = PresentationDocument.Open(st, edit, new OpenSettings() { AutoSave = save });
                    package.MainPart().RootElement.FirstChild.Remove();
                    package.Close();
                }
                Log.Pass("Package closed without any errors.");
            }
        }

        [Fact]
        public void AutoSaveMc_2007_NoProcess()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            OpenMcPackage(FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess);
        }

        [Fact]
        public void AutoSaveMc_2007_ProcessAllParts()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            OpenMcPackage(FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts);
        }

        [Fact]
        public void AutoSaveMc_2007_ProcessLoadedParts()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            OpenMcPackage(FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly);
        }

        private void OpenMcPackage(FileFormatVersions format, MarkupCompatibilityProcessMode mcMode)
        {
            var testfiles = CopyTestFiles(@"bvt")
               .Where(f => f.IsOpenXmlFile());

            foreach (var testfile in testfiles)
            {
                string logGroupName = testfile.FullName;
                Log.BeginGroup(logGroupName);

                Log.Comment("Opening stream with FileAccess.ReadWrite...");
                Stream st = testfile.Open(FileMode.Open, FileAccess.ReadWrite);
                var settings = new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(mcMode, format) };
                Log.Comment("Opening Package with AutoSave: {0}, mcProcessmode: {1}, FileFormat: {2} ...",
                    bool.TrueString, settings.MarkupCompatibilityProcessSettings.ProcessMode, settings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions);
                if (testfile.IsWordprocessingFile())
                {
                    var package = WordprocessingDocument.Open(st, true, settings);
                    package.MainPart().RootElement.FirstChild.Remove();
                    package.Close();
                }
                if (testfile.IsSpreadsheetFile())
                {
                    var package = SpreadsheetDocument.Open(st, true, settings);
                    package.MainPart().RootElement.FirstChild.Remove();
                    package.Close();
                }
                if (testfile.IsPresentationFile())
                {
                    var package = PresentationDocument.Open(st, true, settings);
                    package.MainPart().RootElement.FirstChild.Remove();
                    package.Close();
                }
                Log.Pass("Package Closed without any errors.");
            }
        }
    }


    public class OpenSettingsTestClass : OpenXmlDomTestBase
    {

        [Fact]
        public void OpenWithInvalidFileFormatTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles("bvt")
                .Where(fi => fi.IsOpenXmlFile());
            var testfile = testfiles.FirstOrDefault();

            var invalidFormats = new int[] { int.MinValue, -1, 0, 3, 5, 6, 7, int.MaxValue };
            foreach (var format in invalidFormats)
            {
                var invalidSettings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings
                      = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, (FileFormatVersions)format)
                };
                Log.Comment("New OpenSettings with...");
                Log.Comment("ProcessMode = {0}", invalidSettings.MarkupCompatibilityProcessSettings.ProcessMode);
                Log.Comment("TargetFileFormatVersions = {0}", invalidSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions);
                try
                {
                    Log.Comment("Opening package with constructed OpenSettings...");
                    var package = testfile.OpenPackage(true, invalidSettings);
                    package.Close();
                    Log.Fail("No expected exception thrown for invalid FileFormatVersions value.");
                }
                catch (Exception ex)
                {
                    Log.Pass("{0} caught with detailed information: \n{1}", ex.GetType().Name, ex.ToString());
                }
            }
        }

        [Fact]
        public void OpenWithFileFormatVersionsDefaultValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles("bvt")
                .Where(fi => fi.IsOpenXmlFile());
            var testfile = testfiles.FirstOrDefault();

            FileFormatVersions format = FileFormatVersions.None;
            var mcmodes = new MarkupCompatibilityProcessMode[] { MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, MarkupCompatibilityProcessMode.ProcessAllParts };
            foreach (var mcmode in mcmodes)
            {
                var invalidSettings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(mcmode, format)
                };
                Log.Comment("New OpenSettings with...");
                Log.Comment("ProcessMode = {0}", invalidSettings.MarkupCompatibilityProcessSettings.ProcessMode);
                Log.Comment("TargetFileFormatVersions = {0}", invalidSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions);
                try
                {
                    Log.Comment("Opening package with constructed OpenSettings...");
                    var package = testfile.OpenPackage(true, invalidSettings);
                    package.Close();
                    Log.Fail("No expected exception thrown for default value of FileFormatVersions.");
                }
                catch (Exception ex)
                {
                    Log.Pass("{0} caught with detailed information: \n{1}", ex.GetType().Name, ex.ToString());
                }
            }
        }

        [Fact]
        public void OpenWithFileFormatVersionsDefaultValueNoMCProcessTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles("bvt")
                .Where(fi => fi.IsOpenXmlFile());
            var testfile = testfiles.FirstOrDefault();

            FileFormatVersions format = FileFormatVersions.None;
            var mcmodes = new MarkupCompatibilityProcessMode[] { MarkupCompatibilityProcessMode.NoProcess };
            foreach (var mcmode in mcmodes)
            {
                var invalidSettings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(mcmode, format)
                };
                Log.Comment("New OpenSettings with...");
                Log.Comment("ProcessMode = {0}", invalidSettings.MarkupCompatibilityProcessSettings.ProcessMode);
                Log.Comment("TargetFileFormatVersions = {0}", invalidSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions);
                try
                {
                    Log.Comment("Opening package with constructed OpenSettings...");
                    var package = testfile.OpenPackage(true, invalidSettings);
                    package.Close();
                    Log.Pass("No exception thrown for default value of FileFormatVersions as MarkupCompatibilityProcessMode.NoProcess");
                }
                catch (Exception ex)
                {
                    Log.Fail("{0} caught with detailed information: \n{1}", ex.GetType().Name, ex.ToString());
                }
            }
        }
    }


    public class CreateDocumentTestClass : OpenXmlDomTestBase
    {
        [Fact]
        public void CreateWithFalseAutoSaveTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
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
            this.MyTestInitialize(TestContext.GetCurrentMethod());
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
            this.MyTestInitialize(TestContext.GetCurrentMethod());
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