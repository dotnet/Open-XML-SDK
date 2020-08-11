// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Framework
{
    internal class SimpleTypeValidator<TSimpleType> : IValidator
        where TSimpleType : OpenXmlSimpleType, new()
    {
        private readonly IValidator _other;

        public SimpleTypeValidator(IValidator other)
        {
            _other = other;
        }

        public void Validate(ValidationContext context)
        {
            if (TryTransformValue(context.Stack.Current, out var updated))
            {
                using (context.Stack.Push(updated))
                {
                    _other.Validate(context);
                }
            }
            else
            {
                _other.Validate(context);
            }
        }

        private static bool TryTransformValue(in ValidationElement current, out OpenXmlSimpleType type)
        {
            var input = current.Value;

            if (input is null)
            {
                type = null;
                return false;
            }

            if (input is TSimpleType)
            {
                type = null;
                return false;
            }

            type = new TSimpleType
            {
                InnerText = input.InnerText,
            };

            return true;
        }
    }
}
