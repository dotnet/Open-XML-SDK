// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
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
        private string _tagName;
        private string _prefix;
        private string _value;
        // private bool _readonly = false;

        //internal OpenXmlAttribute()
        //{
        //}

        /// <summary>
        /// Initializes a new instance of the OpenXmlAttribute structure using the supplied qualified name, namespace URI, and text value.
        /// </summary>
        /// <param name="qualifiedName">The qualified attribute name.</param>
        /// <param name="namespaceUri">The namespace URI of the attribute.</param>
        /// <param name="value">The text value of the attribute.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#")]
        public OpenXmlAttribute(string qualifiedName, string namespaceUri, string value)
        {
            if (String.IsNullOrEmpty(qualifiedName))
            {
                throw new ArgumentNullException("qualifiedName");
            }

            this._namespaceUri = namespaceUri;
            OpenXmlElement.SplitName(qualifiedName, out this._prefix, out this._tagName);
            this._value = value;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlAttribute structure using the supplied namespace prefix, local name, namespace URI, and text value.
        /// </summary>
        /// <param name="prefix">The namespace prefix of the attribute. </param>
        /// <param name="localName">The local name of the attribute.</param>
        /// <param name="namespaceUri">The namespace URI of the attribute.</param>
        /// <param name="value">The text value of the attribute.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "2#")]
        public OpenXmlAttribute(string prefix, string localName, string namespaceUri, string value)
        {
            if (String.IsNullOrEmpty(localName))
            {
                throw new ArgumentNullException("localName");
            }

            this._namespaceUri = namespaceUri;
            this._tagName = localName;
            this._prefix = prefix;
            this._value = value;
        }

        /// <summary>
        /// Gets or sets the namespace URI of the current attribute.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
        public string NamespaceUri
        {
            get
            {
                if (this._namespaceUri == null)
                {
                    return string.Empty;
                }
                return _namespaceUri;
            }
            set { _namespaceUri = value; }
        }

        /// <summary>
        /// Gets or sets the local name of the attribute.
        /// </summary>
        public string LocalName
        {
            get { return _tagName; }
            set { _tagName = value; }
        }

        /// <summary>
        /// Gets or sets the namespace prefix of the current attribute. 
        /// </summary>
        public string Prefix
        {
            get { return _prefix; }
            set { _prefix = value; }
        }

        /// <summary>
        /// Gets or sets the text value of the attribute.
        /// </summary>
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// When overridden in a derived class, gets the qualified name of the attribute.
        /// </summary>
        public XmlQualifiedName XmlQualifiedName
        {
            get
            {
                return new XmlQualifiedName(this._tagName, this._namespaceUri);
            }
        }

        /// <summary>
        /// Gets the qualified name of the current attribute.
        /// </summary>
        public XName XName
        {
            get
            {
                return XName.Get(this._tagName, this._namespaceUri);
            }
        }

        #region IEquatable<OpenXmlAttribute> Members

        /// <summary>
        /// Determines if this instance of an OpenXmlAttribute structure is equal to the specified instance of an OpenXmlAttribute structure.
        /// </summary>
        /// <param name="other">An instance of an OpenXmlAttribute structure.</param>
        /// <returns>Returns true if instances are equal; otherwise, returns false.</returns>
        public bool Equals(OpenXmlAttribute other)
        {
            return (this.LocalName == other.LocalName &&
                    this.NamespaceUri == other.NamespaceUri &&
                    this.Prefix == other.Prefix &&
                    this.Value == other.Value);
        }

        #endregion

        // implement to follow Framework design guideline
        // FDG ***** CONSIDER overloading operator== and operator!= whenever implementing IEquatable<T>.

        /// <summary>
        /// Determines if two instances of OpenXmlAttribute structures are equal.
        /// </summary>
        /// <param name="attribute1">The first instance of an OpenXmlAttribute structure.</param>
        /// <param name="attribute2">The second instance of an OpenXmlAttribute structure.</param>
        /// <returns>Returns true if all corresponding members are equal; otherwise, returns false.</returns>
        public static bool operator ==(OpenXmlAttribute attribute1, OpenXmlAttribute attribute2)
        {
            return attribute1.Equals( attribute2 );
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


        ///// <summary>
        ///// Determines if two instances of OpenXmlAttribute structures are equal.
        ///// </summary>
        ///// <param name="attribute1">The first instance of an OpenXmlAttribute structure.</param>
        ///// <param name="attribute2">The second instance of an OpenXmlAttribute structure.</param>
        ///// <returns>Returns true if all corresponding members are equal; otherwise, returns false.</returns>
        //public static bool Equals(OpenXmlAttribute attribute1, OpenXmlAttribute attribute2)
        //{
        //    return attribute1.Equals( attribute2 );
        //}

        // FDG ***** DO override Object.Equals whenever implementing IEquatable<T>.

        /// <summary>
        /// Determines whether the specified Object is a OpenXmlAttribute structure and if so, indicates whether it is equal to this instance of an OpenXmlAttribute structure. 
        /// </summary>
        /// <param name="obj">An Object.</param>
        /// <returns>Returns true if obj is an OpenXmlAttribute structure and it is equal to this instance of an OpenXmlAttribute structure; otherwise, returns false.</returns>
        public override bool Equals(object obj)
        {
            if ((obj == null) || !(obj is OpenXmlAttribute))
            {
                return false;
            }
            OpenXmlAttribute attribute = (OpenXmlAttribute)obj;
            return this.Equals(attribute);
        }


        // FDG ***** DO override GetHashCode whenever you override Equals.

        /// <summary>
        /// Gets the hash code for this instance of an OpenXmlAttribute structure. 
        /// </summary>
        /// <returns>The hash code for this instance of an OpenXmlAttribute structure.</returns>
        public override int GetHashCode()
        {
            int hashCode = 0;

            if (this.LocalName != null)
            {
                hashCode ^= this.LocalName.GetHashCode();
            }
            if (this.NamespaceUri != null)
            {
                hashCode ^= this.NamespaceUri.GetHashCode();
            }
            if (this.Prefix != null)
            {
                hashCode ^= this.Prefix.GetHashCode();
            }
            if (this.Value != null)
            {
                hashCode ^= this.Value.GetHashCode();
            }

            return hashCode;
        }
    }
}
