// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace DocumentFormat.OpenXml.Wordprocessing
{
    /// <summary>
    /// Defines SdtElement - the base class for the sdt elements.
    /// </summary>
    public abstract class SdtElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SdtElement class.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected SdtElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SdtElement class.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected SdtElement(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SdtElement class.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected SdtElement(string outerXml)
            : base(outerXml)
        {
        }

        /// <summary>
        /// Gets/Sets the SdtProperties.
        /// </summary>
        public SdtProperties SdtProperties
        {
            get
            {
                return GetElement<SdtProperties>(0);
            }

            set
            {
                this.SetElement(0, value);
            }
        }

        /// <summary>
        /// Gets/Sets the SdtEndCharProperties.
        /// </summary>
        public SdtEndCharProperties SdtEndCharProperties
        {
            get
            {
                return GetElement<SdtEndCharProperties>(1);
            }

            set
            {
                this.SetElement(1, value);
            }
        }
    }
}
