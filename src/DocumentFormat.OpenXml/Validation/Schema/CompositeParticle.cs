// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle constraint for sequence, choice, all, and group.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [DebuggerDisplay("ParticleType={ParticleType}")]
    internal class CompositeParticle : ParticleConstraint
    {
        private IParticleValidator _particleValidator;

        /// <summary>
        /// Initializes a new instance of the CompositeParticle.
        /// </summary>
        internal CompositeParticle(ParticleType particleType, int minOccurs, int maxOccurs)
            : base(particleType, minOccurs, maxOccurs)
        {
        }

        /// <inheritdoc/>
        internal override IParticleValidator ParticleValidator
        {
            get
            {
                if (_particleValidator == null)
                {
                    _particleValidator = CreateParticleValidator();
                }

                return _particleValidator;
            }
        }

        private ParticleValidator CreateParticleValidator()
        {
            switch (ParticleType)
            {
                case ParticleType.All:
                    return new AllParticleValidator(this);

                case ParticleType.Choice:
                    return new ChoiceParticleValidator(this);

                case ParticleType.Sequence:
                    return new SequenceParticleValidator(this);

                case ParticleType.Group:
                    return new GroupParticleValidator(this);

                //case ParticleType.Any:
                //    return new AnyParticleValidator(particleConstraint);
                case ParticleType.Element:
                default:
                    throw new InvalidOperationException();
            }
        }

        //internal CompositeParticle NormalizeParticle(CompositeParticle compositeParticle)
        //{
        //    // TODO: do some normalization for the children.
        //    // 1). Remove the group when minOccurs=1 and maxOccurs=1 for the group.
        //    // 2). Merge sequence when minOccurs=1 and maxOccurs=1 for a child sequence.
        //    // 3). Merge choice when minOccurs=1 and maxOccurs=1 for a child choice.
        //    throw new NotImplementedException();
        //}
    }
}
