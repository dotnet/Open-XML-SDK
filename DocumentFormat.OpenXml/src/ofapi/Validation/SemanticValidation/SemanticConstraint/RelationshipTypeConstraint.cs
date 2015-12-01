// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
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
