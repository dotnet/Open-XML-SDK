// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace DocumentFormat.OpenXml.Framework
{
    internal readonly struct ValidatorCollection : IEnumerable<IOpenXmlSimpleTypeValidator>
    {
        private readonly ReadOnlyArray<IOpenXmlSimpleTypeValidator> _validators;

        public ValidatorCollection(Type type)
        {
            _validators = Build(type.GetTypeInfo().GetCustomAttributes(true), null);
        }

        public ValidatorCollection(PropertyInfo property)
        {
            _validators = Build(property.GetCustomAttributes(true), property.PropertyType);
        }

        public ReadOnlyArray<IOpenXmlSimpleTypeValidator>.Enumerator GetEnumerator() => _validators.GetEnumerator();

        IEnumerator<IOpenXmlSimpleTypeValidator> IEnumerable<IOpenXmlSimpleTypeValidator>.GetEnumerator() => GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private static IOpenXmlSimpleTypeValidator[] Build(IEnumerable<object> attributes, Type type)
        {
            var builder = new ValidatorCollectionBuilder();

            foreach (var attribute in attributes)
            {
                if (attribute is IOpenXmlSimpleTypeValidator validator)
                {
                    builder.Add(validator);
                }
            }

            builder.AddDefaultValidator(type);

            return builder.Build();
        }
    }
}
