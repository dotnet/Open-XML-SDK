// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Linq;
using System.Reflection;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Summary description for CustomXmlElementTest
    /// </summary>
    public class CustomXmlElementTest
    {
        private string uri = "urn:customXmlSample";
        private string element = "elementName";

        ///<summary>
        ///CustomXmlElementTests.
        ///</summary>
        [Fact]
        public void CustomXmlElementTests()
        {
            Type baseType = typeof(CustomXmlElement);
            Assert.True(baseType.GetTypeInfo().IsAbstract);

            // CustomXmlRuby
            CustomXmlRuby cxRuby = new CustomXmlRuby();
            ValidateCustomXmlElement(cxRuby);

            // CustomXmlBlock
            CustomXmlBlock cxBlock = new CustomXmlBlock();
            ValidateCustomXmlElement(cxBlock);

            // CustomXmlRow
            CustomXmlRow cxRow = new CustomXmlRow();
            ValidateCustomXmlElement(cxRow);

            // CustomXmlRun
            CustomXmlRun cxRun = new CustomXmlRun();
            ValidateCustomXmlElement(cxRun);

            // CustomXmlCell
            CustomXmlCell cxCell = new CustomXmlCell();
            ValidateCustomXmlElement(cxCell);

            // Test loading and modification on DOM tree
            using (var stream = GetStream(TestFiles.simpleSdt))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                // find customXml
                var customXml = doc.MainDocumentPart.Document.Descendants<CustomXmlRun>().First();
                Assert.Equal("firstName", customXml.Element.Value);
                Assert.Null(customXml.Uri);
                Assert.Equal(typeof(Run), customXml.FirstChild.GetType());
                customXml.Uri = "urn:sampleUri";
                customXml.Append(new Hyperlink());
                Assert.Equal(2, customXml.ChildElements.Count);
            }
        }

        private void ValidateCustomXmlElement(CustomXmlElement e)
        {
            e.Uri = uri;
            e.Element = element;
            Assert.NotNull(e.Uri);
            Assert.Equal(typeof(StringValue), e.Uri.GetType());
            Assert.Equal(uri, e.Uri.Value);
            Assert.NotNull(e.Element);
            Assert.Equal(typeof(StringValue), e.Element.GetType());
            Assert.Equal(element, e.Element.Value);
        }

        ///<summary>
        ///SdtBaseClassTest
        ///</summary>
        [Fact]
        public void SdtBaseClassTest()
        {
            Type baseType = typeof(SdtElement);
            Assert.True(baseType.GetTypeInfo().IsAbstract);

            // Test loading and modification
            SdtRun sdtRun = new SdtRun();

            using (var stream = GetStream(TestFiles.simpleSdt))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                // find sdt
                var sdt = doc.MainDocumentPart.Document.Descendants<SdtBlock>().First();
                // get
                Assert.Equal(2, sdt.ChildElements.Count);
                Assert.Equal(typeof(SdtProperties), sdt.ChildElements[0].GetType());
                Assert.Equal(typeof(SdtContentBlock), sdt.ChildElements[1].GetType());
                Assert.Equal(typeof(SdtAlias), sdt.ChildElements[0].ChildElements[0].GetType());
                Assert.Equal("SDT1", (sdt.ChildElements[0].ChildElements[0] as SdtAlias).Val.Value);
                // set
                SdtContentBlock contentRun = sdt.ChildElements[1] as SdtContentBlock;
                contentRun.Append(new Paragraph());

                Assert.Equal(typeof(Paragraph), contentRun.ChildElements.Last().GetType());
            }
        }
    }
}
