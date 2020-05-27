// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class ElementMetadata
    {
        private static readonly ConcurrentDictionary<Type, ElementMetadata> _lookup = new ConcurrentDictionary<Type, ElementMetadata>(new[]
        {
            new KeyValuePair<Type, ElementMetadata>(typeof(OpenXmlUnknownElement), new ElementMetadata()),
            new KeyValuePair<Type, ElementMetadata>(typeof(OpenXmlMiscNode), new ElementMetadata()),
        });

        private readonly ElementLookup _children;

        public ElementMetadata(ReadOnlyArray<AttributeMetadata> attributes, ValidatorCollection validators, FileFormatVersions version, SchemaAttrAttribute schema, ElementLookup lookup)
        {
            Attributes = attributes;
            Validators = validators;
            Availability = version;
            Schema = schema;
            _children = lookup;
        }

        private ElementMetadata()
        {
        }

        public ReadOnlyArray<AttributeMetadata> Attributes { get; }

        public ElementLookup Children => _children ?? ElementLookup.Empty;

        public ValidatorCollection Validators { get; }

        public FileFormatVersions Availability { get; }

        public SchemaAttrAttribute Schema { get; }

        public static ElementMetadata Create(OpenXmlElement element)
        {
            var type = element.GetType();

            // Use TryGetValue first for the common case of already existing types to limit number of allocations
            if (_lookup.TryGetValue(type, out var result))
            {
                return result;
            }

            var metadata = CreateInternal(element);

            _lookup.TryAdd(type, metadata);

            return metadata;
        }

        public static ElementMetadata Create<TElement>()
            where TElement : OpenXmlElement, new()
            => _lookup.GetOrAdd(typeof(TElement), t => CreateInternal(new TElement()));

        private static ElementMetadata CreateInternal(OpenXmlElement element)
        {
            var builder = new ElementMetadataBuilder();

            element.ConfigureMetadata(builder);

            return builder.Build();
        }
    }
}
