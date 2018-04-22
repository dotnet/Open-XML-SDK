// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class Base64BinaryValueTests : OpenXmlComparableSimpleReferenceTests<string>
    {
        private static readonly string SmallString = Convert.ToBase64String(new byte[] { 31, 32, 33, 34, 35, 36 });
        private static readonly string LargeString = Convert.ToBase64String(new byte[] { 41, 42, 43, 44, 45, 46 });

        public Base64BinaryValueTests(ITestOutputHelper output)
        {
            SmallValue1 = new Base64BinaryValue(SmallString);
            SmallValue2 = new Base64BinaryValue(SmallString);

            NullValue1 = new Base64BinaryValue();
            NullValue2 = new Base64BinaryValue();

            LargeValue = new Base64BinaryValue(LargeString);

            output.WriteLine(SmallString);
            output.WriteLine(LargeString);
        }
    }
}
