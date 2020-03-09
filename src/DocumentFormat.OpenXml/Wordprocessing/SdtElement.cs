// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Validation.Schema;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    /// <summary>
    /// Defines SdtElement - the base class for the sdt elements.
    /// </summary>
    public abstract class SdtElement : OpenXmlCompositeElement
    {
        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 0, 1)
        {
            new ElementParticle(typeof(SdtProperties), 0, 1),
            new ElementParticle(typeof(SdtEndCharProperties), 0, 1),
        }.Compile();

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
        /// Gets or sets the SdtProperties.
        /// </summary>
        [Index(0)]
        public SdtProperties SdtProperties
        {
            get => _constraint.Get<SdtProperties>(this);
            set => _constraint.Set(this, value);
        }

        /// <summary>
        /// Gets or sets the SdtEndCharProperties.
        /// </summary>
        [Index(1)]
        public SdtEndCharProperties SdtEndCharProperties
        {
            get => _constraint.Get<SdtEndCharProperties>(this);
            set => _constraint.Set(this, value);
        }
    }
}
