// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.PivotClass;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.Pivot
{
    public class PivotTest : OpenXmlTestBase
    {
        public PivotTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void PivotConnection01EditElement()
        {
            using (var stream = new MemoryStream())
            {
                ConnectionGeneratedDocument.CreatePackage(stream);

                var connectionTestEntities = new ConnectionTestEntities(stream);

                connectionTestEntities.EditElement(stream, Output);
                connectionTestEntities.VerifyElement(stream, Output);
            }
        }

        [Fact]
        public void PivotConnection03DeleteElement()
        {
            using (var stream = new MemoryStream())
            {
                ConnectionGeneratedDocument.CreatePackage(stream);

                var connectionTestEntities = new ConnectionTestEntities(stream);

                connectionTestEntities.DeleteElement(stream, Output);
                connectionTestEntities.VerifyDeletedElement(stream, Output);
            }
        }

        [Fact]
        public void PivotConnection03AddElement()
        {
            using (var stream = new MemoryStream())
            {
                ConnectionGeneratedDocument.CreatePackage(stream);

                var connectionTestEntities = new ConnectionTestEntities(stream);

                connectionTestEntities.AddElement(stream, Output);
                connectionTestEntities.VerifyAddedElement(stream, Output);
            }
        }
    }
}
