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
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort _xsdAnyValue;
        private IParticleValidator _particleValidator;

        /// <summary>
        /// Initializes a new instance of the AnyParticle.
        /// </summary>
        internal AnyParticle()
            : base(ParticleType.Any)
        {
            _particleValidator = new AnyParticleValidator(this);
        }

        internal AnyParticle(decimal minOccurs, decimal maxOccurs)
            : base(ParticleType.Any, minOccurs, maxOccurs)
        {
        }

        internal AnyParticle(ushort xsdAnyValue, decimal minOccurs, decimal maxOccurs)
            : base(ParticleType.Any, minOccurs, maxOccurs)
        {
            _xsdAnyValue = xsdAnyValue;
        }

        /// <inheritdoc/>
        internal override int ElementId
        {
            set
            {
                Debug.Assert(value == XsdAnyPrefidefinedValue.Any ||
                            value == XsdAnyPrefidefinedValue.Local ||
                            value == XsdAnyPrefidefinedValue.Other ||
                            value == XsdAnyPrefidefinedValue.TargetNamespace);

                _xsdAnyValue = (ushort)value;
            }
        }

        /// <summary>
        /// Gets the value of the xsd:any@namespace.
        /// </summary>
        public ushort NamespaceValue => _xsdAnyValue;

        /// <inheritdoc/>
        internal override IParticleValidator ParticleValidator => _particleValidator;
    }
}
