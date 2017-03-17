// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;


namespace DocumentFormat.OpenXml.Tests.WebExtension
{
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Validation;
    using DocumentFormat.OpenXml.Packaging;
    using Pres = DocumentFormat.OpenXml.Presentation;
    using SSht = DocumentFormat.OpenXml.Spreadsheet;
    using WPrc = DocumentFormat.OpenXml.Wordprocessing;
    using Wetp = DocumentFormat.OpenXml.Office2013.WebExtentionPane;

    using We = DocumentFormat.OpenXml.Office2013.WebExtension;
    using A = DocumentFormat.OpenXml.Drawing;


    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.TaskLibraries.DataStorage;
    using DocumentFormat.OpenXml.Tests.WebExtensionClass;
    using OxTest;

    /// <summary>
    /// Test for Web Extension elements
    /// </summary>

    public class WebExtensionTest : OpenXmlTestBase
    {
        #region Data members
        // today's day, used as a seed for value replacements
        private int dayOfTest;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public WebExtensionTest()
        {
            this.dayOfTest = DateTime.Today.Day;
        }
        #endregion

        #region Test Methods
        /// <summary>
        /// Office15TCM: 64603, 64604, 64606: OASys#283288: OOXML SDK : ACC : O15 Conformance WebExtension
        /// </summary>
        [Fact]
        public void WebExtensionAcceptance()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            TestDataStorage dataStorage = new TestDataStorage();
            var entries = dataStorage.GetEntries(TestDataStorage.DataGroups.O15ConformanceExcel).Where(e => e.FilePath.Contains(@"WebExtension\"));

            foreach (var entry in entries)
            {
                Log.BeginGroup(entry.FilePath);

                // Verify that OOXML SDK can read WebExtension Features
                this.VerifyReadWebExtension(entry.FilePath);

                // Verify that OOXML SDK can write WebExtension Elements
                string fixedId = "OSM Test - " + this.dayOfTest.ToString();
                this.VerifyWriteRead<WebExtensionPart>(entry.FilePath,
                                                        (wep) =>
                                                        {
                                                            Log.Comment("Fixing Reference ID to `{0}`", fixedId);
                                                            wep.WebExtension.WebExtensionStoreReference.Id = fixedId;
                                                        },
                                                        (wep) =>
                                                        {
                                                            Log.VerifyValue(wep.WebExtension.WebExtensionStoreReference.Id.ToString(), fixedId,
                                                            "Verifying Reference ID Value is still `{0}`", fixedId);
                                                        }
                                                    );


                // Verify that OOXML SDK can properly validate WebExtension Features
                this.VerifyValidator(entry.FilePath);

                // TODO: Once O15#2337510 is fixed, add a test to make sure MC works fine
                // this.VerifyMarkupCompatibility(entry)

                Log.EndGroup(entry.FilePath);
            }
        }

        /// <summary>
        /// OASys#283290: OOXML SDK : COMPS : Invalid format on WebExtension 
        /// </summary>
        [Fact]
        public void WebExtensionInvalidFormat()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());

            // Instanciating a DataStorage object to get test files
            TestDataStorage dataStorage = new TestDataStorage();

            // Get file information
            var entries = dataStorage.GetEntries(TestDataStorage.DataGroups.O15ConformanceExcel).Where(e => e.FilePath.Contains(@"WebExtension_Invalid\"));

            foreach (var entry in entries)
            {
                Log.BeginGroup(entry.FilePath);

                using (var package = SpreadsheetDocument.Open(entry.FilePath, false))
                {
                    // Instanciating a validator object for validating invalid documents
                    OpenXmlValidator validator = new OpenXmlValidator(FileFormatVersions.Office2013);

                    // Verify the number of validation errrors
                    Log.VerifyTrue(validator.Validate(package).Count() > 0, "Verifying the number of validation errors...Errors = {0}", validator.Validate(package).Count());

                    foreach (ValidationErrorInfo error in validator.Validate(package))
                    {
                        // Verify an error type
                        Log.VerifyTrue((error.ErrorType.ToString() == "Schema"), "Verifying an error type...");
                        Log.Comment("Error Type = " + error.ErrorType);
                        Log.Comment("Error Node = " + error.Node);
                        Log.Comment("Error Parth = " + error.Path);
                    }
                }

                Log.EndGroup(entry.FilePath);
            }
        }

        [Fact]
        public void WebExtensionFullyFledgedValidation()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());

