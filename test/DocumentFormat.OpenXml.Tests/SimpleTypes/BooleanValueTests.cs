// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class BooleanValueTests : OpenXmlComparableSimpleValueTests<bool>
    {
        public BooleanValueTests()
        {
            SmallValue1 = new BooleanValue(false);
            SmallValue2 = new BooleanValue(false);
            LargeValue = new BooleanValue(true);
        }
    }
}
