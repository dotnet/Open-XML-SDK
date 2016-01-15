// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using Xunit;
using OxTest;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Generate list of type and associating (attribute/child element) properties for low-level testing.
    /// </summary>

    public class GenerateList4LowLevelTest : OpenXmlDomTestBase
    {
        [Fact]
        public void TestAutosaveAfterSettingNullRootElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault(f => f.IsWordprocessingFile());

            using (var pkg = testfile.OpenPackage(true /*writable*/, true /*auto-save*/))
            {
                WordprocessingDocument doc = pkg as WordprocessingDocument;
                Assert.NotNull(doc.MainDocumentPart);
                Assert.NotNull(doc.MainDocumentPart.Document);
                try
                {
                    doc.MainDocumentPart.Document = null;
                }
                catch (ArgumentNullException ex)
                {
                    Log.Pass("Caught expected exception.\n{0}", ex.ToString());
                }
            }

            using (var pkg = testfile.OpenPackage(false))
            {
                WordprocessingDocument doc = pkg as WordprocessingDocument;
                Assert.NotNull(doc.MainDocumentPart.Document);
            }
        }

        [Fact]
        // [Description("O14:537826")]
        public void TestRootElementOfVmlDrawingPartIsLoadedAsUnknown()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var file = CopyTestFiles(@"BugRegression", true, "537826.vmlpart.xlsx", f => f.IsSpreadsheetFile())
                .FirstOrDefault();

            using (var vmldoc = SpreadsheetDocument.Open(file.FullName, false))
            {
                var vmlDrawingPart = vmldoc.WorkbookPart.GetPartById("rId1").GetPartById("rId1");
                Assert.True(vmlDrawingPart is VmlDrawingPart);
                Assert.True(((VmlDrawingPart)vmlDrawingPart).RootElement == null);
                using (OpenXmlReader reader = OpenXmlReader.Create(vmlDrawingPart))
                {
                    reader.Read();
                    var elem = reader.LoadCurrentElement();
                    Log.VerifyTrue(elem is OpenXmlUnknownElement, "elem is OpenXmlUnknownElement");
                }
            }
        }

        [Fact]
        public void TestAssertInInnerTextForPlusSymbol()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());

            // same issue for SByteValue, Int16Value, IntegerValue, DecimalValue, SingleValue, DoubleValue
            {
                var v = new SByteValue();
                v.InnerText = "+100";
                sbyte v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Log.VerifyValue(v2, (sbyte)100, "{0}.Value", v.GetType().Name);
                Log.VerifyValue(t, "+100", "{0}.InnerText", v.GetType().Name);
            }

            {
                var v = new Int16Value();
                v.InnerText = "+100";
                Int16 v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Log.VerifyValue(v2, (Int16)100, "{0}.Value", v.GetType().Name);
                Log.VerifyValue(t, "+100", "{0}.InnerText", v.GetType().Name);
            }

            {
                var v = new Int32Value();
                v.InnerText = "+100";
                int v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Log.VerifyValue(v2, (int)100, "{0}.Value", v.GetType().Name);
                Log.VerifyValue(t, "+100", "{0}.InnerText", v.GetType().Name);
            }

            {
                var v = new IntegerValue();
                v.InnerText = "+100";
                long v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Log.VerifyValue(v2, (long)100, "{0}.Value", v.GetType().Name);
                Log.VerifyValue(t, "+100", "{0}.InnerText", v.GetType().Name);
            }

            {
                var v = new DecimalValue();
                v.InnerText = "+100";
                decimal v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Log.VerifyValue(v2, (decimal)100, "{0}.Value", v.GetType().Name);
                Log.VerifyValue(t, "+100", "{0}.InnerText", v.GetType().Name);
            }

            {
                var v = new SingleValue();
                v.InnerText = "+100";
                float v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Log.VerifyValue(v2, (float)100, "{0}.Value", v.GetType().Name);
                Log.VerifyValue(t, "+100", "{0}.InnerText", v.GetType().Name);
            }

            {
                var v = new DoubleValue();
                v.InnerText = "+100";
                double v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Log.VerifyValue(v2, (double)100, "{0}.Value", v.GetType().Name);
                Log.VerifyValue(t, "+100", "{0}.InnerText", v.GetType().Name);
            }

        }

        [Fact]
        public void TestAssertInInnerTextOfDoubleValue()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var v = new DoubleValue();
            v.InnerText = "0.51200000000000001";
            double v2 = v.Value;
            string t = v.InnerText;

            // Verify value and text
            Log.VerifyValue(v2, (double)0.51200000000000001, "{0}.Value", v.GetType().Name);
            Log.VerifyValue(t, "0.51200000000000001", "{0}.InnerText", v.GetType().Name);
        }

        [Fact]
        public void TwiceCallsToLoadAttributeOnUnknown()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var rawxml = @"<dgm14:cNvPr xmlns:dgm14=""http://schemas.microsoft.com/officeart/2007/7/20/diagram"" id=""0"" name="""" />";
            var ele = OpenXmlUnknownElement.CreateOpenXmlUnknownElement(rawxml);
            Log.VerifyTrue(ele.GetAttributes().Count == 2, "ele.GetAttributes().Count"); // The count should be 2 as now namespace declaration is not considered as attribute.
            Log.VerifyTrue(ele.OuterXml == rawxml, "ele.OuterXml");

            var clone = ele.Clone() as OpenXmlUnknownElement;
            Log.VerifyTrue(clone.GetAttributes().Count == 2, "clone.GetAttributes().Count");
            Log.VerifyTrue(clone.OuterXml == rawxml, "clone.OuterXml");
        }

        [Fact]
        public void ExceptionForDuplicatedNsDeclarionWhenClosePackage()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var file = CopyTestFiles(@"ForTestCase", true, "Bug571679_Brownbag.pptx", f => f.IsPresentationFile())
                .FirstOrDefault();

            Log.Comment("Opening file that contains duplicated namespace declarations...");
            Log.Comment("Part that contains duplciated namespace declarations /ppt/diagrams/data3.xml.");

            var result = file.CopyTo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx"));
            using (var package = result.OpenPackage(true, true))
            {
                foreach (var part in package.DescendantParts().Where(p => p.IsReflectable()))
                {
                    OpenXmlPartRootElement dom = part.RootElement;
                }
            }
            Log.Pass("No exception thrown out during loading and saving this file.");
        }

        [Fact]
        public void MaxNumberOfErrorsTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var file = CopyTestFiles(@"ForTestCase", true, "Bug539654_529755.xlsm", f => f.IsSpreadsheetFile())
                .FirstOrDefault();
            using (var package = file.OpenPackage(false))
            {
                var validator = new OpenXmlValidator(FileFormatVersions.Office2007);
                validator.MaxNumberOfErrors = 0;
                var errors = validator.Validate(package);
                Log.VerifyValue(errors.Count(), 3, "Validation error count");

                validator.MaxNumberOfErrors = 1;
                errors = validator.Validate(package);
                Log.VerifyValue(errors.Count(), 1, "Validation error count");

                validator.MaxNumberOfErrors = 2;
                errors = validator.Validate(package);
                Log.VerifyValue(errors.Count(), 2, "Validation error count");

                validator.MaxNumberOfErrors = 3;
                errors = validator.Validate(package);
                Log.VerifyValue(errors.Count(), 3, "Validation error count");

                validator.MaxNumberOfErrors = 10000;
                errors = validator.Validate(package);
                Log.VerifyValue(errors.Count(), 3, "Validation error count");
            }
        }

        [Fact]
        public void ChangeRelationshipId()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault().GetCopy();
            using (var package = testfile.OpenPackage(true, true))
            {
                var container = package.DescendantParts().PickFirst(pc => pc.Parts.Count() > 1);
                var target = container.Parts.PickSecond();
                var part = target.OpenXmlPart;
                try
                {
                    var oldId = container.GetIdOfPart(part);
                    var retId = container.ChangeIdOfPart(part, null);
                }
                catch (ArgumentNullException ex)
                {
                    Log.Pass("Expected {0} caught when changing Id of Part {1} with Id null.", ex.GetType().FullName, part.Uri);
                }
                try
                {
                    var oldId = container.GetIdOfPart(part);
                    var retId = container.ChangeIdOfPart(null, "newId");
                }
                catch (ArgumentNullException ex)
                {
                    Log.Pass("Expected {0} caught when changing Id of Part {1} with Part null.", ex.GetType().FullName, part.Uri);
                }
                try
                {
                    var nonSubPart = container;
                    var retId = container.ChangeIdOfPart(nonSubPart, "newId");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Log.Pass("Expected {0} caught when changing Id of Part {1} with Non-SubPart.", ex.GetType().FullName, part.Uri);
                }
                try
                {
                    var oldId = container.GetIdOfPart(part);
                    var retId = container.ChangeIdOfPart(part, string.Empty);
                }
                catch (System.ArgumentException ex)
                {
                    Log.Pass("Expected {0} caught when changing Id of Part {1} with string.Empty.", ex.GetType().FullName, part.Uri);
                }

                try
                {
                    var oldId = container.GetIdOfPart(part);
                    var retId = container.ChangeIdOfPart(part, oldId);
                }
                catch (System.ArgumentException ex)
                {
                    Log.Pass("Expected {0} caught when changing Id of Part {1} with old value.", ex.GetType().FullName, part.Uri);
                }

                try
                {
                    var oldId = container.GetIdOfPart(part);
                    var newId = "newId1";
                    var retId = container.ChangeIdOfPart(part, newId);
                }
                catch (Exception ex)
                {
                    Log.Fail("Exception {0} caught when changing Id of Part {1}: {2}", ex.GetType().FullName, part.Uri, ex.ToString());
                }

                try
                {
                    var oldId = container.GetIdOfPart(part);
                    var dupId = container.Parts.Where(p => p.RelationshipId != oldId).Select(p => p.RelationshipId).FirstOrDefault();
                    var retId = container.ChangeIdOfPart(part, dupId);
                }
                catch (System.ArgumentException ex)
                {
                    Log.Pass("Expected {0} caught when changing Id of Part {1} with duplicated value.", ex.GetType().FullName, part.Uri);
                }
            }
        }

        [Fact]
        public void LoadCurrentElementTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt");
            var testfile = testfiles.FirstOrDefault().GetCopy();
            using (var package = testfile.OpenPackage(true, true))
            {
                var part = package.DescendantParts().PickFirst(p => p.IsReflectable());
                using (OpenXmlReader reader = OpenXmlReader.Create(part as OpenXmlPart))
                {
                    if (reader.Read())
                    {
                        var rootElement = reader.LoadCurrentElement(); // This line made the exception thrown.
                    }
                }
            }
            Log.Pass("No exception thrown out for OpenXmlReader.LoadCurrentElement().");
        }

        [Fact]
        public void LoadParagraphWithRedefinedPrefixTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            Log.Comment("Constructing a Paragraph with rawxml...");
            var rawxml = "<w:p w:rsidR=\"006B669D\" w:rsidRDefault=\"006B669D\" w:rsidP=\"006B669D\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" xmlns:myw=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" >\n"
                + "	<w12:r xmlns:w12=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" >\n"
                + "		<w:t xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" xml:space=\"preserve\">This is the text in this paragraph. </w:t>\n"
                + "	</w12:r>\n"
                + "</w:p>\n";

            Log.Comment(rawxml);
            var para = new DocumentFormat.OpenXml.Wordprocessing.Paragraph(rawxml);
            Log.VerifyValue(para.NamespaceDeclarations.Count(), 2, "Count of returned Namespace Declarations does NOT match expectation.");
            var run = para.FirstChild;
            Log.VerifyValue(run.NamespaceDeclarations.Count(), 1, "Count of returned Namespace Declarations does NOT match expectation.");
            Log.VerifyValue(run.Prefix, "w12", "Unexpected prefix returned for the Run.");
            Log.VerifyValue(run.NamespaceUri, run.NamespaceDeclarations.ElementAt(0).Value, "NamespaceUri does NOT match declarations on itself.");
            Log.VerifyValue(para.NamespaceUri, run.NamespaceUri, "NamespaceUri of Run does NOT match Paragraph.");
            var text = run.FirstChild;
            Log.VerifyValue(text.NamespaceDeclarations.Count(), 1, "Count of returned Namespace Declarations does NOT match expectation.");
            Log.VerifyValue(text.Prefix, "w", "Unexpected prefix returned for the Text.");
            Log.VerifyValue(text.NamespaceUri, text.NamespaceDeclarations.ElementAt(0).Value, "NamespaceUri does NOT match declarations on itself.");
            Log.VerifyValue(run.NamespaceUri, text.NamespaceUri, "NamespaceUri of Text does NOT match Run.");
            Log.Comment("OuterXml of Paragraph:\n{0}", para.OuterXml);
        }

        [Fact]
        public void NamespaceDeclarationForNewUnknownElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            var testfiles = CopyTestFiles(@"bvt")
                .Where(fi => fi.IsOpenXmlFile());

            System.Uri partUri;
            string hostPath;
            var prefix = "uns";
            var localname = "unknownEle";
            var namespaceUri = @"http://test.openxmlsdk.microsoft.com/unknownns1";
            foreach (FileInfo testfile in testfiles)
            {
                Log.BeginGroup(testfile.Name);

                using (var package = testfile.OpenPackage(true, true))
                {
                    var part = package.DescendantParts().Where(p => p.IsReflectable()).FirstOrDefault();
                    partUri = part.Uri;
                    var dom = part.RootElement;
                    var host = dom.Descendants<OpenXmlCompositeElement>().PickSecond();
                    hostPath = host.Path();

                    var unknown = new OpenXmlUnknownElement(prefix, localname, namespaceUri);
                    unknown = host.AppendChild(unknown);
                    KeyValuePair<string, string> ns = unknown.NamespaceDeclarations.Where(kvp => kvp.Key == prefix && kvp.Value == namespaceUri).FirstOrDefault();
                    if (ns.Key == null)
                        ns = new KeyValuePair<string, string>(unknown.Prefix, unknown.NamespaceUri);

                    Log.VerifyTrue(ns.Key == prefix && ns.Value == namespaceUri, "NO namespace declarations matches found.");
                }

                using (var package = testfile.OpenPackage(false, false))
                {
                    var part = package.DescendantParts().Where(p => p.IsReflectable() && p.Uri == partUri).FirstOrDefault();
                    var dom = part.RootElement;
                    var host = dom.Descendants<OpenXmlCompositeElement>().Where(d => d.Path() == hostPath).FirstOrDefault();

                    var unknown = host.LastChild;
                    var ns = unknown.NamespaceDeclarations.Where(kvp => kvp.Key == prefix && kvp.Value == namespaceUri);
                    Log.VerifyTrue(ns.FirstOrDefault().Key == prefix && ns.FirstOrDefault().Value == namespaceUri, "NO namespace declarations matches found.");
                }
            }
        }
    }
}