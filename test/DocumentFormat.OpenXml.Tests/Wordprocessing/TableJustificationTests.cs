// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Xunit;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class TableJustificationTests
    {
        [InlineData("val", "start", "left")]
        [InlineData("val", "end", "right")]
        [InlineData("val", "other", "other")]
        [Theory]
        public void TableJustificationAttributeTranslationTest(string localName, string value, string newValue)
        {
            var element = new TableJustification();
            var xml = $"<w:tab xmlns:w=\"{element.NamespaceUri}\" w:{localName}=\"{value}\" />";

            element.OuterXml = xml;

            Assert.True(element.HasAttributes);
            var attribute = Assert.Single(element.GetAttributes());

            Assert.Equal(localName, attribute.LocalName);
            Assert.Equal(newValue, attribute.Value);
        }
    }
}
