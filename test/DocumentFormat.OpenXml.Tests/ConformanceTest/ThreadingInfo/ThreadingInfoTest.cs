// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.ChartTrackingRefBasedClass;
using DocumentFormat.OpenXml.Tests.TaskLibraries;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.ThreadingInfo
{
    public class ThreadingInfoTest : OpenXmlTestBase
    {
        public ThreadingInfoTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ThreadingInfo01EditElement()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(stream);

                var testEntities = new TestEntities(stream);
                testEntities.EditElements(stream, Log);
                testEntities.VerifyElements(stream, Log);
            }
        }

        [Fact]
        public void ThreadingInfo03DeleteElement()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(stream);

                var testEntities = new TestEntities(stream);
                testEntities.DeleteElements(stream, Log);
                testEntities.VerifyDeleteElements(stream, Log);
            }
        }

        [Fact]
        public void ThreadingInfo03AddElement()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(stream);

                var testEntities = new TestEntities(stream);
                testEntities.AddElements(stream, Log);
                testEntities.VerifyAddElements(stream, Log);
            }
        }
    }
}
