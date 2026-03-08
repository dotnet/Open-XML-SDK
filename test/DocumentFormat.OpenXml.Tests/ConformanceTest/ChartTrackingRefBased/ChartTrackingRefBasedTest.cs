// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.ChartTrackingRefBasedClass;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.ChartTrackingRefBased
{
    public class ChartTrackingRefBasedTest : OpenXmlTestBase
    {
        public ChartTrackingRefBasedTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ChartTrackingRefBasedTest01()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(stream);

                var testEntities = new TestEntities(stream);

                testEntities.EditElements(stream, Output);
                testEntities.VerifyElements(stream, Output);
            }
        }

        [Fact]
        public void ChartTrackingRefBasedTest03DeleteAddElement()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(stream);

                var testEntities = new TestEntities(stream);
                testEntities.DeleteElements(stream, Output);
                testEntities.VerifyDeleteElements(stream, Output);

                testEntities.AddElements(stream, Output);
                testEntities.VerifyAddElements(stream, Output);
            }
        }
    }
}
