// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;
using System.Linq;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal class RelationshipTypeConstraint : SemanticConstraint
    {
        private readonly byte _attribute;
        private readonly string _type;

        public RelationshipTypeConstraint(byte attribute, string type)
            : base(SemanticValidationLevel.Part)
        {
            Debug.Assert(!string.IsNullOrEmpty(type));

            _attribute = attribute;
            _type = type;
        }

        public override ValidationErrorInfo ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current.Element;
            var attribute = element.ParsedState.Attributes[_attribute];

            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            var actualType = _type;
            var current = context.Stack.Current;
            var rels = current.Part.ExternalRelationships.Where(r => r.Id == attribute.Value.InnerText);

            if (!rels.Any())
            {
                var pairs = current.Part.Parts.Where(p => p.RelationshipId == attribute.Value.InnerText);

                if (pairs.Any())
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
                Node = element,
                Description = SR.Format(
                    ValidationResources.Sem_IncorrectRelationshipType,
                    actualType,
                    GetAttributeQualifiedName(element, _attribute),
                    _type),
            };
        }
    }
}
