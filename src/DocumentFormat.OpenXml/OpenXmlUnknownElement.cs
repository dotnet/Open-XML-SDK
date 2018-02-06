// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents elements that are not defined in the Ecma Office Open XML.
    /// </summary>
    public class OpenXmlUnknownElement : OpenXmlCompositeElement
    {
        private string _namespaceUri;
        private string _tagName;
        private string _prefix;
        // int _attributeTotal;
        private string _text;

        /// <summary>
        /// OpenXmlUnknownElement constructor
        /// </summary>
        internal protected OpenXmlUnknownElement()
            : base()
        {
            this._tagName = string.Empty;
            this._prefix = string.Empty;
            this._namespaceUri = string.Empty;
        }

        //protected OpenXmlUnknownElement(string innerXml)
        //    : base(innerXml)
        //{
        //}

        /// <summary>
        /// Initializes a new instance of the OpenXmlUnknownElement class using
        /// the supplied element name.
        /// </summary>
        /// <param name="name">
        /// The element name.
        /// </param>
        public OpenXmlUnknownElement(string name)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            OpenXmlElement.SplitName(name, out this._prefix, out this._tagName);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlUnknownElement class using
        /// the supplied qualified element name and namespace URI.
        /// </summary>
        /// <param name="qualifiedName">The qualified element name.</param>
        /// <param name="namespaceUri">The namespace URI of the element.</param>
        public OpenXmlUnknownElement(string qualifiedName, string namespaceUri)
            : this( )
        {
            if (qualifiedName == null)
            {
                throw new ArgumentNullException(nameof(qualifiedName));
            }

            OpenXmlElement.SplitName(qualifiedName, out this._prefix, out this._tagName);

            this._namespaceUri = namespaceUri;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlUnknownElement class using
        /// the supplied prefix, local name, and namespace URI.
        /// </summary>
        /// <param name="prefix">The namespace prefix of the element.</param>
        /// <param name="localName">The local name of the element.</param>
        /// <param name="namespaceUri">The namespace URI of the element.</param>
        public OpenXmlUnknownElement(string prefix, string localName, string namespaceUri)
            : this( )
        {
            if (localName == null)
            {
                throw new ArgumentNullException(nameof(localName));
            }

            if (prefix == null)
            {
                prefix = string.Empty;
            }

            if (namespaceUri == null)
            {
                namespaceUri = string.Empty;
            }

            this._prefix = prefix;
            this._namespaceUri = namespaceUri;
            this._tagName = localName;
        }

        /// <summary>
        /// Creates a new OpenXmlUnknownElement class by using the outer XML.
        /// </summary>
        /// <param name="outerXml">The outer XML of the element.</param>
        /// <returns>A new OpenXmlUnknownElement class.</returns>
        public static OpenXmlUnknownElement CreateOpenXmlUnknownElement(string outerXml)
        {
            if (String.IsNullOrEmpty(outerXml))
            {
                throw new ArgumentNullException(nameof(outerXml));
            }

            TextReader stringReader = new StringReader(outerXml);
            using (XmlReader xmlReader = XmlConvertingReaderFactory.Create(stringReader, OpenXmlElementContext.CreateDefaultXmlReaderSettings()))
            {
                do // O15:#3024890, Skip the leading whitespaces. OpenXmUnknownlElement ignores the Whitespace NodeType.
                {
                    // Fix bug #484153.
                    if (xmlReader.Read() && xmlReader.NodeType == XmlNodeType.Element)
                    {
                        OpenXmlUnknownElement newElement = new OpenXmlUnknownElement(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI);
                        newElement.OuterXml = outerXml;
                        return newElement;
                    }
                } while (xmlReader.NodeType == XmlNodeType.Whitespace);

                // This method always expects an Element NodeType is passed, and there may be one or more preceding Whitespace NodeTypes before the Element.
                // If it's not the case, then throw an exception.
                throw new ArgumentException(ExceptionMessages.InvalidOuterXml, nameof(outerXml));
            }
        }

        /// <inheritdoc/>
        public override string LocalName => this._tagName;

        /// <inheritdoc/>
        public override string NamespaceUri => this._namespaceUri;

        /// <inheritdoc/>
        public override string Prefix => this._prefix;

        /// <inheritdoc/>
        public override XmlQualifiedName XmlQualifiedName => new XmlQualifiedName(this._tagName, this._namespaceUri);

        internal override byte NamespaceId => throw new InvalidOperationException();

        /// <inheritdoc/>
        internal override int ElementTypeId => ReservedElementTypeIds.OpenXmlUnknownElementId;

        /// <inheritdoc/>
        public override string InnerText
        {
            get
            {
                if (this.HasChildren)
                {
                    return base.InnerText;
                }
                else
                {
                    return this._text;
                }
            }
        }

        /// <summary>
        /// Gets the text of the unknown element, only if the unknown element
        /// has only one child that is a text node.
        /// </summary>
        public string Text
        {
            get
            {
                MakeSureParsed();
                return this._text;
            }
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep)
        {
            OpenXmlUnknownElement element = new OpenXmlUnknownElement(this._prefix, this._tagName, this._namespaceUri)
            {
                _text = this.Text
            };

            element.CopyAttributes(this);

            if(deep)
            {
                element.CopyChilden(this, deep);
            }

            return element;
        }

        /// <inheritdoc/>
        internal override void WriteContentTo(XmlWriter w)
        {
            if (this.HasChildren)
            {
                base.WriteContentTo(w);
            }
            else if (this.Text != null)
            {
                w.WriteString(this.Text);
            }
            else
            {
            }
        }

        /// <inheritdoc/>
        public override void WriteTo(XmlWriter xmlWriter)
        {
            if (xmlWriter == null)
            {
                throw new ArgumentNullException(nameof(xmlWriter));
            }

            if (this.XmlParsed)
            {
                xmlWriter.WriteStartElement(this.Prefix, this.LocalName, this.NamespaceUri);
                this.WriteAttributesTo(xmlWriter);
                this.WriteContentTo(xmlWriter);
                xmlWriter.WriteEndElement();
            }
            else
            {
                xmlWriter.WriteRaw(this.RawOuterXml);
            }
        }

        /// <inheritdoc/>
        internal override void LazyLoad(XmlReader xmlReader)
        {
            this._tagName = xmlReader.LocalName;
            this._prefix = xmlReader.Prefix;
            this._namespaceUri = xmlReader.NamespaceURI;

            this.RawOuterXml = xmlReader.ReadOuterXml();
        }

        /// <inheritdoc/>
        internal override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
        {
            if (String.IsNullOrEmpty(this._tagName))
            {
                this._tagName = xmlReader.LocalName;
                this._prefix = xmlReader.Prefix;
                this._namespaceUri = xmlReader.NamespaceURI;
            }
            else
            {
                Debug.Assert(String.Equals(this._tagName, xmlReader.LocalName));
                Debug.Assert(String.Equals(this._prefix, xmlReader.Prefix));
                Debug.Assert(String.Equals(this._namespaceUri, xmlReader.NamespaceURI));
            }

            // load children elements
            base.Populate(xmlReader, loadMode);

            if (this.FirstChild != null && this.FirstChild.NextSibling() == null)
            {
                // only one child
                OpenXmlMiscNode miscNode = this.FirstChild as OpenXmlMiscNode;
                if (miscNode != null)
                {
                    switch (miscNode.XmlNodeType)
                    {
                        case XmlNodeType.Text:
                        case XmlNodeType.CDATA:
                        case XmlNodeType.SignificantWhitespace:
                            this._text = miscNode.OuterXml; // is this OK?
                            this.RemoveChild(miscNode);
                            break;

                        case XmlNodeType.Whitespace: // O15:#3024890, OpenXmlUnknownElement ignores the Whitespace NodeType.
                        default:
                            break;
                    }
                }
            }
        }

        /// <inheritdoc/>
        internal override bool IsInVersion(FileFormatVersions version)
        {
            return false;
        }
    }
}
