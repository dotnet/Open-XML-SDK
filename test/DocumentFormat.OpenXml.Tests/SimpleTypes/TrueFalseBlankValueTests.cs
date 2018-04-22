// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class TrueFalseBlankValueTests : OpenXmlComparableSimpleValueTests<bool>
    {
        public TrueFalseBlankValueTests()
        {
            SmallValue1 = new TrueFalseBlankValue(false);
            SmallValue2 = new TrueFalseBlankValue(false);
            LargeValue = new TrueFalseBlankValue(true);
        }
    }
}
