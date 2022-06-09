// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class DecimalValueTests : OpenXmlComparableSimpleValueTests<decimal>
    {
        protected override OpenXmlComparableSimpleValue<decimal> Create(decimal input) => new DecimalValue(input);

        protected override decimal[] Values => new decimal[] { decimal.MinValue, decimal.MinValue + 1, decimal.MinusOne, decimal.Zero, decimal.One, decimal.MaxValue - 1, decimal.MaxValue };

        public DecimalValueTests()
        {
            SmallValue1 = new DecimalValue(10m);
            SmallValue2 = new DecimalValue(10m);
            LargeValue = new DecimalValue(20m);
        }
    }
}
