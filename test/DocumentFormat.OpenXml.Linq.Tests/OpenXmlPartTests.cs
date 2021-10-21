// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Xunit;

#nullable enable
#pragma warning disable SA1116 // Split parameters should start on line after declaration

namespace DocumentFormat.OpenXml.Linq.Tests
{
    public class OpenXmlPartTests
    {
        private const string HelloWorld = "Hello World!";

        private static XElement HelloWorldXElement =>
            new(W.document, new XAttribute(XNamespace.Xmlns + "w", W.w),
                new XElement(W.body,
                    new XElement(W.p,
                        new XElement(W.r,
                            new XElement(W.t, "Hello World!")))));

        private static Document HelloWordDocument =>
            new(new Body(new Paragraph(new Run(new Text(HelloWorld)))));

        private static readonly string HelloWorldXmlString =
            HelloWorldXElement.ToString(SaveOptions.DisableFormatting);

        [Fact]
        public void GetXElement_NewPart_NullAndSynchronized()
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
        }

        [Fact]
        public void GetXElement_PartWithRootElementSetButNotSaved_NotNullAndSynchronized()
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
        }

        [Fact]
        public void SetXElement_NewPart_NotNullAndSynchronized()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            MainDocumentPart part = wordDocument.AddMainDocumentPart();

            // Act.
            part.SetXElement(HelloWorldXElement);

            // Assert.
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
        public void SaveRootXElement_SetDocumentGetAndChangeRootXElement_RootElementSynchronized()
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

            // Add a second paragraph to the RootXElement.
            XElement body = part.GetXElement()!.Elements(W.body).Single();
            body.Add(new XElement(W.p, new XElement(W.r, new XElement(W.t, "Lorem ipsum"))));

            // Note that the Document still has a single paragraph.
            Assert.Single(part.Document.Descendants<Paragraph>());
            Assert.Single(part.RootElement!.Descendants<Paragraph>());

            // Act.
            part.SaveXElement();

            // Assert.
            // Note that, after saving the RootXElement, the Document has now two paragraphs.
            Assert.Equal(2, part.Document.Descendants<Paragraph>().Count());
        }

        [Fact]
        public void Multiple_NewAndChangedPart_Success()
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
