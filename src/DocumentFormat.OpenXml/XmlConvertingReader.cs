// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the XmlConvertingReader - This XmlReader tries to replace the Strict namespaces with equivalent Transitional namespaces.
    /// </summary>
    internal class XmlConvertingReader : XmlReader
    {
        /// <summary>
        /// Creates an instance of <see cref="XmlConvertingReader"/>
        /// </summary>
        /// <param name="baseReader">XmlReader</param>
        /// <param name="strictTranslation">bool</param>
        public XmlConvertingReader(XmlReader baseReader, bool strictTranslation)
        {
            BaseReader = baseReader ?? throw new ArgumentNullException(nameof(baseReader));
            StrictTranslation = strictTranslation;
        }

        /// <summary>
        /// Gets the inner <see cref="XmlReader"/>
        /// </summary>
        protected XmlReader BaseReader { get; }

        /// <summary>
        /// Gets a value indicating whether strict translation is enabled.
        /// </summary>
        public bool StrictTranslation { get; }

#if FEATURE_ABSTRACT_XML_CLOSE
        /// <inheritdoc/>
        public override void Close() => BaseReader.Close();
#endif

        /// <inheritdoc/>
        protected override void Dispose(bool disposing)
        {
#if FEATURE_XML_DISPOSE_PROTECTED
            (BaseReader as IDisposable)?.Dispose();
#else
            BaseReader.Dispose();
#endif
        }

        /// <inheritdoc/>
        public override bool Read() => BaseReader.Read();

        /// <inheritdoc/>
        public override string GetAttribute(int index) => BaseReader.GetAttribute(index);

        /// <inheritdoc/>
        public override string GetAttribute(string name) => BaseReader.GetAttribute(name);

        /// <inheritdoc/>
        public override string GetAttribute(string localName, string namespaceURI) => BaseReader.GetAttribute(localName, namespaceURI);

        /// <inheritdoc/>
        public override string LookupNamespace(string prefix) => BaseReader.LookupNamespace(prefix);

        /// <inheritdoc/>
        public override void MoveToAttribute(int index) => BaseReader.MoveToAttribute(index);

        /// <inheritdoc/>
        public override bool MoveToAttribute(string name) => BaseReader.MoveToAttribute(name);

        /// <inheritdoc/>
        public override bool MoveToAttribute(string localName, string namespaceURI) => BaseReader.MoveToAttribute(localName, namespaceURI);

        /// <inheritdoc/>
        public override bool MoveToElement() => BaseReader.MoveToElement();

        /// <inheritdoc/>
        public override bool MoveToFirstAttribute() => BaseReader.MoveToFirstAttribute();

        /// <inheritdoc/>
        public override bool MoveToNextAttribute() => BaseReader.MoveToNextAttribute();

        /// <inheritdoc/>
        public override bool ReadAttributeValue() => BaseReader.ReadAttributeValue();

        /// <inheritdoc/>
        public override void ResolveEntity() => BaseReader.ResolveEntity();

        /// <inheritdoc/>
        public override int ReadValueChunk(char[] buffer, int index, int count) => BaseReader.ReadValueChunk(buffer, index, count);

        /// <inheritdoc/>
        public override int AttributeCount => BaseReader.AttributeCount;

        /// <inheritdoc/>
        public override string BaseURI => BaseReader.BaseURI;

        /// <inheritdoc/>
        public override bool CanReadBinaryContent => BaseReader.CanReadBinaryContent;

        /// <inheritdoc/>
        public override bool CanReadValueChunk => BaseReader.CanReadValueChunk;

        /// <inheritdoc/>
        public override bool CanResolveEntity => BaseReader.CanResolveEntity;

        /// <inheritdoc/>
        public override int Depth => BaseReader.Depth;

        /// <inheritdoc/>
        public override bool EOF => BaseReader.EOF;

        /// <inheritdoc/>
        public override bool HasValue => BaseReader.HasValue;

        /// <inheritdoc/>
        public override bool IsDefault => BaseReader.IsDefault;

        /// <inheritdoc/>
        public override bool IsEmptyElement => BaseReader.IsEmptyElement;

        /// <inheritdoc/>
        public override string this[int index] => BaseReader[index];

        /// <inheritdoc/>
        public override string this[string name] => BaseReader[name];

        /// <inheritdoc/>
        public override string this[string name, string namespaceURI] => BaseReader[name, namespaceURI];

        /// <inheritdoc/>
        public override string LocalName => BaseReader.LocalName;

        /// <inheritdoc/>
        public override string Name => BaseReader.Name;

        /// <inheritdoc/>
        public override string NamespaceURI => ApplyStrictTranslation(BaseReader.NamespaceURI);

        /// <inheritdoc/>
        public override XmlNameTable NameTable => BaseReader.NameTable;

        /// <inheritdoc/>
        public override XmlNodeType NodeType => BaseReader.NodeType;

        /// <inheritdoc/>
        public override string Prefix => BaseReader.Prefix;

#if FEATURE_XML_QUOTECHAR
        /// <inheritdoc/>
        public override char QuoteChar => BaseReader.QuoteChar;
#endif

        /// <inheritdoc/>
        public override ReadState ReadState => BaseReader.ReadState;

        /// <inheritdoc/>
        public override string Value => BaseReader.NodeType == XmlNodeType.Attribute ? ApplyStrictTranslation(BaseReader.Value) : BaseReader.Value;

        /// <inheritdoc/>
        public override string XmlLang => BaseReader.XmlLang;

        /// <inheritdoc/>
        public override XmlSpace XmlSpace => BaseReader.XmlSpace;

        private string ApplyStrictTranslation(string uri)
        {
            if (StrictTranslation)
            {
                if (NamespaceIdMap.TryGetTransitionalNamespace(uri, out var transitionalNamespace))
                {
                    return transitionalNamespace;
                }
            }
            else if (NamespaceIdMap.TryGetExtendedNamespace(uri, out var extendedNamespace))
            {
                return extendedNamespace;
            }

            return uri;
        }
    }
}
