// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class SByteValueTests : OpenXmlComparableSimpleValueTests<sbyte>
    {
        protected override OpenXmlComparableSimpleValue<sbyte> Create(sbyte input) => new SByteValue(input);

        protected override sbyte[] Values => new sbyte[] { sbyte.MinValue, sbyte.MinValue + 1, 0, sbyte.MaxValue - 1, sbyte.MaxValue };

        public SByteValueTests()
        {
            SmallValue1 = new SByteValue((sbyte) 10);
            SmallValue2 = new SByteValue((sbyte) 10);
            LargeValue = new SByteValue((sbyte) 20);
        }
    }
}
