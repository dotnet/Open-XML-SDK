// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Xml;
using System.IO;
using System.Diagnostics;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the XmlConvertingReaderFactory.
    /// </summary>
    internal static class XmlConvertingReaderFactory
    {
        // When the strictTranslation flag is 'true', the XmlConvertingReader tries to search the incoming xml stream for any Strict namespace
        // that can be translated to Transitional. When the flag is 'false', the reader skips searching.

        public static XmlReader Create(XmlReader xmlReader, bool strictTranslation)
        {
            return new XmlConvertingReader(xmlReader, strictTranslation);
        }

        public static XmlReader Create(Stream partStream, XmlReaderSettings settings)
        {
            return XmlConvertingReaderFactory.Create(partStream, settings, true);
        }

        public static XmlReader Create(Stream partStream, XmlReaderSettings settings, bool strictTranslation)
        {
            XmlReader xmlReader = XmlReader.Create(partStream, settings);

            return new XmlConvertingReader(xmlReader, strictTranslation);
        }

        public static XmlReader Create(TextReader textReader, XmlReaderSettings settings)
        {
            return XmlConvertingReaderFactory.Create(textReader, settings, true);
        }

        public static XmlReader Create(TextReader textReader, XmlReaderSettings settings, bool strictTranslation)
        {
            XmlReader xmlReader = XmlReader.Create(textReader, settings);

            return new XmlConvertingReader(xmlReader, strictTranslation);
        }

        public static XmlReader Create(TextReader textReader)
        {
            return XmlConvertingReaderFactory.Create(textReader, true);
        }

        public static XmlReader Create(TextReader textReader, bool strictTranslation)
        {
            XmlReader xmlReader = XmlReader.Create(textReader);

            return new XmlConvertingReader(xmlReader, strictTranslation);
        }
    }

    /// <summary>
    /// Defines the XmlConvertingReader - This XmlReader tries to replace the Strict namespaces with equivalent Transitional namespaces.
    /// </summary>
    internal class XmlConvertingReader : XmlReader
    {
        // The xmlReader obtained from the Package class.
        protected XmlReader BaseReader { get; set; }
        private bool _strictTranslation { get; set; }

        /// <summary>
        /// XmlConvertingReader
        /// </summary>
        /// <param name="baseReader">XmlReader</param>
        /// <param name="strictTranslation">bool</param>
        /// <returns></returns>
        internal XmlConvertingReader(XmlReader baseReader, bool strictTranslation)
        {
            if (baseReader == null)
            {
                throw new ArgumentNullException("baseReader");
            }

            this._strictTranslation = strictTranslation;
            this.BaseReader = baseReader;
        }

        /// <summary>
        /// Return true if strictTranslation is enabled.
        /// </summary>
        internal bool StrictTranslation
        {
            get { return this._strictTranslation; }
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override void Close()
        {
            this.BaseReader.Close();
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (this.ReadState != ReadState.Closed)
            {
                this.Close();
            }

            ((IDisposable)this.BaseReader).Dispose();
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override bool Read()
        {
            return this.BaseReader.Read();
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override string GetAttribute(int index)
        {
            return this.BaseReader.GetAttribute(index);
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override string GetAttribute(string name)
        {
            return this.BaseReader.GetAttribute(name);
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override string GetAttribute(string localName, string namespaceURI)
        {
            return this.BaseReader.GetAttribute(localName, namespaceURI);
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override string LookupNamespace(string prefix)
        {
            return this.BaseReader.LookupNamespace(prefix);
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override void MoveToAttribute(int index)
        {
            this.BaseReader.MoveToAttribute(index);
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override bool MoveToAttribute(string name)
        {
            return this.BaseReader.MoveToAttribute(name);
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override bool MoveToAttribute(string localName, string namespaceURI)
        {
            return this.BaseReader.MoveToAttribute(localName, namespaceURI);
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override bool MoveToElement()
        {
            return this.BaseReader.MoveToElement();
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override bool MoveToFirstAttribute()
        {
            return this.BaseReader.MoveToFirstAttribute();
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override bool MoveToNextAttribute()
        {
            return this.BaseReader.MoveToNextAttribute();
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override bool ReadAttributeValue()
        {
            return this.BaseReader.ReadAttributeValue();
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override void ResolveEntity()
        {
            this.BaseReader.ResolveEntity();
        }

        /// <summary>
        /// Override the method defined in XmlReader
        /// </summary>
        public override int ReadValueChunk(char[] buffer, int index, int count)
        {
            return this.BaseReader.ReadValueChunk(buffer, index, count);
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override int AttributeCount
        {
            get
            {
                return this.BaseReader.AttributeCount;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string BaseURI
        {
            get
            {
                return this.BaseReader.BaseURI;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override bool CanReadBinaryContent
        {
            get
            {
                return this.BaseReader.CanReadBinaryContent;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override bool CanReadValueChunk
        {
            get
            {
                return this.BaseReader.CanReadValueChunk;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override bool CanResolveEntity 
        {
            get
            {
                return this.BaseReader.CanResolveEntity;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override int Depth
        {
            get
            {
                return this.BaseReader.Depth;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override bool EOF
        {
            get
            {
                return this.BaseReader.EOF;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override bool HasValue
        {
            get
            {
                return this.BaseReader.HasValue;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override bool IsDefault
        {
            get
            {
                return this.BaseReader.IsDefault;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override bool IsEmptyElement
        {
            get
            {
                return this.BaseReader.IsEmptyElement;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string this[int index]
        {
            get
            {
                return this.BaseReader[index];
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string this[string name]
        {
            get
            {
                return this.BaseReader[name];
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string this[string name, string namespaceURI]
        {
            get
            {
                return this.BaseReader[name, namespaceURI];
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string LocalName
        {
            get
            {
                return this.BaseReader.LocalName;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string Name
        {
            get
            {
                return this.BaseReader.Name;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string NamespaceURI
        {
            get
            {
                string uri = this.BaseReader.NamespaceURI;
                string translatedNamespace;
                bool found;

                if (this._strictTranslation)
                {
                    found = NamespaceIdMap.TryGetTransitionalNamespace(uri, out translatedNamespace);
                }
                else
                {
                    found = NamespaceIdMap.TryGetExtendedNamespace(uri, out translatedNamespace);
                }

                if (found)
                {
                    uri = translatedNamespace;
                }
                
                return uri;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override XmlNameTable NameTable
        {
            get
            {
                return this.BaseReader.NameTable;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override XmlNodeType NodeType
        {
            get
            {
                return this.BaseReader.NodeType;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string Prefix
        {
            get
            {
                return this.BaseReader.Prefix;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override char QuoteChar
        {
            get
            {
                return this.BaseReader.QuoteChar;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override ReadState ReadState
        {
            get
            {
                return this.BaseReader.ReadState;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string Value
        {
            get
            {
                string textValue = this.BaseReader.Value;

                if (this.BaseReader.NodeType == XmlNodeType.Attribute)
                {
                    bool found;
                    string translatedNamespace;

                    if (this._strictTranslation)
                    {
                        found = NamespaceIdMap.TryGetTransitionalNamespace(textValue, out translatedNamespace);
                    }
                    else
                    {
                        found = NamespaceIdMap.TryGetExtendedNamespace(textValue, out translatedNamespace);
                    }

                    if (found)
                    {
                        textValue = translatedNamespace;
                    }
                }

                return textValue;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override string XmlLang
        {
            get
            {
                return this.BaseReader.XmlLang;
            }
        }

        /// <summary>
        /// Override the property defined in XmlReader
        /// </summary>
        public override XmlSpace XmlSpace
        {
            get
            {
                return this.BaseReader.XmlSpace;
            }
        }
    }

    /// <summary>
    /// Represents the Open XML reader class.
    /// </summary>
    public abstract class OpenXmlReader : IDisposable
    {
        private bool _disposed;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool _readMiscNodes;

        /// <summary>
        /// Initializes a new instance of the OpenXmlReader class.
        /// </summary>
        protected OpenXmlReader()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlReader class using the supplied Boolean value.
        /// </summary>
        /// <param name="readMiscNodes">Specify false to indicate to the reader to skip all miscellaneous nodes. The default value is false.</param>
        protected OpenXmlReader(bool readMiscNodes)
        {
            this._readMiscNodes = readMiscNodes;
        }

        /// <summary>
        /// Creates an OpenXmlReader from the specified OpenXmlPart.
        /// </summary>
        /// <param name="openXmlPart">The OpenXmlPart to read.</param>
        /// <returns>The newly created OpenXmlReader.</returns>
        public static OpenXmlReader Create(OpenXmlPart openXmlPart)
        {
            return new OpenXmlPartReader(openXmlPart);
        }

        /// <summary>
        /// Creates an OpenXmlReader from the specified OpenXmlPart and Boolean values.
        /// </summary>
        /// <param name="openXmlPart">The OpenXmlPart to read.</param>
        /// <param name="readMiscNodes">Specify false to indicate to the reader to skip all miscellaneous nodes. The default value is false.</param>
        /// <returns>The newly created OpenXmlReader.</returns>
        public static OpenXmlReader Create(OpenXmlPart openXmlPart, bool readMiscNodes)
        {
            return new OpenXmlPartReader(openXmlPart, readMiscNodes);
        }

        /// <summary>
        /// Creates an OpenXmlReader from the specified part stream.
        /// </summary>
        /// <param name="partStream">The part stream.</param>
        /// <returns></returns>
        public static OpenXmlReader Create(Stream partStream)
        {
            return new OpenXmlPartReader(partStream);
        }

        /// <summary>
        /// Creates an OpenXmlReader from the specified part stream and Boolean values.
        /// </summary>
        /// <param name="partStream">The part stream.</param>
        /// <param name="readMiscNodes">Specify false to indicate to the reader to skip all miscellaneous nodes. The default value is false.</param>
        /// <returns></returns>
        public static OpenXmlReader Create(Stream partStream, bool readMiscNodes)
        {
            return new OpenXmlPartReader(partStream, readMiscNodes);
        }

        /// <summary>
        /// Creates an OpenXmlReader from the OpenXmlElement (travel the DOM tree).
        /// </summary>
        /// <param name="openXmlElement">The OpenXmlElement to read.</param>
        /// <returns>The newly created OpenXmlReader.</returns>
        public static OpenXmlReader Create(OpenXmlElement openXmlElement)
        {
            return new OpenXmlDomReader(openXmlElement);
        }

        /// <summary>
        /// Creates an OpenXmlReader from the OpenXmlElement (travel the DOM tree).
        /// </summary>
        /// <param name="openXmlElement">The OpenXmlElement to read.</param>
        /// <param name="readMiscNodes">Specify false to indicate to the reader to skip all miscellaneous nodes. The default value is false.</param>
        /// <returns>The newly created OpenXmlReader.</returns>
        public static OpenXmlReader Create(OpenXmlElement openXmlElement, bool readMiscNodes)
        {
            return new OpenXmlDomReader(openXmlElement, readMiscNodes);
        }

        /// <summary>
        /// Gets a value that indicates whether the OpenXmlReader will read or skip all miscellaneous nodes.
        /// </summary>
        public bool ReadMiscNodes
        {
            get
            {
                ThrowIfObjectDisposed();
                return this._readMiscNodes;
            }
        }

        /// <summary>
        /// Gets the encoding of the XML file.
        /// </summary>
        /// <remarks>
        /// Returns null if the encoding is not specified in the XML file.
        /// </remarks>
        public virtual string Encoding
        {
            get
            {
                ThrowIfObjectDisposed();
                // default XML encoding is UTF8
                return null;
            }
        }

        /// <summary>
        /// Gets the standalone property in the XML declaration of the XML stream. The default value is null.
        /// </summary>
        public virtual bool? StandaloneXml
        {
            get
            {
                ThrowIfObjectDisposed();
                return null;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the current node has any attributes. 
        /// </summary>
        public virtual bool HasAttributes 
        {
            get 
            {
                ThrowIfObjectDisposed();
                return this.Attributes.Count > 0;
            }
        }

        /// <summary>
        /// Gets the list of attributes of the current element.
        /// </summary>
        public abstract ReadOnlyCollection<OpenXmlAttribute> Attributes
        {
            get; 
        }

        /// <summary>
        /// Gets the namespace declarations of the current element.
        /// </summary>
        public abstract IEnumerable<KeyValuePair<string, string>> NamespaceDeclarations { get; }

        /// <summary>
        /// Gets the type of the corresponding strongly typed class of the current element.
        /// </summary>
        public abstract Type ElementType
        {
            get;
        }

        ///// <summary>
        ///// When overridden in a derived class, gets a value indicating whether the current node is an empty element (for example, <MyElement/>). 
        ///// </summary>
        //public abstract bool IsEmptyElement { get; }

        /// <summary>
        /// When overridden in a derived class, gets a value that indicates whether the current node is a miscellaneous XML node (non element). 
        /// </summary>
        /// <remarks>IsStartElement and IsEndElement will be false when IsMiscNode==true.</remarks>
        public abstract bool IsMiscNode
        {
            get;
        }

        /// <summary>
        /// When overridden in a derived class, gets a value that indicates whether the current node is an element start. 
        /// </summary>
        /// <remarks>IsStartElement and IsEndElement will be false when IsMiscNode==true.</remarks>
        public abstract bool IsStartElement
        {
            get;
        }

        /// <summary>
        /// When overridden in a derived class, gets a value that indicates whether the current node is an element end. 
        /// </summary>
        /// <remarks>IsStartElement and IsEndElement will be false when IsMiscNode==true.</remarks>
        public abstract bool IsEndElement
        {
            get;
        }

        /// <summary>
        /// Gets the depth of the current node in the XML document. The depth of the root element is 0.
        /// </summary>
        public abstract int Depth
        {
            get;
        }

        /// <summary>
        /// When overridden in a derived class, gets a value that indicates whether the reader is positioned at the end of the stream. 
        /// </summary>
        public abstract bool EOF
        {
            get;
        }

        /// <summary>
        /// When overridden in a derived class, gets the local name of the current node. 
        /// </summary>
        public abstract string LocalName { get; }

        /// <summary>
        /// When overridden in a derived class, gets the namespace URI (as defined in the W3C Namespace specification) of the node on which the reader is positioned. 
        /// </summary>
        public abstract string NamespaceUri { get; }

        ///// <summary>
        ///// When overridden in a derived class, gets the qualified name of the current node. 
        ///// </summary>
        //public virtual string Name { get; }

        /// <summary>
        /// When overridden in a derived class, gets the namespace prefix associated with the current node. 
        /// </summary>
        public abstract string Prefix { get; }

        /// <summary>
        /// Moves to read the next element.
        /// </summary>
        /// <returns>Returns true if the next element was read successfully; false if there are no more elements to read. </returns>
        public abstract bool Read();

        /// <summary>
        /// Moves to read the first child element.
        /// </summary>
        /// <returns>Returns true if the first child element was read successfully; false if there are no child elements to read. </returns>
        /// <remarks>This method can only be called on element start. At the current node, the reader will move to the end tag if there is no child element.</remarks>
        public abstract bool ReadFirstChild();

        /// <summary>
        /// Moves to read the next sibling element.
        /// </summary>
        /// <returns>Returns true if the next sibling element was read successfully; false if there are no more sibling elements to read. </returns>
        /// <remarks>At the current node, the reader will move to the end tag of the parent node if there are no more sibling elements.</remarks>
        public abstract bool ReadNextSibling();

        /// <summary>
        /// Skips the child elements of the current node. 
        /// </summary>
        public abstract void Skip();

        /// <summary>
        /// Loads the element at current cursor.
        /// </summary>
        /// <returns>The OpenXmlElement that was loaded.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the current is the end element.</exception>
        /// <remarks>The new current element is the end of the element after LoadCurrentElement().</remarks>
        public abstract OpenXmlElement LoadCurrentElement();

        /// <summary>
        /// Gets the text of the element if the element is an OpenXmlLeafTextElement. Returns String.Empty for other elements.
        /// </summary>
        /// <returns>
        /// The text of the element if the element is an OpenXmlLeafTextElement. Returns String.Empty for other elements.
        /// </returns>
        public abstract string GetText();

        /// <summary>
        /// Closes the reader.
        /// </summary>
        public abstract void Close( );

        #region dispose related methods

        /// <summary>
        /// Thrown if the object is disposed.
        /// </summary>
        protected virtual void ThrowIfObjectDisposed()
        {
            if (this._disposed)
            {
                throw new ObjectDisposedException(base.GetType().Name);
            }
        }

        /// <summary>
        /// Closes the reader, and releases all resources. 
        /// </summary>
        /// <param name="disposing">Specify true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    this.Close();
                }
                this._disposed = true;
            }
        }

        #endregion


        #region IDisposable Members

        /// <summary>
        /// Closes the reader, and releases all resources. 
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    internal enum ElementState
    {
        Null,
        Start,
        End,
        LeafStart,
        LeafEnd,
        LoadEnd,
        MiscNode,
        EOF
    }


    /// <summary>
    /// Represents the Open XML part reader class.
    /// </summary>
    public class OpenXmlPartReader : OpenXmlReader
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ReadOnlyCollection<OpenXmlAttribute> _emptyReadOnlyList;

        private OpenXmlElementContext _elementContext;
        private XmlReader _xmlReader;
        private IList<OpenXmlAttribute> _attributeList;
        private IList<KeyValuePair<string, string>> _nsDecls;
        private Stack<OpenXmlElement> _elementStack;
        private ElementState _elementState;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _encoding ;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool? _standalone;

        private OpenXmlPartReader()
        {
            this._attributeList = new List<OpenXmlAttribute>();
            this._nsDecls = new List<KeyValuePair<string, string>>();
            this._elementStack = new Stack<OpenXmlElement>();
            this._elementContext = new OpenXmlElementContext();
            this._elementState = ElementState.Null;
        }

        private OpenXmlPartReader(bool readMiscNodes)
            : base ( readMiscNodes )
        {
            this._attributeList = new List<OpenXmlAttribute>();
            this._nsDecls = new List<KeyValuePair<string, string>>();
            this._elementStack = new Stack<OpenXmlElement>();
            this._elementContext = new OpenXmlElementContext();
            this._elementState = ElementState.Null;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartReader class using the supplied OpenXmlPart class.
        /// </summary>
        /// <param name="openXmlPart">The OpenXmlPart to read.</param>
        public OpenXmlPartReader(OpenXmlPart openXmlPart) : this()
        {
            if (openXmlPart == null)
            {
                throw new ArgumentNullException("openXmlPart");
            }
            Stream partStream = openXmlPart.GetStream(FileMode.Open);
            // set MaxCharactersInDocument to limit the part size on loading DOM.
            this._elementContext.XmlReaderSettings.MaxCharactersInDocument = openXmlPart.MaxCharactersInPart;
            this.Init(partStream, /*closeInput*/true);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartReader class using the supplied OpenXmlPart and Boolean values.
        /// </summary>
        /// <param name="openXmlPart">The OpenXmlPart to read.</param>
        /// <param name="readMiscNodes">Specify false to indicate to the reader to skip all miscellaneous nodes. The default value is false.</param>
        public OpenXmlPartReader(OpenXmlPart openXmlPart, bool readMiscNodes)
            : this(readMiscNodes)
        {
            if (openXmlPart == null)
            {
                throw new ArgumentNullException("openXmlPart");
            }
            // set MaxCharactersInDocument to limit the part size on loading DOM.
            this._elementContext.XmlReaderSettings.MaxCharactersInDocument = openXmlPart.MaxCharactersInPart;
            Stream partStream = openXmlPart.GetStream(FileMode.Open);
            this.Init(partStream, /*closeInput*/true);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartReader class using the supplied stream.
        /// </summary>
        /// <param name="partStream">The part stream of the OpenXmlPart to read.</param>
        public OpenXmlPartReader(Stream partStream) : this()
        {
            if (partStream == null)
            {
                throw new ArgumentNullException("partStream");
            }

            // we don't know the MaxCharactersInPart if only a stream is passed in.
            this.Init(partStream, /*closeInput*/false);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartReader class using the supplied stream and Boolean values.
        /// </summary>
        /// <param name="partStream">The part stream of the OpenXmlPart to read.</param>
        /// <param name="readMiscNodes">Specify false to indicate to the reader to skip all miscellaneous nodes. The default value is false.</param>
        public OpenXmlPartReader(Stream partStream, bool readMiscNodes)
            : this(readMiscNodes)
        {
            if (partStream == null)
            {
                throw new ArgumentNullException("partStream");
            }
            // we don't know the MaxCharactersInPart if only a stream is passed in.
            this.Init(partStream, /*closeInput*/false);
        }

        /// <summary>
        /// Gets the encoding of the XML file.
        /// </summary>
        /// <remarks>
        /// Returns null if encoding is not specified in the XML file.
        /// </remarks>
        public override string Encoding
        {
            get
            {
                ThrowIfObjectDisposed();
                return this._encoding;
            }
        }

        /// <summary>
        /// Gets the standalone property of the XML file. Returns false if there is no "standalone" in the XML declaration stream.
        /// </summary>
        public override bool? StandaloneXml
        {
            get
            {
                ThrowIfObjectDisposed();
                // default is true for standalone
                // <?xml version="1.0" encoding="UTF-8" standalone="yes"?>
                return this._standalone;
            }
        }

        /// <summary>
        /// Gets the list of attributes of the current element.
        /// </summary>
        public override ReadOnlyCollection<OpenXmlAttribute> Attributes
        {
            get {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();

                if (this._elementState == ElementState.Start ||
                    this._elementState == ElementState.LeafStart)
                {
                    Debug.Assert(this._elementStack.Count > 0);

                    return new ReadOnlyCollection<OpenXmlAttribute>(_attributeList);
                }
                else
                {
                    if (_emptyReadOnlyList == null)
                    {
                        _emptyReadOnlyList = new ReadOnlyCollection<OpenXmlAttribute>(new List<OpenXmlAttribute>());
                    }
                    return _emptyReadOnlyList;
                } 
            }
        }

        /// <summary>
        /// Gets the namespace declarations of the current element.
        /// </summary>
        public override IEnumerable<KeyValuePair<string, string>> NamespaceDeclarations
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();

                if (this._elementState == ElementState.Start ||
                    this._elementState == ElementState.LeafStart)
                {
                    Debug.Assert(this._elementStack.Count > 0);

                    return _nsDecls;
                }
                else
                {
                    return EmptyEnumerable<KeyValuePair<string, string>>.EmptyEnumerableSingleton;
                } 
            }
        }

        /// <summary>
        /// Gets the type of the corresponding strong typed class of the current element.
        /// </summary>
        public override Type ElementType
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();

                return this._elementStack.Peek().GetType();
            }
        }

        ///// <summary>
        ///// When overridden in a derived class, gets a value indicating whether the current node is an empty element (for example, <MyElement/>). 
        ///// </summary>
        //public override bool IsEmptyElement
        //{
        //    get { return this._xmlReader.IsEmptyElement; }
        //}

        /// <summary>
        /// Gets a value that indicates whether the current node is a miscellaneous XML node (non element). 
        /// </summary>
        /// <remarks>IsStartElement and IsEndElement will be false when IsMiscNode==true.</remarks>
        public override bool IsMiscNode
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();

                if (this._elementState == ElementState.MiscNode)
                {
                    Debug.Assert(this.ElementType == typeof(OpenXmlMiscNode));
                    return true;
                }
                else
                {
                }
                return false;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the current node is an element start. 
        /// </summary>
        /// <remarks>IsStartElement and IsEndElement will be false when IsMiscNode==true.</remarks>
        public override bool IsStartElement
        {
            get            
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();

                if (!this.IsMiscNode)
                {
                    if (this._elementState == ElementState.Start || this._elementState == ElementState.LeafStart)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the current node is an element end. 
        /// </summary>
        /// <remarks>IsStartElement and IsEndElement will be false when IsMiscNode==true.</remarks>
        public override bool IsEndElement
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();

                if (!this.IsMiscNode)
                {
                    if (this._elementState == ElementState.End || this._elementState == ElementState.LeafEnd
                        || this._elementState == ElementState.LoadEnd )
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Gets the depth of the current node in the XML document. The depth of the root element is 0.
        /// </summary>
        public override int Depth
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();


                Debug.Assert(this._elementStack.Count > 0);
                return this._elementStack.Count - 1;  // depth of root element is 0
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the reader is positioned at the end of the stream. 
        /// </summary>
        public override bool EOF
        {
            get
            {
                ThrowIfObjectDisposed();
                //Debug.Assert(this._elementStack.Count == 0);

                return this._elementState == ElementState.EOF;
            }
        }

        /// <summary>
        /// Gets the local name of the current node. 
        /// </summary>
        public override string LocalName
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();
                return this._elementStack.Peek().LocalName;
            }
        }

        /// <summary>
        /// Gets the namespace URI (as defined in the W3C Namespace specification) of the node on which the reader is positioned. 
        /// </summary>
        public override string NamespaceUri
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();
                return this._elementStack.Peek().NamespaceUri;
            }
        }

        ///// <summary>
        ///// When overridden in a derived class, gets the qualified name of the current node. 
        ///// </summary>
        //public virtual string Name { get; }

        /// <summary>
        /// Gets the namespace prefix associated with the current node. 
        /// </summary>
        public override string Prefix
        {
            get
            {

                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();
                return this._elementStack.Peek().Prefix;
            }
        }

        /// <summary>
        /// Moves to read the next element.
        /// </summary>
        /// <returns>Returns true if the next element was read successfully; false if there are no more elements to read. </returns>
        public override bool Read()
        {
            ThrowIfObjectDisposed();
            bool result = MoveToNextElement();

            if (result && ! ReadMiscNodes)
            {
                // skip miscellaneous node
                while (result && this.IsMiscNode)
                {
                    result = MoveToNextElement();
                }
            }

            return result;
        }

     
        /// <summary>
        /// Moves to read the first child element.
        /// </summary>
        /// <returns>Returns true if the first child element was read successfully; false if there are no child elements to read. </returns>
        /// <remarks>This method can only be called on element start. At the current node, the reader will move to the end tag if there is no child element.</remarks>
        public override bool ReadFirstChild()
        {
            ThrowIfObjectDisposed();
            bool result = MoveToFirstChild();

            if (result && ! ReadMiscNodes)
            {
                // skip miscellaneous node
                while (result && this.IsMiscNode)
                {
                    result = MoveToNextSibling();
                }
            }

            return result;
        }
     
        /// <summary>
        /// Moves to read the next sibling element.
        /// </summary>
        /// <returns>Returns true if the next sibling element was read successfully; false if there are no more sibling elements to read. </returns>
        /// <remarks>At the current node, the reader will move to the end tag of the parent if there are no more sibling elements.</remarks>
        public override bool ReadNextSibling()
        {
            ThrowIfObjectDisposed();
            bool result = MoveToNextSibling();

            if (result && !ReadMiscNodes)
            {
                // skip miscellaneous node
                while (result && this.IsMiscNode)
                {
                    result = MoveToNextSibling();
                }
            }

            return result;
        }

        /// <summary>
        /// Skips the child elements of the current node. 
        /// </summary>
        public override void Skip()
        {
            ThrowIfObjectDisposed();
            this.InnerSkip();

            if (!this.EOF && !ReadMiscNodes)
            {
                // skip miscellaneous node
                while (!this.EOF && this.IsMiscNode)
                {
                    this.InnerSkip();
                }
            }

        }

        #region private methods

        /// <summary>
        /// Moves to next element
        /// </summary>
        /// <returns>true if the next element was read successfully; false if there are no more elements to read. </returns>
        private bool MoveToNextElement()
        {
            Debug.Assert(this._xmlReader != null);

            switch (this._elementState)
            {
                case ElementState.Null:
                    return this.ReadRoot();

                case ElementState.EOF:
                    return false;

                case ElementState.Start:
                    break;

                case ElementState.End:
                case ElementState.MiscNode:
                    // cursor is end element, pop stack 
                    this._elementStack.Pop();
                    break;

                case ElementState.LeafStart:
                    // cursor is leaf element start
                    // just change the state to element end
                    // do not move the cursor
                    this._elementState = ElementState.LeafEnd;
                    return true;


                case ElementState.LeafEnd:
                case ElementState.LoadEnd:
                    // cursor is end element, pop stack 
                    this._elementStack.Pop();
                    if (this._elementStack.Count == 0)
                    {
                        this._elementState = ElementState.EOF;
                        return false;
                    }
                    else
                    {
                        GetElementInformation();
                        return true;
                    }

                default:
                    break;
            }

            this._elementState = ElementState.Null;
           
            if (this._xmlReader.EOF || !this._xmlReader.Read())
            {
                this._elementState = ElementState.EOF;
                return false;
            }
            else
            {
                GetElementInformation();
                return true;
            }
        }

        /// <summary>
        /// Move to first child 
        /// </summary>
        /// <returns>true if the first child element was read successfully; false if there are no child elements to read. </returns>
        /// <remarks>Only can be called on element start. Current will move to the end tag if no child element.</remarks>
        private bool MoveToFirstChild()
        {
            Debug.Assert(this._xmlReader != null);

            switch (this._elementState)
            {
                case ElementState.EOF:
                    return false;

                case ElementState.Start:
                    if (!this._xmlReader.Read())
                    {
                        // should can read.
                        Debug.Assert(false);
                        return false;
                    }
                    GetElementInformation();
                    if (this._elementState == ElementState.End)
                    {
                        return false;
                    }
                    return true;

                case ElementState.LeafStart:
                    this._elementState = ElementState.LeafEnd;
                    return false;

                case ElementState.End:
                case ElementState.LeafEnd:
                case ElementState.LoadEnd:
                case ElementState.MiscNode:
                    return false;

                case ElementState.Null:
                    ThrowIfNull();
                    break;

                default:
                    break;
            }
            return false;
        }

        /// <summary>
        /// Move to  next sibling element 
        /// </summary>
        /// <returns>true if the next sibling element was read successfully; false if there are no more sibling elements to read. </returns>
        /// <remarks>Current will move to the end tag of the parent if no more sibling element.</remarks>
        private bool MoveToNextSibling()
        {
            Debug.Assert(this._xmlReader != null);

            if (this._elementState == ElementState.EOF)
            {
                return false;
            }

            this.InnerSkip();

            if (this._elementState == ElementState.EOF)
            {
                return false;
            }
            else if (this._elementState == ElementState.End)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Skips the children of the current node. 
        /// </summary>
        private void InnerSkip()
        {
            Debug.Assert(this._xmlReader != null);

            switch (this._elementState)
            {
                case ElementState.Null:
                    ThrowIfNull();
                    break;

                case ElementState.EOF:
                    return;

                case ElementState.Start:
                    this._xmlReader.Skip();
                    this._elementStack.Pop();
                    GetElementInformation();
                    return;

                case ElementState.End:
                case ElementState.MiscNode:
                    // cursor is end element, pop stack 
                    this._xmlReader.Skip();
                    this._elementStack.Pop();
                    GetElementInformation();
                    return;
                
                case ElementState.LeafStart:
                    // no move, just process cursor
                    this._elementStack.Pop();
                    GetElementInformation();
                    return;

                case ElementState.LeafEnd:
                case ElementState.LoadEnd:
                    // cursor is leaf element, pop stack, no move
                    this._elementStack.Pop();
                    GetElementInformation();
                    return;

                default:
                    break;
            }
            return;
        }

        #endregion

        /// <summary>
        /// Loads the element at the current cursor.
        /// </summary>
        /// <returns>The OpenXmlElement object.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the current element is element end.</exception>
        /// <remarks>The new current element is the end of the element after LoadCurrentElement().</remarks>
        public override OpenXmlElement LoadCurrentElement()
        {
            ThrowIfObjectDisposed();
            OpenXmlElement element;

            switch (this._elementState)
            {
                case ElementState.LeafStart:
                    element = this._elementStack.Pop();
                    this._elementStack.Push(element.CloneNode(true));

                    // stop at the end tag. 
                    this._elementState = ElementState.LoadEnd;
                    return element;

                case ElementState.Start:
                    element = this._elementStack.Peek();
                    element.Load(this._xmlReader, OpenXmlLoadMode.Full);

                    // stop at the end tag. 
                    this._elementState = ElementState.LoadEnd;
                    return element;

                case ElementState.MiscNode:
                    Debug.Assert(this.ReadMiscNodes);

                    element = this._elementStack.Pop();
                    element.Load(this._xmlReader, OpenXmlLoadMode.Full);
                    // stop at next element.
                    GetElementInformation();
                    return element;


                case ElementState.Null:
                    ThrowIfNull();
                    break;

                case ElementState.EOF:
                    ThrowIfEof();
                    break;

                case ElementState.LoadEnd:
                case ElementState.End:
                case ElementState.LeafEnd:
                    throw new InvalidOperationException(ExceptionMessages.ReaderInEndState);

                default:
                    Debug.Assert(false);
                    break;
            }
            return null;
        }

        ///// <summary>
        ///// Create an empty element of the element at current cursor.
        ///// </summary>
        ///// <returns>An empty ( no children, no attributes ) OpenXmlElement.</returns>
        //public override OpenXmlElement CreateElement()
        //{
        //    switch (this._elementState)
        //    {
        //        case ElementState.LeafStart:
        //        case ElementState.Start:
        //        case ElementState.MiscNode:
        //            {
        //                OpenXmlElement element = this._elementStack.Peek();
        //                OpenXmlElement newElement = element.CloneNode(false);
        //                newElement.ClearAllAttributes();
        //                return newElement;
        //            }

        //        case ElementState.LoadEnd:
        //        case ElementState.End:
        //        case ElementState.LeafEnd:
        //        case ElementState.Null:
        //        case ElementState.EOF:
        //        default:
        //            throw new InvalidOperationException();
        //    }
        //}

        /// <summary>
        /// Gets the text of the element if the element is an OpenXmlLeafTextElement. Returns String.Empty for other elements.
        /// </summary>
        /// <returns>
        /// The text of the element if the element is an OpenXmlLeafTextElement. Returns String.Empty for other elements.
        /// </returns>
        public override string GetText()
        {
            ThrowIfObjectDisposed();
            if (this._elementState == ElementState.LeafStart)
            {
                OpenXmlElement element = this._elementStack.Peek();

                OpenXmlLeafTextElement textElement = element as OpenXmlLeafTextElement;

                if (textElement != null)
                {
                    return textElement.Text;
                }
            }
            return String.Empty;
        }


        /// <summary>
        /// Closes the reader.
        /// </summary>
        public override void Close()
        {
            ThrowIfObjectDisposed();
            this._elementState = ElementState.EOF;
            this._elementStack.Clear();
            this._xmlReader.Close();
        }


        #region private methods

        private void Init(Stream partStream, bool closeInput)
        {
            _elementContext.XmlReaderSettings.CloseInput = closeInput;
            _elementContext.XmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit; // set true explicitly for security fix
            _elementContext.XmlReaderSettings.IgnoreWhitespace = true; // O15:#3024890, the default is false, but we set it to True for compatibility of OpenXmlPartReader behavior
            this._xmlReader = XmlConvertingReaderFactory.Create(partStream, _elementContext.XmlReaderSettings);

            this._xmlReader.Read();

            if ( this._xmlReader.NodeType == XmlNodeType.XmlDeclaration)
            {
                 this._encoding = this._xmlReader["encoding"]; // get the "encoding" attribute

                //if (!String.IsNullOrEmpty(encoding))
                //{
                //    try
                //    {
                //        this._encoding = Encoding.GetEncoding(encoding);
                //    }
                //    catch (ArgumentException)
                //    {
                //        // should we catch?
                //        this._encoding = Encoding.UTF8;
                //    }
                //}

                string standalone = this._xmlReader["standalone"]; // get the "standalone" attribute

                if (!String.IsNullOrEmpty(standalone))
                {
                    if (standalone == "yes")
                    {
                        this._standalone = true;
                    }
                    else
                    {
                        this._standalone = false;
                    }
                }
            }

            this._elementState = ElementState.Null;
        }

        private bool ReadRoot()
        {
            Debug.Assert(this._elementState == ElementState.Null);
            Debug.Assert(this._elementStack.Count == 0);

            // TODO: should we take care of entity? <!DOCTYPE page [ <!ENTITY company "Microsoft"> ]>
            // TODO: is it OK that we skip all prolog ( DOCTYPE, Comment, PT ) ?

            this._xmlReader.MoveToContent();

            while (!this._xmlReader.EOF && this._xmlReader.NodeType != XmlNodeType.Element)
            {
                this._xmlReader.Skip();
            }

            if (this._xmlReader.EOF || !this._xmlReader.IsStartElement())
            {
                throw new InvalidDataException(ExceptionMessages.PartIsEmpty);
            }

            // create the root element object
            OpenXmlElement rootElement = RootElementFactory.CreateElement(this._xmlReader.NamespaceURI, this._xmlReader.LocalName);

            if (rootElement == null)
            {
                throw new InvalidDataException(ExceptionMessages.PartUnknown);
            }

            this._elementStack.Push(rootElement);

            LoadAttributes();

            if (this._xmlReader.IsEmptyElement)
            {
                this._elementState = ElementState.LeafStart;
                rootElement.Load(this._xmlReader, OpenXmlLoadMode.Full);
            }
            else
            {
                this._elementState = ElementState.Start;
            }
            return true;
        }

        private void LoadAttributes()
        {
            Debug.Assert(this._xmlReader != null);

            this._attributeList.Clear();
            _nsDecls.Clear();

            // read attributes
            if (this._xmlReader.HasAttributes)
            {
                while (this._xmlReader.MoveToNextAttribute())
                {
                    if (this._xmlReader.Prefix == OpenXmlElementContext.xmlnsPrefix)
                    {
                        _nsDecls.Add(new KeyValuePair<string, string>(_xmlReader.LocalName, _xmlReader.Value));
                    }
                    else
                    {
                        OpenXmlAttribute attribute = new OpenXmlAttribute(this._xmlReader.Prefix, this._xmlReader.LocalName, this._xmlReader.NamespaceURI, this._xmlReader.Value);
                        this._attributeList.Add(attribute);
                    }
                }

                //  Moves the reader back to the element node.
                this._xmlReader.MoveToElement();
            }
   
        }

        private void GetElementInformation()
        {
            if (this._xmlReader.EOF)
            {
                Debug.Assert(this._elementStack.Count == 0);

                this._elementState = ElementState.EOF;
                return;
            }

            Debug.Assert(this._elementStack.Count > 0);

            OpenXmlElement element;
            switch (this._xmlReader.NodeType)
            {
                case XmlNodeType.EndElement:
//#if DEBUG
//                    {
//                        OpenXmlElement top = this._elementStack.Pop();

//                        element = this.CreateElement();

//                        this._elementStack.Push(top);

//                        Debug.Assert(element.GetType() == this._elementStack.Peek().GetType());
//                    }
//#endif
                    this._elementState = ElementState.End;
                    break;

                case XmlNodeType.Element:
                    element = this.CreateChildElement();

                    LoadAttributes();

                    if (this._xmlReader.IsEmptyElement)
                    {
                        this._elementState = ElementState.LeafStart;
                        element.Load(this._xmlReader, OpenXmlLoadMode.Full);
                    }
                    else if (element is OpenXmlLeafElement  || element is OpenXmlLeafTextElement )
                    {
                        this._elementState = ElementState.LeafStart;
                        element.Load(this._xmlReader, OpenXmlLoadMode.Full);
                    }
                    else if (element is OpenXmlUnknownElement)
                    {
                        this._elementState = ElementState.Start;
                    }
                    else
                    {
                        Debug.Assert(element is OpenXmlCompositeElement);
                        this._elementState = ElementState.Start;
                    }

                    this._elementStack.Push(element);
                    break;

                default:
                    // non element ( PI, Comment, Notation, XmlDeclaration )
                    element = this.CreateChildElement();
                    (element as OpenXmlMiscNode).LoadOuterXml(this._xmlReader);
                    this._elementStack.Push(element);
                    this._elementState = ElementState.MiscNode;
                    break;
            }
        }

        private OpenXmlElement CreateChildElement()
        {
            Debug.Assert(this._elementStack.Count > 0);
            Debug.Assert(this._xmlReader != null);

            OpenXmlElement element = this._elementStack.Peek();

            // AlternateContent / Choice / Fallback needs special treatment
            // The ElementFactory( ) of the Choice / Fallback depends on the parent of AlternateContentChoice 
            // TODO: find a better solution
            if (element is AlternateContentChoice || element is AlternateContentFallback)
            {
                if ( this._elementStack.Count > 2 )
                {
                    OpenXmlElement topElement = this._elementStack.Pop( );
                    OpenXmlElement acElement = this._elementStack.Pop( );
                    
                    OpenXmlElement parentsParent = this._elementStack.Peek( ).CloneNode(false);

                    this._elementStack.Push( acElement );
                    this._elementStack.Push( topElement );

                    element = topElement.CloneNode( false );
                    acElement = new AlternateContent( );
                    acElement.AppendChild( element );
                    parentsParent.AppendChild( acElement );
                }
            }

            return element.ElementFactory(this._xmlReader);
        }

        private void ThrowIfNull()
        {
            if (this._elementState == ElementState.Null)
            {
                throw new InvalidOperationException(ExceptionMessages.ReaderInNullState);
            }
        }

        private void ThrowIfEof()
        {

            if (this._elementState == ElementState.EOF || this._elementStack.Count <= 0)
            {
                throw new InvalidOperationException(ExceptionMessages.ReaderInEofState);
            }
        }

        #endregion

    }

    /// <summary>
    /// Represents the Open XML document reader class.
    /// </summary>
    public class OpenXmlDomReader : OpenXmlReader
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ReadOnlyCollection<OpenXmlAttribute> _emptyReadOnlyList;

        private OpenXmlElement _rootElement;
        private Stack<OpenXmlElement> _elementStack;
        private ElementState _elementState;

        private OpenXmlDomReader()
            : base()
        {
            this._elementStack = new Stack<OpenXmlElement>();
            this._elementState = ElementState.Null;
        }

        private OpenXmlDomReader(bool readMiscNodes)
            : base(readMiscNodes)
        {
            this._elementStack = new Stack<OpenXmlElement>();
            this._elementState = ElementState.Null;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlDomReader class.
        /// </summary>
        /// <param name="openXmlElement">The OpenXmlElement to read.</param>
        public OpenXmlDomReader(OpenXmlElement openXmlElement) : this()
        {
            if (openXmlElement == null)
            {
                throw new ArgumentNullException("openXmlElement");
            }

            this.Init(openXmlElement);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlDomReader class using the supplied OpenXmlElement and Boolean values.
        /// </summary>
        /// <param name="openXmlElement">The OpenXmlElement to read.</param>
        /// <param name="readMiscNodes">Specify false to indicate to the reader to skip all miscellaneous nodes. The default value is false.</param>
        public OpenXmlDomReader(OpenXmlElement openXmlElement, bool readMiscNodes)
            : this(readMiscNodes)
        {
            if (openXmlElement == null)
            {
                throw new ArgumentNullException("openXmlElement");
            }

            this.Init(openXmlElement);
        }

        /// <summary>
        /// Gets the list of attributes of the current element.
        /// </summary>
        public override ReadOnlyCollection<OpenXmlAttribute> Attributes
        {
            get 
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();
                
                if (this._elementState == ElementState.Start)
                {
                    Debug.Assert(this._elementStack.Count > 0);

                    OpenXmlElement element = this._elementStack.Peek();

                    return new ReadOnlyCollection<OpenXmlAttribute>(element.GetAttributes());
                }
                else
                {
                    if (_emptyReadOnlyList == null)
                    {
                        _emptyReadOnlyList = new ReadOnlyCollection<OpenXmlAttribute>(new List<OpenXmlAttribute>());
                    }
                    return _emptyReadOnlyList;
                }
            }
        }

        /// <summary>
        /// Gets the namespace declarations of the current element.
        /// </summary>
        public override IEnumerable<KeyValuePair<string, string>> NamespaceDeclarations
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();
                
                if (this._elementState == ElementState.Start)
                {
                    Debug.Assert(this._elementStack.Count > 0);

                    OpenXmlElement element = this._elementStack.Peek();

                    return element.NamespaceDeclarations;
                }
                else
                {
                    return EmptyEnumerable<KeyValuePair<string, string>>.EmptyEnumerableSingleton;
                }
            }
        }

        /// <summary>
        /// Gets the type of the corresponding strong typed class of the current element.
        /// </summary>
        public override Type ElementType
        {
           get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();
                return this._elementStack.Peek().GetType();
            }
        }

        ///// <summary>
        ///// When overridden in a derived class, gets a value indicating whether the current node is an empty element (for example, <MyElement/>). 
        ///// </summary>
        //public abstract bool IsEmptyElement { get; }

        /// <summary>
        /// Gets a value that indicates whether the current node is a miscellaneous XML node (non element). 
        /// </summary>
        /// <remarks>IsStartElement and IsEndElement will be false when IsMiscNode==true.</remarks>
        public override bool IsMiscNode
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();

                if (this._elementState == ElementState.MiscNode)
                {
                    Debug.Assert(this.ElementType == typeof(OpenXmlMiscNode));
                    return true;
                }
                else
                {
                }
                return false;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the current node is an element start. 
        /// </summary>
        /// <remarks>IsStartElement and IsEndElement will be false when IsMiscNode==true.</remarks>
        public override bool IsStartElement
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();
                
                if (!IsMiscNode)
                {
                    if (this._elementState == ElementState.Start || this._elementState == ElementState.LeafStart)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
            
        /// <summary>
        /// Gets a value that indicates whether the current node is an element end. 
        /// </summary>
        /// <remarks>IsStartElement and IsEndElement will be false when IsMiscNode==true.</remarks>
        public override bool IsEndElement
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();
                
                if (!IsMiscNode)
                {
                    if (this._elementState == ElementState.End)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Gets the depth of the current node in the XML document. The depth of the root element is 0.
        /// </summary>
        public override int Depth
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();

                Debug.Assert(this._elementStack.Count > 0);
                return this._elementStack.Count - 1;  // depth of root element is 0
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the reader is positioned at the end of the stream. 
        /// </summary>
        public override bool EOF
        {
            get
            {
                ThrowIfObjectDisposed();
                //Debug.Assert(this._elementStack.Count == 0);

                return this._elementState == ElementState.EOF;
            }
        }

        /// <summary>
        /// Gets the local name of the current node. 
        /// </summary>
        public override string LocalName
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();
                return this._elementStack.Peek().LocalName;
            }
        }

        /// <summary>
        /// Gets the namespace URI (as defined in the W3C Namespace specification) of the node on which the reader is positioned. 
        /// </summary>
        public override string NamespaceUri
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();
                return this._elementStack.Peek().NamespaceUri;
            }
        }

        ///// <summary>
        ///// When overridden in a derived class, gets the qualified name of the current node. 
        ///// </summary>
        //public virtual string Name { get; }

        /// <summary>
        /// Gets the namespace prefix associated with the current node. 
        /// </summary>
        public override string Prefix
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();
                return this._elementStack.Peek().Prefix;
            }
        }

        /// <summary>
        /// Moves to read the next element.
        /// </summary>
        /// <returns>Returns true if the next element was read successfully; false if there are no more elements to read. </returns>
        public override bool Read()
        {
            ThrowIfObjectDisposed();
            bool result = MoveToNextElement();

            if (result && !ReadMiscNodes)
            {
                // skip miscellaneous node
                while (result && this.IsMiscNode)
                {
                    result = MoveToNextElement();
                }
            }

            return result;
        }


        /// <summary>
        /// Moves to read the first child element.
        /// </summary>
        /// <returns>Returns true if the first child element was read successfully; false if there are no child elements to read. </returns>
        /// <remarks>This method can only be called on element start. At the current node, the reader will move to the end tag if there is no child element.</remarks>
        public override bool ReadFirstChild()
        {
            ThrowIfObjectDisposed();
            bool result = MoveToFirstChild();

            if (result && !ReadMiscNodes)
            {
                // skip miscellaneous node
                while (result && this.IsMiscNode)
                {
                    result = MoveToNextSibling();
                }
            }

            return result;
        }

        /// <summary>
        /// Moves to read the next sibling element.
        /// </summary>
        /// <returns>Returns true if the next sibling element was read successfully; false if there are no more sibling elements to read. </returns>
        /// <remarks>At the current node, the reader will move to the end tag of the parent if there are no more sibling elements.</remarks>
        public override bool ReadNextSibling()
        {
            ThrowIfObjectDisposed();
            bool result = MoveToNextSibling();

            if (result && !ReadMiscNodes)
            {
                // skip miscellaneous node
                while (result && this.IsMiscNode)
                {
                    result = MoveToNextSibling();
                }
            }

            return result;
        }

        /// <summary>
        /// Skips the children of the current node. 
        /// </summary>
        public override void Skip()
        {
            ThrowIfObjectDisposed();
            this.InnerSkip();

            if (!this.EOF && !ReadMiscNodes)
            {
                // skip miscellaneous node
                while (!this.EOF && this.IsMiscNode)
                {
                    this.InnerSkip();
                }
            }

        }

        #region private methods

        /// <summary>
        /// Move to next element 
        /// </summary>
        /// <returns>true if the next element was read successfully; false if there are no more elements to read. </returns>
        private bool MoveToNextElement()
        {
            if (this._elementState == ElementState.Null)
            {
                return this.ReadRoot();
            }

            OpenXmlElement element;

            switch (this._elementState)
            {
                case ElementState.EOF:
                    return false;

                case ElementState.Start:
                    {
                        element = this._elementStack.Peek();
                        if (element.HasChildren)
                        {
                            this._elementStack.Push(element.FirstChild);
                            if (element.FirstChild is OpenXmlMiscNode)
                            {
                                this._elementState = ElementState.MiscNode;
                            }
                            else
                            {
                                this._elementState = ElementState.Start;
                            }
                        }
                        else
                        {
                            // at start state
                            this._elementState = ElementState.End;
                        }
                    }
                    break;

                case ElementState.End:
                case ElementState.MiscNode:
                    {
                        // at end state, find next element
                        element = this._elementStack.Pop();

                        if (this._elementStack.Count > 0)
                        {
                            element = element.NextSibling();
                            if (element != null)
                            {
                                this._elementStack.Push(element);

                                if (element is OpenXmlMiscNode)
                                {
                                    this._elementState = ElementState.MiscNode;
                                }
                                else
                                {
                                    this._elementState = ElementState.Start;
                                }
                            }
                            else
                            {
                                this._elementState = ElementState.End;
                            }
                        }
                        else
                        {
                            Debug.Assert(element == this._rootElement);
                            // no more elements
                            this._elementState = ElementState.EOF;
                            return false;
                        }
                    }
                    break;

                default:
                    Debug.Assert(this._elementState == ElementState.Start ||
                        this._elementState == ElementState.End ||
                        this._elementState == ElementState.EOF);
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Move to first child 
        /// </summary>
        /// <returns>true if the first child element was read successfully; false if there are no child elements to read. </returns>
        /// <remarks>Only can be called on element start. Current will move to the end tag if no child element.</remarks>
        private bool MoveToFirstChild()
        {
            ThrowIfNull();

            if (this._elementState != ElementState.Start)
            {
                return false;
            }            

            OpenXmlElement element = this._elementStack.Peek();
            if (element.HasChildren)
            {
                this._elementStack.Push(element.FirstChild);
                if (element.FirstChild is OpenXmlMiscNode)
                {
                    this._elementState = ElementState.MiscNode;
                }
                else
                {
                    this._elementState = ElementState.Start;
                }
                return true;
            }
            else
            {
                this._elementState = ElementState.End;
                return false;
            }
        }

        /// <summary>
        /// Move to  next sibling element 
        /// </summary>
        /// <returns>true if the next sibling element was read successfully; false if there are no more sibling elements to read. </returns>
        /// <remarks>Current will move to the end tag of the parent if no more sibling element.</remarks>
        private bool MoveToNextSibling()
        {
            if (this._elementState == ElementState.EOF)
            {
                return false;
            }

            ThrowIfNull();

            if (this._elementStack.Count == 0)
            {
                this._elementState = ElementState.EOF;
                return false;
            }

            OpenXmlElement element = this._elementStack.Pop();

            // Fix bug #253890, case: the element used to constructor this DOM reader is not root element ( aka. it has parents and siblings. )
            // the stack is empty means we should move to EOF.
            if (this._elementStack.Count == 0)
            {
                this._elementState = ElementState.EOF;
                return false;
            }

            element = element.NextSibling();
            if (element != null)
            {
                this._elementStack.Push(element);
                if (element is OpenXmlMiscNode)
                {
                    this._elementState = ElementState.MiscNode;
                }
                else
                {
                    this._elementState = ElementState.Start;
                } 
                return true;
            }
            else
            {
                if (this._elementStack.Count > 0)
                {
                    this._elementState = ElementState.End;
                }
                else
                {
                    // no more element, EOF
                    this._elementState = ElementState.EOF;
                }
                return false;
            }
        }

        /// <summary>
        /// Skips the children of the current node. 
        /// </summary>
        private void InnerSkip()
        {
            switch (this._elementState)
            {
                case ElementState.Null:
                    ThrowIfNull();
                    return;

                case ElementState.EOF:
                    return;

                case ElementState.End:
                case ElementState.MiscNode:
                    this.MoveToNextElement();
                    return;

                case ElementState.Start:
                   this.MoveToNextSibling();
                   return;

                default:
                    Debug.Assert(this._elementState == ElementState.Start ||
                        this._elementState == ElementState.End ||
                        this._elementState == ElementState.EOF);
                    return;
            }
        }

        #endregion

        /// <summary>
        /// Loads the element at the current cursor.
        /// </summary>
        /// <returns>The OpenXmlElement object.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the current element is element end.</exception>
        /// <remarks>The new current element is the end of the element after LoadCurrentElement().</remarks>
        public override OpenXmlElement LoadCurrentElement()
        {
            // TODO: should we return a clone?
            // The user expect the element in the tree returned? Is this assumption correct?
            ThrowIfObjectDisposed();
            ThrowIfNull();
            ThrowIfEof();

            if (this._elementState == ElementState.Start)
            {
                OpenXmlElement element = this._elementStack.Peek();

                this._elementState = ElementState.End;

                return element;
            }
            else if (this._elementState == ElementState.MiscNode)
            {
                Debug.Assert(this.ReadMiscNodes);

                OpenXmlElement element = this._elementStack.Peek();

                this.Skip();

                return element;
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.ReaderInEndState);
            }
        }

        ///// <summary>
        ///// Create an empty element of the element at current cursor.
        ///// </summary>
        ///// <returns>An empty ( no children, no attributes ) OpenXmlElement.</returns>
        //public override OpenXmlElement CreateElement()
        //{
        //    if (this._elementState == ElementState.Start ||
        //        this._elementState == ElementState.MiscNode)
        //    {
        //        OpenXmlElement element = this._elementStack.Peek();
        //        OpenXmlElement newElement = element.CloneNode(false);
        //        newElement.ClearAllAttributes();
        //        return newElement;
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException();
        //    }
        //}

        /// <summary>
        /// Gets the text of the element if the element is an OpenXmlLeafTextElement. Returns String.Empty for other elements.
        /// </summary>
        /// <returns>
        /// The text of the element if the element is an OpenXmlLeafTextElement. Returns String.Empty for other elements.
        /// </returns>
        public override string GetText()
        {
            ThrowIfObjectDisposed();
            if (this._elementState == ElementState.Start)
            {
                OpenXmlElement element = this._elementStack.Peek();

                OpenXmlLeafTextElement textElement = element as OpenXmlLeafTextElement;

                if (textElement != null)
                {
                    return textElement.Text;
                }
            }
            return String.Empty;
        }

        /// <summary>
        /// Closes the reader.
        /// </summary>
        public override void Close()
        {
            ThrowIfObjectDisposed();
            this._elementState = ElementState.EOF;
            this._elementStack.Clear();
            this._rootElement = null;
        }

        #region private methods

        private void Init(OpenXmlElement openXmlElement)
        {
            this._rootElement = openXmlElement;
            this._elementState = ElementState.Null;
        }

        private bool ReadRoot()
        {
            this._elementStack.Push(this._rootElement);
            if (this._rootElement is OpenXmlMiscNode)
            {
                this._elementState = ElementState.MiscNode;
            }
            else
            {
                this._elementState = ElementState.Start;
            } 
            return true;
        }

        private void ThrowIfNull()
        {
            if (this._elementState == ElementState.Null)
            {
                throw new InvalidOperationException(ExceptionMessages.ReaderInNullState);
            }
        }

        private void ThrowIfEof()
        {

            if ( this._elementState == ElementState.EOF || this._elementStack.Count <= 0)
            {
                throw new InvalidOperationException(ExceptionMessages.ReaderInEofState);
            }
        }

        #endregion
    }
}
