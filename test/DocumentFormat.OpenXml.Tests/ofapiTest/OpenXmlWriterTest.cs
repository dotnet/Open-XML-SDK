// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// This is a test class for OpenXmlPartWriterTest and is intended
    /// to contain all OpenXmlPartWriterTest Unit Tests
    /// </summary>
    public class OpenXmlWriterTest
    {
        /// <summary>
        /// A test for WriteString
        /// </summary>
        [Fact]
        public void WriteStringTest()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();
                target.WriteStartElement(new Run());

                target.WriteStartElement(new Text());
                target.WriteString(text);
                target.WriteEndElement();

                var textElement = new Text();
                textElement.Space = new EnumValue<SpaceProcessingModeValues>();
                textElement.Space.Value = SpaceProcessingModeValues.Preserve;
                target.WriteStartElement(new Text(), textElement.GetAttributes());
                target.WriteString(text);
                target.WriteString(text);
                target.WriteEndElement();

                var run = new Run(new Text("111"), new Text("222"));
                using (var reader = OpenXmlReader.Create(run))
                {
                    reader.Read();
                    reader.Read();
                    target.WriteStartElement(reader);
                    target.WriteString(reader.GetText());
                    reader.Read();
                    target.WriteEndElement();

                    reader.Read();
                    target.WriteStartElement(reader, textElement.GetAttributes());
                    target.WriteString(reader.GetText());
                    target.WriteString(text);
                    reader.Read();
                    target.WriteEndElement();

                    reader.Close();
                }

                target.Close();
            }
        }

        /// <summary>
        /// A test for WriteString
        /// </summary>
        [Fact]
        public void WriteStringExceptionTest()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();
                target.WriteStartElement(new Run());

                target.WriteStartElement(new RunProperties());
                Assert.Throws<System.InvalidOperationException>(() =>
                    {
                        target.WriteString(text); // exception
                    });
            }
        }

        /// <summary>
        /// A test for WriteString
        /// </summary>
        [Fact]
        public void WriteStringExceptionTest2()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();
                target.WriteStartElement(new Run());

                var textElement = new Text();
                textElement.Space = SpaceProcessingModeValues.Preserve;
                target.WriteStartElement(new RunProperties(), textElement.GetAttributes());
                Assert.Throws<System.InvalidOperationException>(() =>
                    {
                        target.WriteString(text); // exception
                    });
            }
        }

        /// <summary>
        /// A test for WriteString
        /// </summary>
        [Fact]
        public void WriteStringExceptionTest3()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();
                target.WriteStartElement(new Run());

                var textElement = new Text();
                textElement.Space = SpaceProcessingModeValues.Preserve;
                target.WriteStartElement(new Text());
                target.WriteString(text);
                target.WriteEndElement();
                Assert.Throws<System.InvalidOperationException>(() =>
                    {
                        target.WriteString(text); // exception
                    });
            }
        }

        /// <summary>
        /// A test for WriteString
        /// </summary>
        [Fact]
        public void WriteStringExceptionTest4()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();
                target.WriteStartElement(new Run());

                var run = new Run(new Text("111"), new Text("222"));
                using (var reader = OpenXmlReader.Create(run))
                {
                    reader.Read();
                    reader.Read();
                    target.WriteStartElement(reader);
                    target.WriteString(reader.GetText());
                    reader.Read();
                    target.WriteEndElement();
                    Assert.Throws<System.InvalidOperationException>(() =>
                        {
                            target.WriteString(text);  // exception
                        });

                    reader.Close();
                }
            }
        }

        /// <summary>
        /// A test for WriteString
        /// </summary>
        [Fact]
        public void WriteStringExceptionTest5()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();
                target.WriteStartElement(new Run());

                var run = new Run(new RunProperties(), new Text("222"));
                using (var reader = OpenXmlReader.Create(run))
                {
                    reader.Read();
                    reader.Read();
                    target.WriteStartElement(reader);
                    Assert.Throws<System.InvalidOperationException>(() =>
                        {
                            target.WriteString(text); // exception
                        });
                    reader.Read();
                    target.WriteEndElement();
                }
            }
        }

        /// <summary>
        /// A test for WriteString
        /// </summary>
        [Fact]
        public void WriteStringExceptionTest6()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();
                target.WriteStartElement(new Run());

                var textElement = new Text();
                textElement.Space = SpaceProcessingModeValues.Preserve;
                target.WriteStartElement(new RunProperties(), textElement.GetAttributes());
                target.WriteEndElement();
                target.Close();
                Assert.Throws<System.InvalidOperationException>(() =>
                {
                    target.WriteString(text); // exception
                });
            }
        }

        /// <summary>
        /// A test for WriteString
        /// </summary>
        [Fact]
        public void WriteStringExceptionTest7()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();

                Assert.Throws<System.InvalidOperationException>(() =>
                {
                    target.WriteString(text); // exception
                });
            }
        }

