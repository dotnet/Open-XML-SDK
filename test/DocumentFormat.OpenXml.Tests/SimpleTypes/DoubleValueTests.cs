// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
