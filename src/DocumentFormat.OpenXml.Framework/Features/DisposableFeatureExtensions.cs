// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Features;

internal static class DisposableFeatureExtensions
{
    /// <summary>
    /// Register a disposable for dispose.
    /// </summary>
    internal static void Register(this IDisposableFeature feature, IDisposable disposable)
        => feature.Register(disposable.Dispose);

    /// <summary>
    /// Register a feature into the collection and to be disposed.
    /// </summary>
    /// <typeparam name="TFeature">Type of feature.</typeparam>
    /// <param name="features">Feature collection.</param>
    /// <param name="feature">Feature to register.</param>
    internal static void SetDisposable<TFeature>(this IFeatureCollection features, TFeature feature)
    {
        var disposable = features.GetRequired<IDisposableFeature>();

        if (feature is IDisposable d)
        {
            disposable.Register(d);
        }

        features.Set(feature);
    }
}
