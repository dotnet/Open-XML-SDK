// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using w = DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Xml;
#if WB
using DocumentFormat.OpenXml.WB.Tests;
#endif

namespace DocumentFormat.OpenXml.Tests
{
    
    
    /// <summary>
    ///This is a test class for OpenXmlElementTest and is intended
    ///to contain all OpenXmlElementTest Unit Tests
    ///</summary>
    
    public class OpenXmlElementTest
    {
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

        /// <summary>
        ///A test for RemoveAttribute
        ///</summary>
        [Fact]
        public void GetAttributeTest()
        {
            FooterReference paragraph = new FooterReference();

            //OpenXmlAttribute target = paragraph.GetAttribute("type", null);
            //Assert.Null(target);
            OpenXmlAttribute target;

            //target = paragraph.GetAttribute("type", paragraph.NamespaceURI);
            //Assert.Null(target);

            //  2 predefined attributes
            paragraph.Type = HeaderFooterValues.Default;
            paragraph.Id = "1";

            // 1 extended attribute
            OpenXmlAttribute openXmlAttribute = new OpenXmlAttribute("test", "attribute", "http://test", "true");
            paragraph.SetAttribute(openXmlAttribute);

            target = paragraph.GetAttribute(openXmlAttribute.LocalName, openXmlAttribute.NamespaceUri);

            Assert.NotSame(openXmlAttribute, target);
            Assert.Equal(openXmlAttribute.NamespaceUri, target.NamespaceUri);
            Assert.Equal(openXmlAttribute.LocalName, target.LocalName);
            Assert.Equal(openXmlAttribute.Prefix, target.Prefix);
            Assert.Equal(openXmlAttribute.Value, target.Value);

            target = paragraph.GetAttribute("type", paragraph.NamespaceUri);
            Assert.Equal(paragraph.NamespaceUri, target.NamespaceUri);
            Assert.Equal("type", target.LocalName);
            Assert.Equal("w", target.Prefix);
            Assert.Equal(paragraph.Type.InnerText, target.Value);
        }

        /// <summary>
        ///A test for RemoveAttribute
        ///</summary>
        [Fact]
        public void RemoveAttributeTest()
        {
            // create an element to hold 3 attributes 
            FooterReference target = new FooterReference();

            Assert.False(target.HasAttributes);
            Assert.Equal(0, target.GetAttributes().Count);
            Assert.Equal(0, target.ExtendedAttributes.Count());

            Assert.Null(target.Type);
            Assert.Null(target.Id);

            //  2 predefined attributes
            target.Type = HeaderFooterValues.Default;
            target.Id = "1";

            // 1 extended attribute
            OpenXmlAttribute openXmlAttribute = new OpenXmlAttribute("test", "attribute", "http://test", "true");
            target.SetAttribute(openXmlAttribute);

            Assert.True(target.HasAttributes);
            Assert.Equal(3, target.GetAttributes().Count);
            Assert.Equal(1, target.ExtendedAttributes.Count());

            Assert.NotNull(target.Type);
            Assert.True(target.Type.HasValue);
            Assert.Equal(HeaderFooterValues.Default, target.Type.Value);
            Assert.Equal(HeaderFooterValues.Default, (HeaderFooterValues)(target.Type));

            Assert.NotNull(target.Id);
            Assert.Equal("1", (string)target.Id);

            // Remove the custom attribute
            target.RemoveAttribute(openXmlAttribute.LocalName, openXmlAttribute.NamespaceUri);
            Assert.True(target.HasAttributes);
            Assert.Equal(2, target.GetAttributes().Count);
            Assert.Equal(0, target.ExtendedAttributes.Count());

            Assert.NotNull(target.Type);
            Assert.True(target.Type.HasValue);
            Assert.Equal(HeaderFooterValues.Default, target.Type.Value);
            Assert.Equal(HeaderFooterValues.Default, (HeaderFooterValues)(target.Type));

            Assert.NotNull(target.Id);
            Assert.Equal("1", (string)target.Id);

            // remove the .Id
            openXmlAttribute = target.GetAttributes()[1];
            target.RemoveAttribute(openXmlAttribute.LocalName, openXmlAttribute.NamespaceUri);
            Assert.True(target.HasAttributes);
            Assert.Equal(1, target.GetAttributes().Count);
            Assert.Equal(0, target.ExtendedAttributes.Count());

            Assert.NotNull(target.Type);
            Assert.True(target.Type.HasValue);
            Assert.Equal(HeaderFooterValues.Default, target.Type.Value);
            Assert.Equal(HeaderFooterValues.Default, (HeaderFooterValues)(target.Type));

            Assert.Null(target.Id);

            // remove the .Type
            openXmlAttribute = target.GetAttributes()[0];
            target.RemoveAttribute(openXmlAttribute.LocalName, openXmlAttribute.NamespaceUri);
            Assert.False(target.HasAttributes);
            Assert.Equal(0, target.GetAttributes().Count);
            Assert.Equal(0, target.ExtendedAttributes.Count());

            Assert.Null(target.Type);
            Assert.Null(target.Id);
        }

