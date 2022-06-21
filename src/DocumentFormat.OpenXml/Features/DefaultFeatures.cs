// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Features
{
    internal partial class DefaultFeatures : IFeatureCollection
    {
        public static IFeatureCollection Shared { get; } = new DefaultFeatures();

        public bool IsReadOnly => true;

        public int Revision => 0;

        [KnownFeature(typeof(IOpenXmlNamespaceIdResolver), typeof(OpenXmlNamespaceIdResolver))]
        [ThreadSafe]
        public partial TFeature? Get<TFeature>();

        public void Set<TFeature>(TFeature? instance)
        {
            throw new NotSupportedException();
        }
    }
}
