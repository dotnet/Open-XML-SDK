// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System.Linq;
using System.Text;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    public class TestOffice2016
    {
        [Theory]
        [InlineData(TestFiles.Of16_10_symex_docx)]
        public void OF16_007_SymEx(string name)
        {
            using (var stream = GetStream(name))
            using (var wDoc = WordprocessingDocument.Open(stream, false))
            {
                var v = new OpenXmlValidator(FileFormatVersions.Office2016);
                var errors = v.Validate(wDoc);

                Assert.Empty(errors);
            }
        }

        [Theory]
        [InlineData(TestFiles.Of16_09_unknownelement_docx)]
        public void OF16_006_AccessChartPart_IntentionalUnknownElement(string name)
        {
            using (var stream = GetStream(name))
            using (var wDoc = WordprocessingDocument.Open(stream, false))
            {
                var mainDocPart = wDoc.MainDocumentPart;
                var extChartPart = mainDocPart.ExtendedChartParts.First();
                var chartSpace = extChartPart.ChartSpace;

                Assert.Equal("DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace", chartSpace.GetType().ToString());

                var hasUnknownElement = TestIfHasUnknownElement(chartSpace);
                if (hasUnknownElement)
                {
                    var s = DumpOpenXmlObjectTree(chartSpace);
                    Assert.NotEqual("HasUnknownElement", s); // if UnknownElement were not expected, this would fail.  s contains dump of the object graph
                }
            }
        }

        [Theory]
        [InlineData(TestFiles.Of16_01_docx)]
        [InlineData(TestFiles.Of16_02_docx)]
        [InlineData(TestFiles.Of16_03_docx)]
        [InlineData(TestFiles.Of16_04_docx)]
        [InlineData(TestFiles.Of16_05_docx)]
        [InlineData(TestFiles.Of16_06_docx)]
        [InlineData(TestFiles.Of16_07_docx)]
        public void OF16_005_AccessChartPart(string name)
        {
            using (var stream = GetStream(name))
            using (var wDoc = WordprocessingDocument.Open(stream, false))
            {
                var mainDocPart = wDoc.MainDocumentPart;
                var extChartPart = mainDocPart.ExtendedChartParts.First();
                var chartSpace = extChartPart.ChartSpace;
                Assert.Equal("DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace", chartSpace.GetType().ToString());
                var hasUnknownElement = TestIfHasUnknownElement(chartSpace);
                if (hasUnknownElement)
                {
                    var s = DumpOpenXmlObjectTree(chartSpace);
                    Assert.Equal("HasUnknownElement", s); // this will fail.  s contains a dump of the object graph
                }
            }
        }

        [Theory]
        [InlineData(TestFiles.Of16_01_pptx)]
        [InlineData(TestFiles.Of16_02_pptx)]
        [InlineData(TestFiles.Of16_03_pptx)]

        public void OF16_004_ValidatePptx_2013(string name)
        {
            using (var stream = GetStream(name))
            using (var pDoc = PresentationDocument.Open(stream, false))
            {
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errors = v.Validate(pDoc);

                Assert.Empty(errors);
            }
        }

        [Theory]
        [InlineData(TestFiles.Of16_01_docx)]
        [InlineData(TestFiles.Of16_02_docx)]
        [InlineData(TestFiles.Of16_03_docx)]
        [InlineData(TestFiles.Of16_04_docx)]
        [InlineData(TestFiles.Of16_05_docx)]
        [InlineData(TestFiles.Of16_06_docx)]
        [InlineData(TestFiles.Of16_07_docx)]
        [InlineData(TestFiles.Of16_08_docx)]

        public void OF16_003_ValidateDocx_2013(string name)
        {
            using (var stream = GetStream(name))
            using (var wDoc = WordprocessingDocument.Open(stream, false))
            {
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errors = v.Validate(wDoc);

                Assert.Empty(errors);
            }
        }

        [Theory]
        [InlineData(TestFiles.Of16_01_pptx)]
        [InlineData(TestFiles.Of16_02_pptx)]
        [InlineData(TestFiles.Of16_03_pptx)]

        public void OF16_002_ValidatePptx_2016(string name)
        {
            using (var stream = GetStream(name))
            using (var pDoc = PresentationDocument.Open(stream, false))
            {
                var v = new OpenXmlValidator(FileFormatVersions.Office2016);
                var errors = v.Validate(pDoc);

                Assert.Empty(errors);
            }
        }

        [Theory]
        [InlineData(TestFiles.Of16_01_docx)]
        [InlineData(TestFiles.Of16_02_docx)]
        [InlineData(TestFiles.Of16_03_docx)]
        [InlineData(TestFiles.Of16_04_docx)]
        [InlineData(TestFiles.Of16_05_docx)]
        [InlineData(TestFiles.Of16_06_docx)]
        [InlineData(TestFiles.Of16_07_docx)]
        [InlineData(TestFiles.Of16_08_docx)]

        public void OF16_001_ValidateDocx_2016(string name)
        {
            using (var stream = GetStream(name))
            using (var wDoc = WordprocessingDocument.Open(stream, false))
            {
                var v = new OpenXmlValidator(FileFormatVersions.Office2016);
                var errors = v.Validate(wDoc);

                Assert.Empty(errors);
            }
        }

        private bool TestIfHasUnknownElement(OpenXmlElement element)
        {
            if (element.GetType().ToString().Contains("OpenXmlUnknownElement"))
                return true;
            foreach (var item in element.Elements())
            {
                if (TestIfHasUnknownElement(item))
                    return true;
            }
            return false;
        }

        private static string DumpOpenXmlObjectTree(OpenXmlElement startElement)
        {
            void DumpOpenXmlObjectTreeRecursive(OpenXmlElement element, StringBuilder sb)
            {
                var depth = element.Ancestors().Count();

                sb.Append(string.Empty.PadRight(depth * 2));
                sb.AppendLine(element.GetType().FullName);

                foreach (var item in element.Elements())
                {
                    DumpOpenXmlObjectTreeRecursive(item, sb);
                }
            }

            var result = new StringBuilder();

            DumpOpenXmlObjectTreeRecursive(startElement, result);

            return result.ToString();
        }
    }
}
