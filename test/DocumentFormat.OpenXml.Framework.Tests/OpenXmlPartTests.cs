// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Builder;
using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using NSubstitute;
using System;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    public class OpenXmlPartTests
    {
        [Fact]
        public void ExtensionTest()
        {
            // Arrange
            const string ContentType = "test/mimetype";
            const string TargetExt = ".jpg";
            const string FilePath = "/some/path.jpg";

            using var stream = new MemoryStream();

            var package = Substitute.ForPartsOf<OpenXmlPackage>();
            package.WithStorage(stream, PackageOpenMode.Create);

            var features = new FeatureCollection();
            var part = Substitute.ForPartsOf<OpenXmlPart>();
            part.Features.Returns(features);
            var targetFeature = Substitute.For<ITargetFeature>();
            var partExtensionFeature = Substitute.For<IPartExtensionFeature>();
            var partUriFeature = Substitute.For<IPartUriFeature>();
            var contentTypeFeature = Substitute.For<IContentTypeFeature>();
            var expectedUri = new Uri(FilePath, UriKind.Relative);
            partUriFeature.CreatePartUri(ContentType, OpenXmlPackage.Uri, string.Empty, string.Empty, TargetExt).Returns(expectedUri);

            features.Set(partUriFeature);
            features.Set(partExtensionFeature);
            features.Set(targetFeature);
            features.Set(contentTypeFeature);

            // Act
            part.CreateInternal(package, null, ContentType, TargetExt);

            // Assert
            Assert.Equal(FilePath, part.Uri.ToString());
        }

        [Fact]
        public void ExtensionTestKnownContentType()
        {
            // Arrange
            const string ContentType = "image/jpeg";
            const string TargetExt = ".foo";
            const string ExpectedExt = ".bar";
            const string FilePath = "/some/path.bar";

            using var stream = new MemoryStream();

            var package = Substitute.ForPartsOf<OpenXmlPackage>();
            package.WithStorage(stream, PackageOpenMode.Create);

            var features = new FeatureCollection();
            var part = Substitute.ForPartsOf<OpenXmlPart>();
            part.Features.Returns(features);
            var targetFeature = Substitute.For<ITargetFeature>();
            var partExtensionFeature = Substitute.For<IPartExtensionFeature>();
            var partUriFeature = Substitute.For<IPartUriFeature>();
            var contentTypeFeature = Substitute.For<IContentTypeFeature>();
            var expectedUri = new Uri(FilePath, UriKind.Relative);

            partExtensionFeature.TryGetExtension(ContentType, out string expectedExt).Returns(callInfo =>
            {
                callInfo[1] = ExpectedExt;
                return true;
            });

            partUriFeature.CreatePartUri(ContentType, OpenXmlPackage.Uri, string.Empty, string.Empty, ExpectedExt).Returns(expectedUri);

            features.Set(partUriFeature);
            features.Set(partExtensionFeature);
            features.Set(targetFeature);
            features.Set(contentTypeFeature);

            // Act
            part.CreateInternal(package, null, ContentType, TargetExt);

            // Assert
            Assert.Equal(FilePath, part.Uri.ToString());
        }

        [Fact]
        public void ExtensionTestUndefinedExtension()
        {
            // Arrange
            const string ContentType = "test/mimetype";
            const string FilePath = "/some/path.jpg";

            using var stream = new MemoryStream();

            var package = Substitute.ForPartsOf<OpenXmlPackage>();
            package.WithStorage(stream, PackageOpenMode.Create);

            var features = new FeatureCollection();
            var part = Substitute.ForPartsOf<OpenXmlPart>();
            part.Features.Returns(features);
            var targetFeature = Substitute.For<ITargetFeature>();
            var partExtensionFeature = Substitute.For<IPartExtensionFeature>();
            var partUriFeature = Substitute.For<IPartUriFeature>();
            var contentTypeFeature = Substitute.For<IContentTypeFeature>();
            var expectedUri = new Uri(FilePath, UriKind.Relative);

            partUriFeature.CreatePartUri(ContentType, OpenXmlPackage.Uri, string.Empty, string.Empty, string.Empty).Returns(expectedUri);

            features.Set(partUriFeature);
            features.Set(partExtensionFeature);
            features.Set(targetFeature);
            features.Set(contentTypeFeature);

            // Act
            part.CreateInternal(package, null, ContentType, string.Empty);

            // Assert
            Assert.Equal(FilePath, part.Uri.ToString());
        }

        [Fact]
        public void ExtensionTestFixedContentType()
        {
            // Arrange
            const string ContentType = "test/mimetype";
            const string TargetExt = ".jpg";
            const string FilePath = "/some/path.jpg";

            using var stream = new MemoryStream();

            var package = Substitute.ForPartsOf<OpenXmlPackage>();
            package.WithStorage(stream, PackageOpenMode.Create);

            var features = new FeatureCollection();
            var part = Substitute.ForPartsOf<OpenXmlPart>();
            part.Features.Returns(features);
            var targetFeature = Substitute.For<ITargetFeature>();
            var partExtensionFeature = Substitute.For<IPartExtensionFeature>();
            var partUriFeature = Substitute.For<IPartUriFeature>();
            var contentTypeFeature = Substitute.For<IContentTypeFeature>();
            var expectedUri = new Uri(FilePath, UriKind.Relative);

            contentTypeFeature.IsConstant.Returns(true);
            partUriFeature.CreatePartUri(ContentType, OpenXmlPackage.Uri, string.Empty, string.Empty, string.Empty).Returns(expectedUri);

            features.Set(partUriFeature);
            features.Set(partExtensionFeature);
            features.Set(targetFeature);
            features.Set(contentTypeFeature);

            // Act
            part.CreateInternal(package, null, ContentType, TargetExt);

            // Assert
            Assert.Equal(FilePath, part.Uri.ToString());
        }
    }
}
