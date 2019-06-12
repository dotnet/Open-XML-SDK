// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// The schema type constraint for an OpenXmlElement.
    /// </summary>
    [DebuggerDisplay("OpenXmlTypeId={OpenXmlTypeId}")]
    internal class SchemaTypeData
    {
        /// <summary>
        /// Initializes a new instance of the SchemaTypeData.
        /// </summary>
        /// <param name="openxmlTypeId"></param>
        /// <param name="particleConstraint"></param>
        /// <remarks>
        /// For complex type which contains children particles.
        /// </remarks>
        public SchemaTypeData(int openxmlTypeId, ParticleConstraint particleConstraint)
        {
            Debug.Assert(particleConstraint != null);

            OpenXmlTypeId = openxmlTypeId;
            ParticleConstraint = particleConstraint;
        }

        /// <summary>
        /// Gets the type ID of the OpenXmlElement class for this schema type.
        /// </summary>
        public int OpenXmlTypeId { get; }

        /// <summary>
        /// Gets the particle constraint of this schema type.
        /// </summary>
        /// <remarks>
        /// Valid for complex types which are composite types - aka. has children particles.
        /// Otherwise, it should be null.
        /// </remarks>
        public ParticleConstraint ParticleConstraint { get; }
    }
}
