// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Schema;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework
{
    internal class CompiledParticle : IComparer<OpenXmlElement>
    {
        private readonly Lazy<LookupItem[]> _lookup;

        public CompiledParticle(ParticleConstraint? particle)
        {
            Particle = particle;

            if (particle is null)
            {
                _lookup = new Lazy<LookupItem[]>(() => Cached.Array<LookupItem>(), true);
            }
            else
            {
                _lookup = new Lazy<LookupItem[]>(() => ParticleCompiler.Compile(particle), true);
            }
        }

        public ReadOnlyArray<LookupItem> Lookup => _lookup.Value;

        public ParticleConstraint? Particle { get; }

        public ParticlePath? Find(OpenXmlElement? obj)
            => Find(obj?.QName);

        public ParticlePath? Find(OpenXmlQualifiedName? qname)
        {
            if (qname is null)
            {
                return null;
            }

            foreach (var (q, p) in Lookup)
            {
                if (q == qname)
                {
                    return p;
                }
            }

            return null;
        }

        public int Compare(OpenXmlElement? x, OpenXmlElement? y)
        {
            var xPath = Find(x?.QName);
            var yPath = Find(y?.QName);

            if (xPath is null && yPath is null)
            {
                return 0;
            }

            if (xPath is null)
            {
                return -1;
            }

            if (yPath is null)
            {
                return 1;
            }

            return xPath.CompareTo(yPath);
        }
    }
}
