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
        public static string TagName { get; } = "Choice";

        /// <summary>
        /// Gets the local name of the Choice element.
        /// </summary>
        public override string LocalName => TagName;

        internal override byte NamespaceId => AlternateContent.MarkupCompatibilityNamespaceId;

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new[]
        {
            AttributeTag.Create<StringValue>(0, "Requires"),
        };

        internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

        /// <summary>
        /// Gets or sets a whitespace-delimited list of namespace prefixes that identify the
        /// namespaces a markup consumer needs in order to understand and select that
        /// Choice and process the content.
        /// </summary>
        public StringValue Requires
        {
            get { return (StringValue)Attributes[0].Value; }
            set { Attributes[0].Value = value; }
        }

        internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
        {
            OpenXmlElement newElement = null;

            if (Parent != null &&
                 Parent is AlternateContent)
            {
                OpenXmlElement parentsParentElemnt = Parent.Parent;
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
        internal override int ElementTypeId => ReservedElementTypeIds.AlternateContentChoiceId;

        internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    }
}
