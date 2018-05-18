// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class TrueFalseValueTests : OpenXmlComparableSimpleValueTests<bool>
    {
        public TrueFalseValueTests()
        {
            SmallValue1 = new TrueFalseValue(false);
            SmallValue2 = new TrueFalseValue(false);
            LargeValue = new TrueFalseValue(true);
        }
    }
}
