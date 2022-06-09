// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class IndentationTests
    {
        [InlineData("left", "something", "start")]
        [InlineData("left", "other", "start")]
        [InlineData("leftChars", "something", "startChars")]
        [InlineData("leftChars", "other", "startChars")]
        [InlineData("right", "something", "end")]
        [InlineData("right", "other", "end")]
        [InlineData("rightChars", "something", "endChars")]
        [InlineData("rightChars", "other", "endChars")]
        [Theory]
        public void IndendationAttributeTranslationTest(string localName, string value, string newLocalName)
        {
            var element = new Indentation();
            var xml = $"<w:ind xmlns:w=\"{element.NamespaceUri}\" w:{localName}=\"{value}\" />";

            element.OuterXml = xml;

            Assert.True(element.HasAttributes);
            var attribute = Assert.Single(element.GetAttributes());

            Assert.Equal(newLocalName, attribute.LocalName);
            Assert.Equal(value, attribute.Value);
        }
    }
}
