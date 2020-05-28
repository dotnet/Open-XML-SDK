// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines an mc:Choice element in mc:AlternateContent.
    /// </summary>
    public class AlternateContentChoice : OpenXmlCompositeElement
    {
        private const string Name = "Choice";

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
        public static string TagName => Name;

        /// <summary>
        /// Gets the local name of the Choice element.
        /// </summary>
        public override string LocalName => TagName;

        /// <summary>
        /// Gets or sets a whitespace-delimited list of namespace prefixes that identify the
        /// namespaces a markup consumer needs in order to understand and select that
        /// Choice and process the content.
        /// </summary>
        public StringValue Requires
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
        {
            if (Parent is AlternateContent)
            {
                var parentsParentElement = Parent.Parent;

                if (parentsParentElement != null)
                {
                    return parentsParentElement.ElementFactory(namespaceId, name);
                }
            }

            return null;
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AlternateContentChoice>(deep);

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);

            builder.SetSchema(AlternateContent.Namespace, Name);

            builder.AddElement<AlternateContentChoice>()
                .AddAttribute(0, "Requires", a => a.Requires);
        }
    }
}
