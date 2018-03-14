// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Tests.ContentControlClass;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.ContentControl
{
    public class ContentControlTest : OpenXmlTestBase
    {
        public ContentControlTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ContentControl01EditElement()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(stream);

                EditElement.EditContentControlElements(stream, Log);
                VerifyElement.VerifyContentControlElement(stream, Log);
            }
        }

        [Fact]
        public void ContentControl03DeleteElement()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.CreatePackage(stream);

                using (var package = WordprocessingDocument.Open(stream, true))
                {
                    foreach (var sdtElement in package.MainDocumentPart.Document.Descendants<SdtElement>().Reverse())
                    {
                        sdtElement.Remove();
                    }
                }

                using (var package = WordprocessingDocument.Open(stream, false))
                {
                    Assert.Empty(package.MainDocumentPart.Document.Descendants<SdtElement>());
                }
            }
        }
    }
}
