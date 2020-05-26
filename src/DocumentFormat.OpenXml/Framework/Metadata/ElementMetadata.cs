// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal readonly struct ElementMetadata
    {
        private static readonly ConcurrentDictionary<Type, ReadOnlyArray<AttributeMetadata>> _lookup = new ConcurrentDictionary<Type, ReadOnlyArray<AttributeMetadata>>(new[]
        {
            new KeyValuePair<Type, ReadOnlyArray<AttributeMetadata>>(typeof(OpenXmlUnknownElement), null),
            new KeyValuePair<Type, ReadOnlyArray<AttributeMetadata>>(typeof(OpenXmlMiscNode), null),
        });

        public static ElementMetadata Empty => new ElementMetadata(null);

        public bool IsEmpty => Attributes.IsEmpty;

        public static ElementMetadata Create(Type type)
        {
            var data = _lookup.GetOrAdd(type, t =>
            {
                var helper = typeof(BuilderProvider<>).MakeGenericType(t);
                var builder = (IBuilderProvider)Activator.CreateInstance(helper);

                return builder.Create();
            });

            return new ElementMetadata(data);
        }

        public static ElementMetadata Create<TElement>()
            where TElement : OpenXmlElement, new()
        {
            var data = _lookup.GetOrAdd(typeof(TElement), t =>
            {
                var builder = new BuilderProvider<TElement>();

                return builder.Create();
            });

            return new ElementMetadata(data);
        }

        private class BuilderProvider<T> : IBuilderProvider
            where T : OpenXmlElement, new()
        {
            public ReadOnlyArray<AttributeMetadata> Create()
            {
                var element = new T();

                var builder = new ElementMetadataBuilder();

                element.ConfigureMetadata(builder);

                return builder.Build();
            }
        }

        private interface IBuilderProvider
        {
            ReadOnlyArray<AttributeMetadata> Create();
        }

        public ElementMetadata(ReadOnlyArray<AttributeMetadata> tags)
        {
            Attributes = new AttributeCollection(tags);
        }

        public AttributeCollection Attributes { get; }
    }
}
