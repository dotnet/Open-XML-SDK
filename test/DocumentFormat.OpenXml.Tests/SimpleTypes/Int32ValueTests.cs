// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class Int32ValueTests : OpenXmlComparableSimpleValueTests<int>
    {
        protected override OpenXmlComparableSimpleValue<int> Create(int input) => new Int32Value(input);

        protected override int[] Values => new int[] { int.MinValue, int.MinValue + 1, int.MaxValue - 1, int.MaxValue };

        protected override IEnumerable<TestValue> TestValues { get; } = new[]
        {
            new TestValue(int.MinValue, "-2147483648"),
            new TestValue(int.MinValue + 1, "-2147483647"),
            new TestValue(-1, "-1"),
            new TestValue(0, "0"),
            new TestValue(1, "1"),
            new TestValue(int.MaxValue, "2147483647"),
            new TestValue(int.MaxValue - 1, "2147483646"),
            new TestValue((int)1e6, "1e6"),
            new TestValue((int)1.00001e6, "1.00001e6"),
        };

        public Int32ValueTests()
        {
            SmallValue1 = new Int32Value(10);
            SmallValue2 = new Int32Value(10);
            LargeValue = new Int32Value(20);
        }
    }
}
