// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Globalization;
using System.Diagnostics;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml
{
    internal class MiscAttrContainer
    {
        internal List<OpenXmlAttribute> ExtendedAttributesField { get; set; }

        internal MarkupCompatibilityAttributes _mcAttributes { get; set; }

        internal List<KeyValuePair<string, string>> _nsMappings { get; set; }
    }
    /// <summary>
    /// Represents a base class that all elements in an Office Open XML document derive from.
    /// </summary>
    /// <remarks>
    /// Annotations will not be cloned when calling .Clone() and .CloneNode(bool).
    /// </remarks>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    public abstract partial class OpenXmlElement : IEnumerable<OpenXmlElement>, ICloneable
    {

        #region data members

        // private bool _disposed;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OpenXmlElement _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OpenXmlElement _next;

        // implement annotations mechanism like XObject in Linq
        // Annotations will not be cloned when calling .Clone() and .CloneNode(bool)
        private object _annotations;

        // Review: donghz
        // why do we need to initialize this flag as "true"? 
        // Or do we really need this flag? I feel only _rawOuterXml is enough... null or not-null...
        // private bool _xmlParsed = true;
        // private string _rawInnerXml;
        private string _rawOuterXml = string.Empty;

        // known attributes - attributes defined in schema
        private OpenXmlSimpleType[] _fixedAttributes;

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


        internal List<KeyValuePair<string,string>> NamespaceDeclField
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
            if (!String.IsNullOrEmpty(outerXml))
            {
                if (!ValidOuterXml(outerXml, this.NamespaceUri, this.LocalName))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOuterXml, "outerXml");
                }

                this.RawOuterXml = outerXml;
            }
        }

        #region internal properties

        /// <summary>
        /// Gets the next element in the linked list.
        /// </summary>
        internal OpenXmlElement next
        {
            get { return this._next; }
            set { this._next = value; }
        }

        //internal bool XmlParsed
        //{
        //    get { return _xmlParsed; }
        //    set { _xmlParsed = value; }
        //}

        /// <summary>
        /// Returns true if the inner raw xml is parsed.
        /// </summary>
        internal bool XmlParsed
        {
            get { return String.IsNullOrEmpty(this._rawOuterXml); }
        }

        /// <summary>
        /// Gets the raw OuterXml.
        /// </summary>
        internal string RawOuterXml
        {
            get 
            { 
                return _rawOuterXml; 
            }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    _rawOuterXml = string.Empty;
                }

                _rawOuterXml = value; 
            }
        }
    
        /// <summary>
        /// Gets an array of fixed attributes (attributes that are defined in the schema).
        /// </summary>
        private OpenXmlSimpleType[] FixedAttributesArray
        {
            get
            {
                if (this._fixedAttributes == null && this.FixedAttributeTotal > 0)
                {
                    this._fixedAttributes = new OpenXmlSimpleType[this.FixedAttributeTotal];
                }

                return _fixedAttributes;
            }
        }

        /// <summary>
        /// Gets an array of fixed attributes.
        /// The attributes will be parsed out if they are not yet parsed.
        /// </summary>
        internal OpenXmlSimpleType[] Attributes
        {
            get
            {
                MakeSureParsed( );
                Debug.Assert(this.FixedAttributesArray == null && this.FixedAttributeTotal == 0 || this.FixedAttributesArray != null);
                return this.FixedAttributesArray;
            }
        }

        #endregion

        #region internal virtual properties

        // following properties will be overrided in all generated classes.
        // generate will generate the const data

        /// <summary>
        /// Gets the namespace ID of the current element.
        /// </summary>
        internal abstract byte NamespaceId
        {
            get;
        }

        internal int FixedAttributeTotal
        {
            get 
            {
                if (this.AttributeTagNames != null)
                {
                    return this.AttributeTagNames.Length;
                }
                return 0; 
            }
        }

        /// <summary>
        /// Gets the tag names of each attribute.
        /// </summary>
        internal virtual string[] AttributeTagNames
        {
            get { return null; }
        }

        /// <summary>
        /// Gets the namespace IDs of each attribute.
        /// </summary>
        internal virtual byte[] AttributeNamespaceIds
        {
            get { return null; }
        }

        #endregion

        #region public properties

        /// <summary>
        /// Gets the type ID of the current element. 
        /// </summary>
        internal virtual int ElementTypeId 
        {
            get { return ReservedElementTypeIds.OpenXmlElementId; }
        }

        /// <summary>
        /// Gets the OpenXmlEementContext of the current element.
        /// </summary>
        public OpenXmlElementContext OpenXmlElementContext
        {
            get { return this.RootElementContext; }
            // internal set { _elementContext = value; }
        }

        /// <summary>
        /// Gets the OpenXmlEementContext from the root element.
        /// </summary>
        internal virtual OpenXmlElementContext RootElementContext
        {
            get
            {
                if (this.Parent != null)
                {
                    return this.Parent.RootElementContext;
                }

                return null;
            }
        }

        /// <summary>
        /// Gets the first child of the OpenXmlElement element.
        /// Returns null (Nothing in Visual Basic) if there is no such OpenXmlElement element. 
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
        public virtual OpenXmlElement FirstChild
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the last child of the OpenXmlElement element.
        /// Returns null (Nothing in Visual Basic) if there is no such OpenXmlElement element. 
        /// </summary>
        public virtual OpenXmlElement LastChild
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// Gets a boolean value that indicates whether the current element has any attributes. 
        /// </summary>
        public bool HasAttributes
        {
            get
            {
                MakeSureParsed();
                if (ExtendedAttributesField!= null && ExtendedAttributesField.Count != 0)
                {
                    return true;
                }

                if (this.Attributes != null)
                {
                    foreach (OpenXmlSimpleType value in this.Attributes)
                    {
                        if (value != null)
                        {
                            return true;
                        }
                    }
                }
                if (this.MCAttributeCount() > 0)
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
                this.MakeSureParsed();
                if (ExtendedAttributesField != null)
                {
                    return this.ExtendedAttributesField;
                }
                else
                    return EmptyEnumerable<OpenXmlAttribute>.EmptyEnumerableSingleton;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the current element has any child elements. 
        /// </summary>
        public abstract bool HasChildren
        {
            get;
        }

        /// <summary>
        /// Gets all the child nodes of the current element. 
        /// </summary>
        public virtual OpenXmlElementList ChildElements
        {
            get
            {
                if (this.HasChildren)
                {
                    return new OpenXmlChildElements(this);
                }
                else
                {
                    // Use a singleton EmptyElementList when there is no children to avoid uncessory object.
                    return EmptyElementList.EmptyElementListSingleton;
                }
            }
        }

        /// <summary>
        /// Gets the parent element of the current element. 
        /// </summary>
        public OpenXmlElement Parent
        {
            get { return this._parent; }
            internal set { this._parent = value; }
        }

        /// <summary>
        /// Gets the namespace URI of the current element.
        /// </summary>
        public virtual string NamespaceUri
        {
            get
            {
                return NamespaceIdMap.GetNamespaceUri(this.NamespaceId);
            }
        }

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
                var ret = this.LookupPrefix(this.NamespaceUri);
                if (string.IsNullOrEmpty(ret))
                {
                    ret = NamespaceIdMap.GetNamespacePrefix(this.NamespaceId);
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
                    return EmptyEnumerable<KeyValuePair<string, string>>.EmptyEnumerableSingleton;
                }
                return NamespaceDeclField;
            }
        }
      
        /// <summary>
        /// Gets the qualified name of the current element.
        /// </summary>
        public virtual XmlQualifiedName XmlQualifiedName
        {
            get
            {
                return new XmlQualifiedName(this.LocalName, this.NamespaceUri);
            }
        }
        
        /// <summary>
        /// Gets the concatenated values of the node and all of its children. 
        /// </summary>
        public virtual string InnerText
        {
            get
            {
                return string.Empty;
            }
            protected set
            {
                throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Gets or sets the markup that represents only the child elements of the current element.
        /// </summary>
        public virtual string InnerXml
        {
            get
            {
                if (this.XmlParsed)
                {
                    StringWriter w = new StringWriter(CultureInfo.InvariantCulture);
                    XmlDOMTextWriter writer2 = new XmlDOMTextWriter(w);
                    try
                    {
                        this.WriteContentTo(writer2);
                    }
                    finally
                    {
                        writer2.Close();
                    }
                    return w.ToString();
                }
                else
                {
                    using (TextReader stringReader = new StringReader(this.RawOuterXml))
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
                if (this.XmlParsed)
                {
                    // namespace, this element and attributes
                    StringWriter w = new StringWriter(CultureInfo.InvariantCulture);
                    XmlTextWriter writer2 = new XmlDOMTextWriter(w);
                    try
                    {
                        this.WriteTo(writer2);
                    }
                    finally
                    {
                        writer2.Close();
                    }
                    return w.ToString();
                }
                else
                {
                    return this.RawOuterXml;
                }
            }
            internal set
            {
                //if (!String.IsNullOrEmpty(value))
                //{
                //    if (!ValidOuterXml(value, this.NamespaceURI, this.LocalName))
                //    {
                //        // TODO: exception message
                //        throw new InvalidOperationException();
                //    }
                //}

                if (this.XmlParsed)
                {
                    this.RemoveAllChildren();
                    this.NamespaceDeclField = null;
                    this.ExtendedAttributesField = null;
                    if (this.FixedAttributesArray != null)
                    {
                        for (int i = 0; i < this.FixedAttributesArray.Length; i++)
                        {
                            this.FixedAttributesArray[i] = null;
                        }
                    }
                    this.MCAttributes = null;
                }

                if (!String.IsNullOrEmpty(value))
                {
                    this.RawOuterXml = value;
                }
                else
                {
                    this._rawOuterXml = String.Empty;
                }
            }
        }


        #endregion

        #region public methods

        //public override IEnumerable<OpenXmlAttribute<T>> Attributes
        //{
        //    get { throw new NotImplementedException(ExceptionMessages.NonImplemented); }
        //}

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
                throw new ArgumentNullException("localName");
            }

            if (namespaceUri == null)
            {
                // treat null string as empty.
                namespaceUri = string.Empty;
            }

            if (localName == string.Empty)
            {
                throw new ArgumentOutOfRangeException("localName", ExceptionMessages.StringIsEmpty);
            }

            if (this.HasAttributes)
            {
                int index = 0;
                OpenXmlAttribute attribute;

                if (this.Attributes != null && namespaceUri != null)
                {
                    for (index = 0; index < this.Attributes.Length; index++)
                    {
                        if (this.Attributes[index] != null &&
                            this.AttributeTagNames[index] == localName &&
                            NamespaceIdMap.GetNamespaceUri(this.AttributeNamespaceIds[index]) == namespaceUri)
                        {
                            attribute = new OpenXmlAttribute(NamespaceIdMap.GetNamespacePrefix(this.AttributeNamespaceIds[index]),
                                                              this.AttributeTagNames[index],
                                                              NamespaceIdMap.GetNamespaceUri(this.AttributeNamespaceIds[index]),
                                                              this.Attributes[index].ToString());
                            return attribute;
                        }
                    }
                }

                foreach (OpenXmlAttribute extendedAttribute in this.ExtendedAttributes)
                {
                    if (extendedAttribute.LocalName == localName && extendedAttribute.NamespaceUri == namespaceUri)
                    {
                        // clone a copy 
                        attribute = new OpenXmlAttribute(extendedAttribute.Prefix, extendedAttribute.LocalName, extendedAttribute.NamespaceUri, extendedAttribute.Value);
                        return attribute;
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
            if (this.HasAttributes)
            {
                List<OpenXmlAttribute> attributes = new List<OpenXmlAttribute>();
                GetAttributes(attributes);
                return attributes;
            }
            else
            {
                return new List<OpenXmlAttribute>();
            }
        }

        /// <summary>
        /// Gets a collection that contains a copy of all the attributes.
        /// </summary>
        /// <param name="attributes">The collection to hold the copy of the attributes.</param>
        /// <remarks>The returned collection is a non-live copy.</remarks>
        private void GetAttributes(ICollection<OpenXmlAttribute> attributes)
        {
            if (attributes == null)
            {
                throw new ArgumentNullException("attributes");
            }

            if (this.HasAttributes)
            {
                int index = 0;
                OpenXmlAttribute attribute;

                if (this.Attributes != null)
                {
                    for (index = 0; index < this.Attributes.Length; index++)
                    {
                        if (this.Attributes[index] != null)
                        {
                            attribute = new OpenXmlAttribute(NamespaceIdMap.GetNamespacePrefix(this.AttributeNamespaceIds[index]),
                                                              this.AttributeTagNames[index],
                                                              NamespaceIdMap.GetNamespaceUri(this.AttributeNamespaceIds[index]),
                                                              this.Attributes[index].ToString());
                            attributes.Add(attribute);
                        }
                    }
                }

                // append extended attributes
                foreach (OpenXmlAttribute extendedAttribute in this.ExtendedAttributes)
                {
                    // clone a copy 
                    attribute = new OpenXmlAttribute(extendedAttribute.Prefix, extendedAttribute.LocalName, extendedAttribute.NamespaceUri, extendedAttribute.Value);
                    attributes.Add(attribute);
                }

                if (MCAttributes != null)
                {
                    AddMCAttributes(attributes);
                }
            }
            else
            {
                return;
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
            if (String.IsNullOrEmpty(openXmlAttribute.LocalName))
            {
                throw new ArgumentOutOfRangeException("openXmlAttribute", ExceptionMessages.LocalNameIsNull);
            }

            if (openXmlAttribute.Prefix == OpenXmlElementContext.xmlnsPrefix)
            {
                throw new InvalidOperationException(ExceptionMessages.CannotSetAttribute);
            }


            MakeSureParsed();
            if (!this.TrySetFixedAttribute(openXmlAttribute.NamespaceUri, openXmlAttribute.LocalName, openXmlAttribute.Value, false))
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
                    foreach (OpenXmlAttribute extendedAttibute in this.ExtendedAttributesField)
                    {
                        if (extendedAttibute.LocalName == openXmlAttribute.LocalName &&
                            extendedAttibute.NamespaceUri == openXmlAttribute.NamespaceUri)
                        {
                            this.ExtendedAttributesField.RemoveAt(index);
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
                this.ExtendedAttributesField.Add(attribute);
                
            }
        }

        /// <summary>
        /// Removes the attribute from the current element.
        /// </summary>
        /// <param name="localName">The local name of the attribute.</param>
        /// <param name="namespaceUri">The namesapce URI of the attribute.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the localName is empty.</exception>
        public void RemoveAttribute(string localName, string namespaceUri)
        {
            if (localName == null)
            {
                throw new ArgumentNullException("localName");
            }

            if (namespaceUri == null)
            {
                // treat null string as empty.
                namespaceUri = string.Empty;
            }

            if (localName == string.Empty)
            {
                throw new ArgumentOutOfRangeException("localName", ExceptionMessages.StringIsEmpty);
            }

            if (this.HasAttributes)
            {
                bool removed = false;
                if (this.FixedAttributeTotal > 0)
                {
                    // get attribute namespace ID
                    int index = this.TryFindAttributeIndex(namespaceUri, localName);

                    if (index >= 0)
                    {
                        // remove 
                        this.FixedAttributesArray[index] = null;
                        removed = true;
                    }
                }

                if (!removed)
                {
                    int index = 0;
                    if (this.ExtendedAttributesField != null)
                    {
                        foreach (OpenXmlAttribute extendedAttribute in this.ExtendedAttributesField)
                        {
                            if (extendedAttribute.LocalName == localName && extendedAttribute.NamespaceUri == namespaceUri)
                            {
                                this.ExtendedAttributesField.RemoveAt(index);
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
                throw new ArgumentNullException("openXmlAttributes");
            }

            foreach (OpenXmlAttribute attribute in openXmlAttributes)
            {
                this.SetAttribute(attribute);
            }
        }

        /// <summary>
        /// Clears all of the attributes, including both known attributes and extended attributes.
        /// </summary>
        public void ClearAllAttributes()
        {
            MakeSureParsed();
            // clear known attributes defined in schema
            if (this.FixedAttributesArray != null)
            {
                for (int i = 0; i < this.FixedAttributeTotal; i++)
                {
                    this.FixedAttributesArray[i] = null;
                }
            }

            // clear extended attributes
            this.ExtendedAttributesField = null;
            
            MCAttributes = null;
        }

        /// <summary>
        /// Adds a namepace declaration to the current node. 
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="uri">The uri.</param>
        /// <exception cref="InvalidOperationException">Thrown if the prefix is already used in the current node.</exception>
        public void AddNamespaceDeclaration(string prefix, string uri)
        {
            if (string.IsNullOrEmpty(prefix))
            {
                throw new ArgumentNullException("prefix");
            }
            if (string.IsNullOrEmpty(uri))
            {
                throw new ArgumentNullException("uri");
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
                    var msg = String.Format(System.Globalization.CultureInfo.CurrentUICulture, ExceptionMessages.DuplicatedPrefix, prefix);
                    throw new InvalidOperationException(msg);
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
                throw new ArgumentNullException("prefix");
            }
            MakeSureParsed();
            if (NamespaceDeclField != null)
            {
                for(int i = 0; i<NamespaceDeclField.Count; i++)
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
            return this.ChildElements.First<T>( );
        }
        
        /// <summary>
        /// Gets the OpenXmlElement element that immediately precedes the current OpenXmlElement element. 
        /// Returns null (Nothing in Visual Basic ) if there is no preceding OpenXmlElement element.
        /// </summary>
        /// <returns>The OpenXmlElement element that immediately precedes the current OpenXmlElement element.</returns>
        public OpenXmlElement PreviousSibling()
        {
            OpenXmlCompositeElement parent = this.Parent as OpenXmlCompositeElement;
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
        public T PreviousSibling<T>() where T : OpenXmlElement
        {
            OpenXmlElement element = this.PreviousSibling();

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
            OpenXmlElement parentNode = this.Parent;
            if ((parentNode != null) && (this.next != parentNode.FirstChild))
            {
                return this.next;
            }
            return null;
        }

        /// <summary>
        /// Gets the OpenXmlElement element with the specified type that follows the current OpenXmlElement element. 
        /// Returns null (Nothing in Visual Basic) if there is no next OpenXmlElement.
        /// </summary>
        /// <returns>The OpenXmlElement element with the specified type that follows the current OpenXmlElement element.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
        public T NextSibling<T>() where T : OpenXmlElement
        {
            OpenXmlElement element = this.NextSibling();

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
            OpenXmlElement ancestor = this.Parent;

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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
        public IEnumerable<T> Ancestors<T>() where T : OpenXmlElement
        {
            OpenXmlElement ancestor = this.Parent;

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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
        public IEnumerable<T> Elements<T>() where T : OpenXmlElement
        {
            return this.ChildElements.OfType<T>();
        }

        /// <summary>
        /// Enumerates all of the current element's children. 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OpenXmlElement> Elements()
        {
            return this.ChildElements;
        }

        /// <summary>
        /// Enumerate all of the current element's descendants of type T. 
        /// </summary>
        /// <typeparam name="T">The element type.</typeparam>
        /// <returns></returns>
        public IEnumerable<T> Descendants<T>() where T : OpenXmlElement
        {
            T elementT = null;

            foreach(OpenXmlElement element in this.Descendants() )
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
            if ( this.FirstChild == null )
            {
                yield break;
            }

            OpenXmlElement root = this.FirstChild;

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
            if ( this.Parent != null )
            {
                OpenXmlElement element = this.Parent.FirstChild;

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
            if (this.Parent != null)
            {
                OpenXmlElement element = this.NextSibling();

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
                throw new ArgumentNullException("xmlWriter");
            }

            if (this.XmlParsed)
            {
                //check the namespace mapping defined in this node first. because till now xmlWriter don't know the mapping defined in the current node.
                string prefix = LookupPrefixLocal(this.NamespaceUri);
                //if not defined in the current node, try the xmlWriter
                if (string.IsNullOrEmpty(prefix))
                {
                    prefix = xmlWriter.LookupPrefix(this.NamespaceUri);
                }
                //if xmlWriter didn't find it, it means the node is constructed by user and is not in the tree yet
                //in this case, we use the predefined prefix
                if (string.IsNullOrEmpty(prefix))
                {
                    prefix = NamespaceIdMap.GetNamespacePrefix(this.NamespaceId);
                }
                xmlWriter.WriteStartElement(prefix, this.LocalName, this.NamespaceUri);
                this.WriteAttributesTo(xmlWriter);
                this.WriteContentTo(xmlWriter);
                xmlWriter.WriteEndElement();
            }
            else
            {
                xmlWriter.WriteRaw(this.RawOuterXml);
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
                throw new ArgumentNullException("newChildren");
            }

            foreach (OpenXmlElement child in newChildren)
            {
                this.AppendChild(child);
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
                    this.AppendChild(child);
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
                throw new ArgumentNullException("newElement");
                // TODO: should we just return null? InsertBefore / InsertAfter do not throw on null newChild.
                // return null;
            }
            if (this.Parent == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ParentIsNull);
            }

            return this.Parent.InsertAfter(newElement, this);
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
                throw new ArgumentNullException("newElement");
                // TODO: should we just return null? InsertBefore / InsertAfter do not throw on null newChild.
                // return null;
            }
            if (this.Parent == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ParentIsNull);
            }

            return this.Parent.InsertBefore(newElement, this);
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
        public void RemoveAllChildren<T>() where T : OpenXmlElement
        {
            OpenXmlElement element = this.FirstChild;
            OpenXmlElement next;

            while (element != null)
            {
                next = element.NextSibling();

                if (element is T)
                {
                    this.RemoveChild(element);
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
            if (this.Parent == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ParentIsNull);
            }

            this.Parent.RemoveChild(this);
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
                throw new ArgumentNullException("element");
            }

            return (GetOrder(this, element) == ElementOrder.After);
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
                throw new ArgumentNullException("element");
            }

            return (GetOrder(this, element) == ElementOrder.Before);
        }


        private enum ElementOrder
        {
            Same, // same element
            Before,
            After,
            NotInSameTree
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
            else if (Object.ReferenceEquals(element1.Parent, element2.Parent))
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
                if (Object.ReferenceEquals(element, element2))
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
                if (Object.ReferenceEquals(element, element2))
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

            if (this.XmlParsed && this.HasAttributes)
            {

                int i = 0;

                if (this.Attributes != null)
                {
                    foreach (OpenXmlSimpleType attribute in this.Attributes)
                    {
                        if (attribute != null)
                        {
                            //string prefix = NamespaceIdMap.GetNamespacePrefix(AttributeNamespaceIds[i]);
                            string ns = NamespaceIdMap.GetNamespaceUri(AttributeNamespaceIds[i]);
                            string prefix = string.Empty;
                            if (!string.IsNullOrEmpty(ns))
                            {
                                prefix = xmlWriter.LookupPrefix(ns);
                                if (string.IsNullOrEmpty(prefix))
                                {
                                    prefix = NamespaceIdMap.GetNamespacePrefix(AttributeNamespaceIds[i]);
                                }
                            }
                            
                            xmlWriter.WriteStartAttribute(prefix, AttributeTagNames[i], ns);
                            xmlWriter.WriteString(attribute.InnerText);
                            xmlWriter.WriteEndAttribute();
                        }
                        i++;
                    }
                }

                foreach (OpenXmlAttribute attribute in this.ExtendedAttributes)
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


        internal int TryFindAttributeIndex(string namespaceUri, string tagName)
        {
            Debug.Assert( ! String.IsNullOrEmpty(tagName));

            byte nsId = 0;

            Debug.Assert(this.FixedAttributeTotal > 0);

            if (namespaceUri != null && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out nsId))
            {
                for (int i = 0; i < this.AttributeTagNames.Length; i++)
                {
                    string name = this.AttributeTagNames[i];

                    if (name.Equals(tagName) && this.AttributeNamespaceIds[i] == nsId)
                    {
                        return i;
                    }
                }
            }
            // no throw, just return -1.
            return -1;
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
            if (this.FixedAttributeTotal > 0)
            {
                int index;

                if (!strictTranslation)
                {
                    // get attribute namespace ID
                    index = this.TryFindAttributeIndex(namespaceUri, localName);

                    if (index >= 0)
                    {
                        // load attributes
                        OpenXmlSimpleType attributeValue = AttributeFactory(namespaceUri, localName);
                        this.FixedAttributesArray[index] = attributeValue;
                        attributeValue.InnerText = value;

                        return true;
                    }
                }
                else
                {
                    // Strict -> Transitonal translation
                    bool isTranslationRequired;
                    bool isBitFieldOperationRequired = false;
                    bool isAttributesArrayAlreadyAvailable = false;

                    TagAttributeTranslator translator = AttributeTranslator.Translate(this.LocalName, localName, value);

                    isTranslationRequired = (translator != null) ? true : false;

                    // If the translation is required, then we first replace localName and value with the expected ones.
                    if (isTranslationRequired)
                    {
                        localName = translator.LocalName;
                        value = translator.Value;

                        // if value == "", we skip to store this attribute.
                        if (value == "")
                        {
                            return true;
                        }

                        isBitFieldOperationRequired = (translator.Trait != 0) ? true : false;
                    }

                    // get attribute namespace ID
                    index = this.TryFindAttributeIndex(namespaceUri, localName);

                    if (index >= 0)
                    {
                        // load attributes
                        OpenXmlSimpleType attributeValue;

                        isAttributesArrayAlreadyAvailable = (this.FixedAttributesArray[index] != null) ? true : false;

                        // If we need to do a bit field operation, replace value with the expected bit field string.
                        if (isBitFieldOperationRequired)
                        {
                            long bitField = 0;

                            if (isAttributesArrayAlreadyAvailable)
                            {
                                // If the attributes array are not null, we need to get the bitField.
                                string strValue = this.FixedAttributesArray[index].InnerText;
                                bitField = translator.Formatter.StringToValue(strValue);
                            }

                            bitField = (value == "true" || value == "1") ? (bitField | translator.Trait) : (bitField & ~translator.Trait);
                            value = translator.Formatter.ValueToString(bitField);
                        }

                        // If attributeValue for the index is not available, create and set it.
                        if (!isAttributesArrayAlreadyAvailable)
                        {
                            // load attributes
                            attributeValue = AttributeFactory(namespaceUri, localName);
                            this.FixedAttributesArray[index] = attributeValue;
                        }

                        this.FixedAttributesArray[index].InnerText = value;

                        return true;
                    }
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
                            this.ExtendedAttributesField.Add(new OpenXmlAttribute(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI, xmlReader.Value));
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
                this.OpenXmlElementContext.MCContext.LookupNamespaceDelegate = xmlReader.LookupNamespace;

                var mcAttributes = LoadMCAttribute(xmlReader);

                if (mcAttributes != null)
                {
                    OpenXmlElementContext.MCContext.PushMCAttributes(mcAttributes);
                    if (this.OpenXmlElementContext.ACBlockLevel == 0)
                    {
                        CheckMustUnderstandAttr(xmlReader, mcAttributes, this.OpenXmlElementContext.MCSettings);
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
        /// if this is a normal node, check mustunderstand attr in loading time
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
                        var msg = String.Format(System.Globalization.CultureInfo.CurrentCulture, ExceptionMessages.UnknowMCContent, mcAttributes.MustUnderstand.Value);
                        throw new InvalidMCContentException(msg);
                    }
                    if (NamespaceIdMap.IsInFileFormat(ns, mcSettings.TargetFileFormatVersions))
                    {
                        continue;
                    }
                    var error = string.Format(System.Globalization.CultureInfo.CurrentCulture, ExceptionMessages.NsNotUnderStand, prefix);
                    throw new NamespaceNotUnderstandException(error);
                }
            }
        }

        /// <summary>
        /// if this is a node in ACB, check mustunderstand after loaded
        /// </summary>
        internal void CheckMustUnderstandAttr()
        {
            if (this.MCAttributes == null || this.OpenXmlElementContext.MCSettings.ProcessMode == DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessMode.NoProcess)
            {
                return;
            }
            if (MCAttributes.MustUnderstand != null && !string.IsNullOrEmpty(MCAttributes.MustUnderstand.Value))
            {
                var prefixes = MCAttributes.MustUnderstand.Value.Trim().Split(new char[] { ' ' });
                foreach (var prefix in prefixes)
                {
                    var ns = this.LookupNamespace(prefix);
                    if (string.IsNullOrEmpty(ns))
                    {
                        var msg = String.Format(System.Globalization.CultureInfo.CurrentCulture, ExceptionMessages.UnknowMCContent, MCAttributes.MustUnderstand.Value);
                        throw new InvalidMCContentException(msg);
                    }
                    if (NamespaceIdMap.IsInFileFormat(ns, this.OpenXmlElementContext.MCSettings.TargetFileFormatVersions))
                    {
                        continue;
                    }
                    var error = string.Format(System.Globalization.CultureInfo.CurrentCulture, ExceptionMessages.NsNotUnderStand, prefix);
                    throw new NamespaceNotUnderstandException(error);
                }
            }
            foreach (var child in this.ChildElements)
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
                    this.Populate(xmlReader, loadMode);
                    break;

                case OpenXmlLoadMode.Lazy:
                    if (this.OpenXmlElementContext != null && xmlReader.Depth < this.OpenXmlElementContext.LazySteps)
                    {
                        this.Populate(xmlReader, loadMode);
                    }
                    else
                    {
                        this.LazyLoad( xmlReader );
                    }
                    break;
            }
        }

        internal void MakeSureParsed()
        {
            if (this.XmlParsed)
            {
                return;
            }

            ParseXml( );

            // set raw outer xml to empty to indicate that it is pased
            this.RawOuterXml = string.Empty;
        }

        internal virtual void LazyLoad(XmlReader xmlReader)
        {
            this.RawOuterXml = xmlReader.ReadOuterXml();
        }

        internal abstract void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode);

        internal virtual void ParseXml()
        {
            Debug.Assert( ! this.XmlParsed);

            if (String.IsNullOrEmpty(this.RawOuterXml))
            {
                return;
            }

            using (XmlReader xmlReader = this.CreateXmlReader())
            {
                xmlReader.Read(); // move the reader to the start of the element.
                if (this.OpenXmlElementContext != null)
                {
                    this.Populate(xmlReader, this.OpenXmlElementContext.LoadMode);
                }
                else
                {
                    this.Populate(xmlReader, OpenXmlLoadMode.Full);
                }
            }
        }

        internal XmlReader CreateXmlReader()
        {
            XmlReader xmlReader;
            TextReader stringReader = new StringReader(this.RawOuterXml);

            if (this.OpenXmlElementContext != null)
            {
                this.OpenXmlElementContext.XmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit; // set true explicitly for security fix
                xmlReader = XmlConvertingReaderFactory.Create(stringReader, this.OpenXmlElementContext.XmlReaderSettings);
            }
            else
            {
                xmlReader = XmlConvertingReaderFactory.Create(stringReader, OpenXmlElementContext.CreateDefaultXmlReaderSettings());
            }

            return xmlReader;
        }

        internal XmlReader CreateXmlReader(string outerXml)
        {
            XmlReader xmlReader;
            TextReader stringReader = new StringReader(outerXml);

            if (this.OpenXmlElementContext != null)
            {
                this.OpenXmlElementContext.XmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit; // set true explicitly for security fix
                xmlReader = XmlConvertingReaderFactory.Create(stringReader, this.OpenXmlElementContext.XmlReaderSettings);
            }
            else
            {
                xmlReader = XmlConvertingReaderFactory.Create(stringReader, OpenXmlElementContext.CreateDefaultXmlReaderSettings());
            }

            return xmlReader;
        }

        internal virtual OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
        {
            return null;
        }
        
        internal virtual OpenXmlSimpleType AttributeFactory(string namespaceUri, string name)
        {
            Debug.Assert(!String.IsNullOrEmpty(name));
            //
            OpenXmlSimpleType simpleType = null;
            byte nsId;

            if (namespaceUri != null && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out nsId))
            {
                simpleType = AttributeFactory(nsId, name);
            }

            if (simpleType == null)
            {
                // TODO: should we throw?
                simpleType = new StringValue();
            }

            return simpleType; 
        }

        internal OpenXmlElement ElementFactory(XmlReader xmlReader)
        {
            switch (xmlReader.NodeType)
            {
                case XmlNodeType.Element:
                    return this.ElementFactory(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI);

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
            Debug.Assert( ! String.IsNullOrEmpty(name));

            //
            OpenXmlElement newElement = null;
            byte nsId;

            if ( (! String.IsNullOrEmpty(namespaceUri)) && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out nsId))
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

        internal virtual T CloneImp<T>(bool deep) where T : OpenXmlElement, new( )
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
                    this.ExtendedAttributesField = new List<OpenXmlAttribute>(container.ExtendedAttributesField);
                }

                // Copy Attributes.
                if (container.Attributes != null)
                {
                    Debug.Assert(container.FixedAttributesArray.Length == container.FixedAttributesArray.Length);
                    for (int i = 0; i < container.Attributes.Length; i++)
                    {
                        OpenXmlSimpleType attr = container.Attributes[i];
                        if (attr != null)
                        {
                            this.FixedAttributesArray[i] = (OpenXmlSimpleType)attr.Clone();
                        }
                    }
                }

                // Copy MCAttributes
                if (container.MCAttributes != null)
                {
                    this.MCAttributes = CloneMCAttributes(container.MCAttributes);
                    Debug.Assert(this.MCAttributes != null);
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

        // Copy child elements fom the container.
        internal void CopyChilden(OpenXmlElement container, bool deep)
        {
            Debug.Assert(container != null);
            foreach (var element in container.ChildElements)
            {
                this.Append(element.CloneNode(deep));
            }
        }

        /// <summary>
        /// Indicates whether the current element is available in a specific version of Office Application.
        /// For strong typed element, the return value will be generated according to the schema.
        /// For OpenXmlUnknownElement element, always returns false, no matter what the version is.
        /// For OpenXmlMiscNode element, always returns true, no matter what the version is.
        /// </summary>
        /// <param name="version">The Office file format version.</param>
        /// <returns>Returns true if the element is defined in the specified version.</returns>
        internal abstract bool IsInVersion(FileFormatVersions version);

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
                throw new ArgumentNullException("annotation");
            }
            if (this._annotations == null)
            {
                this._annotations = (annotation is object[]) ? new object[] { annotation } : annotation;
            }
            else
            {
                object[] annotations = this._annotations as object[];
                if (annotations == null)
                {
                    this._annotations = new object[] { this._annotations, annotation };
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
                        this._annotations = annotations;
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
            if (this._annotations != null)
            {
                object[] annotations = this._annotations as object[];

                if (annotations == null)
                {
                    return (this._annotations as T);
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
        public Object Annotation(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (this._annotations != null)
            {
                object[] annotations = this._annotations as object[];
                if (annotations == null)
                {
                    if (type.IsInstanceOfType(this._annotations))
                    {
                        return this._annotations;
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
                        if (type.IsInstanceOfType(obj))
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
            if (this._annotations != null)
            {
                object[] annotations = this._annotations as object[];
                if (annotations == null)
                {
                    if (this._annotations is T)
                    {
                        yield return (T)this._annotations;
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
        public IEnumerable<Object> Annotations(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (this._annotations != null)
            {
                object[] annotations = this._annotations as object[];
                if (annotations == null)
                {
                    if (type.IsInstanceOfType(this._annotations))
                    {
                        yield return this._annotations;
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
                        if (type.IsInstanceOfType(obj))
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
            if (this._annotations != null)
            {
                object[] annotations = this._annotations as object[];
                if (annotations == null)
                {
                    if (this._annotations is T)
                    {
                        this._annotations = null;
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
                        this._annotations = null;
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
                throw new ArgumentNullException("type");
            }
            if (this._annotations != null)
            {
                object[] annotations = this._annotations as object[];
                if (annotations == null)
                {
                    if (type.IsInstanceOfType(this._annotations))
                    {
                        this._annotations = null;
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
                        if (!type.IsInstanceOfType(o))
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
                        this._annotations = null;
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
            if (this.OpenXmlElementContext != null)
            {
                return this.OpenXmlElementContext.IsXmlnsUri(nsUri);
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
            if (! (element is OpenXmlUnknownElement) && ! (element is OpenXmlMiscNode))
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
            using (XmlReader xmlReader = this.CreateXmlReader(outerXml))
            {
                do // O15:#3024890, Skip the leading whitespaces. OpenXmlElement ignores the Whitespace NodeType.
                {
                    // Fix bug #484153.
                    if (xmlReader.Read())
                    {
                        if (xmlReader.NodeType == XmlNodeType.Element)
                        {
                            return (string.Equals(namespaceURI, xmlReader.NamespaceURI) && string.Equals(localName, xmlReader.LocalName));
                        }
                    }

                } while (xmlReader.NodeType == XmlNodeType.Whitespace);
            }

            return false;
        }

        #endregion

        #region MC Staffs
        /// <summary>
        /// Sets the markup compatibility attributes. Returns null if no markup compatibility attributes are defined for the current element.
        /// </summary>
        public MarkupCompatibilityAttributes MCAttributes
        {
            get
            {
                this.MakeSureParsed();
                return this.McAttributesFiled;
            }

            set
            {
                this.MakeSureParsed();
                this.McAttributesFiled = value;
            }
        }

        private bool LoadMCAttribute(string localName, string value)
        {
            // DO NOT call this.MCAttributes as this method is called on xml parseing.
            if (this.McAttributesFiled == null)
            {
                this.McAttributesFiled = new MarkupCompatibilityAttributes();
            }
            if (localName.Equals(MCConsts.Ignorable))
            {
                this.McAttributesFiled.Ignorable = value;
                return true;
            }
            if (localName.Equals(MCConsts.ProcessContent))
            {
                this.McAttributesFiled.ProcessContent = value;
                return true;
            }
            if (localName.Equals(MCConsts.PreserveElements))
            {
                this.McAttributesFiled.PreserveElements = value;
                return true;
            }
            if (localName.Equals(MCConsts.PreserveAttributes))
            {
                this.McAttributesFiled.PreserveAttributes = value;
                return true;
            }
            if (localName.Equals(MCConsts.MustUnderstand))
            {
                this.McAttributesFiled.MustUnderstand = value;
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
            var mcPrefix = this.LookupPrefix(AlternateContent.MarkupCompatibilityNamespace);
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

            var mcPrefix = this.LookupPrefix(AlternateContent.MarkupCompatibilityNamespace);
            if (string.IsNullOrEmpty(mcPrefix))
            {
                mcPrefix = MarkupCompatibilityAttributes.MCPrefix;
            }

            if (localName.Equals(MCConsts.Ignorable))
            {
                return new OpenXmlAttribute(mcPrefix, localName,AlternateContent.MarkupCompatibilityNamespace,MCAttributes.Ignorable);
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
            if (this.OpenXmlElementContext == null || 
                this.OpenXmlElementContext.MCSettings.ProcessMode == DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessMode.NoProcess)
            {
                return;
            }
            if (!this.OpenXmlElementContext.MCContext.HasIgnorable())
            {
                return;
            }
            if (this.FixedAttributesArray != null)
            {
                int i = 0;
                foreach (OpenXmlSimpleType attribute in this.FixedAttributesArray)
                {
                    if (attribute != null)
                    {
                        string ns = NamespaceIdMap.GetNamespaceUri(AttributeNamespaceIds[i]);

                        var action = OpenXmlElementContext.MCContext.GetAttributeAction(ns, this.AttributeTagNames[i], OpenXmlElementContext.MCSettings.TargetFileFormatVersions);
                        if (action == AttributeAction.Ignore)
                        {
                            FixedAttributesArray[i] = null;
                        }
                    }
                    i++;
                }
            }

            if (this.ExtendedAttributesField != null)
            {
                List<OpenXmlAttribute> tobeRemoved = new List<OpenXmlAttribute>();
                foreach (OpenXmlAttribute attribute in this.ExtendedAttributesField)
                {
                    var action = OpenXmlElementContext.MCContext.GetAttributeAction(attribute.NamespaceUri, attribute.LocalName, OpenXmlElementContext.MCSettings.TargetFileFormatVersions);
                    if (action == AttributeAction.Ignore)
                    {
                        tobeRemoved.Add(attribute);
                    }
                }

                foreach (var attr in tobeRemoved)
                {
                    this.ExtendedAttributesField.Remove(attr);
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
                throw new ArgumentNullException("prefix");
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
                throw new ArgumentNullException("namespaceUri");
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
    }

    /// <summary>
    /// The base class of the Attribute formatter. (abstract)
    /// </summary>
    abstract internal class AttributeFormatter
    {
        protected int length = 0;

        /// <summary>
        /// The constructor to set the length of characters to express.
        /// </summary>
        /// <param name="length"></param>
        internal AttributeFormatter(int length)
        {
            Debug.Assert(length > 0);

            this.length = length;
        }

        /// <summary>
        /// Convert string to long. (abstract)
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>the converted long value</returns>
        abstract internal long StringToValue(string strValue);

        /// <summary>
        /// Convert long to string. (abstract)
        /// </summary>
        /// <param name="longValue"></param>
        /// <returns>the converted string</returns>
        abstract internal string ValueToString(long longValue);
    }

    /// <summary>
    /// Convert format between long and bin.
    /// </summary>
    internal class BinAttributeFormatter : AttributeFormatter
    {
        /// <summary>
        /// The constructor to set the length of characters to express.
        /// </summary>
        /// <param name="length"></param>
        internal BinAttributeFormatter(int length) : base(length)
        {
        }

        /// <summary>
        /// Convert string to long.
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>the converted long value</returns>
        internal override long StringToValue(string strValue)
        {
            long longValue = 0;
            int length;

            Debug.Assert(strValue != null);

            length = strValue.Length;

            Debug.Assert(length > 0);
            Debug.Assert(length <= 64); // The length of strValue changes depending on the attribute representation, but it at least needs to be less-than-equal 64(bit). 

            for (int count = 0; count < length; count++)
            {
                long bit;
                if (strValue[count] == '1')
                {
                    bit = 1;
                }
                else if (strValue[count] == '0')
                {
                    bit = 0;
                }
                else
                {
                    // if strValue[count] is neither '1' nor '0', we ignore this value by setting the bit zero.
                    bit = 0;
                }

                longValue = (bit == 0) ? (longValue & ~(bit << (length - 1 - count))) : (longValue | (bit << (length - 1 - count)));
            }

            return longValue;
        }

        /// <summary>
        /// Convert long to string.
        /// </summary>
        /// <param name="longValue"></param>
        /// <returns>the converted string</returns>
        internal override string ValueToString(long longValue)
        {
            StringBuilder strBin = new StringBuilder();

            for (int count = this.length - 1; count >= 0; count--)
            {
                strBin.Append((longValue & (1 << count)) > 0 ? '1' : '0');
            }

            return strBin.ToString();
        }
    }

    /// <summary>
    /// Convert format between long and hex.
    /// </summary>
    internal class HexAttributeFormatter : AttributeFormatter
    {
        /// <summary>
        /// The constructor to set the length of characters to express.
        /// </summary>
        /// <param name="length"></param>
        internal HexAttributeFormatter(int length) : base(length)
        {
        }

        /// <summary>
        /// Convert string to long.
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>the converted long value</returns>
        internal override long StringToValue(string strValue)
        {
            long longValue = 0;

            Debug.Assert(strValue != null);

            try
            {
                Int64.TryParse(strValue, NumberStyles.HexNumber, new CultureInfo("en-US"), out longValue);
            }
            catch
            {
                Debug.Assert(true, "Int64.TryParse failed.");
            }

            return longValue;
        }

        /// <summary>
        /// Convert long to string.
        /// </summary>
        /// <param name="longValue"></param>
        /// <returns>the converted string</returns>
        internal override string ValueToString(long longValue)
        {
            return longValue.ToString("X4");
        }
    }

    /// <summary>
    /// The base class of the Attribute translator for Tag.
    /// TagAttributeTranslator converts an attribute from OrigAttrName="OrigAttrValue" to NewAttrName="NewAttrValue".
    /// AttrTrait is currently used as the bit mask when NewAttrValue needs to be in the bit field representation.
    /// </summary>
    abstract internal class TagAttributeTranslator
    {
        internal enum State
        {
            NotInitialized = -1,
        }

        protected int indexOfAttr;
        protected string strAttrName;
        protected string strAttrValue;
        protected string[] arrayOfOrigAttrNames;
        protected string[] arrayOfNewAttrNames;
        protected string[] arrayOfOrigAttrValues;
        protected string[] arrayOfNewAttrValues;
        protected long[] arrayOfAttrTraits;
        protected AttributeFormatter formatter;

        internal TagAttributeTranslator()
        {
            this.indexOfAttr = (int)State.NotInitialized;
            this.strAttrName = null;
            this.strAttrValue = null;
        }

        /// <summary>
        /// Set LocalName and Value.
        /// </summary>
        /// <param name="strLocalName"></param>
        /// <param name="strValue"></param>
        internal void SetLocalNameAndValue(string strLocalName, string strValue)
        {
            this.indexOfAttr = (int)State.NotInitialized;
            this.strAttrName = strLocalName;
            this.strAttrValue = strValue;
        }

        /// <summary>
        /// Get the index to specify the attribute name to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected int GetIndexByAttributeName()
        {
            int index = (int)State.NotInitialized;

            for (int count = 0; count < arrayOfOrigAttrNames.Length; count++)
            {
                if (arrayOfOrigAttrNames[count] == this.strAttrName)
                {
                    index = count;
                    break;
                }
            }

            return index;
        }

        /// <summary>
        /// Get the index to specify the value to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected int GetIndexByValue()
        {
            int index = (int)State.NotInitialized;

            for (int count = 0; count < arrayOfOrigAttrValues.Length; count++)
            {
                if (arrayOfOrigAttrValues[count] == this.strAttrValue)
                {
                    index = count;
                    break;
                }
            }

            return index;
        }

        /// <summary>
        /// Set the index.
        /// </summary>
        /// <returns>The index</returns>
        abstract protected int SetIndex();

        /// <summary>
        /// Get the Index
        /// </summary>
        /// <returns>The index</returns>
        internal virtual int Index
        {
            get
            {
                if (this.indexOfAttr == (int)State.NotInitialized)
                {
                    this.indexOfAttr = this.SetIndex();
                }

                return this.indexOfAttr;
            }
        }

        /// <summary>
        /// Get the LocalName
        /// </summary>
        /// <returns>The LocalName</returns>
        internal virtual string LocalName
        {
            get { return (this.Index == (int)State.NotInitialized) ? this.strAttrName : this.arrayOfNewAttrNames[this.Index]; }
        }

        /// <summary>
        /// Get the Value
        /// </summary>
        /// <returns>The value</returns>
        internal virtual string Value
        {
            get { return (this.Index == (int)State.NotInitialized) ? this.strAttrValue : this.arrayOfNewAttrValues[this.Index]; }
        }

        /// <summary>
        /// Get the Trait.
        /// </summary>
        /// <returns>The Trait</returns>
        internal virtual long Trait
        {
            get { return (this.Index == (int)State.NotInitialized) ? 0 : this.arrayOfAttrTraits[this.Index]; }
        }

        /// <summary>
        /// Get the formatter.
        /// </summary>
        internal virtual AttributeFormatter Formatter
        {
            get { return this.formatter; }
        }
    }

    internal class DocumentTagAttributeTranslator : TagAttributeTranslator
    {
        private static string[] arrayOfOrigTagAttrNames = { "conformance" };
        private static string[] arrayOfNewTagAttrNames = { "conformance" };
        private static string[] arrayOfOrigTagAttrValues = { "strict" };
        private static string[] arrayOfNewTagAttrValues = { "" }; // Must be "".
        private static long[] arrayOfTagAttrTraits = { 0 };

        internal DocumentTagAttributeTranslator()
        {
            arrayOfOrigAttrNames = arrayOfOrigTagAttrNames;
            arrayOfNewAttrNames = arrayOfNewTagAttrNames;
            arrayOfOrigAttrValues = arrayOfOrigTagAttrValues;
            arrayOfNewAttrValues = arrayOfNewTagAttrValues;
            arrayOfAttrTraits = arrayOfTagAttrTraits;
            formatter = null;
        }

        /// <summary>
        /// Set the index to specify the value to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected override int SetIndex()
        {
            return this.GetIndexByValue();
        }
    }

    internal class CnfStyleTagAttributeTranslator : TagAttributeTranslator
    {
        private static string[] arrayOfOrigTagAttrNames = { "firstRow", "lastRow", "firstColumn", "lastColumn", "oddVBand", "evenVBand", "oddHBand", "evenHBand", "firstRowLastColumn", "firstRowFirstColumn", "lastRowFirstColumn", "lastRowLastColumn" };
        private static string[] arrayOfNewTagAttrNames = { "val", "val", "val", "val", "val", "val", "val", "val", "val", "val", "val", "val" };
        private static long[] arrayOfTagAttrTraits = { 0x800, 0x400, 0x200, 0x100, 0x080, 0x040, 0x020, 0x010, 0x008, 0x004, 0x002, 0x001 };

        internal CnfStyleTagAttributeTranslator()
        {
            arrayOfNewAttrNames = arrayOfNewTagAttrNames;
            arrayOfOrigAttrNames = arrayOfOrigTagAttrNames;
            arrayOfOrigAttrValues = null;
            arrayOfNewAttrValues = null;
            arrayOfAttrTraits = arrayOfTagAttrTraits;
            formatter = new BinAttributeFormatter(arrayOfTagAttrTraits.Length);
        }

        /// <summary>
        /// Set the index to specify the attribute name to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected override int SetIndex()
        {
            return this.GetIndexByAttributeName();
        }

        /// <summary>
        /// Get the attribute value.
        /// </summary>
        /// <returns>The attribute value</returns>
        internal override string Value
        {
            get { return this.strAttrValue; }
        }
    }

    internal class TblLookTagAttributeTranslator : TagAttributeTranslator
    {
        private static string[] arrayOfOrigTagAttrNames = { "firstRow", "lastRow", "firstColumn", "lastColumn", "noHBand", "noVBand" };
        private static string[] arrayOfNewTagAttrNames = { "val", "val", "val", "val", "val", "val" };
        private static long[] arrayOfTagAttrTraits = { 0x0020, 0x0040, 0x0080, 0x0100, 0x0200, 0x0400 };

        internal TblLookTagAttributeTranslator()
        {
            arrayOfOrigAttrNames = arrayOfOrigTagAttrNames;
            arrayOfNewAttrNames = arrayOfNewTagAttrNames;
            arrayOfOrigAttrValues = null;
            arrayOfNewAttrValues = null;
            arrayOfAttrTraits = arrayOfTagAttrTraits;
            formatter = new HexAttributeFormatter(arrayOfTagAttrTraits.Length);
        }

        /// <summary>
        /// Set the index to specify the attribute name to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected override int SetIndex()
        {
            return this.GetIndexByAttributeName();
        }

        /// <summary>
        /// Get the attribute value.
        /// </summary>
        /// <returns>The attribute value</returns>
        internal override string Value
        {
            get { return this.strAttrValue; }
        }
    }

    internal class IndTagAttributeTranslator : TagAttributeTranslator
    {
        private static string[] arrayOfOrigTagAttrNames = { "left", "leftChars", "right", "rightChars" };
        private static string[] arrayOfNewTagAttrNames = { "start", "startChars", "end", "endChars" };
        private static long[] arrayOfTagAttrTraits = { 0, 0, 0, 0 };

        internal IndTagAttributeTranslator()
        {
            arrayOfOrigAttrNames = arrayOfOrigTagAttrNames;
            arrayOfNewAttrNames = arrayOfNewTagAttrNames;
            arrayOfOrigAttrValues = null;
            arrayOfNewAttrValues = null;
            arrayOfAttrTraits = arrayOfTagAttrTraits;
            formatter = null;
        }

        /// <summary>
        /// Set the index to specify the attribte name to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected override int SetIndex()
        {
            return this.GetIndexByAttributeName();
        }

        /// <summary>
        /// Get the attribute value.
        /// </summary>
        /// <returns>The attribute value</returns>
        internal override string Value
        {
            get { return this.strAttrValue; }
        }
    }

    internal class JcTabTagAttributeTranslator : TagAttributeTranslator
    {
        private static string[] arrayOfOrigTagAttrNames = { "val", "val" };
        private static string[] arrayOfNewTagAttrNames = { "val", "val" };
        private static string[] arrayOfOrigTagAttrValues = { "start", "end" };
        private static string[] arrayOfNewTagAttrValues = { "left", "right" };
        private static long[] arrayOfTagAttrTraits = { 0, 0 };

        internal JcTabTagAttributeTranslator()
        {
            arrayOfOrigAttrNames = arrayOfOrigTagAttrNames;
            arrayOfNewAttrNames = arrayOfNewTagAttrNames;
            arrayOfOrigAttrValues = arrayOfOrigTagAttrValues;
            arrayOfNewAttrValues = arrayOfNewTagAttrValues;
            arrayOfAttrTraits = arrayOfTagAttrTraits;
            formatter = null;
        }

        /// <summary>
        /// Set the index to specify the value to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected override int SetIndex()
        {
            return this.GetIndexByValue();
        }
    }

    internal class StylePaneSortMethodTagAttributeTranslator : TagAttributeTranslator
    {
        private static string[] arrayOfOrigTagAttrNames = { "val", "val", "val", "val", "val", "val" };
        private static string[] arrayOfNewTagAttrNames = { "val", "val", "val", "val", "val", "val" };
        private static string[] arrayOfOrigTagAttrValues = { "name", "priority", "default", "font", "basedOn", "type" };
        private static string[] arrayOfNewTagAttrValues = { "0000", "0001", "0002", "0003", "0004", "0005" };
        private static long[] arrayOfTagAttrTraits = { 0, 0, 0, 0, 0, 0 };


        internal StylePaneSortMethodTagAttributeTranslator()
        {
            arrayOfOrigAttrNames = arrayOfOrigTagAttrNames;
            arrayOfNewAttrNames = arrayOfNewTagAttrNames;
            arrayOfOrigAttrValues = arrayOfOrigTagAttrValues;
            arrayOfNewAttrValues = arrayOfNewTagAttrValues;
            arrayOfAttrTraits = arrayOfTagAttrTraits;
            formatter = null;
        }

        /// <summary>
        /// Set the index to specify the value to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected override int SetIndex()
        {
            return this.GetIndexByValue();
        }
    }
    
    internal class TextDirectionTagAttributeTranslator : TagAttributeTranslator
    {
        private static string[] arrayOfOrigTagAttrNames = { "val", "val", "val", "val", "val", "val" };
        private static string[] arrayOfNewTagAttrNames = { "val", "val", "val", "val", "val", "val" };
        private static string[] arrayOfOrigTagAttrValues = { "lr", "tb", "tbV", "lrV", "rl", "rlV" };
        private static string[] arrayOfNewTagAttrValues = { "btLr", "lrTb", "lrTbV", "tbLrV", "tbRl", "tbRlV" };
        private static long[] arrayOfTagAttrTraits = { 0, 0, 0, 0, 0, 0 };

        internal TextDirectionTagAttributeTranslator()
        {
            arrayOfOrigAttrNames = arrayOfOrigTagAttrNames;
            arrayOfNewAttrNames = arrayOfNewTagAttrNames;
            arrayOfOrigAttrValues = arrayOfOrigTagAttrValues;
            arrayOfNewAttrValues = arrayOfNewTagAttrValues;
            arrayOfAttrTraits = arrayOfTagAttrTraits;
            formatter = null;
        }

        /// <summary>
        /// Set the index to specify the value to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected override int SetIndex()
        {
            return this.GetIndexByValue();
        }
    }

    /// <summary>
    /// Translate Strict attributes to Transitional
    /// </summary>
    internal static class AttributeTranslator
    {
        private static TagAttributeTranslator translator;
        private static Dictionary<string, TagAttributeTranslator> dicOfTranslators = null;

        private static Dictionary<string, TagAttributeTranslator> DicOfTranslators
        {
            get
            {
                if (dicOfTranslators == null)
                {
                    dicOfTranslators = new Dictionary<string, TagAttributeTranslator>();

                    // Add all the tags we handle.
                    dicOfTranslators["document"] = null;
                    dicOfTranslators["cnfStyle"] = null;
                    dicOfTranslators["tblLook"] = null;
                    dicOfTranslators["ind"] = null;
                    dicOfTranslators["tab"] = null; // "tab" and "jc"
                    dicOfTranslators["stylePaneSortMethod"] = null;
                    dicOfTranslators["textDirection"] = null;
                }

                return dicOfTranslators;
            }
        }

        /// <summary>
        /// Translate Strict attribute to Transitional
        /// </summary>
        /// <param name="strTag"></param>
        /// <param name="strLocalName"></param>
        /// <param name="strValue"></param>
        /// <returns>The translator</returns>
        internal static TagAttributeTranslator Translate(string strTag, string strLocalName, string strValue)
        {
            translator = null;

            if (strTag != null && strLocalName != null && strValue != null)
            {
                try
                {
                    if (DicOfTranslators.ContainsKey(strTag))
                    {
                        translator = DicOfTranslators[strTag];

                        if (translator == null)
                        {
                            switch (strTag)
                            {
                                case "document":
                                    translator = new DocumentTagAttributeTranslator();
                                    break;

                                case "cnfStyle":
                                    translator = new CnfStyleTagAttributeTranslator();
                                    break;

                                case "tblLook":
                                    translator = new TblLookTagAttributeTranslator();
                                    break;

                                case "ind":
                                    translator = new IndTagAttributeTranslator();
                                    break;

                                case "jc": // falls through...
                                case "tab":
                                    translator = new JcTabTagAttributeTranslator();
                                    break;

                                case "stylePaneSortMethod":
                                    translator = new StylePaneSortMethodTagAttributeTranslator();
                                    break;

                                case "textDirection":
                                    translator = new TextDirectionTagAttributeTranslator();
                                    break;

                                default:
                                    break;
                            }

                            Debug.Assert(translator != null, "AttributeTranslator.Translate() can't initialize a translator.");

                            DicOfTranslators[strTag] = translator;
                        }
                    }

                    if (translator != null)
                    {
                        translator.SetLocalNameAndValue(strLocalName, strValue);

                        if (translator.Index == (int)TagAttributeTranslator.State.NotInitialized)
                        {
                            translator = null;
                        }
                    }
                }
                catch
                {
                    Debug.Assert(true, "AttributeTranslator.Translate() failed.");

                    translator = null;
                }
            }

            return translator;
        }
    }
}
