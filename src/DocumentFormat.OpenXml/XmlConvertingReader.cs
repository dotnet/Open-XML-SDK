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
        // The xmlReader obtained from the Package class.
        protected XmlReader BaseReader { get; set; }

        private bool _strictTranslation { get; set; }

        /// <summary>
        /// XmlConvertingReader
        /// </summary>
        /// <param name="baseReader">XmlReader</param>
        /// <param name="strictTranslation">bool</param>
        /// <returns></returns>
        internal XmlConvertingReader(XmlReader baseReader, bool strictTranslation)
        {
            if (baseReader == null)
            {
                throw new ArgumentNullException(nameof(baseReader));
            }

            _strictTranslation = strictTranslation;
            BaseReader = baseReader;
        }

        /// <summary>
        /// Gets a value indicating whether strictTranslation is enabled.
        /// </summary>
        internal bool StrictTranslation => _strictTranslation;

#if FEATURE_CLOSE
        /// <inheritdoc/>
        public override void Close()
        {
            this.BaseReader.Close();
        }
#endif

        /// <inheritdoc/>
        protected override void Dispose(bool disposing)
        {
#if FEATURE_CLOSE
            if (this.ReadState != ReadState.Closed)
            {
                this.Close();
            }
#endif

#if !FEATURE_XML_DISPOSE_PROTECTED
            BaseReader.Dispose();
#endif
        }

        /// <inheritdoc/>
        public override bool Read()
        {
            return BaseReader.Read();
        }

        /// <inheritdoc/>
        public override string GetAttribute(int index)
        {
            return BaseReader.GetAttribute(index);
        }

        /// <inheritdoc/>
        public override string GetAttribute(string name)
        {
            return BaseReader.GetAttribute(name);
        }

        /// <inheritdoc/>
        public override string GetAttribute(string localName, string namespaceURI)
        {
            return BaseReader.GetAttribute(localName, namespaceURI);
        }

        /// <inheritdoc/>
        public override string LookupNamespace(string prefix)
        {
            return BaseReader.LookupNamespace(prefix);
        }

        /// <inheritdoc/>
        public override void MoveToAttribute(int index)
        {
            BaseReader.MoveToAttribute(index);
        }

        /// <inheritdoc/>
        public override bool MoveToAttribute(string name)
        {
            return BaseReader.MoveToAttribute(name);
        }

        /// <inheritdoc/>
        public override bool MoveToAttribute(string localName, string namespaceURI)
        {
            return BaseReader.MoveToAttribute(localName, namespaceURI);
        }

        /// <inheritdoc/>
        public override bool MoveToElement()
        {
            return BaseReader.MoveToElement();
        }

        /// <inheritdoc/>
        public override bool MoveToFirstAttribute()
        {
            return BaseReader.MoveToFirstAttribute();
        }

        /// <inheritdoc/>
        public override bool MoveToNextAttribute()
        {
            return BaseReader.MoveToNextAttribute();
        }

        /// <inheritdoc/>
        public override bool ReadAttributeValue()
        {
            return BaseReader.ReadAttributeValue();
        }

        /// <inheritdoc/>
        public override void ResolveEntity()
        {
            BaseReader.ResolveEntity();
        }

        /// <inheritdoc/>
        public override int ReadValueChunk(char[] buffer, int index, int count)
        {
            return BaseReader.ReadValueChunk(buffer, index, count);
        }

        /// <inheritdoc/>
        public override int AttributeCount
        {
            get
            {
                return BaseReader.AttributeCount;
            }
        }

        /// <inheritdoc/>
        public override string BaseURI
        {
            get
            {
                return BaseReader.BaseURI;
            }
        }

        /// <inheritdoc/>
        public override bool CanReadBinaryContent
        {
            get
            {
                return BaseReader.CanReadBinaryContent;
            }
        }

        /// <inheritdoc/>
        public override bool CanReadValueChunk
        {
            get
            {
                return BaseReader.CanReadValueChunk;
            }
        }

        /// <inheritdoc/>
        public override bool CanResolveEntity
        {
            get
            {
                return BaseReader.CanResolveEntity;
            }
        }

        /// <inheritdoc/>
        public override int Depth
        {
            get
            {
                return BaseReader.Depth;
            }
        }

        /// <inheritdoc/>
        public override bool EOF
        {
            get
            {
                return BaseReader.EOF;
            }
        }

        /// <inheritdoc/>
        public override bool HasValue
        {
            get
            {
                return BaseReader.HasValue;
            }
        }

        /// <inheritdoc/>
        public override bool IsDefault
        {
            get
            {
                return BaseReader.IsDefault;
            }
        }

        /// <inheritdoc/>
        public override bool IsEmptyElement
        {
            get
            {
                return BaseReader.IsEmptyElement;
            }
        }

        /// <inheritdoc/>
        public override string this[int index]
        {
            get
            {
                return BaseReader[index];
            }
        }

        /// <inheritdoc/>
        public override string this[string name]
        {
            get
            {
                return BaseReader[name];
            }
        }

        /// <inheritdoc/>
        public override string this[string name, string namespaceURI]
        {
            get
            {
                return BaseReader[name, namespaceURI];
            }
        }

        /// <inheritdoc/>
        public override string LocalName
        {
            get
            {
                return BaseReader.LocalName;
            }
        }

        /// <inheritdoc/>
        public override string Name
        {
            get
            {
                return BaseReader.Name;
            }
        }

        /// <inheritdoc/>
        public override string NamespaceURI
        {
            get
            {
                string uri = BaseReader.NamespaceURI;
                string translatedNamespace;
                bool found;

                if (_strictTranslation)
                {
                    found = NamespaceIdMap.TryGetTransitionalNamespace(uri, out translatedNamespace);
                }
                else
                {
                    found = NamespaceIdMap.TryGetExtendedNamespace(uri, out translatedNamespace);
                }

                if (found)
                {
                    uri = translatedNamespace;
                }

                return uri;
            }
        }

        /// <inheritdoc/>
        public override XmlNameTable NameTable
        {
            get
            {
                return BaseReader.NameTable;
            }
        }

        /// <inheritdoc/>
        public override XmlNodeType NodeType
        {
            get
            {
                return BaseReader.NodeType;
            }
        }

        /// <inheritdoc/>
        public override string Prefix
        {
            get
            {
                return BaseReader.Prefix;
            }
        }

#if FEATURE_XML_QUOTECHAR
        /// <inheritdoc/>
        public override char QuoteChar
        {
            get
            {
                return this.BaseReader.QuoteChar;
            }
        }
#endif

        /// <inheritdoc/>
        public override ReadState ReadState
        {
            get
            {
                return BaseReader.ReadState;
            }
        }

        /// <inheritdoc/>
        public override string Value
        {
            get
            {
                string textValue = BaseReader.Value;

                if (BaseReader.NodeType == XmlNodeType.Attribute)
                {
                    bool found;
                    string translatedNamespace;

                    if (_strictTranslation)
                    {
                        found = NamespaceIdMap.TryGetTransitionalNamespace(textValue, out translatedNamespace);
                    }
                    else
                    {
                        found = NamespaceIdMap.TryGetExtendedNamespace(textValue, out translatedNamespace);
                    }

                    if (found)
                    {
                        textValue = translatedNamespace;
                    }
                }

                return textValue;
            }
        }

        /// <inheritdoc/>
        public override string XmlLang
        {
            get
            {
                return BaseReader.XmlLang;
            }
        }

        /// <inheritdoc/>
        public override XmlSpace XmlSpace
        {
            get
            {
                return BaseReader.XmlSpace;
            }
        }
    }
}
