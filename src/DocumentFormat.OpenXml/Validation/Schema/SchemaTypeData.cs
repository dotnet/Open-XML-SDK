// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema.Restrictions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// The schema type constraint for an OpenXmlElement.
    /// </summary>
    /// <remarks>
    ///
    /// </remarks>
    [DebuggerDisplay("OpenXmlTypeId={OpenXmlTypeId}")]
    internal class SchemaTypeData
    {
        internal SchemaTypeData(int openxmlTypeId, AttributeConstraint[] attributeConstraints)
        {
            OpenXmlTypeId = openxmlTypeId;

            // Use ReadOnlyCollection<T> as the return type in debug version.
#if DEBUG
            if (attributeConstraints != null)
            {
                AttributeConstraints = new ReadOnlyCollection<AttributeConstraint>(attributeConstraints);
            }
#else
            AttributeConstraints = attributeConstraints;
#endif
        }

        /// <summary>
        /// Initializes a new instance of the SchemaTypeData.
        /// </summary>
        /// <param name="openxmlTypeId"></param>
        /// <param name="attributeConstraints"></param>
        /// <param name="particleConstraint"></param>
        /// <remarks>
        /// For complex type which contains children particles.
        /// </remarks>
        internal SchemaTypeData(int openxmlTypeId, AttributeConstraint[] attributeConstraints, ParticleConstraint particleConstraint)
            : this(openxmlTypeId, attributeConstraints)
        {
            Debug.Assert(particleConstraint != null);

            ParticleConstraint = particleConstraint;
        }

        /// <summary>
        /// Initializes a new instance of the SchemaTypeData.
        /// </summary>
        /// <param name="openxmlTypeId"></param>
        /// <param name="attributeConstraints"></param>
        /// <param name="simpleTypeConstraint"></param>
        /// <remarks>
        /// For simple type or complex type which is simple content (no particle children).
        /// </remarks>
        internal SchemaTypeData(int openxmlTypeId, AttributeConstraint[] attributeConstraints, SimpleTypeRestriction simpleTypeConstraint)
            : this(openxmlTypeId, attributeConstraints)
        {
            Debug.Assert(simpleTypeConstraint != null);
            SimpleTypeConstraint = simpleTypeConstraint;
        }

        /// <summary>
        /// Gets the type ID of the OpenXmlElement class for this schema type.
        /// </summary>
        internal int OpenXmlTypeId { get; private set; }

        /// <summary>
        /// Gets or sets the particle constraint of this schema type.
        /// </summary>
        /// <remarks>
        /// Valid for complex types which are composite types - aka. has children particles.
        /// Otherwise, it should be null.
        /// </remarks>
        internal ParticleConstraint ParticleConstraint { get; private set; }

        /// <summary>
        /// Gets or sets the simple type constraint when this type is simple content.
        /// </summary>
        /// <remarks>
        /// The simple type constraint if it is a simple content complex type or a simple type.
        /// null for complex types which are composite types - aka. has children particles.
        /// </remarks>
        internal SimpleTypeRestriction SimpleTypeConstraint { get; private set; }

        /// <summary>
        /// Gets or sets the constraints for all the attributes of this type.
        /// </summary>
        /// <remarks>
        /// Each attribute is mapped to a class property in the generated OpenXmlElement class.
        /// The attributes value are saved in a fixed array in the OpenXmlElement class.
        /// So the attribute constraint in this array has same order (has a 1:1 map relation to the fixed array in the class).
        /// </remarks>
        internal IList<AttributeConstraint> AttributeConstraints { get; private set; }

        internal bool HasAttributeConstraints
        {
            get
            {
                return AttributeConstraints != null && AttributeConstraints.Count > 0;
            }
        }

        internal int AttributeConstraintsCount
        {
            get
            {
                if (AttributeConstraints != null)
                {
                    return AttributeConstraints.Count;
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the schema type is a schema type which contains particles.
        /// </summary>
        internal bool IsCompositeType => ParticleConstraint != null;

        /// <summary>
        /// Gets a value indicating whether the schema type contains simple content only.
        /// </summary>
        internal bool IsSimpleContent => SimpleTypeConstraint != null;
    }
 }
