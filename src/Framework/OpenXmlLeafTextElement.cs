// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Globalization;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the base class from which leaf elements that have text are derived.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [DebuggerDisplay("{Text}")]
    public abstract class OpenXmlLeafTextElement : OpenXmlLeafElement
    {
        string _rawInnerText;

        /// <summary>
        /// Initializes a new instance of the OpenXmlLeafTextElement class.
        /// </summary>
        protected OpenXmlLeafTextElement() : base( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlLeafTextElement class using the supplied text.  
        /// </summary>
        /// <param name="text"></param>
        protected OpenXmlLeafTextElement(string text)
            : base()
        {
            this._rawInnerText = text;
        }

        internal string RawInnerText
        {
            get { return _rawInnerText; }
            set { _rawInnerText = value; }
        }

        /// <summary>
        /// Convert the text into value (depends on the type defined in the schema).
        /// </summary>
        /// <param name="text">The text to convert.</param>
        /// <returns>An OpenXmlSimpleType value.</returns>
        /// <remarks>All generated classes that are derived from this class will generate this method.</remarks>
        internal virtual OpenXmlSimpleType InnerTextToValue(string text)
        {
            return null;
        }

        /// <summary>
        /// Gets a value that indicates whether the current element has any child
        ///  elements.
        /// </summary>
        public override bool HasChildren
        {
            get { return false; }
        }

        /// <summary>
        /// Gets or sets the concatenated values of the element and all of its
        ///  child elements.
        /// </summary>
        public override string InnerText
        {
            get
            {
                MakeSureParsed();
                if (this.RawInnerText != null)
                {
                    return _rawInnerText;
                }
                else
                {
                    return string.Empty;
                } 
            }
            protected set
            {
                MakeSureParsed();
                this.RawInnerText = value;
                this.ShadowElement = null; // clear the other stuffs.
            }
        }

        /// <summary>
        /// Gets or sets the markup that only represents child elements of the
        ///  current element.
        /// </summary>
        public override string InnerXml
        {
            get
            {
                if (this.ShadowElement != null)
                {
                    return this.ShadowElement.InnerXml;
                }
                else
                {
                    StringWriter w = new StringWriter(CultureInfo.InvariantCulture);
                    XmlDOMTextWriter writer2 = new XmlDOMTextWriter(w);
                    try
                    {
                        this.WriteContentTo(writer2);
                    }
                    finally
                    {
                        writer2.Close();
                    }
                    return w.ToString();
                }
            }

            set
            {
                // only accept null or empty string.
                if (string.IsNullOrEmpty(value))
                {
                    this.ShadowElement = null;
                }
                else
                {
                    throw new InvalidOperationException(ExceptionMessages.LeafElementInnerXmlCannotBeSet);
                }
            }
        }

        /// <summary>
        /// Gets or sets the text of the current element.
        /// </summary>
        public virtual string Text
        {
            get { return this.InnerText; }
            set 
            {
                this.InnerText = value;
            }
        }

        /// <summary>
        /// Saves all the child elements of the current element to the specified XmlWriter. 
        /// </summary>
        /// <param name="w">The XmlWriter to which to save the elements. </param>
        internal override void WriteContentTo(XmlWriter w)
        {
            // Write the loaded inner xml if there are any
            if (this.ShadowElement != null)
            {
                this.ShadowElement.WriteContentTo(w);
            }
            else
            {
                // nothing to write
                w.WriteString(this.Text);
            }
        }

        /// <summary>
        /// Removes all child elements of the current element.
        /// </summary>
        public override void RemoveAllChildren()
        {
            this.RawInnerText = null;
        }

        //internal override void Load(XmlReader xmlReader)
        //{
        //    LoadAttributes(xmlReader);
        //    this.Text = xmlReader.ReadElementString();
        //}
        internal override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
        {
            LoadAttributes(xmlReader);

            if (!xmlReader.IsEmptyElement)
            {   // only when element is not empty (not  <element />).

                xmlReader.Read(); // read this element 

                this.RawInnerText = string.Empty;

                int unwanted = 0;
                int textNodePosition = -1; // the position of the text in the ShadowElement's children when there are other unexpected node.
                XmlNodeType textNodeType = XmlNodeType.Text;

                if (xmlReader.NodeType == XmlNodeType.EndElement)
                {
                    Debug.Assert(xmlReader.LocalName.Equals(this.LocalName));
                }
                else
                {
                    while (!xmlReader.EOF)
                    {
                        if (xmlReader.NodeType == XmlNodeType.EndElement)
                        {
                            Debug.Assert(xmlReader.LocalName.Equals(this.LocalName));
                            break;
                        }
                        else if (string.IsNullOrEmpty(this.RawInnerText) &&
                                     (xmlReader.NodeType == XmlNodeType.Text ||
                                     xmlReader.NodeType == XmlNodeType.CDATA ||
                                     xmlReader.NodeType == XmlNodeType.SignificantWhitespace ||
                                     xmlReader.NodeType == XmlNodeType.Whitespace /* O15:#3024890 */))
                        {
                            // text or CDATA
                            // scenario: normal text element <Application>Microsoft Office Word</Application>
                            // scenario: <w:t>This is <![CDATA[Xml Example <tag>text</tag>.]]> 1</w:t>

                            // only load text when no text is loaded, 
                            // for case "<foo/>Text1<bar/>Text2", only load "Text1", very rare case

                            this.RawInnerText = xmlReader.Value;
                            textNodePosition = unwanted;
                            textNodeType = xmlReader.NodeType;

                            xmlReader.Read();
                        }
                        else
                        {
                            Debug.Assert(xmlReader.NodeType != XmlNodeType.EntityReference);

                            // Load unexpected children if there are any. 

                            OpenXmlElement child = this.ElementFactory(xmlReader);
                            child.Load(xmlReader, OpenXmlLoadMode.Full);
                            unwanted++;

                            if (this.ShadowElement == null)
                            {
                                this.ShadowElement = new OpenXmlUnknownElement(this.Prefix, this.LocalName, this.NamespaceUri);
                            }

                            this.ShadowElement.AppendChild(child);
                        }
                    }
                }

                if (unwanted == 0)
                {
                    // only text node, no unwanted children
                    Debug.Assert(this.ShadowElement == null);
                }
                else if (textNodePosition > -1)
                {
                    // place an OpenXmlMiscNode for the loaded text in the ShadowElement so that we can write out correct content in serialization.
                    OpenXmlMiscNode textNode = null;
                    switch (textNodeType)
                    {
                        case XmlNodeType.Text:
                            textNode = OpenXmlMiscNode.CreateFromText(this.RawInnerText);
                            break;

                        case XmlNodeType.CDATA:
                            textNode = OpenXmlMiscNode.CreateFromCdata(this.RawInnerText);
                            break;

                        case XmlNodeType.SignificantWhitespace:
                        case XmlNodeType.Whitespace: /* O15:#3024890 */
                            textNode = OpenXmlMiscNode.CreateFromSignificantWhitespace(this.RawInnerText);
                            break;

                    }
                    this.ShadowElement.InsertAt(textNode, textNodePosition);
                }
                else
                {
                    // textNodePosition == -1, no text loaded.
                }
            }

            xmlReader.Skip(); // skip the end tag

            // set raw outer xml to empty to indicate that it is passed
            this.RawOuterXml = string.Empty;
        }

        internal override T CloneImp<T>(bool deep)
        {
            T element = base.CloneImp<T>(deep);
            Debug.Assert(element is OpenXmlLeafTextElement);
            (element as OpenXmlLeafTextElement).Text = this.Text;
            return element;
        }
    }
}
