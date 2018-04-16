// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the OpenXml loading context.
    /// </summary>
    public class OpenXmlElementContext
    {
        internal const string xmlnsUri = @"http://www.w3.org/2000/xmlns/";
        internal const string xmlnsPrefix = "xmlns";

        private MarkupCompatibilityProcessSettings _mcSettings;

        internal MarkupCompatibilityProcessSettings MCSettings
        {
            get
            {
                if (_mcSettings == null)
                {
                    _mcSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007.AndLater());
                }

                return _mcSettings;
            }

            set
            {
                _mcSettings = value;
            }
        }

        /// <summary>
        /// Gets the XmlReaderSettings to be used by internal XmlReader
        /// </summary>
        internal XmlReaderSettings XmlReaderSettings { get; }

        /// <summary>
        /// Gets or sets load mode
        /// </summary>
        internal OpenXmlLoadMode LoadMode { get; set; } = OpenXmlLoadMode.Full;

        /// <summary>
        /// Gets layers to be full populated, only effective when LoadMode==Lazy.
        /// Start from 0 (populate only the children layer). The magic number of 3
        /// is currently used, but could potentially be made into a public property
        /// so a user can control this
        /// </summary>
        internal static int LazySteps => 3;

        internal MCContext MCContext { get; }

        internal uint ACBlockLevel { get; set; }

        /// <summary>
        /// Initializes a new instance of the OpenXmlElementContext class.
        /// </summary>
        public OpenXmlElementContext()
        {
            MCContext = new MCContext();
            XmlReaderSettings = CreateDefaultXmlReaderSettings();
        }

        internal static XmlReaderSettings CreateDefaultXmlReaderSettings()
        {
            var nameTable = new NameTable();

            // load predefined namespace to nametable
            for (int i = 1; i < NamespaceIdMap.Count; i++)
            {
                nameTable.Add(NamespaceIdMap.GetNamespaceUri((byte)i));
            }

            nameTable.Add(xmlnsUri);

            return new XmlReaderSettings
            {
#if FEATURE_XML_PROHIBIT_DTD
                ProhibitDtd = true,
#else
                DtdProcessing = DtdProcessing.Prohibit,
#endif
                NameTable = new NameTable(),

                // Set IgnoreWhitespace to false for the SDK to handle the whitespace node type. We have to do this because
                // PPT does not use the preserve attribute (xml:space="preserve") for non-ignorable whitespace.
                IgnoreWhitespace = false,
            };
        }

        /// <summary>
        /// Determines whether the namespace uri equals @"http://www.w3.org/2000/xmlns/".
        /// </summary>
        /// <param name="nsUri">The namespace uri.</param>
        /// <returns>Returns true if nsUri equals @"http://www.w3.org/2000/xmlns/".</returns>
        internal bool IsXmlnsUri(string nsUri)
        {
            return string.Equals(XmlReaderSettings.NameTable.Get(nsUri), xmlnsUri, StringComparison.Ordinal);
        }

        /// <summary>
        /// Fires the ElementInserting event.
        /// </summary>
        /// <param name="element">The OpenXmlElement element to insert.</param>
        /// <param name="parent">The parent element.</param>
        internal void ElementInsertingEvent(OpenXmlElement element, OpenXmlElement parent)
        {
            ElementInserting?.Invoke(this, new ElementEventArgs(element, parent));
        }

        /// <summary>
        /// Fires the ElementInserted event.
        /// </summary>
        /// <param name="element">The inserted OpenXmlElement element.</param>
        /// <param name="parent">The parent element.</param>
        internal void ElementInsertedEvent(OpenXmlElement element, OpenXmlElement parent)
        {
            ElementInserted?.Invoke(this, new ElementEventArgs(element, parent));
        }

        /// <summary>
        /// Fires the ElementRemoving event.
        /// </summary>
        /// <param name="element">The OpenXmlElement element to remove.</param>
        /// <param name="parent">The parent element.</param>
        internal void ElementRemovingEvent(OpenXmlElement element, OpenXmlElement parent)
        {
            ElementRemoving?.Invoke(this, new ElementEventArgs(element, parent));
        }

        /// <summary>
        /// Fires the ElementRemoved event.
        /// </summary>
        /// <param name="element">The removed OpenXmlElement element.</param>
        /// <param name="parent">The parent element.</param>
        internal void ElementRemovedEvent(OpenXmlElement element, OpenXmlElement parent)
        {
            ElementRemoved?.Invoke(this, new ElementEventArgs(element, parent));
        }

        /// <summary>
        /// Occurs when an element is about to be inserted into the element hierarchy.
        /// </summary>
        public event EventHandler<ElementEventArgs> ElementInserting;

        /// <summary>
        /// Occurs when an element has been inserted into the element hierarchy.
        /// </summary>
        public event EventHandler<ElementEventArgs> ElementInserted;

        /// <summary>
        /// Occurs when an element is being removed from the element hierarchy.
        /// </summary>
        public event EventHandler<ElementEventArgs> ElementRemoving;

        /// <summary>
        /// Occurs when an element has been removed from the element hierarchy.
        /// </summary>
        public event EventHandler<ElementEventArgs> ElementRemoved;
    }
}
