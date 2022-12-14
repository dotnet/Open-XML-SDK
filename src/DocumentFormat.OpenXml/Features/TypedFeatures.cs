// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
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

    [KnownFeature(typeof(IRootElementFactory), typeof(TypedRootElementFactory))]
    [KnownFeature(typeof(IOpenXmlNamespaceResolver), typeof(OpenXmlNamespaceResolver))]
    [DelegatedFeature(nameof(FeatureCollection.Default), typeof(FeatureCollection))]
    [ThreadSafe]
    public partial T? Get<T>();

    public void Set<TFeature>(TFeature? instance)
    {
        throw new NotSupportedException();
    }
}
