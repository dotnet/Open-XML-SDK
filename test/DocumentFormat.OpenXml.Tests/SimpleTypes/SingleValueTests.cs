// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class SingleValueTests : OpenXmlComparableSimpleValueTests<float>
    {
        public SingleValueTests()
        {
            SmallValue1 = new SingleValue(10.0F);
            SmallValue2 = new SingleValue(10.0F);
            LargeValue = new SingleValue(20.0F);
        }
    }
}
