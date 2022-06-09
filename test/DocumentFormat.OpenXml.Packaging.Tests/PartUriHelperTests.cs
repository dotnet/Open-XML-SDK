// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using Xunit;

namespace DocumentFormat.OpenXml.Packaging.Tests
{
    public class PartUriHelperTests
    {
        [MemberData(nameof(GetUniquePartData))]
        [Theory]
        public void GetUniquePartUriTest(string contentType, string parentUri, string targetUri, string expectedOnce, string expectedTwice)
        {
            var helper = new PartUriHelper();

            var unique = helper.GetUniquePartUri(contentType, new Uri(parentUri, UriKind.Relative), new Uri(targetUri, UriKind.Relative));
            Assert.Equal(new Uri(expectedOnce, UriKind.Relative), unique);

            var unique2 = helper.GetUniquePartUri(contentType, new Uri(parentUri, UriKind.Relative), new Uri(targetUri, UriKind.Relative));
            Assert.Equal(new Uri(expectedTwice, UriKind.Relative), unique2);
        }

        [MemberData(nameof(GetUniquePartData))]
        [Theory]
        public void GetUniquePartUri5Arg(string contentType, string parentUri, string targetUri, string expectedOnce, string expectedTwice)
        {
            var helper = new PartUriHelper();
            var unique1 = helper.GetUniquePartUri(
                contentType,
                PackUriHelper.ResolvePartUri(new Uri(parentUri, UriKind.Relative), new Uri(targetUri, UriKind.Relative)),
                ".",
                Path.GetFileNameWithoutExtension(targetUri),
                Path.GetExtension(targetUri));

            Assert.Equal(new Uri(expectedOnce, UriKind.Relative), unique1);

            var unique2 = helper.GetUniquePartUri(
                contentType,
                PackUriHelper.ResolvePartUri(new Uri(parentUri, UriKind.Relative), new Uri(targetUri, UriKind.Relative)),
                ".",
                Path.GetFileNameWithoutExtension(targetUri),
                Path.GetExtension(targetUri));

            Assert.Equal(new Uri(expectedTwice, UriKind.Relative), unique2);
        }

        [MemberData(nameof(GetUniquePartData))]
        [Theory]
        public void ReserveUriTest(string contentType, string parentUri, string targetUri, string expected, string expected2)
        {
            // We don't use this in the test, but it comes as part of the shared data set and parameter usage is enforced
            Assert.NotNull(expected);

            var helper = new PartUriHelper();
            var partUri = PackUriHelper.ResolvePartUri(new Uri(parentUri, UriKind.Relative), new Uri(targetUri, UriKind.Relative));

            helper.ReserveUri(contentType, partUri);

            var unique = helper.GetUniquePartUri(contentType, partUri, ".", Path.GetFileNameWithoutExtension(targetUri), Path.GetExtension(targetUri));

            Assert.Equal(new Uri(expected2, UriKind.Relative), unique);
        }

        public static IEnumerable<object[]> GetUniquePartData()
        {
            yield return new object[] { "unknown", "/", "/target", "/target", "/target2" };
            yield return new object[] { "unknown", "/something", "/target", "/target", "/target2" };
            yield return new object[] { "application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml", "/target", "target", "/target1", "/target2" };
            yield return new object[] { "application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml", "/target", "target.ext", "/target1.ext", "/target2.ext" };
        }
    }
}
