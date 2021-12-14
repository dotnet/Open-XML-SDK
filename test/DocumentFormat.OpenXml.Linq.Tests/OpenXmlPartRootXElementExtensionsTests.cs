// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Xunit;

#nullable enable
#pragma warning disable SA1116 // Split parameters should start on line after declaration

namespace DocumentFormat.OpenXml.Linq.Tests
{
    public class OpenXmlPartRootXElementExtensionsTests
    {
        private const string HelloWorld = "Hello World!";

        private static readonly XAttribute XmlnsW = new(XNamespace.Xmlns + "w", W.w);

        private static XElement HelloWorldXElement =>
            new(W.document, XmlnsW,
                new XElement(W.body,
                    new XElement(W.p,
                        new XElement(W.r,
                            new XElement(W.t, "Hello World!")))));

        private static XDocument HelloWorldXDocument =>
            new(new XDeclaration("1.0", "UTF-8", "yes"), HelloWorldXElement);

        private static Document HelloWordDocument =>
            new(new Body(new Paragraph(new Run(new Text(HelloWorld)))));

        private static readonly string HelloWorldXmlString =
            HelloWorldXElement.ToString(SaveOptions.DisableFormatting);

        [Fact]
        public void GetXDocument_NewPartWithoutRootElement_XDocumentIsNotNullAndRootIsNull()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();

            // Act.
            var partXDocument = part.GetXDocument();

            // Assert.
            Assert.NotNull(partXDocument);
            Assert.Null(partXDocument.Root);
            Assert.False(part.IsRootXElementLoaded());
        }

        [Fact]
        public void GetXDocument_PartWithUnsavedRootElement_XDocumentIsNotNullAndRootXmlStringsAreIdentical()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            part.Document = HelloWordDocument;

            // Act.
            var partXDocument = part.GetXDocument();

