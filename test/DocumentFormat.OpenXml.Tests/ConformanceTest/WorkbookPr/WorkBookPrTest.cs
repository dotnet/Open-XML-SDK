// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.WorkBookPrClass;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.WorkBookPr
{
    public class WorkBookPrTest : OpenXmlTestBase
    {
        public WorkBookPrTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void WorkBookPr01EditElement()
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
        public void WorkBookPr03DeleteElement()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(stream);

                var testEntities = new TestEntities(stream);

                testEntities.DeleteElements(stream, Log);
                testEntities.VerifyDeleteElements(stream, Log);

                testEntities.AddElement(stream, Log);
                testEntities.VerifyAddElements(stream, Log);
            }
        }
    }
}
