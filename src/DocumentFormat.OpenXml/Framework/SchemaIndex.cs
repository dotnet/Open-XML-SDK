// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Framework
{
    internal readonly struct SchemaIndex
    {
        private readonly SchemaAttrAttribute _schema;
        private readonly IndexAttribute _index;

        public SchemaIndex(SchemaAttrAttribute schema, IndexAttribute index)
        {
            _schema = schema;
            _index = index;
        }

        /// <summary>
        /// Gets the tag name of the schema attribute.
        /// </summary>
        public string Tag => _schema.Tag;

        public byte Index => _index.Index;

        /// <summary>
        /// Gets the id of the namespace
        /// </summary>
        public byte NamespaceId => _schema.NamespaceId;

        public bool IsValid => _schema != null && _index != null;
    }
}
