// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// Extension methods for registering an <see cref="IOpenXmlNamespacePrefixFeature"/>.
/// </summary>
public static class NamespacePrefixFeatureExtensions
{
    /// <summary>
    /// Registers a feature that controls the namespace prefixes used when elements are written.
    /// </summary>
    /// <param name="features">
    /// The feature collection to register on. This must be a writable collection such as
    /// <see cref="Packaging.OpenXmlPackage.Features"/>; an element's feature collection is read-only.
    /// </param>
    /// <param name="feature">The feature to register.</param>
    /// <exception cref="ArgumentNullException"><paramref name="features"/> or <paramref name="feature"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="features"/> is read-only.</exception>
    public static void SetNamespacePrefixOverride(this IFeatureCollection features, IOpenXmlNamespacePrefixFeature feature)
    {
        if (features is null)
        {
            throw new ArgumentNullException(nameof(features));
        }

        if (feature is null)
        {
            throw new ArgumentNullException(nameof(feature));
        }

        if (features.IsReadOnly)
        {
            throw new InvalidOperationException(ExceptionMessages.ReadOnlyFeatureCollection);
        }

        features.Set(feature);
    }

    /// <summary>
    /// Registers a callback that controls the namespace prefixes used when elements are written.
    /// </summary>
    /// <param name="features">The feature collection, usually a package's.</param>
    /// <param name="resolver">
    /// Returns the prefix for a namespace, <see cref="string.Empty"/> to write it as the default
    /// namespace, or <see langword="null"/> to use the built-in prefix.
    /// </param>
    /// <exception cref="ArgumentNullException"><paramref name="features"/> or <paramref name="resolver"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="features"/> is read-only.</exception>
    public static void SetNamespacePrefixOverride(this IFeatureCollection features, Func<string, string?> resolver)
    {
        // Checked before building the feature so a null collection is reported as such, rather than
        // surfacing as a complaint about the resolver.
        if (features is null)
        {
            throw new ArgumentNullException(nameof(features));
        }

        features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.Create(resolver));
    }
}
