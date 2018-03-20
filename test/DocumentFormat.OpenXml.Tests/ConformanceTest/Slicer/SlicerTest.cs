// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.SlicerClass;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.Slicer
{
    public class SlicerTest : OpenXmlTestBase
    {
        public SlicerTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void Slicer01EditElement()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(stream);

                TestEntities testEntities = new TestEntities();
                testEntities.EditElements(stream, Log);
                testEntities.VerifyElements(stream, Log);
            }
        }
    }
}
