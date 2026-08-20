// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Tests for async methods on <see cref="OpenXmlReader"/> and <see cref="OpenXmlPartReader"/>.
    /// </summary>
    public class OpenXmlReaderAsyncTest
    {
#if TASKS_SUPPORTED
        [Fact]
        public async Task ReadAsync_ShouldNavigateToRootElement()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                mdp.Document = new Document(new Body(new Paragraph(new Run(new Text("Hello")))));
                mdp.Document.Save();
                wpd.Save();

                // Act
                using (OpenXmlPartReader reader = new OpenXmlPartReader(mdp, new OpenXmlPartReaderOptions { Async = true }))
                {
                    bool result = await reader.ReadAsync();

                    // Assert - should be at the Document element
                    Assert.True(result);
                    Assert.True(reader.IsStartElement);
                    Assert.Equal(typeof(Document), reader.ElementType);
                }
            }
        }

        [Fact]
        public async Task ReadAsync_ShouldReturnFalse_WhenNoMoreElements()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                mdp.Document = new Document(new Body());
                mdp.Document.Save();
                wpd.Save();

                // Act
                using (OpenXmlPartReader reader = new OpenXmlPartReader(mdp, new OpenXmlPartReaderOptions { Async = true }))
                {
                    // Read through all elements
                    while (await reader.ReadAsync())
                    {
                    }

                    // Assert
                    Assert.True(reader.EOF);
                }
            }
        }

        [Fact]
        public async Task ReadFirstChildAsync_ShouldMoveToFirstChild()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                mdp.Document = new Document(new Body(new Paragraph()));
                mdp.Document.Save();
                wpd.Save();

                // Act
                using (OpenXmlPartReader reader = new OpenXmlPartReader(mdp, new OpenXmlPartReaderOptions { Async = true }))
                {
                    // Move to Document element
                    await reader.ReadAsync();

                    // Move to first child (Body)
                    bool result = await reader.ReadFirstChildAsync();

                    // Assert
                    Assert.True(result);
                    Assert.True(reader.IsStartElement);
                    Assert.Equal(typeof(Body), reader.ElementType);
                }
            }
        }

        [Fact]
        public async Task ReadFirstChildAsync_ShouldReturnFalse_WhenNoChildren()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                mdp.Document = new Document(new Body());
                mdp.Document.Save();
                wpd.Save();

                // Act
                using (OpenXmlPartReader reader = new OpenXmlPartReader(mdp, new OpenXmlPartReaderOptions { Async = true }))
                {
                    // Move to Document element
                    await reader.ReadAsync();

                    // Move to Body
                    await reader.ReadFirstChildAsync();

                    // Try to move to first child of Body (should fail - empty Body)
                    bool result = await reader.ReadFirstChildAsync();

                    // Assert
                    Assert.False(result);
                    Assert.True(reader.IsEndElement);
                }
            }
        }

        [Fact]
        public async Task ReadNextSiblingAsync_ShouldMoveToNextSibling()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                mdp.Document = new Document(new Body(new Paragraph(), new Paragraph()));
                mdp.Document.Save();
                wpd.Save();

                // Act
                using (OpenXmlPartReader reader = new OpenXmlPartReader(mdp, new OpenXmlPartReaderOptions { Async = true }))
                {
                    // Move to Document -> Body -> first Paragraph
                    await reader.ReadAsync();
                    await reader.ReadFirstChildAsync();
                    await reader.ReadFirstChildAsync();

                    Assert.Equal(typeof(Paragraph), reader.ElementType);

                    // Move to second Paragraph (next sibling)
                    bool result = await reader.ReadNextSiblingAsync();

                    // Assert
                    Assert.True(result);
                    Assert.True(reader.IsStartElement);
                    Assert.Equal(typeof(Paragraph), reader.ElementType);
                }
            }
        }

        [Fact]
        public async Task ReadNextSiblingAsync_ShouldReturnFalse_WhenNoMoreSiblings()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                mdp.Document = new Document(new Body(new Paragraph()));
                mdp.Document.Save();
                wpd.Save();

                // Act
                using (OpenXmlPartReader reader = new OpenXmlPartReader(mdp, new OpenXmlPartReaderOptions { Async = true }))
                {
                    // Move to Document -> Body -> Paragraph
                    await reader.ReadAsync();
                    await reader.ReadFirstChildAsync();
                    await reader.ReadFirstChildAsync();

                    Assert.Equal(typeof(Paragraph), reader.ElementType);

                    // Try to move to next sibling (should be the Body end element)
                    bool result = await reader.ReadNextSiblingAsync();

                    // Assert - no more siblings, moved to end element of parent
                    Assert.False(result);
                    Assert.True(reader.IsEndElement);
                }
            }
        }

        [Fact]
        public async Task SkipAsync_ShouldSkipCurrentElementChildren()
        {
            // Arrange
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                mdp.Document = new Document(new Body(new Paragraph(new Run(new Text("Hello"))), new Paragraph()));
                mdp.Document.Save();
                wpd.Save();

                // Act
                using (OpenXmlPartReader reader = new OpenXmlPartReader(mdp, new OpenXmlPartReaderOptions { Async = true }))
                {
                    // Move to Document -> Body
                    await reader.ReadAsync();
                    await reader.ReadFirstChildAsync();

                    Assert.Equal(typeof(Body), reader.ElementType);

                    // Move to first Paragraph
                    await reader.ReadFirstChildAsync();
                    Assert.Equal(typeof(Paragraph), reader.ElementType);

                    // Skip the first Paragraph (and its children)
                    await reader.SkipAsync();

                    // Should now be at the second Paragraph
                    Assert.True(reader.IsStartElement);
                    Assert.Equal(typeof(Paragraph), reader.ElementType);
                }
            }
        }

        [Fact]
        public async Task ReadAsync_DomReader_ShouldUseBaseVirtualImplementation()
        {
            // Arrange - OpenXmlDomReader uses the base virtual implementation
            string paragraphOuterXml = "<w:p xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:r><w:t>Run Text.</w:t></w:r></w:p>";
            Paragraph para = new Paragraph(paragraphOuterXml);

            // Act
            using (OpenXmlReader reader = OpenXmlReader.Create(para))
            {
                bool result = await reader.ReadAsync();

                // Assert
                Assert.True(result);
                Assert.True(reader.IsStartElement);
                Assert.Equal(typeof(Paragraph), reader.ElementType);
            }
        }

        [Fact]
        public async Task ReadFirstChildAsync_DomReader_ShouldUseBaseVirtualImplementation()
        {
            // Arrange - OpenXmlDomReader uses the base virtual implementation
            string bodyOuterXml = "<w:body xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:p/></w:body>";
            Body body = new Body(bodyOuterXml);

            // Act
            using (OpenXmlReader reader = OpenXmlReader.Create(body))
            {
                await reader.ReadAsync(); // move to Body

                bool result = await reader.ReadFirstChildAsync(); // move to Paragraph

                // Assert
                Assert.True(result);
                Assert.True(reader.IsStartElement);
                Assert.Equal(typeof(Paragraph), reader.ElementType);
            }
        }

        [Fact]
        public async Task ReadNextSiblingAsync_DomReader_ShouldUseBaseVirtualImplementation()
        {
            // Arrange - OpenXmlDomReader uses the base virtual implementation
            Body body = new Body(new Paragraph(), new Paragraph());

            // Act
            using (OpenXmlReader reader = OpenXmlReader.Create(body))
            {
                await reader.ReadAsync(); // move to Body
                await reader.ReadFirstChildAsync(); // move to first Paragraph

                bool result = await reader.ReadNextSiblingAsync(); // move to second Paragraph

                // Assert
                Assert.True(result);
                Assert.True(reader.IsStartElement);
                Assert.Equal(typeof(Paragraph), reader.ElementType);
            }
        }

        [Fact]
        public async Task SkipAsync_DomReader_ShouldUseBaseVirtualImplementation()
        {
            // Arrange - OpenXmlDomReader uses the base virtual implementation
            Body body = new Body(new Paragraph(new Run(new Text("Hello"))), new Paragraph());

            // Act
            using (OpenXmlReader reader = OpenXmlReader.Create(body))
            {
                await reader.ReadAsync(); // move to Body
                await reader.ReadFirstChildAsync(); // move to first Paragraph

                await reader.SkipAsync(); // skip first Paragraph

                // Should now be at second Paragraph
                Assert.True(reader.IsStartElement);
                Assert.Equal(typeof(Paragraph), reader.ElementType);
            }
        }

        [Fact]
        public async Task ReadAsync_PartReader_ShouldReadAllElements()
        {
            // Arrange - full traversal of a document
            using (MemoryStream memoryStream = new MemoryStream())
            using (WordprocessingDocument wpd = WordprocessingDocument.Create(memoryStream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mdp = wpd.AddMainDocumentPart();
                mdp.Document = new Document(new Body(new Paragraph(new Run(new Text("Hello World")))));
                mdp.Document.Save();
                wpd.Save();

                // Act
                using (OpenXmlPartReader reader = new OpenXmlPartReader(mdp, new OpenXmlPartReaderOptions { Async = true }))
                {
                    int elementCount = 0;
                    while (await reader.ReadAsync())
                    {
                        if (reader.IsStartElement)
                        {
                            elementCount++;
                        }
                    }

                    // Assert: Document, Body, Paragraph, Run, Text = 5 start elements
                    Assert.Equal(5, elementCount);
                }
            }
        }

        [Fact]
        public async Task OpenXmlPartReaderOptions_Async_DefaultsFalse()
        {
            // Arrange
            OpenXmlPartReaderOptions options = default;

            // Assert
            Assert.False(options.Async);
        }
#endif
    }
}
