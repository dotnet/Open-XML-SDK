// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.WorkBookPrClass;
using System.IO;
using Xunit;

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

                testEntities.EditElements(stream, Output);
                testEntities.VerifyElements(stream, Output);
            }
        }

        [Fact]
        public void WorkBookPr03DeleteElement()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(stream);

                var testEntities = new TestEntities(stream);

                testEntities.DeleteElements(stream, Output);
                testEntities.VerifyDeleteElements(stream, Output);

                testEntities.AddElement(stream, Output);
                testEntities.VerifyAddElements(stream, Output);
            }
        }
    }
}
