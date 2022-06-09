// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class OpenXmlElementFunctionalExtensionsTests
    {
        private const string NamespaceUriW14 = "http://schemas.microsoft.com/office/word/2010/wordml";

        private static object[] GetElementArray()
        {
            return new object[]
            {
                new Run(new Text("A")),
                new Run(new Text("B")),
            };
        }

        private static List<object> GetElementList()
        {
            return new List<object>
            {
                new Run(new Text("C")),
                new Run(new Text("D")),
            };
        }

        private static List<object> GetNestedElementList()
        {
            return new List<object>
            {
                GetElementArray(),
                GetElementList(),
            };
        }

        private static List<OpenXmlAttribute> GetParagraphAttributes()
        {
            return new List<OpenXmlAttribute>
            {
                GetParagraphId(),
                GetTextId(),
            };
        }

        private static OpenXmlAttribute GetParagraphId()
        {
            return new OpenXmlAttribute("w14", "paraId", NamespaceUriW14, "3BA40FC3");
        }

        private static OpenXmlAttribute GetTextId()
        {
            return new OpenXmlAttribute("w14", "textId", NamespaceUriW14, "2E22A1BE");
        }

        [Fact]
        public void With_AttributeList_Success()
        {
            List<OpenXmlAttribute> attributeList = GetParagraphAttributes();

            Paragraph paragraph = new Paragraph().With(attributeList);

            Assert.Equal(attributeList[0].Value, paragraph.ParagraphId);
            Assert.Equal(attributeList[1].Value, paragraph.TextId);
            Assert.Empty(paragraph.Elements<Run>());
        }

        [Fact]
        public void With_Attribute_Success()
        {
            OpenXmlAttribute attribute = GetParagraphId();

            Paragraph paragraph = new Paragraph().With(attribute);

            Assert.Equal(attribute.Value, paragraph.ParagraphId);
            Assert.Empty(paragraph.Elements<Run>());
        }

        [Fact]
        public void With_ElementArray_Success()
        {
            object[] elementArray = GetElementArray();

            Paragraph paragraph = new Paragraph().With(elementArray);

            Assert.Equal("AB", paragraph.InnerText);
            Assert.Equal(2, paragraph.Elements<Run>().Count());
        }

        [Fact]
        public void With_ElementList_Success()
        {
            List<object> elementList = GetElementList();

            Paragraph paragraph = new Paragraph().With(elementList);

            Assert.Equal("CD", paragraph.InnerText);
            Assert.Equal(2, paragraph.Elements<Run>().Count());
        }

        [Fact]
        public void With_ElementToBeCloned_Success()
        {
            // Arrange, creating an element that is attached to a parent element.
            var element = new Run(new Text("A"));
            var parent = new Paragraph(element);

            Assert.Equal("A", parent.InnerText);

            // Act, creating a Paragraph with the above element, which needs to
            // be cloned.
            Paragraph paragraph = new Paragraph().With(element);

            // Assert, demonstrating that the run was cloned and added to our
            // newly created paragraph.
            Assert.Equal("A", paragraph.InnerText);
            Assert.Single(paragraph.Elements<Run>());
        }

        [Fact]
        public void With_Element_Success()
        {
            var element = new Run(new Text("A"));

            Paragraph paragraph = new Paragraph().With(element);

            Assert.Equal("A", paragraph.InnerText);
            Assert.Single(paragraph.Elements<Run>());
        }

        [Fact]
        public void With_Enumerable_Success()
        {
            IEnumerable<object> enumerable = GetElementArray().Concat(GetElementList());

            Paragraph paragraph = new Paragraph().With(enumerable);

            Assert.Equal("ABCD", paragraph.InnerText);
            Assert.Equal(4, paragraph.Elements<Run>().Count());
        }

        [Fact]
        public void With_NestedElementList_Success()
        {
            List<object> nestedElementList = GetNestedElementList();

            Paragraph paragraph = new Paragraph().With(nestedElementList);

            Assert.Equal("ABCD", paragraph.InnerText);
            Assert.Equal(4, paragraph.Elements<Run>().Count());
        }

        [Fact]
        public void With_NullContent_NothingAdded()
        {
            Paragraph paragraph = new Paragraph().With(null);

            Assert.Equal(string.Empty, paragraph.InnerText);
            Assert.Empty(paragraph.Elements<Run>());
        }

        [Fact]
        public void With_NullOpenXmlElement_ArgumentNullExceptionThrown()
        {
            Paragraph paragraph = null;

            Assert.Throws<ArgumentNullException>(() => paragraph.With(new Run()));
        }

        [Fact]
        public void With_WildMix_Success()
        {
            List<OpenXmlAttribute> attributeList = GetParagraphAttributes();

            // Create paragraph with a w14:paraId attribute and 11 w:r elements.
            Paragraph paragraph = new Paragraph().With(
                attributeList,
                new Run(new Text("1:")),    // 1 w:r
                GetElementArray(),          // 2 w:r
                new Run(new Text(",2:")),   // 1 w:r
                GetElementList(),           // 2 w:r
                new Run(new Text(",3:")),   // 1 w:r
                GetNestedElementList());    // 4 w:r

            Assert.Equal(attributeList[0].Value, paragraph.ParagraphId);
            Assert.Equal(attributeList[1].Value, paragraph.TextId);

            Assert.Equal("1:AB,2:CD,3:ABCD", paragraph.InnerText);
            Assert.Equal(11, paragraph.Elements<Run>().Count());
        }
    }
}
