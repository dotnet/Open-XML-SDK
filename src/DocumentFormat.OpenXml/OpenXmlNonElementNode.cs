// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Xml;

using static System.FormattableString;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents an Open XML non element node (i.e. PT, Comments, Entity, Notation, XmlDeclaration).
    /// </summary>
    public class OpenXmlMiscNode : OpenXmlElement
    {
        private const string strCDataSectionName = "#cdata-section";
        private const string strCommentName = "#comment";
        private const string strTextName = "#text";
        private const string strNonSignificantWhitespaceName = "#whitespace";
        private const string strSignificantWhitespaceName = "#significant-whitespace";
        private const string strXmlDeclaration = "xml-declaration";

        private XmlNodeType _nodeType;

        /// <summary>
        /// Initializes a new instance of the OpenXmlMiscNode class using the
        /// supplied XmlNodeType value.
        /// </summary>
        /// <param name="nodeType">
        /// The XmlNodeType value.
        /// </param>
        public OpenXmlMiscNode(XmlNodeType nodeType)
            : base()
        {
            switch (nodeType)
            {
                case XmlNodeType.Element:
                case XmlNodeType.Attribute:

                case XmlNodeType.Document:
                case XmlNodeType.DocumentFragment:
                case XmlNodeType.DocumentType: // not allowed when DtdProcessing = DtdProcessing.Prohibit
                case XmlNodeType.EndElement:
                case XmlNodeType.EndEntity:
                case XmlNodeType.Entity: // not allowed when DtdProcessing = DtdProcessing.Prohibit
                case XmlNodeType.EntityReference:
                case XmlNodeType.Notation: // not allowed when DtdProcessing = DtdProcessing.Prohibit
                case XmlNodeType.None:
                    throw new ArgumentOutOfRangeException(nameof(nodeType));
            }

            XmlNodeType = nodeType;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlMiscNode class using the
        /// supplied XmlNodeType and outer XML values.
        /// </summary>
        /// <param name="nodeType">The XmlNodeType value.</param>
        /// <param name="outerXml">The outer XML of the element.</param>
        public OpenXmlMiscNode(XmlNodeType nodeType, string outerXml)
            : this(nodeType)
        {
            if (string.IsNullOrEmpty(outerXml))
            {
                throw new ArgumentNullException(nameof(outerXml));
            }

            // check the out XML match the nodeType
            using (StringReader stringReader = new StringReader(outerXml))
            {
                XmlReaderSettings settings = new XmlReaderSettings
                {
#if FEATURE_XML_PROHIBIT_DTD
                    ProhibitDtd = true, // set true explicitly for security fix
#else
                    DtdProcessing = DtdProcessing.Prohibit, // set to prohibit explicitly for security fix
#endif
                };

                using (XmlReader xmlReader = XmlConvertingReaderFactory.Create(stringReader, settings))
                {
                    xmlReader.Read();

                    if (xmlReader.NodeType != nodeType)
                    {
                        throw new ArgumentException(ExceptionMessages.InvalidOuterXmlForMiscNode);
                    }
                }
            }

            RawOuterXml = outerXml;
        }

        /// <summary>
        /// Gets the type of XML node.
        /// </summary>
        public XmlNodeType XmlNodeType
        {
            get { return _nodeType; }
            internal set { _nodeType = value; }
        }

        /// <inheritdoc/>
        internal override int ElementTypeId
        {
            get { return ReservedElementTypeIds.OpenXmlMiscNodeId; }
        }

        /// <inheritdoc/>
        internal override byte NamespaceId
        {
            get
            {
                throw new InvalidOperationException();
            }
        }

        /// <inheritdoc/>
        public override bool HasChildren
        {
            get { return false; }
        }

        /// <inheritdoc/>
        public override string LocalName
        {
            get
            {
                string localName = string.Empty;
                switch (_nodeType)
                {
                    case XmlNodeType.CDATA:
                        localName = strCDataSectionName;
                        break;

                    case XmlNodeType.Comment:
                        localName = strCommentName;
                        break;

                    case XmlNodeType.ProcessingInstruction:
                        using (StringReader stringReader = new StringReader(OuterXml))
                        {
                            XmlReaderSettings settings = new XmlReaderSettings
                            {
#if FEATURE_XML_PROHIBIT_DTD
                                ProhibitDtd = true,
#else
                                DtdProcessing = DtdProcessing.Prohibit,
#endif
                            };

                            using (XmlReader xmlReader = XmlConvertingReaderFactory.Create(stringReader, settings))
                            {
                                xmlReader.Read();
                                localName = xmlReader.LocalName;
                            }
                        }

                        break;

                    case XmlNodeType.Text:
                        localName = strTextName;
                        break;

                    case XmlNodeType.Whitespace:
                        localName = strNonSignificantWhitespaceName;
                        break;

                    case XmlNodeType.SignificantWhitespace:
                        localName = strSignificantWhitespaceName;
                        break;

                    case XmlNodeType.XmlDeclaration:
                        localName = strXmlDeclaration;
                        break;

                    case XmlNodeType.Element:
                    case XmlNodeType.Attribute:

                    case XmlNodeType.Document:
                    case XmlNodeType.DocumentFragment:
                    case XmlNodeType.DocumentType: // not allowed when DtdProcessing = DtdProcessing.Prohibit
                    case XmlNodeType.EndElement:
                    case XmlNodeType.EndEntity:
                    case XmlNodeType.Entity: // not allowed when DtdProcessing = DtdProcessing.Prohibit
                    case XmlNodeType.EntityReference:
                    case XmlNodeType.Notation: // not allowed when DtdProcessing = DtdProcessing.Prohibit
                    case XmlNodeType.None:
                        Debug.Assert(false);
                        break;
                }

                return localName;
            }
        }

        /// <inheritdoc/>
        public override string NamespaceUri
        {
            get
            {
                return string.Empty;
            }
        }

        /// <inheritdoc/>
        public override string Prefix
        {
            get
            {
                return string.Empty;
            }
        }

        /// <inheritdoc/>
        public override XmlQualifiedName XmlQualifiedName
        {
            get
            {
                throw new InvalidOperationException();
            }
        }

        /// <inheritdoc/>
        public override string InnerXml
        {
            get
            {
                return string.Empty;
            }

            set
            {
                throw new InvalidOperationException(ExceptionMessages.InnerXmlCannotBeSet);
            }
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep)
        {
            return new OpenXmlMiscNode(XmlNodeType)
            {
                OuterXml = OuterXml,
            };
        }

        /// <inheritdoc/>
        public override void RemoveAllChildren()
        {
        }

        /// <inheritdoc/>
        internal override void WriteContentTo(XmlWriter w)
        {
            throw new NotImplementedException(ExceptionMessages.NonImplemented);
        }

        /// <inheritdoc/>
        public override void WriteTo(XmlWriter xmlWriter)
        {
            if (xmlWriter == null)
            {
                throw new ArgumentNullException(nameof(xmlWriter));
            }

            // write out the raw xml
            xmlWriter.WriteRaw(RawOuterXml);
        }

        /// <inheritdoc/>
        internal override void LazyLoad(XmlReader xmlReader)
        {
            Populate(xmlReader, OpenXmlLoadMode.Full);
        }

        /// <inheritdoc/>
        private protected override void ParseXml()
        {
        }

        /// <summary>
        /// Gets the XmlReader.Value on loading.
        /// </summary>
        internal string Value
        {
            get;
            private set;
        }

        /// <summary>
        /// Load the out xml from the XmlReader.
        /// </summary>
        /// <param name="xmlReader"></param>
        /// <remarks>The XmlReader not be moved.</remarks>
        internal void LoadOuterXml(System.Xml.XmlReader xmlReader)
        {
            switch (xmlReader.NodeType)
            {
                case XmlNodeType.None:
                    Debug.Assert(xmlReader.NodeType != XmlNodeType.None);
                    break;

                case XmlNodeType.XmlDeclaration:
                    Debug.Assert(xmlReader.NodeType != XmlNodeType.XmlDeclaration);

                    Value = xmlReader.Value; // version='1.0'
                    break;

                case XmlNodeType.Element:
                    Debug.Assert(xmlReader.NodeType != XmlNodeType.Element);
                    break;

                case XmlNodeType.EndElement:
                    Debug.Assert(xmlReader.NodeType != XmlNodeType.EndElement);
                    break;

                case XmlNodeType.Notation:
                    Debug.Assert(xmlReader.NodeType != XmlNodeType.Notation);
                    break;

                case XmlNodeType.Attribute:
                    Debug.Assert(xmlReader.NodeType != XmlNodeType.Attribute);
                    break;

                case XmlNodeType.Text:
                    Value = xmlReader.Value;
                    RawOuterXml = xmlReader.Value;
                    break;

                case XmlNodeType.CDATA:
                    Value = xmlReader.Value;
                    RawOuterXml = Invariant($"<![CDATA[{xmlReader.Value}]]>");
                    break;

                case XmlNodeType.SignificantWhitespace:
                    Value = xmlReader.Value;
                    RawOuterXml = xmlReader.Value;
                    break;

                case XmlNodeType.Whitespace:
                    break; // O15:#3024890, OpenXmlMiscNode ignores the Whitespace NodeType.

                case XmlNodeType.ProcessingInstruction:
                    Value = xmlReader.Value;
                    RawOuterXml = Invariant($"<?{xmlReader.Name} {xmlReader.Value}?>");
                    break;

                case XmlNodeType.Comment:
                    Value = xmlReader.Value;
                    RawOuterXml = Invariant($"<!--{xmlReader.Value}-->");
                    break;

                case XmlNodeType.Document:
                    Debug.Assert(xmlReader.NodeType != XmlNodeType.Document);
                    break;

                case XmlNodeType.DocumentType:
                    Debug.Assert(xmlReader.NodeType != XmlNodeType.DocumentType);
                    break;

                case XmlNodeType.EntityReference:
                    Debug.Assert(xmlReader.NodeType != XmlNodeType.EntityReference);
                    RawOuterXml = xmlReader.Name;
                    break;

                case XmlNodeType.Entity:
                    Debug.Assert(xmlReader.NodeType != XmlNodeType.Entity);
                    break;

                case XmlNodeType.DocumentFragment:
                case XmlNodeType.EndEntity:
                default:
                    Debug.Assert(false, xmlReader.NodeType.ToString());
                    break;
            }
        }

        /// <inheritdoc/>
        internal override void LoadAttributes(XmlReader xmlReader)
        {
            return;
        }

        /// <inheritdoc/>
        internal override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
        {
            LoadOuterXml(xmlReader);
            xmlReader.Read();
        }

        internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

        internal static OpenXmlMiscNode CreateFromText(string text)
        {
            Debug.Assert(text != null);

            return new OpenXmlMiscNode(XmlNodeType.Text)
            {
                Value = text,
                RawOuterXml = text,
            };
        }

        internal static OpenXmlMiscNode CreateFromCdata(string value)
        {
            Debug.Assert(value != null);

            return new OpenXmlMiscNode(XmlNodeType.CDATA)
            {
                Value = value,
                RawOuterXml = Invariant($"<![CDATA[{value}]]>"),
            };
        }

        internal static OpenXmlMiscNode CreateFromSignificantWhitespace(string whitespace)
        {
            Debug.Assert(whitespace != null);

            return new OpenXmlMiscNode(XmlNodeType.SignificantWhitespace)
            {
                Value = whitespace,
                RawOuterXml = whitespace,
            };
        }
    }
}
