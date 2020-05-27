// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class ElementMetadataBuilder : ValidatorBuilder
    {
        private static readonly Lazy<ElementLookup> _lazy = new Lazy<ElementLookup>(() => ElementLookup.Empty, true);

        private List<IMetadataBuilder<AttributeMetadata>> _attributes;
        private HashSet<IMetadataBuilder<ElementLookup.ElementChild>> _children;
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

        public void AddChild<T>()
            where T : OpenXmlElement, new()
        {
            if (_children is null)
            {
                _children = new HashSet<IMetadataBuilder<ElementLookup.ElementChild>>();
            }

            _children.Add(new KnownChild<T>());
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
            var lookup = _children is null ? _lazy : new Lazy<ElementLookup>(() => new ElementLookup(_children.Select(c => c.Build())), true);

            return new ElementMetadata(BuildAttributes(), new ValidatorCollection(ToArray()), Availability, schema, lookup);
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

        private class KnownChild<T> : IMetadataBuilder<ElementLookup.ElementChild>
            where T : OpenXmlElement, new()
        {
            public ElementLookup.ElementChild Build() => new ElementChild2(ElementMetadata.Create<T>());

            private class ElementChild2 : ElementLookup.ElementChild
            {
                public ElementChild2(ElementMetadata metadata)
                    : base(typeof(T), metadata.Schema.NamespaceId, metadata.Schema.Tag)
                {
                }

                public override OpenXmlElement Create() => new T();
            }
        }
    }
}
