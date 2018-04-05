// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines XPath like information for OpenXmlElement.
    /// </summary>
    [DebuggerDisplay("XPath={XPath}")]
    public class XmlPath
    {
        /// <summary>
        /// Initializes a new instance of the XmlPath.
        /// </summary>
        private XmlPath()
        {
        }

        /// <summary>
        /// Initializes a new instance of the XmlPath from the specified OpenXmlPart.
        /// </summary>
        /// <param name="part">The OpenXmlPart.</param>
        internal XmlPath(OpenXmlPart part)
        {
            Debug.Assert(part != null);
            PartUri = part.Uri;
        }

        private List<string> _namespacesDefinitions = new List<string>();

        /// <summary>
        /// Gets the namespaces definitions used in the XPath.
        /// </summary>
        public IList<string> NamespacesDefinitions
        {
            get
            {
                return _namespacesDefinitions;
            }
        }

        /// <summary>
        /// Gets the XPath string.
        /// </summary>
        public string XPath { get; private set; }

        /// <summary>
        /// Gets the internal URI of the part relative to the package root.
        /// </summary>
        public Uri PartUri { get; private set; }

        /// <summary>
        /// Gets XmlPath information of the specified OpenXmlElement.
        /// </summary>
        /// <param name="element">The OpenXmlElement.</param>
        /// <returns>XmlPath to this element from root element.</returns>
        internal static XmlPath GetXPath(OpenXmlElement element)
        {
            if (element == null)
            {
                return null;

                // throw new ArgumentNullException(nameof(element));
            }

            XmlPath xmlPath = new XmlPath();

            xmlPath.PartUri = element.GetPartUri();

            Dictionary<string, string> namespaces = new Dictionary<string, string>();

            StringBuilder xpath = new StringBuilder(string.Empty);

            BuildXPath(element, xpath, namespaces);

            xmlPath.XPath = xpath.ToString();

            StringBuilder nsString;

            foreach (var ns in namespaces)
            {
                nsString = new StringBuilder(string.Empty);
                nsString.Append("xmlns:");
                nsString.Append(ns.Key);
                nsString.Append("=\"");
                nsString.Append(ns.Value);
                nsString.Append("\"");
                xmlPath.NamespacesDefinitions.Add(nsString.ToString());
            }

            return xmlPath;
        }

        /// <summary>
        /// Build the xml XPath from the element recursively.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="xpath">The result XPath.</param>
        /// <param name="namespaces">The namespaces used in the XPath.</param>
        internal static void BuildXPath(OpenXmlElement element, StringBuilder xpath, Dictionary<string, string> namespaces)
        {
            if (element.Parent != null)
            {
                BuildXPath(element.Parent, xpath, namespaces);
            }

            xpath.Append("/");

            if (element is OpenXmlMiscNode)
            {
                xpath.Append(element.OuterXml);
            }
            else
            {
                Debug.Assert(!string.IsNullOrEmpty(element.LocalName));

                if (!string.IsNullOrEmpty(element.Prefix))
                {
                    if (!namespaces.ContainsKey(element.Prefix))
                    {
                        namespaces.Add(element.Prefix, element.NamespaceUri);
                    }

                    xpath.Append(element.Prefix);
                    xpath.Append(":");
                }
                else if (!string.IsNullOrEmpty(element.NamespaceUri))
                {
                    xpath.Append(element.NamespaceUri);
                    xpath.Append(":");
                }

                xpath.Append(element.LocalName);

                xpath.Append("[");
                xpath.Append(element.GetXPathIndex());
                xpath.Append("]");
            }
        }
    }
}
