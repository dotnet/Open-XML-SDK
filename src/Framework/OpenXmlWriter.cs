// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Xml;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the OpenXmlWriter.
    /// </summary>
    public abstract class OpenXmlWriter : IDisposable
    {

        private bool _disposed;

        /// <summary>
        /// Initializes a new instance of the OpenXmlWriter.
        /// </summary>
        protected OpenXmlWriter()
        {
        }

        /// <summary>
        /// Create an OpenXmlWriter from the OpenXmlPart.
        /// </summary>
        /// <param name="openXmlPart">The OpenXmlPart to be writern.</param>
        /// <returns>The created OpenXmlWriter instance.</returns>
        public static OpenXmlWriter Create(OpenXmlPart openXmlPart)
        {
            return new OpenXmlPartWriter(openXmlPart);
        }

        /// <summary>
        /// Create an OpenXmlWriter from the OpenXmlPart.
        /// </summary>
        /// <param name="openXmlPart">The OpenXmlPart to be writern.</param>
        /// <param name="encoding">The encoding for the XML stream.</param>
        /// <returns>The created OpenXmlWriter instance.</returns>
        public static OpenXmlWriter Create(OpenXmlPart openXmlPart, Encoding encoding)
        {
            return new OpenXmlPartWriter(openXmlPart, encoding);
        }

        /// <summary>
        /// Create an OpenXmlWriter on a given stream.
        /// </summary>
        /// <param name="partStream">The target stream.</param>
        /// <returns>The created OpenXmlWriter instance.</returns>
        public static OpenXmlWriter Create(Stream partStream)
        {
            return new OpenXmlPartWriter(partStream);
        }

        /// <summary>
        /// Create an OpenXmlWriter on given stream
        /// </summary>
        /// <param name="partStream">The target stream.</param>
        /// <param name="encoding">The encoding for the XML stream.</param>
        /// <returns>The created OpenXmlWriter instance.</returns>
        public static OpenXmlWriter Create(Stream partStream, Encoding encoding)
        {
            return new OpenXmlPartWriter(partStream, encoding);
        }

        /// <summary>
        /// Writes the XML declaration with the version "1.0".
        /// </summary>
        public abstract void WriteStartDocument();

        /// <summary>
        /// Writes the XML declaration with the version "1.0" and the standalone attribute.
        /// </summary>
        /// <param name="standalone">If true, it writes "standalone=yes"; if false, it writes "standalone=no". </param>
        public abstract void WriteStartDocument(bool standalone);

        /// <summary>
        /// Writes out a start element tag of the current element of the OpenXmlReader. And write all the attributes of the element.
        /// </summary>
        /// <param name="elementReader">The OpenXmlReader to read from. </param>
        public abstract void WriteStartElement(OpenXmlReader elementReader);

        /// <summary>
        /// Writes out a start element tag of the current element of the OpenXmlReader. And write the attributes in attributes. 
        /// </summary>
        /// <param name="elementReader">The OpenXmlReader to read from. </param>
        /// <param name="attributes">The attributes to be writtern, can be null if no attrbutes.</param>
        public abstract void WriteStartElement(OpenXmlReader elementReader, IEnumerable<OpenXmlAttribute> attributes);

        /// <summary>
        /// Writes out a start element tag of the current element of the OpenXmlReader. And write the attributes in attributes. 
        /// </summary>
        /// <param name="elementReader">The OpenXmlReader to read from. </param>
        /// <param name="attributes">The attributes to be writtern, can be null if no attrbutes.</param>
        /// <param name="namespaceDeclarations">The namespace declarations to be written, can be null if no namespace declarations.</param>
        public abstract void WriteStartElement(OpenXmlReader elementReader, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations);

        /// <summary>
        /// Writes out a start tag of the element and all the attributes of the element.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be writen.</param>
        public abstract void WriteStartElement(OpenXmlElement elementObject);

        /// <summary>
        /// Writes out a start tag of the element. And write the attributes in attributes. The attributes of the element will be omitted.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be writen.</param>
        /// <param name="attributes">The attributes to be writtern.</param>
        public abstract void WriteStartElement(OpenXmlElement elementObject, IEnumerable<OpenXmlAttribute> attributes);

        /// <summary>
        /// Writes out a start tag of the element. And write the attributes in attributes. The attributes of the element will be omitted.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be writen.</param>
        /// <param name="attributes">The attributes to be writtern.</param>
        /// <param name="namespaceDeclarations">The namespace declarations to be written, can be null if no namespace declarations.</param>
        public abstract void WriteStartElement(OpenXmlElement elementObject, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations);

        /// <summary>
        /// Closes one element.  
        /// </summary>
        public abstract void WriteEndElement();

        /// <summary>
        /// Write the OpenXmlElement to the writer.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be writen.</param>
        public abstract void WriteElement(OpenXmlElement elementObject);

        /// <summary>
        /// When overridden in a derived class, writes the given text content. 
        /// </summary>
        /// <param name="text">The text to write. </param>
        public abstract void WriteString(string text);

        // public abstract void WriteRaw(string data);

        /// <summary>
        /// Close the writer.
        /// </summary>
        public abstract void Close();

        #region dispose related methods

        /// <summary>
        /// Throw if object is disposed.
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
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
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
        /// Closes the writer, and releases all resources. 
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
    
    /// <summary>
    /// Defines the OpenXmlPartWriter.
    /// </summary>
    public class OpenXmlPartWriter : OpenXmlWriter
    {
        private static Type _openXmlLeafTextElementClass;
        private static Type OpenXmlLeafTextElementClass
        {
            get
            {
                if (_openXmlLeafTextElementClass == null)
                {
                    _openXmlLeafTextElementClass = typeof(OpenXmlLeafTextElement);
                }
                return _openXmlLeafTextElementClass;
            }
        }

        private XmlWriter _xmlWriter;
        private bool _isLeafTextElementStart; // default is false

        // private Stack<OpenXmlElement> _elementStack;

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartWriter.
        /// </summary>
        /// <param name="openXmlPart">The OpenXmlPart to be written to.</param>
        public OpenXmlPartWriter(OpenXmlPart openXmlPart)
            : this(openXmlPart, Encoding.UTF8)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartWriter.
        /// </summary>
        /// <param name="openXmlPart">The OpenXmlPart to be written to.</param>
        /// <param name="encoding">The encoding for the XML stream.</param>
        public OpenXmlPartWriter(OpenXmlPart openXmlPart, Encoding encoding)
        {
            if (openXmlPart == null)
            {
                throw new ArgumentNullException("openXmlPart");
            }

            if (encoding == null)
            {
                throw new ArgumentNullException("encoding");
            }

            Stream partStream = openXmlPart.GetStream(FileMode.Create);
            this.Init(partStream, /*closeOutput*/true, encoding);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartWriter.
        /// </summary>
        /// <param name="partStream">The givern part stream.</param>
        public OpenXmlPartWriter(Stream partStream)
            : this(partStream, Encoding.UTF8)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartWriter.
        /// </summary>
        /// <param name="partStream">The givern part stream.</param>
        /// <param name="encoding">The encoding for the XML stream.</param>
        public OpenXmlPartWriter(Stream partStream, Encoding encoding)
        {
            if (partStream == null)
            {
                throw new ArgumentNullException("partStream");
            }

            if (encoding == null)
            {
                throw new ArgumentNullException("encoding");
            }

            this.Init(partStream, /*closeOutput*/false, encoding);
        }

        #region public OpenXmlWriter methods

        /// <summary>
        /// Writes the XML declaration with the version "1.0".
        /// </summary>
        public override void WriteStartDocument()
        {
            this.ThrowIfObjectDisposed();
            
            this._xmlWriter.WriteStartDocument();
        }

        /// <summary>
        /// Writes the XML declaration with the version "1.0" and the standalone attribute.
        /// </summary>
        /// <param name="standalone">If true, it writes "standalone=yes"; if false, it writes "standalone=no". </param>
        public override void WriteStartDocument(bool standalone)
        {
            this.ThrowIfObjectDisposed();
            
            this._xmlWriter.WriteStartDocument(standalone);
        }

        /// <summary>
        /// Writes out a start element tag of the current element of the OpenXmlReader. And write all the attributes of the element.
        /// </summary>
        /// <param name="elementReader">The OpenXmlReader to read from. </param>
        public override void WriteStartElement(OpenXmlReader elementReader)
        {
            WriteStartElement(elementReader, elementReader.Attributes, elementReader.NamespaceDeclarations);
        }


        /// <summary>
        /// Writes out a start element tag of the current element of the OpenXmlReader. And write the attributes in attributes. 
        /// </summary>
        /// <param name="elementReader">The OpenXmlReader to read from. </param>
        /// <param name="attributes">The attributes to be writtern, can be null if no attrbutes.</param>
        public override void WriteStartElement(OpenXmlReader elementReader, IEnumerable<OpenXmlAttribute> attributes)
        {
            WriteStartElement(elementReader,attributes, elementReader.NamespaceDeclarations);
        }

        /// <summary>
        /// Writes out a start element tag of the current element of the OpenXmlReader. And write the attributes in attributes. 
        /// </summary>
        /// <param name="elementReader">The OpenXmlReader to read from. </param>
        /// <param name="attributes">The attributes to be writtern, can be null if no attrbutes.</param>
        /// <param name="namespaceDeclarations">The namespace declarations to be written, can be null if no namespace declarations.</param>
        public override void WriteStartElement(OpenXmlReader elementReader, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations)
        {
            if (elementReader == null)
            {
                throw new ArgumentNullException("elementReader");
            }

            if (elementReader.IsEndElement)
            {
                throw new ArgumentOutOfRangeException("elementReader");
            }

            if (elementReader.IsMiscNode)
            {
                // OpenXmlMiscNode should be written by WriteElement( );
                throw new ArgumentOutOfRangeException("elementReader");
            }

            this.ThrowIfObjectDisposed();

            this._xmlWriter.WriteStartElement(elementReader.Prefix, elementReader.LocalName, elementReader.NamespaceUri);

            if (namespaceDeclarations != null)
            {
                foreach (var item in namespaceDeclarations)
                {
                    this._xmlWriter.WriteAttributeString(OpenXmlElementContext.xmlnsPrefix, item.Key, OpenXmlElementContext.xmlnsUri, item.Value);
                }
            }

            if (attributes != null)
            {
                // write attributes
                foreach (OpenXmlAttribute attribute in attributes)
                {
                    this._xmlWriter.WriteAttributeString(attribute.Prefix, attribute.LocalName, attribute.NamespaceUri, attribute.Value);
                }
            }

            if (IsOpenXmlLeafTextElement(elementReader.ElementType))
            {
                this._isLeafTextElementStart = true;
            }
            else
            {
                this._isLeafTextElementStart = false;
            }
        }

        /// <summary>
        /// Writes out a start tag of the element and all the attributes of the element.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be writen.</param>
        public override void WriteStartElement(OpenXmlElement elementObject)
        {
            if (elementObject == null)
            {
                throw new ArgumentNullException("elementObject");
            }

            if (elementObject is OpenXmlMiscNode)
            {
                throw new ArgumentOutOfRangeException("elementObject");
            }

            this.ThrowIfObjectDisposed();

            this._xmlWriter.WriteStartElement(elementObject.Prefix, elementObject.LocalName, elementObject.NamespaceUri);
            
            if (elementObject.HasAttributes)
            {
                // write attributes
                foreach (OpenXmlAttribute attribute in elementObject.GetAttributes())
                {
                    this._xmlWriter.WriteAttributeString(attribute.Prefix, attribute.LocalName, attribute.NamespaceUri, attribute.Value);
                }
            }

            if (IsOpenXmlLeafTextElement(elementObject))
            {
                this._isLeafTextElementStart = true;
            }
            else
            {
                this._isLeafTextElementStart = false;
            }
        }

        /// <summary>
        /// Writes out a start tag of the element. And write the attributes in attributes. The attributes of the element will be omitted.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be writen.</param>
        /// <param name="attributes">The attributes to be writtern.</param>
        public override void WriteStartElement(OpenXmlElement elementObject, IEnumerable<OpenXmlAttribute> attributes)
        {
            WriteStartElement(elementObject, attributes, elementObject.NamespaceDeclarations);
        }

        /// <summary>
        /// Writes out a start tag of the element. And write the attributes in attributes. The attributes of the element will be omitted.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be writen.</param>
        /// <param name="attributes">The attributes to be writtern.</param>
        /// <param name="namespaceDeclarations">The namespace declarations to be written, can be null if no namespace declarations.</param>
        public override void WriteStartElement(OpenXmlElement elementObject, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations)
        {
            if (elementObject == null)
            {
                throw new ArgumentNullException("elementObject");
            }

            if (elementObject is OpenXmlMiscNode)
            {
                throw new ArgumentOutOfRangeException("elementObject");
            }

            this.ThrowIfObjectDisposed();

            this._xmlWriter.WriteStartElement(elementObject.Prefix, elementObject.LocalName, elementObject.NamespaceUri);

            if (namespaceDeclarations != null)
            {
                foreach (var item in namespaceDeclarations)
                {
                    this._xmlWriter.WriteAttributeString(OpenXmlElementContext.xmlnsPrefix, item.Key, OpenXmlElementContext.xmlnsUri, item.Value);
                }
            }

            if (attributes != null)
            {
                // write attributes
                foreach (OpenXmlAttribute attribute in attributes)
                {
                    this._xmlWriter.WriteAttributeString(attribute.Prefix, attribute.LocalName, attribute.NamespaceUri, attribute.Value);
                }
            }

            if (IsOpenXmlLeafTextElement(elementObject))
            {
                this._isLeafTextElementStart = true;
            }
            else
            {
                this._isLeafTextElementStart = false;
            }
        }

        /// <summary>
        /// Closes one element.  
        /// </summary>
        public override void WriteEndElement()
        {
            this.ThrowIfObjectDisposed();

            this._xmlWriter.WriteEndElement();

            this._isLeafTextElementStart = false;
        }

        /// <summary>
        /// Writes the given text content. 
        /// </summary>
        /// <param name="text">The text to be writtern. </param>
        public override void WriteString(string text)
        {
            this.ThrowIfObjectDisposed();

            if (this._isLeafTextElementStart)
            {
                this._xmlWriter.WriteString(text);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidWriteStringCall);
            }

            // can continue WriteString(), so don't set _isLeafTextElementStart to false.
        }     

        /// <summary>
        /// Write the OpenXmlElement to the writer.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be writen.</param>
        public override void WriteElement(OpenXmlElement elementObject)
        {
            if (elementObject == null)
            {
                throw new ArgumentNullException("elementObject");
            }

            this.ThrowIfObjectDisposed();

            elementObject.WriteTo(this._xmlWriter);

            this._isLeafTextElementStart = false;
        }

        /// <summary>
        /// Close the writer.
        /// </summary>
        public override void Close()
        {
            if (this._xmlWriter != null)
            {
                // the end tag of the root element
                // this._xmlWriter.WriteEndElement();

                this._xmlWriter.Close();
            }

            this._isLeafTextElementStart = false;
        }

        #endregion

        #region private methods

        private void Init( Stream partStream, bool closeOutput, Encoding encoding)
        {
            // this._elementStack = new Stack<OpenXmlElement>();

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.CloseOutput = closeOutput;
            settings.Encoding = encoding;
            
            this._xmlWriter = XmlWriter.Create(partStream, settings);
        }

        private static bool IsOpenXmlLeafTextElement(Type elementType)
        {
            return elementType.IsSubclassOf(OpenXmlLeafTextElementClass);
        }

        private static bool IsOpenXmlLeafTextElement(OpenXmlElement element)
        {
            return element is OpenXmlLeafTextElement;
        }
        
        #endregion

    }


}
