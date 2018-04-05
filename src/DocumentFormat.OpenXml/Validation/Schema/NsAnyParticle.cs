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
    /// If there are multiple namespace in the original xsd, it will be split into multiple xsd:any in binary database.
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

        /// <inheritdoc/>
        internal override ParticleType ParticleType
        {
            get { return ParticleType.AnyWithUri; }
            set { Debug.Assert(value == ParticleType.AnyWithUri); }
        }

        /// <inheritdoc/>
        internal override int ElementId
        {
            set
            {
                _namespaceId = (byte)value;
            }
        }

        /// <summary>
        /// Gets the namespace ID of the namespace in the xsd:any@namespace.
        /// </summary>
        internal byte NamespaceId
        {
            get { return _namespaceId; }
        }

        /// <summary>
        /// Gets a ParticleValidator for this particle constraint.
        /// </summary>
        internal override IParticleValidator ParticleValidator => _particleValidator;
    }
}
