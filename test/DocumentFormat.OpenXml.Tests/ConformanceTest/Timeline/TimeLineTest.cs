// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using DocumentFormat.OpenXml.Tests.TimelineClass;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.TimeLine
{
    public class TimeLineTest
    {
        [Fact]
        public void TimeLineEditAttributes()
        {
            using (var ms = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(ms);

                var testEntities = new TestEntities(ms);
                testEntities.EditAttributes(ms);
                testEntities.VerifyEditedAttribute(ms);

                testEntities.DeleteTimelineStyle(ms);
                testEntities.VerifyDeletedTimelineStyle(ms);

                testEntities.AddTimelineStyle(ms);
                testEntities.VerifyAddedTimelineStyle(ms);
            }
        }
    }
}
