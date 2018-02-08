// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    ///This is a test class for XmlPathTest and is intended
    ///to contain all XmlPathTest Unit Tests
    ///</summary>
    public class XmlPathTest
    {
        /// <summary>
        ///A test for GetXPath
        ///</summary>
        [Fact]
        public void GetXPathTest()
        {
            XmlPath actual;

            Paragraph p = new Paragraph(new Run(), new BookmarkEnd(), new Run());
            Body body = new Body(p);

            actual = XmlPath.GetXPath(p);
            Assert.Null(actual.PartUri);
            Assert.Equal(@"/w:body[1]/w:p[1]", actual.XPath);
            Assert.Equal(1, actual.NamespacesDefinitions.Count);
            Assert.Equal(@"xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main""", actual.NamespacesDefinitions[0]);

            actual = XmlPath.GetXPath(p.FirstChild);
            Assert.Null(actual.PartUri);
            Assert.Equal(@"/w:body[1]/w:p[1]/w:r[1]", actual.XPath);
            Assert.Equal(1, actual.NamespacesDefinitions.Count);
            Assert.Equal(@"xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main""", actual.NamespacesDefinitions[0]);

            body.PrependChild(new Paragraph());

            actual = XmlPath.GetXPath(p.FirstChild.NextSibling());
            Assert.Null(actual.PartUri);
            Assert.Equal(@"/w:body[1]/w:p[2]/w:bookmarkEnd[1]", actual.XPath);
            Assert.Equal(1, actual.NamespacesDefinitions.Count);
            Assert.Equal(@"xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main""", actual.NamespacesDefinitions[0]);

            var r = p.LastChild;
            actual = XmlPath.GetXPath(r);
            Assert.Null(actual.PartUri);
            Assert.Equal(@"/w:body[1]/w:p[2]/w:r[2]", actual.XPath);
            Assert.Equal(1, actual.NamespacesDefinitions.Count);
            Assert.Equal(@"xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main""", actual.NamespacesDefinitions[0]);

            var unknown1 = p.PrependChild(new OpenXmlUnknownElement("my:test", "http://my"));
            actual = XmlPath.GetXPath(unknown1);
            Assert.Null(actual.PartUri);
            Assert.Equal(@"/w:body[1]/w:p[2]/my:test[1]", actual.XPath);
            Assert.Equal(2, actual.NamespacesDefinitions.Count);
            Assert.Equal(@"xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main""", actual.NamespacesDefinitions[0]);
            Assert.Equal(@"xmlns:my=""http://my""", actual.NamespacesDefinitions[1]);

            var unknown2 = p.AppendChild(new OpenXmlUnknownElement("my:test", "http://my"));
            actual = XmlPath.GetXPath(unknown2);
            Assert.Null(actual.PartUri);
            Assert.Equal(@"/w:body[1]/w:p[2]/my:test[2]", actual.XPath);
            Assert.Equal(2, actual.NamespacesDefinitions.Count);
            Assert.Equal(@"xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main""", actual.NamespacesDefinitions[0]);
            Assert.Equal(@"xmlns:my=""http://my""", actual.NamespacesDefinitions[1]);

            var miscNode = p.AppendChild(new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- comment -->"));
            actual = XmlPath.GetXPath(miscNode);
            Assert.Null(actual.PartUri);
            Assert.Equal(@"/w:body[1]/w:p[2]/<!-- comment -->", actual.XPath);
            Assert.Equal(1, actual.NamespacesDefinitions.Count);
            Assert.Equal(@"xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main""", actual.NamespacesDefinitions[0]);

            actual = XmlPath.GetXPath(r);
            Assert.Null(actual.PartUri);
            Assert.Equal(@"/w:body[1]/w:p[2]/w:r[2]", actual.XPath);
            Assert.Equal(1, actual.NamespacesDefinitions.Count);
            Assert.Equal(@"xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main""", actual.NamespacesDefinitions[0]);

            using (var stream = new MemoryStream())
            using (var doc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                doc.AddMainDocumentPart();
                doc.MainDocumentPart.Document = new Document(body);

                actual = XmlPath.GetXPath(r);
                Assert.Equal(doc.MainDocumentPart.Uri, actual.PartUri);
                Assert.Equal(new Uri("/word/document.xml", UriKind.Relative), actual.PartUri);
                Assert.Equal(@"/w:document[1]/w:body[1]/w:p[2]/w:r[2]", actual.XPath);
                Assert.Equal(1, actual.NamespacesDefinitions.Count);
                Assert.Equal(@"xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main""", actual.NamespacesDefinitions[0]);
            }
        }
    }
}
