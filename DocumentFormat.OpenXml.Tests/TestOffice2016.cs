// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System.Linq;
using System.Text;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class TestOffice2016
    {
        [Theory]
        [InlineData("Of16-10-SymEx.docx")]
        public void OF16_007_SymEx(string name)
        {
            using (var stream = TestFileStreams.GetStream(name))
            using (var wDoc = WordprocessingDocument.Open(stream, false))
            {
                var v = new OpenXmlValidator(FileFormatVersions.Office2016);
                var errors = v.Validate(wDoc);

                Assert.Empty(errors);
            }
        }

        [Theory]
        [InlineData("Of16-09-UnknownElement.docx")]
        public void OF16_006_AccessChartPart_IntentionalUnknownElement(string name)
        {
            using (var stream = TestFileStreams.GetStream(name))
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
        [InlineData("Of16-01.docx")]
        [InlineData("Of16-02.docx")]
        [InlineData("Of16-03.docx")]
        [InlineData("Of16-04.docx")]
        [InlineData("Of16-05.docx")]
        [InlineData("Of16-06.docx")]
        [InlineData("Of16-07.docx")]
        public void OF16_005_AccessChartPart(string name)
        {
            using (var stream = TestFileStreams.GetStream(name))
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
        [InlineData("Of16-01.pptx")]
        [InlineData("Of16-02.pptx")]
        [InlineData("Of16-03.pptx")]

        public void OF16_004_ValidatePptx_2013(string name)
        {
            using (var stream = TestFileStreams.GetStream(name))
            using (var pDoc = PresentationDocument.Open(stream, false))
            {
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errors = v.Validate(pDoc);

                Assert.Empty(errors);
            }
        }

        [Theory]
        [InlineData("Of16-01.docx")]
        [InlineData("Of16-02.docx")]
        [InlineData("Of16-03.docx")]
        [InlineData("Of16-04.docx")]
        [InlineData("Of16-05.docx")]
        [InlineData("Of16-06.docx")]
        [InlineData("Of16-07.docx")]
        [InlineData("Of16-08.docx")]

        public void OF16_003_ValidateDocx_2013(string name)
        {
            using (var stream = TestFileStreams.GetStream(name))
            using (var wDoc = WordprocessingDocument.Open(stream, false))
            {
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errors = v.Validate(wDoc);

                Assert.Empty(errors);
            }
        }

        [Theory]
        [InlineData("Of16-01.pptx")]
        [InlineData("Of16-02.pptx")]
        [InlineData("Of16-03.pptx")]

        public void OF16_002_ValidatePptx_2016(string name)
        {
            using (var stream = TestFileStreams.GetStream(name))
            using (var pDoc = PresentationDocument.Open(stream, false))
            {
                var v = new OpenXmlValidator(FileFormatVersions.Office2016);
                var errors = v.Validate(pDoc);

                Assert.Empty(errors);
            }
        }

        [Theory]
        [InlineData("Of16-01.docx")]
        [InlineData("Of16-02.docx")]
        [InlineData("Of16-03.docx")]
        [InlineData("Of16-04.docx")]
        [InlineData("Of16-05.docx")]
        [InlineData("Of16-06.docx")]
        [InlineData("Of16-07.docx")]
        [InlineData("Of16-08.docx")]

        public void OF16_001_ValidateDocx_2016(string name)
        {
            using (var stream = TestFileStreams.GetStream(name))
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
