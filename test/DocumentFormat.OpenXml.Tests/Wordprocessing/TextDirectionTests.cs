// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Xunit;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class TextDirectionTests
    {
        [InlineData("val", "lr", "btLr")]
        [InlineData("val", "tb", "lrTb")]
        [InlineData("val", "tbV", "lrTbV")]
        [InlineData("val", "lrV", "tbLrV")]
        [InlineData("val", "rl", "tbRl")]
        [InlineData("val", "rlV", "tbRlV")]
        [Theory]
        public void TextDirectionTranslationTest(string localName, string value, string newValue)
        {
            var element = new TextDirection();
            var xml = $"<w:tab xmlns:w=\"{element.NamespaceUri}\" w:{localName}=\"{value}\" />";

            element.OuterXml = xml;

            Assert.True(element.HasAttributes);
            var attribute = Assert.Single(element.GetAttributes());

            Assert.Equal(localName, attribute.LocalName);
            Assert.Equal(newValue, attribute.Value);
        }
    }
}
