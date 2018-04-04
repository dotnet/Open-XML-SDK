// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// A constraint data item for complex type.
    /// The ParticleType, MinOccurs, MaxOccurs means the constraint of this particle in the parent.
    /// </summary>
    /// <remarks>
    /// </remarks>
    internal abstract class ParticleConstraint
    {
        /// <summary>
        /// Initializes a new instance of the ParticleConstraint.
        /// </summary>
        internal ParticleConstraint()
        {
            // default minOccurs and maxOccurs are 1.
            //this.MaxOccurs = 1;
            //this.MinOccurs = 1;
        }

        /// <summary>
        /// Gets or sets the type of the particle.
        /// </summary>
        internal virtual ParticleType ParticleType
        {
            get { return ParticleType.Invalid; }
            set { throw new InvalidOperationException(); }
        }

        /// <summary>
        /// Gets or sets the minOccurs constraint.
        /// </summary>
        internal int MinOccurs { get; set; }

        /// <summary>
        /// Gets or sets the maxOccurs constraint.
        /// 0 means "unbounded".
        /// </summary>
        internal int MaxOccurs { get; set; }

        /// <summary>
        /// Gets a value indicating whether the maxOccurs is unbounded.
        /// </summary>
        internal bool UnboundedMaxOccurs
        {
            get { return MaxOccurs == 0; }
        }

        /// <summary>
        /// Gets a value indicating whether maxOccurs is unbounded or maxOccurs > 1
        /// </summary>
        internal bool CanOccursMoreThanOne
        {
            get { return UnboundedMaxOccurs || MaxOccurs > 1; }
        }

        /// <summary>
        /// Test whether the count is valid.
        /// </summary>
        /// <param name="count">The count of the occurs.</param>
        /// <returns>Returns true if maxOccurs="unbounded" or this.MaxOccurs>count.</returns>
        internal bool MaxOccursGreaterThan(int count)
        {
            return UnboundedMaxOccurs || MaxOccurs > count;
        }

        /// <summary>
        /// Gets or sets the type ID of the OpenXmlElement if the ParticleType == ParticleType.Element.
        /// </summary>
        /// <remarks>
        /// TODO: change int to ushort?
        /// </remarks>
        internal virtual int ElementId
        {
            get { return SdbData.InvalidId; }
            set { Debug.Assert(value == SdbData.InvalidId); }
        }

        /// <summary>
        /// Gets or sets the children particles.
        /// </summary>
        /// <remarks>
        /// be null if the ParticleType == ParticleType.Element || ParticleType=ParticleType.Any
        /// </remarks>
        internal virtual ParticleConstraint[] ChildrenParticles
        {
            get { return null; }
            set { throw new InvalidOperationException(); }
        }

        /// <summary>
        /// Gets a ParticleValidator for this particle constraint.
        /// </summary>
        internal virtual IParticleValidator ParticleValidator
        {
            get { return null; }
        }

        /// <summary>
        /// Test whether this is a simple particle - the particle contains only elements as children.
        /// </summary>
        /// <returns></returns>
        internal bool IsSimple()
        {
            bool isSimple = true;

            if (ChildrenParticles != null)
            {
                foreach (var constraint in ChildrenParticles)
                {
                    if (constraint.ParticleType == ParticleType.All ||
                        constraint.ParticleType == ParticleType.Choice ||
                        constraint.ParticleType == ParticleType.Group ||
                        constraint.ParticleType == ParticleType.Sequence ||
                        constraint.ParticleType == ParticleType.Any ||
                        constraint.ParticleType == ParticleType.AnyWithUri)
                    {
                        // there are sequence particles without any children.
                        // Debug.Assert(constraint.ChildrenParticles != null && constraint.ChildrenParticles.Length > 0);
                        isSimple = false;
                    }
                    else
                    {
                    }
                }
            }

            return isSimple;
        }

        /// <summary>
        /// Create a ParticleConstraint for the specified ParticleType.
        /// </summary>
        /// <param name="particleType"></param>
        /// <returns></returns>
        internal static ParticleConstraint CreateParticleConstraint(ParticleType particleType)
        {
            switch (particleType)
            {
                case ParticleType.Element:
                    return new ElementParticle();

                case ParticleType.Any:
                    return new AnyParticle();

                case ParticleType.AnyWithUri:
                    return new NsAnyParticle();

                case ParticleType.Invalid:
                    Debug.Assert(particleType != ParticleType.Invalid);
                    return null;

                default:
                    return new CompositeParticle();
            }
        }
    }
}