            // create an Excel file containing a fully fledged WebExtension here:
            string filePath = Path.Combine(TestUtil.TestResultsDirectory, "WebExtensionFullFledgeValidation.xlsx");
            WebExtensionData gen = new WebExtensionData();
            gen.CreatePackage(filePath);

            Log.BeginGroup(filePath);

            // make sure the file created is valid
            this.VerifyValidator(filePath);

            // Verify that OOXML SDK can write WebExtension section
            this.VerifyWriteRead<WebExtensionPart>(filePath, (wep) => { WalkWep(wep, StringValueFixer, Int32ValueFixer); },
                                                                (wep) => { WalkWep(wep, StringValueChecker, Int32ValueChecker); });

            // Verify that OOXML SDK can write Taskpanes section
            this.VerifyWriteRead<Wetp.Taskpanes>(filePath, (tps) => { Walker_WebExtentionPane(tps, StringValueFixer, DoubleValueFixer, UInt32ValueFixer, BooleanValueFixer); },
                                                            (tps) => { Walker_WebExtentionPane(tps, StringValueChecker, DoubleValueChecker, UInt32ValueChecker, BooleanValueChecker); });
            Log.EndGroup(filePath);
        }


        #endregion

        #region Helper Functions

        #region Changing/Checking functions for StringValue, Int32Value, etc. values

        /// <summary>
        /// The delegate used to modify/validate a value. The same type is used to allow for uniform coding in the Walker_xxx functions
        /// </summary>
        /// <typeparam name="T">Type to be changed/validates</typeparam>
        /// <param name="iv">The current value</param>
        /// <returns></returns>
        delegate T TypedValueFoo<T>(T iv);

        // append the today's day: [1..31]
        private StringValue StringValueFixer(StringValue sv)
        {
            return sv + "_" + this.dayOfTest.ToString();
        }

        // make sure that today's day was appended
        private StringValue StringValueChecker(StringValue sv)
        {
            Log.VerifyTrue(sv.ToString().EndsWith("_" + this.dayOfTest.ToString()), "finding String signature in `{0}`", sv.ToString());

            return sv.ToString();
        }

        // modify the iv so that: (iv mod(13+dayOfTest) == 0)
        private Int32Value Int32ValueFixer(Int32Value iv)
        {
            int modulo = this.dayOfTest + 13;
            return iv + (modulo - iv % modulo);
        }

        // check that iv ahs the property: (iv mod(13+dayOfTest) == 0)
        private Int32Value Int32ValueChecker(Int32Value iv)
        {
            Log.VerifyTrue(0 == iv % (13 + this.dayOfTest), "finding Int32 signature in `{0}`", iv);

            return iv;
        }

        // very dumb ones
        private DoubleValue DoubleValueFixer(DoubleValue iv)
        {
            return new DoubleValue(this.dayOfTest / 100D);
        }

        private DoubleValue DoubleValueChecker(DoubleValue iv)
        {
            Log.VerifyTrue(iv.Value == DoubleValueFixer(0D).Value, "finding Double signature in `{0}`", iv);

            return iv;
        }

        private UInt32Value UInt32ValueFixer(UInt32Value iv)
        {
            return new UInt32Value((uint)(this.dayOfTest));
        }

        private UInt32Value UInt32ValueChecker(UInt32Value iv)
        {
            Log.VerifyTrue(this.dayOfTest == iv.Value, "finding UInt32 signature in `{0}`", iv);

            return iv;
        }

        private BooleanValue BooleanValueFixer(BooleanValue iv)
        {
            return 0 == this.dayOfTest % 2;
        }

        private BooleanValue BooleanValueChecker(BooleanValue iv)
        {
            Log.VerifyTrue(iv.Value == (0 == this.dayOfTest % 2), "finding Boolean signature in `{0}`", iv);

            return iv;
        }

        #endregion


        /// <summary>
        /// Walks the children of a Taskpanes element.
        /// </summary>
        /// <param name="tps"></param>
        /// <param name="svCallback"></param>
        /// <param name="dblCallback"></param>
        /// <param name="uint32Callback"></param>
        private void Walker_WebExtentionPane(Wetp.Taskpanes tps,
                                            TypedValueFoo<StringValue> svCallback, TypedValueFoo<DoubleValue> dblCallback,
                                            TypedValueFoo<UInt32Value> uint32Callback, TypedValueFoo<BooleanValue> boolCallback)
        {
            foreach (Wetp.WebExtensionTaskpane tp in tps.ChildElements)
            {
                tp.DockState = svCallback(tp.DockState);
                tp.Locked = boolCallback(tp.Locked);
                /// TODO: these are messy, let's do them later:
                /// OfficeArtExtensionList
                /// OsfWebExtensionPartRef
                tp.Row = uint32Callback(tp.Row);
                tp.Visibility = boolCallback(tp.Visibility);
                tp.Width = dblCallback(tp.Width);
            }
        }


