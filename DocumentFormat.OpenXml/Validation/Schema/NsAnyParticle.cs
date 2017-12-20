// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.AnyWithUri.
    /// </summary>
    /// <remarks>
    /// xsd:any can contains only one namespace.
    /// If there are multiple namespace in the original xsd, it will be splitted into multiple xsd:any in binary database.
    /// </remarks>
    [DebuggerDisplay("NamespaceId={NamespaceId}")]
    internal class NsAnyParticle : ParticleConstraint
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte _namespaceId;
        private IParticleValidator _particleValidator;

        /// <summary>
        /// Initializes a new instance of the NsAnyParticle.
        /// </summary>
        internal NsAnyParticle()
            : base()
        {
            _particleValidator = new NsAnyParticleValidator(this);
        }

        /// <summary>
        /// Gets the type of the particle.
        /// </summary>
        internal override ParticleType ParticleType
        {
            get { return ParticleType.AnyWithUri; }
            set { Debug.Assert(value == ParticleType.AnyWithUri); }
        }

        /// <summary>
        /// This field is actually the namespace ID of the xsd:any.
        /// </summary>
        internal override int ElementId
        {
            set
            {
                this._namespaceId = (byte)value;
            }
        }

        /// <summary>
        /// The namespace ID of the the namespace in the xsd:any@namespace.
        /// </summary>
        internal byte NamespaceId
        {
            get { return this._namespaceId; }
        }

        /// <summary>
        /// Gets a ParticleValidator for this particle constraint.
        /// </summary>
        internal override IParticleValidator ParticleValidator
        {
            get { return this._particleValidator;  }
        }
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
