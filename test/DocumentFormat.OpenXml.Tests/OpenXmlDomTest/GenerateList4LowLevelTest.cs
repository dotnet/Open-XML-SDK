// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Generate list of type and associating (attribute/child element) properties for low-level testing.
    /// </summary>
    public class GenerateList4LowLevelTest : OpenXmlDomTestBase
    {
        public GenerateList4LowLevelTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void TestAutosaveAfterSettingNullRootElement()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            {
                using (var doc = WordprocessingDocument.Open(stream, true))
                {
                    Assert.NotNull(doc.MainDocumentPart);
                    Assert.NotNull(doc.MainDocumentPart.Document);
                    Assert.Throws<ArgumentNullException>(() => doc.MainDocumentPart.Document = null);
                }

                using (var doc = WordprocessingDocument.Open(stream, true))
                {
                    Assert.NotNull(doc.MainDocumentPart.Document);
                }
            }
        }

        [Fact]

        // [Description("O14:537826")]
        public void TestRootElementOfVmlDrawingPartIsLoadedAsUnknown()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.BugRegression._537826vmlpart))
            using (var vmldoc = SpreadsheetDocument.Open(stream, false))
            {
                var vmlDrawingPart = vmldoc.WorkbookPart.GetPartById("rId1").GetPartById("rId1");
                var vmlPart = Assert.IsType<VmlDrawingPart>(vmlDrawingPart);

                Assert.Null(vmlPart.RootElement);

                using (var reader = OpenXmlReader.Create(vmlDrawingPart))
                {
                    Assert.True(reader.Read());
                    Assert.IsType<OpenXmlUnknownElement>(reader.LoadCurrentElement());
                }
            }
        }

        [Fact]
        public void TestAssertInInnerTextForPlusSymbol()
        {
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
                short v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Log.VerifyValue(v2, (short)100, "{0}.Value", v.GetType().Name);
                Log.VerifyValue(t, "+100", "{0}.InnerText", v.GetType().Name);
            }

            {
                var v = new Int32Value();
                v.InnerText = "+100";
                int v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Log.VerifyValue(v2, 100, "{0}.Value", v.GetType().Name);
                Log.VerifyValue(t, "+100", "{0}.InnerText", v.GetType().Name);
            }

            {
                var v = new IntegerValue();
                v.InnerText = "+100";
                long v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Log.VerifyValue(v2, 100L, "{0}.Value", v.GetType().Name);
                Log.VerifyValue(t, "+100", "{0}.InnerText", v.GetType().Name);
            }

            {
                var v = new DecimalValue();
                v.InnerText = "+100";
                decimal v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Log.VerifyValue(v2, 100M, "{0}.Value", v.GetType().Name);
                Log.VerifyValue(t, "+100", "{0}.InnerText", v.GetType().Name);
            }

            {
                var v = new SingleValue();
                v.InnerText = "+100";
                float v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Log.VerifyValue(v2, 100F, "{0}.Value", v.GetType().Name);
                Log.VerifyValue(t, "+100", "{0}.InnerText", v.GetType().Name);
            }

            {
                var v = new DoubleValue();
                v.InnerText = "+100";
                double v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Log.VerifyValue(v2, 100D, "{0}.Value", v.GetType().Name);
                Log.VerifyValue(t, "+100", "{0}.InnerText", v.GetType().Name);
            }
        }

        [Fact]
        public void TestAssertInInnerTextOfDoubleValue()
        {
            var v = new DoubleValue();
            v.InnerText = "0.51200000000000001";
            double v2 = v.Value;
            string t = v.InnerText;

            // Verify value and text
            Log.VerifyValue(v2, 0.51200000000000001, "{0}.Value", v.GetType().Name);
            Log.VerifyValue(t, "0.51200000000000001", "{0}.InnerText", v.GetType().Name);
        }

        [Fact]
        public void TwiceCallsToLoadAttributeOnUnknown()
        {
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
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.ForTestCase.Bug571679_Brownbag, true))
            using (var package = PresentationDocument.Open(stream, true))
            {
                Log.Comment("Opening file that contains duplicated namespace declarations...");
                Log.Comment("Part that contains duplicated namespace declarations /ppt/diagrams/data3.xml.");

                foreach (var part in package.DescendantParts().Where(p => p.IsReflectable()))
                {
                    Assert.NotNull(part.RootElement);
                }
            }
        }

        [Theory]
        [InlineData(0, 3)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(1000, 3)]
        public void MaxNumberOfErrorsTest(int maxErrorCount, int expectedErrorCount)
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.ForTestCase.Bug539654_529755))
            using (var package = SpreadsheetDocument.Open(stream, false))
            {
                var validator = new OpenXmlValidator(FileFormatVersions.Office2007)
                {
                    MaxNumberOfErrors = maxErrorCount,
                };

                var errors = validator.Validate(package);

                Assert.Equal(expectedErrorCount, errors.Count());
            }
        }

        [Fact]
        public void ChangeRelationshipId()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            using (var package = WordprocessingDocument.Open(stream, true))
            {
                var container = package.DescendantParts().PickFirst(pc => pc.Parts.Count() > 1);
                var target = container.Parts.PickSecond();
                var part = target.OpenXmlPart;

                Assert.NotNull(container.GetIdOfPart(part));
                Assert.Throws<ArgumentNullException>(() => container.ChangeIdOfPart(part, null));

                Assert.NotNull(container.GetIdOfPart(part));
                Assert.Throws<ArgumentNullException>(() => container.ChangeIdOfPart(null, "newId"));

                // Change Id of Part } with Non-SubPart.
                Assert.Throws<ArgumentOutOfRangeException>(() => container.ChangeIdOfPart(container, "newId"));

                // TODO: Should throw ArgumentException and not ArgumentNullException
                //Assert.Throws<ArgumentException>(() => container.ChangeIdOfPart(part, string.Empty));
                Assert.Throws<ArgumentNullException>(() => container.ChangeIdOfPart(part, string.Empty));

                var oldId1 = container.GetIdOfPart(part);
                Assert.NotNull(oldId1);
                Assert.Throws<ArgumentException>(() => container.ChangeIdOfPart(part, oldId1));

                var newId1 = "newId1";
                Assert.Equal(oldId1, container.ChangeIdOfPart(part, newId1));

                var oldId2 = container.GetIdOfPart(part);
                Assert.Equal(newId1, oldId2);

                var dupId = container.Parts.Where(p => p.RelationshipId != oldId2).Select(p => p.RelationshipId).FirstOrDefault();
                Assert.Throws<ArgumentException>(() => container.ChangeIdOfPart(part, dupId));
            }
        }

        [Fact]
        public void LoadCurrentElementTest()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true))
            using (var package = WordprocessingDocument.Open(stream, true))
            {
                var part = package.DescendantParts().PickFirst(p => p.IsReflectable());

                using (OpenXmlReader reader = OpenXmlReader.Create(part as OpenXmlPart))
                {
                    if (reader.Read())
                    {
                        Assert.NotNull(reader.LoadCurrentElement());
                    }
                }
            }
        }

        [Fact]
        public void LoadParagraphWithRedefinedPrefixTest()
        {
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

        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.O12Typical)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng)]
        [Theory]
        public void NamespaceDeclarationForNewUnknownElement(string path)
        {
            Uri partUri;
            string hostPath;
            var prefix = "uns";
            var localname = "unknownEle";
            var namespaceUri = @"http://test.openxmlsdk.microsoft.com/unknownns1";

            using (var testfile = OpenFile(path, true))
            {
                using (var package = testfile.Open(true))
                {
                    var part = package.DescendantParts().Where(p => p.IsReflectable()).FirstOrDefault();
                    partUri = part.Uri;
                    var dom = part.RootElement;
                    var host = dom.Descendants<OpenXmlCompositeElement>().PickSecond();
                    hostPath = host.Path();

                    var unknown = new OpenXmlUnknownElement(prefix, localname, namespaceUri);
                    unknown = host.AppendChild(unknown);
                    var ns = unknown.NamespaceDeclarations.Where(kvp => kvp.Key == prefix && kvp.Value == namespaceUri).FirstOrDefault();

                    if (ns.Key == null)
                        ns = new KeyValuePair<string, string>(unknown.Prefix, unknown.NamespaceUri);

                    Assert.Equal(prefix, ns.Key);
                    Assert.Equal(namespaceUri, ns.Value);
                }

                using (var package = testfile.Open(false))
                {
                    var part = package.DescendantParts().Where(p => p.IsReflectable() && p.Uri == partUri).FirstOrDefault();
                    var dom = part.RootElement;
                    var host = dom.Descendants<OpenXmlCompositeElement>().Where(d => d.Path() == hostPath).FirstOrDefault();

                    var unknown = host.LastChild;
                    var ns = unknown.NamespaceDeclarations.Where(kvp => kvp.Key == prefix && kvp.Value == namespaceUri);

                    Assert.Equal(prefix, ns.FirstOrDefault().Key);
                    Assert.Equal(namespaceUri, ns.FirstOrDefault().Value);
                }
            }
        }
    }
}
