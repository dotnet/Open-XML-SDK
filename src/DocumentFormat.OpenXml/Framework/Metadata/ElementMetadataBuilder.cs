// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class ElementMetadataBuilder : ValidatorBuilder
    {
        private List<IMetadataBuilder<AttributeMetadata>> _attributes;
        private byte _nsId;
        private string _localName;

        public ElementMetadataBuilder<TElement> AddElement<TElement>()
            where TElement : OpenXmlElement
        {
            return new ElementMetadataBuilder<TElement>(this);
        }

        public void SetSchema(string ns, string localName)
            => SetSchema(NamespaceIdMap.GetNamespaceId(ns), localName);

        public void SetSchema(byte nsId, string localName)
        {
            _nsId = nsId;
            _localName = localName;
        }

        public FileFormatVersions Availability { get; set; } = FileFormatVersions.Office2007;

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
            var schema = _localName is null ? null : new SchemaAttrAttribute(_nsId, _localName);

            return new ElementMetadata(BuildAttributes(), new ValidatorCollection(ToArray()), Availability, schema);
        }

        private AttributeMetadata[] BuildAttributes()
        {
            if (_attributes is null)
            {
                return default;
            }

            var attributes = new AttributeMetadata[_attributes.Count];

            for (int i = 0; i < attributes.Length; i++)
            {
                attributes[i] = _attributes[i].Build();
            }

            return attributes;
        }
    }
}
