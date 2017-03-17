// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml;
using Xunit;
using System.Collections.ObjectModel;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.Globalization;
using System.Text;


namespace DocumentFormat.OpenXml.Tests
{
    
    
    /// <summary>
    ///This is a test class for OpenXmlReaderTest and is intended
    ///to contain all OpenXmlReaderTest Unit Tests
    ///</summary>
    
    public class OpenXmlReaderTest
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
        ///A test for OpenXmlDomReader
        ///</summary>
        [Fact]
        public void DomReaderBasicTest()
        {
            bool moved = false;
            string paragraphOuterXml = "<w:p w:rsidP=\"001\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>";
            Paragraph para = new Paragraph(paragraphOuterXml);

            OpenXmlReader targetReader = OpenXmlReader.Create(para);
            targetReader.Read();

            TestReaderOnParagraph(targetReader);

            moved = targetReader.Read(); // should be false

            Assert.False(moved);
            Assert.True(targetReader.EOF);
            Assert.True(string.IsNullOrEmpty(targetReader.GetText()));

            targetReader.Close();

            targetReader = OpenXmlReader.Create(para);
            targetReader.Read();

            moved = targetReader.ReadFirstChild(); // read to <w:r>

            OpenXmlElement element = targetReader.LoadCurrentElement();

            // at the end of the run
            Assert.False(targetReader.EOF);
            Assert.NotNull(targetReader.Attributes);
            Assert.Equal(0, targetReader.Attributes.Count);
            Assert.False(targetReader.HasAttributes);
            Assert.False(targetReader.IsStartElement);
            Assert.True(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.Equal(typeof(Run), targetReader.ElementType);
            Assert.True(string.IsNullOrEmpty(targetReader.GetText()));

            // loaded element is Run
            Assert.NotNull(element);
            Assert.IsType(typeof(Run), element);

            Run run = (Run)element;
            Assert.Equal("Run Text.", (run.FirstChild as Text).Text);
            Assert.Equal("Run 2.", (run.LastChild as Text).Text);

            targetReader.Close();
        }

         
        /// <summary>
        ///A test for OpenXmlDomReader operations on root element.
        ///</summary>
        [Fact]
        public void DomReaderRootCaseTest()
        {
            Body body = new Body(new Paragraph(new ParagraphProperties(), new Run(new Text("test"))));

            //======== new test with a new reader ========
            OpenXmlReader reader = OpenXmlReader.Create(body);
            Assert.False(reader.EOF);

            bool moved = reader.Read();
            Assert.True(moved);
            Assert.False(reader.EOF);
            Assert.Equal(0, reader.Depth);
            Assert.True(reader.IsStartElement);
            Assert.False(reader.IsEndElement);
            Assert.False(reader.IsMiscNode);

            // ReadNextSibling on root start
            moved = reader.ReadNextSibling();
            Assert.False(moved);
            Assert.True(reader.EOF);

            reader.Close();

            //======== new test with a new reader ========
            reader = OpenXmlReader.Create(body);
            Assert.False(reader.EOF);

            moved = reader.Read();
            moved = reader.ReadFirstChild();
            Assert.True(moved);
            Assert.True(reader.IsStartElement);
            Assert.False(reader.IsEndElement);
            Assert.False(reader.IsMiscNode);
            Assert.False(reader.EOF);
            Assert.Equal(1, reader.Depth);
            Assert.Equal("p", reader.LocalName);

            moved = reader.ReadNextSibling();
            Assert.False(moved); // no more sibling
            Assert.True(reader.IsEndElement); // should on Body end now.
            Assert.False(reader.IsStartElement);
            Assert.False(reader.IsMiscNode);
            Assert.False(reader.EOF);
            Assert.Equal(0, reader.Depth);
            Assert.Equal("body", reader.LocalName);
                        
            // ReadNextSibling on root end
            moved = reader.ReadNextSibling();
            Assert.False(moved);
            Assert.True(reader.EOF); // should be EOF now.

            reader.Close();

            //======== new test with a new reader ========
            reader = OpenXmlReader.Create(body);
            Assert.False(reader.EOF);

            moved = reader.Read();

            // bug #248145 
            // call Skip on root start
            reader.Skip();
            Assert.True(reader.EOF);

            //======== new test with a new reader ========
            reader = OpenXmlReader.Create(body);
            Assert.False(reader.EOF);

            moved = reader.Read();
            moved = reader.ReadFirstChild();

            reader.Skip();
            Assert.True(reader.IsEndElement); // should on Body end now.
            Assert.False(reader.IsStartElement);
            Assert.False(reader.IsMiscNode);
            Assert.False(reader.EOF);
            Assert.Equal(0, reader.Depth);
            Assert.Equal("body", reader.LocalName);

            // call Skip on root end
            reader.Skip();
            Assert.True(reader.EOF);

            reader.Close();

            //======== new test with a new reader ========
            reader = OpenXmlReader.Create(body);
            Assert.False(reader.EOF);

            moved = reader.Read();
            moved = reader.ReadFirstChild();

            reader.Skip();

            // call Read on root end
            moved = reader.Read();
            Assert.False(moved);
            Assert.True(reader.EOF);

            // additional operations should return false.
            moved = reader.Read();
            Assert.False(moved);

            moved = reader.ReadFirstChild();
            Assert.False(moved);

            moved = reader.ReadNextSibling();
            Assert.False(moved);

            reader.Skip();

            reader.Close();
        }

        
        /// <summary>
        ///A test for OpenXmlDomReader on misc node
        ///</summary>
        [Fact]
        public void DomReaderMiscNodeTest()
        {
            Body body = new Body(new Paragraph(new ParagraphProperties(), new Run(new Text("test"))));
            body.PrependChild( new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- start body -->"));

            //======== new test with a new reader ========
            OpenXmlReader reader = OpenXmlReader.Create(body, true); // read misc nodes 
            Assert.False(reader.EOF);

            bool moved = reader.Read();
            Assert.True(moved);
            Assert.False(reader.EOF);
            Assert.Equal(0, reader.Depth);
            Assert.True(reader.IsStartElement);
            Assert.False(reader.IsEndElement);
            Assert.False(reader.IsMiscNode);
            Assert.Equal("body", reader.LocalName);

            moved = reader.Read();
            Assert.True(moved);
            Assert.False(reader.EOF);
            Assert.Equal(1, reader.Depth);
            Assert.False(reader.IsStartElement);
            Assert.False(reader.IsEndElement);
            Assert.True(reader.IsMiscNode);
            Assert.Equal("#comment", reader.LocalName);

            Assert.Equal(string.Empty, reader.Prefix);
            Assert.Equal(string.Empty, reader.NamespaceUri);

            reader.Close();

            // test case: for ReadFirstChild
            reader = OpenXmlReader.Create(body, true); // read misc nodes 
            Assert.False(reader.EOF);

            moved = reader.Read();
            Assert.False(reader.EOF);

            moved = reader.ReadFirstChild();
            Assert.True(moved);
            Assert.False(reader.EOF);
            Assert.Equal(1, reader.Depth);
            Assert.False(reader.IsStartElement);
            Assert.False(reader.IsEndElement);
            Assert.True(reader.IsMiscNode);
            Assert.Equal("#comment", reader.LocalName);

            Assert.Equal(string.Empty, reader.Prefix);
            Assert.Equal(string.Empty, reader.NamespaceUri);

            reader.Close();

            OpenXmlElement miscNode = body.RemoveChild(body.FirstChild);
            body.AppendChild(miscNode);

            reader = OpenXmlReader.Create(body, true); // read misc nodes 
            Assert.False(reader.EOF);

            moved = reader.Read();
            Assert.False(reader.EOF);

            moved = reader.ReadFirstChild();
            reader.Skip();

            Assert.True(moved);
            Assert.False(reader.EOF);
            Assert.Equal(1, reader.Depth);
            Assert.False(reader.IsStartElement);
            Assert.False(reader.IsEndElement);
            Assert.True(reader.IsMiscNode);

            Assert.Equal(string.Empty, reader.Prefix);
            Assert.Equal(string.Empty, reader.NamespaceUri);

            reader.Close();

            // test case: root element is misc node
            reader = OpenXmlReader.Create(new OpenXmlMiscNode(System.Xml.XmlNodeType.ProcessingInstruction, "<?pi test?>"), true);
            moved = reader.Read();
            Assert.True(moved);
            Assert.False(reader.EOF);
            Assert.Equal(0, reader.Depth);
            Assert.False(reader.IsStartElement);
            Assert.False(reader.IsEndElement);
            Assert.True(reader.IsMiscNode);
            Assert.Equal("pi", reader.LocalName);

            Assert.Equal(string.Empty, reader.Prefix);
            Assert.Equal(string.Empty, reader.NamespaceUri);

            reader.Close();

            // case bug #253890
            body = new Body(new Paragraph(new ParagraphProperties(), new Run(new Text("test"))));
            miscNode = body.AppendChild(new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- start body -->"));

            reader = OpenXmlReader.Create(body.FirstChild, true);
            moved = reader.Read();
            Assert.True(moved);
            Assert.False(reader.EOF);
            Assert.Equal(0, reader.Depth);
            Assert.True(reader.IsStartElement);
            Assert.False(reader.IsEndElement);
            Assert.False(reader.IsMiscNode);
            Assert.Equal("p", reader.LocalName);

            reader.Skip();
            Assert.True(reader.EOF);

            reader.Close();

            // case bug #253890
            reader = OpenXmlReader.Create(body.FirstChild, true);
            moved = reader.Read();

            reader.ReadNextSibling();
            Assert.True(reader.EOF);

            reader.Close();

            // case bug #253890
            reader = OpenXmlReader.Create(body.FirstChild, true);
            moved = reader.Read();
            moved = reader.Read();
            moved = reader.ReadNextSibling();
            moved = reader.ReadNextSibling();
            Assert.False(moved);
            Assert.False(reader.EOF);
            Assert.Equal(0, reader.Depth);
            Assert.False(reader.IsStartElement);
            Assert.True(reader.IsEndElement);
            Assert.False(reader.IsMiscNode);
            Assert.Equal("p", reader.LocalName);

            // call ReadNextSibling() on EndElement
            reader.ReadNextSibling();
            Assert.True(reader.EOF);


        }

        /// <summary>
        ///A test for OpenXmlPartReader on misc node
        ///</summary>
        [Fact]
        public void PartReaderMiscNodeTest()
        {
            string partText = "<w:document xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\">" +
                                "<!-- start body -->" +
                                "<w:body>" +
                                    "<w:p w:rsidP=\"001\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>" +
                               "</w:body>" +
                              "</w:document>";

            UTF8Encoding utf8Encoding = new UTF8Encoding();
            Stream stream = new MemoryStream(utf8Encoding.GetBytes(partText), false);

            //======== new test with a new reader ========
            OpenXmlReader reader = OpenXmlReader.Create(stream, true); // read misc nodes 
            Assert.False(reader.EOF);

            bool moved = reader.Read();
            Assert.True(moved);
            Assert.False(reader.EOF);
            Assert.Equal(0, reader.Depth);
            Assert.True(reader.IsStartElement);
            Assert.False(reader.IsEndElement);
            Assert.False(reader.IsMiscNode);

            moved = reader.Read();
            Assert.True(moved);
            Assert.False(reader.EOF);
            Assert.Equal(1, reader.Depth);
            Assert.False(reader.IsStartElement);
            Assert.False(reader.IsEndElement);
            Assert.True(reader.IsMiscNode);

            Assert.Equal(string.Empty, reader.Prefix);
            Assert.Equal(string.Empty, reader.NamespaceUri);

            reader.Close();
        }

        /// <summary>
        ///A test for OpenXmlPartReader
        ///</summary>
        [Fact]
        public void PartReaderBasicTest()
        {
            string partText =  "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>" +
                               "<w:document xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\">" +
                               "<w:body>" +
                               "<w:p w:rsidP=\"001\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>" +
                               "<w:p w:rsidP=\"001\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>" +
                               "</w:body>" +
                               "</w:document>";

            UTF8Encoding utf8Encoding = new UTF8Encoding();                
            Stream stream = new MemoryStream( utf8Encoding.GetBytes(partText), false );

            OpenXmlReader targetReader = OpenXmlReader.Create(stream);            
            targetReader.Read();

            Assert.False(targetReader.EOF);
            Assert.NotNull(targetReader.Attributes);
            Assert.Equal(0, targetReader.Attributes.Count);
            Assert.False(targetReader.HasAttributes);
            Assert.True(targetReader.IsStartElement);
            Assert.False(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.True(string.IsNullOrEmpty(targetReader.GetText()));
            Assert.Equal(typeof(Document), targetReader.ElementType);

            targetReader.ReadFirstChild(); // to <w:body>
            targetReader.Read(); // to <w:p>

            TestReaderOnParagraph(targetReader);

            Assert.False(targetReader.EOF);
            Assert.NotNull(targetReader.Attributes);
            Assert.Equal(0, targetReader.Attributes.Count);
            Assert.False(targetReader.HasAttributes);
            Assert.False(targetReader.IsStartElement);
            Assert.True(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.Equal(typeof(Paragraph), targetReader.ElementType);
            Assert.True(string.IsNullOrEmpty(targetReader.GetText()));

            targetReader.ReadNextSibling(); // next <w:p>

            OpenXmlElement element = targetReader.LoadCurrentElement();

            // at </w:p>
            Assert.False(targetReader.EOF);
            Assert.NotNull(targetReader.Attributes);
            Assert.Equal(0, targetReader.Attributes.Count);
            Assert.False(targetReader.HasAttributes);
            Assert.False(targetReader.IsStartElement);
            Assert.True(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.Equal(typeof(Paragraph), targetReader.ElementType);
            Assert.True(string.IsNullOrEmpty(targetReader.GetText()));

            // loaded element is Run
            Assert.NotNull(element);
            Assert.IsType(typeof(Paragraph), element);

            Run run = (Run)(element.FirstChild);
            Assert.Equal("Run Text.", (run.FirstChild as Text).Text);
            Assert.Equal("Run 2.", (run.LastChild as Text).Text);

            targetReader.Close();

        }

        ///<summary>
        ///TestReaderOnPragraph.
        ///</summary>
        public void TestReaderOnParagraph(OpenXmlReader targetReader)
        {
            bool moved = false;
            
            Assert.False(targetReader.EOF);
            Assert.NotNull(targetReader.Attributes);
            Assert.Equal(1, targetReader.Attributes.Count);
            Assert.True(targetReader.HasAttributes);
            Assert.True(targetReader.IsStartElement);
            Assert.False(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.True(string.IsNullOrEmpty(targetReader.GetText()));
            Assert.Equal(typeof(Paragraph), targetReader.ElementType);

            moved = targetReader.Read(); // read to <w:r>

            Assert.True(moved);
            Assert.False(targetReader.EOF);
            Assert.NotNull(targetReader.Attributes);
            Assert.Equal(0, targetReader.Attributes.Count);
            Assert.False(targetReader.HasAttributes);
            Assert.True(targetReader.IsStartElement);
            Assert.False(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.True(string.IsNullOrEmpty(targetReader.GetText()));
            Assert.Equal(typeof(Run), targetReader.ElementType);

            moved = targetReader.ReadFirstChild(); // read to <w:t>

            Assert.True(moved);
            Assert.False(targetReader.EOF);
            Assert.NotNull(targetReader.Attributes);
            Assert.Equal(0, targetReader.Attributes.Count);
            Assert.False(targetReader.HasAttributes);
            Assert.True(targetReader.IsStartElement);
            Assert.False(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.Equal(typeof(Text), targetReader.ElementType);
            Assert.False(string.IsNullOrEmpty(targetReader.GetText()));
            Assert.Equal("Run Text.", targetReader.GetText());

            moved = targetReader.Read(); // read to </w:t>

            Assert.True(moved);
            Assert.False(targetReader.EOF);
            Assert.NotNull(targetReader.Attributes);
            Assert.Equal(0, targetReader.Attributes.Count);
            Assert.False(targetReader.HasAttributes);
            Assert.False(targetReader.IsStartElement);
            Assert.True(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.Equal(typeof(Text), targetReader.ElementType);
            Assert.True(string.IsNullOrEmpty(targetReader.GetText()));

            moved = targetReader.ReadNextSibling(); // read to <w:t>

            Assert.True(moved);
            Assert.False(targetReader.EOF);
            Assert.NotNull(targetReader.Attributes);
            Assert.Equal(0, targetReader.Attributes.Count);
            Assert.False(targetReader.HasAttributes);
            Assert.True(targetReader.IsStartElement);
            Assert.False(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.Equal(typeof(Text), targetReader.ElementType);
            Assert.False(string.IsNullOrEmpty(targetReader.GetText()));
            Assert.Equal("Run 2.", targetReader.GetText());

            moved = targetReader.ReadNextSibling(); // read to </w:r>, skip the </w:t>

            Assert.False(moved);
            Assert.False(targetReader.EOF);
            Assert.NotNull(targetReader.Attributes);
            Assert.Equal(0, targetReader.Attributes.Count);
            Assert.False(targetReader.HasAttributes);
            Assert.False(targetReader.IsStartElement);
            Assert.True(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.Equal(typeof(Run), targetReader.ElementType);
            Assert.True(string.IsNullOrEmpty(targetReader.GetText()));

            moved = targetReader.Read(); // read to </w:p>

            Assert.True(moved);
            Assert.False(targetReader.EOF);
            Assert.NotNull(targetReader.Attributes);
            Assert.Equal(0, targetReader.Attributes.Count);
            Assert.False(targetReader.HasAttributes);
            Assert.False(targetReader.IsStartElement);
            Assert.True(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.Equal(typeof(Paragraph), targetReader.ElementType);
            Assert.True(string.IsNullOrEmpty(targetReader.GetText()));
        }
    }
}
