// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class Int32ValueTests : OpenXmlComparableSimpleValueTests<int>
    {
        protected override OpenXmlComparableSimpleValue<int> Create(int input) => new Int32Value(input);

        protected override int[] Values => new int[] { int.MinValue, int.MinValue + 1, int.MaxValue - 1, int.MaxValue };

        public Int32ValueTests()
        {
            SmallValue1 = new Int32Value(10);
            SmallValue2 = new Int32Value(10);
            LargeValue = new Int32Value(20);
        }

        // Regression for https://github.com/dotnet/Open-XML-SDK/issues/2007:
        // ECMA-376 percentage attributes (e.g. a:biLevel/@thresh) are a union of an integer in
        // 1000ths of a percent and a string with a trailing '%'. Office emits the string form.
        [Theory]
        [InlineData("50%", 50000)]
        [InlineData("100%", 100000)]
        [InlineData("0%", 0)]
        [InlineData("0.5%", 500)]
        [InlineData("-25%", -25000)]
        [InlineData("12345", 12345)]
        public void ParsesIntegerAndPercentageForms(string input, int expected)
        {
            var value = new Int32Value { InnerText = input };
            Assert.Equal(expected, value.Value);
        }
    }
}
