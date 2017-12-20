// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
    /// <summary>
    /// Particle constraint data for particle which type is ParticleType.Any.
    /// </summary>
    /// <remarks>
    /// xsd:any can contains only one namespace.
    /// If there are multiple namespace in the original xsd, it will be splitted into multiple xsd:any in binary database.
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
            : base()
        {
            _particleValidator = new AnyParticleValidator(this);
        }

        /// <summary>
        /// Gets the type of the particle.
        /// </summary>
        internal override ParticleType ParticleType
        {
            get { return ParticleType.Any; }
            set { Debug.Assert(value == ParticleType.Any); }
        }

        /// <summary>
        /// This field is actually the value of the xsd:any.
        /// </summary>
        internal override int ElementId
        {
            set
            {
                Debug.Assert( value == XsdAnyPrefidefinedValue.Any ||
                            value == XsdAnyPrefidefinedValue.Local ||
                            value == XsdAnyPrefidefinedValue.Other ||
                            value == XsdAnyPrefidefinedValue.TargetNamespace);

                this._xsdAnyValue = (ushort)value;
            }
        }

        /// <summary>
        /// The value of the xsd:any@namespace.
        /// </summary>
        internal ushort NamespaceValue
        {
            get { return this._xsdAnyValue; }
        }

        /// <summary>
        /// Gets a ParticleValidator for this particle constraint.
        /// </summary>
        internal override IParticleValidator ParticleValidator
        {
            get { return this._particleValidator; }
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
