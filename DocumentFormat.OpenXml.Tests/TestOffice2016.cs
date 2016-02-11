// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using Xunit;
using P = DocumentFormat.OpenXml.Presentation;
using S = DocumentFormat.OpenXml.Spreadsheet;
using W = DocumentFormat.OpenXml.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;
using OpenXmlPowerTools;
using OxTest;
using System.Text;

namespace DocumentFormat.OpenXml.Tests
{
    public class TestOffice2016
    {
        [Theory]
        [InlineData("Of16-10-SymEx.docx", 0, 0)]
        public void OF16_007_SymEx(string name, int expectedErrorCount, int expectedErrorCount2)
        {
            var orig = new FileInfo(Path.Combine(TestUtil.TestFilesDir, name));
            using (WordprocessingDocument wDoc = WordprocessingDocument.Open(orig.FullName, false))
            {
                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2016);
                var errs = v.Validate(wDoc);
                var cnt = errs.Count();
                Assert.True(cnt == expectedErrorCount || cnt == expectedErrorCount2);
            }
        }

        [Theory]
        [InlineData("Of16-09-UnknownElement.docx")]
        public void OF16_006_AccessChartPart_IntentionalUnknownElement(string name)
        {
            var orig = new FileInfo(Path.Combine(TestUtil.TestFilesDir, name));
            using (WordprocessingDocument wDoc = WordprocessingDocument.Open(orig.FullName, false))
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
            var orig = new FileInfo(Path.Combine(TestUtil.TestFilesDir, name));
            using (WordprocessingDocument wDoc = WordprocessingDocument.Open(orig.FullName, false))
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

        private static string DumpOpenXmlObjectTree(DocumentFormat.OpenXml.OpenXmlElement element)
        {
            StringBuilder sb = new StringBuilder();
            DumpOpenXmlObjectTreeRecursive(element, sb);
            return sb.ToString();

        }

        private static void DumpOpenXmlObjectTreeRecursive(DocumentFormat.OpenXml.OpenXmlElement element, StringBuilder sb)
        {
            int depth = element.Ancestors().Count();
            var dStr = "".PadRight(depth * 2);
            var nStr = element.GetType().FullName;
            sb.Append(dStr + nStr + Environment.NewLine);
            foreach (var item in element.Elements())
                DumpOpenXmlObjectTreeRecursive(item, sb);
        }

        [Theory]
        [InlineData("Of16-01.pptx", 0, 0)]
        [InlineData("Of16-02.pptx", 0, 0)]
        [InlineData("Of16-03.pptx", 0, 0)]

        public void OF16_004_ValidatePptx_2013(string name, int expectedErrorCount, int expectedErrorCount2)
        {
            var orig = new FileInfo(Path.Combine(TestUtil.TestFilesDir, name));
            using (PresentationDocument pDoc = PresentationDocument.Open(orig.FullName, false))
            {
                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(pDoc);
                var cnt = errs.Count();
                Assert.True(cnt == expectedErrorCount || cnt == expectedErrorCount2);
            }
        }

        [Theory]
        [InlineData("Of16-01.docx", 0, 0)]
        [InlineData("Of16-02.docx", 0, 0)]
        [InlineData("Of16-03.docx", 0, 0)]
        [InlineData("Of16-04.docx", 0, 0)]
        [InlineData("Of16-05.docx", 0, 0)]
        [InlineData("Of16-06.docx", 0, 0)]
        [InlineData("Of16-07.docx", 0, 0)]
        [InlineData("Of16-08.docx", 0, 0)]

        public void OF16_003_ValidateDocx_2013(string name, int expectedErrorCount, int expectedErrorCount2)
        {
            var orig = new FileInfo(Path.Combine(TestUtil.TestFilesDir, name));
            using (WordprocessingDocument wDoc = WordprocessingDocument.Open(orig.FullName, false))
            {
                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(wDoc);
                var cnt = errs.Count();
                Assert.True(cnt == expectedErrorCount || cnt == expectedErrorCount2);
            }
        }

        [Theory]
        [InlineData("Of16-01.pptx", 0, 0)]
        [InlineData("Of16-02.pptx", 0, 0)]
        [InlineData("Of16-03.pptx", 0, 0)]

        public void OF16_002_ValidatePptx_2016(string name, int expectedErrorCount, int expectedErrorCount2)
        {
            var orig = new FileInfo(Path.Combine(TestUtil.TestFilesDir, name));
            using (PresentationDocument pDoc = PresentationDocument.Open(orig.FullName, false))
            {
                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2016);
                var errs = v.Validate(pDoc);
                var cnt = errs.Count();
                Assert.True(cnt == expectedErrorCount || cnt == expectedErrorCount2);
            }
        }

        [Theory]
        [InlineData("Of16-01.docx", 0, 0)]
        [InlineData("Of16-02.docx", 0, 0)]
        [InlineData("Of16-03.docx", 0, 0)]
        [InlineData("Of16-04.docx", 0, 0)]
        [InlineData("Of16-05.docx", 0, 0)]
        [InlineData("Of16-06.docx", 0, 0)]
        [InlineData("Of16-07.docx", 0, 0)]
        [InlineData("Of16-08.docx", 0, 0)]

        public void OF16_001_ValidateDocx_2016(string name, int expectedErrorCount, int expectedErrorCount2)
        {
            var orig = new FileInfo(Path.Combine(TestUtil.TestFilesDir, name));
            using (WordprocessingDocument wDoc = WordprocessingDocument.Open(orig.FullName, false))
            {
                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2016);
                var errs = v.Validate(wDoc);
                var cnt = errs.Count();
                Assert.True(cnt == expectedErrorCount || cnt == expectedErrorCount2);
            }
        }
    }
}
