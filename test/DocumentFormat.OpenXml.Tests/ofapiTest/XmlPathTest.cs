// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class XmlPathTest
    {
        [Fact]
        public void GetXPathTest1()
        {
            var p = new Paragraph(new Run(), new BookmarkEnd(), new Run());
            var body = new Body(p);

            AssertNamespace(XmlPath.GetXPath(p), @"/w:body[1]/w:p[1]",
                new NS("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main"));
        }

        [Fact]
        public void GetXPathTest2()
        {
            var p = new Paragraph(new Run(), new BookmarkEnd(), new Run());
            var body = new Body(p);

            AssertNamespace(XmlPath.GetXPath(p.FirstChild), @"/w:body[1]/w:p[1]/w:r[1]",
                new NS("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main"));
        }

        [Fact]
        public void GetXPathTest3()
        {
            var p = new Paragraph(new Run(), new BookmarkEnd(), new Run());
            var body = new Body(p);
            body.PrependChild(new Paragraph());

            AssertNamespace(XmlPath.GetXPath(p.FirstChild.NextSibling()), @"/w:body[1]/w:p[2]/w:bookmarkEnd[1]",
                new NS("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main"));
        }

        [Fact]
        public void GetXPathTest4()
        {
            var p = new Paragraph(new Run(), new BookmarkEnd(), new Run());
            var body = new Body(p);
            body.PrependChild(new Paragraph());

            AssertNamespace(XmlPath.GetXPath(p.LastChild), @"/w:body[1]/w:p[2]/w:r[2]",
                new NS("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main"));
        }

        [Fact]
        public void GetXPathTest5()
        {
            var p = new Paragraph(new Run(), new BookmarkEnd(), new Run());
            var body = new Body(p);
            body.PrependChild(new Paragraph());
            var r = p.LastChild;
            var unknown1 = p.PrependChild(new OpenXmlUnknownElement("my:test", "http://my"));

            AssertNamespace(XmlPath.GetXPath(unknown1), @"/w:body[1]/w:p[2]/my:test[1]",
                new NS("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main"),
                new NS("my", "http://my"));
        }

        [Fact]
        public void GetXPathTest6()
        {
            var p = new Paragraph(new Run(), new BookmarkEnd(), new Run());
            var body = new Body(p);
            body.PrependChild(new Paragraph());
            var r = p.LastChild;
            var unknown1 = p.PrependChild(new OpenXmlUnknownElement("my:test", "http://my"));
            var unknown2 = p.AppendChild(new OpenXmlUnknownElement("my:test", "http://my"));

            AssertNamespace(XmlPath.GetXPath(unknown2), @"/w:body[1]/w:p[2]/my:test[2]",
                new NS("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main"),
                new NS("my", "http://my"));
        }

        [Fact]
        public void GetXPathTest7()
        {
            var p = new Paragraph(new Run(), new BookmarkEnd(), new Run());
            var body = new Body(p);
            body.PrependChild(new Paragraph());
            var r = p.LastChild;
            var unknown1 = p.PrependChild(new OpenXmlUnknownElement("my:test", "http://my"));
            var unknown2 = p.AppendChild(new OpenXmlUnknownElement("my:test", "http://my"));
            var miscNode = p.AppendChild(new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- comment -->"));

            AssertNamespace(XmlPath.GetXPath(miscNode), @"/w:body[1]/w:p[2]/<!-- comment -->",
                new NS("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main"));
        }

        [Fact]
        public void GetXPathTest8()
        {
            var p = new Paragraph(new Run(), new BookmarkEnd(), new Run());
            var body = new Body(p);
            body.PrependChild(new Paragraph());
            var r = p.LastChild;
            var unknown1 = p.PrependChild(new OpenXmlUnknownElement("my:test", "http://my"));
            var unknown2 = p.AppendChild(new OpenXmlUnknownElement("my:test", "http://my"));

            AssertNamespace(XmlPath.GetXPath(r), @"/w:body[1]/w:p[2]/w:r[2]",
                new NS("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main"));

            using (var stream = new MemoryStream())
            using (var doc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                doc.AddMainDocumentPart();
                doc.MainDocumentPart.Document = new Document(body);
                AssertNamespace(XmlPath.GetXPath(r), doc.MainDocumentPart.Uri, @"/w:document[1]/w:body[1]/w:p[2]/w:r[2]",
                    new NS("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main"));
            }
        }

        private readonly struct NS
        {
            public NS(string prefix, string ns)
            {
                Prefix = prefix;
                Namespace = ns;
            }

            public string Prefix { get; }

            public string Namespace { get; }

            public KeyValuePair<string, string> ToPair() => new KeyValuePair<string, string>(Prefix, Namespace);
        }

        private static void AssertNamespace(XmlPath xmlPath, string uri, params NS[] namespaces) => AssertNamespace(xmlPath, null, uri, namespaces);

        private static void AssertNamespace(XmlPath xmlPath, Uri partUri, string uri, params NS[] namespaces)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Assert.Equal(partUri, xmlPath.PartUri);
            Assert.Equal(uri, xmlPath.XPath);

            var actualNamespaces = xmlPath.Namespaces.GetNamespacesInScope(XmlNamespaceScope.Local);

            Assert.Equal(namespaces.Length, xmlPath.NamespacesDefinitions.Count);
            Assert.Equal(namespaces.Length, actualNamespaces.Count);

            foreach (var name in namespaces)
            {
                Assert.Contains($"xmlns:{name.Prefix}=\"{name.Namespace}\"", xmlPath.NamespacesDefinitions);
                Assert.Contains(name.ToPair(), actualNamespaces);
            }
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
