// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    internal readonly struct OpenXmlNamespace : IComparable<OpenXmlNamespace>, IEquatable<OpenXmlNamespace>
    {
        private readonly byte? _nsId;
        private readonly string? _prefix;

        public OpenXmlNamespace(byte nsId)
        {
            _nsId = nsId;
            _prefix = NamespaceIdMap.GetNamespacePrefix(nsId);
            Uri = NamespaceIdMap.GetNamespaceUri(nsId);
        }

        public OpenXmlNamespace(string nsUri, string? prefix = null)
        {
            _prefix = prefix ?? NamespaceIdMap.GetNamespacePrefix(nsUri ?? string.Empty);
            Uri = nsUri!;

            if (NamespaceIdMap.TryGetNamespaceId(nsUri!, out var nsId))
            {
                _nsId = nsId;
            }
            else
            {
                _nsId = default;
            }
        }

        public byte Id => _nsId.GetValueOrDefault();

        public string Uri { get; }

        public string Prefix => _prefix ?? string.Empty;

        public bool IsValid => _nsId.HasValue;

        public override bool Equals(object? obj) => obj is OpenXmlNamespace ns && Equals(ns);

        public override int GetHashCode() => HashCode.Combine(_nsId.GetValueOrDefault());

        public override string ToString() => Uri;

        public int CompareTo(OpenXmlNamespace other)
            => _nsId.GetValueOrDefault().CompareTo(other._nsId.GetValueOrDefault());

        public bool Equals(OpenXmlNamespace other)
            => string.Equals(Uri, other.Uri, StringComparison.Ordinal);

        public static implicit operator OpenXmlNamespace(string ns) => new OpenXmlNamespace(ns);

        public static implicit operator OpenXmlNamespace(byte nsId) => new OpenXmlNamespace(nsId);
    }
}
