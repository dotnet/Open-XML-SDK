// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Framework
{
    internal class ListValidator : IOpenXmlSimpleTypeValidator
    {
        public static IOpenXmlSimpleTypeValidator Instance { get; } = new ListValidator();

        private ListValidator()
        {
        }

        public void Validate(ValidatorContext context)
        {
            var value = context.Value;

            if (value is null)
            {
                return;
            }

            if (!value.IsValid)
            {
                var id = context.IsAttribute ? "Sch_AttributeValueDataTypeDetailed" : "Sch_ElementValueDataTypeDetailed";
                var description = context.IsAttribute ? ValidationResources.Sch_AttributeValueDataTypeDetailed : ValidationResources.Sch_ElementValueDataTypeDetailed;

                if (string.IsNullOrEmpty(value.InnerText))
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(description, context.QName, context.Value.InnerText, context.IsAttribute ? ValidationResources.Sch_EmptyAttributeValue : ValidationResources.Sch_EmptyElementValue),
                        errorType: ValidationErrorType.Schema);
                }
                else
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(description, context.QName, context.Value.InnerText, string.Empty),
                        errorType: ValidationErrorType.Schema);
                }
            }
        }
    }
}
