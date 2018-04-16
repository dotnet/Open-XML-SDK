// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using NSubstitute;
using System.Xml;
using Xunit;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions.Tests
{
    public class HexBinaryRestrictionTests
    {
        [InlineData(null, false)]
        [InlineData("", true)]
        [InlineData("a", false)]
        [InlineData("A", false)]
        [InlineData("zz", false)]
        [InlineData("gg", false)]
        [InlineData("bb", true)]
        [InlineData("0A", true)]
        [InlineData("5A", true)]
        [InlineData("5dA", false)]
        [InlineData("5AbC5AbC5AbC5AbC5AbC5AbC5AbC5AbC", true)]
        [InlineData("5AbC5AbC5AbC5AbC5AbC5AbC5AbC5Ab", false)]
        [Theory]
        public void ValidateValue(string innerText, bool expected)
        {
            var restriction = new HexBinaryRestriction();
            var type = Substitute.ForPartsOf<OpenXmlSimpleType>();

            type.InnerText.Returns(innerText);

            Assert.Equal(expected, restriction.ValidateValueType(type));
        }
    }
}
