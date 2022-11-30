// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using System;

namespace DocumentFormat.OpenXml.Features
{
    internal partial class DefaultFeatures : IFeatureCollection
    {
        public static IFeatureCollection Shared { get; } = new DefaultFeatures();

        public bool IsReadOnly => true;

        public int Revision => 0;

        [KnownFeature(typeof(IOpenXmlNamespaceIdResolver), typeof(OpenXmlNamespaceIdResolver))]
        [KnownFeature(typeof(IOpenXmlNamespaceResolver), typeof(NoDataNamespaceResolver))]
        [KnownFeature(typeof(IElementMetadataFactoryFeature), typeof(ElementMetadataFactoryFeature))]
        [ThreadSafe]
        public partial T? Get<T>();

        public void Set<TFeature>(TFeature? instance)
        {
            throw new NotSupportedException();
        }
    }
}