#if FEATURE_ASYNC_SAX_XML
        [Fact]
        public async Task WriteStartDocumentAsync_ShouldWriteStartDocument()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                OpenXmlWriter writer = new OpenXmlPartWriter(mdp, useAsync: true);

                // Act
                await writer.WriteStartDocumentAsync();
                writer.Close();

                // Assert
                Stream stream = mdp.GetStream();
                stream.Position = 0;
                string xml = new StreamReader(stream).ReadToEnd();
                Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?>", xml);
            }
        }

        [Fact]
        public async Task WriteStartDocumentAsync_WithStandalone_ShouldWriteStartDocument()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                OpenXmlWriter writer = new OpenXmlPartWriter(mdp, useAsync: true);

                // Act
                await writer.WriteStartDocumentAsync(true);
                writer.Close();

                // Assert
                Stream stream = mdp.GetStream();
                stream.Position = 0;
                string xml = new StreamReader(stream).ReadToEnd();
                Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\"?>", xml);
            }
        }

        [Fact]
        public async Task WriteStartElementAsync_ShouldWriteStartElement()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                OpenXmlWriter writer = new OpenXmlPartWriter(mdp, useAsync: true);

                // Act
                await writer.WriteStartDocumentAsync();
                await writer.WriteStartElementAsync(new Document());
                await writer.WriteEndElementAsync();
                writer.Close();

                // Assert
                Stream stream = mdp.GetStream();
                stream.Position = 0;
                string xml = new StreamReader(stream).ReadToEnd();
                Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><w:document xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" />", xml);
            }
        }

        [Fact]
        public async Task WriteStartElementAsync_ShouldWriteStartElement_With_Attributes()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                OpenXmlWriter writer = new OpenXmlPartWriter(mdp, useAsync: true);

                // Act
                await writer.WriteStartDocumentAsync();
                await writer.WriteStartElementAsync(new Document());
                await writer.WriteStartElementAsync(new Body());
                await writer.WriteStartElementAsync(new Paragraph());
                await writer.WriteStartElementAsync(new ParagraphProperties());
                await writer.WriteStartElementAsync(new ParagraphStyleId(), new List<OpenXmlAttribute> { new OpenXmlAttribute("val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "Normal") });
                await writer.WriteEndElementAsync();
                await writer.WriteEndElementAsync();
                await writer.WriteEndElementAsync();
                await writer.WriteEndElementAsync();
                await writer.WriteEndElementAsync();
                writer.Close();

                // Assert
                Stream stream = mdp.GetStream();
                stream.Position = 0;
                string xml = new StreamReader(stream).ReadToEnd();
                Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><w:document xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:body><w:p><w:pPr><w:pStyle w:val=\"Normal\" /></w:pPr></w:p></w:body></w:document>", xml);
            }
        }

        [Fact]
        public async Task WriteElementAsync_ShouldWriteStartElement_With_Attributes_And_Namespaces()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                OpenXmlWriter writer = new OpenXmlPartWriter(mdp, useAsync: true);

                // Act
                await writer.WriteStartDocumentAsync();
                await writer.WriteStartElementAsync(new Document());
                await writer.WriteStartElementAsync(new Body());
                await writer.WriteStartElementAsync(new Paragraph());
                await writer.WriteStartElementAsync(new ParagraphProperties());
                await writer.WriteStartElementAsync(new ParagraphStyleId(), new List<OpenXmlAttribute> { new OpenXmlAttribute("val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "Normal") }, new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("q", "http://schemas.openxmlformats.org/fake/namespace") });
                await writer.WriteEndElementAsync();
                await writer.WriteEndElementAsync();
                await writer.WriteEndElementAsync();
                await writer.WriteEndElementAsync();
                await writer.WriteEndElementAsync();
                writer.Close();

                // Assert
                Stream stream = mdp.GetStream();
                stream.Position = 0;
                string xml = new StreamReader(stream).ReadToEnd();
                Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><w:document xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:body><w:p><w:pPr><w:pStyle xmlns:q=\"http://schemas.openxmlformats.org/fake/namespace\" w:val=\"Normal\" /></w:pPr></w:p></w:body></w:document>", xml);
            }
        }

        [Fact]
        public async Task WriteEndElementAsync_ShouldWriteEndElement()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                OpenXmlWriter writer = new OpenXmlPartWriter(mdp, useAsync: true);

                // Act
                await writer.WriteStartDocumentAsync();
                await writer.WriteStartElementAsync(new Document());
                await writer.WriteElementAsync(new Body());
                await writer.WriteEndElementAsync();
                writer.Close();

                // Assert
                Stream stream = mdp.GetStream();
                stream.Position = 0;
                string xml = new StreamReader(stream).ReadToEnd();
                Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><w:document xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:body /></w:document>", xml);
            }
        }

        [Fact]
        public async Task WriteElementAsync_ShouldWriteSelfClosingElement()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                OpenXmlWriter writer = new OpenXmlPartWriter(mdp, useAsync: true);

                // Act
                await writer.WriteStartDocumentAsync();
                await writer.WriteElementAsync(new Document());
                writer.Close();

                // Assert
                Stream stream = mdp.GetStream();
                stream.Position = 0;
                string xml = new StreamReader(stream).ReadToEnd();
                Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><w:document xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" />", xml);
            }
        }

        [Fact]
        public async Task WriteStringAsync_ShouldWriteString()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                OpenXmlWriter writer = new OpenXmlPartWriter(mdp, useAsync: true);
                string txt = "Well, there's your problem";

                // Act
                await writer.WriteStartDocumentAsync();
                await writer.WriteStartElementAsync(new Body());
                await writer.WriteStartElementAsync(new Paragraph());
                await writer.WriteStartElementAsync(new Run());
                await writer.WriteStartElementAsync(new Text());
                await writer.WriteStringAsync(txt);
                await writer.WriteEndElementAsync();
                await writer.WriteEndElementAsync();
                await writer.WriteEndElementAsync();
                await writer.WriteEndElementAsync();
                writer.Close();

                // Assert
                Stream stream = mdp.GetStream();
                stream.Position = 0;
                string xml = new StreamReader(stream).ReadToEnd();
                Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><w:body xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:p><w:r><w:t>Well, there's your problem</w:t></w:r></w:p></w:body>", xml);
            }
        }
#endif
    }
}
