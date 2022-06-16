// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.IO;
using System.Xml;
using Xunit;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class ConditionalFormatStyleTests
    {
        [InlineData("firstRow", "true", 1 << 11)]
        [InlineData("firstRow", "1", 1 << 11)]
        [InlineData("firstRow", "false", 1 << 11)]

        [InlineData("lastRow", "true", 1 << 10)]
        [InlineData("lastRow", "1", 1 << 10)]
        [InlineData("lastRow", "false", 1 << 10)]

        [InlineData("firstColumn", "true", 1 << 9)]
        [InlineData("firstColumn", "1", 1 << 9)]
        [InlineData("firstColumn", "false", 1 << 9)]

        [InlineData("lastColumn", "true", 1 << 8)]
        [InlineData("lastColumn", "1", 1 << 8)]
        [InlineData("lastColumn", "false", 1 << 8)]

        [InlineData("oddVBand", "true", 1 << 7)]
        [InlineData("oddVBand", "1", 1 << 7)]
        [InlineData("oddVBand", "false", 1 << 7)]

        [InlineData("evenVBand", "true", 1 << 6)]
        [InlineData("evenVBand", "1", 1 << 6)]
        [InlineData("evenVBand", "false", 1 << 6)]

        [InlineData("oddHBand", "true", 1 << 5)]
        [InlineData("oddHBand", "1", 1 << 5)]
        [InlineData("oddHBand", "false", 1 << 5)]

        [InlineData("evenHBand", "true", 1 << 4)]
        [InlineData("evenHBand", "1", 1 << 4)]
        [InlineData("evenHBand", "false", 1 << 4)]

        [InlineData("firstRowLastColumn", "true", 1 << 3)]
        [InlineData("firstRowLastColumn", "1", 1 << 3)]
        [InlineData("firstRowLastColumn", "false", 1 << 3)]

        [InlineData("firstRowFirstColumn", "true", 1 << 2)]
        [InlineData("firstRowFirstColumn", "1", 1 << 2)]
        [InlineData("firstRowFirstColumn", "false", 1 << 2)]

        [InlineData("lastRowFirstColumn", "true", 1 << 1)]
        [InlineData("lastRowFirstColumn", "1", 1 << 1)]
        [InlineData("lastRowFirstColumn", "false", 1 << 1)]

        [InlineData("lastRowLastColumn", "true", 1)]
        [InlineData("lastRowLastColumn", "1", 1)]
        [InlineData("lastRowLastColumn", "false", 1)]
        [Theory]
        public void ConditionalFormatStyleTranslationTests(string localName, string value, int newValue)
        {
            const int Padding = 12;
            const int Base = 2;

            var valueIsTrue = value == "true" || value == "1";

            var element = new ConditionalFormatStyle();
            var xml = $"<w:{element.LocalName} xmlns:w=\"{element.NamespaceUri}\" w:{localName}=\"{value}\" />";

            element.OuterXml = xml;

            Assert.True(element.HasAttributes);
            var attribute = Assert.Single(element.GetAttributes());

            var expected = valueIsTrue ? Convert.ToString(newValue, Base).PadLeft(Padding, '0') : new string('0', Padding);

            Assert.Equal("val", attribute.LocalName);
            Assert.Equal(expected, attribute.Value);

            // Validate bitwise actions on value
            for (int i = 0; i < 12; i++)
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
