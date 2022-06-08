// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class TrueFalseBlankValueTests : OpenXmlComparableSimpleValueTests<bool>
    {
        protected override OpenXmlComparableSimpleValue<bool> Create(bool input) => new TrueFalseBlankValue(input);

        protected override bool[] Values => new[] { true, false };

        public TrueFalseBlankValueTests()
        {
            SmallValue1 = new TrueFalseBlankValue(false);
            SmallValue2 = new TrueFalseBlankValue(false);
            LargeValue = new TrueFalseBlankValue(true);
        }
    }
}
