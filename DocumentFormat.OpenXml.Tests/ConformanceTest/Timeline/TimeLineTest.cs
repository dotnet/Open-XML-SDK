// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

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
