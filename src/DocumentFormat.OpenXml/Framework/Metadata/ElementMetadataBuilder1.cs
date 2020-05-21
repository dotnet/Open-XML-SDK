// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class ElementMetadataBuilder<TElement> : IElementMetadataBuilder
    {
        private List<IAttributeMetadataBuilder> _attributes;

        public static ElementMetadataBuilder<TElement> Create()
        {
            return new ElementMetadataBuilder<TElement>();
        }

        public ElementProperty<OpenXmlSimpleType>[] Build()
        {
            if (_attributes is null)
            {
                return Array.Empty<ElementProperty<OpenXmlSimpleType>>();
            }

            var result = new ElementProperty<OpenXmlSimpleType>[_attributes.Count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = _attributes[i].Build();
            }

            return result;
        }

        public ElementMetadataBuilder<TElement> AddAttribute<TSimpleType>(byte nsId, string localName, Expression<Func<TElement, TSimpleType>> expression, Action<AttributeMetadataBuilder<TSimpleType>> action = null)
            where TSimpleType : OpenXmlSimpleType, new()
        {
            if (_attributes is null)
            {
                _attributes = new List<IAttributeMetadataBuilder>(4);
            }

            if (expression.Body is MemberExpression member)
            {
                var builder = new AttributeMetadataBuilder<TSimpleType>(nsId, localName, member.Member.Name);

                action?.Invoke(builder);

                _attributes.Add(builder);

                return this;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
