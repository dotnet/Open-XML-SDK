using System;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class DateTimeValueTests : OpenXmlComparableValueTypeTests<DateTime>
    {
        public DateTimeValueTests()
        {
            SmallValue1 = new DateTimeValue(DateTime.MinValue);
            SmallValue2 = new DateTimeValue(DateTime.MinValue);
            LargeValue = new DateTimeValue(DateTime.MaxValue);
        }
    }
}
