// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Schema;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DocumentFormat.OpenXml.Framework
{
    internal class CompiledParticle : IComparer<OpenXmlElement>
    {
        private LookupItem[] _lookup;

        public CompiledParticle(ParticleConstraint particle)
        {
            Particle = particle;
        }

        public ReadOnlyArray<LookupItem> Lookup
        {
            get
            {
                if (_lookup is null)
                {
                    Interlocked.Exchange(ref _lookup, ParticleCompiler.Compile(Particle));
                }

                return _lookup;
            }
        }

        public ParticleConstraint Particle { get; }

        public ParticlePath Find<TElement>()
            where TElement : OpenXmlElement
            => GetPath(typeof(TElement));

        public ParticlePath Find(object obj)
            => GetPath(obj?.GetType());

        private ParticlePath GetPath(Type type)
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

        public int Compare(OpenXmlElement x, OpenXmlElement y)
        {
            var xPath = GetPath(x?.GetType());
            var yPath = GetPath(y?.GetType());

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
