// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class OpenXmlElementTest2
    {
        ///<summary>
        ///TestGetPartRootElement.
        ///</summary>
        [Fact]
        public void TestGetPartRootElement()
        {
            Paragraph p = new Paragraph(new Run());
            Body body = new Body(p);

            var target = p.GetPartRootElement();
            Assert.Null(target);

            Document document = new Document(body);

            target = p.GetPartRootElement();
            Assert.Same(document, target);
        }

        ///<summary>
        ///TestGetNextNonMiscElementSibling.
        ///</summary>
        [Fact]
        public void TestGetNextNonMiscElementSibling()
        {
            Paragraph p = new Paragraph(new Run(), new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- comment -->"), new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- comment -->"), new Run(new Text()));
            OpenXmlElement target;

            target = p.GetNextNonMiscElementSibling();
            Assert.Null(target);

            target = p.LastChild.GetNextNonMiscElementSibling();
            Assert.Null(target);

            target = p.FirstChild.GetNextNonMiscElementSibling();
            Assert.Same(p.LastChild, target);

            target = p.FirstChild.NextSibling().GetNextNonMiscElementSibling();
            Assert.Same(p.LastChild, target);
        }

        ///<summary>
        ///TestGetFirstNonMiscElementChild.
        ///</summary>
        [Fact]
        public void TestGetFirstNonMiscElementChild()
        {
            Paragraph p1 = new Paragraph(new Run(), new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- comment -->"), new Run(new Text()));
            Paragraph p2 = new Paragraph(new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- comment -->"), new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- comment -->"), new Run(new Text()));
            Paragraph p3 = new Paragraph();
            OpenXmlElement target;

            target = p1.GetFirstNonMiscElementChild();
            Assert.Same(p1.FirstChild, target);

            target = p2.GetFirstNonMiscElementChild();
            Assert.Same(p2.LastChild, target);

            target = p3.GetFirstNonMiscElementChild();
            Assert.Null(target);
        }

        ///<summary>
        ///TestGetPartUri.
        ///</summary>
        [Fact]
        public void TestGetPartUri()
        {
            Paragraph p = new Paragraph(new Run());
            Body body = new Body(p);

            var target = p.GetPartUri();
            Assert.Null(target);

            Document document = new Document(body);

            target = p.GetPartUri();
            Assert.Null(target);

            using (var stream = new MemoryStream())
            using (var doc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                doc.AddMainDocumentPart();
                Run run = new Run(new Text("Text"));
                doc.MainDocumentPart.Document = new Document(new Body(new Paragraph(new Run(), run)));

                target = run.GetPartUri();
                Assert.Same(doc.MainDocumentPart.Uri, target);
                Assert.Equal(new Uri("/word/document.xml", UriKind.Relative), target);
            }
        }

        ///<summary>
        ///TestGetXPathIndex.
        ///</summary>
        [Fact]
        public void TestGetXPathIndex()
        {
            Paragraph p = new Paragraph(new ParagraphProperties());
            int target = -1;

            target = p.GetXPathIndex();
            Assert.Equal(1, target);

            target = p.FirstChild.GetXPathIndex();
            Assert.Equal(1, target);

            var run1 = p.AppendChild(new Run());
            var run2 = p.AppendChild(new Run());
            var bk1 = p.AppendChild(new BookmarkStart());
            var unknown1 = p.AppendChild(new OpenXmlUnknownElement("unknown"));
            var unknown2 = p.AppendChild(new OpenXmlUnknownElement("unknown"));
            var run3 = p.AppendChild(new Run());

            target = run1.GetXPathIndex();
            Assert.Equal(1, target);

            target = run2.GetXPathIndex();
            Assert.Equal(2, target);

            target = run3.GetXPathIndex();
            Assert.Equal(3, target);

            target = bk1.GetXPathIndex();
            Assert.Equal(1, target);

            target = unknown1.GetXPathIndex();
            Assert.Equal(1, target);

            target = unknown2.GetXPathIndex();
            Assert.Equal(2, target);
        }

        /// <summary>
        /// Tests if empty string is set when
        /// null value is given to setter
        /// </summary>
        [Fact]
        public void TestSetRawOuterXmlField_NullValueIsSet_FieldShouldNotBeNull()
        {
            var openXmlElement = new Document();
            openXmlElement.RawOuterXml = null;
            Assert.NotNull(openXmlElement.RawOuterXml);
        }

        /// <summary>
        /// Tests if proper string value is set when
        /// setter is invoked
        /// </summary>
        [Fact]
        public void TestSetRawOuterXmlField_ValueIsSet_FieldShouldContainSetValue()
        {
            var openXmlElement = new Document();
            var testValue = "Some proper value";
            openXmlElement.RawOuterXml = testValue;
            Assert.Equal(testValue, openXmlElement.RawOuterXml);
        }

        /// <summary>
        /// Tests if field is empty when empty string is set
        /// </summary>
        [Fact]
        public void TestSetRawOuterXmlField_SetValueIsEmpty_FieldShouldBeEmpty()
        {
            var openXmlElement = new Document();
            openXmlElement.RawOuterXml = string.Empty;
            Assert.Equal(string.Empty, openXmlElement.RawOuterXml);
        }

        [Fact]
        public void CanSetNullValue()
        {
            var cell = new WithChildElement
            {
                Child = new ChildElement(),
            };

            Assert.NotNull(cell.Child);

            cell.Child = null;

            Assert.Null(cell.Child);
        }

        private class WithChildElement : OpenXmlCompositeElement
        {
            public ChildElement Child
            {
                get => GetElement<ChildElement>();
                set => SetElement(value);
            }

            internal override void ConfigureMetadata(ElementMetadata.Builder builder)
            {
                builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(ChildElement), 0, 1),
                };
            }
        }

        private class ChildElement : OpenXmlLeafElement
        {
        }
    }
}
