// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
    internal class RelationshipExistConstraint : SemanticConstraint
    {
        private byte _rIdAttribute;

        public RelationshipExistConstraint(byte rIdAttribute)
            : base(SemanticValidationLevel.Part)
        {
            _rIdAttribute = rIdAttribute;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            OpenXmlSimpleType attributeValue = context.Element.Attributes[_rIdAttribute];

            //if the attribute is omited, semantic validation will do nothing 
            if (attributeValue == null || string.IsNullOrEmpty(attributeValue.InnerText))
            {
                return null;
            }

            if (context.Part.PackagePart.RelationshipExists(attributeValue.InnerText))
            {
                return null;
            }
            else
            {
                string errorDescription = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sem_InvalidRelationshipId,
                                                        attributeValue, GetAttributeQualifiedName(context.Element, _rIdAttribute));

                return new ValidationErrorInfo()
                {
                    Id = "Sem_InvalidRelationshipId",
                    ErrorType = ValidationErrorType.Semantic,
                    Node = context.Element,
                    Description = errorDescription
                };
            }
        }
    }
}