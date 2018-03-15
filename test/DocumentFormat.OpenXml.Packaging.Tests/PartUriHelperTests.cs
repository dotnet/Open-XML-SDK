// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.IO.Packaging;
using Xunit;

namespace DocumentFormat.OpenXml.Packaging.Tests
{
    public class PartUriHelperTests
    {
        [InlineData("unknown", "/", "/target", "/target")]
        [InlineData("unknown", "/something", "/target", "/target")]
        [InlineData("application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml", "/target", "target", "/target")]
        [Theory]
        public void GetUniquePartUriTest(string contentType, string parentUri, string targetUri, string expected)
        {
            var helper = new PartUriHelper();
            var unique = helper.GetUniquePartUri(contentType, new Uri(parentUri, UriKind.Relative), new Uri(targetUri, UriKind.Relative));

            Assert.Equal(new Uri(expected, UriKind.Relative), unique);
        }

        [InlineData("unknown", "/", "/target", "/target2")]
        [InlineData("unknown", "/something", "/target", "/target2")]
        [InlineData("application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml", "/target", "target", "/target1")]
        [Theory]
        public void GetUniquePartUriTestTwice(string contentType, string parentUri, string targetUri, string expected)
        {
            var helper = new PartUriHelper();
            var unique1 = helper.GetUniquePartUri(contentType, new Uri(parentUri, UriKind.Relative), new Uri(targetUri, UriKind.Relative));
            var unique2 = helper.GetUniquePartUri(contentType, new Uri(parentUri, UriKind.Relative), new Uri(targetUri, UriKind.Relative));

            Assert.Equal(new Uri(expected, UriKind.Relative), unique2);
        }

        [InlineData("unknown", "/", "/target", "/target")]
        [InlineData("unknown", "/something", "/target", "/target")]
        [InlineData("application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml", "/target", "target", "/target1")]
        [InlineData("application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml", "/target", "target.ext", "/target1.ext")]
        [Theory]
        public void GetUniquePartUri5Arg(string contentType, string parentUri, string targetUri, string expected)
        {
            var helper = new PartUriHelper();
            var unique = helper.GetUniquePartUri(
                contentType,
                PackUriHelper.ResolvePartUri(new Uri(parentUri, UriKind.Relative), new Uri(targetUri, UriKind.Relative)),
                ".",
                Path.GetFileNameWithoutExtension(targetUri),
                Path.GetExtension(targetUri));

            Assert.Equal(new Uri(expected, UriKind.Relative), unique);
        }

        [InlineData("unknown", "/", "/target", "/target2")]
        [InlineData("unknown", "/something", "/target", "/target2")]
        [InlineData("application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml", "/target", "target", "/target2")]
        [InlineData("application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml", "/target", "target.ext", "/target2.ext")]
        [Theory]
        public void ReserveUriTest(string contentType, string parentUri, string targetUri, string expected)
        {
            var helper = new PartUriHelper();
            var partUri = PackUriHelper.ResolvePartUri(new Uri(parentUri, UriKind.Relative), new Uri(targetUri, UriKind.Relative));

            helper.ReserveUri(contentType, partUri);

            var unique = helper.GetUniquePartUri(contentType, partUri, ".", Path.GetFileNameWithoutExtension(targetUri), Path.GetExtension(targetUri));

            Assert.Equal(new Uri(expected, UriKind.Relative), unique);
        }
    }
}
