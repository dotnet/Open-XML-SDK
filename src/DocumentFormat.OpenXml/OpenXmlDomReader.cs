// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace DocumentFormat.OpenXml
{
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
            _elementStack = new Stack<OpenXmlElement>();
            _elementState = ElementState.Null;
        }

        private OpenXmlDomReader(bool readMiscNodes)
            : base(readMiscNodes)
        {
            _elementStack = new Stack<OpenXmlElement>();
            _elementState = ElementState.Null;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlDomReader class.
        /// </summary>
        /// <param name="openXmlElement">The OpenXmlElement to read.</param>
        public OpenXmlDomReader(OpenXmlElement openXmlElement) : this()
        {
            if (openXmlElement == null)
            {
                throw new ArgumentNullException(nameof(openXmlElement));
            }

            Init(openXmlElement);
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
                throw new ArgumentNullException(nameof(openXmlElement));
            }

            Init(openXmlElement);
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

                if (_elementState == ElementState.Start)
                {
                    Debug.Assert(_elementStack.Count > 0);

                    OpenXmlElement element = _elementStack.Peek();

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

                if (_elementState == ElementState.Start)
                {
                    Debug.Assert(_elementStack.Count > 0);

                    OpenXmlElement element = _elementStack.Peek();

                    return element.NamespaceDeclarations;
                }
                else
                {
                    return Enumerable.Empty<KeyValuePair<string, string>>();
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
                    if (_elementState == ElementState.End)
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

        #region private methods

        /// <summary>
        /// Move to next element
        /// </summary>
        /// <returns>true if the next element was read successfully; false if there are no more elements to read. </returns>
        private bool MoveToNextElement()
        {
            if (_elementState == ElementState.Null)
            {
                return ReadRoot();
            }

            OpenXmlElement element;

            switch (_elementState)
            {
                case ElementState.EOF:
                    return false;

                case ElementState.Start:
                    {
                        element = _elementStack.Peek();
                        if (element.HasChildren)
                        {
                            _elementStack.Push(element.FirstChild);
                            if (element.FirstChild is OpenXmlMiscNode)
                            {
                                _elementState = ElementState.MiscNode;
                            }
                            else
                            {
                                _elementState = ElementState.Start;
                            }
                        }
                        else
                        {
                            // at start state
                            _elementState = ElementState.End;
                        }
                    }

                    break;

                case ElementState.End:
                case ElementState.MiscNode:
                    {
                        // at end state, find next element
                        element = _elementStack.Pop();

                        if (_elementStack.Count > 0)
                        {
                            element = element.NextSibling();
                            if (element != null)
                            {
                                _elementStack.Push(element);

                                if (element is OpenXmlMiscNode)
                                {
                                    _elementState = ElementState.MiscNode;
                                }
                                else
                                {
                                    _elementState = ElementState.Start;
                                }
                            }
                            else
                            {
                                _elementState = ElementState.End;
                            }
                        }
                        else
                        {
                            Debug.Assert(element == _rootElement);

                            // no more elements
                            _elementState = ElementState.EOF;
                            return false;
                        }
                    }

                    break;

                default:
                    Debug.Assert(_elementState == ElementState.Start ||
                        _elementState == ElementState.End ||
                        _elementState == ElementState.EOF);
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

            if (_elementState != ElementState.Start)
            {
                return false;
            }

            OpenXmlElement element = _elementStack.Peek();
            if (element.HasChildren)
            {
                _elementStack.Push(element.FirstChild);
                if (element.FirstChild is OpenXmlMiscNode)
                {
                    _elementState = ElementState.MiscNode;
                }
                else
                {
                    _elementState = ElementState.Start;
                }

                return true;
            }
            else
            {
                _elementState = ElementState.End;
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
            if (_elementState == ElementState.EOF)
            {
                return false;
            }

            ThrowIfNull();

            if (_elementStack.Count == 0)
            {
                _elementState = ElementState.EOF;
                return false;
            }

            OpenXmlElement element = _elementStack.Pop();

            // Fix bug #253890, case: the element used to constructor this DOM reader is not root element ( aka. it has parents and siblings. )
            // the stack is empty means we should move to EOF.
            if (_elementStack.Count == 0)
            {
                _elementState = ElementState.EOF;
                return false;
            }

            element = element.NextSibling();
            if (element != null)
            {
                _elementStack.Push(element);
                if (element is OpenXmlMiscNode)
                {
                    _elementState = ElementState.MiscNode;
                }
                else
                {
                    _elementState = ElementState.Start;
                }

                return true;
            }
            else
            {
                if (_elementStack.Count > 0)
                {
                    _elementState = ElementState.End;
                }
                else
                {
                    // no more element, EOF
                    _elementState = ElementState.EOF;
                }

                return false;
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
                    return;

                case ElementState.EOF:
                    return;

                case ElementState.End:
                case ElementState.MiscNode:
                    MoveToNextElement();
                    return;

                case ElementState.Start:
                    MoveToNextSibling();
                    return;

                default:
                    Debug.Assert(_elementState == ElementState.Start ||
                        _elementState == ElementState.End ||
                        _elementState == ElementState.EOF);
                    return;
            }
        }

        #endregion

        /// <inheritdoc/>
        public override OpenXmlElement LoadCurrentElement()
        {
            // TODO: should we return a clone?
            // The user expect the element in the tree returned? Is this assumption correct?
            ThrowIfObjectDisposed();
            ThrowIfNull();
            ThrowIfEof();

            if (_elementState == ElementState.Start)
            {
                OpenXmlElement element = _elementStack.Peek();

                _elementState = ElementState.End;

                return element;
            }
            else if (_elementState == ElementState.MiscNode)
            {
                Debug.Assert(ReadMiscNodes);

                OpenXmlElement element = _elementStack.Peek();

                Skip();

                return element;
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.ReaderInEndState);
            }
        }

        /// <inheritdoc/>
        public override string GetText()
        {
            ThrowIfObjectDisposed();
            if (_elementState == ElementState.Start)
            {
                OpenXmlElement element = _elementStack.Peek();

                OpenXmlLeafTextElement textElement = element as OpenXmlLeafTextElement;

                if (textElement != null)
                {
                    return textElement.Text;
                }
            }

            return string.Empty;
        }

        /// <inheritdoc/>
        public override void Close()
        {
            ThrowIfObjectDisposed();
            _elementState = ElementState.EOF;
            _elementStack.Clear();
            _rootElement = null;
        }

        #region private methods

        private void Init(OpenXmlElement openXmlElement)
        {
            _rootElement = openXmlElement;
            _elementState = ElementState.Null;
        }

        private bool ReadRoot()
        {
            _elementStack.Push(_rootElement);
            if (_rootElement is OpenXmlMiscNode)
            {
                _elementState = ElementState.MiscNode;
            }
            else
            {
                _elementState = ElementState.Start;
            }

            return true;
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

        #endregion
    }
}
