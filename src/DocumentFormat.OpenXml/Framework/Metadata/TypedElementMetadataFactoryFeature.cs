// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class TypedElementMetadataFactoryFeature : IElementMetadataFactoryFeature
    {
        private readonly ConcurrentDictionary<Type, ElementMetadata> _lookup = new(new[]
        {
            new KeyValuePair<Type, ElementMetadata>(typeof(OpenXmlUnknownElement), new ElementMetadata(typeof(OpenXmlUnknownElement))),
            new KeyValuePair<Type, ElementMetadata>(typeof(OpenXmlMiscNode), new ElementMetadata(typeof(OpenXmlMiscNode))),
        });

        public IElementMetadata GetMetadata(OpenXmlElement element)
        {
            var type = element.GetType();

            // Use TryGetValue first for the common case of already existing types to limit number of allocations
            if (_lookup.TryGetValue(type, out var result))
            {
                return result;
            }

            var metadata = CreateMetadata(element);

            _lookup.TryAdd(type, metadata);

            return metadata;
        }

        private static ElementMetadata CreateMetadata(OpenXmlElement element)
        {
            var builder = new ElementMetadata.Builder(element.GetType(), element.Features.GetNamespaceResolver());

            element.ConfigureMetadata(builder);

            return builder.Build();
        }
    }
}
