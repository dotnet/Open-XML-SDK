// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the attribute which is used to decorate a property for its corresponding attribute information.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    [Obsolete("This attribute is no longer used to identify schema information. It didn't contain everything and a new API will be forthcoming.")]
    public sealed class SchemaAttrAttribute : Attribute
    {
        private readonly OpenXmlQualifiedName _qname;

        /// <summary>
        /// Initializes a new instance of the SchemaAttrAttribute.
        /// </summary>
        /// <param name="nsId">Specifies the namespace Id of the schema attribute.</param>
        /// <param name="tag">Specifies the Tag name of the schema attribute.</param>
        /// <remarks>This will be removed once the concept of id can be removed. Please use <see cref="SchemaAttrAttribute(string, string)"/></remarks>
        [Obsolete("The namespace id is no longer tracked and will be removed in future release.")]
        public SchemaAttrAttribute(byte nsId, string tag)
        {
            if (string.IsNullOrEmpty(tag))
            {
                throw new ArgumentNullException(nameof(tag));
            }

            var features = FeatureCollection.TypedOrDefault;
            var prefix = features.GetRequired<IOpenXmlNamespaceIdResolver>().GetPrefix(nsId);
            var uri = features.GetRequired<IOpenXmlNamespaceResolver>().LookupNamespace(prefix);

            _qname = new OpenXmlQualifiedName(uri ?? string.Empty, tag);
        }

        /// <summary>
        /// Initializes a new instance of the SchemaAttrAttribute.
        /// </summary>
        /// <param name="qname">Qualified name of item.</param>
        /// <remarks>This will be removed once the concept of id can be removed. Please use <see cref="SchemaAttrAttribute(string, string)"/></remarks>
        public SchemaAttrAttribute(string qname)
        {
            if (string.IsNullOrEmpty(qname))
            {
                throw new ArgumentNullException(nameof(qname));
            }

            _qname = FeatureCollection.TypedOrDefault.GetNamespaceResolver().ParseQName(qname);
        }

        /// <summary>
        /// Initializes a new instance of the SchemaAttrAttribute.
        /// </summary>
        /// <param name="ns">Specifies the namespace of the schema attribute.</param>
        /// <param name="tag">Specifies the Tag name of the schema attribute.</param>
        public SchemaAttrAttribute(string ns, string tag)
        {
            if (string.IsNullOrEmpty(tag))
            {
                throw new ArgumentNullException(nameof(tag));
            }

            _qname = new(ns, tag);
        }

        /// <summary>
        /// Gets the tag name of the schema attribute.
        /// </summary>
        public string Tag => _qname.Name;

        /// <summary>
        /// Gets the Namespace Uri of the schema attribute.
        /// </summary>
        public string NamespaceUri => _qname.Namespace.Uri;
    }
}
