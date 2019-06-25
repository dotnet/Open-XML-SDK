// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle constraint for sequence, choice, all, and group.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [DebuggerDisplay("ParticleType={ParticleType}")]
    internal class CompositeParticle : ParticleConstraint, IEnumerable<ParticleConstraint>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ParticleConstraint> _childrenParticles;

        private IParticleValidator _particleValidator;

        /// <summary>
        /// Initializes a new instance of the CompositeParticle.
        /// </summary>
        internal CompositeParticle(ParticleType particleType)
            : base(particleType)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CompositeParticle.
        /// </summary>
        internal CompositeParticle(ParticleType particleType, decimal minOccurs, decimal maxOccurs)
            : base(particleType, minOccurs, maxOccurs)
        {
        }

        public void Add(ParticleConstraint constraint)
        {
            if (_childrenParticles is null)
            {
                _childrenParticles = new List<ParticleConstraint>();
            }

            _childrenParticles.Add(constraint);
        }

        IEnumerator<ParticleConstraint> IEnumerable<ParticleConstraint>.GetEnumerator() => ChildrenParticles.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ChildrenParticles.GetEnumerator();

        /// <inheritdoc/>
        public override ReadOnlyList<ParticleConstraint> ChildrenParticles => _childrenParticles;

        /// <inheritdoc/>
        internal override IParticleValidator ParticleValidator
        {
            get
            {
                if (_particleValidator == null)
                {
                    _particleValidator = Schema.ParticleValidator.CreateParticleValidator(this);
                }

                return _particleValidator;
            }
        }

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
