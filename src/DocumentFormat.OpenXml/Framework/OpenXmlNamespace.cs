// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Framework
{
    internal readonly partial struct OpenXmlNamespace : IComparable<OpenXmlNamespace>, IEquatable<OpenXmlNamespace>
    {
        private readonly string? _prefix;
        private readonly string? _uri;

        internal OpenXmlNamespace(byte nsId)
        {
            _prefix = FeatureCollection.StaticOrDefault.GetRequired<IOpenXmlNamespaceIdResolver>().GetPrefix(nsId);
            _uri = FeatureCollection.StaticOrDefault.GetRequired<IOpenXmlNamespaceResolver>().LookupNamespace(_prefix);
        }

        public OpenXmlNamespace(string? nsUri, string? prefix = null)
        {
            _uri = nsUri;
            _prefix = prefix;
        }

        public string Uri => _uri ?? string.Empty;

        public string Prefix => _prefix ?? GetNamespacePrefix(Uri) ?? string.Empty;

        public bool IsEmpty => string.IsNullOrEmpty(Uri);

        /// <summary>
        /// Try to get the expected namespace if the passed namespace is an obsolete.
        /// </summary>
        /// <param name="extNamespaceUri">The expected namespace when the passed namespace is an obsolete.</param>
        /// <returns>True when the passed namespace is an obsolete and the expected namespace found</returns>
        public bool TryGetExtendedNamespace(out OpenXmlNamespace extNamespaceUri) => FeatureCollection.StaticOrDefault.GetRequired<IOpenXmlNamespaceResolver>().TryGetExtendedNamespace(this, out extNamespaceUri);

        public override bool Equals(object? obj) => obj is OpenXmlNamespace ns && Equals(ns);

        public bool Equals(OpenXmlNamespace other)
            => string.Equals(Uri, other.Uri, StringComparison.Ordinal);

        public override int GetHashCode()
        {
            var hashcode = default(HashCode);

            hashcode.Add(Uri, StringComparer.Ordinal);

            return hashcode.ToHashCode();
        }

        public override string ToString() => Uri;

        public int CompareTo(OpenXmlNamespace other)
            => string.CompareOrdinal(Uri, other.Uri);

        public static implicit operator OpenXmlNamespace(string ns) => new(ns);

        /// <summary>
        /// Gets the namespace URI for the specified namespace prefix.
        /// </summary>
        /// <param name="prefix">The namespace prefix.</param>
        /// <returns></returns>
        public static string? GetNamespaceUri(string prefix) => FeatureCollection.StaticOrDefault.GetRequired<IOpenXmlNamespaceResolver>().LookupNamespace(prefix);

        /// <summary>
        /// Gets the default namespace prefix for the specified namespace URI.
        /// </summary>
        /// <param name="namespaceUri">The namespace URI.</param>
        /// <returns>The default namespace prefix.</returns>
        public static string? GetNamespacePrefix(string namespaceUri) => FeatureCollection.StaticOrDefault.GetRequired<IOpenXmlNamespaceResolver>().LookupPrefix(namespaceUri);
    }
}
