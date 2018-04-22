// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class IntegerValueTests : OpenXmlComparableSimpleValueTests<long>
    {
        public IntegerValueTests()
        {
            SmallValue1 = new IntegerValue(10L);
            SmallValue2 = new IntegerValue(10L);
            LargeValue = new IntegerValue(20L);
        }
    }
}
