// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.Element.
    /// </summary>
    [DebuggerDisplay("ElementId={ElementId}")]
    internal class ElementParticle : ParticleConstraint, IParticleValidator
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int _elementId;

        /// <summary>
        /// Initializes a new instance of the ElementParticle.
        /// </summary>
        internal ElementParticle()
            : base()
        {
        }

        /// <summary>
        /// Gets the type of the particle.
        /// </summary>
        internal override ParticleType ParticleType
        {
            get { return ParticleType.Element; }
            set { Debug.Assert(value == ParticleType.Element); }
        }

        /// <summary>
        /// Gets or sets the type ID of the OpenXmlElement if the ParticleType == ParticleType.Element.
        /// </summary>
        internal override int ElementId
        {
            get { return this._elementId; }
            set { this._elementId = value; }
        }

        /// <summary>
        /// Gets a ParticleValidator for this particle constraint.
        /// </summary>
        internal override IParticleValidator ParticleValidator
        {
            get { return this; }
        }

        #region IParticleValidator Members

        /// <summary>
        /// Try match this element once.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext"></param>
        public void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            Debug.Assert(particleMatchInfo != null);
            Debug.Assert(particleMatchInfo.StartElement != null);

            if (particleMatchInfo.StartElement.ElementTypeId == this.ElementId)
            {
                particleMatchInfo.Match = ParticleMatch.Matched;
                particleMatchInfo.LastMatchedElement = particleMatchInfo.StartElement;
            }
            else
            {
                particleMatchInfo.Match = ParticleMatch.Nomatch;
            }
            return;
        }

        /// <summary>
        /// Try match this element.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext"></param>
        public void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            Debug.Assert(particleMatchInfo != null);
            Debug.Assert(particleMatchInfo.StartElement != null);

            if (this.ElementId != particleMatchInfo.StartElement.ElementTypeId)
            {
                particleMatchInfo.Match = ParticleMatch.Nomatch;
            }
            else if (this.MaxOccurs == 1)
            {
                // matched element once.
                particleMatchInfo.Match = ParticleMatch.Matched;
                particleMatchInfo.LastMatchedElement = particleMatchInfo.StartElement;
            }
            else
            {
                // try to match multiple elements.
                var element = particleMatchInfo.StartElement;
                int count = 0;

                while (element != null &&
                    this.MaxOccursGreaterThan(count) &&
                    element.ElementTypeId == this.ElementId)
                {
                    count++;
                    particleMatchInfo.LastMatchedElement = element;
                    element = validationContext.GetNextChildMc(element);
                }

                if (count >= this.MinOccurs)
                {
                    particleMatchInfo.Match = ParticleMatch.Matched;
                }
                else
                {
                    particleMatchInfo.Match = ParticleMatch.Partial;
                    if (validationContext.CollectExpectedChildren)
                    {
                        if (particleMatchInfo.ExpectedChildren == null)
                        {
                            particleMatchInfo.InitExpectedChildren();
                        }
                        particleMatchInfo.ExpectedChildren.Add(this.ElementId);
                    }
                }
            }
            return;
        }

        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are required elements in this particle.</returns>
        public bool GetRequiredElements(ExpectedChildren result)
        {
            if (this.MinOccurs > 0)
            {
                if (result != null)
                {
                    result.Add(this.ElementId);
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <returns>Required elements in this particle.</returns>
        public ExpectedChildren GetRequiredElements()
        {
            ExpectedChildren requiredElements = new ExpectedChildren();

            if (this.MinOccurs > 0)
            {
                requiredElements.Add(this.ElementId);
            }

            return requiredElements;
        }

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are expected elements in this particle.</returns>
        public bool GetExpectedElements(ExpectedChildren result)
        {
            result.Add(this.ElementId);
            return true;
        }

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <returns>Expected elements in this particle.</returns>
        public ExpectedChildren GetExpectedElements()
        {
            ExpectedChildren expectedElements = new ExpectedChildren();

            expectedElements.Add(this.ElementId);

            return expectedElements;
        }

        #endregion
    }

#if false
    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.All
    /// </summary>
    internal class AllParticle : CompositeParticle
    {
        internal AllParticle() : base()
        {
        }
    }

    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.Choice
    /// </summary>
    internal class ChoiceParticle : CompositeParticle
    {
        internal ChoiceParticle()
            : base()
        {
        }
    }

    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.Sequence
    /// </summary>
    internal class SequenceParticle : CompositeParticle
    {
        internal SequenceParticle()
            : base()
        {
        }
    }

    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.Group
    /// </summary>
    internal class GroupParticle : CompositeParticle
    {
        internal GroupParticle()
            : base()
        {
        }
    }
#endif

}
