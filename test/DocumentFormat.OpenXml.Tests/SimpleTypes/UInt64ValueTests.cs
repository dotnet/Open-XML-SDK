// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class UInt64ValueTests : OpenXmlComparableSimpleValueTests<ulong>
    {
        public UInt64ValueTests()
        {
            SmallValue1 = new UInt64Value(10UL);
            SmallValue2 = new UInt64Value(10UL);
            LargeValue = new UInt64Value(20UL);
        }
    }
}
