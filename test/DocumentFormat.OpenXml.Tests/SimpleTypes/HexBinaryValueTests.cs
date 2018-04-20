namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class HexBinaryValueTests : OpenXmlComparableReferenceTypeTests<string>
    {
        private const string SmallHexBinary = "12345678";
        private const string LargeHexBinary = "FEDCBA98";

        public HexBinaryValueTests()
        {
            SmallValue1 = new HexBinaryValue(SmallHexBinary);
            SmallValue2 = new HexBinaryValue(SmallHexBinary);

            NullValue1 = new HexBinaryValue();
            NullValue2 = new HexBinaryValue();

            LargeValue = new HexBinaryValue(LargeHexBinary);
        }
    }
}
