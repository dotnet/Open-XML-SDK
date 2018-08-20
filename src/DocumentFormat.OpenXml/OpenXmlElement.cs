// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents a base class that all elements in an Office Open XML document derive from.
    /// </summary>
    /// <remarks>
    /// Annotations will not be cloned when calling .Clone() and .CloneNode(bool).
    /// </remarks>
    public abstract partial class OpenXmlElement : IEnumerable<OpenXmlElement>, ICloneable
    {
        #region data members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OpenXmlElement _next;

        // implement annotations mechanism like XObject in LINQ to XML
        // Annotations will not be cloned when calling .Clone() and .CloneNode(bool)
        private object _annotations;

        private string _rawOuterXml = string.Empty;

        internal MiscAttrContainer MiscAttrContainer { get; set; }

        // attributes not defined in schema
        private List<OpenXmlAttribute> ExtendedAttributesField
        {
            get
            {
                if (MiscAttrContainer == null)
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
                if (MiscAttrContainer == null)
                {
                    MiscAttrContainer = new MiscAttrContainer();
                }

                MiscAttrContainer.ExtendedAttributesField = value;
            }
        }

        private MarkupCompatibilityAttributes McAttributesFiled
        {
            get
            {
                if (MiscAttrContainer == null)
                {
                    return null;
                }
                else
                {
                    return MiscAttrContainer._mcAttributes;
                }
            }

            set
            {
                if (MiscAttrContainer == null)
                {
                    MiscAttrContainer = new MiscAttrContainer();
                }

                MiscAttrContainer._mcAttributes = value;
            }
        }

        internal List<KeyValuePair<string, string>> NamespaceDeclField
        {
            get
            {
                if (MiscAttrContainer == null)
                {
                    return null;
                }
                else
                {
                    return MiscAttrContainer._nsMappings;
                }
            }

            set
            {
                if (MiscAttrContainer == null)
                {
                    MiscAttrContainer = new MiscAttrContainer();
                }

                MiscAttrContainer._nsMappings = value;
            }
        }

        #endregion

        /// <summary>
        /// Initializes a new instance of the OpenXmlElement class.
        /// </summary>
        protected OpenXmlElement()
            : base()
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
        internal OpenXmlElement next
        {
            get { return _next; }
            set { _next = value; }
        }

        /// <summary>
        /// Gets a value indicating whether the inner raw xml is parsed.
        /// </summary>
        internal bool XmlParsed
        {
            get { return string.IsNullOrEmpty(_rawOuterXml); }
        }

        /// <summary>
        /// Gets or sets the raw OuterXml.
        /// </summary>
        internal string RawOuterXml
        {
            get
            {
                return _rawOuterXml;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _rawOuterXml = string.Empty;
                }

                _rawOuterXml = value;
            }
        }

        /// <summary>
        /// Gets an array of fixed attributes (attributes that are defined in the schema) without forcing any parsing of the element.
        /// If parsing is required, please use <see cref="Attributes"/>
        /// </summary>
        internal virtual AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(Cached.Array<AttributeTag>());

        /// <summary>
        /// Gets an array of fixed attributes which will be parsed out if they are not yet parsed. If parsing is not requried, please
        /// use <see cref="RawAttributes"/>
        /// </summary>
        internal AttributeTagCollection Attributes
        {
            get
            {
                MakeSureParsed();
                return RawAttributes;
            }
        }

        #endregion

        #region internal virtual properties

        // following properties will be overridden in all generated classes.
        // generate will generate the constant data

        /// <summary>
        /// Gets the namespace ID of the current element.
        /// </summary>
        internal abstract byte NamespaceId { get; }

        #endregion

        #region public properties

        /// <summary>
        /// Gets the type ID of the current element.
        /// </summary>
        internal virtual int ElementTypeId => ReservedElementTypeIds.OpenXmlElementId;

        /// <summary>
        /// Gets the OpenXmlEementContext of the current element.
        /// </summary>
        public OpenXmlElementContext OpenXmlElementContext => RootElementContext;

        /// <summary>
        /// Gets the OpenXmlEementContext from the root element.
        /// </summary>
        internal virtual OpenXmlElementContext RootElementContext => Parent?.RootElementContext;

        /// <summary>
        /// Gets the first child of the OpenXmlElement element.
        /// Returns null (Nothing in Visual Basic) if there is no such OpenXmlElement element.
        /// </summary>
        public virtual OpenXmlElement FirstChild => null;

        /// <summary>
        /// Gets the last child of the OpenXmlElement element.
        /// Returns null (Nothing in Visual Basic) if there is no such OpenXmlElement element.
        /// </summary>
        public virtual OpenXmlElement LastChild => null;

        /// <summary>
        /// Gets a value indicating whether the current element has any attributes.
        /// </summary>
        public bool HasAttributes
        {
            get
            {
                MakeSureParsed();
                if (ExtendedAttributesField != null && ExtendedAttributesField.Count != 0)
                {
                    return true;
                }

                foreach (var value in Attributes)
                {
                    if (value.HasValue)
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
                if (ExtendedAttributesField != null)
                {
                    return ExtendedAttributesField;
                }
                else
                    return Enumerable.Empty<OpenXmlAttribute>();
            }
        }

        /// <summary>
        /// Gets a value indicating whether the current element has any child elements.
        /// </summary>
        public abstract bool HasChildren { get; }

        /// <summary>
        /// Gets all the child nodes of the current element.
        /// </summary>
        public virtual OpenXmlElementList ChildElements
        {
            get
            {
                return HasChildren ? new OpenXmlChildElements(this) : OpenXmlElementList.Empty;
            }
        }

        /// <summary>
        /// Gets the parent element of the current element.
        /// </summary>
        public OpenXmlElement Parent
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the namespace URI of the current element.
        /// </summary>
        public virtual string NamespaceUri => NamespaceIdMap.GetNamespaceUri(NamespaceId);

        /// <summary>
        /// Gets the local name of the current element.
        /// </summary>
        public virtual string LocalName
        {
            get
            {
#if DEBUG
                Debug.Assert(false, "LocalName not implemented.");
#endif
                return null;
            }
        }

        /// <summary>
        /// Gets the namespace prefix of current element.
        /// </summary>
        public virtual string Prefix
        {
            get
            {
                MakeSureParsed();
                var ret = LookupPrefix(NamespaceUri);
                if (string.IsNullOrEmpty(ret))
                {
                    ret = NamespaceIdMap.GetNamespacePrefix(NamespaceId);
                }

                return ret;
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
                if (NamespaceDeclField == null)
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
                    using (StringWriter w = new StringWriter(CultureInfo.InvariantCulture))
                    {
                        using (XmlDOMTextWriter writer2 = new XmlDOMTextWriter(w))
                        {
                            WriteContentTo(writer2);
                        }

                        return w.ToString();
                    }
                }
                else
                {
                    using (TextReader stringReader = new StringReader(RawOuterXml))
                    using (XmlReader xmlReader = XmlConvertingReaderFactory.Create(stringReader))
                    {
                        xmlReader.Read();
                        return xmlReader.ReadInnerXml();
                    }
                }
            }

            set
            {
                throw new InvalidOperationException(ExceptionMessages.InnerXmlCannotBeSet);
            }
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
                    using (StringWriter w = new StringWriter(CultureInfo.InvariantCulture))
                    {
                        using (XmlDOMTextWriter writer2 = new XmlDOMTextWriter(w))
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

                    foreach (var attribute in RawAttributes)
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
            if (localName == null)
            {
                throw new ArgumentNullException(nameof(localName));
            }

            if (namespaceUri == null)
            {
                // treat null string as empty.
                namespaceUri = string.Empty;
            }

            if (localName.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(localName), ExceptionMessages.StringIsEmpty);
            }

            if (HasAttributes)
            {
                if (namespaceUri != null)
                {
                    foreach (var attribute in Attributes)
                    {
                        if (attribute.HasValue &&
                            attribute.Tag.Name == localName &&
                            attribute.Tag.Namespace == namespaceUri)
                        {
                            return new OpenXmlAttribute(attribute);
                        }
                    }
                }

                foreach (OpenXmlAttribute extendedAttribute in ExtendedAttributes)
                {
                    if (extendedAttribute.LocalName == localName && extendedAttribute.NamespaceUri == namespaceUri)
                    {
                        // clone a copy
                        return new OpenXmlAttribute(extendedAttribute.Prefix, extendedAttribute.LocalName, extendedAttribute.NamespaceUri, extendedAttribute.Value);
                    }
                }

                if (namespaceUri == AlternateContent.MarkupCompatibilityNamespace)
                {
                    return GetMCAttribute(localName);
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
                var attributes = new List<OpenXmlAttribute>();

                foreach (var attribute in Attributes)
                {
                    if (attribute.HasValue)
                    {
                        attributes.Add(new OpenXmlAttribute(attribute));
                    }
                }

                attributes.AddRange(ExtendedAttributes);

                if (MCAttributes != null)
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

            if (openXmlAttribute.Prefix == OpenXmlElementContext.xmlnsPrefix)
            {
                throw new InvalidOperationException(ExceptionMessages.CannotSetAttribute);
            }

            MakeSureParsed();
            if (!TrySetFixedAttribute(openXmlAttribute.NamespaceUri, openXmlAttribute.LocalName, openXmlAttribute.Value, false))
            {
                if (openXmlAttribute.NamespaceUri == AlternateContent.MarkupCompatibilityNamespace)
                {
                    if (LoadMCAttribute(openXmlAttribute.LocalName, openXmlAttribute.Value))
                    {
                        return;
                    }
                }

                int index = 0;

                // remove the old one if there is
                if (ExtendedAttributesField != null)
                {
                    foreach (OpenXmlAttribute extendedAttibute in ExtendedAttributesField)
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

                if (ExtendedAttributesField == null)
                {
                    ExtendedAttributesField = new List<OpenXmlAttribute>();
                }

                OpenXmlAttribute attribute = new OpenXmlAttribute(openXmlAttribute.Prefix, openXmlAttribute.LocalName, openXmlAttribute.NamespaceUri, openXmlAttribute.Value);
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
            if (localName == null)
            {
                throw new ArgumentNullException(nameof(localName));
            }

            if (namespaceUri == null)
            {
                // treat null string as empty.
                namespaceUri = string.Empty;
            }

            if (localName.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(localName), ExceptionMessages.StringIsEmpty);
            }

            if (HasAttributes)
            {
                // get attribute namespace ID
                var attribute = RawAttributes[namespaceUri, localName];
                if (!attribute.IsNil)
                {
                    attribute.Value = null;
                }
                else
                {
                    int index = 0;
                    if (ExtendedAttributesField != null)
                    {
                        foreach (OpenXmlAttribute extendedAttribute in ExtendedAttributesField)
                        {
                            if (extendedAttribute.LocalName == localName && extendedAttribute.NamespaceUri == namespaceUri)
                            {
                                ExtendedAttributesField.RemoveAt(index);
                                return;
                            }

                            index++;
                        }
                    }
                }

                //try remove MC attribute
                if (namespaceUri == AlternateContent.MarkupCompatibilityNamespace)
                {
                    RemoveMCAttribute(localName);
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
            if (openXmlAttributes == null)
            {
                throw new ArgumentNullException(nameof(openXmlAttributes));
            }

            foreach (OpenXmlAttribute attribute in openXmlAttributes)
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
            foreach (var attribute in RawAttributes)
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
            if (NamespaceDeclField == null)
            {
                NamespaceDeclField = new List<KeyValuePair<string, string>>();
            }

            foreach (var item in NamespaceDeclField)
            {
                if (item.Key == prefix)
                {
                    throw new InvalidOperationException(SR.Format(ExceptionMessages.DuplicatedPrefix, prefix));
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
            if (NamespaceDeclField != null)
            {
                for (int i = 0; i < NamespaceDeclField.Count; i++)
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
        public T GetFirstChild<T>() where T : OpenXmlElement
        {
            return ChildElements.First<T>();
        }

        /// <summary>
        /// Gets the OpenXmlElement element that immediately precedes the current OpenXmlElement element.
        /// Returns null (Nothing in Visual Basic ) if there is no preceding OpenXmlElement element.
        /// </summary>
        /// <returns>The OpenXmlElement element that immediately precedes the current OpenXmlElement element.</returns>
        public OpenXmlElement PreviousSibling()
        {
            OpenXmlCompositeElement parent = Parent as OpenXmlCompositeElement;
            if (parent == null)
            {
                return null;
            }

            OpenXmlElement firstChild = parent.FirstChild;

            while (firstChild != null)
            {
                OpenXmlElement nextSibling = firstChild.NextSibling();
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
        public T PreviousSibling<T>() where T : OpenXmlElement
        {
            OpenXmlElement element = PreviousSibling();

            while (element != null)
            {
                if (element is T)
                {
                    return (T)element;
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
        public OpenXmlElement NextSibling()
        {
            OpenXmlElement parentNode = Parent;
            if ((parentNode != null) && (next != parentNode.FirstChild))
            {
                return next;
            }

            return null;
        }

        /// <summary>
        /// Gets the OpenXmlElement element with the specified type that follows the current OpenXmlElement element.
        /// Returns null (Nothing in Visual Basic) if there is no next OpenXmlElement.
        /// </summary>
        /// <returns>The OpenXmlElement element with the specified type that follows the current OpenXmlElement element.</returns>
        public T NextSibling<T>() where T : OpenXmlElement
        {
            OpenXmlElement element = NextSibling();

            while (element != null)
            {
                if (element is T)
                {
                    return (T)element;
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
            OpenXmlElement ancestor = Parent;

            while (ancestor != null)
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
        public IEnumerable<T> Ancestors<T>() where T : OpenXmlElement
        {
            OpenXmlElement ancestor = Parent;

            while (ancestor != null)
            {
                if (ancestor is T)
                {
                    yield return (T)ancestor;
                }

                ancestor = ancestor.Parent;
            }
        }

        /// <summary>
        /// Enumerates only the current element's children that have the specified type.
        /// </summary>
        /// <typeparam name="T">The element type.</typeparam>
        /// <returns></returns>
        public IEnumerable<T> Elements<T>() where T : OpenXmlElement
        {
            return ChildElements.OfType<T>();
        }

        /// <summary>
        /// Enumerates all of the current element's children.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OpenXmlElement> Elements()
        {
            return ChildElements;
        }

        /// <summary>
        /// Enumerate all of the current element's descendants of type T.
        /// </summary>
        /// <typeparam name="T">The element type.</typeparam>
        /// <returns></returns>
        public IEnumerable<T> Descendants<T>() where T : OpenXmlElement
        {
            T elementT = null;

            foreach (OpenXmlElement element in Descendants())
            {
                elementT = element as T;
                if (elementT != null)
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
            if (FirstChild == null)
            {
                yield break;
            }

            OpenXmlElement root = FirstChild;

            yield return root;

            Stack<OpenXmlElement> stack = new Stack<OpenXmlElement>();

            stack.Push(root);

            while (true)
            {
                if (stack.Peek() == root && stack.Peek().FirstChild != null)
                {
                    root = stack.Peek().FirstChild;
                    stack.Push(root);
                    yield return root;
                }
                else if (stack.Peek().NextSibling() != null)
                {
                    root = stack.Peek().NextSibling();
                    stack.Pop();
                    stack.Push(root);
                    yield return root;
                }
                else
                {
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        yield break;
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
            if (Parent != null)
            {
                OpenXmlElement element = Parent.FirstChild;

                while (element != this)
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
            if (Parent != null)
            {
                OpenXmlElement element = NextSibling();

                while (element != null)
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
        public virtual OpenXmlElement CloneNode(bool deep)
        {
            throw new NotImplementedException(ExceptionMessages.NonImplemented);
        }

        /// <summary>
        /// Saves the current node to the specified XmlWriter.
        /// </summary>
        /// <param name="xmlWriter">The XmlWriter to which to save the current node. </param>
        public virtual void WriteTo(XmlWriter xmlWriter)
        {
            if (xmlWriter == null)
            {
                throw new ArgumentNullException(nameof(xmlWriter));
            }

            if (XmlParsed)
            {
                //check the namespace mapping defined in this node first. because till now xmlWriter don't know the mapping defined in the current node.
                string prefix = LookupPrefixLocal(NamespaceUri);

                //if not defined in the current node, try the xmlWriter
                if (string.IsNullOrEmpty(prefix))
                {
                    prefix = xmlWriter.LookupPrefix(NamespaceUri);
                }

                //if xmlWriter didn't find it, it means the node is constructed by user and is not in the tree yet
                //in this case, we use the predefined prefix
                if (string.IsNullOrEmpty(prefix))
                {
                    prefix = NamespaceIdMap.GetNamespacePrefix(NamespaceId);
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
            if (newChildren == null)
            {
                throw new ArgumentNullException(nameof(newChildren));
            }

            foreach (OpenXmlElement child in newChildren)
            {
                AppendChild(child);
            }
        }

        /// <summary>
        /// Appends each element from an array of elements to the end of the current element's list of child elements.
        /// </summary>
        /// <param name="newChildren">The array of OpenXmlElement elements to be appended.</param>
        public void Append(params OpenXmlElement[] newChildren)
        {
            if (newChildren != null)
            {
                foreach (OpenXmlElement child in newChildren)
                {
                    AppendChild(child);
                }
            }
        }

        /// <summary>
        /// Appends the specified element to the end of the current element's list of child nodes.
        /// </summary>
        /// <param name="newChild">The OpenXmlElement element to append.</param>
        /// <returns>The OpenXmlElement element that was appended. </returns>
        public virtual T AppendChild<T>(T newChild) where T : OpenXmlElement
        {
            throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);
        }

        /// <summary>
        /// Inserts the specified element immediately after the specified reference element.
        /// </summary>
        /// <param name="newChild">The OpenXmlElement element to insert.</param>
        /// <param name="refChild">The reference OpenXmlElement element. newChild is placed after refChild. </param>
        /// <returns>The OpenXmlElement element that was inserted.</returns>
        public virtual T InsertAfter<T>(T newChild, OpenXmlElement refChild) where T : OpenXmlElement
        {
            throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);
        }

        /// <summary>
        /// Inserts the specified element immediately before the specified reference element.
        /// </summary>
        /// <param name="newChild">The OpenXmlElement element to insert.</param>
        /// <param name="refChild">The reference OpenXmlElement element. newChild is placed before refChild.</param>
        /// <returns>The OpenXmlElement element that was inserted.</returns>
        public virtual T InsertBefore<T>(T newChild, OpenXmlElement refChild) where T : OpenXmlElement
        {
            throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);
        }

        /// <summary>
        /// Inserts the specified element immediately after the current element.
        /// </summary>
        /// <param name="newElement">The new element to insert.</param>
        /// <returns>The inserted element.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the "newElement" parameter is a null reference.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the parent is a null reference.</exception>
        public T InsertAfterSelf<T>(T newElement) where T : OpenXmlElement
        {
            if (newElement == null)
            {
                throw new ArgumentNullException(nameof(newElement));

                // TODO: should we just return null? InsertBefore / InsertAfter do not throw on null newChild.
                // return null;
            }

            if (Parent == null)
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
        /// <exception cref="ArgumentNullException">Thrown when the "newElement" parameter is a null reference.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the parent is a null reference.</exception>
        public T InsertBeforeSelf<T>(T newElement) where T : OpenXmlElement
        {
            if (newElement == null)
            {
                throw new ArgumentNullException(nameof(newElement));

                // TODO: should we just return null? InsertBefore / InsertAfter do not throw on null newChild.
                // return null;
            }

            if (Parent == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ParentIsNull);
            }

            return Parent.InsertBefore(newElement, this);
        }

        /// <summary>
        /// Inserts the specified element at the specified index in the current element's list of child elements.
        /// </summary>
        /// <param name="newChild">The OpenXmlElement element to insert.</param>
        /// <param name="index">The zero-based index where the element is to be inserted.</param>
        /// <returns>The OpenXmlElement element that was inserted.</returns>
        /// <remarks>Returns null if newChild equals null.</remarks>
        public virtual T InsertAt<T>(T newChild, int index) where T : OpenXmlElement
        {
            throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);
        }

        /// <summary>
        /// Inserts the specified element at the beginning of the current element's list of child elements.
        /// </summary>
        /// <param name="newChild">The OpenXmlElement element to add.</param>
        /// <returns>The OpenXmlElement element that was added.</returns>
        public virtual T PrependChild<T>(T newChild) where T : OpenXmlElement
        {
            throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);
        }

        /// <summary>
        /// Removes the specified child element from the current element's list of child elements.
        /// </summary>
        /// <param name="oldChild">The child element to remove. </param>
        /// <returns>The element that was removed. </returns>
        public virtual T RemoveChild<T>(T oldChild) where T : OpenXmlElement
        {
            throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);
        }

        /// <summary>
        /// Replaces a child element with another child element in the current element's list of child elements.
        /// </summary>
        /// <param name="newChild">The new child element to put in the list.</param>
        /// <param name="oldChild">The child element to replace in the list.</param>
        /// <returns>The OpenXmlElement element that was replaced.</returns>
        public virtual T ReplaceChild<T>(OpenXmlElement newChild, T oldChild) where T : OpenXmlElement
        {
            throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);
        }

        /// <summary>
        /// Removes all of the current element's child elements.
        /// </summary>
        public abstract void RemoveAllChildren();

        /// <summary>
        /// Remove all of the current element's child elements that are of type T.
        /// </summary>
        public void RemoveAllChildren<T>() where T : OpenXmlElement
        {
            OpenXmlElement element = FirstChild;
            OpenXmlElement next;

            while (element != null)
            {
                next = element.NextSibling();

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
            if (Parent == null)
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
            if (element == null)
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
            if (element == null)
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
            Debug.Assert(element1 != null && element2 != null);

            if (element1.Parent == null && element2.Parent == null)
            {
                return ElementOrder.NotInSameTree;
            }
            else if (object.ReferenceEquals(element1.Parent, element2.Parent))
            {
                return GetSiblingOrder(element1, element2);
            }
            else
            {
                Stack<OpenXmlElement> element1Ancestors = new Stack<OpenXmlElement>();
                Stack<OpenXmlElement> element2Ancestors = new Stack<OpenXmlElement>();

                element1Ancestors.Push(element1);
                element2Ancestors.Push(element2);

                foreach (OpenXmlElement ancestor in element1.Ancestors())
                {
                    element1Ancestors.Push(ancestor);
                }

                foreach (OpenXmlElement ancestor in element2.Ancestors())
                {
                    element2Ancestors.Push(ancestor);
                }

                OpenXmlElement thisAncestor = element1Ancestors.Pop();
                OpenXmlElement targetAncestor = element2Ancestors.Pop();

                if (thisAncestor == targetAncestor)
                {
                    while (element1Ancestors.Count > 0 && element2Ancestors.Count > 0)
                    {
                        thisAncestor = element1Ancestors.Pop();
                        targetAncestor = element2Ancestors.Pop();

                        ElementOrder order = GetSiblingOrder(thisAncestor, targetAncestor);

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

            OpenXmlElement element = element1.NextSibling();

            while (element != null)
            {
                if (object.ReferenceEquals(element, element2))
                {
                    // element1 before element2
                    return ElementOrder.Before;
                }

                element = element.NextSibling();
            }

#if DEBUG
            element = element1.PreviousSibling();

            while (element != null)
            {
                if (object.ReferenceEquals(element, element2))
                {
                    break;
                }

                element = element.PreviousSibling();
            }

            Debug.Assert(element == element2);
#endif
            return ElementOrder.After;
        }

#if false
        /// <summary>
        /// Transforms child elements by using the user callback.
        /// </summary>
        /// <param name="callback">The user callback.</param>
        /// <param name="argument">Argument of the user callback.</param>
        /// <returns>Returns false if the transformation has been canceled by the callback.</returns>
        internal virtual bool TransformChildElements(TransformElement callback, object argument)
        {
            return true;
        }
#endif

        #endregion

        #region internal methods

        internal virtual void WriteAttributesTo(XmlWriter xmlWriter)
        {
            Debug.Assert(xmlWriter != null);

            //write the namespace declaration first, so the inner attribute will get the right prefix
            if (NamespaceDeclField != null)
            {
                foreach (var item in NamespaceDeclField)
                {
                    xmlWriter.WriteAttributeString(OpenXmlElementContext.xmlnsPrefix, item.Key, OpenXmlElementContext.xmlnsUri, item.Value);
                }
            }

            if (XmlParsed && HasAttributes)
            {
                foreach (var attribute in Attributes)
                {
                    if (attribute.HasValue)
                    {
                        string ns = attribute.Tag.Namespace;
                        string prefix = string.Empty;

                        if (!string.IsNullOrEmpty(ns))
                        {
                            prefix = xmlWriter.LookupPrefix(ns);
                            if (string.IsNullOrEmpty(prefix))
                            {
                                prefix = attribute.Tag.NamespacePrefix;
                            }
                        }

                        xmlWriter.WriteStartAttribute(prefix, attribute.Tag.Name, ns);
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

        /// <summary>
        /// Saves all of the children of the current node to the specified XmlWriter.
        /// </summary>
        /// <param name="w">The XmlWriter at which to save the child nodes. </param>
        internal abstract void WriteContentTo(XmlWriter w);

        private protected virtual bool StrictTranslateAttribute(string namespaceUri, string localName, string value)
        {
            return TrySetFixedAttribute(namespaceUri, localName, value, false);
        }

        /// <summary>
        /// Attempts to set the attribute to a known attribute.
        /// </summary>
        /// <param name="namespaceUri"></param>
        /// <param name="localName"></param>
        /// <param name="value"></param>
        /// <param name="strictTranslation"></param>
        /// <returns>true if the attribute is a known attribute.</returns>
        internal bool TrySetFixedAttribute(string namespaceUri, string localName, string value, bool strictTranslation)
        {
            if (RawAttributes.Any())
            {
                if (strictTranslation)
                {
                    return StrictTranslateAttribute(namespaceUri, localName, value);
                }

                var attribute = RawAttributes[namespaceUri, localName];

                if (!attribute.IsNil)
                {
                    if (!attribute.HasValue)
                    {
                        attribute.Value = attribute.Tag.CreateNew();
                    }

                    attribute.Value.InnerText = value;
                    return true;
                }
            }

            return false;
        }

        internal virtual void LoadAttributes(XmlReader xmlReader)
        {
            Debug.Assert(xmlReader != null);

            Debug.Assert(xmlReader.NodeType == XmlNodeType.Element);

            // read attributes
            if (xmlReader.HasAttributes)
            {
                while (xmlReader.MoveToNextAttribute())
                {
                    if (!TrySetFixedAttribute(xmlReader.NamespaceURI, xmlReader.LocalName, xmlReader.Value, ((XmlConvertingReader)xmlReader).StrictTranslation))
                    {
                        if (xmlReader.NamespaceURI == AlternateContent.MarkupCompatibilityNamespace)
                        {
                            if (LoadMCAttribute(xmlReader.LocalName, xmlReader.Value))
                            {
                                continue;
                            }

                            //if we cannot recognize the local name with the mc prefix, load it as extended properties
                        }

                        // a attribute is (xmlns:nnn=".....")
                        //bool attributeIsXmlnsDefination = this.IsXmlnsUri(xmlReader.NamespaceURI);
                        bool attributeIsXmlnsDefination = xmlReader.NamespaceURI == OpenXmlElementContext.xmlnsUri;

                        if (!attributeIsXmlnsDefination)
                        {
                            // do not add xmlns:x="...." as attribute
                            if (ExtendedAttributesField == null)
                            {
                                ExtendedAttributesField = new List<OpenXmlAttribute>();
                            }

                            ExtendedAttributesField.Add(new OpenXmlAttribute(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI, xmlReader.Value));
                        }
                        else
                        {
                            //don't add declaration for case like xmlns="global namespace uri"
                            if (!string.IsNullOrEmpty(xmlReader.Prefix))
                            {
                                if (NamespaceDeclField == null)
                                {
                                    NamespaceDeclField = new List<KeyValuePair<string, string>>();
                                }

                                NamespaceDeclField.Add(new KeyValuePair<string, string>(xmlReader.LocalName, xmlReader.Value));
                            }
                        }
                    }
                }

                RemoveAttributesBasedonMC();

                //  Moves the reader back to the element node.
                xmlReader.MoveToElement();
            }
        }

        /// <summary>
        /// Reads MC attributes from the xmlReader and than pushes MC Context on needed.
        /// This xmlReader will keeps on the element start after this method.
        /// </summary>
        /// <param name="xmlReader">This method screen all attribute from xmlReader, and then set the xmlReader back to the element start.</param>
        /// <returns>Returns true if a MCAttributes is pushed.</returns>
        internal bool PushMcContext(XmlReader xmlReader)
        {
            Debug.Assert(xmlReader != null);
            Debug.Assert(xmlReader.NodeType == XmlNodeType.Element);

            if (OpenXmlElementContext != null && OpenXmlElementContext.MCSettings.ProcessMode != DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessMode.NoProcess)
            {
                OpenXmlElementContext.MCContext.LookupNamespaceDelegate = xmlReader.LookupNamespace;

                var mcAttributes = LoadMCAttribute(xmlReader);

                if (mcAttributes != null)
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

        internal void PopMcContext()
        {
            if (OpenXmlElementContext != null && OpenXmlElementContext.MCSettings.ProcessMode != DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessMode.NoProcess)
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
        internal static void CheckMustUnderstandAttr(XmlReader reader, MarkupCompatibilityAttributes mcAttributes, MarkupCompatibilityProcessSettings mcSettings)
        {
            Debug.Assert(mcAttributes != null && mcSettings.ProcessMode != DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessMode.NoProcess);

            if (mcAttributes.MustUnderstand != null && !string.IsNullOrEmpty(mcAttributes.MustUnderstand.Value))
            {
                var prefixes = mcAttributes.MustUnderstand.Value.Trim().Split(new char[] { ' ' });
                foreach (var prefix in prefixes)
                {
                    var ns = reader.LookupNamespace(prefix);
                    if (string.IsNullOrEmpty(ns))
                    {
                        throw new InvalidMCContentException(SR.Format(ExceptionMessages.UnknowMCContent, mcAttributes.MustUnderstand.Value));
                    }

                    if (NamespaceIdMap.IsInFileFormat(ns, mcSettings.TargetFileFormatVersions))
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
            if (MCAttributes == null || OpenXmlElementContext.MCSettings.ProcessMode == DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessMode.NoProcess)
            {
                return;
            }

            if (MCAttributes.MustUnderstand != null && !string.IsNullOrEmpty(MCAttributes.MustUnderstand.Value))
            {
                var prefixes = MCAttributes.MustUnderstand.Value.Trim().Split(new char[] { ' ' });
                foreach (var prefix in prefixes)
                {
                    var ns = LookupNamespace(prefix);
                    if (string.IsNullOrEmpty(ns))
                    {
                        throw new InvalidMCContentException(SR.Format(ExceptionMessages.UnknowMCContent, MCAttributes.MustUnderstand.Value));
                    }

                    if (NamespaceIdMap.IsInFileFormat(ns, OpenXmlElementContext.MCSettings.TargetFileFormatVersions))
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
            Debug.Assert(xmlReader != null);

            switch (loadMode)
            {
                case OpenXmlLoadMode.Full:
                    Populate(xmlReader, loadMode);
                    break;

                case OpenXmlLoadMode.Lazy:
                    if (OpenXmlElementContext != null && xmlReader.Depth < OpenXmlElementContext.LazySteps)
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

        internal virtual void LazyLoad(XmlReader xmlReader)
        {
            RawOuterXml = xmlReader.ReadOuterXml();
        }

        internal abstract void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode);

        private protected virtual void ParseXml()
        {
            Debug.Assert(!XmlParsed);

            if (string.IsNullOrEmpty(RawOuterXml))
            {
                return;
            }

            using (XmlReader xmlReader = CreateXmlReader())
            {
                // move the reader to the start of the element.
                xmlReader.Read();
                Populate(xmlReader, OpenXmlElementContext?.LoadMode ?? OpenXmlLoadMode.Full);
            }
        }

        internal XmlReader CreateXmlReader()
        {
            var stringReader = new StringReader(RawOuterXml);

            if (OpenXmlElementContext != null)
            {
#if FEATURE_XML_PROHIBIT_DTD
                OpenXmlElementContext.XmlReaderSettings.ProhibitDtd = true; // set true explicitly for security fix
#else
                OpenXmlElementContext.XmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit; // set to prohibit explicitly for security fix
#endif
                return XmlConvertingReaderFactory.Create(stringReader, OpenXmlElementContext.XmlReaderSettings);
            }
            else
            {
                return XmlConvertingReaderFactory.Create(stringReader, OpenXmlElementContext.CreateDefaultXmlReaderSettings());
            }
        }

        internal XmlReader CreateXmlReader(string outerXml)
        {
            XmlReader xmlReader;
            TextReader stringReader = new StringReader(outerXml);

            if (OpenXmlElementContext != null)
            {
#if FEATURE_XML_PROHIBIT_DTD
                OpenXmlElementContext.XmlReaderSettings.ProhibitDtd = true; // set true explicitly for security fix
#else
                OpenXmlElementContext.XmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit; // set to prohibit explicitly for security fix
#endif
                xmlReader = XmlConvertingReaderFactory.Create(stringReader, OpenXmlElementContext.XmlReaderSettings);
            }
            else
            {
                xmlReader = XmlConvertingReaderFactory.Create(stringReader, OpenXmlElementContext.CreateDefaultXmlReaderSettings());
            }

            return xmlReader;
        }

        internal OpenXmlElement ElementFactory(XmlReader xmlReader)
        {
            switch (xmlReader.NodeType)
            {
                case XmlNodeType.Element:
                    return ElementFactory(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI);

                case XmlNodeType.Comment:
                case XmlNodeType.ProcessingInstruction:
                case XmlNodeType.XmlDeclaration:
                    return new OpenXmlMiscNode(xmlReader.NodeType);

                case XmlNodeType.Text:
                case XmlNodeType.CDATA:
                case XmlNodeType.SignificantWhitespace:
                case XmlNodeType.Whitespace:
                    return new OpenXmlMiscNode(xmlReader.NodeType);

                case XmlNodeType.Attribute:
                case XmlNodeType.Document:
                case XmlNodeType.DocumentFragment:
                case XmlNodeType.DocumentType: // not allowed when DtdProcessing = DtdProcessing.Prohibit
                case XmlNodeType.EndElement:
                case XmlNodeType.EndEntity:
                case XmlNodeType.Entity: // not allowed when DtdProcessing = DtdProcessing.Prohibit
                case XmlNodeType.EntityReference:
                case XmlNodeType.Notation: // not allowed when DtdProcessing = DtdProcessing.Prohibit
                case XmlNodeType.None:
                default:
                    throw new InvalidOperationException();
            }
        }

        internal virtual OpenXmlElement ElementFactory(string prefix, string name, string namespaceUri)
        {
            // Debug.Assert(namespaceUri != null);
            Debug.Assert(!string.IsNullOrEmpty(name));

            OpenXmlElement newElement = null;
            byte nsId;

            if ((!string.IsNullOrEmpty(namespaceUri)) && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out nsId))
            {
                newElement = ElementFactory(nsId, name);

                // try AlternateContent
                if (newElement == null &&
                    AlternateContent.MarkupCompatibilityNamespaceId == nsId &&
                    AlternateContent.TagName == name)
                {
                    newElement = new AlternateContent();
                }
            }

            if (newElement == null)
            {
                newElement = new OpenXmlUnknownElement(prefix, name, namespaceUri);
            }

            return newElement;
        }

        internal virtual OpenXmlElement ElementFactory(byte namespaceId, string name)
        {
            return null;
        }

        internal virtual OpenXmlElement AlternateContentElementFactory(byte namespaceId, string name)
        {
            return null;
        }

        internal virtual T CloneImp<T>(bool deep) where T : OpenXmlElement, new()
        {
            T element = new T();
            element.CopyAttributes(this);

            if (deep)
            {
                element.CopyChilden(this, deep);
            }

            return element;
        }

        // Copy attributes including Attributes, ExtendedAttributes, MCAttributes from the container.
        internal void CopyAttributes(OpenXmlElement container)
        {
            Debug.Assert(container != null);
            if (container.HasAttributes)
            {
                if (container.ExtendedAttributesField != null)
                {
                    ExtendedAttributesField = new List<OpenXmlAttribute>(container.ExtendedAttributesField);
                }

                // Copy Attributes.
                Debug.Assert(container.RawAttributes.Length == container.RawAttributes.Length);
                for (int i = 0; i < container.Attributes.Length; i++)
                {
                    var attribute = container.Attributes[i];

                    if (attribute.HasValue)
                    {
                        RawAttributes[i].Value = (OpenXmlSimpleType)attribute.Value.Clone();
                    }
                }

                // Copy MCAttributes
                if (container.MCAttributes != null)
                {
                    MCAttributes = CloneMCAttributes(container.MCAttributes);
                    Debug.Assert(MCAttributes != null);
                }
            }

            if (container.NamespaceDeclField != null)
            {
                NamespaceDeclField = new List<KeyValuePair<string, string>>(container.NamespaceDeclField);
            }
        }

        // Clone the source MCAttributes and returns the copy
        // Remark: If properties of MCAttributes are changed,
        // this method should be modified up-to-date.
        private static MarkupCompatibilityAttributes CloneMCAttributes(MarkupCompatibilityAttributes source)
        {
            Debug.Assert(source != null);
            MarkupCompatibilityAttributes target = new MarkupCompatibilityAttributes();
            if (source.Ignorable != null)
            {
                target.Ignorable = (StringValue)source.Ignorable.Clone();
            }

            if (source.MustUnderstand != null)
            {
                target.MustUnderstand = (StringValue)source.MustUnderstand.Clone();
            }

            if (source.PreserveAttributes != null)
            {
                target.PreserveAttributes = (StringValue)source.PreserveAttributes.Clone();
            }

            if (source.PreserveElements != null)
            {
                target.PreserveElements = (StringValue)source.PreserveElements.Clone();
            }

            if (source.ProcessContent != null)
            {
                target.ProcessContent = (StringValue)source.ProcessContent.Clone();
            }

            return target;
        }

        // Copy child elements from the container.
        internal void CopyChilden(OpenXmlElement container, bool deep)
        {
            Debug.Assert(container != null);
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
        internal abstract FileFormatVersions InitialVersion { get; }

        #endregion

        #region annotations

        //  This code is copied from PartContainer.
        //  Duplicate code.
        //  Fix both code on bug fixing.

        /// <summary>
        /// Adds an object to the current OpenXmlElement element's list of annotations.
        /// </summary>
        /// <param name="annotation">The annotation to add to the current OpenXmlElement element.</param>
        public void AddAnnotation(object annotation)
        {
            if (annotation == null)
            {
                throw new ArgumentNullException(nameof(annotation));
            }

            if (_annotations == null)
            {
                _annotations = (annotation is object[]) ? new object[] { annotation } : annotation;
            }
            else
            {
                object[] annotations = _annotations as object[];
                if (annotations == null)
                {
                    _annotations = new object[] { _annotations, annotation };
                }
                else
                {
                    int index = 0;
                    while ((index < annotations.Length) && (annotations[index] != null))
                    {
                        index++;
                    }

                    if (index == annotations.Length)
                    {
                        Array.Resize<object>(ref annotations, index * 2);
                        _annotations = annotations;
                    }

                    annotations[index] = annotation;
                }
            }
        }

        /// <summary>
        /// Get the first annotation object of the specified type from the current OpenXmlElement element.
        /// </summary>
        /// <typeparam name="T">The type of the annotation to retrieve.</typeparam>
        /// <returns>The first annotation object of the specified type.</returns>
        public T Annotation<T>() where T : class
        {
            if (_annotations != null)
            {
                object[] annotations = _annotations as object[];

                if (annotations == null)
                {
                    return _annotations as T;
                }

                for (int i = 0; i < annotations.Length; i++)
                {
                    object obj = annotations[i];

                    if (obj == null)
                    {
                        break;
                    }

                    T t = obj as T;
                    if (t != null)
                    {
                        return t;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Get the first annotation object of the specified type from the current OpenXmlElement element.
        /// </summary>
        /// <param name="type">The type of the annotation to retrieve.</param>
        /// <returns>The first annotation object with the specified type.</returns>
        public object Annotation(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            if (_annotations != null)
            {
                object[] annotations = _annotations as object[];
                if (annotations == null)
                {
                    if (type.GetTypeInfo().IsAssignableFrom(_annotations.GetType().GetTypeInfo()))
                    {
                        return _annotations;
                    }
                }
                else
                {
                    for (int i = 0; i < annotations.Length; i++)
                    {
                        object obj = annotations[i];
                        if (obj == null)
                        {
                            break;
                        }

                        if (type.GetTypeInfo().IsAssignableFrom(obj.GetType().GetTypeInfo()))
                        {
                            return obj;
                        }
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Gets a collection of annotations with the specified type for the current OpenXmlElement element.
        /// </summary>
        /// <typeparam name="T">The type of the annotations to retrieve.</typeparam>
        /// <returns>An IEnumerable(T) object that contains the annotations for current OpenXmlElement element.</returns>
        public IEnumerable<T> Annotations<T>() where T : class
        {
            if (_annotations != null)
            {
                object[] annotations = _annotations as object[];
                if (annotations == null)
                {
                    if (_annotations is T)
                    {
                        yield return (T)_annotations;
                    }
                }
                else
                {
                    for (int i = 0; i < annotations.Length; i++)
                    {
                        object obj = annotations[i];
                        if (obj == null)
                        {
                            break;
                        }

                        if (obj is T)
                        {
                            yield return (T)obj;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gets a collection of annotations with the specified type for the current OpenXmlElement element.
        /// </summary>
        /// <param name="type">The type of the annotations to retrieve.</param>
        /// <returns>An IEnumerable(T) object that contains the annotations for the current OpenXmlElement element.</returns>
        public IEnumerable<object> Annotations(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            if (_annotations != null)
            {
                object[] annotations = _annotations as object[];
                if (annotations == null)
                {
                    if (type.GetTypeInfo().IsAssignableFrom(_annotations.GetType().GetTypeInfo()))
                    {
                        yield return _annotations;
                    }
                }
                else
                {
                    for (int i = 0; i < annotations.Length; i++)
                    {
                        object obj = annotations[i];
                        if (obj == null)
                        {
                            break;
                        }

                        if (type.GetTypeInfo().IsAssignableFrom(obj.GetType().GetTypeInfo()))
                        {
                            yield return obj;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Removes the annotations with the specified type from the current OpenXmlElement element.
        /// </summary>
        /// <typeparam name="T">The type of the annotations to remove.</typeparam>
        public void RemoveAnnotations<T>() where T : class
        {
            if (_annotations != null)
            {
                object[] annotations = _annotations as object[];
                if (annotations == null)
                {
                    if (_annotations is T)
                    {
                        _annotations = null;
                    }
                }
                else
                {
                    int index = 0;
                    int num = 0;
                    while (index < annotations.Length)
                    {
                        object obj = annotations[index];
                        if (obj == null)
                        {
                            break;
                        }

                        if (!(obj is T))
                        {
                            annotations[num++] = obj;
                        }

                        index++;
                    }

                    if (num != 0)
                    {
                        while (num < index)
                        {
                            annotations[num++] = null;
                        }
                    }
                    else
                    {
                        _annotations = null;
                    }
                }
            }
        }

        /// <summary>
        /// Removes the annotations of the specified type from the current OpenXmlElement element.
        /// </summary>
        /// <param name="type">The type of the annotations to remove.</param>
        public void RemoveAnnotations(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            if (_annotations != null)
            {
                object[] annotations = _annotations as object[];
                if (annotations == null)
                {
                    if (type.GetTypeInfo().IsAssignableFrom(_annotations.GetType().GetTypeInfo()))
                    {
                        _annotations = null;
                    }
                }
                else
                {
                    int index = 0;
                    int num = 0;
                    while (index < annotations.Length)
                    {
                        object o = annotations[index];
                        if (o == null)
                        {
                            break;
                        }

                        if (!type.GetTypeInfo().IsAssignableFrom(o.GetType().GetTypeInfo()))
                        {
                            annotations[num++] = o;
                        }

                        index++;
                    }

                    if (num != 0)
                    {
                        while (num < index)
                        {
                            annotations[num++] = null;
                        }
                    }
                    else
                    {
                        _annotations = null;
                    }
                }
            }
        }

        #endregion

        #region IEnumerable<OpenXmlElement> Members

        /// <summary>
        /// Returns an enumerator that iterates through the child collection.
        /// </summary>
        /// <returns>An IEnumerator object that can be used to iterate through the child collection. </returns>
        public IEnumerator<OpenXmlElement> GetEnumerator()
        {
            return new OpenXmlChildElements(this).GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new OpenXmlChildElements(this).GetEnumerator();
        }

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
        public object Clone()
        {
            return CloneNode(true);
        }

        #endregion

        #region internal and private methods

        /// <summary>
        /// Indicates whether the specified namespace uri equals @"http://www.w3.org/2000/xmlns/".
        /// </summary>
        /// <param name="nsUri">The namespace uri.</param>
        /// <returns>True if nsUri == @"http://www.w3.org/2000/xmlns/".</returns>
        internal bool IsXmlnsUri(string nsUri)
        {
            if (OpenXmlElementContext != null)
            {
                return OpenXmlElementContext.IsXmlnsUri(nsUri);
            }
            else
            {
                return nsUri == OpenXmlElementContext.xmlnsUri;
            }
        }

        /// <summary>
        /// Indicates whether the specified namespace is a known namespace.
        /// </summary>
        /// <param name="namespaceUri"></param>
        /// <returns></returns>
        internal static bool IsKnownNamespace(string namespaceUri)
        {
            byte id;
            return NamespaceIdMap.TryGetNamespaceId(namespaceUri, out id);
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

        internal static void SplitName(string name, out string prefix, out string localName)
        {
            int length = name.IndexOf(':');
            if (((-1 == length) || (length == 0)) || ((name.Length - 1) == length))
            {
                prefix = string.Empty;
                localName = name;
            }
            else
            {
                prefix = name.Substring(0, length);
                localName = name.Substring(length + 1);
            }
        }

        private bool ValidOuterXml(string outerXml, string namespaceURI, string localName)
        {
            using (XmlReader xmlReader = CreateXmlReader(outerXml))
            {
                // Skip the leading whitespace since OpenXmlElement ignores the Whitespace NodeType.
                do
                {
                    if (xmlReader.Read())
                    {
                        if (xmlReader.NodeType == XmlNodeType.Element)
                        {
                            return string.Equals(namespaceURI, xmlReader.NamespaceURI) && string.Equals(localName, xmlReader.LocalName);
                        }
                    }
                } while (xmlReader.NodeType == XmlNodeType.Whitespace);
            }

            return false;
        }

        #endregion

        #region MC Staffs

        /// <summary>
        /// Gets or sets the markup compatibility attributes. Returns null if no markup compatibility attributes are defined for the current element.
        /// </summary>
        public MarkupCompatibilityAttributes MCAttributes
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

        private bool LoadMCAttribute(string localName, string value)
        {
            // Do not call this.MCAttributes as this method is called on xml parsing.
            if (McAttributesFiled == null)
            {
                McAttributesFiled = new MarkupCompatibilityAttributes();
            }

            if (localName.Equals(MCConsts.Ignorable))
            {
                McAttributesFiled.Ignorable = value;
                return true;
            }

            if (localName.Equals(MCConsts.ProcessContent))
            {
                McAttributesFiled.ProcessContent = value;
                return true;
            }

            if (localName.Equals(MCConsts.PreserveElements))
            {
                McAttributesFiled.PreserveElements = value;
                return true;
            }

            if (localName.Equals(MCConsts.PreserveAttributes))
            {
                McAttributesFiled.PreserveAttributes = value;
                return true;
            }

            if (localName.Equals(MCConsts.MustUnderstand))
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
        private static MarkupCompatibilityAttributes LoadMCAttribute(XmlReader xmlReader)
        {
            MarkupCompatibilityAttributes mcAttributes = null;

            if (xmlReader.HasAttributes)
            {
                while (xmlReader.MoveToNextAttribute())
                {
                    if (xmlReader.NamespaceURI == AlternateContent.MarkupCompatibilityNamespace)
                    {
                        switch (xmlReader.LocalName)
                        {
                            case MCConsts.Ignorable:
                                if (mcAttributes == null)
                                {
                                    mcAttributes = new MarkupCompatibilityAttributes();
                                }

                                mcAttributes.Ignorable = xmlReader.Value;
                                break;
                            case MCConsts.ProcessContent:
                                if (mcAttributes == null)
                                {
                                    mcAttributes = new MarkupCompatibilityAttributes();
                                }

                                mcAttributes.ProcessContent = xmlReader.Value;
                                break;
                            case MCConsts.PreserveElements:
                                if (mcAttributes == null)
                                {
                                    mcAttributes = new MarkupCompatibilityAttributes();
                                }

                                mcAttributes.PreserveElements = xmlReader.Value;
                                break;
                            case MCConsts.PreserveAttributes:
                                if (mcAttributes == null)
                                {
                                    mcAttributes = new MarkupCompatibilityAttributes();
                                }

                                mcAttributes.PreserveAttributes = xmlReader.Value;
                                break;
                            case MCConsts.MustUnderstand:
                                if (mcAttributes == null)
                                {
                                    mcAttributes = new MarkupCompatibilityAttributes();
                                }

                                mcAttributes.MustUnderstand = xmlReader.Value;
                                break;
                        }
                    }
                }

                //  Moves the reader back to the element node.
                xmlReader.MoveToElement();
            }

            return mcAttributes;
        }

        private bool RemoveMCAttribute(string localName)
        {
            if (MCAttributes == null)
            {
                return false;
            }

            if (localName.Equals(MCConsts.Ignorable))
            {
                MCAttributes.Ignorable = null;
                return true;
            }

            if (localName.Equals(MCConsts.ProcessContent))
            {
                MCAttributes.ProcessContent = null;
                return true;
            }

            if (localName.Equals(MCConsts.PreserveElements))
            {
                MCAttributes.PreserveElements = null;
                return true;
            }

            if (localName.Equals(MCConsts.PreserveAttributes))
            {
                MCAttributes.PreserveAttributes = null;
                return true;
            }

            if (localName.Equals(MCConsts.MustUnderstand))
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
            if (string.IsNullOrEmpty(mcPrefix))
            {
                mcPrefix = MarkupCompatibilityAttributes.MCPrefix;
            }

            if (MCAttributes.Ignorable != null)
            {
                attributes.Add(new OpenXmlAttribute(mcPrefix, "Ignorable", AlternateContent.MarkupCompatibilityNamespace, MCAttributes.Ignorable));
            }

            if (MCAttributes.ProcessContent != null)
            {
                attributes.Add(new OpenXmlAttribute(mcPrefix, "ProcessContent", AlternateContent.MarkupCompatibilityNamespace, MCAttributes.ProcessContent));
            }

            if (MCAttributes.PreserveElements != null)
            {
                attributes.Add(new OpenXmlAttribute(mcPrefix, "PreserveElements", AlternateContent.MarkupCompatibilityNamespace, MCAttributes.PreserveElements));
            }

            if (MCAttributes.PreserveAttributes != null)
            {
                attributes.Add(new OpenXmlAttribute(mcPrefix, "PreserveAttributes", AlternateContent.MarkupCompatibilityNamespace, MCAttributes.PreserveAttributes));
            }

            if (MCAttributes.MustUnderstand != null)
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
            if (MCAttributes == null)
            {
                throw new KeyNotFoundException(ExceptionMessages.CannotFindAttribute);
            }

            var mcPrefix = LookupPrefix(AlternateContent.MarkupCompatibilityNamespace);
            if (string.IsNullOrEmpty(mcPrefix))
            {
                mcPrefix = MarkupCompatibilityAttributes.MCPrefix;
            }

            if (localName.Equals(MCConsts.Ignorable))
            {
                return new OpenXmlAttribute(mcPrefix, localName, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.Ignorable);
            }

            if (localName.Equals(MCConsts.ProcessContent))
            {
                return new OpenXmlAttribute(mcPrefix, localName, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.ProcessContent);
            }

            if (localName.Equals(MCConsts.PreserveElements))
            {
                return new OpenXmlAttribute(mcPrefix, localName, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.PreserveElements);
            }

            if (localName.Equals(MCConsts.PreserveAttributes))
            {
                return new OpenXmlAttribute(mcPrefix, localName, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.PreserveAttributes);
            }

            if (localName.Equals(MCConsts.MustUnderstand))
            {
                return new OpenXmlAttribute(mcPrefix, localName, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.MustUnderstand);
            }

            throw new KeyNotFoundException(ExceptionMessages.CannotFindAttribute);
        }

        private void WriteMCAttribute(XmlWriter xmlWriter)
        {
            if (MCAttributes == null)
            {
                return;
            }

            var mcPrefix = xmlWriter.LookupPrefix(AlternateContent.MarkupCompatibilityNamespace);
            if (string.IsNullOrEmpty(mcPrefix))
            {
                mcPrefix = MarkupCompatibilityAttributes.MCPrefix;
            }

            if (MCAttributes.Ignorable != null)
            {
                xmlWriter.WriteAttributeString(mcPrefix, MCConsts.Ignorable, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.Ignorable);
            }

            if (MCAttributes.ProcessContent != null)
            {
                xmlWriter.WriteAttributeString(mcPrefix, MCConsts.ProcessContent, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.ProcessContent);
            }

            if (MCAttributes.PreserveElements != null)
            {
                xmlWriter.WriteAttributeString(mcPrefix, MCConsts.PreserveElements, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.PreserveElements);
            }

            if (MCAttributes.PreserveAttributes != null)
            {
                xmlWriter.WriteAttributeString(mcPrefix, MCConsts.PreserveAttributes, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.PreserveAttributes);
            }

            if (MCAttributes.MustUnderstand != null)
            {
                xmlWriter.WriteAttributeString(mcPrefix, MCConsts.MustUnderstand, AlternateContent.MarkupCompatibilityNamespace, MCAttributes.MustUnderstand);
            }
        }

        private int MCAttributeCount()
        {
            if (MCAttributes == null)
                return 0;

            int ret = 0;
            if (MCAttributes.Ignorable != null)
            {
                ret++;
            }

            if (MCAttributes.ProcessContent != null)
            {
                ret++;
            }

            if (MCAttributes.PreserveElements != null)
            {
                ret++;
            }

            if (MCAttributes.PreserveAttributes != null)
            {
                ret++;
            }

            if (MCAttributes.MustUnderstand != null)
            {
                ret++;
            }

            return ret;
        }

        internal void RemoveAttributesBasedonMC()
        {
            if (OpenXmlElementContext == null ||
                OpenXmlElementContext.MCSettings.ProcessMode == DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessMode.NoProcess)
            {
                return;
            }

            if (!OpenXmlElementContext.MCContext.HasIgnorable())
            {
                return;
            }

            foreach (var attribute in RawAttributes)
            {
                if (attribute.HasValue)
                {
                    var action = OpenXmlElementContext.MCContext.GetAttributeAction(attribute.Tag.Namespace, attribute.Tag.Name, OpenXmlElementContext.MCSettings.TargetFileFormatVersions);

                    if (action == AttributeAction.Ignore)
                    {
                        attribute.Value = null;
                    }
                }
            }

            if (ExtendedAttributesField != null)
            {
                var tobeRemoved = new List<OpenXmlAttribute>();

                foreach (var attribute in ExtendedAttributesField)
                {
                    var action = OpenXmlElementContext.MCContext.GetAttributeAction(attribute.NamespaceUri, attribute.LocalName, OpenXmlElementContext.MCSettings.TargetFileFormatVersions);
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

        internal string LookupNamespaceLocal(string prefix)
        {
            if (NamespaceDeclField != null)
            {
                for (int i = 0; i < NamespaceDeclField.Count; i++)
                {
                    if (NamespaceDeclField[i].Key == prefix)
                    {
                        return NamespaceDeclField[i].Value;
                    }
                }
            }

            return null;
        }

        internal string LookupPrefixLocal(string uri)
        {
            if (NamespaceDeclField != null)
            {
                for (int i = 0; i < NamespaceDeclField.Count; i++)
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
        public string LookupNamespace(string prefix)
        {
            if (prefix == null)
            {
                throw new ArgumentNullException(nameof(prefix));
            }

            // first, lookup whether the prefix is defined on itself and any ancestor elements.
            var node = this;
            string ret = null;
            while (node != null)
            {
                ret = node.LookupNamespaceLocal(prefix);
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
        public string LookupPrefix(string namespaceUri)
        {
            if (string.IsNullOrEmpty(namespaceUri))
            {
                throw new ArgumentNullException(nameof(namespaceUri));
            }

            var node = this;
            string ret = null;
            while (node != null)
            {
                ret = node.LookupPrefixLocal(namespaceUri);
                if (!string.IsNullOrEmpty(ret))
                    return ret;
                node = node.Parent;
            }

            return null;
        }

        #endregion

        /// <summary>
        /// Returns the next sibling element that is not an OpenXmlMiscNode element.
        /// </summary>
        /// <returns>The next sibling element that is not an OpenXmlMiscNode element.</returns>
        internal OpenXmlElement GetNextNonMiscElementSibling()
        {
            var next = NextSibling();

            while (next != null && next is OpenXmlMiscNode)
            {
                next = next.NextSibling();
            }

            return next;
        }

        /// <summary>
        /// Returns the first child element that is not an OpenXmlMiscNode element.
        /// </summary>
        /// <returns>The first child element that is not an OpenXmlMiscNode element.</returns>
        internal OpenXmlElement GetFirstNonMiscElementChild()
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
        internal OpenXmlPartRootElement GetPartRootElement()
        {
            var root = this;

            while (root.Parent != null)
            {
                root = root.Parent;
            }

            var partRootElement = root as OpenXmlPartRootElement;

            return partRootElement;
        }
    }
}
