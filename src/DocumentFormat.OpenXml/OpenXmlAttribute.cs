// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents an Open XML attribute.
    /// </summary>
    public struct OpenXmlAttribute : IEquatable<OpenXmlAttribute>
    {
        private string _namespaceUri;

        internal OpenXmlAttribute(in ElementPropertyCollection<OpenXmlSimpleType>.PropertyEntry entry)
            : this(entry.Property.NamespacePrefix, entry.Property.Name, entry.Property.Namespace, entry.Value?.ToString())
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlAttribute structure using the supplied qualified name, namespace URI, and text value.
        /// </summary>
        /// <param name="qualifiedName">The qualified attribute name.</param>
        /// <param name="namespaceUri">The namespace URI of the attribute.</param>
        /// <param name="value">The text value of the attribute.</param>
        public OpenXmlAttribute(string qualifiedName, string namespaceUri, string value)
        {
            if (string.IsNullOrEmpty(qualifiedName))
            {
                throw new ArgumentNullException(nameof(qualifiedName));
            }

            _namespaceUri = namespaceUri;

            OpenXmlElement.SplitName(qualifiedName, out var prefix, out var localName);

            Prefix = prefix;
            LocalName = localName;
            Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlAttribute structure using the supplied namespace prefix, local name, namespace URI, and text value.
        /// </summary>
        /// <param name="prefix">The namespace prefix of the attribute. </param>
        /// <param name="localName">The local name of the attribute.</param>
        /// <param name="namespaceUri">The namespace URI of the attribute.</param>
        /// <param name="value">The text value of the attribute.</param>
        public OpenXmlAttribute(string prefix, string localName, string namespaceUri, string value)
        {
            if (string.IsNullOrEmpty(localName))
            {
                throw new ArgumentNullException(nameof(localName));
            }

            _namespaceUri = namespaceUri;
            LocalName = localName;
            Prefix = prefix;
            Value = value;
        }

        /// <summary>
        /// Gets or sets the namespace URI of the current attribute.
        /// </summary>
        public string NamespaceUri
        {
            get => _namespaceUri ?? string.Empty;
            set => _namespaceUri = value;
        }

        /// <summary>
        /// Gets or sets the local name of the attribute.
        /// </summary>
        public string LocalName { get; set; }

        /// <summary>
        /// Gets or sets the namespace prefix of the current attribute.
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or sets the text value of the attribute.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets the qualified name of the attribute.
        /// </summary>
        public XmlQualifiedName XmlQualifiedName => new XmlQualifiedName(LocalName, _namespaceUri);

        /// <summary>
        /// Gets the qualified name of the current attribute.
        /// </summary>
        public XName XName => XName.Get(LocalName, _namespaceUri);

        /// <summary>
        /// Determines if this instance of an OpenXmlAttribute structure is equal to the specified instance of an OpenXmlAttribute structure.
        /// </summary>
        /// <param name="other">An instance of an OpenXmlAttribute structure.</param>
        /// <returns>Returns true if instances are equal; otherwise, returns false.</returns>
        public bool Equals(OpenXmlAttribute other)
        {
            return string.Equals(LocalName, other.LocalName, StringComparison.Ordinal)
                && string.Equals(NamespaceUri, other.NamespaceUri, StringComparison.Ordinal)
                && string.Equals(Prefix, other.Prefix, StringComparison.Ordinal)
                && string.Equals(Value, other.Value, StringComparison.Ordinal);
        }

        /// <summary>
        /// Determines if two instances of OpenXmlAttribute structures are equal.
        /// </summary>
        /// <param name="attribute1">The first instance of an OpenXmlAttribute structure.</param>
        /// <param name="attribute2">The second instance of an OpenXmlAttribute structure.</param>
        /// <returns>Returns true if all corresponding members are equal; otherwise, returns false.</returns>
        public static bool operator ==(OpenXmlAttribute attribute1, OpenXmlAttribute attribute2)
        {
            return attribute1.Equals(attribute2);
        }

        /// <summary>
        /// Determines if two instances of OpenXmlAttribute structures are not equal.
        /// </summary>
        /// <param name="attribute1">The first instance of an OpenXmlAttribute structure.</param>
        /// <param name="attribute2">The second instance of an OpenXmlAttribute structure.</param>
        /// <returns>Returns true if some corresponding members are different; otherwise, returns false.</returns>
        public static bool operator !=(OpenXmlAttribute attribute1, OpenXmlAttribute attribute2)
        {
            return !(attribute1 == attribute2);
        }

        /// <summary>
        /// Determines whether the specified Object is a OpenXmlAttribute structure and if so, indicates whether it is equal to this instance of an OpenXmlAttribute structure.
        /// </summary>
        /// <param name="obj">An Object.</param>
        /// <returns>Returns true if obj is an OpenXmlAttribute structure and it is equal to this instance of an OpenXmlAttribute structure; otherwise, returns false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is OpenXmlAttribute attribute)
            {
                return Equals(attribute);
            }

            return false;
        }

        /// <summary>
        /// Gets the hash code for this instance of an OpenXmlAttribute structure.
        /// </summary>
        /// <returns>The hash code for this instance of an OpenXmlAttribute structure.</returns>
        public override int GetHashCode()
        {
            int hash = 23;

            hash = hash * 31 + (LocalName?.GetHashCode() ?? 0);
            hash = hash * 31 + (NamespaceUri?.GetHashCode() ?? 0);
            hash = hash * 31 + (Prefix?.GetHashCode() ?? 0);
            hash = hash * 31 + (Value?.GetHashCode() ?? 0);

            return hash;
        }
    }
}
