// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.Threading;

namespace DocumentFormat.OpenXml.Features;

internal partial class TypedFeatures : IFeatureCollection
{
    private static TypedFeatures? _shared;

    public static IFeatureCollection Shared
    {
        get
        {
            if (_shared is null)
            {
                Interlocked.CompareExchange(ref _shared, new(), null);
            }

            return _shared;
        }
    }

    public bool IsReadOnly => true;

    public int Revision => 0;

    [KnownFeature(typeof(IRootElementFactory), typeof(ReflectionBasedRootElementFactory))]
    [KnownFeature(typeof(IPartMetadataFeature), typeof(CachedPartMetadataProvider))]
    [KnownFeature(typeof(IOpenXmlNamespaceResolver), typeof(OpenXmlNamespaceResolver))]
    [KnownFeature(typeof(IElementMetadataFactoryFeature), typeof(TypedElementMetadataFactoryFeature))]
    [KnownFeature(typeof(IPartFactory), typeof(ReflectionPartFactory))]
    [DelegatedFeature(nameof(FeatureCollection.Default), typeof(FeatureCollection))]
    [ThreadSafe]
    public partial TFeature? Get<TFeature>();

    public void Set<TFeature>(TFeature? instance)
    {
        throw new NotSupportedException();
    }
}