        /// <summary>
        ///A test for Descendants, Ancestors, ElementsBefore, ElementsAfter, IsBefore, IsAfter
        ///</summary>
        [Fact]
        public void OpenXmlElementTraversingMethodsTest()
        {
            Paragraph para = new Paragraph();
            Run r1 = para.AppendChild(new Run());
            Bold b1 = r1.AppendChild(new RunProperties()).AppendChild(new Bold());
            Text t1 = r1.AppendChild(new Text());

            Run r2 = para.AppendChild(new Run());
            r2.AppendChild(new Text());

            Run r3 = para.AppendChild(new Run());

            Assert.Equal(7, para.Descendants().Count());
            Assert.Equal(3, r1.Descendants().Count());
            Assert.Equal(1, r2.Descendants().Count());
            Assert.Equal(0, r3.Descendants().Count());

            Assert.Same(r1, para.Descendants().First());
            Assert.Same(b1, para.Descendants().ElementAt(2));
            Assert.Same(t1, para.Descendants().ElementAt(3));
            Assert.Same(r2, para.Descendants().ElementAt(4));
            Assert.Same(r3, para.Descendants().Last());

            // ancestors
            Assert.Equal(0, para.Ancestors().Count());
            Assert.Equal(0, para.Ancestors<Body>().Count());
            Assert.Equal(1, r1.Ancestors().Count());
            Assert.Equal(1, r1.Ancestors<Paragraph>().Count());
            Assert.Equal(0, r1.Ancestors<Body>().Count());
            Assert.Equal(1, r3.Ancestors().Count());
            Assert.Equal(1, r3.Ancestors<Paragraph>().Count());
            Assert.Equal(0, r3.Ancestors<Body>().Count());
            Assert.Equal(2, t1.Ancestors().Count());
            Assert.Equal(1, t1.Ancestors<Paragraph>().Count());
            Assert.Equal(0, t1.Ancestors<Body>().Count());
            Assert.Equal(3, b1.Ancestors().Count());
            Assert.Equal(1, b1.Ancestors<Paragraph>().Count());
            Assert.Equal(1, b1.Ancestors<Run>().Count());
            Assert.Equal(1, b1.Ancestors<RunProperties>().Count());
            Assert.Equal(0, b1.Ancestors<Body>().Count());

            Assert.Same(para, r1.Ancestors().First());
            Assert.Same(para, r1.Ancestors<Paragraph>().First());
            Assert.Same(r1, t1.Ancestors().First());
            Assert.Same(para, t1.Ancestors().Last());
            Assert.Same(r1, t1.Ancestors<Run>().First());
            Assert.Same(para, t1.Ancestors<Paragraph>().First());
            Assert.Same(para, b1.Ancestors().Last());
            Assert.Same(r1, b1.Ancestors().ElementAt(1));

            // IsBefore() / IsAfter()
            Assert.False(para.IsBefore(para));
            Assert.False(para.IsAfter(para));
            Assert.False(r2.IsBefore(r2));
            Assert.False(r2.IsAfter(r2));

            Assert.True(para.IsBefore(r1));
            Assert.False(para.IsAfter(r1));
            Assert.True(para.IsBefore(b1));
            Assert.False(para.IsAfter(b1));
            Assert.False(r1.IsBefore(para));
            Assert.True(r1.IsAfter(para));
            Assert.False(r1.IsBefore(para));
            Assert.True(r1.IsAfter(para));

            Assert.True(r1.IsBefore(r2));
            Assert.False(r1.IsAfter(r2));
            Assert.False(r3.IsBefore(r1));
            Assert.True(r3.IsAfter(r1));
            Assert.False(b1.IsAfter(r2));
            Assert.True(b1.IsBefore(r2));

            Assert.True(r1.IsBefore(b1));
            Assert.False(r1.IsAfter(b1));
            Assert.True(b1.IsAfter(r1));
            Assert.False(b1.IsBefore(r1));

            Paragraph p2 = new Paragraph();
            Run p2r1 = p2.AppendChild(new Run());

            Assert.False(p2.IsBefore(para));
            Assert.False(p2.IsAfter(para));
            Assert.False(p2r1.IsAfter(para));
            Assert.False(p2r1.IsBefore(para));

            // ElementsBefore / ElementsAfter
            Assert.False(para.ElementsBefore().Any());
            Assert.False(para.ElementsAfter().Any());
            Assert.True(r1.ElementsAfter().Any());
            Assert.False(r1.ElementsBefore().Any());
            Assert.False(r3.ElementsAfter().Any());
            Assert.True(r3.ElementsBefore().Any());
            Assert.True(r2.ElementsAfter().Any());
            Assert.True(r2.ElementsBefore().Any());
            Assert.Same(r1, r3.ElementsBefore().First());
            Assert.Same(r2, r3.ElementsBefore().Last());
            Assert.Same(r2, r1.ElementsAfter().First());
            Assert.Same(r3, r1.ElementsAfter().Last());
            Assert.False(b1.ElementsBefore().Any());
            Assert.False(b1.ElementsAfter().Any());
        }

        /// <summary>
        ///A test for OpenXmlElement.InnerXml
        ///</summary>
        [Fact]
        public void InnerXmlTest()
        {
            string paragraphOuterXml = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>";
            string paragraphInnerXml = "<w:r xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r>";
            string run1Text = "Run Text.";
            string run2Text = "Run 2.";

            Paragraph p = new Paragraph(new Run(new Text(run1Text), new Text(run2Text)));
            p.RsidParagraphProperties = "001";

            Assert.Equal(paragraphOuterXml, p.OuterXml);
            Assert.Equal(paragraphInnerXml, p.InnerXml);
            Assert.Equal(run1Text + run2Text, p.InnerText);

            FontSize fontSize = new FontSize();
            fontSize.Val = "12"; // change from UInt64 to UInt32 according to deviation bug $14199

            Assert.Equal(string.Empty, fontSize.InnerXml);
            Assert.Equal(string.Empty, fontSize.InnerText);

            p = new Paragraph();
            p.InnerXml = paragraphInnerXml;
            p.RsidParagraphProperties = "001";

            // make sure elements are fullly populated.
            var r1 = p.FirstChild.FirstChild;
            var r2 = r1.NextSibling();

            Assert.Equal(run1Text, r1.InnerText);
            Assert.Equal(run2Text, r2.InnerText);

            var newOuter = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>";
            Assert.Equal(newOuter, p.OuterXml);
            Assert.Equal(paragraphInnerXml, p.InnerXml);
            Assert.Equal(run1Text + run2Text, p.InnerText);

            p = new Paragraph(paragraphOuterXml);
            Assert.Equal(paragraphOuterXml, p.OuterXml);
            Assert.Equal(paragraphInnerXml, p.InnerXml);
            Assert.Equal(run1Text + run2Text, p.InnerText);

            OpenXmlUnknownElement unknownElement = OpenXmlUnknownElement.CreateOpenXmlUnknownElement(paragraphOuterXml);
            Assert.Equal(paragraphOuterXml, unknownElement.OuterXml);
            Assert.Equal(paragraphInnerXml, unknownElement.InnerXml);
        }
 
