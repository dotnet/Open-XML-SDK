// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.Reflection;

namespace DocumentFormat.OpenXml.Features
{
    internal class DefaultFeatures : IFeatureCollection
    {
        private readonly object _sync = new();

        private IRootElementFactory? _rootElementFactory;
        private IPartMetadataFeature? _partMetadata;

        public static IFeatureCollection Shared { get; } = new DefaultFeatures();

        public bool IsReadOnly => true;

        public int Revision => 0;

        public TFeature? Get<TFeature>()
        {
            if (typeof(TFeature) == typeof(IRootElementFactory))
            {
                if (_rootElementFactory is null)
                {
                    lock (_sync)
                    {
                        if (_rootElementFactory is null)
                        {
                            _rootElementFactory = new ReflectionBasedRootElementFactory(typeof(ReflectionBasedRootElementFactory).GetTypeInfo().Assembly, ClassActivator<OpenXmlElement>.CreateActivator);
                        }
                    }
                }

                return (TFeature)_rootElementFactory;
            }

            if (typeof(TFeature) == typeof(IPartMetadataFeature))
            {
                if (_partMetadata is null)
                {
                    lock (_sync)
                    {
                        if (_partMetadata is null)
                        {
                            _partMetadata = new CachedPartMetadataProvider();
                        }
                    }
                }

                return (TFeature)_partMetadata;
            }

            return default;
        }

        public void Set<TFeature>(TFeature? instance)
        {
            throw new NotSupportedException();
        }
    }
}
