// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal readonly struct OpenXmlSchema : IComparable<OpenXmlSchema>, IEquatable<OpenXmlSchema>
    {
        internal OpenXmlSchema(OpenXmlNamespace ns, string name)
        {
            Namespace = ns;
            Name = name;
        }

        public OpenXmlNamespace Namespace { get; }

        public string Name { get; }

        public override bool Equals(object? obj) => base.Equals(obj);

        public int CompareTo(OpenXmlSchema other)
        {
            var nsCompare = Namespace.CompareTo(other.Namespace);

            if (nsCompare != 0)
            {
                return nsCompare;
            }

            return string.CompareOrdinal(Name, other.Name);
        }

        public override string ToString() => $"{Namespace}:{Name}";

        public bool Equals(OpenXmlSchema other)
            => Namespace.Equals(other.Namespace)
            && string.Equals(Name, other.Name, StringComparison.Ordinal);

        public override int GetHashCode()
        {
            var hashcode = new HashCode();

            hashcode.Add(Namespace);
            hashcode.Add(Name, StringComparer.Ordinal);

            return hashcode.ToHashCode();
        }

        public static OpenXmlSchema Create(string nsUri, string prefix, string name)
            => new OpenXmlSchema(new OpenXmlNamespace(nsUri, prefix), name);

        public static OpenXmlSchema Parse(string name, string? nsUri = null)
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
                    return new OpenXmlSchema(string.Empty, name);
                }
                else
                {
                    return new OpenXmlSchema(nsUri, name);
                }
            }
            else
            {
                var prefix = name.Substring(0, length);
                var uri = nsUri ?? NamespaceIdMap.GetNamespaceUri(prefix) ?? string.Empty;
                var localName = name.Substring(length + 1);

                return new OpenXmlSchema(new OpenXmlNamespace(uri, prefix), name);
            }
        }

        public XmlQualifiedName ToXmlQualifiedName() => new XmlQualifiedName(Name, Namespace.Uri);
    }
}
