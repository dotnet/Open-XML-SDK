// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// OpenXmlLoadMode - load mode, default is Lazy
    ///     Full - load all the OpenXmlElements recursively
    ///     Lazy (default) - load N layer descendant elements from the current element, lazy load (cache OuterXml) for others
    ///             default is populate 3 layers 
    /// </summary>
    internal enum OpenXmlLoadMode
    {
        /// <summary>
        /// Load all the OpenXmlElements recursively
        /// </summary>
        Full,

        /// <summary>
        /// Load only one layer element, cache OuterXml
        /// </summary>
        Lazy,

        ///// <summary>
        ///// Full populate the top N layers, and then lazy load others.
        ///// </summary>
        //TopLayers
    }

    /// <summary>
    /// Represents the OpenXml loading context.
    /// </summary>
    public class OpenXmlElementContext
    {
        #region const data

        internal const string xmlnsUri = @"http://www.w3.org/2000/xmlns/";
        internal const string xmlnsPrefix = "xmlns";

        #endregion

        #region data member

        private OpenXmlPart _ownerPart;

        // TODO: XmlNameTable, XmlParserContext, NamespaceManager
        private XmlNameTable _xmlNameTable;
        // private XmlNamespaceManager _xmlNamespaceManager;
        // private XmlParserContext _xmlParserContext;
        private XmlReaderSettings _xmlReaderSettings;

        private OpenXmlLoadMode _loadMode = OpenXmlLoadMode.Full;

        private int _lazySteps = 3;

        private EventHandler<ElementEventArgs> _onElementInserting;
        private EventHandler<ElementEventArgs> _onElementInserted;
        private EventHandler<ElementEventArgs> _onElementRemoving;
        private EventHandler<ElementEventArgs> _onElementRemoved;

        private MarkupCompatibilityProcessSettings _mcSettings;
        internal MarkupCompatibilityProcessSettings MCSettings 
        {
            get
            {
                if (_mcSettings == null)
                {
                    _mcSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013);
                }
                return _mcSettings;
            }
            set
            {
                _mcSettings = value;
            } 
        }
        #endregion

        internal OpenXmlPart OwnerPart
        {
            get { return _ownerPart; }
            set { _ownerPart = value; }
        }

        /// <summary>
        /// The XmlNameTable to be used by internal XmlReader
        /// </summary>
        private XmlNameTable XmlNameTable
        {
            get { return _xmlNameTable; }
            // set { _xmlNameTable = value; }
        }

        /// <summary>
        /// The XmlReaderSettings to be used by internal XmlReader
        /// </summary>
        internal XmlReaderSettings XmlReaderSettings
        {
            get { return _xmlReaderSettings; }
            set { _xmlReaderSettings = value; }
        }

        /// <summary>
        /// Load mode
        /// </summary>
        internal OpenXmlLoadMode LoadMode
        {
            get { return _loadMode; }
            set { _loadMode = value; }
        }

        /// <summary>
        /// Layers to be full populated, only effective when LoadMode==Lazy.
        /// Start from 0 (populate only the children layer).
        /// </summary>
        internal int LazySteps
        {
            get { return this._lazySteps; }
            set
            {
                if (value < 0)
                {
                    this._lazySteps = 0;
                }
                else
                {
                    this._lazySteps = value;
                }
            }
        }

        //public XmlNamespaceManager XmlNamespaceManager
        //{
        //    get { return _xmlNamespaceManager; }
        //    // set { _xmlNamespaceManager = value; }
        //}
        
        //public XmlParserContext XmlParserContext
        //{
        //    get { return _xmlParserContext; }
        //    //set { _xmlParserContext = value; }
        //}

        /// <summary>
        /// Initializes a new instance of the OpenXmlElementContext class.
        /// </summary>
        public OpenXmlElementContext()
        {
            // this._xmlParserContext = new XmlParserContext(
            this._xmlNameTable = new NameTable();
            MCContext = new MCContext();
            Init();
        }

        ///// <summary>
        ///// OpenXmlElementContext constructor
        ///// </summary>
        //public OpenXmlElementContext(OpenXmlPart ownerPart)
        //{
        //    this._ownerPart = ownerPart;
        //    // this._xmlParserContext = new XmlParserContext(
        //    this._xmlNameTable = new NameTable();
        //    Init();
        //}

        internal static XmlReaderSettings CreateDefaultXmlReaderSettings()
        {
            
            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit; // set true explicitly for security fix

            // init XmlReaderSettings
            xmlReaderSettings.NameTable = new NameTable();

            // O15:#3024890, Set IgnoreWhitespace to false for the SDK to handle the whitespace node type. We have to do this because
            // PPT does not use the preserve attribute (xml:space="preserve") for non-ignorable whitespaces. (See the bug for details.)
            xmlReaderSettings.IgnoreWhitespace = false;

            // load predifined namespace to nametable
            for (int i = 1; i < NamespaceIdMap.Count; i++)
            {
                xmlReaderSettings.NameTable.Add(NamespaceIdMap.GetNamespaceUri((byte)i));
            }
            xmlReaderSettings.NameTable.Add(xmlnsUri);

            return xmlReaderSettings;
        }

        /// <summary>
        /// Determines whether the namespace uri equals @"http://www.w3.org/2000/xmlns/".
        /// </summary>
        /// <param name="nsUri">The namespace uri.</param>
        /// <returns>Returns true if nsUri equals @"http://www.w3.org/2000/xmlns/".</returns>
        internal bool IsXmlnsUri(string nsUri)
        {
            return this._xmlNameTable.Get(nsUri) == xmlnsUri;
        }

        private void Init()
        {
            // load predifined namespace to nametable
            for (int i = 1; i < NamespaceIdMap.Count; i++)
            {
                this._xmlNameTable.Add(NamespaceIdMap.GetNamespaceUri( (byte)i ));
            }

            this._xmlNameTable.Add(xmlnsUri);

            // init XmlReaderSettings
            this.XmlReaderSettings = new XmlReaderSettings();
            this.XmlReaderSettings.NameTable = this.XmlNameTable;

            // O15:#3024890, Set IgnoreWhitespace to false for the SDK to handle the whitespace node type. We have to do this because
            // PPT does not use the preserve attribute (xml:space="preserve") for non-ignorable whitespaces. (See the bug for details.)
            this.XmlReaderSettings.IgnoreWhitespace = false;
        }

        #region Event mechanism

        /// <summary>
        /// Fires the ElementInserting event.
        /// </summary>
        /// <param name="element">The OpenXmlElement element to insert.</param>
        /// <param name="parent">The parent element.</param>
        internal void ElementInsertingEvent(OpenXmlElement element, OpenXmlElement parent)
        {
            if (this._onElementInserting != null)
            {
                this._onElementInserting(this, new ElementEventArgs(element, parent));
            }
        }

        /// <summary>
        /// Fires the ElementInserted event.
        /// </summary>
        /// <param name="element">The inserted OpenXmlElement element.</param>
        /// <param name="parent">The parent element.</param>
        internal void ElementInsertedEvent(OpenXmlElement element, OpenXmlElement parent)
        {
            if (this._onElementInserted != null)
            {
                this._onElementInserted(this, new ElementEventArgs(element, parent));
            }
        }

        /// <summary>
        /// Fires the ElementRemoving event.
        /// </summary>
        /// <param name="element">The OpenXmlElement element to remove.</param>
        /// <param name="parent">The parent element.</param>
        internal void ElementRemovingEvent(OpenXmlElement element, OpenXmlElement parent)
        {
            if (this._onElementRemoving != null)
            {
                this._onElementRemoving(this, new ElementEventArgs(element, parent));
            }
        }

        /// <summary>
        /// Fires the ElementRemoved event.
        /// </summary>
        /// <param name="element">The removed OpenXmlElement element.</param>
        /// <param name="parent">The parent element.</param>
        internal void ElementRemovedEvent(OpenXmlElement element, OpenXmlElement parent)
        {
            if (this._onElementRemoved != null)
            {
                this._onElementRemoved(this, new ElementEventArgs(element, parent));
            }
        }

        /// <summary>
        /// Occurs when an element is about to be inserted into the element hierarchy.
        /// </summary>
        public event EventHandler<ElementEventArgs> ElementInserting
        {
            add
            {
                this._onElementInserting = (EventHandler<ElementEventArgs>)Delegate.Combine(this._onElementInserting, value);
            }
            remove
            {
                this._onElementInserting = (EventHandler<ElementEventArgs>)Delegate.Remove(this._onElementInserting, value);
            }
        }

        /// <summary>
        /// Occurs when an element has been inserted into the element hierarchy.
        /// </summary>
        public event EventHandler<ElementEventArgs> ElementInserted
        {
            add
            {
                this._onElementInserted = (EventHandler<ElementEventArgs>)Delegate.Combine(this._onElementInserted, value);
            }
            remove
            {
                this._onElementInserted = (EventHandler<ElementEventArgs>)Delegate.Remove(this._onElementInserted, value);
            }
        }

        /// <summary>
        /// Occurs when an element is being removed from the element hierarchy.
        /// </summary>
        public event EventHandler<ElementEventArgs> ElementRemoving
        {
            add
            {
                this._onElementRemoving = (EventHandler<ElementEventArgs>)Delegate.Combine(this._onElementRemoving, value);
            }
            remove
            {
                this._onElementRemoving = (EventHandler<ElementEventArgs>)Delegate.Remove(this._onElementRemoving, value);
            }
        }

        /// <summary>
        /// Occurs when an element has been removed from the element hierarchy.
        /// </summary>
        public event EventHandler<ElementEventArgs> ElementRemoved
        {
            add
            {
                this._onElementRemoved = (EventHandler<ElementEventArgs>)Delegate.Combine(this._onElementRemoved, value);
            }
            remove
            {
                this._onElementRemoved = (EventHandler<ElementEventArgs>)Delegate.Remove(this._onElementRemoved, value);
            }
        }

        #endregion

        internal MCContext MCContext { get; set; }

        internal uint ACBlockLevel { get; set; }
    }

    /// <summary>
    /// Represents arguments for element events.
    /// </summary>
    public class ElementEventArgs : EventArgs
    {
        private OpenXmlElement _element;
        private OpenXmlElement _parentElement;

        /// <summary>
        /// Initializes a new instance of the ElementEventArgs class using the
        ///  supplied elements.
        /// </summary>
        /// <param name="element">
        /// The element that caused the event.
        /// </param>
        /// <param name="parentElement">
        /// The parent element of the element that caused the event.
        /// </param>
        public ElementEventArgs(OpenXmlElement element, OpenXmlElement parentElement)
        {
            this._element = element;
            this._parentElement = parentElement;
        }

        /// <summary>
        /// Gets the element that caused the event.
        /// </summary>
        public OpenXmlElement Element
        {
            get { return this._element; }
        }

        /// <summary>
        /// Gets the parent element of the element that caused the event.
        /// </summary>
        public OpenXmlElement ParentElement
        {
            get { return this._parentElement; }
        }
    }

}
