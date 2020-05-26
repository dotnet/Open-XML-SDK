// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal readonly struct ElementMetadata
    {
        private static readonly ConcurrentDictionary<Type, ElementMetadata> _lookup = new ConcurrentDictionary<Type, ElementMetadata>(new[]
        {
            new KeyValuePair<Type, ElementMetadata>(typeof(OpenXmlUnknownElement), default),
            new KeyValuePair<Type, ElementMetadata>(typeof(OpenXmlMiscNode), default),
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

        public ReadOnlyArray<AttributeMetadata> Attributes { get; }

        public ElementLookup Children => _children ?? ElementLookup.Empty;

        public ValidatorCollection Validators { get; }

        public FileFormatVersions Availability { get; }

        public SchemaAttrAttribute Schema { get; }

        public static ElementMetadata Create(Type type)
        {
            var data = _lookup.GetOrAdd(type, t =>
            {
                var helper = typeof(BuilderProvider<>).MakeGenericType(t);
                var builder = (IMetadataBuilder<ElementMetadata>)Activator.CreateInstance(helper);

                return builder.Build();
            });

            return data;
        }

        public static ElementMetadata Create<TElement>()
            where TElement : OpenXmlElement, new()
        {
            var data = _lookup.GetOrAdd(typeof(TElement), t =>
            {
                var builder = new BuilderProvider<TElement>();

                return builder.Build();
            });

            return data;
        }

        private class BuilderProvider<T> : IMetadataBuilder<ElementMetadata>
            where T : OpenXmlElement, new()
        {
            public ElementMetadata Build()
            {
                var element = new T();

                var builder = new ElementMetadataBuilder();

                element.ConfigureMetadata(builder);

                return builder.Build();
            }
        }
    }
}
