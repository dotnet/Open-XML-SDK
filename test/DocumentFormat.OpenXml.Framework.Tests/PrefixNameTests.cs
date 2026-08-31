// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    public class PrefixNameTests
    {
        [InlineData("prefix:name", "prefix", "name")]
        [InlineData(":name", "", "name")]
        [InlineData("prefix:", "prefix", "")]
        [InlineData(":", "", "")]
        [Theory]
        public void TryParsePrefixedSucceedsForSingleColon(string name, string expectedPrefix, string expectedName)
        {
            Assert.True(PrefixName.TryParsePrefixed(name, out var result));
            Assert.Equal(expectedPrefix, result.Prefix);
            Assert.Equal(expectedName, result.Name);
        }

        [InlineData("")]
        [InlineData("name")]
        [InlineData("prefix:name:other")]
        [InlineData("::")]
        [Theory]
        public void TryParsePrefixedFailsWithoutASingleColon(string name)
        {
            Assert.False(PrefixName.TryParsePrefixed(name, out _));
        }
    }
}