        /// <summary>
        /// Walks the WebExtension element, invoking the delegates provided on all the Strings and Int32 values
        /// </summary>
        /// <param name="wep">WebExtensionPart the element to be walked</param>
        /// <param name="svCallback">StringValueFoo delegate to be called for StringValues</param>
        /// <param name="int32Callback">Int32ValueFoo delegate to be called for Int32Values</param>
        private void WalkWep(WebExtensionPart wep, TypedValueFoo<StringValue> svCallback, TypedValueFoo<Int32Value> int32Callback)
        {
            We.WebExtension we = wep.WebExtension;

            foreach (OpenXmlElement blipKid in we.Snapshot)
            {
                // Actually they say (obj.GetType() == typeof(ClassA)) is faster, but we are not in hurry here anyways
                if (blipKid is A.AlphaBiLevel)
                {
                    A.AlphaBiLevel abl = blipKid as A.AlphaBiLevel;
                    abl.Threshold = int32Callback(abl.Threshold);
                }
                else

                    if (blipKid is A.AlphaCeiling)
                    {
                    }
                    else

                        if (blipKid is A.AlphaFloor)
                        {
                        }
                        else

                            if (blipKid is A.BlipExtensionList)
                            {
                                A.BlipExtensionList bel = blipKid as A.BlipExtensionList;

                                foreach (A.BlipExtension be in bel)
                                {
                                    be.Uri = svCallback(be.Uri);

                                }
                                // it's possible to try and access the childs of be, but these are OpenXmlUnknownElement
                                // and it's not possible to modify them in an intelligent way.
                            }
            }

            we.Id = svCallback(we.Id);

            foreach (We.WebExtensionBinding binding in we.WebExtensionBindingList)
            {
                binding.AppReference = svCallback(binding.AppReference);
                binding.Id = svCallback(binding.Id);

                // UF: how about the Type?
            }

            foreach (We.WebExtensionProperty prop in we.WebExtensionPropertyBag)
            {
                prop.Name = svCallback(prop.Name);
                prop.Value = svCallback(prop.Value);
            }

            {
                We.WebExtensionStoreReference refr = we.WebExtensionStoreReference;

                refr.Id = svCallback(refr.Id);
                refr.Store = svCallback(refr.Store);
                refr.StoreType = svCallback(refr.StoreType);
                refr.Version = svCallback(refr.Version);
            }

            foreach (We.WebExtensionStoreReference refr in we.WebExtensionReferenceList)
            {
                refr.Id = svCallback(refr.Id);
                refr.Store = svCallback(refr.Store);
                refr.StoreType = svCallback(refr.StoreType);
                refr.Version = svCallback(refr.Version);
            }
        }


        /// <summary>
        /// Verify that OOXML SDK can read OOXML files containing MOE (WebExtension) feature
        /// </summary>
        /// <param name="entry">ITestData object for test file</param>
        private void VerifyReadWebExtension(string filePath)
        {
            // Get File Information object for the target test file
            FileInfo fi = GetTestFileOne(filePath).GetCopy();
            Log.VerifyNotNull(fi, "Test File is copied successfully.");

            using (OpenXmlPackage package = OpenXmlDomTestExtension.OpenPackage(fi, false))
            {
                Log.VerifyNotNull(package, "File is opened successfully.");

                var xl = package as SpreadsheetDocument;

                foreach (var wsPart in xl.WorkbookPart.WorksheetParts)
                {
                    // Try to get WebExtensionPart
                    foreach (WebExtensionPart we in wsPart.DrawingsPart.WebExtensionParts)
                    {
                        Log.VerifyValue(we.WebExtension.WebExtensionStoreReference.Version.ToString(), "1.0", "Verifying WebExtension.OsfWebExtensionReference.Version");
                        Log.VerifyValue(we.WebExtension.LocalName, "webextension", "Verifying WebExtension.LocalName");
                    }
                }
            }
        }

        delegate void WebExtentionPartHandler(WebExtensionPart wep);
        delegate void ElementHandler<T>(T wep);

