// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the base class from which leaf elements are derived.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    public abstract class OpenXmlLeafElement : OpenXmlElement
    {

        /// <summary>
        /// Represents a shadow element to hold child elements if there are any. 
        /// </summary>
        internal OpenXmlElement ShadowElement
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlLeafElement class. 
        /// </summary>
        protected OpenXmlLeafElement()
            : base()
        {
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
        /// Gets or sets the markup that only represents child elements of the current
        ///  element.
        /// </summary>
        public override string InnerXml
        {
            get
            {
                if (this.ShadowElement != null)
                {
                    return this.ShadowElement.InnerXml;
                }
                return string.Empty;
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
        /// Saves all child elements of the current element to the specified XmlWriter. 
        /// </summary>
        /// <param name="w">The XmlWriter to which to save the child elements. </param>
        internal override void WriteContentTo(XmlWriter w)
        {
            // Write the loaded inner xml if there are any
            if (this.ShadowElement != null)
            {
                this.ShadowElement.WriteContentTo(w);
            }
        }

        /// <summary>
        /// Removes all child elements of the current element.
        /// </summary>
        public override void RemoveAllChildren()
        {
            // nothing to remove
            // TODO: should we clear the this.LoadedInnerXml?
        }

        internal override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
        {
            // BUGBUG! following Read() move the cursor to next node, and skip the attributes of the first node
            // xmlReader.Read(); // read this element 

            LoadAttributes(xmlReader);

            // TODO: handle non Text node ( PI, Comments, etc. )
            if (!xmlReader.IsEmptyElement)
            {
                Debug.Assert(xmlReader.IsStartElement());

                // load inner xml into LoadedInnerXml if there are any.
                this.ShadowElement = new OpenXmlUnknownElement(this.Prefix, this.LocalName, this.NamespaceUri);
                this.ShadowElement.InnerXml = xmlReader.ReadInnerXml();
            }
            else
            {
                xmlReader.Skip();
            }

            // set raw outer xml to empty to indicate that it is parsed
            this.RawOuterXml = string.Empty;
        }
    }
}
