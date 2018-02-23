// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Defines methods to validate particles.
    /// </summary>
    internal interface IParticleValidator
    {
        /// <summary>
        /// Try match the particle once.
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext);

        /// <summary>
        /// Try match the particle,
        /// </summary>
        /// <param name="particleMatchInfo"></param>
        /// <param name="validationContext">The context information for validation.</param>
        void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext);

        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are required elements in this particle.</returns>
        bool GetRequiredElements(ExpectedChildren result);

        /// <summary>
        /// Get the required elements - elements which minOccurs > 0.
        /// </summary>
        /// <returns>Required elements in this particle.</returns>
        ExpectedChildren GetRequiredElements();

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>True if there are expected elements in this particle.</returns>
        bool GetExpectedElements(ExpectedChildren result);

        /// <summary>
        /// Get the expected elements - elements which minOccurs >= 0.
        /// </summary>
        /// <returns>Expected elements in this particle.</returns>
        ExpectedChildren GetExpectedElements();
    }
}
