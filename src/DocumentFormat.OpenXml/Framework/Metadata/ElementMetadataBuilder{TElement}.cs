// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class ElementMetadataBuilder<TElement> : IMetadataBuilder<AttributeMetadata[]>
        where TElement : OpenXmlElement
    {
        private List<IMetadataBuilder<AttributeMetadata>> _attributes;
        private FileFormatVersions _version = FileFormatVersions.Office2007;

        public ElementMetadataBuilder<TElement> SetVersion(FileFormatVersions version)
        {
            _version = version;
            return this;
        }

        public AttributeMetadata[] Build()
        {
            if (_attributes is null)
            {
                return Array.Empty<AttributeMetadata>();
            }

            var result = new AttributeMetadata[_attributes.Count];

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
                _attributes = new List<IMetadataBuilder<AttributeMetadata>>();
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
