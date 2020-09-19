// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class UInt32ValueTests : OpenXmlComparableSimpleValueTests<uint>
    {
        protected override OpenXmlComparableSimpleValue<uint> Create(uint input) => new UInt32Value(input);

        protected override uint[] Values => new uint[] { uint.MinValue, uint.MinValue + 1, 0, uint.MaxValue - 1, uint.MaxValue };

        protected override IEnumerable<TestValue> TestValues { get; } = new[]
        {
            new TestValue(uint.MinValue, "0"),
            new TestValue(uint.MinValue + 1, "1"),
            new TestValue(uint.MaxValue, "4294967295"),
            new TestValue(uint.MaxValue - 1, "4294967294"),
            new TestValue((uint)1e6, "1e6"),
            new TestValue((int)1.00001e6, "1.00001e6"),
        };

        public UInt32ValueTests()
        {
            SmallValue1 = new UInt32Value(10U);
            SmallValue2 = new UInt32Value(10U);
            LargeValue = new UInt32Value(20U);
        }
    }
}
