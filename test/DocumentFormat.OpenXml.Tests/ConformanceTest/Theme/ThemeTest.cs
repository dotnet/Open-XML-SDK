// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Tests.ThemeClass;
using System.IO;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.Theme
{
    public class ThemeTest : OpenXmlTestBase
    {
        public ThemeTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void Theme01EditAttribute()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(stream);

                // Adding ThemeId
                using (PresentationDocument doc = PresentationDocument.Open(stream, true))
                {
                    doc.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId = new StringValue("TEST");
                }

                TestEntities testEntities = new TestEntities();
                testEntities.EditAttribute(stream, Output);
                testEntities.VerifyAttribute(stream, Output);
            }
        }

        [Fact]
        public void Theme03DeleteAttribute()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(stream);

                TestEntities testEntities = new TestEntities();
                testEntities.DeletAttribute(stream, Output);
                testEntities.VerifyDeletedAttribute(stream, Output);

                testEntities.AddAttribute(stream, Output);
                testEntities.VerifyAddedAttribute(stream, Output);
            }
        }
    }
}
