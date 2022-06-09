// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class UInt32ValueTests : OpenXmlComparableSimpleValueTests<uint>
    {
        protected override OpenXmlComparableSimpleValue<uint> Create(uint input) => new UInt32Value(input);

        protected override uint[] Values => new uint[] { uint.MinValue, uint.MinValue + 1, 0, uint.MaxValue - 1, uint.MaxValue };

        public UInt32ValueTests()
        {
            SmallValue1 = new UInt32Value(10U);
            SmallValue2 = new UInt32Value(10U);
            LargeValue = new UInt32Value(20U);
        }
    }
}
