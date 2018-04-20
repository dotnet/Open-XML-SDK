namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class DecimalValueTests : OpenXmlComparableValueTypeTests<decimal>
    {
        public DecimalValueTests()
        {
            SmallValue1 = new DecimalValue(10m);
            SmallValue2 = new DecimalValue(10m);
            LargeValue = new DecimalValue(20m);
        }
    }

    public class DoubleValueTests : OpenXmlComparableValueTypeTests<double>
    {
        public DoubleValueTests()
        {
            SmallValue1 = new DoubleValue(10.0);
            SmallValue2 = new DoubleValue(10.0);
            LargeValue = new DoubleValue(20.0);
        }
    }
}
