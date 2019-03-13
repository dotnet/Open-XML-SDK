// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the attribute which is used to decorate a property for its corresponding attribute information.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public sealed class SchemaAttrAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the SchemaAttrAttribute.
        /// </summary>
        /// <param name="nsId">Specifies the namespace Id of the schema attribute.</param>
        /// <param name="tag">Specifies the Tag name of the schema attribute.</param>
        /// <remarks>This will be removed once the concept of id can be removed. Please use <see cref="SchemaAttrAttribute(string, string)"/></remarks>
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
        /// Initializes a new instance of the SchemaAttrAttribute.
        /// </summary>
        /// <param name="ns">Specifies the namespace of the schema attribute.</param>
        /// <param name="tag">Specifies the Tag name of the schema attribute.</param>
        public SchemaAttrAttribute(string ns, string tag)
            : this(NamespaceIdMap.GetNamespaceId(ns), tag)
        {
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
