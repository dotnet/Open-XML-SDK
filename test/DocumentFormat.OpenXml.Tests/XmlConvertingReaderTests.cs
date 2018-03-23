// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using NSubstitute;
using System;
using System.Xml;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class XmlConvertingReaderTests
    {
        private const string TranslationalNamespaceExample1 = "http://purl.oclc.org/ooxml/descriptions/base";
        private const string TranslationalNamespaceExample1Result = "http://descriptions.openxmlformats.org/description/base";
        private const string ExtendedNamespace1 = "http://schemas.openxmlformats.org/wordprocessingml/2006/3/main";
        private const string ExtendedNamespace1Result = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";
        private const string RandomNamespace = "NotKnownNamespace";

        [Fact]
        public void ThrowsOnNullReader()
        {
            Assert.Throws<ArgumentNullException>("baseReader", () => new XmlConvertingReader(null, true));
            Assert.Throws<ArgumentNullException>("baseReader", () => new XmlConvertingReader(null, false));
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void SetsProperties(bool strictTranslation)
        {
            using (var baseReader = Substitute.For<XmlReader>())
            using (var reader = new AccessBaseReader(baseReader, strictTranslation))
            {
                Assert.Same(baseReader, reader.BaseReader);
                Assert.Equal(strictTranslation, reader.StrictTranslation);
            }
        }

#if FEATURE_ABSTRACT_XML_CLOSE
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DelegatesCallClose(bool strictTranslation)
        {
            using (var baseReader = Substitute.For<XmlReader>())
            using (var reader = new XmlConvertingReader(baseReader, strictTranslation))
            {
                reader.Close();
                baseReader.Received(1).Close();
            }
        }
#endif

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DelegatesCallDispose(bool strictTranslation)
        {
            using (var baseReader = Substitute.For<XmlReader>())
            using (var reader = new XmlConvertingReader(baseReader, strictTranslation))
            {
                ((IDisposable)reader).Dispose();
                ((IDisposable)baseReader).Received(1).Dispose();

#if !FEATURE_XML_DISPOSE_PROTECTED
                baseReader.ClearReceivedCalls();
                reader.Dispose();
                baseReader.Received(1).Dispose();
#endif
            }
        }

        [Theory]
        [InlineData(TranslationalNamespaceExample1, TranslationalNamespaceExample1Result, true)]
        [InlineData(RandomNamespace, RandomNamespace, true)]
        [InlineData(ExtendedNamespace1, ExtendedNamespace1, true)]
        [InlineData(TranslationalNamespaceExample1, TranslationalNamespaceExample1, false)]
        [InlineData(RandomNamespace, RandomNamespace, false)]
        [InlineData(ExtendedNamespace1, ExtendedNamespace1Result, false)]
        public void NamespaceUriIsHandled(string baseNamespaceUri, string expectedNamespaceUri, bool strictTranslation)
        {
            using (var baseReader = Substitute.For<XmlReader>())
            using (var reader = new XmlConvertingReader(baseReader, strictTranslation))
            {
                baseReader.NamespaceURI.Returns(baseNamespaceUri);

                Assert.Equal(expectedNamespaceUri, reader.NamespaceURI);
            }
        }

        [Theory]
        [InlineData(TranslationalNamespaceExample1, TranslationalNamespaceExample1Result, XmlNodeType.Attribute, true)]
        [InlineData(TranslationalNamespaceExample1, TranslationalNamespaceExample1, XmlNodeType.Element, true)]
        [InlineData(RandomNamespace, RandomNamespace, XmlNodeType.Attribute, true)]
        [InlineData(RandomNamespace, RandomNamespace, XmlNodeType.Element, true)]
        [InlineData(ExtendedNamespace1, ExtendedNamespace1, XmlNodeType.Attribute, true)]
        [InlineData(ExtendedNamespace1, ExtendedNamespace1, XmlNodeType.Element, true)]
        [InlineData(TranslationalNamespaceExample1, TranslationalNamespaceExample1, XmlNodeType.Attribute, false)]
        [InlineData(TranslationalNamespaceExample1, TranslationalNamespaceExample1, XmlNodeType.Element, false)]
        [InlineData(RandomNamespace, RandomNamespace, XmlNodeType.Attribute, false)]
        [InlineData(RandomNamespace, RandomNamespace, XmlNodeType.Element, false)]
        [InlineData(ExtendedNamespace1, ExtendedNamespace1Result, XmlNodeType.Attribute, false)]
        [InlineData(ExtendedNamespace1, ExtendedNamespace1, XmlNodeType.Element, false)]
        public void StrictTranslationAppliesToValue(string baseValue, string expectedValue, XmlNodeType nodeType, bool strictTranslation)
        {
            using (var baseReader = Substitute.For<XmlReader>())
            using (var reader = new XmlConvertingReader(baseReader, strictTranslation))
            {
                baseReader.Value.Returns(baseValue);
                baseReader.NodeType.Returns(nodeType);

                Assert.Equal(expectedValue, reader.Value);
            }
        }

        private class AccessBaseReader : XmlConvertingReader
        {
            public AccessBaseReader(XmlReader baseReader, bool strictTranslation)
                : base(baseReader, strictTranslation)
            {
            }

            public new XmlReader BaseReader => base.BaseReader;
        }
    }
}
