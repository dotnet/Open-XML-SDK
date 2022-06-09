// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class TabStopTests
    {
        [InlineData("val", "start", "left")]
        [InlineData("val", "end", "right")]
        [InlineData("val", "other", "other")]
        [Theory]
        public void TabStopAttributeTranslationTest(string localName, string value, string newValue)
        {
            var element = new TabStop();
            var xml = $"<w:tab xmlns:w=\"{element.NamespaceUri}\" w:{localName}=\"{value}\" />";

            element.OuterXml = xml;

            Assert.True(element.HasAttributes);
            var attribute = Assert.Single(element.GetAttributes());

            Assert.Equal(localName, attribute.LocalName);
            Assert.Equal(newValue, attribute.Value);
        }
    }
}
