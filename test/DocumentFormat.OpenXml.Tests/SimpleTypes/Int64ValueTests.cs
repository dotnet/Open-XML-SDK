// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class Int64ValueTests : OpenXmlComparableSimpleValueTests<long>
    {
        public Int64ValueTests()
        {
            SmallValue1 = new Int64Value(10L);
            SmallValue2 = new Int64Value(10L);
            LargeValue = new Int64Value(20L);
        }
    }
}
