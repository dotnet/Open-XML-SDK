// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework
{
    internal class UnionValidator : IValidator
    {
        private readonly ReadOnlyArray<IValidator> _others;

        public UnionValidator(ReadOnlyArray<IValidator> others, byte id)
        {
            _others = others;
            Id = id;
        }

        public byte Id { get; }

        public IEnumerable<IValidator> Validators => _others;

        public void Validate(ValidationContext context)
        {
            var errorRaised = false;

            using (context.Stack.Push(_ => errorRaised = true))
            {
                foreach (var other in _others)
                {
                    other.Validate(context);

                    if (!errorRaised)
                    {
                        return;
                    }

                    errorRaised = false;
                }
            }

            var current = context.Stack.Current;

            context.CreateError(
                id: "Sch_AttributeUnionFailedEx",
                description: SR.Format(ValidationResources.Sch_AttributeUnionFailedEx, current.Property.GetQName(), current.Value),
                errorType: ValidationErrorType.Schema);
        }
    }
}
