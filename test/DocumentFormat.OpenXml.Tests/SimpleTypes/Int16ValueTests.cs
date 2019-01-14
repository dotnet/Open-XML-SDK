// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class Int16ValueTests : OpenXmlComparableSimpleValueTests<short>
    {
        protected override OpenXmlComparableSimpleValue<short> Create(short input) => new Int16Value(input);

        protected override short[] Values => new short[] { short.MinValue, short.MinValue + 1, 0, short.MaxValue - 1, short.MaxValue };

        public Int16ValueTests()
        {
            SmallValue1 = new Int16Value((short)10);
            SmallValue2 = new Int16Value((short)10);
            LargeValue = new Int16Value((short)20);
        }
    }
}
