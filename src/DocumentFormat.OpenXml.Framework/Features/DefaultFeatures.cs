// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace DocumentFormat.OpenXml.Features
{
    internal partial class DefaultFeatures : IFeatureCollection
    {
        private IOpenXmlNamespaceResolver? _openXmlNamespaceResolver;
        private IElementMetadataFactoryFeature? _elementMetadata;

        public object? this[Type key]
        {
            get
            {
                if (key == typeof(IOpenXmlNamespaceResolver))
                {
                    if (_openXmlNamespaceResolver is null)
                    {
                        Interlocked.CompareExchange(ref _openXmlNamespaceResolver, new OpenXmlNamespaceResolver(), null);
                    }

                    return _openXmlNamespaceResolver;
                }

                if (key == typeof(IElementMetadataFactoryFeature))
                {
                    if (_elementMetadata is null)
                    {
                        Interlocked.CompareExchange(ref _elementMetadata, new ElementMetadataFactoryFeature(), null);
                    }

                    return _elementMetadata;
                }

                return null;
            }
            set => throw new NotSupportedException();
        }

        public static IFeatureCollection Shared { get; } = new DefaultFeatures();

        public bool IsReadOnly => true;

        public int Revision => 0;

        public IEnumerator<KeyValuePair<Type, object>> GetEnumerator()
        {
            yield return GetPair<IOpenXmlNamespaceResolver>();
            yield return GetPair<IElementMetadataFactoryFeature>();
        }

        private KeyValuePair<Type, object> GetPair<T>() => new(typeof(T), this[typeof(T)]!);

        public void Set<TFeature>(TFeature? instance) => throw new NotSupportedException();

        public TFeature? Get<TFeature>() => (TFeature?)this[typeof(TFeature)];

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
