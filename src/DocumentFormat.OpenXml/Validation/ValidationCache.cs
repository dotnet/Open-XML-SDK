// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System.Collections.Concurrent;

namespace DocumentFormat.OpenXml.Validation
{
    internal class ValidationCache
    {
        private readonly ConcurrentDictionary<ParticleConstraint, ParticleConstraint> _constraints;
        private readonly ConcurrentDictionary<ApplicationType, DocumentValidator> _documentValidators;
        private readonly ConcurrentDictionary<ApplicationType, SemanticValidator> _semanticValidators;

        public ValidationCache(FileFormatVersions version)
        {
            Version = version;

            _constraints = new ConcurrentDictionary<ParticleConstraint, ParticleConstraint>();
            _documentValidators = new ConcurrentDictionary<ApplicationType, DocumentValidator>();
            _semanticValidators = new ConcurrentDictionary<ApplicationType, SemanticValidator>();
        }

        public FileFormatVersions Version { get; }

        public SchemaValidator SchemaValidator = new SchemaValidator();

        public SemanticValidator GetOrCreateSemanticValidator(ApplicationType appType)
            => _semanticValidators.GetOrAdd(appType, type => new SemanticValidator(Version, type));

        public DocumentValidator GetOrCreateDocumentValidator(ApplicationType appType)
            => _documentValidators.GetOrAdd(appType, type => new DocumentValidator(SchemaValidator, GetOrCreateSemanticValidator(type), this));

        public ParticleConstraint GetConstraint(OpenXmlElement element)
        {
            var constraint = element.ParticleConstraint;

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
