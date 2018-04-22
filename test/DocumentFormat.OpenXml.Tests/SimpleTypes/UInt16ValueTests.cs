// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class UInt16ValueTests : OpenXmlComparableSimpleValueTests<ushort>
    {
        public UInt16ValueTests()
        {
            SmallValue1 = new UInt16Value((ushort) 10);
            SmallValue2 = new UInt16Value((ushort) 10);
            LargeValue = new UInt16Value((ushort) 20);
        }
    }
}
