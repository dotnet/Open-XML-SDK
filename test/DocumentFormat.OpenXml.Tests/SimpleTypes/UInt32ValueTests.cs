// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class UInt32ValueTests : OpenXmlComparableSimpleValueTests<uint>
    {
        public UInt32ValueTests()
        {
            SmallValue1 = new UInt32Value(10U);
            SmallValue2 = new UInt32Value(10U);
            LargeValue = new UInt32Value(20U);
        }
    }
}
