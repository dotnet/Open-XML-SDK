// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Wordprocessing
{
    /// <summary>
    /// Defines CustomXmlElement - the base class for the customXml elements.
    /// </summary>
    public abstract class CustomXmlElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomXmlElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected CustomXmlElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomXmlElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected CustomXmlElement(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomXmlBlock class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected CustomXmlElement(string outerXml)
            : base(outerXml)
        {
        }

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new[]
        {
            AttributeTag.Create<StringValue>(23, "uri"),
            AttributeTag.Create<StringValue>(23, "element"),
        };

        internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

        /// <summary>
        /// Gets or sets the custom XML Markup Namespace.
        /// </summary>
        /// <remark>
        /// Represents the attribute in schema: w:uri.
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main.
        /// </remark>
        [SchemaAttr(23, "uri")]
        public StringValue Uri
        {
            get { return (StringValue)Attributes[0].Value; }
            set { Attributes[0].Value = value; }
        }

        /// <summary>
        /// Gets or sets the element name.
        /// </summary>
        /// <remark>
        /// Represents the attribute in schema: w:element.
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main.
        /// </remark>
        [SchemaAttr(23, "element")]
        public StringValue Element
        {
            get { return (StringValue)Attributes[1].Value; }
            set { Attributes[1].Value = value; }
        }

        /// <summary>
        /// Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
        /// </summary>
        /// <remark>
        /// xmlns:w = http://schemas.openxmlformats.org/wordprocessingml/2006/main.
        /// </remark>
        public CustomXmlProperties CustomXmlProperties
        {
            get => GetElement<CustomXmlProperties>(0);
            set => SetElement(0, value);
        }
    }
}
