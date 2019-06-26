// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Base class for particle validator.
    /// </summary>
    internal abstract class ParticleValidator : IParticleValidator
    {
        /// <summary>
        /// Initializes a new instance of the ParticleValidator.
        /// </summary>
        internal ParticleValidator()
        {
        }

        /// <summary>
        /// Be called on root particle of complex type.
        /// </summary>
        /// <param name="validationContext"></param>
        internal abstract void Validate(ValidationContext validationContext);

        /// <summary>
        /// Try match the particle once.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        public virtual void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            particleMatchInfo.Match = ParticleMatch.Nomatch;
            return;
        }

        /// <summary>
        /// Try match the particle.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        public virtual void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
        {
            particleMatchInfo.Match = ParticleMatch.Nomatch;
            return;
        }

        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are required elements in this particle.</returns>
        public virtual bool GetRequiredElements(ExpectedChildren result)
        {
            return false;
        }

        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <returns>Required elements in this particle.</returns>
        public ExpectedChildren GetRequiredElements()
        {
            var requiredElements = new ExpectedChildren();

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
            return false;
        }

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <returns>Expected elements in this particle.</returns>
        public ExpectedChildren GetExpectedElements()
        {
            var expectedElements = new ExpectedChildren();

            GetExpectedElements(expectedElements);

            return expectedElements;
        }

        internal static string GetExpectedChildrenMessage(OpenXmlElement parent, ExpectedChildren expectedChildrenIds)
        {
            Debug.Assert(parent != null);

            if (expectedChildrenIds != null)
            {
                return expectedChildrenIds.GetExpectedChildrenMessage(parent);
            }

            return string.Empty;
        }
    }
}
