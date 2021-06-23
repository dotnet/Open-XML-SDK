// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Provides information about a concrete OpenXmlPart.
    /// </summary>
    public class OpenXmlPartInfo
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="openXmlPartType">A subtype of <see cref="OpenXmlPart" />.</param>
        /// <param name="openXmlPartRootElementType">A subtype of <see cref="OpenXmlPartRootElement" />.</param>
        /// <param name="rootName">The root element's <see cref="XName" />.</param>
        /// <param name="rootNamespacePrefix">The root element's namespace prefix.</param>
        internal OpenXmlPartInfo(
            Type openXmlPartType,
            Type openXmlPartRootElementType,
            XName rootName,
            string rootNamespacePrefix)
        {
            if (!openXmlPartType.IsAssignableTo(typeof(OpenXmlPart)))
            {
                throw new ArgumentException(
                    $@"Invalid type: {openXmlPartType.FullName}",
                    nameof(openXmlPartType));
            }

            if (!openXmlPartRootElementType.IsAssignableTo(typeof(OpenXmlPartRootElement)))
            {
                throw new ArgumentException(
                    $@"Invalid type: {openXmlPartRootElementType.FullName}",
                    nameof(openXmlPartRootElementType));
            }

            OpenXmlPartType = openXmlPartType;
            OpenXmlPartRootElementType = openXmlPartRootElementType;
            RootName = rootName;
            RootNamespacePrefix = rootNamespacePrefix;

            RootNamespaceAttribute = new XAttribute(XNamespace.Xmlns + RootNamespacePrefix, RootName.NamespaceName);
        }

        /// <summary>
        /// Gets the <see cref="Type" /> of the <see cref="OpenXmlPart" /> (e.g.,
        /// typeof(MainDocumentPart)).
        /// </summary>
        public Type OpenXmlPartType { get; }

        /// <summary>
        /// Gets the concrete <see cref="Type" /> of the <see cref="OpenXmlPart" />'s
        /// <see cref="OpenXmlPartRootElement" /> (e.g., typeof(Document)).
        /// </summary>
        public Type OpenXmlPartRootElementType { get; }

        /// <summary>
        /// Gets the <see cref="OpenXmlPartRootElement" />'s qualified name (e.g.,
        /// "{http://schemas.openxmlformats.org/wordprocessingml/2006/main}document")
        /// </summary>
        public XName RootName { get; }

        /// <summary>
        /// Gets the <see cref="OpenXmlPartRootElement" />'s namespace prefix (e.g., "w").
        /// </summary>
        public string RootNamespacePrefix { get; }

        /// <summary>
        /// Gets the <see cref="OpenXmlPartRootElement" />'s namespace attribute
        /// (e.g., 'xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main"').
        /// </summary>
        public XAttribute RootNamespaceAttribute { get; }
    }
}
