// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// A constraint data item for complex type.
    /// The ParticleType, MinOccurs, MaxOccurs means the constraint of this particle in the parent.
    /// </summary>
    /// <remarks>
    /// </remarks>
    internal abstract class ParticleConstraint : IEnumerable<ParticleConstraint>
    {
        private List<ParticleConstraint> _children;

        /// <summary>
        /// Initializes a new instance of the ParticleConstraint.
        /// </summary>
        internal ParticleConstraint(ParticleType type, int minOccurs, int maxOccurs)
        {
            ParticleType = type;
            MinOccurs = minOccurs;
            MaxOccurs = maxOccurs;
        }

        /// <summary>
        /// Gets the type of the particle.
        /// </summary>
        public ParticleType ParticleType { get; }

        /// <summary>
        /// Gets the minOccurs constraint.
        /// </summary>
        public int MinOccurs { get; }

        /// <summary>
        /// Gets the maxOccurs constraint.
        /// 0 means "unbounded".
        /// </summary>
        public int MaxOccurs { get; }

        /// <summary>
        /// Gets a value indicating whether the maxOccurs is unbounded.
        /// </summary>
        internal bool UnboundedMaxOccurs => MaxOccurs == 0;

        /// <summary>
        /// Gets a value indicating whether maxOccurs is unbounded or maxOccurs > 1
        /// </summary>
        internal bool CanOccursMoreThanOne => UnboundedMaxOccurs || MaxOccurs > 1;

        /// <summary>
        /// Test whether the count is valid.
        /// </summary>
        /// <param name="count">The count of the occurs.</param>
        /// <returns>Returns true if maxOccurs="unbounded" or this.MaxOccurs>count.</returns>
        internal bool MaxOccursGreaterThan(int count) => UnboundedMaxOccurs || MaxOccurs > count;

        /// <summary>
        /// Gets the type ID of the OpenXmlElement if the ParticleType == ParticleType.Element.
        /// </summary>
        /// <remarks>
        /// TODO: change int to ushort?
        /// </remarks>
        internal virtual int ElementId { get; }

        public virtual Type ElementType => null;

        /// <summary>
        /// Gets the children particles.
        /// </summary>
        public ReadOnlyList<ParticleConstraint> ChildrenParticles => _children;

        /// <summary>
        /// Gets a ParticleValidator for this particle constraint.
        /// </summary>
        internal virtual IParticleValidator ParticleValidator => null;

        public void Add(ParticleConstraint constraint)
        {
            if (_children is null)
            {
                _children = new List<ParticleConstraint>();
            }

            _children.Add(constraint);
        }

        /// <summary>
        /// Test whether this is a simple particle - the particle contains only elements as children.
        /// </summary>
        /// <returns></returns>
        internal bool IsSimple()
        {
            bool isSimple = true;

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

            return isSimple;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is ParticleConstraint p)
            {
                var parent = ParticleType == p.ParticleType
                    && MinOccurs == p.MinOccurs
                    && MaxOccurs == p.MaxOccurs
                    && ElementId == p.ElementId
                    && ChildrenParticles.Length == p.ChildrenParticles.Length;

                if (!parent)
                {
                    return false;
                }

                if (ChildrenParticles.Length != p.ChildrenParticles.Length)
                {
                    return false;
                }

                for (int i = 0; i < ChildrenParticles.Length; i++)
                {
                    if (!ChildrenParticles[i].Equals(p.ChildrenParticles[i]))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return new
            {
                ParticleType,
                MinOccurs,
                MaxOccurs,
                ElementId,
                ChildrenParticles.Length,
            }.GetHashCode();
        }

        IEnumerator<ParticleConstraint> IEnumerable<ParticleConstraint>.GetEnumerator() => ChildrenParticles.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ChildrenParticles.GetEnumerator();
    }
}
