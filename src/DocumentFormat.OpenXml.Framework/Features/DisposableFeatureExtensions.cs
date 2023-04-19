// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// Extensions for using <see cref="IDisposableFeature"/>
/// </summary>
public static class DisposableFeatureExtensions
{
    /// <summary>
    /// Register a disposable for dispose.
    /// </summary>
    public static void Register(this IDisposableFeature feature, IDisposable disposable)
    {
        if (feature is null)
        {
            throw new ArgumentNullException(nameof(feature));
        }

        if (disposable is null)
        {
            throw new ArgumentNullException(nameof(disposable));
        }

        feature.Register(disposable.Dispose);
    }
}
