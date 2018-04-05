// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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

        /// <inheritdoc/>
        internal override ParticleType ParticleType
        {
            get { return ParticleType.Element; }
            set { Debug.Assert(value == ParticleType.Element); }
        }

        /// <inheritdoc/>
        internal override int ElementId
        {
            get { return _elementId; }
            set { _elementId = value; }
        }

        /// <inheritdoc/>
        internal override IParticleValidator ParticleValidator
        {
            get { return this; }
        }

        /// <inheritdoc/>
        public void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            Debug.Assert(particleMatchInfo != null);
            Debug.Assert(particleMatchInfo.StartElement != null);

            if (particleMatchInfo.StartElement.ElementTypeId == ElementId)
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

        /// <inheritdoc/>
        public void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            Debug.Assert(particleMatchInfo != null);
            Debug.Assert(particleMatchInfo.StartElement != null);

            if (ElementId != particleMatchInfo.StartElement.ElementTypeId)
            {
                particleMatchInfo.Match = ParticleMatch.Nomatch;
            }
            else if (MaxOccurs == 1)
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
                    MaxOccursGreaterThan(count) &&
                    element.ElementTypeId == ElementId)
                {
                    count++;
                    particleMatchInfo.LastMatchedElement = element;
                    element = validationContext.GetNextChildMc(element);
                }

                if (count >= MinOccurs)
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

                        particleMatchInfo.ExpectedChildren.Add(ElementId);
                    }
                }
            }

            return;
        }

        /// <inheritdoc/>
        public bool GetRequiredElements(ExpectedChildren result)
        {
            if (MinOccurs > 0)
            {
                if (result != null)
                {
                    result.Add(ElementId);
                }

                return true;
            }

            return false;
        }

        /// <inheritdoc/>
        public ExpectedChildren GetRequiredElements()
        {
            ExpectedChildren requiredElements = new ExpectedChildren();

            if (MinOccurs > 0)
            {
                requiredElements.Add(ElementId);
            }

            return requiredElements;
        }

        /// <inheritdoc/>
        public bool GetExpectedElements(ExpectedChildren result)
        {
            result.Add(ElementId);
            return true;
        }

        /// <inheritdoc/>
        public ExpectedChildren GetExpectedElements()
        {
            ExpectedChildren expectedElements = new ExpectedChildren();

            expectedElements.Add(ElementId);

            return expectedElements;
        }
    }
}
