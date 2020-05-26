// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class ElementMetadataBuilder
    {
        private List<IMetadataBuilder<AttributeMetadata>> _attributes;

        public ElementMetadataBuilder<TElement> AddElement<TElement>()
            where TElement : OpenXmlElement
        {
            return new ElementMetadataBuilder<TElement>(this);
        }

        public void Add(IMetadataBuilder<AttributeMetadata> builder)
        {
            if (_attributes is null)
            {
                _attributes = new List<IMetadataBuilder<AttributeMetadata>>();
            }

            _attributes.Add(builder);
        }

        public ElementMetadata Build()
        {
            if (_attributes is null)
            {
                return new ElementMetadata(null);
            }

            var attributes = new AttributeMetadata[_attributes.Count];

            for (int i = 0; i < attributes.Length; i++)
            {
                attributes[i] = _attributes[i].Build();
            }

            return new ElementMetadata(attributes);
        }
    }
}
