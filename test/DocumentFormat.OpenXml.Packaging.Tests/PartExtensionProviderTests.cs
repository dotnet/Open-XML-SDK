// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Xunit;

namespace DocumentFormat.OpenXml.Packaging.Tests
{
    public class PartExtensionProviderTests
    {
        [Fact]
        public void SetsAppropriateComparer()
        {
            var provider1 = new PartExtensionProvider();
            var provider2 = new PartExtensionProvider(provider1);
            var provider3 = new PartExtensionProvider(5);

            Assert.Same(provider1.Comparer, StringComparer.Ordinal);
            Assert.Same(provider2.Comparer, StringComparer.Ordinal);
            Assert.Same(provider3.Comparer, StringComparer.Ordinal);
        }

        [Fact]
        public void MakeSurePartExtensionExistNullChecks()
        {
            var provider = new PartExtensionProvider();

            Assert.Throws<ArgumentNullException>("contentType", () => provider.MakeSurePartExtensionExist(null, null));
            Assert.Throws<ArgumentNullException>("partExtension", () => provider.MakeSurePartExtensionExist(string.Empty, null));
        }

        [Fact]
        public void AddContentTypeTwice()
        {
            const string ContentType = "contentType";
            const string PartExtension = "partExtensions";

            var provider = new PartExtensionProvider();

            Assert.False(provider.ContainsKey(ContentType));
            provider.MakeSurePartExtensionExist(ContentType, PartExtension);
            Assert.True(provider.ContainsKey(ContentType));
            Assert.Equal(PartExtension, provider[ContentType]);

            provider.MakeSurePartExtensionExist(ContentType, PartExtension);
            Assert.True(provider.ContainsKey(ContentType));
            Assert.Equal(PartExtension, provider[ContentType]);
        }

        [Fact]
        public void ReplaceContentType()
        {
            const string ContentType = "contentType";
            const string PartExtension1 = "partExtensions1";
            const string PartExtension2 = "partExtensions2";

            var provider = new PartExtensionProvider();

            Assert.False(provider.ContainsKey(ContentType));
            provider.MakeSurePartExtensionExist(ContentType, PartExtension1);
            Assert.True(provider.ContainsKey(ContentType));
            Assert.Equal(PartExtension1, provider[ContentType]);

            provider.MakeSurePartExtensionExist(ContentType, PartExtension2);
            Assert.True(provider.ContainsKey(ContentType));
            Assert.Equal(PartExtension2, provider[ContentType]);
        }

        [Fact]
        public void AddPartExtensionTest()
        {
            const string ContentType = "contentType";
            const string PartExtension = "partExtensions";

            var provider = new PartExtensionProvider();

            Assert.False(provider.ContainsKey(ContentType));
            provider.AddPartExtension(ContentType, PartExtension);
            Assert.True(provider.ContainsKey(ContentType));

            Assert.Throws<ArgumentException>(() => provider.AddPartExtension(ContentType, PartExtension));
        }
    }
}
