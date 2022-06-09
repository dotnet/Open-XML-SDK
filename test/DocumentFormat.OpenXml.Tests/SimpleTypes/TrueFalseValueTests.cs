// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class TrueFalseValueTests : OpenXmlComparableSimpleValueTests<bool>
    {
        protected override OpenXmlComparableSimpleValue<bool> Create(bool input) => new TrueFalseBlankValue(input);

        protected override bool[] Values => new[] { true, false };

        public TrueFalseValueTests()
        {
            SmallValue1 = new TrueFalseValue(false);
            SmallValue2 = new TrueFalseValue(false);
            LargeValue = new TrueFalseValue(true);
        }
    }
}
