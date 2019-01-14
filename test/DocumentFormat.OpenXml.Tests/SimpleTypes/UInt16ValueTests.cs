// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class UInt16ValueTests : OpenXmlComparableSimpleValueTests<ushort>
    {
        protected override OpenXmlComparableSimpleValue<ushort> Create(ushort input) => new UInt16Value(input);

        protected override ushort[] Values => new ushort[] { ushort.MinValue, ushort.MinValue + 1, 0, ushort.MaxValue - 1, ushort.MaxValue };

        public UInt16ValueTests()
        {
            SmallValue1 = new UInt16Value((ushort) 10);
            SmallValue2 = new UInt16Value((ushort) 10);
            LargeValue = new UInt16Value((ushort) 20);
        }
    }
}
