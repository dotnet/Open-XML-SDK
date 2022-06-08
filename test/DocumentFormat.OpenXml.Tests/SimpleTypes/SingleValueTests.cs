// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class SingleValueTests : OpenXmlComparableSimpleValueTests<float>
    {
        protected override OpenXmlComparableSimpleValue<float> Create(float input) => new SingleValue(input);

        protected override float[] Values => new float[] { float.NegativeInfinity, float.MinValue, float.MinValue + 1, 0, float.NaN, float.MaxValue - 1, float.MaxValue };

        public SingleValueTests()
        {
            SmallValue1 = new SingleValue(10.0F);
            SmallValue2 = new SingleValue(10.0F);
            LargeValue = new SingleValue(20.0F);
        }
    }
}
