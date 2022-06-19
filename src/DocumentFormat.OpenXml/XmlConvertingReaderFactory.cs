// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the XmlConvertingReaderFactory.
    /// </summary>
    internal static class XmlConvertingReaderFactory
    {
        // When the strictRelationshipFound flag is 'true', the XmlConvertingReader tries to search the incoming xml stream for any Strict namespace
        // that can be translated to Transitional. When the flag is 'false', the reader skips searching.
        public static XmlReader Create(Stream partStream, IOpenXmlNamespaceResolver resolver, XmlReaderSettings settings)
        {
            return Create(partStream, resolver, settings, true);
        }

        public static XmlReader Create(Stream partStream, IOpenXmlNamespaceResolver resolver, XmlReaderSettings settings, bool strictRelationshipFound)
        {
            var xmlReader = XmlReader.Create(partStream, settings);

            return new XmlConvertingReader(xmlReader, resolver, strictRelationshipFound);
        }

        public static XmlReader Create(TextReader textReader, IOpenXmlNamespaceResolver resolver, XmlReaderSettings settings)
        {
            var xmlReader = XmlReader.Create(textReader, settings);

            return new XmlConvertingReader(xmlReader, resolver, true);
        }

        public static XmlReader Create(TextReader textReader, IOpenXmlNamespaceResolver resolver)
        {
            var xmlReader = XmlReader.Create(textReader);

            return new XmlConvertingReader(xmlReader, resolver, true);
        }
    }
}
