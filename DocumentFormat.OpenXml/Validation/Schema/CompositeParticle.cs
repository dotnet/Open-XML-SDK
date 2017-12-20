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

        /// <summary>
        /// Gets the type of the particle.
        /// </summary>
        internal override ParticleType ParticleType
        {
            get { return this._particleType; }
            set { this._particleType = value; }
        }

        /// <summary>
        /// Gets the children particles.
        /// </summary>
        internal override ParticleConstraint[] ChildrenParticles
        {
            get { return this._childrenParticles; }
            set { this._childrenParticles = value; }
        }

        /// <summary>
        /// Gets a ParticleValidator for this particle constraint.
        /// </summary>
        internal override IParticleValidator ParticleValidator
        {
            get
            {
                if (this._particleValidator == null)
                {
                    this._particleValidator = Schema.ParticleValidator.CreateParticleValidator(this);
                }
                return this._particleValidator;
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
