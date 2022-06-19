// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.IO;
using System.Xml;
using Xunit;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class TableLookTests
    {
        [InlineData("firstRow", "true", 0x0020)]
        [InlineData("firstRow", "1", 0x020)]
        [InlineData("firstRow", "false", 0x020)]
        [InlineData("lastRow", "true", 0x040)]
        [InlineData("lastRow", "1", 0x040)]
        [InlineData("lastRow", "false", 0x040)]
        [InlineData("firstColumn", "true", 0x080)]
        [InlineData("firstColumn", "1", 0x080)]
        [InlineData("firstColumn", "false", 0x080)]
        [InlineData("lastColumn", "true", 0x100)]
        [InlineData("lastColumn", "1", 0x100)]
        [InlineData("lastColumn", "false", 0x100)]
        [InlineData("noHBand", "true", 0x200)]
        [InlineData("noHBand", "1", 0x200)]
        [InlineData("noHBand", "false", 0x200)]
        [InlineData("noVBand", "true", 0x400)]
        [InlineData("noVBand", "1", 0x400)]
        [InlineData("noVBand", "false", 0x400)]
        [Theory]
        public void TableLookTranslationTests(string localName, string value, int newValue)
        {
            const int Padding = 4;
            const int Base = 16;

            var valueIsTrue = value == "true" || value == "1";
            var element = new TableLook();
            var xml = $"<w:{element.LocalName} xmlns:w=\"{element.NamespaceUri}\" w:{localName}=\"{value}\" />";

            element.OuterXml = xml;

            Assert.True(element.HasAttributes);
            var attribute = Assert.Single(element.GetAttributes());
            var expected = Convert.ToString(valueIsTrue ? newValue : 0, Base).PadLeft(Padding, '0');

            Assert.Equal("val", attribute.LocalName);
            Assert.Equal(expected, attribute.Value);

            // Validate bitwise actions on value
            for (int i = 0; i < 8; i++)
            {
                var offset = 1 << i;

                element.SetAttribute(new OpenXmlAttribute("w", "val", element.NamespaceUri, Convert.ToString(offset, Base)));

                using (var reader = XmlReader.Create(new StringReader(xml)))
                {
                    Assert.True(reader.Read());

                    using (var converting = new XmlConvertingReader(reader, new OpenXmlNamespaceResolver(), true))
                    {
                        element.LoadAttributes(converting);
                    }
                }

                var attribute2 = Assert.Single(element.GetAttributes());

                int GetExpectedValue()
                {
                    if (valueIsTrue)
                    {
                        return newValue | offset;
                    }

                    if (offset == newValue)
                    {
                        return 0;
                    }

                    return offset;
                }

                var expectedValue = GetExpectedValue();
                var expected2 = Convert.ToString(expectedValue, Base).PadLeft(Padding, '0');

                Assert.Equal("val", attribute2.LocalName);
                Assert.Equal(expected2, attribute2.Value, StringComparer.OrdinalIgnoreCase);
            }
        }
    }
}
