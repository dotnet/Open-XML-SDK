// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.Text;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    ///This is a test class for OpenXmlReaderTest and is intended
    ///to contain all OpenXmlReaderTest Unit Tests
    ///</summary>
    public class OpenXmlReaderTest
    {
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
            Assert.Empty(targetReader.Attributes);
            Assert.False(targetReader.HasAttributes);
            Assert.False(targetReader.IsStartElement);
            Assert.True(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.Equal(typeof(Run), targetReader.ElementType);
            Assert.True(string.IsNullOrEmpty(targetReader.GetText()));
            Assert.False(targetReader.GetLineInfo().HasLineInfo());

            // loaded element is Run
            Assert.NotNull(element);
            Assert.IsType<Run>(element);

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
            using (OpenXmlReader reader = OpenXmlReader.Create(body))
            {
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
            }

            //======== new test with a new reader ========
            using (var reader = OpenXmlReader.Create(body))
            {
                Assert.False(reader.EOF);

                var moved = reader.Read();
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
            }

            //======== new test with a new reader ========
            using (var reader = OpenXmlReader.Create(body))
            {
                Assert.False(reader.EOF);

                var moved = reader.Read();

                // bug #248145
                // call Skip on root start
                reader.Skip();
                Assert.True(reader.EOF);
            }

            //======== new test with a new reader ========
            using (var reader = OpenXmlReader.Create(body))
            {
                Assert.False(reader.EOF);

                var moved = reader.Read();
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
            }

            //======== new test with a new reader ========
            using (var reader = OpenXmlReader.Create(body))
            {
                Assert.False(reader.EOF);

                var moved = reader.Read();
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
            }
        }

        /// <summary>
        ///A test for OpenXmlDomReader on misc node
        ///</summary>
        [Fact]
        public void DomReaderMiscNodeTest()
        {
            Body body = new Body(new Paragraph(new ParagraphProperties(), new Run(new Text("test"))));
            body.PrependChild(new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- start body -->"));

            //======== new test with a new reader ========
            using (OpenXmlReader reader = OpenXmlReader.Create(body, true)) // read misc node
            {
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
            }

            // test case: for ReadFirstChild
            using (var reader = OpenXmlReader.Create(body, true)) // read misc nodes
            {
                Assert.False(reader.EOF);

                var moved = reader.Read();
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
            }

            OpenXmlElement miscNode = body.RemoveChild(body.FirstChild);
            body.AppendChild(miscNode);

            using (var reader = OpenXmlReader.Create(body, true)) // read misc nodes
            {
                Assert.False(reader.EOF);

                var moved = reader.Read();
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
            }

            // test case: root element is misc node
            using (var reader = OpenXmlReader.Create(new OpenXmlMiscNode(System.Xml.XmlNodeType.ProcessingInstruction, "<?pi test?>"), true))
            {
                var moved = reader.Read();
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
            }

            // case bug #253890
            body = new Body(new Paragraph(new ParagraphProperties(), new Run(new Text("test"))));
            miscNode = body.AppendChild(new OpenXmlMiscNode(System.Xml.XmlNodeType.Comment, "<!-- start body -->"));

            using (var reader = OpenXmlReader.Create(body.FirstChild, true))
            {
                var moved = reader.Read();
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
            }

            // case bug #253890
            using (var reader = OpenXmlReader.Create(body.FirstChild, true))
            {
                var moved = reader.Read();

                reader.ReadNextSibling();
                Assert.True(reader.EOF);
            }

            // case bug #253890
            using (var reader = OpenXmlReader.Create(body.FirstChild, true))
            {
                var moved = reader.Read();
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
            Assert.True(reader.GetLineInfo().HasLineInfo());
            Assert.Equal(1, reader.GetLineInfo().LineNumber);
            Assert.Equal(2, reader.GetLineInfo().LinePosition);

            moved = reader.Read();
            Assert.True(moved);
            Assert.False(reader.EOF);
            Assert.Equal(1, reader.Depth);
            Assert.False(reader.IsStartElement);
            Assert.False(reader.IsEndElement);
            Assert.True(reader.IsMiscNode);
            Assert.True(reader.GetLineInfo().HasLineInfo());
            Assert.Equal(1, reader.GetLineInfo().LineNumber);
            Assert.Equal(88, reader.GetLineInfo().LinePosition);

            Assert.Equal(string.Empty, reader.Prefix);
            Assert.Equal(string.Empty, reader.NamespaceUri);

            reader.Close();
        }

        /// <summary>
        ///A test for OpenXmlPartReader to test the ignoreWhitespace option
        ///</summary>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void PartReaderIgnoreWhitespaceTest(bool ignoreWhitespace)
        {
            const string PartText = "<w:document xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\">" +
                "<w:body>" +
                "<w:p w:rsidP=\"001\"><w:r><w:t>  </w:t></w:r></w:p>" +
                "</w:body>" +
                "</w:document>";

            using var stream = new MemoryStream(Encoding.UTF8.GetBytes(PartText), false);

            using var reader = OpenXmlReader.Create(stream, false, ignoreWhitespace);
            Assert.False(reader.EOF);

            reader.Read();
            Assert.False(reader.EOF);

            reader.ReadFirstChild();
            Assert.True(reader.IsStartElement);
            Assert.Equal(typeof(Body), reader.ElementType);
            reader.Read();
            Assert.True(reader.IsStartElement);
            Assert.Equal(typeof(Paragraph), reader.ElementType);
            reader.Read();
            Assert.True(reader.IsStartElement);
            Assert.Equal(typeof(Run), reader.ElementType);
            reader.Read();
            Assert.True(reader.IsStartElement);
            Assert.Equal(typeof(Text), reader.ElementType);
            Assert.Equal(ignoreWhitespace, reader.GetText() == string.Empty);

            reader.Close();
        }

        /// <summary>
        /// Test that the OpenXmlReader can handle formatted xml.
        ///</summary>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void TestIgnoreWhitespaceWithFormattedXml(bool ignoreWhitespace) {
            const string PartText = @"
    <w:document xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main"">
      <w:body>
        <w:p>
          <w:r>
            <w:t>First Text</w:t>
          </w:r>
        </w:p>
      </w:body>
    </w:document>";

            using var stream = new MemoryStream(Encoding.UTF8.GetBytes(PartText), false);
            using var reader = OpenXmlReader.Create(stream, false, ignoreWhitespace);
            Assert.True(reader.Read());
            Assert.False(reader.EOF);
            Assert.Equal(typeof(Document), reader.ElementType);
            Assert.True(reader.IsStartElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Body), reader.ElementType);
            Assert.True(reader.IsStartElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Paragraph), reader.ElementType);
            Assert.True(reader.IsStartElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Run), reader.ElementType);
            Assert.True(reader.IsStartElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Text), reader.ElementType);
            Assert.True(reader.IsStartElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Text), reader.ElementType);
            Assert.True(reader.IsEndElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Run), reader.ElementType);
            Assert.True(reader.IsEndElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Paragraph), reader.ElementType);
            Assert.True(reader.IsEndElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Body), reader.ElementType);
            Assert.True(reader.IsEndElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Document), reader.ElementType);
            Assert.True(reader.IsEndElement);
            Assert.False(reader.Read());
            Assert.True(reader.EOF);

            reader.Close();
    }

        /// <summary>
        /// Test that the OpenXmlReader can handle a whitespace after the last element.
        ///</summary>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void TestIgnoreWhitespaceWhitespaceAfterLastElement(bool ignoreWhitespace) {
            const string PartText = @"
    <w:document xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main"">
      <w:body>
        <w:p>
        </w:p>
      </w:body>
    </w:document> ";

            using var stream = new MemoryStream(Encoding.UTF8.GetBytes(PartText), false);
            using var reader = OpenXmlReader.Create(stream, false, ignoreWhitespace);
            Assert.True(reader.Read());
            Assert.False(reader.EOF);
            Assert.Equal(typeof(Document), reader.ElementType);
            Assert.True(reader.IsStartElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Body), reader.ElementType);
            Assert.True(reader.IsStartElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Paragraph), reader.ElementType);
            Assert.True(reader.IsStartElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Paragraph), reader.ElementType);
            Assert.True(reader.IsEndElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Body), reader.ElementType);
            Assert.True(reader.IsEndElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Document), reader.ElementType);
            Assert.True(reader.IsEndElement);
            Assert.False(reader.Read());
            Assert.True(reader.EOF);

            reader.Close();
        }

        /// <summary>
        /// Test that the OpenXmlReader can handle a misc node after the last element.
        ///</summary>
        [Fact]
        public void TestMiscNodeAfterDocument() {
            const string PartText = @"
    <w:document xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main"">
      <w:body>
        <w:p>
        </w:p>
      </w:body>
    </w:document> <!--Your comment-->";

            using var stream = new MemoryStream(Encoding.UTF8.GetBytes(PartText), true);
            using var reader = OpenXmlReader.Create(stream);
            Assert.True(reader.Read());
            Assert.False(reader.EOF);
            Assert.Equal(typeof(Document), reader.ElementType);
            Assert.True(reader.IsStartElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Body), reader.ElementType);
            Assert.True(reader.IsStartElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Paragraph), reader.ElementType);
            Assert.True(reader.IsStartElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Paragraph), reader.ElementType);
            Assert.True(reader.IsEndElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Body), reader.ElementType);
            Assert.True(reader.IsEndElement);
            Assert.True(reader.Read());
            Assert.Equal(typeof(Document), reader.ElementType);
            Assert.True(reader.IsEndElement);

            // not reading the misc node after the end of the document
            Assert.False(reader.Read());
            Assert.True(reader.EOF);
            reader.Close();
        }

        /// <summary>
        ///A test for OpenXmlPartReader
        ///</summary>
        [Fact]
        public void PartReaderBasicTest()
        {
            string partText = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>" +
                               "<w:document xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\">" +
                               "<w:body>" +
                               "<w:p w:rsidP=\"001\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>" +
                               "<w:p w:rsidP=\"001\"><w:r><w:t>Run Text.</w:t><w:t>Run 2.</w:t></w:r></w:p>" +
                               "</w:body>" +
                               "</w:document>";

            UTF8Encoding utf8Encoding = new UTF8Encoding();
            Stream stream = new MemoryStream(utf8Encoding.GetBytes(partText), false);

            OpenXmlReader targetReader = OpenXmlReader.Create(stream);
            targetReader.Read();

            Assert.False(targetReader.EOF);
            Assert.NotNull(targetReader.Attributes);
            Assert.Empty(targetReader.Attributes);
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
            Assert.Empty(targetReader.Attributes);
            Assert.False(targetReader.HasAttributes);
            Assert.False(targetReader.IsStartElement);
            Assert.True(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.Equal(typeof(Paragraph), targetReader.ElementType);
            Assert.True(string.IsNullOrEmpty(targetReader.GetText()));
            Assert.True(targetReader.GetLineInfo().HasLineInfo());
            Assert.Equal(1, targetReader.GetLineInfo().LineNumber);
            Assert.Equal(216, targetReader.GetLineInfo().LinePosition);

            targetReader.ReadNextSibling(); // next <w:p>

            OpenXmlElement element = targetReader.LoadCurrentElement();

            // at </w:p>
            Assert.False(targetReader.EOF);
            Assert.NotNull(targetReader.Attributes);
            Assert.Empty(targetReader.Attributes);
            Assert.False(targetReader.HasAttributes);
            Assert.False(targetReader.IsStartElement);
            Assert.True(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.Equal(typeof(Paragraph), targetReader.ElementType);
            Assert.True(string.IsNullOrEmpty(targetReader.GetText()));
            Assert.Equal(1, targetReader.GetLineInfo().LineNumber);
            Assert.Equal(295, targetReader.GetLineInfo().LinePosition);

            // loaded element is Run
            Assert.NotNull(element);
            Assert.IsType<Paragraph>(element);

            Run run = (Run)element.FirstChild;
            Assert.Equal("Run Text.", (run.FirstChild as Text).Text);
            Assert.Equal("Run 2.", (run.LastChild as Text).Text);

            targetReader.Close();
        }

        ///<summary>
        ///TestReaderOnPragraph.
        ///</summary>
        private void TestReaderOnParagraph(OpenXmlReader targetReader)
        {
            bool moved = false;

            Assert.False(targetReader.EOF);
            Assert.NotNull(targetReader.Attributes);
            Assert.Single(targetReader.Attributes);
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
            Assert.Empty(targetReader.Attributes);
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
            Assert.Empty(targetReader.Attributes);
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
            Assert.Empty(targetReader.Attributes);
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
            Assert.Empty(targetReader.Attributes);
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
            Assert.Empty(targetReader.Attributes);
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
            Assert.Empty(targetReader.Attributes);
            Assert.False(targetReader.HasAttributes);
            Assert.False(targetReader.IsStartElement);
            Assert.True(targetReader.IsEndElement);
            Assert.False(targetReader.IsMiscNode);
            Assert.Equal(typeof(Paragraph), targetReader.ElementType);
            Assert.True(string.IsNullOrEmpty(targetReader.GetText()));
        }
    }
}
