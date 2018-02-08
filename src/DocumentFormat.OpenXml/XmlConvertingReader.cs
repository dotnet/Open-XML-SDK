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

            this._strictTranslation = strictTranslation;
            this.BaseReader = baseReader;
        }

        /// <summary>
        /// Gets a value indicating whether strictTranslation is enabled.
        /// </summary>
        internal bool StrictTranslation => this._strictTranslation;

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
            this.BaseReader.Dispose();
#endif
        }

        /// <inheritdoc/>
        public override bool Read()
        {
            return this.BaseReader.Read();
        }

        /// <inheritdoc/>
        public override string GetAttribute(int index)
        {
            return this.BaseReader.GetAttribute(index);
        }

        /// <inheritdoc/>
        public override string GetAttribute(string name)
        {
            return this.BaseReader.GetAttribute(name);
        }

        /// <inheritdoc/>
        public override string GetAttribute(string localName, string namespaceURI)
        {
            return this.BaseReader.GetAttribute(localName, namespaceURI);
        }

        /// <inheritdoc/>
        public override string LookupNamespace(string prefix)
        {
            return this.BaseReader.LookupNamespace(prefix);
        }

        /// <inheritdoc/>
        public override void MoveToAttribute(int index)
        {
            this.BaseReader.MoveToAttribute(index);
        }

        /// <inheritdoc/>
        public override bool MoveToAttribute(string name)
        {
            return this.BaseReader.MoveToAttribute(name);
        }

        /// <inheritdoc/>
        public override bool MoveToAttribute(string localName, string namespaceURI)
        {
            return this.BaseReader.MoveToAttribute(localName, namespaceURI);
        }

        /// <inheritdoc/>
        public override bool MoveToElement()
        {
            return this.BaseReader.MoveToElement();
        }

        /// <inheritdoc/>
        public override bool MoveToFirstAttribute()
        {
            return this.BaseReader.MoveToFirstAttribute();
        }

        /// <inheritdoc/>
        public override bool MoveToNextAttribute()
        {
            return this.BaseReader.MoveToNextAttribute();
        }

        /// <inheritdoc/>
        public override bool ReadAttributeValue()
        {
            return this.BaseReader.ReadAttributeValue();
        }

        /// <inheritdoc/>
        public override void ResolveEntity()
        {
            this.BaseReader.ResolveEntity();
        }

        /// <inheritdoc/>
        public override int ReadValueChunk(char[] buffer, int index, int count)
        {
            return this.BaseReader.ReadValueChunk(buffer, index, count);
        }

        /// <inheritdoc/>
        public override int AttributeCount
        {
            get
            {
                return this.BaseReader.AttributeCount;
            }
        }

        /// <inheritdoc/>
        public override string BaseURI
        {
            get
            {
                return this.BaseReader.BaseURI;
            }
        }

        /// <inheritdoc/>
        public override bool CanReadBinaryContent
        {
            get
            {
                return this.BaseReader.CanReadBinaryContent;
            }
        }

        /// <inheritdoc/>
        public override bool CanReadValueChunk
        {
            get
            {
                return this.BaseReader.CanReadValueChunk;
            }
        }

        /// <inheritdoc/>
        public override bool CanResolveEntity
        {
            get
            {
                return this.BaseReader.CanResolveEntity;
            }
        }

        /// <inheritdoc/>
        public override int Depth
        {
            get
            {
                return this.BaseReader.Depth;
            }
        }

        /// <inheritdoc/>
        public override bool EOF
        {
            get
            {
                return this.BaseReader.EOF;
            }
        }

        /// <inheritdoc/>
        public override bool HasValue
        {
            get
            {
                return this.BaseReader.HasValue;
            }
        }

        /// <inheritdoc/>
        public override bool IsDefault
        {
            get
            {
                return this.BaseReader.IsDefault;
            }
        }

        /// <inheritdoc/>
        public override bool IsEmptyElement
        {
            get
            {
                return this.BaseReader.IsEmptyElement;
            }
        }

        /// <inheritdoc/>
        public override string this[int index]
        {
            get
            {
                return this.BaseReader[index];
            }
        }

        /// <inheritdoc/>
        public override string this[string name]
        {
            get
            {
                return this.BaseReader[name];
            }
        }

        /// <inheritdoc/>
        public override string this[string name, string namespaceURI]
        {
            get
            {
                return this.BaseReader[name, namespaceURI];
            }
        }

        /// <inheritdoc/>
        public override string LocalName
        {
            get
            {
                return this.BaseReader.LocalName;
            }
        }

        /// <inheritdoc/>
        public override string Name
        {
            get
            {
                return this.BaseReader.Name;
            }
        }

        /// <inheritdoc/>
        public override string NamespaceURI
        {
            get
            {
                string uri = this.BaseReader.NamespaceURI;
                string translatedNamespace;
                bool found;

                if (this._strictTranslation)
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
                return this.BaseReader.NameTable;
            }
        }

        /// <inheritdoc/>
        public override XmlNodeType NodeType
        {
            get
            {
                return this.BaseReader.NodeType;
            }
        }

        /// <inheritdoc/>
        public override string Prefix
        {
            get
            {
                return this.BaseReader.Prefix;
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
                return this.BaseReader.ReadState;
            }
        }

        /// <inheritdoc/>
        public override string Value
        {
            get
            {
                string textValue = this.BaseReader.Value;

                if (this.BaseReader.NodeType == XmlNodeType.Attribute)
                {
                    bool found;
                    string translatedNamespace;

                    if (this._strictTranslation)
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
                return this.BaseReader.XmlLang;
            }
        }

        /// <inheritdoc/>
        public override XmlSpace XmlSpace
        {
            get
            {
                return this.BaseReader.XmlSpace;
            }
        }
    }
}
