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
        /// Return true if strictTranslation is enabled.
        /// </summary>
        internal bool StrictTranslation
        {
            get { return this._strictTranslation; }
        }

#if FEATURE_CLOSE
        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override void Close()
        {
            this.BaseReader.Close();
        }
#endif

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
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

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override bool Read()
        {
            return this.BaseReader.Read();
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override string GetAttribute(int index)
        {
            return this.BaseReader.GetAttribute(index);
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override string GetAttribute(string name)
        {
            return this.BaseReader.GetAttribute(name);
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override string GetAttribute(string localName, string namespaceURI)
        {
            return this.BaseReader.GetAttribute(localName, namespaceURI);
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override string LookupNamespace(string prefix)
        {
            return this.BaseReader.LookupNamespace(prefix);
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override void MoveToAttribute(int index)
        {
            this.BaseReader.MoveToAttribute(index);
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override bool MoveToAttribute(string name)
        {
            return this.BaseReader.MoveToAttribute(name);
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override bool MoveToAttribute(string localName, string namespaceURI)
        {
            return this.BaseReader.MoveToAttribute(localName, namespaceURI);
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override bool MoveToElement()
        {
            return this.BaseReader.MoveToElement();
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override bool MoveToFirstAttribute()
        {
            return this.BaseReader.MoveToFirstAttribute();
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override bool MoveToNextAttribute()
        {
            return this.BaseReader.MoveToNextAttribute();
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override bool ReadAttributeValue()
        {
            return this.BaseReader.ReadAttributeValue();
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override void ResolveEntity()
        {
            this.BaseReader.ResolveEntity();
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override int ReadValueChunk(char[] buffer, int index, int count)
        {
            return this.BaseReader.ReadValueChunk(buffer, index, count);
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override int AttributeCount
        {
            get
            {
                return this.BaseReader.AttributeCount;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string BaseURI
        {
            get
            {
                return this.BaseReader.BaseURI;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override bool CanReadBinaryContent
        {
            get
            {
                return this.BaseReader.CanReadBinaryContent;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override bool CanReadValueChunk
        {
            get
            {
                return this.BaseReader.CanReadValueChunk;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override bool CanResolveEntity
        {
            get
            {
                return this.BaseReader.CanResolveEntity;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override int Depth
        {
            get
            {
                return this.BaseReader.Depth;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override bool EOF
        {
            get
            {
                return this.BaseReader.EOF;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override bool HasValue
        {
            get
            {
                return this.BaseReader.HasValue;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override bool IsDefault
        {
            get
            {
                return this.BaseReader.IsDefault;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override bool IsEmptyElement
        {
            get
            {
                return this.BaseReader.IsEmptyElement;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string this[int index]
        {
            get
            {
                return this.BaseReader[index];
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string this[string name]
        {
            get
            {
                return this.BaseReader[name];
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string this[string name, string namespaceURI]
        {
            get
            {
                return this.BaseReader[name, namespaceURI];
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string LocalName
        {
            get
            {
                return this.BaseReader.LocalName;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string Name
        {
            get
            {
                return this.BaseReader.Name;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
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

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override XmlNameTable NameTable
        {
            get
            {
                return this.BaseReader.NameTable;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override XmlNodeType NodeType
        {
            get
            {
                return this.BaseReader.NodeType;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string Prefix
        {
            get
            {
                return this.BaseReader.Prefix;
            }
        }

#if FEATURE_XML_QUOTECHAR
        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override char QuoteChar
        {
            get
            {
                return this.BaseReader.QuoteChar;
            }
        }
#endif

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override ReadState ReadState
        {
            get
            {
                return this.BaseReader.ReadState;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
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

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string XmlLang
        {
            get
            {
                return this.BaseReader.XmlLang;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override XmlSpace XmlSpace
        {
            get
            {
                return this.BaseReader.XmlSpace;
            }
        }
    }
}
