// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
#if TASKS_SUPPORTED
using DocumentFormat.OpenXml.Framework;
using System.Threading.Tasks;
#endif
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the OpenXmlPartWriter.
    /// </summary>
    public class OpenXmlPartWriter : OpenXmlWriter
    {
        private readonly XmlWriter _xmlWriter;
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
            if (openXmlPart is null)
            {
                throw new ArgumentNullException(nameof(openXmlPart));
            }

            if (encoding is null)
            {
                throw new ArgumentNullException(nameof(encoding));
            }

            var partStream = openXmlPart.GetStream(FileMode.Create);
            var settings = new XmlWriterSettings
            {
                CloseOutput = true,
                Encoding = encoding,
            };

            _xmlWriter = XmlWriter.Create(partStream, settings);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartWriter.
        /// </summary>
        /// <param name="openXmlPart">The OpenXmlPart to be written to.</param>
        /// <param name="settings">The settings for the OpenXmlPartWriter.</param>
        public OpenXmlPartWriter(OpenXmlPart openXmlPart, OpenXmlPartWriterSettings settings)
        {
            if (openXmlPart is null)
            {
                throw new ArgumentNullException(nameof(openXmlPart));
            }

            if (settings is null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            var partStream = openXmlPart.GetStream(FileMode.Create);
            XmlWriterSettings xmlWriterSettings = new()
            {
                CloseOutput = true,
                Encoding = settings.Encoding,
#if TASKS_SUPPORTED
                Async = settings.Async,
#endif
            };

            _xmlWriter = XmlWriter.Create(partStream, xmlWriterSettings);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartWriter.
        /// </summary>
        /// <param name="partStream">The given part stream.</param>
        public OpenXmlPartWriter(Stream partStream)
            : this(partStream, Encoding.UTF8)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartWriter.
        /// </summary>
        /// <param name="partStream">The given part stream.</param>
        /// <param name="encoding">The encoding for the XML stream.</param>
        public OpenXmlPartWriter(Stream partStream, Encoding encoding)
        {
            if (partStream is null)
            {
                throw new ArgumentNullException(nameof(partStream));
            }

            if (encoding is null)
            {
                throw new ArgumentNullException(nameof(encoding));
            }

            var settings = new XmlWriterSettings
            {
                CloseOutput = false,
                Encoding = encoding,
            };

            _xmlWriter = XmlWriter.Create(partStream, settings);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartWriter.
        /// </summary>
        /// <param name="partStream">The given part stream.</param>
        /// <param name="settings">The settings for the OpenXmlPartWriter.</param>
        public OpenXmlPartWriter(Stream partStream, OpenXmlPartWriterSettings settings)
        {
            if (partStream is null)
            {
                throw new ArgumentNullException(nameof(partStream));
            }

            if (settings is null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            XmlWriterSettings xmlWriterSettings = new()
            {
                CloseOutput = settings.CloseOutput,
                Encoding = settings.Encoding,
#if TASKS_SUPPORTED
                Async = settings.Async,
#endif
            };

            _xmlWriter = XmlWriter.Create(partStream, xmlWriterSettings);
        }

        #region public OpenXmlWriter methods

        /// <summary>
        /// Writes the XML declaration with the version "1.0".
        /// </summary>
        public override void WriteStartDocument()
        {
            ThrowIfObjectDisposed();

            _xmlWriter.WriteStartDocument();
        }

        /// <summary>
        /// Writes the XML declaration with the version "1.0" and the standalone attribute.
        /// </summary>
        /// <param name="standalone">If true, it writes "standalone=yes"; if false, it writes "standalone=no". </param>
        public override void WriteStartDocument(bool standalone)
        {
            ThrowIfObjectDisposed();

            _xmlWriter.WriteStartDocument(standalone);
        }

        /// <summary>
        /// Writes out a start element tag of the current element of the OpenXmlReader. And write all the attributes of the element.
        /// </summary>
        /// <param name="elementReader">The OpenXmlReader to read from. </param>
        public override void WriteStartElement(OpenXmlReader elementReader)
        {
            if (elementReader is null)
            {
                throw new ArgumentNullException(nameof(elementReader));
            }

            WriteStartElement(elementReader, elementReader.Attributes, elementReader.NamespaceDeclarations);
        }

        /// <summary>
        /// Writes out a start element tag of the current element of the OpenXmlReader. And write the attributes in attributes.
        /// </summary>
        /// <param name="elementReader">The OpenXmlReader to read from. </param>
        /// <param name="attributes">The attributes to be written, can be null if no attributes.</param>
        public override void WriteStartElement(OpenXmlReader elementReader, IEnumerable<OpenXmlAttribute> attributes)
        {
            if (elementReader is null)
            {
                throw new ArgumentNullException(nameof(elementReader));
            }

            WriteStartElement(elementReader, attributes, elementReader.NamespaceDeclarations);
        }

        /// <summary>
        /// Writes out a start element tag of the current element of the OpenXmlReader. And write the attributes in attributes.
        /// </summary>
        /// <param name="elementReader">The OpenXmlReader to read from. </param>
        /// <param name="attributes">The attributes to be written, can be null if no attributes.</param>
        /// <param name="namespaceDeclarations">The namespace declarations to be written, can be null if no namespace declarations.</param>
        public override void WriteStartElement(OpenXmlReader elementReader, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations)
        {
            if (elementReader is null)
            {
                throw new ArgumentNullException(nameof(elementReader));
            }

            if (elementReader.IsEndElement)
            {
                throw new ArgumentOutOfRangeException(nameof(elementReader));
            }

            if (elementReader.IsMiscNode)
            {
                // OpenXmlMiscNode should be written by WriteElement( );
                throw new ArgumentOutOfRangeException(nameof(elementReader));
            }

            ThrowIfObjectDisposed();

            _xmlWriter.WriteStartElement(elementReader.Prefix, elementReader.LocalName, elementReader.NamespaceUri);

            if (namespaceDeclarations is not null)
            {
                foreach (var item in namespaceDeclarations)
                {
                    _xmlWriter.WriteAttributeString(OpenXmlElementContext.XmlnsPrefix, item.Key, OpenXmlElementContext.XmlnsUri, item.Value);
                }
            }

            if (attributes is not null)
            {
                // write attributes
                foreach (var attribute in attributes)
                {
                    _xmlWriter.WriteAttributeString(attribute.Prefix, attribute.LocalName, attribute.NamespaceUri, attribute.Value);
                }
            }

            if (elementReader.ElementType.IsSubclassOf(typeof(OpenXmlLeafTextElement)))
            {
                _isLeafTextElementStart = true;
            }
            else
            {
                _isLeafTextElementStart = false;
            }
        }

        /// <summary>
        /// Writes out a start tag of the element and all the attributes of the element.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be written.</param>
        public override void WriteStartElement(OpenXmlElement elementObject)
        {
            if (elementObject is null)
            {
                throw new ArgumentNullException(nameof(elementObject));
            }

            if (elementObject is OpenXmlMiscNode)
            {
                throw new ArgumentOutOfRangeException(nameof(elementObject));
            }

            ThrowIfObjectDisposed();

            _xmlWriter.WriteStartElement(elementObject.Prefix, elementObject.LocalName, elementObject.NamespaceUri);

            if (elementObject.HasAttributes)
            {
                // write attributes
                foreach (var attribute in elementObject.GetAttributes())
                {
                    _xmlWriter.WriteAttributeString(attribute.Prefix, attribute.LocalName, attribute.NamespaceUri, attribute.Value);
                }
            }

            if (elementObject is OpenXmlLeafTextElement)
            {
                _isLeafTextElementStart = true;
            }
            else
            {
                _isLeafTextElementStart = false;
            }
        }

        /// <summary>
        /// Writes out a start tag of the element. And write the attributes in attributes. The attributes of the element will be omitted.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be written.</param>
        /// <param name="attributes">The attributes to be written.</param>
        public override void WriteStartElement(OpenXmlElement elementObject, IEnumerable<OpenXmlAttribute> attributes)
        {
            if (elementObject is null)
            {
                throw new ArgumentNullException(nameof(elementObject));
            }

            WriteStartElement(elementObject, attributes, elementObject.NamespaceDeclarations);
        }

        /// <summary>
        /// Writes out a start tag of the element. And write the attributes in attributes. The attributes of the element will be omitted.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be written.</param>
        /// <param name="attributes">The attributes to be written.</param>
        /// <param name="namespaceDeclarations">The namespace declarations to be written, can be null if no namespace declarations.</param>
        public override void WriteStartElement(OpenXmlElement elementObject, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations)
        {
            if (elementObject is null)
            {
                throw new ArgumentNullException(nameof(elementObject));
            }

            if (elementObject is OpenXmlMiscNode)
            {
                throw new ArgumentOutOfRangeException(nameof(elementObject));
            }

            ThrowIfObjectDisposed();

            _xmlWriter.WriteStartElement(elementObject.Prefix, elementObject.LocalName, elementObject.NamespaceUri);

            if (namespaceDeclarations is not null)
            {
                foreach (var item in namespaceDeclarations)
                {
                    _xmlWriter.WriteAttributeString(OpenXmlElementContext.XmlnsPrefix, item.Key, OpenXmlElementContext.XmlnsUri, item.Value);
                }
            }

            if (attributes is not null)
            {
                // write attributes
                foreach (var attribute in attributes)
                {
                    _xmlWriter.WriteAttributeString(attribute.Prefix, attribute.LocalName, attribute.NamespaceUri, attribute.Value);
                }
            }

            if (elementObject is OpenXmlLeafTextElement)
            {
                _isLeafTextElementStart = true;
            }
            else
            {
                _isLeafTextElementStart = false;
            }
        }

        /// <summary>
        /// Closes one element.
        /// </summary>
        public override void WriteEndElement()
        {
            ThrowIfObjectDisposed();

            _xmlWriter.WriteEndElement();

            _isLeafTextElementStart = false;
        }

        /// <summary>
        /// Writes the given text content.
        /// </summary>
        /// <param name="text">The text to be written. </param>
        public override void WriteString(string text)
        {
            ThrowIfObjectDisposed();

            if (_isLeafTextElementStart)
            {
                _xmlWriter.WriteString(text);
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
        /// <param name="elementObject">The OpenXmlElement object to be written.</param>
        public override void WriteElement(OpenXmlElement elementObject)
        {
            if (elementObject is null)
            {
                throw new ArgumentNullException(nameof(elementObject));
            }

            ThrowIfObjectDisposed();

            elementObject.WriteTo(_xmlWriter);

            _isLeafTextElementStart = false;
        }

        /// <summary>
        /// Close the writer.
        /// </summary>
        public override void Close()
        {
            if (_xmlWriter is not null)
            {
                _xmlWriter.Close();
            }

            _isLeafTextElementStart = false;
        }

        #endregion

        // Async Methods
#if TASKS_SUPPORTED
        /// <summary>
        /// Asynchronously writes the XML declaration with the version "1.0".
        /// </summary>
        public override Task WriteStartDocumentAsync()
        {
            ThrowIfObjectDisposed();

            return _xmlWriter.WriteStartDocumentAsync();
        }

        /// <summary>
        /// Asynchronously writes the XML declaration with the version "1.0" and the standalone attribute.
        /// </summary>
        /// <param name="standalone">If true, it writes "standalone=yes"; if false, it writes "standalone=no". </param>
        public override Task WriteStartDocumentAsync(bool standalone)
        {
            ThrowIfObjectDisposed();

            return _xmlWriter.WriteStartDocumentAsync(standalone);
        }

        /// <summary>
        /// Asynchronously writes out a start tag of the element and all the attributes of the element.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be written.</param>
        public async override Task WriteStartElementAsync(OpenXmlElement elementObject)
        {
            if (elementObject is null)
            {
                throw new ArgumentNullException(nameof(elementObject));
            }

            if (elementObject is OpenXmlMiscNode)
            {
                throw new ArgumentOutOfRangeException(nameof(elementObject));
            }

            ThrowIfObjectDisposed();

            await _xmlWriter.WriteStartElementAsync(elementObject.Prefix, elementObject.LocalName, elementObject.NamespaceUri).ConfigureAwait(true);

            if (elementObject.HasAttributes)
            {
                // write attributes
                foreach (var attribute in elementObject.GetAttributes())
                {
                    await _xmlWriter.WriteAttributeStringAsync(attribute.Prefix, attribute.LocalName, attribute.NamespaceUri, attribute.Value).ConfigureAwait(true);
                }
            }

            if (elementObject is OpenXmlLeafTextElement)
            {
                _isLeafTextElementStart = true;
            }
            else
            {
                _isLeafTextElementStart = false;
            }
        }

        /// <summary>
        /// Asynchronously writes out a start tag of the element. And write the attributes in attributes. The attributes of the element will be omitted.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be written.</param>
        /// <param name="attributes">The attributes to be written.</param>
        public override Task WriteStartElementAsync(OpenXmlElement elementObject, IEnumerable<OpenXmlAttribute> attributes)
        {
            if (elementObject is null)
            {
                throw new ArgumentNullException(nameof(elementObject));
            }

            return WriteStartElementAsync(elementObject, attributes, elementObject.NamespaceDeclarations);
        }

        /// <summary>
        /// Asynchronously writes out a start tag of the element. And write the attributes in attributes. The attributes of the element will be omitted.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be written.</param>
        /// <param name="attributes">The attributes to be written.</param>
        /// <param name="namespaceDeclarations">The namespace declarations to be written, can be null if no namespace declarations.</param>
        public async override Task WriteStartElementAsync(OpenXmlElement elementObject, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations)
        {
            if (elementObject is null)
            {
                throw new ArgumentNullException(nameof(elementObject));
            }

            if (elementObject is OpenXmlMiscNode)
            {
                throw new ArgumentOutOfRangeException(nameof(elementObject));
            }

            ThrowIfObjectDisposed();

            await _xmlWriter.WriteStartElementAsync(elementObject.Prefix, elementObject.LocalName, elementObject.NamespaceUri).ConfigureAwait(true);

            if (namespaceDeclarations is not null)
            {
                foreach (var item in namespaceDeclarations)
                {
                    await _xmlWriter.WriteAttributeStringAsync(OpenXmlElementContext.XmlnsPrefix, item.Key, OpenXmlElementContext.XmlnsUri, item.Value).ConfigureAwait(true);
                }
            }

            if (attributes is not null)
            {
                // write attributes
                foreach (var attribute in attributes)
                {
                    await _xmlWriter.WriteAttributeStringAsync(attribute.Prefix, attribute.LocalName, attribute.NamespaceUri, attribute.Value).ConfigureAwait(true);
                }
            }

            if (elementObject is OpenXmlLeafTextElement)
            {
                _isLeafTextElementStart = true;
            }
            else
            {
                _isLeafTextElementStart = false;
            }
        }

        /// <summary>
        /// Asynchronously closes one element.
        /// </summary>
        public override Task WriteEndElementAsync()
        {
            ThrowIfObjectDisposed();

            _isLeafTextElementStart = false;

            return _xmlWriter.WriteEndElementAsync();
        }

        /// <summary>
        /// Asynchronously writes the OpenXmlElement to the writer.
        /// </summary>
        /// <param name="elementObject">The OpenXmlElement object to be written.</param>
        public async override Task WriteElementAsync(OpenXmlElement elementObject)
        {
            if (elementObject is null)
            {
                throw new ArgumentNullException(nameof(elementObject));
            }

            ThrowIfObjectDisposed();

            await WriteStartElementAsync(elementObject).ConfigureAwait(true);

            await WriteEndElementAsync().ConfigureAwait(true);

            _isLeafTextElementStart = false;
        }

        /// <summary>
        /// Asynchronously writes the given text content.
        /// </summary>
        /// <param name="text">The text to be written. </param>
        public override Task WriteStringAsync(string text)
        {
            ThrowIfObjectDisposed();

            if (_isLeafTextElementStart)
            {
                return _xmlWriter.WriteStringAsync(text);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidWriteStringCall);
            }

            // can continue WriteStringAsync(), so don't set _isLeafTextElementStart to false.
        }
#endif
    }
}
