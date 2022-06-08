// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using System;

namespace DocumentFormat.OpenXml.Features
{
    internal partial class DefaultFeatures : IFeatureCollection
    {
        public static IFeatureCollection Shared { get; } = new DefaultFeatures();

        public bool IsReadOnly => true;

        public int Revision => 0;

        [KnownFeature(typeof(IRootElementFactory), typeof(ReflectionBasedRootElementFactory))]
        [KnownFeature(typeof(IPartMetadataFeature), typeof(CachedPartMetadataProvider))]
        [KnownFeature(typeof(IOpenXmlNamespaceResolver), typeof(OpenXmlNamespaceResolver))]
        [KnownFeature(typeof(IOpenXmlNamespaceIdResolver), typeof(OpenXmlNamespaceIdResolver))]
        [KnownFeature(typeof(ElementMetadataProviderFeature))]
        [ThreadSafe]
        public partial TFeature? Get<TFeature>();

        public void Set<TFeature>(TFeature? instance)
        {
            throw new NotSupportedException();
        }
    }
}
