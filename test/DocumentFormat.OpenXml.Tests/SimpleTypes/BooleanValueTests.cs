// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class BooleanValueTests : OpenXmlComparableSimpleValueTests<bool>
    {
        protected override OpenXmlComparableSimpleValue<bool> Create(bool input) => new BooleanValue(input);

        protected override bool[] Values => new[] { true, false };

        public BooleanValueTests()
        {
            SmallValue1 = new BooleanValue(false);
            SmallValue2 = new BooleanValue(false);
            LargeValue = new BooleanValue(true);
        }
    }
}
