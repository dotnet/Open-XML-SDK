// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework
{
    internal class UnionValidator : IOpenXmlSimpleTypeValidator
    {
        private readonly List<IOpenXmlSimpleTypeValidator> _others;

        public UnionValidator(List<IOpenXmlSimpleTypeValidator> others, byte id)
        {
            _others = others;
            Id = id;
        }

        public byte Id { get; }

        public IEnumerable<IOpenXmlSimpleTypeValidator> Validators => _others;

        public void Validate(ValidatorContext context)
        {
            var errorRaised = false;
            var inner = context.With(_ => errorRaised = true);

            foreach (var other in _others)
            {
                other.Validate(inner);

                if (!errorRaised)
                {
                    return;
                }

                errorRaised = false;
            }

            context.CreateError(
                id: "Sch_AttributeUnionFailedEx",
                description: SR.Format(ValidationResources.Sch_AttributeUnionFailedEx, context.QName, context.Value),
                errorType: ValidationErrorType.Schema);
        }
    }
}
