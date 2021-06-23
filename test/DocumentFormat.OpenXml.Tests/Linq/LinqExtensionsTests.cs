// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Linq;
using DocumentFormat.OpenXml.Packaging;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Xunit;

#pragma warning disable SA1116 // Split parameters should start on line after declaration

namespace DocumentFormat.OpenXml.Tests.Linq
{
    public class LinqExtensionsTests
    {
        [Fact]
        public void GetXDocument_NewPart_XDocumentWithEmptyRootElementWithNamespaceAttribute()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            MainDocumentPart part = wordDocument.AddMainDocumentPart();

            // Act.
            XDocument document = part.GetXDocument();

            // Assert.
            Assert.NotNull(document);
            Assert.NotNull(document.Declaration);
            Assert.NotNull(document.Root);
            Assert.Equal(W.document, document.Root.Name);
            Assert.Empty(document.Root.Elements());

            XAttribute expectedAttribute = new(XNamespace.Xmlns + "w", W.w);
            XAttribute attribute = document.Root.Attributes().Single();

            Assert.Equal(expectedAttribute.Name, attribute.Name);
            Assert.Equal(expectedAttribute.Value, attribute.Value);
        }

        [Fact]
        public void GetXElement_NewPart_EmptyRootElementWithNamespaceAttribute()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            MainDocumentPart part = wordDocument.AddMainDocumentPart();

            // Act.
            XElement element = part.GetXElement();

            // Assert.
            Assert.NotNull(element);
            Assert.Equal(W.document, element.Name);
            Assert.Empty(element.Elements());

            XAttribute expectedAttribute = new(XNamespace.Xmlns + "w", W.w);
            XAttribute attribute = element.Attributes().Single();

            Assert.Equal(expectedAttribute.Name, attribute.Name);
            Assert.Equal(expectedAttribute.Value, attribute.Value);
        }

        [Fact]
        public void PutXElement_GetPut_SameInstances()
        {
            // Arrange.
            using var stream = new MemoryStream();
            using var wordDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            MainDocumentPart part = wordDocument.AddMainDocumentPart();

            XElement expectedDocument = part.GetXElement();

            expectedDocument.Add(
                new XElement(W.body,
                    new XElement(W.p,
                        new XElement(W.r,
                            new XElement(W.t, "Hello World!")))));

            // Act.
            part.PutXElement();

            // Assert.
            XElement document = part.GetXElement();
            Assert.Same(expectedDocument, document);
        }
    }
}

#pragma warning restore SA1116 // Split parameters should start on line after declaration
