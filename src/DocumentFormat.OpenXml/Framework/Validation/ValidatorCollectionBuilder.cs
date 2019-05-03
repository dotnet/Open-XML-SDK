// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace DocumentFormat.OpenXml.Framework
{
    internal struct ValidatorCollectionBuilder
    {
        private static readonly IOpenXmlSimpleTypeValidator StringValidator = new StringValidatorAttribute();
        private static readonly IOpenXmlSimpleTypeValidator NumberValidator = new NumberValidatorAttribute();
        private static readonly IOpenXmlSimpleTypeValidator EnumValidator = new EnumValidatorAttribute();

        private Dictionary<byte, List<IOpenXmlSimpleTypeValidator>> _union;
        private List<IOpenXmlSimpleTypeValidator> _validators;

        public void Add(IOpenXmlSimpleTypeValidator validator)
        {
            if (validator is IUnionValidator union && union.UnionId.HasValue)
            {
                AddUnion(union);
            }
            else
            {
                if (_validators is null)
                {
                    _validators = new List<IOpenXmlSimpleTypeValidator>();
                }

                _validators.Add(validator);
            }
        }

        private void AddUnion(IUnionValidator attribute)
        {
            if (_union is null)
            {
                _union = new Dictionary<byte, List<IOpenXmlSimpleTypeValidator>>();
            }

            if (_union.TryGetValue(attribute.UnionId.Value, out var entry))
            {
                entry.Add(attribute);
            }
            else
            {
                _union.Add(attribute.UnionId.Value, new List<IOpenXmlSimpleTypeValidator> { attribute });
            }
        }

        public void AddDefaultValidator(Type type)
        {
            if (type != null && typeof(OpenXmlSimpleType).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
            {
                if (typeof(StringValue).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
                {
                    Add(StringValidator);
                }
                else if (typeof(OnOffValue) == type || typeof(TrueFalseBlankValue) == type || IsEnum(type))
                {
                    Add(EnumValidator);
                }
                else if (typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
                {
                    Add(ListValidator.Instance);
                }
                else
                {
                    Add(NumberValidator);
                }
            }
        }

        private static bool IsEnum(Type type)
        {
            return type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(EnumValue<>);
        }

        public IOpenXmlSimpleTypeValidator[] Build()
        {
            var unionCount = _union?.Count ?? 0;
            var validatorCount = _validators?.Count ?? 0;
            var count = unionCount + validatorCount;

            if (count == 0)
            {
                return Cached.Array<IOpenXmlSimpleTypeValidator>();
            }

            var result = new IOpenXmlSimpleTypeValidator[count];

            if (_validators != null)
            {
                _validators.CopyTo(result);
            }

            if (_union != null)
            {
                var i = validatorCount;

                foreach (var item in _union)
                {
                    result[i++] = new UnionValidator(item.Value, item.Key);
                }
            }

            Array.Sort(result, ValidatorComparer.Instance);

            return result;
        }
    }
}
