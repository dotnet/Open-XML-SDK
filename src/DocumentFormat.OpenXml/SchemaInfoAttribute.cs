// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the attribute which is used to decorate a property for its corresponding attribute information.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class SchemaAttrAttribute : Attribute
    {
        private string _tag;
        private byte _nsId;

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

            _nsId = nsId;
            _tag = tag;
        }

        /// <summary>
        /// Gets/Sets the Tag name of the schema attribute.
        /// </summary>
        public string Tag
        {
            get { return _tag; }

            //set { _tag = value; }
        }

        /// <summary>
        /// Gets the Namespace Uri of the schema attribute.
        /// </summary>
        public string NamespaceUri
        {
            get
            {
                return NamespaceIdMap.GetNamespaceUri(_nsId);
            }
        }
    }
}
