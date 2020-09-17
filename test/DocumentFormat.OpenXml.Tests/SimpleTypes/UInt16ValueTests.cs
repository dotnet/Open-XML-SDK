// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class UInt16ValueTests : OpenXmlComparableSimpleValueTests<ushort>
    {
        protected override OpenXmlComparableSimpleValue<ushort> Create(ushort input) => new UInt16Value(input);

        protected override ushort[] Values => new ushort[] { ushort.MinValue, ushort.MinValue + 1, 0, ushort.MaxValue - 1, ushort.MaxValue };

        protected override IEnumerable<TestValue> TestValues { get; } = new[]
        {
            new TestValue(ushort.MinValue, "0"),
            new TestValue(ushort.MinValue + 1, "1"),
            new TestValue(ushort.MaxValue, "65535"),
            new TestValue(ushort.MaxValue - 1, "65534"),
        };

        public UInt16ValueTests()
        {
            SmallValue1 = new UInt16Value((ushort)10);
            SmallValue2 = new UInt16Value((ushort)10);
            LargeValue = new UInt16Value((ushort)20);
        }
    }
}
