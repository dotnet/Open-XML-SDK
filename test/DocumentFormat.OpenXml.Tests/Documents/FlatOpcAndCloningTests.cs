using DocumentFormat.OpenXml.Experimental;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.Documents
{
    public class FlatOpcAndCloningTests
    {
        private readonly ITestOutputHelper _output;

        public FlatOpcAndCloningTests(ITestOutputHelper output)
        {
            _output = output;
        }

        private void PrintPackageParts(List<IPackagePart> packageParts, string title)
        {
            _output.WriteLine(title);

            foreach (var part in packageParts)
            {
                _output.WriteLine($"- Uri: {part.Uri}, ContentType: {part.ContentType}");
            }

            _output.WriteLine(string.Empty);
        }

        [Fact]
        public void DocumentsHaveIdenticalParts()
        {
            // Arrange
            using var stream = TestAssets.GetStream(TestAssets.TestFiles.HelloWorldDocx);
            using var docxDocument = WordprocessingDocument.Open(stream, false);

            using var xml = TestAssets.GetStream(TestAssets.TestFiles.HelloWorldFlatOpc);
            using var flatOpcDocument = WordprocessingDocument.FromFlatOpcDocument(XDocument.Load(xml));

            // Act
            var docxPackageParts = docxDocument.GetPackage().GetParts().ToList();
            var flatOpcPackageParts = flatOpcDocument.GetPackage().GetParts().ToList();

            PrintPackageParts(docxPackageParts, "HelloWorldDocx");
            PrintPackageParts(flatOpcPackageParts, "HelloWorldXml");

            // Assert
            Assert.True(docxPackageParts.Select(p => p.Uri).SequenceEqual(flatOpcPackageParts.Select(p => p.Uri)));
        }

        [Fact]
        public void CanCloneDocxDocument()
        {
            // Arrange
            using var stream = TestAssets.GetStream(TestAssets.TestFiles.HelloWorldDocx);
            using var docxDocument = WordprocessingDocument.Open(stream, false);

            // Act and Assert (no exception thrown)
            using OpenXmlPackage clone = docxDocument.Clone();

            Assert.NotNull(clone);
        }

        [Fact]
        public void CanCloneFlatOpcDocument()
        {
            // Arrange
            using var xml = TestAssets.GetStream(TestAssets.TestFiles.HelloWorldFlatOpc);
            using var flatOpcDocument = WordprocessingDocument.FromFlatOpcDocument(XDocument.Load(xml));

            // Act and Assert (no exception thrown)
            using OpenXmlPackage clone = flatOpcDocument.Clone();

            Assert.NotNull(clone);
        }
    }
}