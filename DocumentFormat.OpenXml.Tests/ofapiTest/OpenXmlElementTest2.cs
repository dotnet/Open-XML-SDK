// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using System.IO;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Summary description for OpenXmlElementTest2
    /// </summary>
    
    public class OpenXmlElementTest2
    {
        ///<summary>
        ///Constructor.
        ///</summary>
        public OpenXmlElementTest2()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

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

            using ( var stream = new MemoryStream() )
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

            var run1 = p.AppendChild( new Run() );
            var run2 = p.AppendChild( new Run() );
            var bk1 = p.AppendChild( new BookmarkStart());
            var unknown1 = p.AppendChild( new OpenXmlUnknownElement("unknown") );
            var unknown2 = p.AppendChild( new OpenXmlUnknownElement("unknown") );
            var run3 = p.AppendChild(new Run() );

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
    }
}
