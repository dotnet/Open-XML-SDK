// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class Int32ValueTests : OpenXmlComparableSimpleValueTests<int>
    {
        public Int32ValueTests()
        {
            SmallValue1 = new Int32Value(10);
            SmallValue2 = new Int32Value(10);
            LargeValue = new Int32Value(20);
        }
    }
}
