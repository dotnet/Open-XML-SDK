﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the Open XML part reader class.
    /// </summary>
    public class OpenXmlPartReader : OpenXmlReader
    {
        private readonly IRootElementFeature _rootElements;
        private readonly IOpenXmlNamespaceResolver _resolver;
        private readonly XmlReader _xmlReader;
        private readonly List<OpenXmlAttribute> _attributeList = new List<OpenXmlAttribute>();
        private readonly List<KeyValuePair<string, string>> _nsDecls = new List<KeyValuePair<string, string>>();
        private readonly Stack<OpenXmlElement> _elementStack = new Stack<OpenXmlElement>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly string? _encoding;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly bool? _standalone;

        private ElementState _elementState;

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartReader class using the supplied OpenXmlPart class.
        /// </summary>
        /// <param name="openXmlPart">The OpenXmlPart to read.</param>
        public OpenXmlPartReader(OpenXmlPart openXmlPart)
            : this(openXmlPart, options: default)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenXmlPartReader"/> class.
        /// </summary>
        /// <param name="openXmlPart">The <see cref="OpenXmlPart"/> to read.</param>
        /// <param name="options">Options on how to read the part.</param>
        public OpenXmlPartReader(OpenXmlPart openXmlPart, OpenXmlPartReaderOptions options)
            : this(GetPartStream(openXmlPart), openXmlPart.Features, options.UpdateForPart(openXmlPart))
        {
        }

        private static Stream GetPartStream(OpenXmlPart? openXmlPart)
        {
            if (openXmlPart is null)
            {
                throw new ArgumentNullException(nameof(openXmlPart));
            }

            return openXmlPart.GetStream(FileMode.Open);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartReader class using the supplied OpenXmlPart and Boolean values.
        /// </summary>
        /// <param name="openXmlPart">The OpenXmlPart to read.</param>
        /// <param name="readMiscNodes">Specify false to indicate to the reader to skip all miscellaneous nodes. The default value is false.</param>
        public OpenXmlPartReader(OpenXmlPart openXmlPart, bool readMiscNodes)
            : this(openXmlPart, new OpenXmlPartReaderOptions() { ReadMiscellaneousNodes = readMiscNodes })
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPartReader class using the supplied OpenXmlPart and Boolean values.
        /// </summary>
        /// <param name="openXmlPart">The OpenXmlPart to read.</param>
        /// <param name="readMiscNodes">Specify false to indicate to the reader to skip all miscellaneous nodes.</param>
        /// <param name="ignoreWhitespace">Specify true to indicate to the reader to ignore insignificant white space.</param>
        public OpenXmlPartReader(OpenXmlPart openXmlPart, bool readMiscNodes, bool ignoreWhitespace)
            : this(openXmlPart, new OpenXmlPartReaderOptions { ReadMiscellaneousNodes = readMiscNodes, IgnoreWhitespace = ignoreWhitespace })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenXmlPartReader"/> class.
        /// </summary>
        /// <param name="partStream">The stream for the part data.</param>
        /// <param name="features">A feature collection used to identify what parts and elements to create.</param>
        /// <param name="options">Options for how to read the <paramref name="partStream"/>.</param>
        public OpenXmlPartReader(Stream partStream, IFeatureCollection features, OpenXmlPartReaderOptions options)
            : base(options.ReadMiscellaneousNodes)
        {
            if (partStream is null)
            {
                throw new ArgumentNullException(nameof(partStream));
            }

            _resolver = features.GetRequired<IOpenXmlNamespaceResolver>();
            _rootElements = features.GetRequired<IRootElementFeature>();
            _xmlReader = CreateReader(partStream, options.CloseStream, options.MaxCharactersInPart, ignoreWhitespace: options.IgnoreWhitespace, out _standalone, out _encoding);
        }

        /// <summary>
        /// Gets the encoding of the XML file.
        /// </summary>
        /// <remarks>
        /// Returns null if encoding is not specified in the XML file.
        /// </remarks>
        public override string? Encoding
        {
            get
            {
                ThrowIfObjectDisposed();
                return _encoding;
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
                return _standalone;
            }
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

                if (_elementState == ElementState.Start ||
                    _elementState == ElementState.LeafStart)
                {
                    Debug.Assert(_elementStack.Count > 0);

                    return new ReadOnlyCollection<OpenXmlAttribute>(_attributeList);
                }
                else
                {
                    return Cached.ReadOnlyCollection<OpenXmlAttribute>();
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

                if (_elementState == ElementState.Start ||
                    _elementState == ElementState.LeafStart)
                {
                    Debug.Assert(_elementStack.Count > 0);

                    return _nsDecls;
                }
                else
                {
                    return Enumerable.Empty<KeyValuePair<string, string>>();
                }
            }
        }

        /// <inheritdoc/>
        public override Type ElementType
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();

                return _elementStack.Peek().GetType();
            }
        }

        /// <inheritdoc/>
        public override bool IsMiscNode
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();

                if (_elementState == ElementState.MiscNode)
                {
                    Debug.Assert(ElementType == typeof(OpenXmlMiscNode));
                    return true;
                }
                else
                {
                }

                return false;
            }
        }

        /// <inheritdoc/>
        public override bool IsStartElement
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();

                if (!IsMiscNode)
                {
                    if (_elementState == ElementState.Start || _elementState == ElementState.LeafStart)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        /// <inheritdoc/>
        public override bool IsEndElement
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();

                if (!IsMiscNode)
                {
                    if (_elementState == ElementState.End || _elementState == ElementState.LeafEnd
                        || _elementState == ElementState.LoadEnd)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        /// <inheritdoc/>
        public override int Depth
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();

                Debug.Assert(_elementStack.Count > 0);
                return _elementStack.Count - 1;  // depth of root element is 0
            }
        }

        /// <inheritdoc/>
        public override bool EOF
        {
            get
            {
                ThrowIfObjectDisposed();
                return _elementState == ElementState.EOF;
            }
        }

        /// <inheritdoc/>
        public override string LocalName
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();
                return _elementStack.Peek().LocalName;
            }
        }

        /// <inheritdoc/>
        public override string NamespaceUri
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();
                return _elementStack.Peek().NamespaceUri;
            }
        }

        /// <inheritdoc/>
        public override string Prefix
        {
            get
            {
                ThrowIfObjectDisposed();
                ThrowIfNull();
                ThrowIfEof();
                return _elementStack.Peek().Prefix;
            }
        }

        /// <inheritdoc/>
        public override bool Read()
        {
            ThrowIfObjectDisposed();
            bool result = MoveToNextElement();

            if (result && !ReadMiscNodes)
            {
                // skip miscellaneous node
                while (result && IsMiscNode)
                {
                    result = MoveToNextElement();
                }
            }

            return result;
        }

        /// <inheritdoc/>
        public override bool ReadFirstChild()
        {
            ThrowIfObjectDisposed();
            bool result = MoveToFirstChild();

            if (result && !ReadMiscNodes)
            {
                // skip miscellaneous node
                while (result && IsMiscNode)
                {
                    result = MoveToNextSibling();
                }
            }

            return result;
        }

        /// <inheritdoc/>
        public override bool ReadNextSibling()
        {
            ThrowIfObjectDisposed();
            bool result = MoveToNextSibling();

            if (result && !ReadMiscNodes)
            {
                // skip miscellaneous node
                while (result && IsMiscNode)
                {
                    result = MoveToNextSibling();
                }
            }

            return result;
        }

        /// <inheritdoc/>
        public override void Skip()
        {
            ThrowIfObjectDisposed();
            InnerSkip();

            if (!EOF && !ReadMiscNodes)
            {
                // skip miscellaneous node
                while (!EOF && IsMiscNode)
                {
                    InnerSkip();
                }
            }
        }

        /// <inheritdoc/>
        public override IXmlLineInfo GetLineInfo() => XmlLineInfo.Get(_xmlReader);

        #region private methods

        /// <summary>
        /// Moves to next element
        /// </summary>
        /// <returns>true if the next element was read successfully; false if there are no more elements to read. </returns>
        private bool MoveToNextElement()
        {
            switch (_elementState)
            {
                case ElementState.Null:
                    return ReadRoot();

                case ElementState.EOF:
                    return false;

                case ElementState.Start:
                    break;

                case ElementState.End:
                case ElementState.MiscNode:
                    // cursor is end element, pop stack
                    _elementStack.Pop();
                    if (_elementStack.Count == 0)
                    {
                        _elementState = ElementState.EOF;
                        return false;
                    }

                    break;

                case ElementState.LeafStart:
                    // cursor is leaf element start
                    // just change the state to element end
                    // do not move the cursor
                    _elementState = ElementState.LeafEnd;
                    return true;

                case ElementState.LeafEnd:
                case ElementState.LoadEnd:
                    // cursor is end element, pop stack
                    _elementStack.Pop();
                    if (_elementStack.Count == 0)
                    {
                        _elementState = ElementState.EOF;
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

            _elementState = ElementState.Null;

            if (_xmlReader.EOF || !_xmlReader.Read())
            {
                _elementState = ElementState.EOF;
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
            switch (_elementState)
            {
                case ElementState.EOF:
                    return false;

                case ElementState.Start:
                    if (!_xmlReader.Read())
                    {
                        // should can read.
                        Debug.Assert(false);
                        return false;
                    }

                    GetElementInformation();
                    if (_elementState == ElementState.End)
                    {
                        return false;
                    }

                    return true;

                case ElementState.LeafStart:
                    _elementState = ElementState.LeafEnd;
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
            Debug.Assert(_xmlReader is not null);

            if (_elementState == ElementState.EOF)
            {
                return false;
            }

            InnerSkip();

            if (_elementState == ElementState.EOF)
            {
                return false;
            }
            else if (_elementState == ElementState.End)
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
            switch (_elementState)
            {
                case ElementState.Null:
                    ThrowIfNull();
                    break;

                case ElementState.EOF:
                    return;

                case ElementState.Start:
                case ElementState.End:
                case ElementState.MiscNode:
                    _xmlReader.Skip();
                    _elementStack.Pop();
                    GetElementInformation();
                    return;

                case ElementState.LeafStart:
                    // no move, just process cursor
                    _elementStack.Pop();
                    GetElementInformation();
                    return;

                case ElementState.LeafEnd:
                case ElementState.LoadEnd:
                    // cursor is leaf element, pop stack, no move
                    _elementStack.Pop();
                    GetElementInformation();
                    return;

                default:
                    break;
            }

            return;
        }

        #endregion

        /// <inheritdoc/>
        public override OpenXmlElement? LoadCurrentElement()
        {
            ThrowIfObjectDisposed();
            OpenXmlElement element;

            switch (_elementState)
            {
                case ElementState.LeafStart:
                    element = _elementStack.Pop();
                    _elementStack.Push(element.CloneNode(true));

                    // stop at the end tag.
                    _elementState = ElementState.LoadEnd;
                    return element;

                case ElementState.Start:
                    element = _elementStack.Peek();
                    element.Load(_xmlReader, OpenXmlLoadMode.Full);

                    // stop at the end tag.
                    _elementState = ElementState.LoadEnd;
                    return element;

                case ElementState.MiscNode:
                    Debug.Assert(ReadMiscNodes);

                    element = _elementStack.Pop();
                    element.Load(_xmlReader, OpenXmlLoadMode.Full);

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

        /// <inheritdoc/>
        public override string GetText()
        {
            ThrowIfObjectDisposed();

            if (_elementState == ElementState.LeafStart && _elementStack.Peek() is OpenXmlLeafTextElement textElement)
            {
                return textElement.Text;
            }

            return string.Empty;
        }

        /// <inheritdoc/>
        public override void Close()
        {
            ThrowIfObjectDisposed();
            _elementState = ElementState.EOF;
            _elementStack.Clear();
            _attributeList.Clear();
            _nsDecls.Clear();
            _xmlReader.Close();
        }

        private XmlReader CreateReader(Stream partStream, bool closeInput, long maxCharactersInPart, bool ignoreWhitespace, out bool? standalone, out string? encoding)
        {
            var settings = new XmlReaderSettings
            {
                MaxCharactersInDocument = maxCharactersInPart,
                CloseInput = closeInput,
                IgnoreWhitespace = ignoreWhitespace,
#if NET35
                ProhibitDtd = true,
#else
                DtdProcessing = DtdProcessing.Prohibit,
#endif
            };

            var xmlReader = XmlConvertingReaderFactory.Create(partStream, _resolver, settings);

            xmlReader.Read();

            if (xmlReader.NodeType == XmlNodeType.XmlDeclaration)
            {
                encoding = xmlReader["encoding"];

                var standaloneRaw = xmlReader["standalone"];

                if (string.Equals("yes", standaloneRaw, StringComparison.Ordinal))
                {
                    standalone = true;
                }
                else if (string.Equals("no", standaloneRaw, StringComparison.Ordinal))
                {
                    standalone = false;
                }
                else
                {
                    standalone = null;
                }
            }
            else
            {
                encoding = null;
                standalone = null;
            }

            return xmlReader;
        }

        private bool ReadRoot()
        {
            Debug.Assert(_elementState == ElementState.Null);
            Debug.Assert(_elementStack.Count == 0);

            // TODO: should we take care of entity? <!DOCTYPE page [ <!ENTITY company "Microsoft"> ]>
            // TODO: is it OK that we skip all prologue ( DOCTYPE, Comment, PT ) ?
            _xmlReader.MoveToContent();

            while (!_xmlReader.EOF && _xmlReader.NodeType != XmlNodeType.Element)
            {
                _xmlReader.Skip();
            }

            if (_xmlReader.EOF || !_xmlReader.IsStartElement())
            {
                throw new InvalidDataException(ExceptionMessages.PartIsEmpty);
            }

            // create the root element object
            var rootElement = CreateElement(new(_xmlReader.NamespaceURI, _xmlReader.LocalName));

            if (rootElement is null)
            {
                throw new InvalidDataException(ExceptionMessages.PartUnknown);
            }

            _elementStack.Push(rootElement);

            LoadAttributes();

            if (_xmlReader.IsEmptyElement)
            {
                _elementState = ElementState.LeafStart;
                rootElement.Load(_xmlReader, OpenXmlLoadMode.Full);
            }
            else
            {
                _elementState = ElementState.Start;
            }

            return true;
        }

        private OpenXmlElement CreateElement(in OpenXmlQualifiedName qname)
        {
            if (_rootElements.TryCreate(qname, out var element))
            {
                return element;
            }

            // return unknown element instead of throw exception.
            return new OpenXmlUnknownElement(_xmlReader.Prefix, _xmlReader.LocalName, _xmlReader.NamespaceURI);
        }

        private void LoadAttributes()
        {
            _attributeList.Clear();
            _nsDecls.Clear();

            // read attributes
            if (_xmlReader.HasAttributes)
            {
                while (_xmlReader.MoveToNextAttribute())
                {
                    if (_xmlReader.Prefix == OpenXmlElementContext.XmlnsPrefix)
                    {
                        _nsDecls.Add(new KeyValuePair<string, string>(_xmlReader.LocalName, _xmlReader.Value));
                    }
                    else
                    {
                        _attributeList.Add(new OpenXmlAttribute(_xmlReader.Prefix, _xmlReader.LocalName, _xmlReader.NamespaceURI, _xmlReader.Value));
                    }
                }

                // Moves the reader back to the element node.
                _xmlReader.MoveToElement();
            }
        }

        private void GetElementInformation()
        {
            if (_xmlReader.EOF)
            {
                Debug.Assert(_elementStack.Count == 0);

                _elementState = ElementState.EOF;
                return;
            }

            Debug.Assert(_elementStack.Count > 0);

            OpenXmlElement element;
            switch (_xmlReader.NodeType)
            {
                case XmlNodeType.EndElement:
                    _elementState = ElementState.End;
                    break;

                case XmlNodeType.Element:
                    element = CreateChildElement();

                    LoadAttributes();

                    if (_xmlReader.IsEmptyElement)
                    {
                        _elementState = ElementState.LeafStart;
                        element.Load(_xmlReader, OpenXmlLoadMode.Full);
                    }
                    else if (element is OpenXmlLeafElement || element is OpenXmlLeafTextElement)
                    {
                        _elementState = ElementState.LeafStart;
                        element.Load(_xmlReader, OpenXmlLoadMode.Full);
                    }
                    else if (element is OpenXmlUnknownElement)
                    {
                        _elementState = ElementState.Start;
                    }
                    else
                    {
                        Debug.Assert(element is OpenXmlCompositeElement);
                        _elementState = ElementState.Start;
                    }

                    _elementStack.Push(element);
                    break;

                default:
                    // non element ( PI, Comment, Notation, XmlDeclaration )
                    element = CreateChildElement();
                    ((OpenXmlMiscNode)element).LoadOuterXml(_xmlReader);
                    _elementStack.Push(element);
                    _elementState = ElementState.MiscNode;
                    break;
            }
        }

        private OpenXmlElement CreateChildElement()
        {
            Debug.Assert(_elementStack.Count > 0);

            var element = _elementStack.Peek();

            // AlternateContent / Choice / Fallback needs special treatment
            // The ElementFactory( ) of the Choice / Fallback depends on the parent of AlternateContentChoice
            // TODO: find a better solution
            if (element is AlternateContentChoice || element is AlternateContentFallback)
            {
                if (_elementStack.Count > 2)
                {
                    OpenXmlElement topElement = _elementStack.Pop();
                    OpenXmlElement acElement = _elementStack.Pop();

                    OpenXmlElement parentsParent = _elementStack.Peek().CloneNode(false);

                    _elementStack.Push(acElement);
                    _elementStack.Push(topElement);

                    element = topElement.CloneNode(false);
                    acElement = new AlternateContent();
                    acElement.AppendChild(element);
                    parentsParent.AppendChild(acElement);
                }
            }

            return element.ElementFactory(_xmlReader);
        }

        private void ThrowIfNull()
        {
            if (_elementState == ElementState.Null)
            {
                throw new InvalidOperationException(ExceptionMessages.ReaderInNullState);
            }
        }

        private void ThrowIfEof()
        {
            if (_elementState == ElementState.EOF || _elementStack.Count <= 0)
            {
                throw new InvalidOperationException(ExceptionMessages.ReaderInEofState);
            }
        }
    }
}
