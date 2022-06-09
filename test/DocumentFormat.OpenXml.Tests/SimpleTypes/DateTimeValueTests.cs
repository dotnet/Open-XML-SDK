// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class DateTimeValueTests : OpenXmlComparableSimpleValueTests<DateTime>
    {
        protected override OpenXmlComparableSimpleValue<DateTime> Create(DateTime input) => new DateTimeValue(input);

        protected override DateTime[] Values => new DateTime[] { DateTime.MinValue, DateTime.MinValue.AddDays(1), DateTime.MaxValue.AddDays(-1), DateTime.MaxValue };

        public DateTimeValueTests()
        {
            SmallValue1 = new DateTimeValue(DateTime.MinValue);
            SmallValue2 = new DateTimeValue(DateTime.MinValue);
            LargeValue = new DateTimeValue(DateTime.MaxValue);
        }
    }
}
