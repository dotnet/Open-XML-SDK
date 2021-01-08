// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal readonly struct OpenXmlSchema : IComparable<OpenXmlSchema>
    {
        internal OpenXmlSchema(byte nsId, string name)
        {
            NamespaceId = nsId;
            Name = name;
        }

        internal byte NamespaceId { get; }

        public string NamespaceUri => NamespaceIdMap.GetNamespaceUri(NamespaceId);

        public string Name { get; }

        public int CompareTo(OpenXmlSchema other)
        {
            var nsCompare = NamespaceId.CompareTo(other.NamespaceId);

            if (nsCompare != 0)
            {
                return nsCompare;
            }

            return string.CompareOrdinal(Name, other.Name);
        }
    }
}
