// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Diagnostics;
using System.IO;
using System.Globalization;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents an Open XML non element node (i.e. PT, Comments, Entity, Notation, XmlDeclaration).
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    public class OpenXmlMiscNode : OpenXmlElement
    {
        const string strCDataSectionName = "#cdata-section";
        const string strCommentName = "#comment";
        const string strTextName = "#text";
        const string strNonSignificantWhitespaceName = "#whitespace";
        const string strSignificantWhitespaceName = "#significant-whitespace";
        const string strXmlDeclaration = "xml-declaration";

        XmlNodeType _nodeType;

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
                    throw new ArgumentOutOfRangeException("nodeType");
            }

            this.XmlNodeType = nodeType;
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
            if ( String.IsNullOrEmpty( outerXml ) )
            {
                throw new ArgumentNullException("outerXml");
            }
            
            // check the out XML match the nodeType
            using (StringReader stringReader = new StringReader(outerXml))
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.DtdProcessing = DtdProcessing.Prohibit; // set true explicitly for serucity fix
                using (XmlReader xmlReader = XmlConvertingReaderFactory.Create(stringReader, settings))
                {
                    xmlReader.Read();
                
                    if (xmlReader.NodeType != nodeType)
                    {
                        throw new ArgumentException(ExceptionMessages.InvalidOuterXmlForMiscNode);
                    }

                    xmlReader.Close();
                }
            }

            this.RawOuterXml = outerXml;
        }

        /// <summary>
        /// Specifies the type of XML node. 
        /// </summary>
        public XmlNodeType XmlNodeType
        {
            get { return _nodeType; }
            internal set { _nodeType = value; }
        }

        /// <summary>
        /// The type ID of the element. 
        /// </summary>
        internal override int ElementTypeId
        {
            get { return ReservedElementTypeIds.OpenXmlMiscNodeId; }
        }

        internal override byte NamespaceId
        {
            get
            {
                throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the current element has any child
        /// elements.
        /// </summary>
        public override bool HasChildren
        {
            get { return false; }
        }


        /// <summary>
        /// When overridden in a derived class, gets the local name of the node.
        /// </summary>
        public override string LocalName
        {
            get
            {
                string localName = string.Empty;
                switch (this._nodeType)
                {                       
                    case XmlNodeType.CDATA:
                        localName = strCDataSectionName;
                        break;

                    case XmlNodeType.Comment:
                        localName = strCommentName;
                        break;

                    case XmlNodeType.ProcessingInstruction:
                        using (StringReader stringReader = new StringReader(this.OuterXml))
                        {
                            XmlReaderSettings settings = new XmlReaderSettings();
                            settings.DtdProcessing = DtdProcessing.Prohibit; // set true explicitly for security fix
                            using (XmlReader xmlReader = XmlConvertingReaderFactory.Create(stringReader, settings))
                            {
                                xmlReader.Read();
                                localName = xmlReader.LocalName;
                                xmlReader.Close();
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

        /// <summary>
        /// Gets the namespace URI of the current node.
        /// </summary>
        public override string NamespaceUri
        {
            get
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the namespace prefix of the current node.
        /// </summary>
        public override string Prefix
        {
            get
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// When overridden in a derived class, gets the qualified name of the node.
        /// </summary>
        public override XmlQualifiedName XmlQualifiedName
        {
            get
            {
                throw new InvalidOperationException();
            }
        }

        
        /// <summary>
        /// Gets or sets the markup that represents only the child nodes of the
        /// current node.
        /// </summary>
        public override string InnerXml
        {
            get
            {
                return String.Empty;
            }
            set
            {
                throw new InvalidOperationException(ExceptionMessages.InnerXmlCannotBeSet);
            }
        }

        /// <summary>
        /// When overridden in a derived class, creates a duplicate of the node. 
        /// </summary>
        /// <param name="deep">
        /// Specify true to recursively clone the subtree under the specified
        /// node; false to clone only the node itself.
        /// </param>
        /// <returns>The cloned node. </returns>
        public override OpenXmlElement CloneNode(bool deep)
        {
            OpenXmlMiscNode element = new OpenXmlMiscNode(this.XmlNodeType);

            element.OuterXml = this.OuterXml;

            return element;
        }

        /// <summary>
        /// Removes all child elements.
        /// </summary>
        public override void RemoveAllChildren()
        {
        }

        /// <summary>
        /// Saves all the children of the node to the specified XmlWriter. 
        /// </summary>
        /// <param name="w">The XmlWriter to which you want to save. </param>
        internal override void WriteContentTo(XmlWriter w)
        {
            throw new NotImplementedException(ExceptionMessages.NonImplemented);
        }

        /// <summary>
        /// Saves the current node to the specified XmlWriter. 
        /// </summary>
        /// <param name="xmlWriter">
        /// The XmlWriter at which to save the current node.
        /// </param>
        public override void WriteTo(XmlWriter xmlWriter)
        {
            if (xmlWriter == null)
            {
                throw new ArgumentNullException("xmlWriter");
            }

            // write out the raw xml
            xmlWriter.WriteRaw(this.RawOuterXml);
        }

        internal override void LazyLoad(XmlReader xmlReader)
        {
            this.Populate(xmlReader, OpenXmlLoadMode.Full);
        }

        internal override void ParseXml()
        {
            // do nothing 
        }

        /// <summary>
        /// Holds the XmlReader.Value on loading.
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
                    // this.RawOuterXml = String.Format("<?xml version='1.0'?>");
                    this.Value = xmlReader.Value; // version='1.0'
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
                    this.Value = xmlReader.Value;
                    this.RawOuterXml = xmlReader.Value;
                    break;

                case XmlNodeType.CDATA:
                    this.Value = xmlReader.Value;
                    this.RawOuterXml = String.Format(CultureInfo.InvariantCulture, "<![CDATA[{0}]]>", xmlReader.Value);
                    break;

                case XmlNodeType.SignificantWhitespace:
                    this.Value = xmlReader.Value;
                    this.RawOuterXml = xmlReader.Value;
                    break;

                case XmlNodeType.Whitespace:
                    break; // O15:#3024890, OpenXmlMiscNode ignores the Whitespace NodeType.

                case XmlNodeType.ProcessingInstruction:
                    this.Value = xmlReader.Value;
                    this.RawOuterXml = String.Format(CultureInfo.InvariantCulture, "<?{0} {1}?>", xmlReader.Name, xmlReader.Value);
                    break;

                case XmlNodeType.Comment:
                    this.Value = xmlReader.Value;
                    this.RawOuterXml = String.Format(CultureInfo.InvariantCulture, "<!--{0}-->", xmlReader.Value);
                    break;

                case XmlNodeType.Document:
                    Debug.Assert(xmlReader.NodeType != XmlNodeType.Document);
                    break;

                case XmlNodeType.DocumentType:
                    // this.RawOuterXml = String.Format(CultureInfo.InvariantCulture, "<!DOCTYPE {0} [{1}]", xmlReader.Name, xmlReader.Value);
                    Debug.Assert(xmlReader.NodeType != XmlNodeType.DocumentType);
                    break;

                case XmlNodeType.EntityReference:
                    Debug.Assert(xmlReader.NodeType != XmlNodeType.EntityReference);
                    this.RawOuterXml = xmlReader.Name;
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

        /// <summary>
        /// Do nothing for MiscNode.
        /// Override this method because the MC loading algorithm try to call this method in parent's Populate. 
        /// While the OpenXmlElement.LoadAttributes() will cause the reader be moved which should not.
        /// </summary>
        /// <param name="xmlReader"></param>
        internal override void LoadAttributes(XmlReader xmlReader)
        {
            return;
        }

        internal override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
        {
            this.LoadOuterXml(xmlReader);
            xmlReader.Read();

            // this.RawOuterXml = xmlReader.ReadOuterXml();
        }

        /// <summary>
        /// Whether this element is available in a specific version of Office Application.
        /// For OpenXmlMiscNode, always return true, no matter what the version is.
        /// </summary>
        /// <param name="version">The Office file format version.</param>
        /// <returns>Returns true if the element is defined in the specified version.</returns>
        internal override bool IsInVersion(FileFormatVersions version)
        {
            return true;
        }

        internal static OpenXmlMiscNode CreateFromText(string text)
        {
            Debug.Assert(text != null);

            var newMiscNode = new OpenXmlMiscNode(XmlNodeType.Text);
            newMiscNode.Value = text;
            newMiscNode.RawOuterXml = text;
            return newMiscNode;
        }

        internal static OpenXmlMiscNode CreateFromCdata(string value)
        {
            Debug.Assert(value != null);

            var newMiscNode = new OpenXmlMiscNode(XmlNodeType.CDATA);
            newMiscNode.Value = value;
            newMiscNode.RawOuterXml = String.Format(CultureInfo.InvariantCulture, "<![CDATA[{0}]]>", value); ;
            return newMiscNode;
        }

        internal static OpenXmlMiscNode CreateFromSignificantWhitespace(string whitespace)
        {
            Debug.Assert(whitespace != null);

            var newMiscNode = new OpenXmlMiscNode(XmlNodeType.SignificantWhitespace);
            newMiscNode.Value = whitespace;
            newMiscNode.RawOuterXml = whitespace;
            return newMiscNode;
        }
    }
}