        /// <summary>
        ///A test for OpenXmlElement.RemoveAllChildren
        ///</summary>
        [Fact]
        public void RemoveElementTest()
        {
            Paragraph para = new Paragraph();
            Run r1 = para.AppendChild(new Run());
            Bold b1 = r1.AppendChild(new RunProperties()).AppendChild(new Bold());
            Text t1 = r1.AppendChild(new Text());

            BookmarkStart bkStart =  para.AppendChild(new BookmarkStart());

            Run r2 = para.AppendChild(new Run());
            r2.AppendChild(new Text());

            BookmarkEnd bkEnd = para.AppendChild(new BookmarkEnd());

            Run r3 = para.AppendChild(new Run());

            t1.Remove();
            Assert.Equal(1, r1.ChildElements.Count);
            Assert.Null(t1.Parent);
            Assert.NotNull(r1.FirstChild);
            Assert.NotNull(r1.LastChild);

            r1.RemoveAllChildren<Text>(); // should do nothing
            Assert.NotNull(r1.FirstChild);
            Assert.NotNull(r1.LastChild);

            r1.RemoveAllChildren<RunProperties>(); 
            Assert.Null(r1.FirstChild);
            Assert.Null(r1.LastChild);
            
            para.RemoveAllChildren<BookmarkStart>();
            Assert.Null(bkStart.Parent);

            para.RemoveAllChildren<Run>();
            Assert.Same(bkEnd, para.FirstChild);
            Assert.Same(bkEnd, para.LastChild);

            para.RemoveAllChildren<Run>(); // should do nothing
            Assert.Same(bkEnd, para.FirstChild);
            Assert.Same(bkEnd, para.LastChild);
        }

        /// <summary>
        ///A test for OpenXmlElement.RemoveAllChildren
        ///</summary>
        [Fact]
        public void InsertElementTest()
        {
            Paragraph para = new Paragraph();
            Run r1 = new Run();
            Run r2 = new Run();
            Run r3 = new Run();

            para.InsertAt(r1, 0);
            para.InsertAt(r3, 1);
            para.InsertAt(r2, 1);

            Assert.Same(r1, para.FirstChild);
            Assert.Same(r2, r1.NextSibling());
            Assert.Same(r3, para.LastChild);

            ParagraphProperties pPr = new ParagraphProperties();
            r1.InsertBeforeSelf(pPr);
            Assert.Same(pPr, para.FirstChild);
            Assert.Same(r1, pPr.NextSibling());
            Assert.Same(pPr, r1.PreviousSibling());


            BookmarkStart bkStart = new BookmarkStart();

            r1.InsertAfterSelf(bkStart);
            Assert.Same(bkStart, r1.NextSibling());
            Assert.Same(r1, bkStart.PreviousSibling());
        }
 
        
        /// <summary>
        ///A test for OpenXmlElement.RemoveAllChildren
        ///</summary>
        [Fact]
        public void SiblingTest()
        {
            Paragraph para = new Paragraph();
            Run r1 = para.AppendChild(new Run());
            Bold b1 = r1.AppendChild(new RunProperties()).AppendChild(new Bold());
            Text t1 = r1.AppendChild(new Text());

            BookmarkStart bkStart = para.AppendChild(new BookmarkStart());

            Run r2 = para.AppendChild(new Run());
            r2.AppendChild(new Text());

            BookmarkEnd bkEnd = para.AppendChild(new BookmarkEnd());

            Run r3 = para.AppendChild(new Run());

            Assert.Null(para.PreviousSibling<Paragraph>());
            Assert.Null(r1.PreviousSibling<BookmarkStart>());
            Assert.Same(r1, bkStart.PreviousSibling<Run>());
            Assert.Same(bkStart, r2.PreviousSibling<BookmarkStart>());
            Assert.Same(bkStart, bkEnd.PreviousSibling<BookmarkStart>());
            Assert.Same(bkStart, r3.PreviousSibling<BookmarkStart>());

            Assert.Null(para.NextSibling<Paragraph>());
            Assert.Null(r2.NextSibling<BookmarkStart>());
            Assert.Same(r2, bkStart.NextSibling<Run>());
            Assert.Same(bkEnd, r1.NextSibling<BookmarkEnd>());
            Assert.Same(bkEnd, bkStart.NextSibling<BookmarkEnd>());
            Assert.Same(bkEnd, r2.NextSibling<BookmarkEnd>());
        }


        /// <summary>
        ///A test for OpenXmlElement
        ///</summary>
        [Fact]
        public void PrefixTest()
        {
            var target = new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();

            Assert.Equal("urn:schemas-microsoft-com:office:word", target.NamespaceUri);
            Assert.Equal("w10", target.Prefix);
            Assert.Equal("wrap", target.LocalName);

        }

