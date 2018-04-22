// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace DocumentFormat.OpenXml.Attributes
{
    public class BinaryValueConverterTests
    {
        [InlineData(1, "0", 0)]
        [InlineData(2, "00", 0)]
        [InlineData(5, "00000", 0)]
        [InlineData(2, "01", 1)]
        [InlineData(5, "00101", 5)]
        [InlineData(3, "101", 5)]
        [InlineData(3, "011", 3)]
        [InlineData(3, "111", 7)]
        [Theory]
        public void StringToValueTest(int length, string str, long value)
        {
            var formatter = new BinaryValueConverter(length);
            Assert.Equal(str, formatter.ValueToString(value));
            Assert.Equal(value, formatter.StringToValue(str));
        }

        [InlineData(3, null, 0, "000")]
        [InlineData(3, "", 0, "000")]
        [InlineData(3, "121", 5, "101")]
        [InlineData(3, "201", 1, "001")]
        [Theory]
        public void StringToValueTestMalformed(int length, string str, long value, string expectedString)
        {
            var formatter = new BinaryValueConverter(length);
            Assert.Equal(expectedString, formatter.ValueToString(value));
            Assert.Equal(value, formatter.StringToValue(str));
        }
    }
}
