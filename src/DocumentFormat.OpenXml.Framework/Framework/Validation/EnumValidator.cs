// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Framework
{
    internal sealed class EnumValidator : VersionedValidator
    {
        public static IValidator Instance { get; } = new EnumValidator();

        protected override void ValidateVersion(ValidationContext context)
        {
            var current = context.Stack.Current;

            if (current is null || current.Value is null || current.Property is null)
            {
                return;
            }

            if (!current.Value.IsValid)
            {
                var errorMessageResourceId = current.IsAttribute ? "Sch_AttributeValueDataTypeDetailed" : "Sch_ElementValueDataTypeDetailed";
                var message = current.IsAttribute ? ValidationResources.Sch_AttributeValueDataTypeDetailed : ValidationResources.Sch_ElementValueDataTypeDetailed;

                if (!current.Value.IsEnum && string.IsNullOrEmpty(current.Value.InnerText))
                {
                    context.CreateError(
                        id: errorMessageResourceId,
                        description: SR.Format(message, current.Property.QName, current.Value.InnerText, ValidationResources.Sch_EmptyAttributeValue),
                        errorType: ValidationErrorType.Schema);
                }
                else
                {
                    context.CreateError(
                        id: errorMessageResourceId,
                        description: SR.Format(message, current.Property.QName, current.Value, ValidationResources.Sch_EnumerationConstraintFailed),
                        errorType: ValidationErrorType.Schema);
                }
            }
        }
    }
}
