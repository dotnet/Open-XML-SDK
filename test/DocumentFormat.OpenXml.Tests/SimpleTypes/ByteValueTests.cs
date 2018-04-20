namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class ByteValueTests : OpenXmlComparableValueTypeTests<byte>
    {
        public ByteValueTests()
        {
            SmallValue1 = new ByteValue((byte) 10);
            SmallValue2 = new ByteValue((byte) 10);
            LargeValue = new ByteValue((byte) 20);
        }
    }
}
