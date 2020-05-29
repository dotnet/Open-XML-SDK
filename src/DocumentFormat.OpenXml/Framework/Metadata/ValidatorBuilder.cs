// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class ValidatorBuilder
    {
        private readonly List<IOpenXmlSimpleTypeValidator> _validators = new List<IOpenXmlSimpleTypeValidator>();

        public void AddValidator(IOpenXmlSimpleTypeValidator validator)
        {
            if (validator is RequiredValidatorAttribute)
            {
                _validators.Insert(0, validator);
            }
            else
            {
                _validators.Add(validator);
            }
        }

        public void AddValidator<TSimpleType>(IOpenXmlSimpleTypeValidator validator)
            where TSimpleType : OpenXmlSimpleType, new()
        {
            var wrapped = new SimpleTypeValidator<TSimpleType>(validator);

            // If the original validator provided a qname, we need to ensure the wrapped one does too
            if (validator is INameProvider name)
            {
                var qname = name.QName ?? typeof(TSimpleType).GetSimpleTypeQualifiedName();
                _validators.Add(new NameProviderValidator(wrapped, qname));
            }
            else
            {
                _validators.Add(wrapped);
            }
        }

        public void InsertValidator(int index, IOpenXmlSimpleTypeValidator validator)
        {
            _validators.Insert(index, validator);
        }

        protected IOpenXmlSimpleTypeValidator[] ToArray() => _validators?.ToArray() ?? Cached.Array<IOpenXmlSimpleTypeValidator>();
    }
}
