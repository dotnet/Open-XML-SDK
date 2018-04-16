// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

#pragma warning disable SA1402 // File may only contain a single type

namespace DocumentFormat.OpenXml.Validation.Schema
{
#if DEBUG
    /// <summary>
    /// InstanceCounter for performance investigation.
    /// </summary>
    public static class InstanceCounter
    {
        /// <summary>
        /// Gets or sets count of ParticleMatchInfo instance.
        /// </summary>
        public static long ParticleMatchInfo { get; set; }

        /// <summary>
        /// Gets or sets count of ExpectedChildren instance.
        /// </summary>
        public static long ExpectedChildren { get; set; }
    }

    internal partial class ExpectedChildren
    {
        static partial void IncressInstanceCount()
        {
            InstanceCounter.ExpectedChildren++;
        }
    }

    internal partial class ParticleMatchInfo
    {
        static partial void IncressInstanceCount()
        {
            InstanceCounter.ParticleMatchInfo++;
        }
    }

#endif

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
            return false;
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

        internal static ParticleValidator CreateParticleValidator(ParticleConstraint particleConstraint)
        {
            var compositeParticle = particleConstraint as CompositeParticle;

            switch (particleConstraint.ParticleType)
            {
                case ParticleType.All:
                    return new AllParticleValidator(compositeParticle);

                case ParticleType.Choice:
                    return new ChoiceParticleValidator(compositeParticle);

                case ParticleType.Sequence:
                    return new SequenceParticleValidator(compositeParticle);

                case ParticleType.Group:
                    return new GroupParticleValidator(compositeParticle);

                //case ParticleType.Any:
                //    return new AnyParticleValidator(particleConstraint);
                case ParticleType.Element:
                default:
                    throw new InvalidOperationException();
            }
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
