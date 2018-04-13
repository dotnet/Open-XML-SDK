// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using NSubstitute;
using System.Collections.Generic;
using Xunit;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions.Tests
{
    public class TokenRestrictionTests
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { null, true };
            yield return new object[] { string.Empty, true };
            yield return new object[] { " ", false };
            yield return new object[] { "a ", false };
            yield return new object[] { "a\nd", false };
            yield return new object[] { "a\td", false };
            yield return new object[] { "a\rd", false };
            yield return new object[] { "abc def", true };
            yield return new object[] { "abc  def", false };
        }

        [MemberData(nameof(GetData))]
        [Theory]
        public void VerifyTOKEN(string text, bool expected)
        {
            Assert.Equal(expected, TokenRestriction.VerifyTOKEN(text));
        }

        [MemberData(nameof(GetData))]
        [Theory]
        public void ValidateText(string innerText, bool expected)
        {
            var restriction = new TokenRestriction();
            var type = Substitute.ForPartsOf<OpenXmlSimpleType>();

            type.InnerText.Returns(innerText);

            Assert.Equal(expected, restriction.ValidateValueType(type));
        }
    }
}
