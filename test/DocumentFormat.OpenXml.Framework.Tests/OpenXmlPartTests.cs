using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var expectedUri = new Uri("/some/path.jpg", UriKind.Relative);
            partUriFeature.CreatePartUri(ContentType, OpenXmlPackage.Uri, string.Empty, string.Empty, TargetExt).Returns(expectedUri);

            features.Set(partUriFeature);
            features.Set(partExtensionFeature);
            features.Set(targetFeature);
            features.Set(contentTypeFeature);

            // Act
            part.CreateInternal(package, null, ContentType, TargetExt);

            // Assert
            Assert.Equal("/some/path.jpg", part.Uri.ToString());
        }
    }
}
