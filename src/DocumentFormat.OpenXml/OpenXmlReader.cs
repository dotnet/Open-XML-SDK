// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;

namespace DocumentFormat.OpenXml
{
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
            _readMiscNodes = readMiscNodes;
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
        /// Gets a value indicating whether the OpenXmlReader will read or skip all miscellaneous nodes.
        /// </summary>
        public bool ReadMiscNodes
        {
            get
            {
                ThrowIfObjectDisposed();
                return _readMiscNodes;
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
        /// Gets a value indicating whether the current node has any attributes.
        /// </summary>
        public virtual bool HasAttributes
        {
            get
            {
                ThrowIfObjectDisposed();
                return Attributes.Count > 0;
            }
        }

        /// <summary>
        /// Gets the list of attributes of the current element.
        /// </summary>
        public abstract ReadOnlyCollection<OpenXmlAttribute> Attributes { get; }

        /// <summary>
        /// Gets the namespace declarations of the current element.
        /// </summary>
        public abstract IEnumerable<KeyValuePair<string, string>> NamespaceDeclarations { get; }

        /// <summary>
        /// Gets the type of the corresponding strongly typed class of the current element.
        /// </summary>
        public abstract Type ElementType { get; }

        /// <summary>
        /// Gets a value indicating whether the current node is a miscellaneous XML node (non element).
        /// </summary>
        /// <remarks><see cref="IsStartElement"/> and <see cref="IsEndElement"/> will be false when <see cref="IsMiscNode"/> is true.</remarks>
        public abstract bool IsMiscNode { get; }

        /// <summary>
        /// Gets a value indicating whether the current node is an element start.
        /// </summary>
        public abstract bool IsStartElement { get; }

        /// <summary>
        /// Gets a value indicating whether the current node is an element end.
        /// </summary>
        public abstract bool IsEndElement { get; }

        /// <summary>
        /// Gets the depth of the current node in the XML document. The depth of the root element is 0.
        /// </summary>
        public abstract int Depth { get; }

        /// <summary>
        /// Gets a value indicating whether the reader is positioned at the end of the stream.
        /// </summary>
        public abstract bool EOF { get; }

        /// <summary>
        /// Gets the local name of the current node.
        /// </summary>
        public abstract string LocalName { get; }

        /// <summary>
        /// Gets the namespace URI (as defined in the W3C Namespace specification) of the node on which the reader is positioned.
        /// </summary>
        public abstract string NamespaceUri { get; }

        /// <summary>
        /// Gets the namespace prefix associated with the current node.
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
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().Name);
            }
        }

        /// <summary>
        /// Closes the reader, and releases all resources.
        /// </summary>
        /// <param name="disposing">Specify true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Close();
                }

                _disposed = true;
            }
        }

#endregion

#region IDisposable Members

        /// <summary>
        /// Closes the reader, and releases all resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

#endregion
    }
}
