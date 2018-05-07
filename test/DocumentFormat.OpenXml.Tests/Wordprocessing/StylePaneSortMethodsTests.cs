// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class StylePaneSortMethodsTests
    {
        [InlineData("val", "name", "0000")]
        [InlineData("val", "priority", "0001")]
        [InlineData("val", "default", "0002")]
        [InlineData("val", "font", "0003")]
        [InlineData("val", "basedOn", "0004")]
        [InlineData("val", "type", "0005")]
        [Theory]
        public void StylePaneSortMethodAttributeTranslationXmlTests(string localName, string value, string newValue)
        {
            var element = new StylePaneSortMethods();
            var xml = $"<w:tab xmlns:w=\"{element.NamespaceUri}\" w:{localName}=\"{value}\" />";
            element.OuterXml = xml;

            Assert.True(element.HasAttributes);
            var attribute = Assert.Single(element.GetAttributes());

            Assert.Equal(localName, attribute.LocalName);
            Assert.Equal(newValue, attribute.Value);

            Assert.True(element.HasAttributes);
            var attribute2 = Assert.Single(element.GetAttributes());

            Assert.Equal(localName, attribute2.LocalName);
            Assert.Equal(newValue, attribute2.Value);
        }
    }
}
