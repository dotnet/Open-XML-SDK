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
        /// Initializes a new instance of the CustomXmlElement class with the speicified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected CustomXmlElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomXmlElement class with the speicified child elements.
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

        /// <summary>
        /// Gets or sets the custom XML Markup Namespace.
        /// </summary>
        /// <remark>
        /// Represents the attribte in schema: w:uri.
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main.
        /// </remark>
        [SchemaAttr(23, "uri")]
        public StringValue Uri
        {
            get { return (StringValue)Attributes[0]; }
            set { Attributes[0] = value; }
        }

        /// <summary>
        /// Gets or sets the element name.
        /// </summary>
        /// <remark>
        /// Represents the attribte in schema: w:element.
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main.
        /// </remark>
        [SchemaAttr(23, "element")]
        public StringValue Element
        {
            get { return (StringValue)Attributes[1]; }
            set { Attributes[1] = value; }
        }

        internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
        {
            if (23 == namespaceId && "uri" == name)
                return new StringValue();

            if (23 == namespaceId && "element" == name)
                return new StringValue();

            return null;
        }

        /// <summary>
        /// Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
        /// </summary>
        /// <remark>
        /// xmlns:w = http://schemas.openxmlformats.org/wordprocessingml/2006/main.
        /// </remark>
        public CustomXmlProperties CustomXmlProperties
        {
            get
            {
                return GetElement<CustomXmlProperties>(0);
            }

            set
            {
                SetElement(0, value);
            }
        }
    }
}
