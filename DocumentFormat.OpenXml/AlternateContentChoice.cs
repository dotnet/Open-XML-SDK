// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines an mc:Choice element in mc:AlternateContent.
    /// </summary>
    public class AlternateContentChoice : OpenXmlCompositeElement
    {
        private static string tagName = "Choice";

        /// <summary>
        /// Initializes a new instance of the
        /// AlternateContentChoice class.
        /// </summary>
        public AlternateContentChoice()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AlternateContentChoice class by using the supplied
        /// IEnumerable elements.
        /// </summary>
        /// <param name="childElements">
        /// Represents all child elements.
        /// </param>
        public AlternateContentChoice(IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AlternateContentChoice class by using the supplied
        /// OpenXmlElement elements.
        /// </summary>
        /// <param name="childElements">
        /// Represents all child elements.
        /// </param>
        public AlternateContentChoice(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <param name="outerXml">
        /// The outer XML of the element.
        /// </param>
        /// <summary>
        /// Initializes a new instance of the
        /// AlternateContentChoice class by using the supplied
        /// string.
        /// </summary>
        public AlternateContentChoice(string outerXml)
            : base(outerXml)
        {
        }

        /// <summary>
        /// Gets a value that represents the tag name of the
        /// Choice element.
        /// </summary>
        public static string TagName
        {
            get { return tagName; }
        }
        /// <summary>
        /// Gets the local name of the Choice element.
        /// </summary>
        public override string LocalName
        {
            get { return tagName; }
        }

        internal override byte NamespaceId
        {
            get { return AlternateContent.MarkupCompatibilityNamespaceId; }
        }

        private static string[] attributeTagNames = { "Requires" };
        private static byte[] attributeNamespaceIds = { 0 };

        internal override string[] AttributeTagNames
        {
            get
            {
                return attributeTagNames;
            }
        }

        internal override byte[] AttributeNamespaceIds
        {
            get
            {
                return attributeNamespaceIds;
            }
        }

        internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
        {
            if (0 == namespaceId && "Requires" == name)
                return new StringValue();
            return null;
        }

        /// <summary>
        /// Gets or sets a whitespace-delimited list of namespace prefixes that identify the
        /// namespaces a markup consumer needs in order to understand and select that
        /// Choice and process the content.
        /// </summary>
        public StringValue Requires
        {
            get { return (StringValue)Attributes[0]; }
            set { Attributes[0] = value; }
        }

        internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
        {
            OpenXmlElement newElement = null;

            if (this.Parent != null &&
                 this.Parent is AlternateContent)
            {
                OpenXmlElement parentsParentElemnt = this.Parent.Parent;
                if (parentsParentElemnt != null)
                {
                    newElement = parentsParentElemnt.ElementFactory(namespaceId, name);
                    if (newElement == null)
                    {
                        newElement = parentsParentElemnt.AlternateContentElementFactory(namespaceId, name);
                    }
                }
            }

            return newElement;
        }

        /// <returns>The cloned node. </returns>
        /// <summary>
        /// When a node is overridden in a derived class, CloneNode creates a duplicate
        ///  of the node.
        /// </summary>
        /// <param name="deep">
        /// True to recursively clone the subtree under the specified node; False
        ///  to clone only the node itself.
        /// </param>
        public override OpenXmlElement CloneNode(bool deep)
        {
            return CloneImp<AlternateContentChoice>(deep);
        }

        /// <summary>
        /// Gets the type ID of the element.
        /// </summary>
        internal override int ElementTypeId
        {
            get { return ReservedElementTypeIds.AlternateContentChoiceId; }
        }

        /// <summary>
        /// Indicates whether this element is available in a specific version of an Office Application.
        /// This method always returns true since AlternateContentFallback is available in every version.
        /// </summary>
        /// <param name="version">The Office file format version.</param>
        /// <returns>Returns true if the element is defined in the specified version.</returns>
        internal override bool IsInVersion(FileFormatVersions version)
        {
            return true;
        }
    }
}
