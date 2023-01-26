﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System.Diagnostics;
using System.Linq;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal class RelationshipTypeConstraint : SemanticConstraint
    {
        private readonly OpenXmlQualifiedName _attribute;
        private readonly string _type;

        public RelationshipTypeConstraint(OpenXmlQualifiedName attribute, string type)
            : base(SemanticValidationLevel.Part)
        {
            Debug.Assert(!string.IsNullOrEmpty(type));

            _attribute = attribute;
            _type = type;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1851:Possible multiple enumerations of 'IEnumerable' collection", Justification = "https://github.com/dotnet/Open-XML-SDK/issues/1325")]
        public override ValidationErrorInfo? ValidateCore(ValidationContext context)
        {
            var current = context.Stack.Current;

            if (current is null)
            {
                return null;
            }

            var element = current.Element;

            if (element is null)
            {
                return null;
            }

            if (!TryFindAttribute(element, _attribute, out var attribute))
            {
                return null;
            }

            if (attribute.Value is null || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            var actualType = _type;

            if (current.Part is null)
            {
                return null;
            }

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
                    attribute.Property.QName,
                    _type),
            };
        }
    }
}
