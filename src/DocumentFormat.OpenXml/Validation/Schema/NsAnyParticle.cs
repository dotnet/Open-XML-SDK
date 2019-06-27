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
        /// <summary>
        /// Initializes a new instance of the NsAnyParticle.
        /// </summary>
        internal NsAnyParticle(int namespaceId, int minOccurs, int maxOccurs, FileFormatVersions version = FileFormatVersions.Office2007)
            : base(ParticleType.AnyWithUri, minOccurs, maxOccurs, version)
        {
            ParticleValidator = new NsAnyParticleValidator(this);
            NamespaceId = (byte)namespaceId;
        }

        /// <summary>
        /// Gets the namespace ID of the namespace in the xsd:any@namespace.
        /// </summary>
        public byte NamespaceId { get; }

        /// <summary>
        /// Gets a ParticleValidator for this particle constraint.
        /// </summary>
        internal override IParticleValidator ParticleValidator { get; }
    }
}