        /// <summary>
        /// A test for OpenXmlAttribute
        /// </summary>
        [Fact]
        public void OpenXmlAttributeTest()
        {
            OpenXmlAttribute target = new OpenXmlAttribute();
            OpenXmlAttribute other = new OpenXmlAttribute();

            Assert.NotSame(target, other);
            Assert.True(target == other);
            Assert.False(target != other);
            Assert.True(target.Equals(other));
            Assert.True(target.Equals((object)other));
            Assert.True(OpenXmlAttribute.Equals(target, other));
            Assert.Equal(target.GetHashCode(), other.GetHashCode());

            target = new OpenXmlAttribute("test", "http://test", "test", "value");
            other = new OpenXmlAttribute("test", "http://test", "test", "value");

            Assert.NotSame(target, other);
            Assert.True(target == other);
            Assert.False(target != other);
            Assert.True(target.Equals(other));
            Assert.True(target.Equals((object)other));
            Assert.True(OpenXmlAttribute.Equals(target, other));
            Assert.Equal(target.GetHashCode(), other.GetHashCode());

            other.Value = "other";

            Assert.NotSame(target, other);
            Assert.False(target == other);
            Assert.True(target != other);
            Assert.False(target.Equals(other));
            Assert.False(target.Equals((object)other));
            Assert.False(OpenXmlAttribute.Equals(target, other));
            Assert.NotEqual(target.GetHashCode(), other.GetHashCode());

            other.Value = "value";

            Assert.NotSame(target, other);
            Assert.True(target == other);
            Assert.False(target != other);
            Assert.True(target.Equals(other));
            Assert.True(target.Equals((object)other));
            Assert.True(OpenXmlAttribute.Equals(target, other));
            Assert.Equal(target.GetHashCode(), other.GetHashCode());

            other.Prefix = "t";

            Assert.NotSame(target, other);
            Assert.False(target == other);
            Assert.True(target != other);
            Assert.False(target.Equals(other));
            Assert.False(target.Equals((object)other));
            Assert.False(OpenXmlAttribute.Equals(target, other));
            Assert.NotEqual(target.GetHashCode(), other.GetHashCode());

        }

        /// <summary>
        ///A test for OpenXmlLeafElement.InnerXml
        ///</summary>
        [Fact]
        public void LeafElementInnerXmlTest()
        {
            string paragraphOuterXml = "<w:p xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" w:rsidP=\"001\"><w:pPr><w:wordWrap w:val=\"off\"><invalidElement /></w:wordWrap><w:jc w:val=\"right\" /></w:pPr><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>";
            string paragraphInnerXml = "<w:pPr xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:wordWrap w:val=\"off\"><invalidElement /></w:wordWrap><w:jc w:val=\"right\" /></w:pPr><w:r xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r>";
            string wordWrapInnerText = "<invalidElement />";

            Paragraph p = new Paragraph(paragraphOuterXml);
            ParagraphProperties pPr = (ParagraphProperties)p.FirstChild;

            Assert.Equal(paragraphOuterXml, p.OuterXml);
            Assert.Equal(paragraphInnerXml, p.InnerXml);
            Assert.Equal(wordWrapInnerText, pPr.WordWrap.InnerXml);
            Assert.Equal(string.Empty, pPr.Justification.InnerXml);

            pPr.WordWrap.InnerXml = string.Empty;
            Assert.Equal(string.Empty, pPr.WordWrap.InnerXml);

            pPr.WordWrap.InnerXml = null;
            Assert.Equal(string.Empty, pPr.WordWrap.InnerXml);
        }

        /// <summary>
        ///A test for OpenXmlLeafTextElement.InnerXml
        ///</summary>
        [Fact]
        public void LeafTextElementInnerXmlTest()
        {
            string paragraphOuterXml = "<w:p xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" w:rsidP=\"001\"><w:r><w:t>Run Text.</w:t><w:t>Text 2.<invalidElement /></w:t></w:r></w:p>";
            string paragraphInnerXml = "<w:r xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:t>Run Text.</w:t><w:t>Text 2.<invalidElement /></w:t></w:r>";
            string text1Text = "Run Text.";
            string text2Text = "Text 2.";
            string text2InnerXml = "Text 2.<invalidElement />";

            Paragraph p = new Paragraph(paragraphOuterXml);
            Text text1 = (Text)p.FirstChild.FirstChild;
            Text text2 = (Text)p.FirstChild.LastChild;

            Assert.Equal(text1Text, text1.InnerXml);
            Assert.Equal(text1Text, text1.Text);
            Assert.Equal(text2Text, text2.Text);
            Assert.Equal(text2InnerXml, text2.InnerXml);
            Assert.Equal(paragraphOuterXml, p.OuterXml);
            Assert.Equal(paragraphInnerXml, p.InnerXml);

            text2.InnerXml = string.Empty;
            Assert.Equal(text2Text, text2.Text);

            text2.InnerXml = null;
            Assert.Equal(text2Text, text2.Text);
        }

