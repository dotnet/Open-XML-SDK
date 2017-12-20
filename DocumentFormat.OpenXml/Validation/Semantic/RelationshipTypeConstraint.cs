// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
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
            OpenXmlSimpleType attributeValue = context.Element.Attributes[_attribute];

            if (attributeValue == null || string.IsNullOrEmpty(attributeValue.InnerText))
            {
                return null;
            }

            string actualType = _type;

            IEnumerable<ExternalRelationship> rels = context.Part.ExternalRelationships.Where(r => r.Id == attributeValue.InnerText);

            if (rels.Count() == 0)
            {
                IEnumerable<IdPartPair> pairs = context.Part.Parts.Where(p => p.RelationshipId == attributeValue.InnerText);
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
                Description = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sem_IncorrectRelationshipType,
                                            actualType, GetAttributeQualifiedName(context.Element, _attribute), this._type)
            };
        }
    }
}
