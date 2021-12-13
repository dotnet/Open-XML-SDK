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
            _prefix = DefaultFeatures.Shared.GetRequired<IOpenXmlNamespaceIdResolver>().GetPrefix(nsId);
            _uri = DefaultFeatures.Shared.GetRequired<IOpenXmlNamespaceResolver>().LookupNamespace(_prefix);
        }

        public OpenXmlNamespace(string? nsUri, string? prefix = null)
        {
            _uri = nsUri;
            _prefix = prefix;
        }

        public string Uri => _uri ?? string.Empty;

        public string Prefix => _prefix ?? GetNamespacePrefix(Uri) ?? string.Empty;

        public bool IsKnown => Version != FileFormatVersions.None;

        public bool IsEmpty => string.IsNullOrEmpty(Uri);

        public FileFormatVersions Version => DefaultFeatures.Shared.GetRequired<IOpenXmlNamespaceResolver>().GetVersion(this);

        public bool HasVersion(FileFormatVersions version) => (version & Version) == version;

        /// <summary>
        /// Attempts to get the Transitional equivalent namespace.
        /// </summary>
        /// <param name="transitionalNamespace">An equivalent namespace in Transitional.</param>
        /// <returns>Returns true when a Transitional equivalent namespace is found, returns false when it is not found.</returns>
        public bool TryGetTransitionalNamespace(out OpenXmlNamespace transitionalNamespace) => DefaultFeatures.Shared.GetRequired<IOpenXmlNamespaceResolver>().TryGetTransitionalNamespace(this, out transitionalNamespace);

        /// <summary>
        /// Attempts to get the Transitional equivalent relationship.
        /// </summary>
        /// <param name="transitionalRelationship">An equivalent relationship in Transitional.</param>
        /// <returns>Returns true when a Transitional equivalent relationship is found, returns false when it is not.</returns>
        public bool TryGetTransitionalRelationship(out OpenXmlNamespace transitionalRelationship) => DefaultFeatures.Shared.GetRequired<IOpenXmlNamespaceResolver>().TryGetTransitionalRelationship(this, out transitionalRelationship);

        /// <summary>
        /// Try to get the expected namespace if the passed namespace is an obsolete.
        /// </summary>
        /// <param name="extNamespaceUri">The expected namespace when the passed namespace is an obsolete.</param>
        /// <returns>True when the passed namespace is an obsolete and the expected namespace found</returns>
        public bool TryGetExtendedNamespace(out OpenXmlNamespace extNamespaceUri) => DefaultFeatures.Shared.GetRequired<IOpenXmlNamespaceResolver>().TryGetExtendedNamespace(this, out extNamespaceUri);

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

        public static implicit operator OpenXmlNamespace(string ns) => new OpenXmlNamespace(ns);

        /// <summary>
        /// Gets the namespace URI for the specified namespace prefix.
        /// </summary>
        /// <param name="prefix">The namespace prefix.</param>
        /// <returns></returns>
        public static string? GetNamespaceUri(string prefix) => DefaultFeatures.Shared.GetRequired<IOpenXmlNamespaceResolver>().LookupNamespace(prefix);

        /// <summary>
        /// Gets the default namespace prefix for the specified namespace URI.
        /// </summary>
        /// <param name="namespaceUri">The namespace URI.</param>
        /// <returns>The default namespace prefix.</returns>
        public static string? GetNamespacePrefix(string namespaceUri) => DefaultFeatures.Shared.GetRequired<IOpenXmlNamespaceResolver>().LookupPrefix(namespaceUri);
    }
}
