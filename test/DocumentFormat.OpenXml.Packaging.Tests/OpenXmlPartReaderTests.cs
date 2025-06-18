// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Wordprocessing;
using NSubstitute;
using System;
using System.IO;
using System.Text;
using Xunit;

namespace DocumentFormat.OpenXml.Packaging.Tests;

public class OpenXmlPartReaderTests
{
    [Fact]
    public void ThrowsNull()
    {
        Assert.Throws<ArgumentNullException>(() => new OpenXmlPartReader(null!));
        Assert.Throws<ArgumentNullException>(() => new OpenXmlPartReader(null!, true));
    }

    [InlineData("<?xml version='1.0' encoding='UTF-8' standalone='yes'?><root/>", "UTF-8", true)]
    [InlineData("<?xml version='1.0' encoding='UTF-32' standalone='yes'?><root/>", "UTF-32", true)]
    [InlineData("<?xml version='1.0' standalone='yes'?><root/>", null, true)]
    [InlineData("<?xml version='1.0' standalone='no'?><root/>", null, false)]
    [InlineData("<?xml version='1.0'?><root/>", null, null)]
    [InlineData("<?xml version='1.0'?>", null, null)]
    [InlineData("<root/>", null, null)]
    [Theory]
    public void ExtractsInfoFromStream(string xml, string? encoding, bool? standalone)
    {
        var features = new FeatureCollection();
        var elementFactory = Substitute.For<IRootElementFeature>();
        var namespaceResolver = Substitute.For<IOpenXmlNamespaceResolver>();

        features.Set(elementFactory);
        features.Set(namespaceResolver);

        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));

        using (var partReader = new OpenXmlPartReader(stream, features, default))
        {
            Assert.Equal(encoding, partReader.Encoding);
            Assert.Equal(standalone, partReader.StandaloneXml);
        }

        // Ensure the part reader did not dispose the stream when it is disposed
        Assert.True(stream.CanRead);
    }

    [Fact]
    public void CreateElement()
    {
        // Arrange
        var stream = new MemoryStream();
        ExtendedPart extPart;
        const string xmlContent = """
            <?xml version='1.0' encoding='utf-8' standalone='yes'?>
            <a:root xmlns:a="http://www.tests.com/">
                <a:child>Test</a:child>
                <a:child>Test2</a:child>
            </a:root>
            """;
        const string nsUri = "http://www.tests.com/";
        const string prefix = "a";
        const string localName = "root";
        {
            using (var package = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook))
            {
                var workbook = package.AddWorkbookPart();
                extPart = workbook.AddExtendedPart(nsUri, "application/xml", ".xml");
                // Write some custom elements which are unknown to the OpenXmlPartReader
                using (var writer = new StreamWriter(extPart.GetStream(FileMode.Create)))
                {
                    writer.Write(xmlContent);
                }

                OpenXmlReader reader = OpenXmlReader.Create(extPart);

                // Assert
                while (reader.Read())
                {
                    Assert.Equal(prefix, reader.Prefix);
                    Assert.Equal(nsUri, reader.NamespaceUri);

                    if (!reader.LocalName.Equals(localName))
                    {
                        Assert.Equal("child", reader.LocalName);
                    }
                    else
                    {
                        Assert.Equal(localName, reader.LocalName);
                    }
                }
            }
        }
    }
}
