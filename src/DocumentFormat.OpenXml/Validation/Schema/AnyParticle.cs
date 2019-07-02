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
        internal AnyParticle(XsdAny xsdAnyValue, int minOccurs, int maxOccurs, FileFormatVersions version = FileFormatVersions.Office2007)
            : base(ParticleType.Any, minOccurs, maxOccurs, version)
        {
            NamespaceValue = xsdAnyValue;
            _particleValidator = new AnyParticleValidator(this);
        }

        internal AnyParticle(int minOccurs, int maxOccurs, FileFormatVersions version = FileFormatVersions.Office2007)
           : this(XsdAny.Any, minOccurs, maxOccurs, version)
        {
        }

        /// <summary>
        /// Gets the value of the xsd:any@namespace.
        /// </summary>
        public XsdAny NamespaceValue { get; }

        /// <inheritdoc/>
        internal override IParticleValidator ParticleValidator => _particleValidator;
    }
}
