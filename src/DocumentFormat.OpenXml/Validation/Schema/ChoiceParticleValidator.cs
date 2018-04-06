// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Choice particle validator.
    /// </summary>
    internal class ChoiceParticleValidator : CompositeParticleValidator
    {
        /// <summary>
        /// This data field is moved from TryMatchOnce.
        /// Base on the following point.
        /// - The TryMatchOnce() method will NOT be called more than once with same ChoiceParticleValidator instance on the stack when validating one element.
        /// - That means this data field will not be overridden in recursive calling when validating one element.
        /// </summary>
        private ParticleMatchInfo _childMatchInfo = new ParticleMatchInfo();

        /// <summary>
        /// Initializes a new instance of the ChoiceParticleValidator.
        /// </summary>
        /// <param name="particleConstraint"></param>
        internal ChoiceParticleValidator(CompositeParticle particleConstraint)
            : base(particleConstraint)
        {
            Debug.Assert(particleConstraint != null);
            Debug.Assert(particleConstraint.ParticleType == ParticleType.Choice);
        }

        /// <summary>
        /// Try match the particle once.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        public override void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            Debug.Assert(!(particleMatchInfo.StartElement is OpenXmlMiscNode));

            var next = particleMatchInfo.StartElement;

            particleMatchInfo.LastMatchedElement = null;
            particleMatchInfo.Match = ParticleMatch.Nomatch;

            ParticleConstraint childConstraint;
            int constraintIndex = 0;
            int constraintTotal = ParticleConstraint.ChildrenParticles.Length;

            while (constraintIndex < constraintTotal && next != null)
            {
                childConstraint = ParticleConstraint.ChildrenParticles[constraintIndex];

                // Use Reset() instead of new() to avoid heavy memory allocation and GC.
                _childMatchInfo.Reset(next);

                childConstraint.ParticleValidator.TryMatch(_childMatchInfo, validationContext);

                // if the _childMatchInfo.StartElement is changed, it means this method of this object is called more than once on the stack.
                Debug.Assert(_childMatchInfo.StartElement == next);

                switch (_childMatchInfo.Match)
                {
                    case ParticleMatch.Nomatch:
                        // continue trying match next child constraint.
                        constraintIndex++;
                        break;

                    case ParticleMatch.Matched:
                        particleMatchInfo.Match = ParticleMatch.Matched;
                        particleMatchInfo.LastMatchedElement = _childMatchInfo.LastMatchedElement;
                        return;

                    case ParticleMatch.Partial:
                        // partial match, incomplete children.
                        particleMatchInfo.Match = ParticleMatch.Partial;
                        particleMatchInfo.LastMatchedElement = _childMatchInfo.LastMatchedElement;
                        if (validationContext.CollectExpectedChildren)
                        {
                            particleMatchInfo.SetExpectedChildren(_childMatchInfo.ExpectedChildren);
                        }

                        return;
                }
            }

            // no match
            Debug.Assert(particleMatchInfo.Match == ParticleMatch.Nomatch);
            return;
        }

        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are required elements in this particle.</returns>
        public override bool GetRequiredElements(ExpectedChildren result)
        {
            bool requiredElements = true;
            var requiredChoiceChildren = new ExpectedChildren();

            // if there are any child elements that minOccurs = 0, then there is no required children.
            if (ParticleConstraint.MinOccurs > 0)
            {
                foreach (var constraint in ParticleConstraint.ChildrenParticles)
                {
                    if (!constraint.ParticleValidator.GetRequiredElements(requiredChoiceChildren))
                    {
                        requiredElements = false;
                    }
                }

                if (requiredElements && result != null)
                {
                    result.Add(requiredChoiceChildren);
                }

                return requiredElements;
            }
            else
            {
                return false;
            }
        }
    }
}
