// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

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
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.Complex2005_12rtm, true))
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
                Assert.Equal((sbyte)100, v2);
                Assert.Equal("+100", t);
            }

            {
                var v = new Int16Value();
                v.InnerText = "+100";
                short v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Assert.Equal((short)100, v2);
                Assert.Equal("+100", t);
            }

            {
                var v = new Int32Value();
                v.InnerText = "+100";
                int v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Assert.Equal(100, v2);
                Assert.Equal("+100", t);
            }

            {
                var v = new IntegerValue();
                v.InnerText = "+100";
                long v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Assert.Equal(100L, v2);
                Assert.Equal("+100", t);
            }

            {
                var v = new DecimalValue();
                v.InnerText = "+100";
                decimal v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Assert.Equal(100M, v2);
                Assert.Equal("+100", t);
            }

            {
                var v = new SingleValue();
                v.InnerText = "+100";
                float v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Assert.Equal(100F, v2);
                Assert.Equal("+100", t);
            }

            {
                var v = new DoubleValue();
                v.InnerText = "+100";
                double v2 = v.Value;
                string t = v.InnerText;

                // Verify value and text
                Assert.Equal(100D, v2);
                Assert.Equal("+100", t);
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
            Assert.Equal(0.51200000000000001, v2);
            Assert.Equal("0.51200000000000001", t);
        }

        [Fact]
        public void ExceptionForDuplicatedNsDeclarionWhenClosePackage()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.ForTestCase.Bug571679_Brownbag, true))
            using (var package = PresentationDocument.Open(stream, true))
            {
                Output.WriteLine("Opening file that contains duplicated namespace declarations...");
                Output.WriteLine("Part that contains duplicated namespace declarations /ppt/diagrams/data3.xml.");

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

                var errors = validator.Validate(package, TestContext.Current.CancellationToken);

                Assert.Equal(expectedErrorCount, errors.Count());
            }
        }

        [Fact]
        public void ChangeRelationshipId()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.Complex2005_12rtm, true))
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

                Assert.Throws<ArgumentException>(() => container.ChangeIdOfPart(part, string.Empty));

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
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.Complex2005_12rtm, true))
            using (var package = WordprocessingDocument.Open(stream, true))
            {
                var part = package.DescendantParts().PickFirst(p => p.IsReflectable());

                using (OpenXmlReader reader = OpenXmlReader.Create(part))
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
            Output.WriteLine("Constructing a Paragraph with rawxml...");
            var rawxml = "<w:p w:rsidR=\"006B669D\" w:rsidRDefault=\"006B669D\" w:rsidP=\"006B669D\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" xmlns:myw=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" >\n"
                + "	<w12:r xmlns:w12=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" >\n"
                + "		<w:t xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" xml:space=\"preserve\">This is the text in this paragraph. </w:t>\n"
                + "	</w12:r>\n"
                + "</w:p>\n";

            Output.WriteLine(rawxml);
            var para = new DocumentFormat.OpenXml.Wordprocessing.Paragraph(rawxml);
            Assert.Equal(2, para.NamespaceDeclarations.Count());
            var run = para.FirstChild;
            Assert.Equal(1, run.NamespaceDeclarations.Count());
            Assert.Equal("w12", run.Prefix);
            Assert.Equal(run.NamespaceDeclarations.ElementAt(0).Value, run.NamespaceUri);
            Assert.Equal(run.NamespaceUri, para.NamespaceUri);
            var text = run.FirstChild;
            Assert.Equal(1, text.NamespaceDeclarations.Count());
            Assert.Equal("w", text.Prefix);
            Assert.Equal(text.NamespaceDeclarations.ElementAt(0).Value, text.NamespaceUri);
            Assert.Equal(text.NamespaceUri, run.NamespaceUri);
            Output.WriteLine("OuterXml of Paragraph:\n{0}", para.OuterXml);
        }

        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.Complex2005_12rtm)]
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

                    if (ns.Key is null)
                    {
                        ns = new KeyValuePair<string, string>(unknown.Prefix, unknown.NamespaceUri);
                    }

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
