// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.Any.
    /// </summary>
    /// <remarks>
    /// xsd:any can contains only one namespace.
    /// If there are multiple namespace in the original xsd, it will be split into multiple xsd:any in binary database.
    /// </remarks>
    [DebuggerDisplay("NamespaceValue={NamespaceValue}")]
    internal class AnyParticle : ParticleConstraint
    {
        private readonly IParticleValidator _particleValidator;

        /// <summary>
        /// Initializes a new instance of the AnyParticle.
        /// </summary>
        internal AnyParticle(ushort xsdAnyValue, int minOccurs, int maxOccurs)
            : base(ParticleType.Any, minOccurs, maxOccurs)
        {
            NamespaceValue = xsdAnyValue;
            _particleValidator = new AnyParticleValidator(this);
        }

        internal AnyParticle(int minOccurs, int maxOccurs)
           : base(ParticleType.Any, minOccurs, maxOccurs)
        {
            _particleValidator = new AnyParticleValidator(this);
        }

        /// <summary>
        /// Gets the value of the xsd:any@namespace.
        /// </summary>
        public ushort NamespaceValue { get; }

        /// <inheritdoc/>
        internal override IParticleValidator ParticleValidator => _particleValidator;
    }
}
