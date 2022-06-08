// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

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
