// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Xunit;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions.Tests
{
    public class TokenRestrictionTests
    {
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData(" ", false)]
        [InlineData("a ", false)]
        [InlineData("a\nd", false)]
        [InlineData("a\td", false)]
        [InlineData("a\rd", false)]
        [InlineData("abc def", true)]
        [InlineData("abc  def", false)]
        [Theory]
        public void VerifyTOKEN(string text, bool expected)
        {
            Assert.Equal(expected, TokenRestriction.VerifyTOKEN(text));
        }
    }
}
