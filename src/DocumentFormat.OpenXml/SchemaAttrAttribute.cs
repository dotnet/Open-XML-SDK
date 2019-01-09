// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    internal sealed class SchemaIndexAttribute : Attribute
    {
        public SchemaIndexAttribute(int index)
        {
            Index = index;
        }

        public int Index { get; }
    }

    /// <summary>
    /// Defines the attribute which is used to decorate a property for its corresponding attribute information.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class SchemaAttrAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the SchemaAttrAttribute.
        /// </summary>
        /// <param name="nsId">Specifies the Namespace Id of the schema attribute.</param>
        /// <param name="tag">Specifies the Tag name of the schema attribute.</param>
        public SchemaAttrAttribute(byte nsId, string tag)
        {
            if (string.IsNullOrEmpty(tag))
            {
                throw new ArgumentNullException(nameof(tag));
            }

            NamespaceId = nsId;
            Tag = tag;
        }

        /// <summary>
        /// Gets the tag name of the schema attribute.
        /// </summary>
        public string Tag { get; }

        /// <summary>
        /// Gets the id of the namespace
        /// </summary>
        internal byte NamespaceId { get; }

        /// <summary>
        /// Gets the Namespace Uri of the schema attribute.
        /// </summary>
        public string NamespaceUri => NamespaceIdMap.GetNamespaceUri(NamespaceId);
    }
}
