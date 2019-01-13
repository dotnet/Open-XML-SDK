// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal class RelationshipTypeConstraint : SemanticConstraint
    {
        private byte _attribute;
        private string _type;

        public RelationshipTypeConstraint(byte attribute, string type)
            : base(SemanticValidationLevel.Part)
        {
            Debug.Assert(!string.IsNullOrEmpty(type));

            _attribute = attribute;
            _type = type;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            var attribute = context.Element.Attributes[_attribute];

            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            string actualType = _type;

            IEnumerable<ExternalRelationship> rels = context.Part.ExternalRelationships.Where(r => r.Id == attribute.Value.InnerText);

            if (rels.Count() == 0)
            {
                IEnumerable<IdPartPair> pairs = context.Part.Parts.Where(p => p.RelationshipId == attribute.Value.InnerText);

                if (pairs.Count() != 0)
                {
                    Debug.Assert(pairs.Count() == 1);
                    actualType = pairs.First().OpenXmlPart.RelationshipType;
                }
            }
            else
            {
                Debug.Assert(rels.Count() == 1);
                actualType = rels.First().RelationshipType;
            }

            if (actualType == _type)
            {
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_IncorrectRelationshipType",
                ErrorType = ValidationErrorType.Semantic,
                Node = context.Element,
                Description = SR.Format(
                    ValidationResources.Sem_IncorrectRelationshipType,
                    actualType,
                    GetAttributeQualifiedName(context.Element, _attribute),
                    _type),
            };
        }
    }
}
