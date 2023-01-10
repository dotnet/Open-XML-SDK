// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using Xunit;

namespace DocumentFormat.OpenXml.Packaging.Tests
{
    public class PartExtensionProviderTests
    {
        [Fact]
        public void SetsAppropriateComparer()
        {
            var provider = new PartExtensionProvider();

            Assert.Same(provider.Comparer, StringComparer.Ordinal);
        }

        [Fact]
        public void RegisterNullChecks()
        {
            var provider = new PartExtensionProvider();

            Assert.Throws<ArgumentNullException>("contentType", () => provider.Register(null, null));
            Assert.Throws<ArgumentNullException>("extension", () => provider.Register(string.Empty, null));
        }

        [Fact]
        public void AddContentTypeTwice()
        {
            const string ContentType = "contentType";
            const string PartExtension = "partExtensions";

            var provider = (IPartExtensionFeature)new PartExtensionProvider();

            Assert.False(provider.TryGetExtension(ContentType, out _));
            provider.Register(ContentType, PartExtension);
            Assert.True(provider.TryGetExtension(ContentType, out var existing1));
            Assert.Equal(PartExtension, existing1);

            provider.Register(ContentType, PartExtension);
            Assert.True(provider.TryGetExtension(ContentType, out var existing2));
            Assert.Equal(PartExtension, existing2);
        }

        [Fact]
        public void ReplaceContentType()
        {
            const string ContentType = "contentType";
            const string PartExtension1 = "partExtensions1";
            const string PartExtension2 = "partExtensions2";

            var provider = (IPartExtensionFeature)new PartExtensionProvider();

            Assert.False(provider.TryGetExtension(ContentType, out _));
            provider.Register(ContentType, PartExtension1);
            Assert.True(provider.TryGetExtension(ContentType, out var existing1));
            Assert.Equal(PartExtension1, existing1);

            provider.Register(ContentType, PartExtension2);
            Assert.True(provider.TryGetExtension(ContentType, out var existing2));
            Assert.Equal(PartExtension2, existing2);
        }
    }
}
