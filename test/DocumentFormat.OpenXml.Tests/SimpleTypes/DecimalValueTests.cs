// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class DecimalValueTests : OpenXmlComparableSimpleValueTests<decimal>
    {
        public DecimalValueTests()
        {
            SmallValue1 = new DecimalValue(10m);
            SmallValue2 = new DecimalValue(10m);
            LargeValue = new DecimalValue(20m);
        }
    }
}
