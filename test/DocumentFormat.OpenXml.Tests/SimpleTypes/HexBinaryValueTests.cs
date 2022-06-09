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

        [Fact]
        public void GetBytes()
        {
            var type = new HexBinaryValue();

            Assert.False(type.TryGetBytes(out _));

            type.InnerText = "00";
            Assert.True(type.TryGetBytes(out var result1));
            Assert.Collection(result1, b => Assert.Equal(0, b));

            type.InnerText = "01";
            Assert.True(type.TryGetBytes(out var result2));
            Assert.Collection(result2, b => Assert.Equal(1, b));

            type.InnerText = "FF";
            Assert.True(type.TryGetBytes(out var result3));
            Assert.Collection(result3, b => Assert.Equal(0xFF, b));

            type.InnerText = "FFF";
            Assert.False(type.TryGetBytes(out _));

            type.InnerText = "FF01";
            Assert.True(type.TryGetBytes(out var result4));
            Assert.Collection(
                result4,
                b => Assert.Equal(0xFF, b),
                b => Assert.Equal(0x01, b));
        }

        [Fact]
        public void CreateFromBytes()
        {
            Assert.Equal(string.Empty, HexBinaryValue.Create().Value);
            Assert.Equal("00", HexBinaryValue.Create(0).Value);
            Assert.Equal("01", HexBinaryValue.Create(1).Value);
            Assert.Equal("FF", HexBinaryValue.Create(0xFF).Value);
            Assert.Equal("FF01", HexBinaryValue.Create(0xFF, 0x01).Value);
        }
    }
}
