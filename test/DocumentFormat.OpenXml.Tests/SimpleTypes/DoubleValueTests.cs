// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class DoubleValueTests : OpenXmlComparableSimpleValueTests<double>
    {
        protected override OpenXmlComparableSimpleValue<double> Create(double input) => new DoubleValue(input);

        protected override double[] Values => new double[] { double.NegativeInfinity, double.MinValue, double.MinValue + 1, double.NaN, double.MaxValue - 1, double.MaxValue, double.PositiveInfinity };

        public DoubleValueTests()
        {
            SmallValue1 = new DoubleValue(10.0);
            SmallValue2 = new DoubleValue(10.0);
            LargeValue = new DoubleValue(20.0);
        }
    }
}
