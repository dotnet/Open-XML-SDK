// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines a mc:Fallback element in mc:AlternateContent.
    /// </summary>
    public class AlternateContentFallback : OpenXmlCompositeElement
    {
        private const string Name = "Fallback";

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
        public static string TagName => Name;

        internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
        {
            OpenXmlElement newElement = null;

            if (Parent != null &&
                 Parent is AlternateContent)
            {
                OpenXmlElement parentsParentElement = Parent.Parent;
                if (parentsParentElement != null)
                {
                    newElement = parentsParentElement.ElementFactory(namespaceId, name);
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);

            builder.SetSchema(AlternateContent.Namespace, Name);
        }
    }
}
