// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// Factory methods for <see cref="IOpenXmlNamespacePrefixFeature"/> implementations.
/// </summary>
public static class OpenXmlNamespacePrefix
{
    /// <summary>
    /// Creates a feature that writes the supplied namespaces as the default (unprefixed) namespace
    /// and leaves every other namespace on its built-in prefix.
    /// </summary>
    /// <param name="namespaceUris">The namespaces to write unprefixed.</param>
    /// <returns>A feature that can be registered on a package's <see cref="IFeatureCollection"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="namespaceUris"/> is, or contains, <see langword="null"/>.</exception>
    public static IOpenXmlNamespacePrefixFeature DefaultFor(params string[] namespaceUris)
    {
        if (namespaceUris is null)
        {
            throw new ArgumentNullException(nameof(namespaceUris));
        }

        foreach (var namespaceUri in namespaceUris)
        {
            if (namespaceUri is null)
            {
                throw new ArgumentNullException(nameof(namespaceUris), ExceptionMessages.NamespaceUriCannotBeNull);
            }
        }

        return new DefaultNamespaceFeature(namespaceUris);
    }

    /// <summary>
    /// Creates a feature from a callback that maps a namespace to the prefix used to write it.
    /// </summary>
    /// <param name="resolver">
    /// Returns the prefix for a namespace, <see cref="string.Empty"/> to write it as the default
    /// namespace, or <see langword="null"/> to use the built-in prefix.
    /// </param>
    /// <returns>A feature that can be registered on a package's <see cref="IFeatureCollection"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="resolver"/> is <see langword="null"/>.</exception>
    public static IOpenXmlNamespacePrefixFeature Create(Func<string, string?> resolver)
    {
        if (resolver is null)
        {
            throw new ArgumentNullException(nameof(resolver));
        }

        return new DelegateFeature(resolver);
    }

    private sealed class DefaultNamespaceFeature : IOpenXmlNamespacePrefixFeature
    {
        private readonly HashSet<string> _namespaces;

        public DefaultNamespaceFeature(string[] namespaceUris)
        {
            _namespaces = new HashSet<string>(namespaceUris, StringComparer.Ordinal);
        }

        public bool TryGetPrefix(string namespaceUri, out string prefix)
        {
            if (_namespaces.Contains(namespaceUri))
            {
                prefix = string.Empty;
                return true;
            }

            prefix = string.Empty;
            return false;
        }
    }

    private sealed class DelegateFeature : IOpenXmlNamespacePrefixFeature
    {
        private readonly Func<string, string?> _resolver;

        public DelegateFeature(Func<string, string?> resolver)
        {
            _resolver = resolver;
        }

        public bool TryGetPrefix(string namespaceUri, out string prefix)
        {
            if (_resolver(namespaceUri) is { } result)
            {
                prefix = result;
                return true;
            }

            prefix = string.Empty;
            return false;
        }
    }
}
