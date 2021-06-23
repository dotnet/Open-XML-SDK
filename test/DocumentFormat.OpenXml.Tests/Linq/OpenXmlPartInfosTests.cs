// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Xml.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.Linq
{
    public class OpenXmlPartInfosTests
    {
        [Fact]
        public void Constructor_Default_Success()
        {
            var openXmlPartInfos = new OpenXmlPartInfos();

            OpenXmlPartInfo partInfo = openXmlPartInfos[typeof(MainDocumentPart)];
            Assert.Equal(typeof(MainDocumentPart), partInfo.OpenXmlPartType);
            Assert.Equal(typeof(Document), partInfo.OpenXmlPartRootElementType);
            Assert.Equal(W.document, partInfo.RootName);
            Assert.Equal("w", partInfo.RootNamespacePrefix);

            // We can't compare the XAttribute instances directly.
            var xmlnsW = new XAttribute(XNamespace.Xmlns + "w", W.w);
            Assert.Equal(xmlnsW.Name, partInfo.RootNamespaceAttribute.Name);
            Assert.Equal(xmlnsW.Value, partInfo.RootNamespaceAttribute.Value);
            Assert.Equal(xmlnsW.IsNamespaceDeclaration, partInfo.RootNamespaceAttribute.IsNamespaceDeclaration);
        }
    }
}
