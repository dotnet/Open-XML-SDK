// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal readonly struct OpenXmlSchema
    {
        internal OpenXmlSchema(byte nsId, string name)
        {
            NamespaceId = nsId;
            Tag = name;
        }

        internal byte NamespaceId { get; }

        public string NamespaceUri => NamespaceIdMap.GetNamespaceUri(NamespaceId);

        public string Tag { get; }
    }
}