        /// <summary>
        /// A test for Clone.
        /// </summary>
        [Fact]
        public void ElementCloneTest()
        {
            using(MemoryStream stream = new MemoryStream(TestFileStreams.mcdoc))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                // Shallow clone the body, which doesn't have attributes
                var body = doc.MainDocumentPart.Document.Body;
                var clonedBody = body.CloneNode(false);
                Assert.False(clonedBody.HasChildren);
                Assert.Equal(body.HasAttributes, clonedBody.HasAttributes); //Cloned Body has no attributes.
                Assert.Equal(body.ExtendedAttributes.Count(), clonedBody.ExtendedAttributes.Count());

                // Shallow clone the first paragraph, which has attributes
                var paragraph = body.Descendants<Paragraph>().First();
                var clonedParagraph = paragraph.CloneNode(false);
                Assert.False(clonedParagraph.HasChildren);
                Assert.True(clonedParagraph.HasAttributes);
                Assert.Equal(paragraph.Attributes.Count(), clonedParagraph.Attributes.Count());
                Assert.Equal(paragraph.ExtendedAttributes.Count(), clonedParagraph.ExtendedAttributes.Count());

                // Deep clone the document
                var clonedDocument = doc.MainDocumentPart.Document.CloneNode(true);
                Assert.True(clonedDocument.HasChildren);
                Assert.Equal(doc.MainDocumentPart.Document.ChildElements.Count, clonedDocument.ChildElements.Count);
                Assert.Equal(doc.MainDocumentPart.Document.Descendants().Count(), clonedDocument.Descendants().Count());
                var docEnumerator = doc.MainDocumentPart.Document.Descendants().GetEnumerator();
                foreach (var elem in clonedDocument.Descendants())
                {
                    Assert.True(docEnumerator.MoveNext());
                    var curElem = docEnumerator.Current;
                    Assert.Equal(curElem.GetType(), elem.GetType());
                    Assert.Equal(curElem.NamespaceUri, elem.NamespaceUri);
                    Assert.Equal(curElem.XmlQualifiedName, elem.XmlQualifiedName);
                    Assert.Equal(curElem.Attributes == null, elem.Attributes == null);
                    if (curElem.Attributes != null)
                    {
                        Assert.Equal(curElem.Attributes.Length, elem.Attributes.Length);
                    }
                    Assert.Equal(curElem.ExtendedAttributes.Count(), elem.ExtendedAttributes.Count());
                    var a1 = curElem.ExtendedAttributes.ToArray();
                    var a2 = elem.ExtendedAttributes.ToArray();
                    for(int i = 0; i< a1.Length; i++)
                    {
                        Assert.Equal(a1[i].NamespaceUri, a2[i].NamespaceUri);
                        Assert.Equal(a1[i].LocalName, a2[i].LocalName);
                        Assert.Equal(a1[i].Value, a2[i].Value);
                    }

                    Assert.Equal(curElem.MCAttributes == null, elem.MCAttributes == null);
                    if (curElem is OpenXmlLeafTextElement)
                    {
                        Assert.Equal(((OpenXmlLeafTextElement)curElem).Text, ((OpenXmlLeafTextElement)elem).Text);
                    }
                }
                // Deep clone the unknown element
                var unknown = doc.MainDocumentPart.Document.Descendants<OpenXmlUnknownElement>().Where(e => e.LocalName == "wsp").First();
                var clonedUnknown = unknown.CloneNode(true);
                Assert.Equal(unknown.OuterXml, clonedUnknown.OuterXml);

                // Clone the OpenXmlMiscNode
                var miscNode = new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- my comment -->");
                var clonedMiscNode = miscNode.CloneNode(true) as OpenXmlMiscNode;
                Assert.NotNull(clonedMiscNode);
                Assert.Equal(miscNode.XmlNodeType, clonedMiscNode.XmlNodeType);
                Assert.Equal(miscNode.OuterXml, clonedMiscNode.OuterXml);
                
                // Shallow clone mc element
                var acb = body.Descendants<AlternateContent>().First();
                acb.MCAttributes = new MarkupCompatibilityAttributes();
                acb.MCAttributes.Ignorable = "w14";
                acb.MCAttributes.MustUnderstand = "wp";
                acb.MCAttributes.PreserveAttributes = "a";
                acb.MCAttributes.PreserveElements = "w14";
                acb.MCAttributes.ProcessContent = "wp";
                var clonedAcb = acb.CloneNode(false);
                Assert.NotNull(clonedAcb.MCAttributes);
                Assert.Equal(acb.MCAttributes.Ignorable.Value, clonedAcb.MCAttributes.Ignorable.Value);
                Assert.Equal(acb.MCAttributes.MustUnderstand.Value, clonedAcb.MCAttributes.MustUnderstand.Value);
                Assert.Equal(acb.MCAttributes.PreserveAttributes.Value, clonedAcb.MCAttributes.PreserveAttributes.Value);
                Assert.Equal(acb.MCAttributes.PreserveElements.Value, clonedAcb.MCAttributes.PreserveElements.Value);
                Assert.Equal(acb.MCAttributes.ProcessContent.Value, clonedAcb.MCAttributes.ProcessContent.Value);
            }
        }

