// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// NsAny particle validator.
    /// </summary>
    /// <remarks>
    /// xsd:any with defined namespace.
    /// </remarks>
    internal class NsAnyParticleValidator : AnyParticleValidator
    {
        private NsAnyParticle _nsAnyParticleConstraint;

        internal override ParticleConstraint ParticleConstraint
        {
            get { return _nsAnyParticleConstraint; }
        }

        /// <summary>
        /// Initializes a new instance of the AnyParticleValidator.
        /// </summary>
        /// <param name="particleConstraint"></param>
        internal NsAnyParticleValidator(NsAnyParticle particleConstraint)
            : base()
        {
            Debug.Assert(particleConstraint != null);
            Debug.Assert(particleConstraint.ParticleType == ParticleType.AnyWithUri);

            _nsAnyParticleConstraint = particleConstraint;
        }

        /// <summary>
        /// Try match this element once.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        public override void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            Debug.Assert(particleMatchInfo != null);
            Debug.Assert(particleMatchInfo.StartElement != null);
            Debug.Assert(!(particleMatchInfo.StartElement is OpenXmlMiscNode));

            var element = particleMatchInfo.StartElement;

            if (element.NamespaceUri == NamespaceIdMap.GetNamespaceUri(_nsAnyParticleConstraint.NamespaceId))
            {
                particleMatchInfo.Match = ParticleMatch.Matched;
                particleMatchInfo.LastMatchedElement = element;
            }
            else
            {
                particleMatchInfo.Match = ParticleMatch.Nomatch;
            }

            return;
        }

        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are required elements in this particle.</returns>
        public override bool GetRequiredElements(ExpectedChildren result)
        {
            if (ParticleConstraint.MinOccurs > 0)
            {
                if (result != null)
                {
                    result.Add(NamespaceIdMap.GetNamespaceUri(_nsAnyParticleConstraint.NamespaceId));
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are expected elements in this particle.</returns>
        public override bool GetExpectedElements(ExpectedChildren result)
        {
            if (result != null)
            {
                result.Add(NamespaceIdMap.GetNamespaceUri(_nsAnyParticleConstraint.NamespaceId));
            }

            return true;
        }
    }
}