            // Assert.
            Assert.NotNull(partXDocument);
            Assert.NotNull(partXDocument.Root);
            Assert.Equal(part.Document.OuterXml, partXDocument.Root!.ToString(SaveOptions.DisableFormatting));
            Assert.True(part.IsRootXElementLoaded());
        }

        [Fact]
        public void GetXDocument_AfterCallingGetXDocumentAndSetXElement_XDocumentReferencesAreIdentical()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            var expectedPartXDocument = part.GetXDocument();

            var expectedRootXElement = HelloWorldXElement;
            part.SetXElement(expectedRootXElement);

            // Act.
            var partXDocument = part.GetXDocument();

            // Assert.
            Assert.Same(expectedPartXDocument, partXDocument);
            Assert.Same(expectedRootXElement, partXDocument.Root);
            Assert.True(part.IsRootXElementLoaded());
        }

        [Fact]
        public void GetXElement_NewPartWithoutRootElement_XElementIsNull()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();

            // Act.
            var rootXElement = part.GetXElement();

            // Assert.
            Assert.Null(rootXElement);
            Assert.Null(part.RootElement);
            Assert.Null(part.Document);

            Assert.False(part.IsRootXElementLoaded());
        }

        [Fact]
        public void GetXElement_PartWithUnsavedRootElement_XElementIsNotNullAndRootXmlStringsAreIdentical()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            part.Document = HelloWordDocument;

            // Act.
            var rootXElement = part.GetXElement();

            // Assert.
            Assert.NotNull(rootXElement);
            Assert.Equal(part.Document.OuterXml, rootXElement!.ToString(SaveOptions.DisableFormatting));
            Assert.True(part.IsRootXElementLoaded());
        }

        [Fact]
        public void GetXElement_AfterCallingSetXDocument_XDocumentRootReturned()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            part.SetXDocument(HelloWorldXDocument);

            // Act and Assert.
            Assert.Same(part.GetXDocument().Root, part.GetXElement());
            Assert.True(part.IsRootXElementLoaded());
        }

        [Fact]
        public void GetXElement_AfterCallingSetXDocumentAndSetXElement_XDocumentRootReturned()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            part.SetXDocument(HelloWorldXDocument);

            Assert.True(part.IsRootXElementLoaded());

            var expectedRootXElement = new XElement(W.document, XmlnsW, new XElement(W.body));
            part.SetXElement(expectedRootXElement);

            // Act and Assert.
            Assert.Same(part.GetXDocument().Root, part.GetXElement());
            Assert.Same(expectedRootXElement, part.GetXElement());
        }

        [Fact]
        public void GetXElement_AfterAddingXElementToXDocument_XDocumentRootReturned()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            var partXDocument = part.GetXDocument();

            Assert.False(part.IsRootXElementLoaded());

            var expectedRootXElement = HelloWorldXElement;
            partXDocument.Add(expectedRootXElement);

            // Act and Assert.
            Assert.Same(part.GetXDocument().Root, part.GetXElement());
            Assert.Same(expectedRootXElement, part.GetXElement());
        }

        [Fact]
        public void GetXElement_AfterReplacingXDocumentsRoot_XDocumentRootReturned()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();

            var partXDocument = HelloWorldXDocument;
            part.SetXDocument(partXDocument);

            Assert.True(part.IsRootXElementLoaded());

            var expectedRootXElement = new XElement(W.document, XmlnsW, new XElement(W.body));
            partXDocument.Root!.ReplaceWith(expectedRootXElement);

            // Act and Assert.
            Assert.Same(part.GetXDocument().Root, part.GetXElement());
            Assert.Same(expectedRootXElement, part.GetXElement());
        }

        [Fact]
        public void SetXDocument_NewPartWithoutRootElement_RootXmlStringsAreIdentical()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();

            // Act.
            part.SetXDocument(HelloWorldXDocument);

            // Assert.
            Assert.True(part.IsRootXElementLoaded());

            // Note that the RootXElement has the expected markup.
            var partXDocument = part.GetXDocument();
            var rootXElement = partXDocument.Root;

            Assert.NotNull(rootXElement);
            Assert.Equal(HelloWorldXmlString, rootXElement!.ToString(SaveOptions.DisableFormatting));

            // Note that the RootElement has the expected markup.
            var rootElement = part.RootElement;
            Assert.NotNull(rootElement);
            Assert.Equal(HelloWorldXmlString, rootElement!.OuterXml);

            // Note that the Document has the expected markup.
            Document document = part.Document;
            Assert.NotNull(document);
            Assert.Equal(HelloWorldXmlString, document.OuterXml);
        }

        [Fact]
        public void SetXDocument_RootIsNull_ArgumentExceptionThrown()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();

            var partXDocument = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"));
            Assert.Null(partXDocument.Root);

            // Act.
            Assert.Throws<ArgumentException>(() => part.SetXDocument(partXDocument));
        }

        [Fact]
        public void SetXElement_NewPartWithoutRootElement_RootXmlStringsAreIdentical()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();

            // Act.
            part.SetXElement(HelloWorldXElement);

            // Assert.
            Assert.True(part.IsRootXElementLoaded());

            // Note that the RootXElement has the expected markup.
            var rootXElement = part.GetXElement();
            Assert.NotNull(rootXElement);
            Assert.Equal(HelloWorldXmlString, rootXElement!.ToString(SaveOptions.DisableFormatting));

            // Note that the RootElement has the expected markup.
            var rootElement = part.RootElement;
            Assert.NotNull(rootElement);
            Assert.Equal(HelloWorldXmlString, rootElement!.OuterXml);

            // Note that the Document has the expected markup.
            Document document = part.Document;
            Assert.NotNull(document);
            Assert.Equal(HelloWorldXmlString, document.OuterXml);
        }

        [Fact]
        public void SetXElement_Null_ArgumentNullExceptionThrown()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();

            // Act.
            Assert.Throws<ArgumentNullException>(() => part.SetXElement(null!));
        }

        [Fact]
        public void Save_PartXDocumentIsNull_NotSaved()
        {
            // Arrange.
            using var stream = new MemoryStream();

            using (var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart part = wordDocument.AddMainDocumentPart();
                part.Document = HelloWordDocument;
            }

            using (var wordDocument = WordprocessingDocument.Open(stream, true))
            {
                MainDocumentPart part = wordDocument.MainDocumentPart!;

                Assert.NotNull(part.GetXDocument());
                Assert.NotNull(part.GetXElement());
                Assert.True(part.IsRootXElementLoaded());
            }

            using (var wordDocument = WordprocessingDocument.Open(stream, true))
            {
                MainDocumentPart part = wordDocument.MainDocumentPart!;

                Assert.False(part.IsRootXElementLoaded());

                // Act and Assert.
                Assert.False(part.SaveXDocument());
                Assert.False(part.SaveXElement());
            }
        }

        [Fact]
        public void Save_PartXDocumentIsNotNullButRootIsNull_NotSaved()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            var partXDocument = part.GetXDocument();

            Assert.NotNull(partXDocument);
            Assert.Null(partXDocument.Root);
            Assert.False(part.IsRootXElementLoaded());

            // Act and Assert.
            Assert.False(part.SaveXDocument());
            Assert.False(part.SaveXElement());
        }

        [Fact]
        public void SaveXDocument_PartRootXElementIsNotNull_Saved()
        {
            // Arrange.
            using var stream = new MemoryStream();

            using (var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart part = wordDocument.AddMainDocumentPart();
                part.Document = HelloWordDocument;
            }

            using (var wordDocument = WordprocessingDocument.Open(stream, true))
            {
                MainDocumentPart part = wordDocument.MainDocumentPart!;

                Assert.NotNull(part.GetXElement());
                Assert.True(part.IsRootXElementLoaded());

                // Act and Assert.
                Assert.True(part.SaveXDocument());
            }
        }

        [Fact]
        public void SaveXElement_PartRootXElementIsNotNull_Saved()
        {
            // Arrange.
            using var stream = new MemoryStream();

            using (var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart part = wordDocument.AddMainDocumentPart();
                part.Document = HelloWordDocument;
            }

            using (var wordDocument = WordprocessingDocument.Open(stream, true))
            {
                MainDocumentPart part = wordDocument.MainDocumentPart!;

                Assert.NotNull(part.GetXElement());
                Assert.True(part.IsRootXElementLoaded());

                // Act and Assert.
                Assert.True(part.SaveXElement());
            }
        }

        [Fact]
        public void SaveXElement_AfterSettingRootElementCallingGetXElementAndChangingXElement_RootElementSynchronized()
        {
            // Arrange.
            // Set up a WordprocessingDocument with a MainDocumentPart and a Document with a single paragraph.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            part.Document = HelloWordDocument;

            // Note that the RootXElement is synchronized with the Document (RootElement).
            Assert.Equal(HelloWorldXmlString, part.GetXElement()!.ToString(SaveOptions.DisableFormatting));
            Assert.Same(part.Document, part.RootElement);

            // Get the root XElement.
            var root = part.GetXElement();

            Assert.NotNull(root);
            Assert.True(part.IsRootXElementLoaded());

            // Add a second paragraph to the RootXElement.
            XElement body = root!.Elements(W.body).Single();
            body.Add(new XElement(W.p, new XElement(W.r, new XElement(W.t, "Lorem ipsum"))));

            // Note that the Document still has a single paragraph.
            Assert.Single(part.Document.Descendants<Paragraph>());
            Assert.Single(part.RootElement!.Descendants<Paragraph>());

            // Act.
            var saved = part.SaveXElement();

            // Assert.
            // Note that, after saving the RootXElement, the Document has now two paragraphs.
            Assert.True(saved);
            Assert.Equal(2, part.Document.Descendants<Paragraph>().Count());
        }

        [Fact]
        public void IsRootXElementLoaded_AfterGettingXDocumentFromEmptyPart_FalseReturned()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            Assert.Null(part.GetXDocument().Root);

            // Act and Assert.
            Assert.False(part.IsRootXElementLoaded());
        }

        [Fact]
        public void IsRootXElementLoaded_BeforeAndAfterGettingXDocument_FalseAndTrueReturned()
        {
            // Arrange.
            using var stream = new MemoryStream();

            using (var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart part = wordDocument.AddMainDocumentPart();
                part.Document = HelloWordDocument;
            }

            using (var wordDocument = WordprocessingDocument.Open(stream, true))
            {
                MainDocumentPart part = wordDocument.MainDocumentPart!;

                // Act and Assert that it is not loaded before calling GetXElement().
                Assert.False(part.IsRootXElementLoaded());

                // Load the XDocument.
                Assert.NotNull(part.GetXDocument().Root);

                // Act and Assert that it is loaded after calling GetXElement().
                Assert.True(part.IsRootXElementLoaded());
            }
        }

        [Fact]
        public void IsRootXElementLoaded_BeforeAndAfterGettingXElement_FalseAndTrueReturned()
        {
            // Arrange.
            using var stream = new MemoryStream();

            using (var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart part = wordDocument.AddMainDocumentPart();
                part.Document = HelloWordDocument;
            }

            using (var wordDocument = WordprocessingDocument.Open(stream, true))
            {
                MainDocumentPart part = wordDocument.MainDocumentPart!;

                // Act and Assert that it is not loaded before calling GetXElement().
                Assert.False(part.IsRootXElementLoaded());

                // Load the root XElement.
                Assert.NotNull(part.GetXElement());

                // Act and Assert that it is loaded after calling GetXElement().
                Assert.True(part.IsRootXElementLoaded());
            }
        }

        [Fact]
        public void UseCase_NewAndChangedPart_Success()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();
            part.Document = HelloWordDocument;
            part.Document.Save();

            Assert.Same(part.Document, part.RootElement);
            Assert.Equal(HelloWorldXmlString, part.Document.OuterXml);
            Assert.Equal(HelloWorldXmlString, part.GetXElement()!.ToString(SaveOptions.DisableFormatting));

            // Act and Assert.
            // Add a second W.p
            part.GetXElement()!.Element(W.body)!.Add(new XElement(W.p));

            Assert.Single(part.Document.Descendants<Paragraph>());
            Assert.Equal(2, part.GetXElement()!.Descendants(W.p).Count());
            Assert.True(part.IsRootXElementLoaded());

            // Reload the Document (RootElement) and note that the RootXElement was reset.
            part.Document.Reload();

            Assert.Single(part.Document.Descendants<Paragraph>());
            Assert.Single(part.GetXElement()!.Descendants(W.p));

            // Re-add a second W.p and save the RootXElement.
            part.GetXElement()!.Element(W.body)!.Add(new XElement(W.p));
            part.SaveXElement();

            Assert.Equal(2, part.Document.Descendants<Paragraph>().Count());
            Assert.Equal(2, part.GetXElement()!.Descendants(W.p).Count());

            // Add a third Paragraph and save the Document.
            part.Document.Body!.AppendChild(new Paragraph(new Run(new Text("Far far away"))));
            part.Document.Save();

            Assert.Equal(3, part.Document.Descendants<Paragraph>().Count());
            Assert.Equal(3, part.GetXElement()!.Descendants(W.p).Count());

            // Set a new Document (RootElement).
            part.Document = HelloWordDocument;

            Assert.Equal(HelloWorldXmlString, part.Document.OuterXml);
            Assert.Equal(HelloWorldXmlString, part.GetXElement()!.ToString(SaveOptions.DisableFormatting));
        }
    }
}

#pragma warning restore SA1116 // Split parameters should start on line after declaration
