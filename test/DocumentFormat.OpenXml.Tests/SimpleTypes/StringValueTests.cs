// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class StringValueTests : OpenXmlComparableSimpleReferenceTests<string>
    {
        private const string SmallString = "abcdef";
        private const string LargeString = "uvwxyz";

        public StringValueTests()
        {
            SmallValue1 = new StringValue(SmallString);
            SmallValue2 = new StringValue(SmallString);

            NullValue1 = new StringValue();
            NullValue2 = new StringValue();

            LargeValue = new StringValue(LargeString);
        }
    }
}
