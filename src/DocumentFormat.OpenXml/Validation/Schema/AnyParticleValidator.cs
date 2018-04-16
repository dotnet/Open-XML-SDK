// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /******************************************************
     * TODO: should we take care of "processContests"? - processContents = (lax | skip | strict) : strict
    ******************************************************/

    /// <summary>
    /// Any particle validator.
    /// </summary>
    internal class AnyParticleValidator : IParticleValidator
    {
        private AnyParticle _particleConstraint;

        internal virtual ParticleConstraint ParticleConstraint
        {
            get { return _particleConstraint; }
        }

        protected AnyParticleValidator()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnyParticleValidator.
        /// </summary>
        /// <param name="particleConstraint"></param>
        internal AnyParticleValidator(AnyParticle particleConstraint)
        {
            Debug.Assert(particleConstraint != null);
            Debug.Assert(particleConstraint.ParticleType == ParticleType.Any);

            _particleConstraint = particleConstraint;
        }

        #region IParticleValidator Members

        /// <summary>
        /// Try match this element once.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        public virtual void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            Debug.Assert(particleMatchInfo != null);
            Debug.Assert(particleMatchInfo.StartElement != null);
            Debug.Assert(!(particleMatchInfo.StartElement is OpenXmlMiscNode));

            var element = particleMatchInfo.StartElement;

            switch (_particleConstraint.NamespaceValue)
            {
                case XsdAnyPrefidefinedValue.Any:
                    // Elements from any namespace can be present.
                    particleMatchInfo.Match = ParticleMatch.Matched;
                    particleMatchInfo.LastMatchedElement = element;
                    return;

                case XsdAnyPrefidefinedValue.Local:
                    // Elements that are not qualified with a namespace can be present.
                    if (string.IsNullOrEmpty(element.NamespaceUri))
                    {
                        particleMatchInfo.Match = ParticleMatch.Matched;
                        particleMatchInfo.LastMatchedElement = element;
                        return;
                    }
                    else
                    {
                        particleMatchInfo.Match = ParticleMatch.Nomatch;
                        return;
                    }

                case XsdAnyPrefidefinedValue.Other:
                    // Elements from any namespace that is not the target namespace of the parent element containing this element can be present.
                    if (string.IsNullOrEmpty(element.NamespaceUri) ||
                        element.Parent != null && element.NamespaceUri != element.Parent.NamespaceUri)
                    {
                        particleMatchInfo.Match = ParticleMatch.Matched;
                        particleMatchInfo.LastMatchedElement = element;
                        return;
                    }
                    else
                    {
                        particleMatchInfo.Match = ParticleMatch.Nomatch;
                        return;
                    }

                case XsdAnyPrefidefinedValue.TargetNamespace:
                    if (element.Parent != null && element.NamespaceUri == element.Parent.NamespaceUri)
                    {
                        particleMatchInfo.Match = ParticleMatch.Matched;
                        particleMatchInfo.LastMatchedElement = element;
                        return;
                    }
                    else
                    {
                        particleMatchInfo.Match = ParticleMatch.Nomatch;
                        return;
                    }
            }

            return;
        }

        /// <summary>
        /// Try match this element.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        public void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            Debug.Assert(particleMatchInfo != null);
            Debug.Assert(particleMatchInfo.StartElement != null);
            Debug.Assert(!(particleMatchInfo.StartElement is OpenXmlMiscNode));

            if (ParticleConstraint.MaxOccurs == 1)
            {
                TryMatchOnce(particleMatchInfo, validationContext);
            }
            else
            {
                // try to match multiple times.
                ParticleMatchInfo nextParticleMatchInfo;
                int matchCount = 0;
                var next = particleMatchInfo.StartElement;

                while (next != null && ParticleConstraint.MaxOccursGreaterThan(matchCount))
                {
                    nextParticleMatchInfo = new ParticleMatchInfo(next);
                    TryMatchOnce(nextParticleMatchInfo, validationContext);

                    if (nextParticleMatchInfo.Match == ParticleMatch.Nomatch)
                    {
                        break;
                    }
                    else if (nextParticleMatchInfo.Match == ParticleMatch.Matched)
                    {
                        matchCount++;
                        particleMatchInfo.LastMatchedElement = nextParticleMatchInfo.LastMatchedElement;
                        next = validationContext.GetNextChildMc(particleMatchInfo.LastMatchedElement);
                    }
                    else
                    {
                        // never go here
                        Debug.Assert( nextParticleMatchInfo.Match != ParticleMatch.Partial );
                    }
                }

                if (matchCount == 0)
                {
                    particleMatchInfo.Match = ParticleMatch.Nomatch;
                }
                else if (matchCount >= ParticleConstraint.MinOccurs)
                {
                    // matched OK
                    particleMatchInfo.Match = ParticleMatch.Matched;
                }
                else
                {
                    // minOccurs failed, incomplete children.
                    particleMatchInfo.Match = ParticleMatch.Partial;
                }
            }

            return;
        }

        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are required elements in this particle.</returns>
        public virtual bool GetRequiredElements(ExpectedChildren result)
        {
            if (ParticleConstraint.MinOccurs > 0)
            {
                if (result != null)
                {
                    result.Add(XsdAnyPrefidefinedValue.GetNamespaceString(_particleConstraint.NamespaceValue));
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

            GetRequiredElements(requiredElements);

            return requiredElements;
        }

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are expected elements in this particle.</returns>
        public virtual bool GetExpectedElements(ExpectedChildren result)
        {
            if (result != null)
            {
                result.Add(XsdAnyPrefidefinedValue.GetNamespaceString(_particleConstraint.NamespaceValue));
            }

            return true;
        }

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <returns>Expected elements in this particle.</returns>
        public ExpectedChildren GetExpectedElements()
        {
            ExpectedChildren expectedElements = new ExpectedChildren();

            GetExpectedElements(expectedElements);

            return expectedElements;
        }

        #endregion
    }
}
