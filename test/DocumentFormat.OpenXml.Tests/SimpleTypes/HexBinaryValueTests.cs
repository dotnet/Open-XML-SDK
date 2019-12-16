// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class HexBinaryValueTests : OpenXmlComparableSimpleReferenceTests<string>
    {
        private const string SmallHexBinary = "12345678";
        private const string LargeHexBinary = "FEDCBA98";

        public HexBinaryValueTests()
        {
            SmallValue1 = new HexBinaryValue(SmallHexBinary);
            SmallValue2 = new HexBinaryValue(SmallHexBinary);

            NullValue1 = new HexBinaryValue();
            NullValue2 = new HexBinaryValue();

            LargeValue = new HexBinaryValue(LargeHexBinary);
        }

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
            var type = new HexBinaryValue
            {
                InnerText = innerText,
            };

            Assert.Equal(expected, type.IsValid);
        }
    }
}