        /// <summary>
        /// A test for the OpenXmlElement contructor with an outerXml as parameter.
        /// </summary>
        [Fact]
        public void OpenXmlElementConstructorOuterXmlTest()
        {
            // Check bug #484153.
            string outerXmlWithXmlDecl = "<?xml version=\"1.0\" encoding=\"utf-8\"?><customUI  xmlns=\"http://schemas.microsoft.com/office/2006/01/customui\"></customUI>";
            try
            {
                DocumentFormat.OpenXml.Office.CustomUI.CustomUI cUi = new DocumentFormat.OpenXml.Office.CustomUI.CustomUI(outerXmlWithXmlDecl);
                Assert.True(false); // Assert.Fail("Expected InvalidOperationException is not thrown");
            }
            catch (ArgumentException ex1)
            {
                Assert.True(ex1.Message.StartsWith(ExceptionMessages.InvalidOuterXml));
            }

            // Valid outer xml
            string validOuterXml = "<customUI  xmlns=\"http://schemas.microsoft.com/office/2006/01/customui\"></customUI>";
            DocumentFormat.OpenXml.Office.CustomUI.CustomUI cUi2 = new DocumentFormat.OpenXml.Office.CustomUI.CustomUI(validOuterXml);
            Assert.Equal(validOuterXml, cUi2.OuterXml);

            // Valid outer xml but starting with whitespaces.
            string validOuterXmlWithWhitespaces = "     <customUI  xmlns=\"http://schemas.microsoft.com/office/2006/01/customui\"></customUI>";
            DocumentFormat.OpenXml.Office.CustomUI.CustomUI cUi3 = new DocumentFormat.OpenXml.Office.CustomUI.CustomUI(validOuterXmlWithWhitespaces);
            // The whitespaces should be trimmed when getting OuterXml.
            Assert.Equal(validOuterXml, cUi2.OuterXml);

            // verify bug #671248
            string paragraphXml = "<w:p xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" mc:Ignorable=\"w14\" " +
                        "xmlns:w14=\"http://schemas.microsoft.com/office/word/2007/5/30/wordml\" " +
                        "xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" w14:paraId=\"017B6C57\" w14:editId=\"32F17AD3\" w:rsidR=\"00A35C47\"  />";
            var p = new Paragraph(paragraphXml);
            Assert.NotNull(p.MCAttributes);
            Assert.Equal(2, p.ExtendedAttributes.Count());
            Assert.NotNull(p.RsidParagraphAddition);
        }

