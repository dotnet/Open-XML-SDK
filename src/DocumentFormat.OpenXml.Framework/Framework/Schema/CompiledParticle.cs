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
            => Find(obj?.Metadata.Type);

        public ParticlePath? Find(OpenXmlSchemaType? type)
        {
            if (type is null)
            {
                return null;
            }

            foreach (var (t, p) in Lookup)
            {
                if (t == type)
                {
                    return p;
                }
            }

            return null;
        }

        public int Compare(OpenXmlElement? x, OpenXmlElement? y)
        {
            var xPath = Find(x?.Metadata.Type);
            var yPath = Find(y?.Metadata.Type);

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
