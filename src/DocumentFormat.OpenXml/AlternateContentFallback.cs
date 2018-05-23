// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines a mc:Fallback element in mc:AlternateContent.
    /// </summary>
    public class AlternateContentFallback : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AlternateContentFallback class.
        /// </summary>
        public AlternateContentFallback()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AlternateContentFallback class
        ///  by using the supplied IEnumerable elements.
        /// </summary>
        /// <param name="childElements">
        /// Represents all child elements.
        /// </param>
        public AlternateContentFallback(IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AlternateContentFallback class
        ///  by using the supplied OpenXmlElement elements.
        /// </summary>
        /// <param name="childElements">
        /// Represents all child elements.
        /// </param>
        public AlternateContentFallback(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <param name="outerXml">The outer XML of the element.</param>
        /// <summary>
        /// Initializes a new instance of the AlternateContentFallback class
        ///  by using the supplied string.
        /// </summary>
        public AlternateContentFallback(string outerXml)
            : base(outerXml)
        {
        }

        /// <summary>
        /// Gets a value that represents the tag name of the AlternateContentFallback element.
        /// </summary>
        public static string TagName { get; } = "Fallback";

        /// <summary>
        /// Gets the local name of the element.
        /// </summary>
        public override string LocalName => TagName;

        internal override byte NamespaceId => AlternateContent.MarkupCompatibilityNamespaceId;

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
                }
            }

            return newElement;
        }

        /// <returns>The cloned node. </returns>
        /// <summary>
        /// When a node is overridden in a derived class, CloneNode creates a
        ///  duplicate of the node.
        /// </summary>
        /// <param name="deep">
        /// True to recursively clone the subtree under the specified node; False
        ///  to clone only the node itself.
        /// </param>
        public override OpenXmlElement CloneNode(bool deep)
        {
            return CloneImp<AlternateContentFallback>(deep);
        }

        /// <summary>
        /// Gets the type ID of the element.
        /// </summary>
        internal override int ElementTypeId => ReservedElementTypeIds.AlternateContentFallbackId;

        internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    }
}
