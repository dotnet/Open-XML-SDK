// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class Int64ValueTests : OpenXmlComparableSimpleValueTests<long>
    {
        protected override OpenXmlComparableSimpleValue<long> Create(long input) => new Int64Value(input);

        protected override long[] Values => new long[] { long.MinValue, long.MinValue + 1, long.MaxValue - 1, long.MaxValue };

        protected override IEnumerable<TestValue> TestValues { get; } = new[]
        {
            new TestValue(long.MinValue, "-9223372036854775808"),
            new TestValue(long.MinValue + 1, "-9223372036854775807"),
            new TestValue(-1, "-1"),
            new TestValue(0, "0"),
            new TestValue(1, "1"),
            new TestValue((long)1e6, "1e6"),
            new TestValue((int)1.00001e6, "1.00001e6"),
            new TestValue(long.MaxValue - 1, "9223372036854775806"),
            new TestValue(long.MaxValue, "9223372036854775807"),
        };

        public Int64ValueTests()
        {
            SmallValue1 = new Int64Value(10L);
            SmallValue2 = new Int64Value(10L);
            LargeValue = new Int64Value(20L);
        }
    }
}