        /// <summary>
        /// A test for the OpenXmlUnknownElement.CreateOpenXmlUnknownElement with an outer xml.
        /// </summary>
        [Fact]
        public void CreateOpenXmlUnknownElmenentTest()
        {
            // Valid outer xml
            string validOuterXml = "<myElement  xmlns=\"http://schemas.microsoft.com/office/2006/01/customui\"></myElement>";
            var unknown1 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement(validOuterXml);
            Assert.Equal(validOuterXml, unknown1.OuterXml);

            // Valid outer xml but starting with whitespaces.
            string validOuterXmlWithWhitespaces = "   <myElement  xmlns=\"http://schemas.microsoft.com/office/2006/01/customui\"></myElement>";
            var unknown2 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement(validOuterXmlWithWhitespaces);
            Assert.Equal(validOuterXmlWithWhitespaces, unknown2.OuterXml);

            // Check bug #484153.
            string outerXmlWithXmlDecl = "<?xml version=\"1.0\" encoding=\"utf-8\"?><customUI  xmlns=\"http://schemas.microsoft.com/office/2006/01/customui\"></customUI>";
            try
            {
                var unknown3 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement(outerXmlWithXmlDecl);
                Assert.True(false); // Assert.Fail("Expected InvalidOperationException is not thrown");
            }
            catch (ArgumentException ex1)
            {
                Assert.True(ex1.Message.StartsWith(ExceptionMessages.InvalidOuterXml));
            }
        }
        /// <summary>
        /// A test for the OpenXmlElement.ChildElements{get;}.
        /// </summary>
        [Fact]
        public void ChildElementsTest()
        {
            Paragraph p = new Paragraph();
            var pPr = p.AppendChild(new ParagraphProperties());
            var r = p.AppendChild(new Run());
            var rPr = r.AppendChild(new RunProperties());
            var b = rPr.Bold = new Bold();
            var t = r.AppendChild(new Text("Text"));
            var unknown1 = p.AppendChild(new OpenXmlUnknownElement("tmp:node", "http://temp"));
            var unknown2 = unknown1.AppendChild(new OpenXmlUnknownElement("tmp:node2", "http://temp"));
            var miscNode = p.AppendChild(new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- comment -->"));

            var emptyListSingleton = EmptyElementList.EmptyElementListSingleton;
            var emptyEnumeratorSingleton = EmptyEnumerator<OpenXmlElement>.EmptyEnumeratorSingleton;

            Assert.NotSame(emptyListSingleton, p.ChildElements);
            Assert.Equal(4, p.ChildElements.Count);

            var enumerator = p.ChildElements.GetEnumerator();
            Assert.NotSame(emptyEnumeratorSingleton, enumerator);
            Assert.True(enumerator.MoveNext());
            Assert.Same(pPr, enumerator.Current);

            Assert.True(enumerator.MoveNext());
            Assert.Same(r, enumerator.Current);
            Assert.True(enumerator.MoveNext());
            Assert.True(enumerator.MoveNext());
            Assert.False(enumerator.MoveNext()); // the end

            // pPr, empty children
            Assert.Same(emptyListSingleton, pPr.ChildElements);
            Assert.Equal(0, pPr.ChildElements.Count);
            enumerator = pPr.ChildElements.GetEnumerator();
            Assert.Same(emptyEnumeratorSingleton, enumerator);
            Assert.False(enumerator.MoveNext());

            // r, two child
            Assert.NotSame(emptyListSingleton, r.ChildElements);
            Assert.Equal(2, r.ChildElements.Count);
            enumerator = r.ChildElements.GetEnumerator();
            Assert.NotSame(emptyEnumeratorSingleton, enumerator);
            Assert.True(enumerator.MoveNext());
            Assert.Same(rPr, enumerator.Current);

            // rPr, one child
            Assert.NotSame(emptyListSingleton, rPr.ChildElements);
            Assert.Equal(1, rPr.ChildElements.Count);
            enumerator = rPr.ChildElements.GetEnumerator();
            Assert.NotSame(emptyEnumeratorSingleton, enumerator);
            Assert.True(enumerator.MoveNext());

            // b, leaf element
            Assert.Same(emptyListSingleton, b.ChildElements);
            Assert.Equal(0, b.ChildElements.Count);
            enumerator = b.ChildElements.GetEnumerator();
            Assert.Same(emptyEnumeratorSingleton, enumerator);
            Assert.False(enumerator.MoveNext());

            // t, leaf text element
            Assert.Same(emptyListSingleton, t.ChildElements);
            Assert.Equal(0, t.ChildElements.Count);
            enumerator = t.ChildElements.GetEnumerator();
            Assert.Same(emptyEnumeratorSingleton, enumerator);
            Assert.False(enumerator.MoveNext());

            // unknown1, one child
            Assert.NotSame(emptyListSingleton, unknown1.ChildElements);
            Assert.Equal(1, unknown1.ChildElements.Count);
            enumerator = unknown1.ChildElements.GetEnumerator();
            Assert.NotSame(emptyEnumeratorSingleton, enumerator);
            Assert.True(enumerator.MoveNext());

            // unknown2, empty children
            Assert.Same(emptyListSingleton, unknown2.ChildElements);
            Assert.Equal(0, unknown2.ChildElements.Count);
            enumerator = unknown2.ChildElements.GetEnumerator();
            Assert.Same(emptyEnumeratorSingleton, enumerator);
            Assert.False(enumerator.MoveNext());

            // miscNode
            Assert.Same(emptyListSingleton, miscNode.ChildElements);
            Assert.Equal(0, miscNode.ChildElements.Count);
            enumerator = miscNode.ChildElements.GetEnumerator();
            Assert.Same(emptyEnumeratorSingleton, enumerator);
            Assert.False(enumerator.MoveNext());
        }

        /// <summary>
        /// test the namespace declaration property
        /// </summary>
        [Fact]
        public void NSDeclTest()
        {
            var p = new Paragraph();
            p.ParagraphId = "123";
            //NamespaceDeclarations is not null
            Assert.Equal(0, p.NamespaceDeclarations.Count());

            p.AddNamespaceDeclaration("a", "http://b");
            p.SetAttribute(new OpenXmlAttribute("t", "tt", "http://t", "abcd"));

            Assert.Equal(null, p.LookupPrefix("http://t"));
            Assert.Equal(null, p.LookupPrefix("http://schemas.microsoft.com/office/word/2010/wordml\""));

            var xmlcontent = "<w:p xmlns:a=\"http://b\" w14:paraId=\"123\" t:tt=\"abcd\" xmlns:t=\"http://t\" xmlns:w14=\"http://schemas.microsoft.com/office/word/2010/wordml\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" />";
            Assert.Equal(xmlcontent, p.OuterXml);
            Assert.Equal(1, p.ExtendedAttributes.Count());
            Assert.Equal(1, p.NamespaceDeclarations.Count());

            p = new Paragraph(xmlcontent);
            Assert.Equal(1, p.ExtendedAttributes.Count());
            Assert.Equal(4, p.NamespaceDeclarations.Count());

            Assert.Equal("a", p.LookupPrefix("http://b"));

            Assert.Equal("t", p.LookupPrefix("http://t"));
            Assert.Equal("w14", p.LookupPrefix("http://schemas.microsoft.com/office/word/2010/wordml"));

            p.RemoveNamespaceDeclaration("t");
            Assert.Equal(null, p.LookupPrefix("http://t"));
        }

        /// <summary>
        /// test the openxmlreader/writer with namespace declaration
        /// </summary>
        [Fact]
        public void ReaderWithNsTest()
        {
            using (MemoryStream stream = new MemoryStream(TestFileStreams.mcdoc))
            using (var doc = WordprocessingDocument.Open(stream, false))
            using (var reader = OpenXmlPartReader.Create(doc.MainDocumentPart))
            {
                reader.Read();
                Assert.Equal(15, reader.NamespaceDeclarations.Count());
                reader.Read();
                Assert.Equal(0, reader.NamespaceDeclarations.Count());
            }

            var xml = "<document xmlns=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><body/></document>";
            var r1 = OpenXmlDomReader.Create(new Document(xml));
            r1.Read();
            Assert.Equal(0, r1.NamespaceDeclarations.Count());

            xml = "<w:document xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:body a=\"1\"/></w:document>";
            r1 = OpenXmlDomReader.Create(new Document(xml));
            r1.Read();
            Assert.Equal(1, r1.NamespaceDeclarations.Count());
            Assert.Equal(0, r1.Attributes.Count);
            Assert.Equal(false, r1.HasAttributes);
            r1.Read();
            Assert.Equal(0, r1.NamespaceDeclarations.Count());
            Assert.Equal(1, r1.Attributes.Count);
            Assert.Equal(true, r1.HasAttributes);
        }

        /// <summary>
        /// test the openxmlreader/writer with namespace declaration
        /// </summary>
        [Fact]
        public void WriterWithNsTest()
        {
            using (var memStream = new MemoryStream())
            {
                using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
                {
                    target.WriteStartDocument();
                    target.WriteStartElement(new Document());

                    target.WriteStartElement(new Body(), new List<OpenXmlAttribute>() { new OpenXmlAttribute("a:a", "http://aa", "ab") });

                    target.WriteStartElement(new Paragraph(), null, null);
                    target.WriteEndElement();

                    List<KeyValuePair<string, string>> ns = new List<KeyValuePair<string, string>>();
                    KeyValuePair<string, string> item = new KeyValuePair<string, string>("b", "http://aaa");
                    ns.Add(item);
                    target.WriteStartElement(new Table(), null, ns);
                    target.WriteEndElement();

                    target.WriteEndElement();
                    
                    target.WriteEndElement();
                    target.Close();
                }
                memStream.Flush();
                memStream.Seek(0, SeekOrigin.Begin);

                using (var reader = new OpenXmlPartReader(memStream))
                {
                    //<w:document>
                    reader.Read();
                    Assert.Equal(1, reader.NamespaceDeclarations.Count());

                    //<w:body>
                    reader.Read();
                    Assert.Equal(1, reader.NamespaceDeclarations.Count());

                    //<w:p>
                    reader.ReadFirstChild();
                    Assert.True(reader.ElementType.Name.EndsWith("Paragraph"));
                    Assert.Equal(0, reader.NamespaceDeclarations.Count());

                    //<w:p>
                    reader.ReadNextSibling();
                    Assert.True(reader.ElementType.Name.EndsWith("Table"));
                    Assert.Equal(1, reader.NamespaceDeclarations.Count());


                }
            }
        }

        /// <summary>
        /// test the clone method
        /// </summary>
        [Fact]
        public void CloneTest()
        {
            var xml = "<document xmlns=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><body a:b=\"2\" xmlns:a=\"http://a\"/></document>";
            var node = new Document(xml);
            var nod1 = node.Clone() as Document;

            Assert.Equal(node.ExtendedAttributes.Count(), nod1.ExtendedAttributes.Count());
            Assert.Equal(node.OuterXml, nod1.OuterXml);
            Assert.Equal(node.Body.OuterXml, nod1.Body.OuterXml);

        }

        /// <summary>
        /// Test for OpenXmlLeafElement / OpenXmlLeafTextElement on loading redundant childre.
        /// </summary>
        [Fact]
        public void LeafAndLeafTextElementLoadTest()
        {
            string runOuterXml = "<w:r xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\">" +
            "<w:rPr><w:strike /><w:vanish><!-- comments is ok --></w:vanish><w:webHidden><w:invalidChild /></w:webHidden></w:rPr>" +
            "<w:t>Run Text.</w:t><w:t><!-- comments is ok -->Text 2</w:t><w:t>Text 3.<invalidElement /></w:t></w:r>";
        
            var openxmlElement = new Run(runOuterXml);

            var strike = openxmlElement.RunProperties.Strike;
            Assert.Null(strike.ShadowElement);

            var varnish = openxmlElement.RunProperties.Vanish;
            Assert.Equal(XmlNodeType.Comment, (varnish.ShadowElement.FirstChild as OpenXmlMiscNode).XmlNodeType);
            Assert.Equal("<!-- comments is ok -->", varnish.InnerXml);
            Assert.Equal("<w:vanish xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><!-- comments is ok --></w:vanish>", varnish.OuterXml);

            var webHidden = openxmlElement.RunProperties.WebHidden;
            Assert.Equal("invalidChild", (webHidden.ShadowElement.FirstChild as OpenXmlUnknownElement).LocalName);
            Assert.Equal("<w:invalidChild xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" />", webHidden.InnerXml);
            Assert.Equal("<w:webHidden xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:invalidChild xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" /></w:webHidden>", webHidden.OuterXml);

            var t1 = openxmlElement.GetFirstChild<Text>();
            Assert.Null(t1.ShadowElement);
            Assert.Equal("Run Text.", t1.Text);
            Assert.Equal("Run Text.", t1.InnerXml);
            Assert.Equal("<w:t xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\">Run Text.</w:t>", t1.OuterXml);

            var t2 = t1.NextSibling() as Text;
            Assert.Equal(XmlNodeType.Comment, (t2.ShadowElement.FirstChild as OpenXmlMiscNode).XmlNodeType);
            Assert.Equal("Text 2", t2.Text);
            Assert.Equal("<!-- comments is ok -->Text 2", t2.InnerXml);
            Assert.Equal("<w:t xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><!-- comments is ok -->Text 2</w:t>", t2.OuterXml);

            var t3 = t2.NextSibling() as Text;
            Assert.Equal(XmlNodeType.Text, (t3.ShadowElement.FirstChild as OpenXmlMiscNode).XmlNodeType);
            Assert.Equal("invalidElement", (t3.ShadowElement.LastChild as OpenXmlUnknownElement).LocalName);
            Assert.Equal("Text 3.", t3.Text);
            Assert.Equal("Text 3.<invalidElement />", t3.InnerXml);
            Assert.Equal("<w:t xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\">Text 3.<invalidElement /></w:t>", t3.OuterXml);

            // bug #725597
            var run = new Run("<w:r xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:t xml:space=\"preserve\"><w:rFonts w:hint=\"eastAsia\" /></w:t></w:r>");
            var text = run.FirstChild as Text;
            Assert.Equal("<w:rFonts w:hint=\"eastAsia\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" />", text.InnerXml);
            Assert.Equal("<w:t xml:space=\"preserve\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:rFonts w:hint=\"eastAsia\" /></w:t>", text.OuterXml);
        }

        /// <summary>
        /// A test for creating O15 elements
        /// </summary>
        [Fact]
        public void O15ElementTest()
        {
            try
            {
                // Well, if CommentEx is not integrated in the SDK, we can't even compile this unit test project...

                // Check if CommentEx is available.
                DocumentFormat.OpenXml.Office2013.Word.CommentEx commentEx = new DocumentFormat.OpenXml.Office2013.Word.CommentEx();
                Assert.NotNull(commentEx);
            }
            catch
            {
                Assert.True(false); // Assert.Fail("Should not throw exception.");
            }
        }
    }
}
