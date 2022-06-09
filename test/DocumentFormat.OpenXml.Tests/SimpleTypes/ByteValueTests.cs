// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class ByteValueTests : OpenXmlComparableSimpleValueTests<byte>
    {
        protected override OpenXmlComparableSimpleValue<byte> Create(byte input) => new ByteValue(input);

        protected override byte[] Values { get; } = new byte[] { byte.MinValue, byte.MinValue + 1, byte.MaxValue - 1, byte.MaxValue };

        public ByteValueTests()
        {
            SmallValue1 = new ByteValue((byte)10);
            SmallValue2 = new ByteValue((byte)10);
            LargeValue = new ByteValue((byte)20);
        }
    }
}
