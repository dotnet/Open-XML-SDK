// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle constraint for sequence, choice, all, and group.
    /// </summary>
    [DebuggerDisplay("ParticleType={ParticleType}")]
    internal class CompositeParticle : ParticleConstraint, IEnumerable<ParticleConstraint>
    {
        private IParticleValidator _particleValidator;
        private List<ParticleConstraint> _children;

        /// <summary>
        /// Initializes a new instance of the CompositeParticle.
        /// </summary>
        internal CompositeParticle(ParticleType particleType, int minOccurs, int maxOccurs, FileFormatVersions version = FileFormatVersions.Office2007)
            : base(particleType, minOccurs, maxOccurs, version)
        {
        }

        /// <summary>
        /// Gets the children particles.
        /// </summary>
        public ReadOnlyList<ParticleConstraint> ChildrenParticles => _children;

        public override ParticleConstraint Build(FileFormatVersions version)
        {
            if (!version.AtLeast(Version))
            {
                return null;
            }

            // We can potentially limit creation of a clone to times when it is required; ie, when there
            // is a version specific particle.
            var clone = new CompositeParticle(ParticleType, MinOccurs, MaxOccurs, version);

            foreach (var child in ChildrenParticles)
            {
                clone.Add(child.Build(version));
            }

            return clone;
        }

        public void Add(ParticleConstraint constraint)
        {
            if (constraint is null)
            {
                return;
            }

            if (_children is null)
            {
                _children = new List<ParticleConstraint>();
            }

            _children.Add(constraint);
        }

        /// <inheritdoc/>
        internal override IParticleValidator ParticleValidator
        {
            get
            {
                if (_particleValidator == null)
                {
                    _particleValidator = CreateParticleValidator();
                }

                return _particleValidator;
            }
        }

        private ParticleValidator CreateParticleValidator()
        {
            switch (ParticleType)
            {
                case ParticleType.All:
                    return new AllParticleValidator(this);

                case ParticleType.Choice:
                    return new ChoiceParticleValidator(this);

                case ParticleType.Sequence:
                    return new SequenceParticleValidator(this);

                case ParticleType.Group:
                    return new GroupParticleValidator(this);

                //case ParticleType.Any:
                //    return new AnyParticleValidator(particleConstraint);
                case ParticleType.Element:
                default:
                    throw new InvalidOperationException();
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is CompositeParticle other)
            {
                if (!base.Equals(obj))
                {
                    return false;
                }

                if (ChildrenParticles.Length != other.ChildrenParticles.Length)
                {
                    return false;
                }

                for (int i = 0; i < ChildrenParticles.Length; i++)
                {
                    if (!ChildrenParticles[i].Equals(other.ChildrenParticles[i]))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), ChildrenParticles.Length);

        public IEnumerator<ParticleConstraint> GetEnumerator() => ChildrenParticles.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ChildrenParticles.GetEnumerator();

        //internal CompositeParticle NormalizeParticle(CompositeParticle compositeParticle)
        //{
        //    // TODO: do some normalization for the children.
        //    // 1). Remove the group when minOccurs=1 and maxOccurs=1 for the group.
        //    // 2). Merge sequence when minOccurs=1 and maxOccurs=1 for a child sequence.
        //    // 3). Merge choice when minOccurs=1 and maxOccurs=1 for a child choice.
        //    throw new NotImplementedException();
        //}
    }
}
