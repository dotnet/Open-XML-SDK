// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using DocumentFormat.OpenXml.Validation;
using System.Xml;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
    internal class AttributeCannotOmitConstraint : SemanticConstraint
    {
        private byte _attribute;

        public AttributeCannotOmitConstraint(byte attribute)
            : base(SemanticValidationLevel.Element)
        {
            _attribute = attribute;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            if (context.Element.Attributes[_attribute] != null)
            {
                return null;
            }

            return new ValidationErrorInfo() 
            { 
                Id = "Sem_MissRequiredAttribute", 
                ErrorType = ValidationErrorType.Schema, 
                Node = context.Element,
                Description = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sch_MissRequiredAttribute, 
                                            GetAttributeQualifiedName(context.Element, _attribute)) 
            };
        }
    }
}
