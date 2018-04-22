// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace DocumentFormat.OpenXml.Attributes.Translator
{
    public class HexValueConverterTests
    {
        [InlineData(0, "0000")]
        [InlineData(0x3, "0003")]
        [InlineData(0x31, "0031")]
        [InlineData(0x314, "0314")]
        [InlineData(0x3141, "3141")]
        [InlineData(0x31415, "31415")]
        [InlineData(0x104, "0104")]
        [InlineData(0x10324, "10324")]
        [Theory]
        public void StringToValueTest(long value, string str)
        {
            var formatter = HexValueConverter.Instance;
            Assert.Equal(str, formatter.ValueToString(value));
            Assert.Equal(value, formatter.StringToValue(str));
        }

        [InlineData("kj")]
        [InlineData(null)]
        [InlineData("")]
        [Theory]
        public void NegativeTests(string input)
        {
            var formatter = HexValueConverter.Instance;

            Assert.Equal(0, formatter.StringToValue(input));
        }
    }
}
