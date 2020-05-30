﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Validation.Schema;

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
        protected SdtElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
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
        /// Gets or sets the SdtProperties.
        /// </summary>
        public SdtProperties SdtProperties
        {
            get => GetElement<SdtProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// Gets or sets the SdtEndCharProperties.
        /// </summary>
        public SdtEndCharProperties SdtEndCharProperties
        {
            get => GetElement<SdtEndCharProperties>();
            set => SetElement(value);
        }
    }
}
