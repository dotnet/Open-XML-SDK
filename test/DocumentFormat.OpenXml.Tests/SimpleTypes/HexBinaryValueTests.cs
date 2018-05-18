// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class HexBinaryValueTests : OpenXmlComparableSimpleReferenceTests<string>
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
