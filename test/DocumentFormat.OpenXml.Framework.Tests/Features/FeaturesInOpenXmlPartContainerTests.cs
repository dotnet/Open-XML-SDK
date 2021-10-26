// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using NSubstitute;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Features.Tests
{
    public class FeaturesInOpenXmlPartContainerTests
    {
        [Fact]
        public void FeaturesPropogateThroughContainer()
        {
            using var ms = new MemoryStream();
            using var package = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document);

            var feature1 = new Feature();

            var part = package.AddMainDocumentPart();

            package.Features.Set(feature1);

            Assert.Same(feature1, package.Features.Get<Feature>());
            Assert.Same(feature1, part.Features.Get<Feature>());
        }

        [Fact]
        public void FeaturesDoNotPropogateBackThroughContainer()
        {
            using var ms = new MemoryStream();
            using var package = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document);

            var feature1 = new Feature();

            var part = package.AddMainDocumentPart();

            part.Features.Set(feature1);

            Assert.Null(package.Features.Get<Feature>());
            Assert.Same(feature1, part.Features.Get<Feature>());
        }

        [Fact]
        public void FeaturesIndependentParts()
        {
            using var ms = new MemoryStream();
            using var package = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document);

            var part1 = package.AddMainDocumentPart();
            var feature1 = new Feature();
            part1.Features.Set(feature1);

            var feature2 = new Feature();
            var part2 = package.AddCoreFilePropertiesPart();
            part2.Features.Set(feature2);

            Assert.Null(package.Features.Get<Feature>());
            Assert.Same(feature1, part1.Features.Get<Feature>());
            Assert.Same(feature2, part2.Features.Get<Feature>());
        }

        [Fact]
        public void FeaturesIndependentPartsReadFromPackage()
        {
            using var ms = new MemoryStream();
            using var package = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document);

            var part1 = package.AddMainDocumentPart();
            var feature1 = new Feature();
            part1.Features.Set(feature1);

            var feature2 = new Feature();
            package.Features.Set(feature2);

            var part2 = package.AddCoreFilePropertiesPart();

            Assert.Same(feature2, package.Features.Get<Feature>());
            Assert.Same(feature1, part1.Features.Get<Feature>());
            Assert.Same(feature2, part2.Features.Get<Feature>());
        }

        [Fact]
        public void ElementGetReadonlyFeatures()
        {
            var element = Substitute.ForPartsOf<OpenXmlElement>();

            Assert.NotNull(element.Features);
            Assert.True(element.Features.IsReadOnly);
            Assert.Same(element.Features, element.Features);
        }

        [Fact]
        public void ElementGetFromPart()
        {
            var element = new Body();

            using var ms1 = new MemoryStream();
            using var package1 = WordprocessingDocument.Create(ms1, WordprocessingDocumentType.Document);

            var part1 = package1.AddMainDocumentPart();
            var feature1 = new Feature();
            part1.Features.Set(feature1);
            part1.Document = new();
            part1.Document.AddChild(element);

            Assert.Same(feature1, element.Features.Get<Feature>());

            // Remove element from tree
            element.Remove();
            Assert.Null(element.Features.Get<Feature>());

            // Change part element is in
            using var ms2 = new MemoryStream();
            using var package2 = WordprocessingDocument.Create(ms2, WordprocessingDocumentType.Document);

            var part2 = package2.AddMainDocumentPart();
            var feature2 = new Feature();
            part2.Features.Set(feature2);
            part2.Document = new();
            part2.Document.AddChild(element);

            Assert.Same(feature2, element.Features.Get<Feature>());
        }

        private class Feature
        {
        }
    }
}
