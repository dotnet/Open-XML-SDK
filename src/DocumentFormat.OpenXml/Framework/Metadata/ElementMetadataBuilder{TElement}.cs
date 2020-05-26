// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class ElementMetadataBuilder<TElement> : ValidatorBuilder
        where TElement : OpenXmlElement
    {
        private readonly ElementMetadataBuilder _builder;

        public ElementMetadataBuilder(ElementMetadataBuilder builder)
        {
            _builder = builder;
        }

        public ElementMetadataBuilder<TElement> AddAttribute<TSimpleType>(byte nsId, string localName, Expression<Func<TElement, TSimpleType>> expression, Action<AttributeMetadataBuilder<TSimpleType>> action = null)
            where TSimpleType : OpenXmlSimpleType, new()
        {
            if (expression.Body is MemberExpression member)
            {
                var builder = new AttributeMetadataBuilder<TSimpleType>(nsId, localName, member.Member.Name);

                action?.Invoke(builder);

                _builder.Add(builder);

                return this;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
