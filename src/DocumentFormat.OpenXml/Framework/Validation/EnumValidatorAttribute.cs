﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System;

namespace DocumentFormat.OpenXml.Framework
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    internal sealed class EnumValidatorAttribute : VersionedValidatorAttribute
    {
        protected override void ValidateVersion(ValidationContext context)
        {
            var current = context.Stack.Current;
            var value = GetValue(current);

            if (value != null && !value.IsValid)
            {
                var errorMessageResourceId = current.IsAttribute ? "Sch_AttributeValueDataTypeDetailed" : "Sch_ElementValueDataTypeDetailed";
                var message = current.IsAttribute ? ValidationResources.Sch_AttributeValueDataTypeDetailed : ValidationResources.Sch_ElementValueDataTypeDetailed;

                if (!value.IsEnum && string.IsNullOrEmpty(value.InnerText))
                {
                    context.CreateError(
                        id: errorMessageResourceId,
                        description: SR.Format(message, current.Property.GetQName(), current.Value.InnerText, ValidationResources.Sch_EmptyAttributeValue),
                        errorType: ValidationErrorType.Schema);
                }
                else
                {
                    context.CreateError(
                        id: errorMessageResourceId,
                        description: SR.Format(message, current.Property.GetQName(), value, ValidationResources.Sch_EnumerationConstraintFailed),
                        errorType: ValidationErrorType.Schema);
                }
            }
        }
    }
}
