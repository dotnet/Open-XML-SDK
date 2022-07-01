// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents elements that are not defined in the Office Open XML ECMA standard.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.None)]
    public class OpenXmlUnknownElement : OpenXmlCompositeElement
    {
        private string _namespaceUri;
        private string _tagName;
        private string _prefix;
        private string _text;

        /// <summary>
        /// OpenXmlUnknownElement constructor
        /// </summary>
        internal protected OpenXmlUnknownElement()
            : base()
        {
            _tagName = string.Empty;
            _prefix = string.Empty;
            _namespaceUri = string.Empty;
            _text = string.Empty;
        }

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
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            var parsed = PrefixName.Parse(name);

            _prefix = parsed.Prefix;
            _tagName = parsed.Name;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlUnknownElement class using
        /// the supplied qualified element name and namespace URI.
        /// </summary>
        /// <param name="qualifiedName">The qualified element name.</param>
        /// <param name="namespaceUri">The namespace URI of the element.</param>
        public OpenXmlUnknownElement(string qualifiedName, string namespaceUri)
            : this()
        {
            if (qualifiedName is null)
            {
                throw new ArgumentNullException(nameof(qualifiedName));
            }

            var parsed = PrefixName.Parse(qualifiedName);

            _prefix = parsed.Prefix;
            _tagName = parsed.Name;
            _namespaceUri = namespaceUri;
        }

        internal OpenXmlUnknownElement(in OpenXmlQualifiedName qname, string prefix)
            : this(prefix, qname.Name, qname.Namespace.Uri)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlUnknownElement class using
        /// the supplied prefix, local name, and namespace URI.
        /// </summary>
        /// <param name="prefix">The namespace prefix of the element.</param>
        /// <param name="localName">The local name of the element.</param>
        /// <param name="namespaceUri">The namespace URI of the element.</param>
        public OpenXmlUnknownElement(string prefix, string localName, string namespaceUri)
            : this()
        {
            if (localName is null)
            {
                throw new ArgumentNullException(nameof(localName));
            }

            if (prefix is null)
            {
                prefix = string.Empty;
            }

            if (namespaceUri is null)
            {
                namespaceUri = string.Empty;
            }

            _prefix = prefix;
            _namespaceUri = namespaceUri;
            _tagName = localName;
        }

        /// <summary>
        /// Creates a new OpenXmlUnknownElement class by using the outer XML.
        /// </summary>
        /// <param name="outerXml">The outer XML of the element.</param>
        /// <returns>A new OpenXmlUnknownElement class.</returns>
        public static OpenXmlUnknownElement CreateOpenXmlUnknownElement(string outerXml)
        {
            if (string.IsNullOrEmpty(outerXml))
            {
                throw new ArgumentNullException(nameof(outerXml));
            }

            TextReader stringReader = new StringReader(outerXml);
            using (XmlReader xmlReader = XmlConvertingReaderFactory.Create(stringReader, FeatureCollection.TypedOrDefault.GetNamespaceResolver(), OpenXmlElementContext.CreateDefaultXmlReaderSettings()))
            {
                // Skip the leading whitespace as OpenXmUnknownlElement ignores the Whitespace NodeType.
                do
                {
                    if (xmlReader.Read() && xmlReader.NodeType == XmlNodeType.Element)
                    {
                        return new OpenXmlUnknownElement(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI)
                        {
                            OuterXml = outerXml,
                        };
                    }
                }
                while (xmlReader.NodeType == XmlNodeType.Whitespace);

                // This method always expects an Element NodeType is passed, and there may be one or more preceding Whitespace NodeTypes before the Element.
                // If it's not the case, then throw an exception.
                throw new ArgumentException(ExceptionMessages.InvalidOuterXml, nameof(outerXml));
            }
        }

        /// <inheritdoc/>
        public override string LocalName => _tagName;

        /// <inheritdoc/>
        public override string NamespaceUri => _namespaceUri;

        /// <inheritdoc/>
        public override string Prefix => _prefix;

        /// <inheritdoc/>
        public override XmlQualifiedName XmlQualifiedName => new XmlQualifiedName(_tagName, _namespaceUri);

        /// <inheritdoc/>
        public override string InnerText
        {
            get
            {
                if (HasChildren)
                {
                    return base.InnerText;
                }
                else
                {
                    return _text;
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
                return _text;
            }
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep)
        {
            var element = new OpenXmlUnknownElement(_prefix, _tagName, _namespaceUri)
            {
                _text = Text,
            };

            element.CopyAttributes(this);

            if (deep)
            {
                element.CopyChildren(this, deep);
            }

            return element;
        }

        /// <inheritdoc/>
        internal override void WriteContentTo(XmlWriter w)
        {
            if (HasChildren)
            {
                base.WriteContentTo(w);
            }
            else if (Text is not null)
            {
                w.WriteString(Text);
            }
            else
            {
            }
        }

        /// <inheritdoc/>
        public override void WriteTo(XmlWriter xmlWriter)
        {
            if (xmlWriter is null)
            {
                throw new ArgumentNullException(nameof(xmlWriter));
            }

            if (XmlParsed)
            {
                xmlWriter.WriteStartElement(Prefix, LocalName, NamespaceUri);
                WriteAttributesTo(xmlWriter);
                WriteContentTo(xmlWriter);
                xmlWriter.WriteEndElement();
            }
            else
            {
                xmlWriter.WriteRaw(RawOuterXml);
            }
        }

        /// <inheritdoc/>
        private protected override void LazyLoad(XmlReader xmlReader)
        {
            _tagName = xmlReader.LocalName;
            _prefix = xmlReader.Prefix;
            _namespaceUri = xmlReader.NamespaceURI;

            RawOuterXml = xmlReader.ReadOuterXml();
        }

        /// <inheritdoc/>
        private protected override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
        {
            if (string.IsNullOrEmpty(_tagName))
            {
                _tagName = xmlReader.LocalName;
                _prefix = xmlReader.Prefix;
                _namespaceUri = xmlReader.NamespaceURI;
            }
            else
            {
                Debug.Assert(string.Equals(_tagName, xmlReader.LocalName, StringComparison.Ordinal));
                Debug.Assert(string.Equals(_prefix, xmlReader.Prefix, StringComparison.Ordinal));
                Debug.Assert(string.Equals(_namespaceUri, xmlReader.NamespaceURI, StringComparison.Ordinal));
            }

            // load children elements
            base.Populate(xmlReader, loadMode);

            if (FirstChild is not null && FirstChild.NextSibling() is null)
            {
                // only one child
                if (FirstChild is OpenXmlMiscNode miscNode)
                {
                    switch (miscNode.XmlNodeType)
                    {
                        case XmlNodeType.Text:
                        case XmlNodeType.CDATA:
                        case XmlNodeType.SignificantWhitespace:
                            _text = miscNode.OuterXml; // is this OK?
                            RemoveChild(miscNode);
                            break;

                        case XmlNodeType.Whitespace: // O15:#3024890, OpenXmlUnknownElement ignores the Whitespace NodeType.
                        default:
                            break;
                    }
                }
            }
        }
    }
}
