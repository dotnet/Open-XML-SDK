// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class ByteValueTests : OpenXmlComparableSimpleValueTests<byte>
    {
        public ByteValueTests()
        {
            SmallValue1 = new ByteValue((byte) 10);
            SmallValue2 = new ByteValue((byte) 10);
            LargeValue = new ByteValue((byte) 20);
        }
    }
}