        /// <summary>
        /// The template class to faclilitate the enumeration over the elemnts of different section of a SpreadsheetDocument.
        /// Currently supported types are:
        /// 1. WebExtensionPart
        /// 2. Wetp.Taskpanes
        /// </summary>
        /// <typeparam name="T">one of the types supported</typeparam>
        public class SectionFetcher<T> : IEnumerable
        {
            private SpreadsheetDocument xl;
            public SectionFetcher(SpreadsheetDocument xl)
            {
                this.xl = xl;
            }

            public IEnumerator GetEnumerator()
            {
                // surprisingly, this works too: typeof(T).IsAssignableFrom(typeof(WebExtensionPart))
                if (typeof(T) == typeof(WebExtensionPart))
                {
                    foreach (var wsPart in this.xl.WorkbookPart.WorksheetParts)
                    {
                        foreach (WebExtensionPart wep in wsPart.DrawingsPart.WebExtensionParts)
                        {
                            yield return wep;
                        }
                    }
                }

                if (typeof(T) == typeof(Wetp.Taskpanes))
                {
                    // technically speaking there is only one Taskpanes section in a document.
                    yield return this.xl.WebExTaskpanesPart.Taskpanes;
                }
            }
        }

        /// <summary>
        /// Verify that OOXML SDK can write and read T - a specific section of an Excel document.
        /// The function makes use of SectionFetcher<T> class to fetch a specific section from a spreadsheet.
        /// The functions
        /// 1. makes a copy of the original document
        /// 2. looks for the section specified
        /// 3. modifies it and closes the file
        /// 4. reopens the file and verifies that the section is modified in the expected way
        /// </summary>
        /// <typeparam name="T">the type which represents the section to be alternated</typeparam>
        /// <param name="filePath">name of the Excel document under test</param>
        /// <param name="elemFixer">a "section walker" function for modification</param>
        /// <param name="elemTester">a "section walker" function for validation the modifications made</param>
        private void VerifyWriteRead<T>(string filePath, ElementHandler<T> elemFixer, ElementHandler<T> elemTester)
        {
            // Get File Information object for the target test file
            FileInfo fi = GetTestFileOne(filePath).GetCopy();
            Log.VerifyNotNull(fi, "Test file is copied successfully into {0}", fi.FullName);

            // Open OOXML File with writable mode
            using (OpenXmlPackage package = OpenXmlDomTestExtension.OpenPackage(fi, true))
            {
                Log.VerifyNotNull(package, "The file is opened for writing");

                // Cast package to SpreadsheetDocument
                using (var xl = package as SpreadsheetDocument)
                {
                    foreach (T elem in new SectionFetcher<T>(xl))
                    {
                        elemFixer(elem);
                    }
                }
            }

            // Re-open the file just saved above with read-only mode
            using (OpenXmlPackage package = OpenXmlDomTestExtension.OpenPackage(fi, false))
            {
                Log.VerifyNotNull(package, "The file is re-opened read-only");

                using (var xl = package as SpreadsheetDocument)
                {
                    foreach (T elem in new SectionFetcher<T>(xl))
                    {
                        elemTester(elem);
                    }
                }
            }
        }


        /// <summary>
        /// Verify that OOXML SDK can properly validate an OOXML file
        /// </summary>
        /// <param name="filePath">filenae of the file under test</param>
        private void VerifyValidator(string filePath)
        {
            // Get File Information object for the target test file
            FileInfo fi = GetTestFileOne(filePath).GetCopy();
            Log.VerifyNotNull(fi, "Test File is copied successfully.");

            using (OpenXmlPackage package = OpenXmlDomTestExtension.OpenPackage(fi, true))
            {
                Log.VerifyNotNull(package, "File is opened successfully.");

                OpenXmlValidator validator = new OpenXmlValidator(FileFormatVersions.Office2013);

                // Verify the number of validation errrors
                Log.VerifyValue(validator.Validate(package).Count(), 0, "Verifying the number of validation errors...Errors = {0}", validator.Validate(package).Count());

                if (validator.Validate(package).Count() != 0)
                {
                    foreach (ValidationErrorInfo error in validator.Validate(package))
                    {
                        // List error information
                        Log.Comment("*** Error: {0}", error.Description);
                        Log.Comment("Type = " + error.ErrorType);
                        Log.Comment("Node = " + error.Node);
                        Log.Comment("Parth = " + error.Path);
                    }
                }
            }
        }
        #endregion
    }
}

