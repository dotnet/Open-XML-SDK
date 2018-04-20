namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class BooleanValueTests : OpenXmlComparableValueTypeTests<bool>
    {
        public BooleanValueTests()
        {
            SmallValue1 = new BooleanValue(false);
            SmallValue2 = new BooleanValue(false);
            LargeValue = new BooleanValue(true);
        }
    }
}
