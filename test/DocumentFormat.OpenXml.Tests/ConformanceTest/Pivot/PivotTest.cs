// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.PivotClass;
using System.IO;
using Xunit;
using Xunit.Abstractions;

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

                connectionTestEntities.EditElement(stream, Log);
                connectionTestEntities.VerifyElement(stream, Log);
            }
        }

        [Fact]
        public void PivotConnection03DeleteElement()
        {
            using (var stream = new MemoryStream())
            {
                ConnectionGeneratedDocument.CreatePackage(stream);

                var connectionTestEntities = new ConnectionTestEntities(stream);

                connectionTestEntities.DeleteElement(stream, Log);
                connectionTestEntities.VerifyDeletedElement(stream, Log);
            }
        }

        [Fact]
        public void PivotConnection03AddElement()
        {
            using (var stream = new MemoryStream())
            {
                ConnectionGeneratedDocument.CreatePackage(stream);

                var connectionTestEntities = new ConnectionTestEntities(stream);

                connectionTestEntities.AddElement(stream, Log);
                connectionTestEntities.VerifyAddedElement(stream, Log);
            }
        }
    }
}
