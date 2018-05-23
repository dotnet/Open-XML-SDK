﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the mc:AlternateContent element of markup
    /// compatibility.
    /// </summary>
    public class AlternateContent : OpenXmlCompositeElement
    {
        private static string _mcNamespace = @"http://schemas.openxmlformats.org/markup-compatibility/2006";
        private static byte _mcNamespaceId = byte.MaxValue;

        private static string tagName = "AlternateContent";

        /// <summary>
        /// Initializes a new instance of the AlternateContent
        /// class.
        /// </summary>
        public AlternateContent()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AlternateContent
        /// class by using the supplied IEnumerable elements.
        /// </summary>
        /// <param name="childElements">
        /// Represents all child elements.
        /// </param>
        public AlternateContent(IEnumerable<OpenXmlElement> childElements)
            : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AlternateContent
        /// class by using the supplied OpenXmlElement elements.
        /// </summary>
        /// <param name="childElements">
        /// Represents all child elements.
        /// </param>
        public AlternateContent(params OpenXmlElement[] childElements)
            : base(childElements)
        {
        }

        /// <param name="outerXml">The outer XML of the element.
        /// </param>
        /// <summary>
        /// Initializes a new instance of the AlternateContent
        /// class by using the supplied string.
        /// </summary>
        public AlternateContent(string outerXml)
            : base(outerXml)
        {
        }

        /// <summary>
        /// Gets a value that represents the markup compatibility
        /// namespace.
        /// </summary>
        public static string MarkupCompatibilityNamespace
        {
            get { return _mcNamespace; }
        }

        /// <summary>
        /// Gets a value that represents the markup compatibility
        /// namespace ID.
        /// </summary>
        public static byte MarkupCompatibilityNamespaceId
        {
            get
            {
                if (_mcNamespaceId == byte.MaxValue)
                {
                    _mcNamespaceId = NamespaceIdMap.GetNamespaceId(_mcNamespace);
                }

                return _mcNamespaceId;
            }
        }

        /// <summary>
        /// Gets a value that represents the tag name of the
        /// AlternateContent element.
        /// </summary>
        public static string TagName
        {
            get { return tagName; }
        }

        /// <inheritdoc/>
        public override string LocalName
        {
            get { return tagName; }
        }

        /// <inheritdoc/>
        internal override byte NamespaceId
        {
            get { return MarkupCompatibilityNamespaceId; }
        }

        private static string[] attributeTagNames = Cached.Array<string>();
        private static byte[] attributeNamespaceIds = Cached.Array<byte>();

        /// <inheritdoc/>
        internal override string[] AttributeTagNames
        {
            get
            {
                return attributeTagNames;
            }
        }

        /// <inheritdoc/>
        internal override byte[] AttributeNamespaceIds
        {
            get
            {
                return attributeNamespaceIds;
            }
        }

        /// <inheritdoc/>
        internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
        {
            if (MarkupCompatibilityNamespaceId == namespaceId && AlternateContentChoice.TagName == name)
                return new AlternateContentChoice();

            if (MarkupCompatibilityNamespaceId == namespaceId && AlternateContentFallback.TagName == name)
                return new AlternateContentFallback();

            return null;
        }

        /// <summary>
        /// Appends a new child of type T:DocumentFormat.OpenXml.AlternateContentChoice
        ///  to the current element.
        /// </summary>
        /// <returns>
        /// </returns>
        public AlternateContentChoice AppendNewAlternateContentChoice()
        {
            AlternateContentChoice child = new AlternateContentChoice();
            AppendChild(child);
            return child;
        }

        /// <summary>
        /// Appends a new child of type T:DocumentFormat.OpenXml.AlternateContentFallback
        ///  to the current element.
        /// </summary>
        /// <returns>
        /// </returns>
        public AlternateContentFallback AppendNewAlternateContentFallback()
        {
            AlternateContentFallback child = new AlternateContentFallback();
            AppendChild(child);
            return child;
        }

        /// <inheritdoc/>
        internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
        {
            return null;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep)
        {
            return CloneImp<AlternateContent>(deep);
        }

        /// <inheritdoc/>
        internal override int ElementTypeId
        {
            get { return ReservedElementTypeIds.AlternateContentId; }
        }

        internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    }
}
