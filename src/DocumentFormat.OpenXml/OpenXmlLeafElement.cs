// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the base class from which leaf elements are derived.
    /// </summary>
    public abstract class OpenXmlLeafElement : OpenXmlElement
    {
        /// <summary>
        /// Gets or sets represents a shadow element to hold child elements if there are any.
        /// </summary>
        internal OpenXmlElement ShadowElement { get; set; }

        /// <summary>
        /// Initializes a new instance of the OpenXmlLeafElement class.
        /// </summary>
        protected OpenXmlLeafElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public override bool HasChildren => false;

        /// <inheritdoc/>
        public override string InnerXml
        {
            get
            {
                if (ShadowElement != null)
                {
                    return ShadowElement.InnerXml;
                }

                return string.Empty;
            }

            set
            {
                // only accept null or empty string.
                if (string.IsNullOrEmpty(value))
                {
                    ShadowElement = null;
                }
                else
                {
                    throw new InvalidOperationException(ExceptionMessages.LeafElementInnerXmlCannotBeSet);
                }
            }
        }

        /// <inheritdoc/>
        internal override void WriteContentTo(XmlWriter w)
        {
            // Write the loaded inner xml if there are any
            if (ShadowElement != null)
            {
                ShadowElement.WriteContentTo(w);
            }
        }

        /// <inheritdoc/>
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
                ShadowElement = new OpenXmlUnknownElement(Prefix, LocalName, NamespaceUri);
                ShadowElement.InnerXml = xmlReader.ReadInnerXml();
            }
            else
            {
                xmlReader.Skip();
            }

            // set raw outer xml to empty to indicate that it is parsed
            RawOuterXml = string.Empty;
        }
    }
}
