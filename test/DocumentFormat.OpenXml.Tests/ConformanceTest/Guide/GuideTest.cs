// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.GuideClass;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.GuideTest
{
    public class GuideTest : OpenXmlTestBase
    {
        public GuideTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void Guide01EditElement()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(stream);
                var testEntities = new TestEntities(stream);

                testEntities.EditElement(stream, Log);
                testEntities.VerifyElement(stream, Log);
            }
        }

        [Fact]
        public void Guide03DeleteAddElement()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(stream);
                var testEntities = new TestEntities(stream);

                testEntities.DeleteElement(stream, Log);
                testEntities.VerifyDeletedElement(stream, Log);

                testEntities.AddElement(stream, Log);
                testEntities.VerifyAddedElemenet(stream, Log);
            }
        }
    }
}
