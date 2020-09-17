// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class UInt64ValueTests : OpenXmlComparableSimpleValueTests<ulong>
    {
        protected override OpenXmlComparableSimpleValue<ulong> Create(ulong input) => new UInt64Value(input);

        protected override ulong[] Values => new[] { ulong.MinValue, ulong.MinValue + 1, ulong.MaxValue - 1, ulong.MaxValue };

        protected override IEnumerable<TestValue> TestValues { get; } = new[]
        {
            new TestValue(ulong.MinValue, "0"),
            new TestValue(ulong.MinValue + 1, "1"),
            new TestValue(ulong.MaxValue, "18446744073709551615"),
            new TestValue(ulong.MaxValue - 1, "18446744073709551614"),
            new TestValue((ulong)1e6, "1e6"),
        };

        public UInt64ValueTests()
        {
            SmallValue1 = new UInt64Value(10UL);
            SmallValue2 = new UInt64Value(10UL);
            LargeValue = new UInt64Value(20UL);
        }
    }
}
