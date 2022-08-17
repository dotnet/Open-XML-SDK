// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents a base class that all elements in an Office Open XML document derive from.
    /// </summary>
    /// <remarks>
    /// Annotations will not be cloned when calling <see cref="Clone"/> and <see cref="CloneNode(bool)"/>.
    /// </remarks>
    public abstract partial class OpenXmlElement : IEnumerable<OpenXmlElement>, ICloneable
    {
        private IFeatureCollection? _features;

        private string _rawOuterXml = string.Empty;

        internal MiscAttrContainer? MiscAttrContainer { get; set; }

        // attributes not defined in schema
        private List<OpenXmlAttribute>? ExtendedAttributesField
        {
            get
            {
                if (MiscAttrContainer is null)
                {
                    return null;
                }
                else
                {
                    return MiscAttrContainer.ExtendedAttributesField;
                }
            }

            set
            {
                if (MiscAttrContainer is null)
                {
                    MiscAttrContainer = new MiscAttrContainer();
                }

                MiscAttrContainer.ExtendedAttributesField = value;
            }
        }

        /// <summary>
        /// Gets a <see cref="IFeatureCollection"/> for the current element. This feature collection will be read-only, but will inherit features from its parent part and package if available.
        /// </summary>
        public IFeatureCollection Features
        {
            get
            {
                if (_features is null)
                {
                    _features = new ElementFeatureCollection(this);
                }

                return _features;
            }
        }

        private MarkupCompatibilityAttributes? McAttributesFiled
        {
            get
            {
                if (MiscAttrContainer is null)
                {
                    return null;
                }
                else
                {
                    return MiscAttrContainer.McAttributes;
                }
            }

            set
            {
                if (MiscAttrContainer is null)
                {
                    MiscAttrContainer = new MiscAttrContainer();
                }

                MiscAttrContainer.McAttributes = value;
            }
        }

        internal List<KeyValuePair<string, string>>? NamespaceDeclField
        {
            get
            {
                if (MiscAttrContainer is null)
                {
                    return null;
                }
                else
                {
                    return MiscAttrContainer.NsMappings;
                }
            }

            set
            {
                if (MiscAttrContainer is null)
                {
                    MiscAttrContainer = new MiscAttrContainer();
                }

                MiscAttrContainer.NsMappings = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlElement class.
        /// </summary>
        protected OpenXmlElement()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlElement class using the supplied outer XML of the element.
        /// </summary>
        /// <param name="outerXml">The outer XML of the element.</param>
        protected OpenXmlElement(string outerXml)
            : this()
        {
            if (!string.IsNullOrEmpty(outerXml))
            {
                if (!ValidOuterXml(outerXml, NamespaceUri, LocalName))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOuterXml, nameof(outerXml));
                }

                RawOuterXml = outerXml;
            }
        }

        #region internal properties

        /// <summary>
        /// Gets or sets the next element in the linked list.
        /// </summary>
        internal OpenXmlElement? Next { get; set; }

        /// <summary>
        /// Gets a value indicating whether the inner raw xml is parsed.
        /// </summary>
        internal bool XmlParsed => string.IsNullOrEmpty(_rawOuterXml);

        /// <summary>
        /// Gets or sets the raw OuterXml.
        /// </summary>
        internal string RawOuterXml
        {
            get => _rawOuterXml;

            set => _rawOuterXml = value ?? string.Empty;
        }

        private Framework.Metadata.ElementState _state;

        /// <summary>
        /// Gets an array of fixed attributes (attributes that are defined in the schema) without forcing any parsing of the element.
        /// If parsing is required, please use <see cref="ParsedState"/>
        /// </summary>
        private protected Framework.Metadata.ElementState RawState
        {
            get
            {
                if (_state.IsEmpty)
                {
                    _state = new Framework.Metadata.ElementState(Metadata);
                }

                return _state;
            }
        }

        internal IElementMetadata Metadata => Features.GetRequired<IElementMetadata>();

        /// <summary>
        /// Gets an array of fixed attributes which will be parsed out if they are not yet parsed. If parsing is not requried, please
        /// use <see cref="RawState"/>.
        /// </summary>
        internal Framework.Metadata.ElementState ParsedState
        {
            get
            {
                MakeSureParsed();
                return RawState;
            }
        }

        internal virtual void ConfigureMetadata(ElementMetadata.Builder builder)
        {
        }

        private protected virtual void SetAttribute<TSimpleType>(TSimpleType? value, [CallerMemberName] string propertyName = null!)
            where TSimpleType : OpenXmlSimpleType
            => ParsedState.Attributes.GetProperty(propertyName).Value = value;

        private protected TSimpleType? GetAttribute<TSimpleType>([CallerMemberName] string propertyName = null!)
            where TSimpleType : OpenXmlSimpleType
            => ParsedState.Attributes.GetProperty(propertyName).Value as TSimpleType;

        #endregion

        #region public properties

        /// <summary>
        /// Gets the OpenXmlElementContext of the current element.
        /// </summary>
        public OpenXmlElementContext? OpenXmlElementContext => RootElementContext;

        /// <summary>
        /// Gets the OpenXmlElementContext from the root element.
        /// </summary>
        internal virtual OpenXmlElementContext? RootElementContext => Parent?.RootElementContext;

        /// <summary>
        /// Gets the first child of the OpenXmlElement element.
        /// Returns null (Nothing in Visual Basic) if there is no such OpenXmlElement element.
        /// </summary>
        public virtual OpenXmlElement? FirstChild => null;

        /// <summary>
        /// Gets the last child of the OpenXmlElement element.
        /// Returns null (Nothing in Visual Basic) if there is no such OpenXmlElement element.
        /// </summary>
        public virtual OpenXmlElement? LastChild => null;

        /// <summary>
        /// Gets a value indicating whether the current element has any attributes.
        /// </summary>
        public bool HasAttributes
        {
            get
            {
                MakeSureParsed();
                if (ExtendedAttributesField is not null && ExtendedAttributesField.Count != 0)
                {
                    return true;
                }

                foreach (var value in ParsedState.Attributes)
                {
                    if (value.Value is not null)
                    {
                        return true;
                    }
                }

                if (MCAttributeCount() > 0)
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Gets all extended attributes (attributes not defined in the schema) of the current element.
        /// </summary>
        public IEnumerable<OpenXmlAttribute> ExtendedAttributes
        {
            get
            {
                MakeSureParsed();
                if (ExtendedAttributesField is not null)
                {
                    return ExtendedAttributesField;
                }
                else
                {
                    return Enumerable.Empty<OpenXmlAttribute>();
                }
            }
        }

        /// <summary>
        /// Gets a value indicating whether the current element has any child elements.
        /// </summary>
        public abstract bool HasChildren { get; }

        /// <summary>
        /// Gets all the child nodes of the current element.
        /// </summary>
        public virtual OpenXmlElementList ChildElements => HasChildren ? new OpenXmlChildElements(this) : OpenXmlElementList.Empty;

        /// <summary>
        /// Gets the parent element of the current element.
        /// </summary>
        public OpenXmlElement? Parent
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the namespace URI of the current element.
        /// </summary>
        public virtual string NamespaceUri => Metadata.QName.Namespace.Uri;

        /// <summary>
        /// Gets the local name of the current element.
        /// </summary>
        public virtual string LocalName => Metadata.QName.Name;

        internal OpenXmlQualifiedName QName => new(NamespaceUri, LocalName);

        /// <summary>
        /// Gets the namespace prefix of current element.
        /// </summary>
        public virtual string Prefix
        {
            get
            {
                MakeSureParsed();

                var prefix = LookupPrefix(NamespaceUri);

                if (!prefix.IsNullOrEmpty())
                {
                    return prefix;
                }

                return Features.GetNamespaceResolver().LookupPrefix(QName.Namespace.Uri) ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets all the namespace declarations defined in the current element. Returns an empty enumerator if there is no namespace declaration.
        /// </summary>
        public IEnumerable<KeyValuePair<string, string>> NamespaceDeclarations
        {
            get
            {
                MakeSureParsed();
                if (NamespaceDeclField is null)
                {
                    return Enumerable.Empty<KeyValuePair<string, string>>();
                }

                return NamespaceDeclField;
            }
        }

        /// <summary>
        /// Gets the qualified name of the current element.
        /// </summary>
        public virtual XmlQualifiedName XmlQualifiedName => new XmlQualifiedName(LocalName, NamespaceUri);

        /// <summary>
        /// Gets the qualified name of the current element.
        /// </summary>
        public virtual XName XName => XName.Get(LocalName, NamespaceUri);

        /// <summary>
        /// Gets or sets the concatenated values of the node and all of its children.
        /// </summary>
        public virtual string InnerText
        {
            get => string.Empty;
            protected set => throw new InvalidOperationException();
        }

        /// <summary>
        /// Gets or sets the markup that represents only the child elements of the current element.
        /// </summary>
        public virtual string InnerXml
        {
            get
            {
                if (XmlParsed)
                {
                    using (var w = new StringWriter(CultureInfo.InvariantCulture))
                    {
                        using (var writer2 = new XmlDOMTextWriter(w))
                        {
                            WriteContentTo(writer2);
                        }

                        return w.ToString();
                    }
                }
                else
                {
                    using (TextReader stringReader = new StringReader(RawOuterXml))
                    using (var xmlReader = XmlConvertingReaderFactory.Create(stringReader, Features.GetNamespaceResolver()))
                    {
                        xmlReader.Read();
                        return xmlReader.ReadInnerXml();
                    }
                }
            }

            set => throw new InvalidOperationException(ExceptionMessages.InnerXmlCannotBeSet);
        }

        /// <summary>
        /// Gets the markup that represents the current element and all of its child elements.
        /// </summary>
        public string OuterXml
        {
            get
            {
                if (XmlParsed)
                {
                    // namespace, this element and attributes
                    using (var w = new StringWriter(CultureInfo.InvariantCulture))
                    {
                        using (var writer2 = new XmlDOMTextWriter(w))
                        {
                            WriteTo(writer2);
                        }

                        return w.ToString();
                    }
                }
                else
                {
                    return RawOuterXml;
                }
            }

            internal set
            {
                if (XmlParsed)
                {
                    RemoveAllChildren();
                    NamespaceDeclField = null;
                    ExtendedAttributesField = null;

                    foreach (var attribute in RawState.Attributes)
                    {
                        attribute.Value = null;
                    }

                    MCAttributes = null;
                }

                if (!string.IsNullOrEmpty(value))
                {
                    RawOuterXml = value;
                }
                else
                {
                    _rawOuterXml = string.Empty;
                }
            }
        }

        #endregion

        #region public methods

        /// <summary>
        /// Gets an Open XML attribute with the specified tag name and namespace URI.
        /// </summary>
        /// <param name="localName">The tag name.</param>
        /// <param name="namespaceUri">The namespace URI.</param>
        /// <returns>Returns a clone of the OpenXmlAttribute with local name equal to "localName" and namespace URI equal to "namespaceUri".</returns>
        /// <exception cref="ArgumentOutOfRangeException">When the "localName" is empty.</exception>
        /// <exception cref="KeyNotFoundException">When the element does not have the specified attribute.</exception>
        public OpenXmlAttribute GetAttribute(string localName, string namespaceUri)
        {
            if (localName is null)
            {
                throw new ArgumentNullException(nameof(localName));
            }

            if (namespaceUri is null)
            {
                // treat null string as empty.
                namespaceUri = string.Empty;
            }

            if (localName.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(localName), ExceptionMessages.StringIsEmpty);
            }

            return GetAttribute(new(namespaceUri, localName));
        }

        private OpenXmlAttribute GetAttribute(in OpenXmlQualifiedName qname)
        {
            if (HasAttributes)
            {
                foreach (var attribute in ParsedState.Attributes)
                {
                    if (attribute.Value is not null && attribute.Property.QName.Equals(qname))
                    {
                        var prefix = Features.GetNamespaceResolver().LookupPrefix(qname.Namespace.Uri) ?? string.Empty;
                        return new OpenXmlAttribute(qname, prefix, attribute.Value.InnerText);
                    }
                }

                foreach (var extendedAttribute in ExtendedAttributes)
                {
                    if (extendedAttribute.QName.Equals(qname))
                    {
                        // clone a copy
                        return new OpenXmlAttribute(extendedAttribute.Prefix, extendedAttribute.LocalName, extendedAttribute.NamespaceUri, extendedAttribute.Value);
                    }
                }

                if (qname.Namespace.Uri == AlternateContent.MarkupCompatibilityNamespace)
                {
                    return GetMCAttribute(qname.Name);
                }
            }

            throw new KeyNotFoundException(ExceptionMessages.CannotFindAttribute);
        }

        /// <summary>
        /// Gets a list that contains a copy of all the attributes.
        /// </summary>
        /// <returns>A list of attributes. Return an empty list if there are no attributes.</returns>
        /// <remarks>The returned list is a non-live copy.</remarks>
        public IList<OpenXmlAttribute> GetAttributes()
        {
            if (HasAttributes)
            {
                var resolver = Features.GetNamespaceResolver();
                var attributes = new List<OpenXmlAttribute>();

                foreach (var attribute in ParsedState.Attributes)
                {
                    if (attribute.Value is not null)
                    {
                        var qname = attribute.Property.QName;
                        var prefix = resolver.LookupPrefix(qname.Namespace.Uri) ?? string.Empty;
                        attributes.Add(new OpenXmlAttribute(qname, prefix, attribute.Value.InnerText));
                    }
                }

                attributes.AddRange(ExtendedAttributes);

                if (MCAttributes is not null)
                {
                    AddMCAttributes(attributes);
                }

                return attributes;
            }
            else
            {
                return Cached.Array<OpenXmlAttribute>();
            }
        }

        /// <summary>
        /// Sets an attribute to the specified element.
        /// If the attribute is a known attribute, the value of the attribute is set.
        /// If the attribute is an extended attribute, the 'openxmlAttribute' is added to the extended attributes list.
        /// </summary>
        /// <param name="openXmlAttribute">The attribute to be set on the element.</param>
        /// <exception cref="ArgumentNullException">Thrown when the LocalName of the "openxmlAttribute" parameter is null or empty.</exception>
        /// <exception cref="InvalidOperationException">Thrown when an attempt to set a namespace declaration is made.</exception>
        public void SetAttribute(OpenXmlAttribute openXmlAttribute)
        {
            if (string.IsNullOrEmpty(openXmlAttribute.LocalName))
            {
                throw new ArgumentOutOfRangeException(nameof(openXmlAttribute), ExceptionMessages.LocalNameIsNull);
            }

            if (openXmlAttribute.Prefix == OpenXmlElementContext.XmlnsPrefix)
            {
                throw new InvalidOperationException(ExceptionMessages.CannotSetAttribute);
            }

            MakeSureParsed();
            if (!TrySetFixedAttribute(openXmlAttribute.QName, openXmlAttribute.Value, false))
            {
                if (openXmlAttribute.NamespaceUri == AlternateContent.MarkupCompatibilityNamespace)
                {
                    if (LoadMCAttribute(openXmlAttribute.LocalName, openXmlAttribute.Value))
                    {
                        return;
                    }
                }

                var index = 0;

                // remove the old one if there is
                if (ExtendedAttributesField is not null)
                {
                    foreach (var extendedAttibute in ExtendedAttributesField)
                    {
                        if (extendedAttibute.LocalName == openXmlAttribute.LocalName &&
                            extendedAttibute.NamespaceUri == openXmlAttribute.NamespaceUri)
                        {
                            ExtendedAttributesField.RemoveAt(index);
                            break;
                        }

                        index++;
                    }
                }

                if (ExtendedAttributesField is null)
                {
                    ExtendedAttributesField = new List<OpenXmlAttribute>();
                }

                var attribute = new OpenXmlAttribute(openXmlAttribute.Prefix, openXmlAttribute.LocalName, openXmlAttribute.NamespaceUri, openXmlAttribute.Value);
                ExtendedAttributesField.Add(attribute);
            }
        }

        /// <summary>
        /// Removes the attribute from the current element.
        /// </summary>
        /// <param name="localName">The local name of the attribute.</param>
        /// <param name="namespaceUri">The namespace URI of the attribute.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the localName is empty.</exception>
        public void RemoveAttribute(string localName, string namespaceUri)
        {
            if (localName is null)
            {
                throw new ArgumentNullException(nameof(localName));
            }

            if (namespaceUri is null)
            {
                // treat null string as empty.
                namespaceUri = string.Empty;
            }

            if (localName.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(localName), ExceptionMessages.StringIsEmpty);
            }

            RemoveAttribute(new(namespaceUri, localName));
        }

        private void RemoveAttribute(in OpenXmlQualifiedName qname)
        {
            if (HasAttributes)
            {
                // get attribute namespace ID
                var attribute = RawState.Attributes[qname];
                if (!attribute.IsNil)
                {
                    attribute.Value = null;
                }
                else
                {
                    var index = 0;
                    if (ExtendedAttributesField is not null)
                    {
                        foreach (var extendedAttribute in ExtendedAttributesField)
                        {
                            if (extendedAttribute.QName.Equals(qname))
                            {
                                ExtendedAttributesField.RemoveAt(index);
                                return;
                            }

                            index++;
                        }
                    }
                }

                // try remove MC attribute
                if (qname.Namespace.Uri == AlternateContent.MarkupCompatibilityNamespace)
                {
                    RemoveMCAttribute(qname.Name);
                }
            }
        }

        /// <summary>
        /// Sets a number of attributes to the element.
        /// If an attribute is a known attribute, the value of the attribute is set.
        /// If an attribute is an extended attribute, the 'openxmlAttribute' is added to the extended attributes list.
        /// </summary>
        /// <param name="openXmlAttributes">The attributes to be set on the element.</param>
        public void SetAttributes(IEnumerable<OpenXmlAttribute> openXmlAttributes)
        {
            if (openXmlAttributes is null)
            {
                throw new ArgumentNullException(nameof(openXmlAttributes));
            }

            foreach (var attribute in openXmlAttributes)
            {
                SetAttribute(attribute);
            }
        }

        /// <summary>
        /// Clears all of the attributes, including both known attributes and extended attributes.
        /// </summary>
        public void ClearAllAttributes()
        {
            MakeSureParsed();

            // clear known attributes defined in schema
            foreach (var attribute in RawState.Attributes)
            {
                attribute.Value = null;
            }

            // clear extended attributes
            ExtendedAttributesField = null;

            MCAttributes = null;
        }

        /// <summary>
        /// Adds a namespace declaration to the current node.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="uri">The uri.</param>
        /// <exception cref="InvalidOperationException">Thrown if the prefix is already used in the current node.</exception>
        public void AddNamespaceDeclaration(string prefix, string uri)
        {
            if (string.IsNullOrEmpty(prefix))
            {
                throw new ArgumentNullException(nameof(prefix));
            }

            if (string.IsNullOrEmpty(uri))
            {
                throw new ArgumentNullException(nameof(uri));
            }

            MakeSureParsed();
            if (NamespaceDeclField is null)
            {
                NamespaceDeclField = new List<KeyValuePair<string, string>>();
            }
            else
            {
                foreach (var item in NamespaceDeclField)
                {
                    if (item.Key == prefix)
                    {
                        throw new InvalidOperationException(SR.Format(ExceptionMessages.DuplicatedPrefix, prefix));
                    }
                }
            }

            NamespaceDeclField.Add(new KeyValuePair<string, string>(prefix, uri));
        }

        /// <summary>
        /// Removes the namespace declaration for the specified prefix. Removes nothing if there is no prefix.
        /// </summary>
        /// <param name="prefix"></param>
        public void RemoveNamespaceDeclaration(string prefix)
        {
            if (string.IsNullOrEmpty(prefix))
            {
                throw new ArgumentNullException(nameof(prefix));
            }

            MakeSureParsed();
            if (NamespaceDeclField is not null)
            {
                for (var i = 0; i < NamespaceDeclField.Count; i++)
                {
                    if (NamespaceDeclField[i].Key == prefix)
                    {
                        NamespaceDeclField.RemoveAt(i);
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Finds the first child element in type T.
        /// </summary>
        /// <typeparam name="T">Type of element.</typeparam>
        /// <returns></returns>
        public T? GetFirstChild<T>()
            where T : OpenXmlElement
            => ChildElements.First<T>();

        /// <summary>
        /// Gets the OpenXmlElement element that immediately precedes the current OpenXmlElement element.
        /// Returns null (Nothing in Visual Basic ) if there is no preceding OpenXmlElement element.
        /// </summary>
        /// <returns>The OpenXmlElement element that immediately precedes the current OpenXmlElement element.</returns>
        public OpenXmlElement? PreviousSibling()
        {
            if (Parent is not OpenXmlCompositeElement parent)
            {
                return null;
            }

            var firstChild = parent.FirstChild;

            while (firstChild is not null)
            {
                var nextSibling = firstChild.NextSibling();
                if (nextSibling == this)
                {
                    return firstChild;
                }

                firstChild = nextSibling;
            }

            return firstChild;
        }

        /// <summary>
        /// Gets the OpenXmlElement element with the specified type that precedes the current OpenXmlElement.
        /// Returns null (Nothing in Visual Basic) if there is no preceding OpenXmlElement element.
        /// </summary>
        /// <returns>The OpenXmlElement element with the specified type that precedes the current OpenXmlElement element.</returns>
        public T? PreviousSibling<T>()
            where T : OpenXmlElement
        {
            var element = PreviousSibling();

            while (element is not null)
            {
                if (element is T t)
                {
                    return t;
                }

                element = element.PreviousSibling();
            }

            return null;
        }

        /// <summary>
        /// Gets the OpenXmlElement element that immediately follows the current OpenXmlElement element.
        /// Returns null (Nothing in Visual Basic) if there is no next OpenXmlElement element.
        /// </summary>
        /// <returns>The OpenXmlElement element that immediately follows the current OpenXmlElement element.</returns>
        public OpenXmlElement? NextSibling()
        {
            var parentNode = Parent;
            if ((parentNode is not null) && (Next != parentNode.FirstChild))
            {
                return Next;
            }

            return null;
        }

        /// <summary>
        /// Gets the OpenXmlElement element with the specified type that follows the current OpenXmlElement element.
        /// Returns null (Nothing in Visual Basic) if there is no next OpenXmlElement.
        /// </summary>
        /// <returns>The OpenXmlElement element with the specified type that follows the current OpenXmlElement element.</returns>
        public T? NextSibling<T>()
            where T : OpenXmlElement
        {
            var element = NextSibling();

            while (element is not null)
            {
                if (element is T t)
                {
                    return t;
                }

                element = element.NextSibling();
            }

            return null;
        }

        /// <summary>
        /// Enumerates all of the current element's ancestors.
        /// </summary>
        /// <returns>An IEnumerable object that contains a list of the current OpenXmlElement element's ancestors.</returns>
        public IEnumerable<OpenXmlElement> Ancestors()
        {
            var ancestor = Parent;

            while (ancestor is not null)
            {
                yield return ancestor;
                ancestor = ancestor.Parent;
            }
        }

        /// <summary>
        /// Enumerates only the current element's ancestors that have the specified type.
        /// </summary>
        /// <typeparam name="T">The element type.</typeparam>
        /// <returns>An IEnumerable object that contains a list of the current OpenXmlElement element's ancestors.</returns>
        public IEnumerable<T> Ancestors<T>()
            where T : OpenXmlElement
        {
            var ancestor = Parent;

            while (ancestor is not null)
            {
                if (ancestor is T t)
                {
                    yield return t;
                }

                ancestor = ancestor.Parent;
            }
        }

        /// <summary>
        /// Enumerates only the current element's children that have the specified type.
        /// </summary>
        /// <typeparam name="T">The element type.</typeparam>
        /// <returns></returns>
        public IEnumerable<T> Elements<T>()
            where T : OpenXmlElement
            => ChildElements.OfType<T>();

        /// <summary>
        /// Enumerates all of the current element's children.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OpenXmlElement> Elements() => ChildElements;

        /// <summary>
        /// Enumerate all of the current element's descendants of type T.
        /// </summary>
        /// <typeparam name="T">The element type.</typeparam>
        /// <returns></returns>
        public IEnumerable<T> Descendants<T>()
            where T : OpenXmlElement
        {
            foreach (var element in Descendants())
            {
                if (element is T elementT)
                {
                    yield return elementT;
                }
            }
        }

        /// <summary>
        /// Enumerates all of the current element's descendants.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OpenXmlElement> Descendants()
        {
            if (FirstChild is null)
            {
                yield break;
            }

            var root = FirstChild;

            yield return root;

            var stack = new Stack<OpenXmlElement>();

            stack.Push(root);

            while (stack.Count > 0)
            {
                var topElement = stack.Peek();
                var firstChildInTopElement = topElement.FirstChild;

                if (topElement == root && firstChildInTopElement is not null)
                {
                    root = firstChildInTopElement;
                    stack.Push(root);
                    yield return root;
                }
                else
                {
                    var nextSiblingElement = topElement.NextSibling();
                    stack.Pop();
                    if (nextSiblingElement is not null)
                    {
                        root = nextSiblingElement;
                        stack.Push(root);
                        yield return root;
                    }
                }
            }
        }

        /// <summary>
        /// Enumerates all of the sibling elements that precede the current element and have the same parent as the current element.
        /// </summary>
        /// <returns>An IEnumerable object that contains a list of OpenXmlElement elements.</returns>
        public IEnumerable<OpenXmlElement> ElementsBefore()
        {
            if (Parent is not null)
            {
                var element = Parent.FirstChild;

                while (element != this && element is not null)
                {
                    yield return element;

                    element = element.NextSibling();
                }
            }
        }

        /// <summary>
        /// Enumerates all of the sibling elements that follow the current element and have the same parent as the current element.
        /// </summary>
        /// <returns>An IEnumerable object that contains a list of OpenXmlElement elements.</returns>
        public IEnumerable<OpenXmlElement> ElementsAfter()
        {
            if (Parent is not null)
            {
                var element = NextSibling();

                while (element is not null)
                {
                    yield return element;

                    element = element.NextSibling();
                }
            }
        }

        /// <summary>
        /// When overridden in a derived class, creates a duplicate of the node.
        /// </summary>
        /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
        /// <returns>The cloned node. </returns>
        public virtual OpenXmlElement CloneNode(bool deep) => throw new NotImplementedException(ExceptionMessages.NonImplemented);

        /// <summary>
        /// Saves the current node to the specified XmlWriter.
        /// </summary>
        /// <param name="xmlWriter">The XmlWriter to which to save the current node. </param>
        public virtual void WriteTo(XmlWriter xmlWriter)
        {
            if (xmlWriter is null)
            {
                throw new ArgumentNullException(nameof(xmlWriter));
            }

            if (XmlParsed)
            {
                // check the namespace mapping defined in this node first. because till now xmlWriter don't know the mapping defined in the current node.
                var prefix = LookupPrefixLocal(NamespaceUri);

                // if not defined in the current node, try the xmlWriter
                if (string.IsNullOrEmpty(prefix))
                {
                    prefix = xmlWriter.LookupPrefix(NamespaceUri);
                }

                // if xmlWriter didn't find it, it means the node is constructed by user and is not in the tree yet
                // in this case, we use the predefined prefix
                if (string.IsNullOrEmpty(prefix))
                {
                    prefix = Features.GetNamespaceResolver().LookupPrefix(QName.Namespace.Uri);
                }

                xmlWriter.WriteStartElement(prefix, LocalName, NamespaceUri);
                WriteAttributesTo(xmlWriter);
                WriteContentTo(xmlWriter);
                xmlWriter.WriteEndElement();
            }
            else
            {
                xmlWriter.WriteRaw(RawOuterXml);
            }
        }

        /// <summary>
        /// Appends each element from a list of elements to the end of the current element's list of child elements.
        /// </summary>
        /// <param name="newChildren">The list that contains the OpenXmlElement elements to be appended.</param>
        public void Append(IEnumerable<OpenXmlElement> newChildren)
        {
            if (newChildren is null)
            {
                throw new ArgumentNullException(nameof(newChildren));
            }

            foreach (var child in newChildren)
            {
                AppendChild(child);
            }
        }

        /// <summary>
        /// Appends each element from an array of elements to the end of the current element's list of child elements.
        /// </summary>
        /// <param name="newChildren">The array of <see cref="OpenXmlElement"/> elements to be appended.</param>
        public void Append(params OpenXmlElement[] newChildren)
        {
            if (newChildren is not null)
            {
                foreach (var child in newChildren)
                {
                    AppendChild(child);
                }
            }
        }

        /// <summary>
        /// Appends the specified element to the end of the current element's list of child nodes.
        /// </summary>
        /// <param name="newChild">The <see cref="OpenXmlElement"/> element to append.</param>
        /// <returns>The <see cref="OpenXmlElement"/> element that was appended. </returns>
        [return: NotNullIfNotNull("newChild")]
        public virtual T? AppendChild<T>(T? newChild)
            where T : OpenXmlElement
            => throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);

        /// <summary>
        /// Inserts the specified element immediately after the specified reference element.
        /// </summary>
        /// <param name="newChild">The <see cref="OpenXmlElement"/> element to insert.</param>
        /// <param name="referenceChild">The reference <see cref="OpenXmlElement"/> element. <paramref name="newChild"/> is placed after <paramref name="referenceChild"/>. </param>
        /// <returns>The <see cref="OpenXmlElement"/> element that was inserted.</returns>
        [return: NotNullIfNotNull("newChild")]
        public virtual T? InsertAfter<T>(T? newChild, OpenXmlElement? referenceChild)
            where T : OpenXmlElement
            => throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);

        /// <summary>
        /// Inserts the specified element immediately before the specified reference element.
        /// </summary>
        /// <param name="newChild">The <see cref="OpenXmlElement"/> element to insert.</param>
        /// <param name="referenceChild">The reference <see cref="OpenXmlElement"/> element. <paramref name="newChild"/> is placed before <paramref name="referenceChild"/>.</param>
        /// <returns>The <see cref="OpenXmlElement"/> element that was inserted.</returns>
        [return: NotNullIfNotNull("newChild")]
        public virtual T? InsertBefore<T>(T? newChild, OpenXmlElement? referenceChild)
            where T : OpenXmlElement
            => throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);

        /// <summary>
        /// Inserts the specified element immediately after the current element.
        /// </summary>
        /// <param name="newElement">The new element to insert.</param>
        /// <returns>The inserted element.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="newElement"/> parameter is a null reference.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the parent is a null reference.</exception>
        public T InsertAfterSelf<T>(T newElement)
            where T : OpenXmlElement
        {
            if (newElement is null)
            {
                throw new ArgumentNullException(nameof(newElement));
            }

            if (Parent is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ParentIsNull);
            }

            return Parent.InsertAfter(newElement, this);
        }

        /// <summary>
        /// Inserts the specified element immediately before the current element.
        /// </summary>
        /// <param name="newElement">The new element to insert.</param>
        /// <returns>The inserted element.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="newElement"/> parameter is a null reference.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the parent is a null reference.</exception>
        public T InsertBeforeSelf<T>(T newElement)
            where T : OpenXmlElement
        {
            if (newElement is null)
            {
                throw new ArgumentNullException(nameof(newElement));
            }

            if (Parent is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ParentIsNull);
            }

            return Parent.InsertBefore(newElement, this);
        }

        /// <summary>
        /// Inserts the specified element at the specified index in the current element's list of child elements.
        /// </summary>
        /// <param name="newChild">The <see cref="OpenXmlElement"/> element to insert.</param>
        /// <param name="index">The zero-based index where the element is to be inserted.</param>
        /// <returns>The <see cref="OpenXmlElement"/> element that was inserted.</returns>
        /// <remarks>Returns <c>null</c>if <paramref name="newChild"/> equals <c>null</c>.</remarks>
        [return: NotNullIfNotNull("newChild")]
        public virtual T? InsertAt<T>(T? newChild, int index)
            where T : OpenXmlElement
            => throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);

        /// <summary>
        /// Inserts the specified element at the beginning of the current element's list of child elements.
        /// </summary>
        /// <param name="newChild">The <see cref="OpenXmlElement"/> element to add.</param>
        /// <returns>The <see cref="OpenXmlElement"/> element that was added.</returns>
        [return: NotNullIfNotNull("newChild")]
        public virtual T? PrependChild<T>(T? newChild)
            where T : OpenXmlElement
            => throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);

        /// <summary>
        /// Removes the specified child element from the current element's list of child elements.
        /// </summary>
        /// <param name="oldChild">The child element to remove. </param>
        /// <returns>The element that was removed. </returns>
        [return: NotNullIfNotNull("newChild")]
        public virtual T? RemoveChild<T>(T? oldChild)
            where T : OpenXmlElement
            => throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);

        /// <summary>
        /// Replaces a child element with another child element in the current element's list of child elements.
        /// </summary>
        /// <param name="newChild">The new child element to put in the list.</param>
        /// <param name="oldChild">The child element to replace in the list.</param>
        /// <returns>The <see cref="OpenXmlElement"/> element that was replaced.</returns>
        [return: NotNullIfNotNull("newChild")]
        public virtual T? ReplaceChild<T>(OpenXmlElement newChild, T? oldChild)
            where T : OpenXmlElement
            => throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);

        /// <summary>
        /// Removes all of the current element's child elements.
        /// </summary>
        public abstract void RemoveAllChildren();

        /// <summary>
        /// Remove all of the current element's child elements that are of type T.
        /// </summary>
        public void RemoveAllChildren<T>()
            where T : OpenXmlElement
        {
            var element = FirstChild;

            while (element is not null)
            {
                var next = element.NextSibling();

                if (element is T)
                {
                    RemoveChild(element);
                }

                element = next;
            }
        }

        /// <summary>
        /// Removes the current element from its parent.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when the parent is a null reference.</exception>
        public void Remove()
        {
            if (Parent is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ParentIsNull);
            }

            Parent.RemoveChild(this);
        }

        /// <summary>
        /// Determines if the current element appears after a specified element in document order.
        /// </summary>
        /// <param name="element">The element to compare for order.</param>
        /// <returns>Returns true if the current element appears after the specified element in document order; otherwise returns false.</returns>
        public bool IsAfter(OpenXmlElement element)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            return GetOrder(this, element) == ElementOrder.After;
        }

        /// <summary>
        /// Determines if the current element appears before a specified element in document order.
        /// </summary>
        /// <param name="element">The element to compare for order.</param>
        /// <returns>Returns true if the current element appears before the specified element in document order; otherwise returns false.</returns>
        public bool IsBefore(OpenXmlElement element)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            return GetOrder(this, element) == ElementOrder.Before;
        }

        private enum ElementOrder
        {
            Same, // same element
            Before,
            After,
            NotInSameTree,
        }

        /// <summary>
        /// Gets the order of the two specified elements in document order.
        /// </summary>
        /// <param name="element1">The first element to compare for order.</param>
        /// <param name="element2">The second element to compare for order.</param>
        /// <returns></returns>
        private static ElementOrder GetOrder(OpenXmlElement element1, OpenXmlElement element2)
        {
            if (element1.Parent is null && element2.Parent is null)
            {
                return ElementOrder.NotInSameTree;
            }
            else if (ReferenceEquals(element1.Parent, element2.Parent))
            {
                return GetSiblingOrder(element1, element2);
            }
            else
            {
                var element1Ancestors = new Stack<OpenXmlElement>();
                var element2Ancestors = new Stack<OpenXmlElement>();

                element1Ancestors.Push(element1);
                element2Ancestors.Push(element2);

                foreach (var ancestor in element1.Ancestors())
                {
                    element1Ancestors.Push(ancestor);
                }

                foreach (var ancestor in element2.Ancestors())
                {
                    element2Ancestors.Push(ancestor);
                }

                var thisAncestor = element1Ancestors.Pop();
                var targetAncestor = element2Ancestors.Pop();

                if (thisAncestor == targetAncestor)
                {
                    while (element1Ancestors.Count > 0 && element2Ancestors.Count > 0)
                    {
                        thisAncestor = element1Ancestors.Pop();
                        targetAncestor = element2Ancestors.Pop();

                        var order = GetSiblingOrder(thisAncestor, targetAncestor);

                        if (order == ElementOrder.Same)
                        {
                            continue;
                        }
                        else
                        {
                            return order;
                        }
                    }

                    // case: one is ancestor of another
                    if (element1Ancestors.Count == 0)
                    {
                        return ElementOrder.Before;
                    }
                    else
                    {
                        return ElementOrder.After;
                    }
                }
                else
                {
                    // case: not in same tree
                    return ElementOrder.NotInSameTree;
                }
            }
        }

        private static ElementOrder GetSiblingOrder(OpenXmlElement element1, OpenXmlElement element2)
        {
            Debug.Assert(element1.Parent == element2.Parent);

            if (element1 == element2)
            {
                return ElementOrder.Same;
            }

            var element = element1.NextSibling();

            while (element is not null)
            {
                if (ReferenceEquals(element, element2))
                {
                    // element1 before element2
                    return ElementOrder.Before;
                }

                element = element.NextSibling();
            }

#if DEBUG
            element = element1.PreviousSibling();

            while (element is not null)
            {
                if (ReferenceEquals(element, element2))
                {
                    break;
                }

                element = element.PreviousSibling();
            }

            Debug.Assert(element == element2);
#endif
            return ElementOrder.After;
        }

        private protected virtual void WriteAttributesTo(XmlWriter xmlWriter)
        {
            // write the namespace declaration first, so the inner attribute will get the right prefix
            if (NamespaceDeclField is not null)
            {
                foreach (var item in NamespaceDeclField)
                {
                    xmlWriter.WriteAttributeString(OpenXmlElementContext.XmlnsPrefix, item.Key, OpenXmlElementContext.XmlnsUri, item.Value);
                }
            }

            if (XmlParsed && HasAttributes)
            {
                foreach (var attribute in ParsedState.Attributes)
                {
                    if (attribute.Value is not null)
                    {
                        var ns = attribute.Property.QName.Namespace.Uri;
                        var prefix = string.Empty;

                        if (!string.IsNullOrEmpty(ns))
                        {
                            prefix = xmlWriter.LookupPrefix(ns);
                            if (string.IsNullOrEmpty(prefix))
                            {
                                prefix = Features.GetNamespaceResolver().LookupPrefix(attribute.Property.QName.Namespace.Uri);
                            }
                        }

                        xmlWriter.WriteStartAttribute(prefix, attribute.Property.QName.Name, ns);
                        xmlWriter.WriteString(attribute.Value.InnerText);
                        xmlWriter.WriteEndAttribute();
                    }
                }

                foreach (var attribute in ExtendedAttributes)
                {
                    xmlWriter.WriteAttributeString(attribute.Prefix, attribute.LocalName, attribute.NamespaceUri, attribute.Value);
                }

                WriteMCAttribute(xmlWriter);
            }
        }

        #endregion

        #region internal methods

        /// <summary>
        /// Saves all of the children of the current node to the specified XmlWriter.
        /// </summary>
        /// <param name="w">The XmlWriter at which to save the child nodes. </param>
        internal abstract void WriteContentTo(XmlWriter w);

        private protected virtual bool StrictTranslateAttribute(in OpenXmlQualifiedName qname, string? value) => TrySetFixedAttribute(qname, value, false);

        /// <summary>
        /// Attempts to set the attribute to a known attribute.
        /// </summary>
        /// <param name="qname"></param>
        /// <param name="value"></param>
        /// <param name="strictRelationshipFound"></param>
        /// <returns>true if the attribute is a known attribute.</returns>
        private protected virtual bool TrySetFixedAttribute(in OpenXmlQualifiedName qname, string? value, bool strictRelationshipFound)
        {
            if (RawState.Attributes.Any())
            {
                if (strictRelationshipFound)
                {
                    return StrictTranslateAttribute(qname, value);
                }

                var attribute = RawState.Attributes[qname];

                if (!attribute.IsNil)
                {
                    if (attribute.Value is null)
                    {
                        attribute.Value = attribute.Property.CreateNew();
                    }

                    attribute.Value.InnerText = value;
                    return true;
                }
            }

            return false;
        }

        internal virtual void LoadAttributes(XmlReader xmlReader)
        {
            Debug.Assert(xmlReader.NodeType == XmlNodeType.Element);

            // read attributes
            if (xmlReader.HasAttributes)
            {
                var resolver = Features.GetNamespaceResolver();

                while (xmlReader.MoveToNextAttribute())
                {
                    if (!TrySetFixedAttribute(new(xmlReader.NamespaceURI, xmlReader.LocalName), xmlReader.Value, ((XmlConvertingReader)xmlReader).StrictRelationshipFound))
                    {
                        if (xmlReader.NamespaceURI == AlternateContent.MarkupCompatibilityNamespace)
                        {
                            if (LoadMCAttribute(xmlReader.LocalName, xmlReader.Value))
                            {
                                continue;
                            }

                            // if we cannot recognize the local name with the mc prefix, load it as extended properties
                        }

                        // a attribute is (xmlns:nnn=".....")
                        // bool attributeIsXmlnsDefination = this.IsXmlnsUri(xmlReader.NamespaceURI);
                        var attributeIsXmlnsDefination = xmlReader.NamespaceURI == OpenXmlElementContext.XmlnsUri;

                        if (!attributeIsXmlnsDefination)
                        {
                            // do not add xmlns:x="...." as attribute
                            if (ExtendedAttributesField is null)
                            {
                                ExtendedAttributesField = new List<OpenXmlAttribute>();
                            }

                            ExtendedAttributesField.Add(new OpenXmlAttribute(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI, xmlReader.Value));
                        }
                        else
                        {
                            // don't add declaration for case like xmlns="global namespace uri"
                            if (!string.IsNullOrEmpty(xmlReader.Prefix))
                            {
                                if (NamespaceDeclField is null)
                                {
                                    NamespaceDeclField = new List<KeyValuePair<string, string>>();
                                }

                                NamespaceDeclField.Add(new KeyValuePair<string, string>(xmlReader.LocalName, xmlReader.Value));
                            }
                        }
                    }
                }

                RemoveAttributesBasedonMC();

                // Moves the reader back to the element node.
                xmlReader.MoveToElement();
            }
        }

        /// <summary>
        /// Reads MC attributes from the xmlReader and than pushes MC Context on needed.
        /// This xmlReader will keeps on the element start after this method.
        /// </summary>
        /// <param name="xmlReader">This method screen all attribute from xmlReader, and then set the xmlReader back to the element start.</param>
        /// <returns>Returns true if a MCAttributes is pushed.</returns>
        private protected bool PushMcContext(XmlReader xmlReader)
        {
            Debug.Assert(xmlReader.NodeType == XmlNodeType.Element);

            if (OpenXmlElementContext is not null && OpenXmlElementContext.MCSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess)
            {
                OpenXmlElementContext.MCContext.LookupNamespaceDelegate = xmlReader.LookupNamespace;

                var mcAttributes = LoadMCAttribute(xmlReader);

                if (mcAttributes is not null)
                {
                    OpenXmlElementContext.MCContext.PushMCAttributes(mcAttributes);
                    if (OpenXmlElementContext.ACBlockLevel == 0)
                    {
                        CheckMustUnderstandAttr(xmlReader, mcAttributes, OpenXmlElementContext.MCSettings);
                    }

                    return true;
                }
            }
            else
            {
                // no need to process MC attributes, just return.
            }

            return false;
        }

        private protected void PopMcContext()
        {
            if (OpenXmlElementContext is not null && OpenXmlElementContext.MCSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess)
            {
                OpenXmlElementContext.MCContext.PopMCAttributes();
            }
            else
            {
                // no need to process MC attributes, just return.
            }
        }

        /// <summary>
        /// If this is a normal node, check <c>mustunderstand</c> attribute at load time
        /// </summary>
        /// <param name="reader">The XmlReader.</param>
        /// <param name="mcAttributes">The MarkupCompatibilityAttributes.</param>
        /// <param name="mcSettings">The MarkupCompatibilityProcessSettings.</param>
        private protected void CheckMustUnderstandAttr(XmlReader reader, MarkupCompatibilityAttributes mcAttributes, MarkupCompatibilityProcessSettings mcSettings)
        {
            Debug.Assert(mcSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess);

            if (mcAttributes.MustUnderstand is not null && !string.IsNullOrEmpty(mcAttributes.MustUnderstand.Value))
            {
                var resolver = Features.GetNamespaceResolver();
                var prefixes = mcAttributes.MustUnderstand.Value!.Trim().Split(new char[] { ' ' });

                foreach (var prefix in prefixes)
                {
                    var uri = reader.LookupNamespace(prefix);

                    if (uri is null)
                    {
                        throw new InvalidMCContentException(SR.Format(ExceptionMessages.UnknowMCContent, mcAttributes.MustUnderstand.Value));
                    }

                    var ns = new OpenXmlNamespace(uri);

                    if (resolver.HasVersion(ns, mcSettings.TargetFileFormatVersions))
                    {
                        continue;
                    }

                    throw new NamespaceNotUnderstandException(SR.Format(ExceptionMessages.NsNotUnderStand, prefix));
                }
            }
        }

        /// <summary>
        /// If this is a node in ACB, check <c>mustunderstand</c> after load
        /// </summary>
        internal void CheckMustUnderstandAttr()
        {
            if (MCAttributes is null || OpenXmlElementContext is null || OpenXmlElementContext.MCSettings.ProcessMode == MarkupCompatibilityProcessMode.NoProcess)
            {
                return;
            }

            if (MCAttributes.MustUnderstand is not null && !string.IsNullOrEmpty(MCAttributes.MustUnderstand.Value))
            {
                var resolver = Features.GetNamespaceResolver();
                var prefixes = MCAttributes.MustUnderstand.Value!.Trim().Split(new char[] { ' ' });

                foreach (var prefix in prefixes)
                {
                    var uri = LookupNamespace(prefix);

                    if (uri is null)
                    {
                        throw new InvalidMCContentException(SR.Format(ExceptionMessages.UnknowMCContent, MCAttributes.MustUnderstand.Value));
                    }

                    var ns = new OpenXmlNamespace(uri);

                    if (resolver.HasVersion(ns, OpenXmlElementContext.MCSettings.TargetFileFormatVersions))
                    {
                        continue;
                    }

                    throw new NamespaceNotUnderstandException(SR.Format(ExceptionMessages.NsNotUnderStand, prefix));
                }
            }

            foreach (var child in ChildElements)
            {
                child.CheckMustUnderstandAttr();
            }
        }

        internal void Load(XmlReader xmlReader, OpenXmlLoadMode loadMode)
        {
            switch (loadMode)
            {
                case OpenXmlLoadMode.Full:
                    Populate(xmlReader, loadMode);
                    break;

                case OpenXmlLoadMode.Lazy:
                    if (OpenXmlElementContext is not null && xmlReader.Depth < OpenXmlElementContext.LazySteps)
                    {
                        Populate(xmlReader, loadMode);
                    }
                    else
                    {
                        LazyLoad(xmlReader);
                    }

                    break;
            }
        }

        internal void MakeSureParsed()
        {
            if (XmlParsed)
            {
                return;
            }

            ParseXml();

            // Set raw outer xml to empty to indicate that it passed
            RawOuterXml = string.Empty;
        }

        private protected virtual void LazyLoad(XmlReader xmlReader) => RawOuterXml = xmlReader.ReadOuterXml();

        private protected abstract void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode);

        private protected virtual void ParseXml()
        {
            Debug.Assert(!XmlParsed);

            if (string.IsNullOrEmpty(RawOuterXml))
            {
                return;
            }

            using (var xmlReader = CreateXmlReader())
            {
                // move the reader to the start of the element.
                xmlReader.Read();

                // Skip any whitespace
                while (xmlReader.NodeType == XmlNodeType.Whitespace)
                {
                    xmlReader.Skip();
                }

                Populate(xmlReader, OpenXmlElementContext?.LoadMode ?? OpenXmlLoadMode.Full);
            }
        }

        private protected XmlReader CreateXmlReader()
        {
            return CreateXmlReader(RawOuterXml);
        }

        private protected XmlReader CreateXmlReader(string outerXml)
        {
            // This StringReader should not be in a using statement, because it is passed to XmlConvertingReaderFactory
            // and we delegate the responsibility of disposing to XmlConvertingReader.
            // We do not want the using statement here, as we risk this exception being thrown: System.ObjectDisposedException Cannot read from a closed TextReader.
            var stringReader = new StringReader(outerXml);

            if (OpenXmlElementContext is not null)
            {
#if FEATURE_XML_PROHIBIT_DTD
                OpenXmlElementContext.XmlReaderSettings.ProhibitDtd = true; // set true explicitly for security fix
#else
                OpenXmlElementContext.XmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit; // set to prohibit explicitly for security fix
#endif
                return XmlConvertingReaderFactory.Create(stringReader, Features.GetNamespaceResolver(), OpenXmlElementContext.XmlReaderSettings);
            }
            else
            {
                return XmlConvertingReaderFactory.Create(stringReader, Features.GetNamespaceResolver(), OpenXmlElementContext.CreateDefaultXmlReaderSettings());
            }
        }

        internal OpenXmlElement ElementFactory(XmlReader xmlReader)
            => xmlReader.NodeType switch
            {
                XmlNodeType.Element => CreateElement(new(xmlReader.NamespaceURI, xmlReader.LocalName), xmlReader.Prefix),
                XmlNodeType.Comment or XmlNodeType.ProcessingInstruction or XmlNodeType.XmlDeclaration => new OpenXmlMiscNode(xmlReader.NodeType),
                XmlNodeType.Text or XmlNodeType.CDATA or XmlNodeType.SignificantWhitespace or XmlNodeType.Whitespace => new OpenXmlMiscNode(xmlReader.NodeType),
                _ => throw new InvalidOperationException(),
            };

        internal OpenXmlElement CreateElement(in OpenXmlQualifiedName qname, string prefix)
        {
            var newElement = default(OpenXmlElement);

            if (Features.GetNamespaceResolver().IsKnown(qname.Namespace))
            {
                newElement = ElementFactory(qname);

                // try AlternateContent
                if (newElement is null && AlternateContent.InternalQName.Equals(qname))
                {
                    newElement = new AlternateContent();
                }
            }

            if (newElement is null)
            {
                newElement = new OpenXmlUnknownElement(qname, prefix);
            }

            return newElement;
        }

        internal virtual OpenXmlElement? ElementFactory(in OpenXmlQualifiedName qname) => Metadata.Children.Create(qname);

        internal virtual T CloneImp<T>(bool deep)
            where T : OpenXmlElement, new()
        {
            var element = new T();
            element.CopyAttributes(this);

            if (deep)
            {
                element.CopyChildren(this, deep);
            }

            return element;
        }

        // Copy attributes including Attributes, ExtendedAttributes, MCAttributes from the container.
        private protected void CopyAttributes(OpenXmlElement container)
        {
            if (container.HasAttributes)
            {
                if (container.ExtendedAttributesField is not null)
                {
                    ExtendedAttributesField = new List<OpenXmlAttribute>(container.ExtendedAttributesField);
                }

                // Copy Attributes.
                for (var i = 0; i < container.ParsedState.Attributes.Length; i++)
                {
                    var attribute = container.ParsedState.Attributes[i];

                    if (attribute.Value is not null)
                    {
                        RawState.Attributes[i].Value = (OpenXmlSimpleType)attribute.Value.Clone();
                    }
                }

                // Copy MCAttributes
                if (container.MCAttributes is not null)
                {
                    MCAttributes = CloneMCAttributes(container.MCAttributes);
                    Debug.Assert(MCAttributes is not null);
                }
            }

            if (container.NamespaceDeclField is not null)
            {
                NamespaceDeclField = new List<KeyValuePair<string, string>>(container.NamespaceDeclField);
            }
        }

        // Clone the source MCAttributes and returns the copy
        // Remark: If properties of MCAttributes are changed,
        // this method should be modified up-to-date.
        private static MarkupCompatibilityAttributes CloneMCAttributes(MarkupCompatibilityAttributes source)
        {
            var target = new MarkupCompatibilityAttributes();

            if (source.Ignorable is not null)
            {
                target.Ignorable = (StringValue)source.Ignorable.Clone();
            }

            if (source.MustUnderstand is not null)
            {
                target.MustUnderstand = (StringValue)source.MustUnderstand.Clone();
            }

            if (source.PreserveAttributes is not null)
            {
                target.PreserveAttributes = (StringValue)source.PreserveAttributes.Clone();
            }

            if (source.PreserveElements is not null)
            {
                target.PreserveElements = (StringValue)source.PreserveElements.Clone();
            }

            if (source.ProcessContent is not null)
            {
                target.ProcessContent = (StringValue)source.ProcessContent.Clone();
            }

            return target;
        }

        // Copy child elements from the container.
        internal void CopyChildren(OpenXmlElement container, bool deep)
        {
            foreach (var element in container.ChildElements)
            {
                Append(element.CloneNode(deep));
            }
        }

        /// <summary>
        /// Gets a value that indicates the version in which the current element was introduced.
        /// For strong typed element, the return value will be generated according to the schema.
        /// For <see cref="OpenXmlUnknownElement"/>, always returns <c>false</c>
        /// For <see cref="OpenXmlMiscNode"/>, always returns <c>true</c>
        /// </summary>
        internal FileFormatVersions InitialVersion => RawState.Metadata.Availability;

        #endregion

        #region annotations

        /// <summary>
        /// Adds an object to the current OpenXmlElement element's list of annotations.
        /// </summary>
        /// <param name="annotation">The annotation to add to the current OpenXmlElement element.</param>
        public void AddAnnotation(object annotation) => Features.GetRequired<AnnotationsFeature>().AddAnnotation(annotation);

        /// <summary>
        /// Get the first annotation object of the specified type from the current OpenXmlElement element.
        /// </summary>
        /// <typeparam name="T">The type of the annotation to retrieve.</typeparam>
        /// <returns>The first annotation object of the specified type.</returns>
        public T? Annotation<T>()
            where T : class
        {
            return Features.GetRequired<AnnotationsFeature>().Annotation<T>();
        }

        /// <summary>
        /// Get the first annotation object of the specified type from the current OpenXmlElement element.
        /// </summary>
        /// <param name="type">The type of the annotation to retrieve.</param>
        /// <returns>The first annotation object with the specified type.</returns>
        public object? Annotation(Type type) => Features.GetRequired<AnnotationsFeature>().Annotation(type);

        /// <summary>
        /// Gets a collection of annotations with the specified type for the current OpenXmlElement element.
        /// </summary>
        /// <typeparam name="T">The type of the annotations to retrieve.</typeparam>
        /// <returns>An IEnumerable(T) object that contains the annotations for current OpenXmlElement element.</returns>
        public IEnumerable<T> Annotations<T>()
            where T : class
        {
            return Features.GetRequired<AnnotationsFeature>().Annotations<T>();
        }

        /// <summary>
        /// Gets a collection of annotations with the specified type for the current OpenXmlElement element.
        /// </summary>
        /// <param name="type">The type of the annotations to retrieve.</param>
        /// <returns>An IEnumerable(T) object that contains the annotations for the current OpenXmlElement element.</returns>
        public IEnumerable<object> Annotations(Type type) => Features.GetRequired<AnnotationsFeature>().Annotations(type);

        /// <summary>
        /// Removes the annotations with the specified type from the current OpenXmlElement element.
        /// </summary>
        /// <typeparam name="T">The type of the annotations to remove.</typeparam>
        public void RemoveAnnotations<T>()
            where T : class
        {
            Features.GetRequired<AnnotationsFeature>().RemoveAnnotations<T>();
        }

        /// <summary>
        /// Removes the annotations of the specified type from the current OpenXmlElement element.
        /// </summary>
        /// <param name="type">The type of the annotations to remove.</param>
        public void RemoveAnnotations(Type type) => Features.GetRequired<AnnotationsFeature>().RemoveAnnotations(type);

        #endregion

        #region IEnumerable<OpenXmlElement> Members

        /// <summary>
        /// Returns an enumerator that iterates through the child collection.
        /// </summary>
        /// <returns>An IEnumerator object that can be used to iterate through the child collection. </returns>
        public IEnumerator<OpenXmlElement> GetEnumerator() => new OpenXmlChildElements(this).GetEnumerator();

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => new OpenXmlChildElements(this).GetEnumerator();

        #endregion

        #region ICloneable Members

        /// <summary>
        /// Creates a duplicate of the current node.
        /// </summary>
        /// <remarks>
        /// Cloning an OpenXmlNode copies all attributes and their values, including those generated by the XML processor to represent defaulted attributes. This method recursively clones the node and the subtree underneath it.
        /// Cloning is equivalent to calling CloneNode(true).
        /// </remarks>
        /// <returns>The cloned node.</returns>
        public object Clone() => CloneNode(true);

        #endregion

        #region internal and private methods

        /// <summary>
        /// Indicates whether the specified namespace uri equals @"http://www.w3.org/2000/xmlns/".
        /// </summary>
        /// <param name="nsUri">The namespace uri.</param>
        /// <returns>True if nsUri == @"http://www.w3.org/2000/xmlns/".</returns>
        internal bool IsXmlnsUri(string nsUri)
        {
            if (OpenXmlElementContext is not null)
            {
                return OpenXmlElementContext.IsXmlnsUri(nsUri);
            }
            else
            {
                return nsUri == OpenXmlElementContext.XmlnsUri;
            }
        }

        /// <summary>
        /// Returns true when the specified element is not an OpenXmlUnknownElement and it is not an OpenXmlMiscNode.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        internal static bool IsKnownElement(OpenXmlElement element)
        {
            if (!(element is OpenXmlUnknownElement) && !(element is OpenXmlMiscNode))
            {
                // must be composite element or leaf element.
                Debug.Assert(element is OpenXmlCompositeElement || element is OpenXmlLeafElement);
                return true;
            }

            return false;
        }

        private bool ValidOuterXml(string outerXml, string namespaceURI, string localName)
        {
            using (var xmlReader = CreateXmlReader(outerXml))
            {
                // Skip the leading whitespace since OpenXmlElement ignores the Whitespace NodeType.
                do
                {
                    if (xmlReader.Read())
                    {
                        if (xmlReader.NodeType == XmlNodeType.Element)
                        {
                            return string.Equals(namespaceURI, xmlReader.NamespaceURI, StringComparison.Ordinal) && string.Equals(localName, xmlReader.LocalName, StringComparison.Ordinal);
                        }
                    }
                }
                while (xmlReader.NodeType == XmlNodeType.Whitespace);
            }

            return false;
        }

        #endregion

        #region MC Staffs

        /// <summary>
        /// Gets or sets the markup compatibility attributes. Returns null if no markup compatibility attributes are defined for the current element.
        /// </summary>
        public MarkupCompatibilityAttributes? MCAttributes
        {
            get
            {
                MakeSureParsed();
                return McAttributesFiled;
            }

            set
            {
                MakeSureParsed();
                McAttributesFiled = value;
            }
        }

        private bool LoadMCAttribute(string localName, string? value)
        {
            // Do not call this.MCAttributes as this method is called on xml parsing.
            if (McAttributesFiled is null)
            {
                McAttributesFiled = new MarkupCompatibilityAttributes();
            }

            if (string.Equals(localName, MCConsts.Ignorable, StringComparison.Ordinal))
            {
                McAttributesFiled.Ignorable = value;
                return true;
            }

            if (string.Equals(localName, MCConsts.ProcessContent, StringComparison.Ordinal))
            {
                McAttributesFiled.ProcessContent = value;
                return true;
            }

            if (string.Equals(localName, MCConsts.PreserveElements, StringComparison.Ordinal))
            {
                McAttributesFiled.PreserveElements = value;
                return true;
            }

            if (string.Equals(localName, MCConsts.PreserveAttributes, StringComparison.Ordinal))
            {
                McAttributesFiled.PreserveAttributes = value;
                return true;
            }

            if (string.Equals(localName, MCConsts.MustUnderstand, StringComparison.Ordinal))
            {
                McAttributesFiled.MustUnderstand = value;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Loads the MC attributes from the xmlReader.
        /// This xmlReader will keeps on the element start after this method.
        /// </summary>
        /// <param name="xmlReader">This method screen all attribute from xmlReader, and then set the xmlReader back to the element start.</param>
        private static MarkupCompatibilityAttributes? LoadMCAttribute(XmlReader xmlReader)
        {
            var mcAttributes = default(MarkupCompatibilityAttributes);

            if (xmlReader.HasAttributes)
            {
                while (xmlReader.MoveToNextAttribute())
                {
                    if (xmlReader.NamespaceURI == AlternateContent.MarkupCompatibilityNamespace)
                    {
                        switch (xmlReader.LocalName)
                        {
                            case MCConsts.Ignorable:
                                if (mcAttributes is null)
                                {
                                    mcAttributes = new MarkupCompatibilityAttributes();
                                }

                                mcAttributes.Ignorable = xmlReader.Value;
                                break;
                            case MCConsts.ProcessContent:
                                if (mcAttributes is null)
                                {
                                    mcAttributes = new MarkupCompatibilityAttributes();
                                }

                                mcAttributes.ProcessContent = xmlReader.Value;
                                break;
                            case MCConsts.PreserveElements:
                                if (mcAttributes is null)
                                {
                                    mcAttributes = new MarkupCompatibilityAttributes();
                                }

                                mcAttributes.PreserveElements = xmlReader.Value;
                                break;
                            case MCConsts.PreserveAttributes:
                                if (mcAttributes is null)
                                {
                                    mcAttributes = new MarkupCompatibilityAttributes();
                                }

                                mcAttributes.PreserveAttributes = xmlReader.Value;
                                break;
                            case MCConsts.MustUnderstand:
                                if (mcAttributes is null)
                                {
                                    mcAttributes = new MarkupCompatibilityAttributes();
                                }

                                mcAttributes.MustUnderstand = xmlReader.Value;
                                break;
                        }
                    }
                }

                // Moves the reader back to the element node.
                xmlReader.MoveToElement();
            }

            return mcAttributes;
        }

        private bool RemoveMCAttribute(string localName)
        {
            if (MCAttributes is null)
            {
                return false;
            }

            if (string.Equals(localName, MCConsts.Ignorable, StringComparison.Ordinal))
            {
                MCAttributes.Ignorable = null;
                return true;
            }

            if (string.Equals(localName, MCConsts.ProcessContent, StringComparison.Ordinal))
            {
                MCAttributes.ProcessContent = null;
                return true;
            }

            if (string.Equals(localName, MCConsts.PreserveElements, StringComparison.Ordinal))
            {
                MCAttributes.PreserveElements = null;
                return true;
            }

            if (string.Equals(localName, MCConsts.PreserveAttributes, StringComparison.Ordinal))
            {
                MCAttributes.PreserveAttributes = null;
                return true;
            }

            if (string.Equals(localName, MCConsts.MustUnderstand, StringComparison.Ordinal))
            {
                MCAttributes.MustUnderstand = null;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Adds the MC attributes to the "attributes" collection.
        /// </summary>
        /// <param name="attributes"></param>
        private void AddMCAttributes(ICollection<OpenXmlAttribute> attributes)
        {
            var mcPrefix = LookupPrefix(AlternateContent.MarkupCompatibilityNamespace);

            if (mcPrefix.IsNullOrEmpty())
            {
                mcPrefix = MarkupCompatibilityAttributes.MCPrefix;
            }

            if (MCAttributes is null)
            {
                return;
            }

            if (MCAttributes.Ignorable is not null)
            {
                attributes.Add(new OpenXmlAttribute(mcPrefix, "Ignorable", AlternateContent.MarkupCompatibilityNamespace, MCAttributes.Ignorable));
            }

            if (MCAttributes.ProcessContent is not null)
            {
                attributes.Add(new OpenXmlAttribute(mcPrefix, "ProcessContent", AlternateContent.MarkupCompatibilityNamespace, MCAttributes.ProcessContent));
            }

            if (MCAttributes.PreserveElements is not null)
            {
                attributes.Add(new OpenXmlAttribute(mcPrefix, "PreserveElements", AlternateContent.MarkupCompatibilityNamespace, MCAttributes.PreserveElements));
            }

            if (MCAttributes.PreserveAttributes is not null)
            {
                attributes.Add(new OpenXmlAttribute(mcPrefix, "PreserveAttributes", AlternateContent.MarkupCompatibilityNamespace, MCAttributes.PreserveAttributes));
            }

            if (MCAttributes.MustUnderstand is not null)
            {
                attributes.Add(new OpenXmlAttribute(mcPrefix, "MustUnderstand", AlternateContent.MarkupCompatibilityNamespace, MCAttributes.MustUnderstand));
            }
        }

        /// <summary>
        /// Finds the corresponding MC attribute from the attribute name.
        /// </summary>
        /// <param name="localName"></param>
        /// <returns></returns>
        private OpenXmlAttribute GetMCAttribute(string localName)
        {
            if (MCAttributes is null)
            {
                throw new KeyNotFoundException(ExceptionMessages.CannotFindAttribute);
            }

            var mcPrefix = LookupPrefix(AlternateContent.MarkupCompatibilityNamespace);
            if (mcPrefix.IsNullOrEmpty())
            {
                mcPrefix = MarkupCompatibilityAttributes.MCPrefix;
            }

            if (string.Equals(localName, MCConsts.Ignorable, StringComparison.Ordinal))
            {
                return new OpenXmlAttribute(mcPrefix, localName, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.Ignorable);
            }

            if (string.Equals(localName, MCConsts.ProcessContent, StringComparison.Ordinal))
            {
                return new OpenXmlAttribute(mcPrefix, localName, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.ProcessContent);
            }

            if (string.Equals(localName, MCConsts.PreserveElements, StringComparison.Ordinal))
            {
                return new OpenXmlAttribute(mcPrefix, localName, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.PreserveElements);
            }

            if (string.Equals(localName, MCConsts.PreserveAttributes, StringComparison.Ordinal))
            {
                return new OpenXmlAttribute(mcPrefix, localName, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.PreserveAttributes);
            }

            if (string.Equals(localName, MCConsts.MustUnderstand, StringComparison.Ordinal))
            {
                return new OpenXmlAttribute(mcPrefix, localName, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.MustUnderstand);
            }

            throw new KeyNotFoundException(ExceptionMessages.CannotFindAttribute);
        }

        private void WriteMCAttribute(XmlWriter xmlWriter)
        {
            if (MCAttributes is null)
            {
                return;
            }

            var mcPrefix = xmlWriter.LookupPrefix(AlternateContent.MarkupCompatibilityNamespace);
            if (string.IsNullOrEmpty(mcPrefix))
            {
                mcPrefix = MarkupCompatibilityAttributes.MCPrefix;
            }

            if (MCAttributes.Ignorable is not null)
            {
                xmlWriter.WriteAttributeString(mcPrefix, MCConsts.Ignorable, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.Ignorable);
            }

            if (MCAttributes.ProcessContent is not null)
            {
                xmlWriter.WriteAttributeString(mcPrefix, MCConsts.ProcessContent, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.ProcessContent);
            }

            if (MCAttributes.PreserveElements is not null)
            {
                xmlWriter.WriteAttributeString(mcPrefix, MCConsts.PreserveElements, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.PreserveElements);
            }

            if (MCAttributes.PreserveAttributes is not null)
            {
                xmlWriter.WriteAttributeString(mcPrefix, MCConsts.PreserveAttributes, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.PreserveAttributes);
            }

            if (MCAttributes.MustUnderstand is not null)
            {
                xmlWriter.WriteAttributeString(mcPrefix, MCConsts.MustUnderstand, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.MustUnderstand);
            }
        }

        private int MCAttributeCount()
        {
            if (MCAttributes is null)
            {
                return 0;
            }

            var ret = 0;
            if (MCAttributes.Ignorable is not null)
            {
                ret++;
            }

            if (MCAttributes.ProcessContent is not null)
            {
                ret++;
            }

            if (MCAttributes.PreserveElements is not null)
            {
                ret++;
            }

            if (MCAttributes.PreserveAttributes is not null)
            {
                ret++;
            }

            if (MCAttributes.MustUnderstand is not null)
            {
                ret++;
            }

            return ret;
        }

        internal void RemoveAttributesBasedonMC()
        {
            if (OpenXmlElementContext is null ||
                OpenXmlElementContext.MCSettings.ProcessMode == MarkupCompatibilityProcessMode.NoProcess)
            {
                return;
            }

            if (!OpenXmlElementContext.MCContext.HasIgnorable())
            {
                return;
            }

            foreach (var attribute in RawState.Attributes)
            {
                if (attribute.Value is not null)
                {
                    var action = OpenXmlElementContext.MCContext.GetAttributeAction(attribute.Property.QName, OpenXmlElementContext.MCSettings.TargetFileFormatVersions);

                    if (action == AttributeAction.Ignore)
                    {
                        attribute.Value = null;
                    }
                }
            }

            if (ExtendedAttributesField is not null)
            {
                var tobeRemoved = new List<OpenXmlAttribute>();

                foreach (var attribute in ExtendedAttributesField)
                {
                    var action = OpenXmlElementContext.MCContext.GetAttributeAction(attribute.QName, OpenXmlElementContext.MCSettings.TargetFileFormatVersions);
                    if (action == AttributeAction.Ignore)
                    {
                        tobeRemoved.Add(attribute);
                    }
                }

                foreach (var attr in tobeRemoved)
                {
                    ExtendedAttributesField.Remove(attr);
                }
            }
        }

        internal string? LookupNamespaceLocal(string prefix)
        {
            if (NamespaceDeclField is not null)
            {
                for (var i = 0; i < NamespaceDeclField.Count; i++)
                {
                    if (NamespaceDeclField[i].Key == prefix)
                    {
                        return NamespaceDeclField[i].Value;
                    }
                }
            }

            return null;
        }

        internal string? LookupPrefixLocal(string uri)
        {
            if (NamespaceDeclField is not null)
            {
                for (var i = 0; i < NamespaceDeclField.Count; i++)
                {
                    if (NamespaceDeclField[i].Value == uri)
                    {
                        return NamespaceDeclField[i].Key;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Resolves the namespace prefix in the context of the current node.
        /// </summary>
        /// <param name="prefix">The prefix to resolve.</param>
        /// <returns>The resolved namespace. Returns null (Nothing in Visual Basic) if the prefix cannot be resolved.</returns>
        public string? LookupNamespace(string prefix)
        {
            if (prefix is null)
            {
                throw new ArgumentNullException(nameof(prefix));
            }

            // first, lookup whether the prefix is defined on itself and any ancestor elements.
            var node = this;

            while (node is not null)
            {
                var ret = node.LookupNamespaceLocal(prefix);
                if (!string.IsNullOrEmpty(ret))
                {
                    return ret;
                }

                node = node.Parent;
            }

            return null;
        }

        /// <summary>
        /// Finds the corresponding prefix for a namespace uri in the current element scope.
        /// </summary>
        /// <param name="namespaceUri">The namespace uri.</param>
        /// <returns>The corresponding prefix. Returns null (Nothing in Visual Basic) if no prefix is found.</returns>
        public string? LookupPrefix(string namespaceUri)
        {
            if (string.IsNullOrEmpty(namespaceUri))
            {
                throw new ArgumentNullException(nameof(namespaceUri));
            }

            var node = this;

            while (node is not null)
            {
                var ret = node.LookupPrefixLocal(namespaceUri);
                if (!string.IsNullOrEmpty(ret))
                {
                    return ret;
                }

                node = node.Parent;
            }

            return null;
        }

        #endregion

        /// <summary>
        /// Returns the next sibling element that is not an OpenXmlMiscNode element.
        /// </summary>
        /// <returns>The next sibling element that is not an OpenXmlMiscNode element.</returns>
        internal OpenXmlElement? GetNextNonMiscElementSibling()
        {
            var next = NextSibling();

            while (next is not null && next is OpenXmlMiscNode)
            {
                next = next.NextSibling();
            }

            return next;
        }

        /// <summary>
        /// Returns the first child element that is not an OpenXmlMiscNode element.
        /// </summary>
        /// <returns>The first child element that is not an OpenXmlMiscNode element.</returns>
        internal OpenXmlElement? GetFirstNonMiscElementChild()
        {
            Debug.Assert(this is OpenXmlCompositeElement);

            var element = FirstChild;

            if (element is OpenXmlMiscNode)
            {
                return element.GetNextNonMiscElementSibling();
            }
            else
            {
                return element;
            }
        }

        /// <summary>
        /// Gets the root element of the current OpenXmlElement element.
        /// </summary>
        /// <returns>
        /// Returns the root element if it is an OpenXmlPartRootElement element. Returns the current element if it is an OpenXmlPartRootElement element.
        /// Returns null (Nothing in Visual Basic) if the current element has no parent or the root element is not an OpenXmlPartRootElement element.
        /// </returns>
        internal OpenXmlPartRootElement? GetPartRootElement()
        {
            var root = this;

            while (root.Parent is not null)
            {
                root = root.Parent;
            }

            return root as OpenXmlPartRootElement;
        }

        private sealed partial class ElementFeatureCollection : IFeatureCollection
        {
            private readonly OpenXmlElement _owner;

            public ElementFeatureCollection(OpenXmlElement owner)
            {
                _owner = owner;
            }

            public bool IsReadOnly => true;

            public int Revision => GetPartFeatures()?.Revision ?? 0;

            [KnownFeature(typeof(AnnotationsFeature))]
            [KnownFeature(typeof(IElementMetadata), Factory = nameof(CreateMetadata))]
            [DelegatedFeature(nameof(GetPartFeatures))]
            [DelegatedFeature(nameof(FeatureCollection.TypedOrDefault), typeof(FeatureCollection))]
            public partial TFeature? Get<TFeature>();

            public IFeatureCollection? GetPartFeatures() => _owner.GetPart()?.Features;

            private IElementMetadata CreateMetadata() => this.GetRequired<IElementMetadataFactoryFeature>().GetMetadata(_owner);

            public void Set<TFeature>(TFeature? instance)
            {
                throw new NotImplementedException();
            }
        }
    }
}
