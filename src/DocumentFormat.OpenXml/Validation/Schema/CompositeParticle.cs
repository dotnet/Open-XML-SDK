// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle constraint for sequence, choice, all, and group.
    /// </summary>
    [DebuggerDisplay("ParticleType={ParticleType}")]
    internal class CompositeParticle : ParticleConstraint
    {
        private IParticleValidator? _particleValidator;

        /// <summary>
        /// Initializes a new instance of the CompositeParticle.
        /// </summary>
        public CompositeParticle(ParticleType particleType, int minOccurs, int maxOccurs, bool requireFilter = false, FileFormatVersions version = FileFormatVersions.Office2007, in ReadOnlyArray<ParticleConstraint> children = default)
            : base(particleType, minOccurs, maxOccurs, version)
        {
            ChildrenParticles = children;
            RequireFilter = requireFilter;
        }

        /// <summary>
        /// Gets the children particles.
        /// </summary>
        public ReadOnlyArray<ParticleConstraint> ChildrenParticles { get; }

        public bool RequireFilter { get; }

        public override ParticleConstraint? Build(FileFormatVersions version)
        {
            if (!version.AtLeast(Version))
            {
                return null;
            }

            var builder = new Builder(ParticleType, MinOccurs, MaxOccurs, requireFilter: RequireFilter, Version, filterVersion: true);

            foreach (var child in ChildrenParticles)
            {
                builder.Add(child.Build(version));
            }

            // We can potentially limit creation of a clone to times when it is required; ie, when there
            // is a version specific particle.
            return builder;
        }

        /// <inheritdoc/>
        internal override IParticleValidator ParticleValidator
        {
            get
            {
                if (_particleValidator is null)
                {
                    _particleValidator = CreateParticleValidator();
                }

                return _particleValidator;
            }
        }

        private ParticleValidator CreateParticleValidator()
            => ParticleType switch
            {
                ParticleType.All => new AllParticleValidator(this),
                ParticleType.Choice => new ChoiceParticleValidator(this),
                ParticleType.Sequence => new SequenceParticleValidator(this),
                ParticleType.Group => new GroupParticleValidator(this),
                _ => throw new InvalidOperationException(),
            };

        public override bool Equals(object? obj)
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

        public struct Builder : IEnumerable<ParticleConstraint>
        {
            private readonly ParticleType _particleType;
            private readonly int _minOccurs;
            private readonly int _maxOccurs;
            private readonly bool _requireFilter;
            private readonly FileFormatVersions _version;
            private readonly bool _filterVersion;

            private List<ParticleConstraint>? _children;

            public Builder(ParticleType particleType, int minOccurs, int maxOccurs, bool requireFilter = false, FileFormatVersions version = FileFormatVersions.Office2007, bool filterVersion = false)
            {
                _particleType = particleType;
                _minOccurs = minOccurs;
                _maxOccurs = maxOccurs;
                _requireFilter = requireFilter;
                _version = version;
                _filterVersion = filterVersion;

                _children = null;
            }

            public void Add(ParticleConstraint? constraint)
            {
                if (constraint is null)
                {
                    return;
                }
                else if (_children is null)
                {
                    _children = new List<ParticleConstraint>();
                }
                else if (_filterVersion)
                {
                    for (int i = 0; i < _children.Count; i++)
                    {
                        var other = _children[i];

                        if (Equals(other, constraint) && constraint.Version > other.Version)
                        {
                            _children.RemoveAt(i);
                            i--;
                        }
                    }
                }

                _children.Add(constraint);
            }

            public IEnumerator<ParticleConstraint> GetEnumerator() => _children?.GetEnumerator() ?? Enumerable.Empty<ParticleConstraint>().GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            public CompositeParticle Build()
                => new CompositeParticle(_particleType, _minOccurs, _maxOccurs, _requireFilter, _version, _children?.ToArray());

            public static implicit operator CompositeParticle(Builder builder)
                => builder.Build();

            public static implicit operator ParticleConstraint(Builder builder)
                => builder.Build();

            private bool Equals(ParticleConstraint constraint1, ParticleConstraint constraint2)
            {
                if (constraint1 is ElementParticle element1 && constraint2 is ElementParticle element2)
                {
                    return element1.ElementType == element2.ElementType;
                }
                else if (_requireFilter && constraint1.ParticleType == ParticleType.Group && constraint2.ParticleType == ParticleType.Group)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
