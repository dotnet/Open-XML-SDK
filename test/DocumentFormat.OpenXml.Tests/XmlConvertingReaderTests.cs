// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
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
            Assert.Throws<ArgumentNullException>("baseReader", () => new XmlConvertingReader(null, null, true));
            Assert.Throws<ArgumentNullException>("baseReader", () => new XmlConvertingReader(null, null, false));
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void SetsProperties(bool strictRelationshipFound)
        {
            using (var baseReader = Substitute.For<XmlReader>())
            using (var reader = new AccessBaseReader(baseReader, strictRelationshipFound))
            {
                Assert.Same(baseReader, reader.BaseReader);
                Assert.Equal(strictRelationshipFound, reader.StrictRelationshipFound);
            }
        }

#if FEATURE_ABSTRACT_XML_CLOSE && !NETSTANDARD1_3_SDK
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DelegatesCallClose(bool strictRelationshipFound)
        {
            using (var baseReader = Substitute.For<XmlReader>())
            using (var reader = new XmlConvertingReader(baseReader, new OpenXmlNamespaceResolver(), strictRelationshipFound))
            {
                reader.Close();
                baseReader.Received(1).Close();
            }
        }
#endif

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DelegatesCallDispose(bool strictRelationshipFound)
        {
            using (var baseReader = Substitute.For<XmlReader>())
            using (var reader = new XmlConvertingReader(baseReader, new OpenXmlNamespaceResolver(), strictRelationshipFound))
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
        public void NamespaceUriIsHandled(string baseNamespaceUri, string expectedNamespaceUri, bool strictRelationshipFound)
        {
            using (var baseReader = Substitute.For<XmlReader>())
            using (var reader = new XmlConvertingReader(baseReader, new OpenXmlNamespaceResolver(), strictRelationshipFound))
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
        public void StrictTranslationAppliesToValue(string baseValue, string expectedValue, XmlNodeType nodeType, bool strictRelationshipFound)
        {
            using (var baseReader = Substitute.For<XmlReader>())
            using (var reader = new XmlConvertingReader(baseReader, new OpenXmlNamespaceResolver(), strictRelationshipFound))
            {
                baseReader.Value.Returns(baseValue);
                baseReader.NodeType.Returns(nodeType);

                Assert.Equal(expectedValue, reader.Value);
            }
        }

        private class AccessBaseReader : XmlConvertingReader
        {
            public AccessBaseReader(XmlReader baseReader, bool strictRelationshipFound)
                : base(baseReader, new OpenXmlNamespaceResolver(), strictRelationshipFound)
            {
            }

            public new XmlReader BaseReader => base.BaseReader;
        }
    }
}
