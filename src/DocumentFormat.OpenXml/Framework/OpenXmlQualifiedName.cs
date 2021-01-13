// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    internal readonly struct OpenXmlQualifiedName : IComparable<OpenXmlQualifiedName>, IEquatable<OpenXmlQualifiedName>
    {
        internal OpenXmlQualifiedName(in OpenXmlNamespace ns, string name)
        {
            Namespace = ns;
            Name = name;
        }

        public OpenXmlNamespace Namespace { get; }

        public string Name { get; }

        public override bool Equals(object? obj) => obj is OpenXmlQualifiedName qname && Equals(qname);

        public int CompareTo(OpenXmlQualifiedName other)
        {
            var nsCompare = Namespace.CompareTo(other.Namespace);

            if (nsCompare != 0)
            {
                return nsCompare;
            }

            return string.CompareOrdinal(Name, other.Name);
        }

        public override string ToString() => Namespace.IsEmpty ? Name : string.Concat(Namespace.ToString(), ":", Name);

        public bool Equals(OpenXmlQualifiedName other)
            => Namespace.Equals(other.Namespace)
            && string.Equals(Name, other.Name, StringComparison.Ordinal);

        public override int GetHashCode()
        {
            var hashcode = new HashCode();

            hashcode.Add(Namespace);
            hashcode.Add(Name, StringComparer.Ordinal);

            return hashcode.ToHashCode();
        }

        public static OpenXmlQualifiedName Create(string nsUri, string prefix, string name)
            => new OpenXmlQualifiedName(new OpenXmlNamespace(nsUri, prefix), name);

        public static OpenXmlQualifiedName Parse(string name, string? nsUri = null)
        {
#if NET5_0
            var length = name.IndexOf(':', StringComparison.Ordinal);
#else
            var length = name.IndexOf(':');
#endif

            if (((length == -1) || (length == 0)) || ((name.Length - 1) == length))
            {
                if (nsUri is null)
                {
                    return new OpenXmlQualifiedName(string.Empty, name);
                }
                else
                {
                    return new OpenXmlQualifiedName(nsUri, name);
                }
            }
            else
            {
                var prefix = name.Substring(0, length);
                var uri = nsUri ?? OpenXmlNamespace.GetNamespaceUri(prefix) ?? string.Empty;
                var localName = name.Substring(length + 1);

                return new OpenXmlQualifiedName(new OpenXmlNamespace(uri, prefix), localName);
            }
        }
    }
}
