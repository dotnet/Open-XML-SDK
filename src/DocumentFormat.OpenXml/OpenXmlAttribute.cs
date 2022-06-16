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
        private const string ObsoleteMessage = "OpenXmlAttribute is a struct so setters may not behave as you might expect. Mutable setters will be removed in a future version.";

        private string? _value;

        internal OpenXmlAttribute(in OpenXmlQualifiedName qname, string? value)
        {
            QName = qname;
            _value = value;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlAttribute structure using the supplied qualified name, namespace URI, and text value.
        /// </summary>
        /// <param name="qualifiedName">The qualified attribute name.</param>
        /// <param name="namespaceUri">The namespace URI of the attribute.</param>
        /// <param name="value">The text value of the attribute.</param>
        public OpenXmlAttribute(string qualifiedName, string namespaceUri, string? value)
        {
            if (string.IsNullOrEmpty(qualifiedName))
            {
                throw new ArgumentNullException(nameof(qualifiedName));
            }

            var qname = OpenXmlQualifiedName.Parse(qualifiedName);

            QName = new(new(namespaceUri, qname.Namespace.Prefix), qname.Name);
            _value = value;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlAttribute structure using the supplied namespace prefix, local name, namespace URI, and text value.
        /// </summary>
        /// <param name="prefix">The namespace prefix of the attribute. </param>
        /// <param name="localName">The local name of the attribute.</param>
        /// <param name="namespaceUri">The namespace URI of the attribute.</param>
        /// <param name="value">The text value of the attribute.</param>
        public OpenXmlAttribute(string prefix, string localName, string namespaceUri, string? value)
        {
            if (string.IsNullOrEmpty(localName))
            {
                throw new ArgumentNullException(nameof(localName));
            }

            QName = new(new(namespaceUri, prefix), localName);
            _value = value;
        }

        /// <summary>
        /// Gets or sets the namespace URI of the current attribute.
        /// </summary>
        public string NamespaceUri
        {
            get => QName.Namespace.Uri;
            [Obsolete(ObsoleteMessage, true)]
            set => QName = new(new(value, Prefix), LocalName);
        }

        /// <summary>
        /// Gets or sets the local name of the attribute.
        /// </summary>
        public string LocalName
        {
            get => QName.Name;
            [Obsolete(ObsoleteMessage, true)]
            set => QName = new(QName.Namespace, value);
        }

        /// <summary>
        /// Gets or sets the namespace prefix of the current attribute.
        /// </summary>
        public string Prefix
        {
            get => QName.Namespace.Prefix;
            [Obsolete(ObsoleteMessage, true)]
            set => QName = new(new(NamespaceUri, value), LocalName);
        }

        /// <summary>
        /// Gets or sets the text value of the attribute.
        /// </summary>
        public string? Value
        {
            get => _value;
            [Obsolete(ObsoleteMessage, true)]
            set => _value = value;
        }

        /// <summary>
        /// Gets the qualified name of the attribute.
        /// </summary>
        public XmlQualifiedName XmlQualifiedName => new(LocalName, QName.Namespace.Uri);

        /// <summary>
        /// Gets the qualified name of the current attribute.
        /// </summary>
        public XName XName => XName.Get(LocalName, QName.Namespace.Uri);

        internal OpenXmlQualifiedName QName { get; private set; }

        /// <summary>
        /// Determines if this instance of an OpenXmlAttribute structure is equal to the specified instance of an OpenXmlAttribute structure.
        /// </summary>
        /// <param name="other">An instance of an OpenXmlAttribute structure.</param>
        /// <returns>Returns true if instances are equal; otherwise, returns false.</returns>
        public bool Equals(OpenXmlAttribute other)
            => string.Equals(Value, other.Value, StringComparison.Ordinal)
            && string.Equals(QName.Name, other.QName.Name, StringComparison.Ordinal)
            && string.Equals(QName.Namespace.Uri, other.QName.Namespace.Uri, StringComparison.Ordinal)
            && string.Equals(QName.Namespace.Prefix, other.QName.Namespace.Prefix, StringComparison.Ordinal);

        /// <summary>
        /// Determines if two instances of OpenXmlAttribute structures are equal.
        /// </summary>
        /// <param name="attribute1">The first instance of an OpenXmlAttribute structure.</param>
        /// <param name="attribute2">The second instance of an OpenXmlAttribute structure.</param>
        /// <returns>Returns true if all corresponding members are equal; otherwise, returns false.</returns>
        public static bool operator ==(OpenXmlAttribute attribute1, OpenXmlAttribute attribute2)
            => attribute1.Equals(attribute2);

        /// <summary>
        /// Determines if two instances of OpenXmlAttribute structures are not equal.
        /// </summary>
        /// <param name="attribute1">The first instance of an OpenXmlAttribute structure.</param>
        /// <param name="attribute2">The second instance of an OpenXmlAttribute structure.</param>
        /// <returns>Returns true if some corresponding members are different; otherwise, returns false.</returns>
        public static bool operator !=(OpenXmlAttribute attribute1, OpenXmlAttribute attribute2)
            => !(attribute1 == attribute2);

        /// <summary>
        /// Determines whether the specified Object is a OpenXmlAttribute structure and if so, indicates whether it is equal to this instance of an OpenXmlAttribute structure.
        /// </summary>
        /// <param name="obj">An Object.</param>
        /// <returns>Returns true if obj is an OpenXmlAttribute structure and it is equal to this instance of an OpenXmlAttribute structure; otherwise, returns false.</returns>
        public override bool Equals(object? obj)
            => obj is OpenXmlAttribute attribute && Equals(attribute);

        /// <summary>
        /// Gets the hash code for this instance of an OpenXmlAttribute structure.
        /// </summary>
        /// <returns>The hash code for this instance of an OpenXmlAttribute structure.</returns>
        public override int GetHashCode()
        {
            var hashcode = default(HashCode);

            hashcode.Add(Value, StringComparer.Ordinal);
            hashcode.Add(QName.Name, StringComparer.Ordinal);
            hashcode.Add(QName.Namespace.Uri, StringComparer.Ordinal);
            hashcode.Add(QName.Namespace.Prefix, StringComparer.Ordinal);

            return hashcode.ToHashCode();
        }
    }
}
