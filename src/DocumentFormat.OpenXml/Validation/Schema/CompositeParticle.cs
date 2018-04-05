// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ParticleType _particleType;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ParticleConstraint[] _childrenParticles;

        private IParticleValidator _particleValidator;

        /// <summary>
        /// Initializes a new instance of the CompositeParticle.
        /// </summary>
        internal CompositeParticle()
            : base()
        {
        }

        /// <inheritdoc/>
        internal override ParticleType ParticleType
        {
            get { return _particleType; }
            set { _particleType = value; }
        }

        /// <inheritdoc/>
        internal override ParticleConstraint[] ChildrenParticles
        {
            get { return _childrenParticles; }
            set { _childrenParticles = value; }
        }

        /// <inheritdoc/>
        internal override IParticleValidator ParticleValidator
        {
            get
            {
                if (_particleValidator == null)
                {
                    _particleValidator = Schema.ParticleValidator.CreateParticleValidator(this);
                }

                return _particleValidator;
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
