// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the XmlConvertingReaderFactory.
    /// </summary>
    internal static class XmlConvertingReaderFactory
    {
        // When the strictTranslation flag is 'true', the XmlConvertingReader tries to search the incoming xml stream for any Strict namespace
        // that can be translated to Transitional. When the flag is 'false', the reader skips searching.
        public static XmlReader Create(Stream partStream, XmlReaderSettings settings)
        {
            return Create(partStream, settings, true);
        }

        public static XmlReader Create(Stream partStream, XmlReaderSettings settings, bool strictTranslation)
        {
            XmlReader xmlReader = XmlReader.Create(partStream, settings);

            return new XmlConvertingReader(xmlReader, strictTranslation);
        }

        public static XmlReader Create(TextReader textReader, XmlReaderSettings settings)
        {
            return Create(textReader, settings, true);
        }

        public static XmlReader Create(TextReader textReader, XmlReaderSettings settings, bool strictTranslation)
        {
            XmlReader xmlReader = XmlReader.Create(textReader, settings);

            return new XmlConvertingReader(xmlReader, strictTranslation);
        }

        public static XmlReader Create(TextReader textReader)
        {
            return Create(textReader, true);
        }

        public static XmlReader Create(TextReader textReader, bool strictTranslation)
        {
            XmlReader xmlReader = XmlReader.Create(textReader);

            return new XmlConvertingReader(xmlReader, strictTranslation);
        }
    }
}
