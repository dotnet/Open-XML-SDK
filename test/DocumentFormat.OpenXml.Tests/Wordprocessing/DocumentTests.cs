// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;
using System.Xml;
using Xunit;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class DocumentTests
    {
        [InlineData("conformance", "strict", true)]
        [InlineData("conformance", "anything", false)]
        [InlineData("conformance", "", false)]
        [InlineData("anything", "something", false)]
        [Theory]
        public void DocumentAttributeTranslationTest(string localName, string value, bool remove)
        {
            var doc = new Document();
            var xml = $"<w:document xmlns:w=\"{doc.NamespaceUri}\" {localName}=\"{value}\" />";

            doc.OuterXml = xml;

            if (remove)
            {
                Assert.False(doc.HasAttributes);
                Assert.Empty(doc.GetAttributes());
            }
            else
            {
                Assert.True(doc.HasAttributes);
                var attribute = Assert.Single(doc.GetAttributes());

                Assert.Equal(localName, attribute.LocalName);
                Assert.Equal(value, attribute.Value);
            }
        }
    }
}
