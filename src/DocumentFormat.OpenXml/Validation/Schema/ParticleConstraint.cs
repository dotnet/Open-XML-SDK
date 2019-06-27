// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// A constraint data item for complex type.
    /// The ParticleType, MinOccurs, MaxOccurs means the constraint of this particle in the parent.
    /// </summary>
    internal abstract class ParticleConstraint
    {
        /// <summary>
        /// Initializes a new instance of the ParticleConstraint.
        /// </summary>
        protected ParticleConstraint(ParticleType type, int minOccurs, int maxOccurs, FileFormatVersions version)
        {
            ParticleType = type;
            MinOccurs = minOccurs;
            MaxOccurs = maxOccurs;
            Version = version;
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

        public FileFormatVersions Version { get; }

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
        /// Gets a ParticleValidator for this particle constraint.
        /// </summary>
        internal virtual IParticleValidator ParticleValidator => null;

        public virtual ParticleConstraint Build(FileFormatVersions version)
            => version.AtLeast(Version) ? this : null;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is ParticleConstraint other)
            {
                return ParticleType == other.ParticleType
                    && MinOccurs == other.MinOccurs
                    && MaxOccurs == other.MaxOccurs;
            }

            return false;
        }

        public override int GetHashCode() => HashCode.Combine(ParticleType, MinOccurs, MaxOccurs);
    }
}
