// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using DocumentFormat.OpenXml.Validation.Schema;
using System.Collections.Concurrent;

namespace DocumentFormat.OpenXml.Validation
{
    internal class ValidationCache
    {
        private readonly ConcurrentDictionary<ParticleConstraint, ParticleConstraint?> _constraints;

        public ValidationCache(FileFormatVersions version)
        {
            Version = version;

            _constraints = new ConcurrentDictionary<ParticleConstraint, ParticleConstraint?>();
        }

        public FileFormatVersions Version { get; }

        public ParticleConstraint? GetConstraint(OpenXmlElement element)
        {
            var constraint = element.Metadata.Particle?.Particle;

            if (constraint is null)
            {
                return null;
            }

            if (_constraints.TryGetValue(constraint, out var result))
            {
                return result;
            }

            var built = constraint.Build(Version);

            if (built == constraint)
            {
                return constraint;
            }

            _constraints.TryAdd(constraint, built);

            return built;
        }
    }
}
