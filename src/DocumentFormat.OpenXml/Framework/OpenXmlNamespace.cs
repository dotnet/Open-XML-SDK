// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    internal readonly struct OpenXmlNamespace : IComparable<OpenXmlNamespace>, IEquatable<OpenXmlNamespace>
    {
        private readonly string? _prefix;
        private readonly string? _uri;

        private OpenXmlNamespace(byte nsId)
        {
            _prefix = NamespaceIdMap.GetNamespacePrefix(nsId);
            _uri = NamespaceIdMap.GetNamespaceUri(nsId);
        }

        public OpenXmlNamespace(string? nsUri, string? prefix = null)
        {
            _uri = nsUri;
            _prefix = prefix;
        }

        public string Uri => _uri ?? string.Empty;

        public string Prefix => _prefix ?? NamespaceIdMap.GetNamespacePrefix(Uri) ?? string.Empty;

        public bool IsValid => NamespaceIdMap.TryGetNamespaceId(Uri, out _);

        public bool IsEmpty => string.IsNullOrEmpty(Uri);

        public bool IsInFormat(FileFormatVersions version) => NamespaceIdMap.IsInFileFormat(Uri, version);

        public override bool Equals(object? obj) => obj is OpenXmlNamespace ns && Equals(ns);

        public override int GetHashCode()
        {
            var hashcode = new HashCode();

            hashcode.Add(Uri, StringComparer.Ordinal);

            return hashcode.ToHashCode();
        }

        public override string ToString() => Uri;

        public int CompareTo(OpenXmlNamespace other)
            => string.CompareOrdinal(Uri, other.Uri);

        public bool Equals(OpenXmlNamespace other)
            => string.Equals(Uri, other.Uri, StringComparison.Ordinal);

        public static implicit operator OpenXmlNamespace(string ns) => new OpenXmlNamespace(ns);

        public static implicit operator OpenXmlNamespace(byte nsId) => new OpenXmlNamespace(nsId);
    }
}
