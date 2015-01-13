// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the XmlPath - XPath like informaiton for OpenXmlElement.
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
        /// Initlizes a new instance of the XmlPath from the specified OpenXmlPart.
        /// </summary>
        /// <param name="part">The OpenXmlPart.</param>
        internal XmlPath(OpenXmlPart part)
        {
            Debug.Assert(part != null);
            this.PartUri = part.Uri;
        }

        private List<string> _namespacesDefinitions = new List<string>();

        /// <summary>
        /// Gets the namespaces definitions used in the XPath.
        /// </summary>
        public IList<string> NamespacesDefinitions
        {
            get
            {
                return this._namespacesDefinitions;
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
                // throw new ArgumentNullException("element");
            }

            XmlPath xmlPath = new XmlPath();
            
            xmlPath.PartUri = element.GetPartUri();

            Dictionary<string, string> namespaces = new Dictionary<string, string>();

            StringBuilder xpath = new StringBuilder("");

            BuildXPath(element, xpath, namespaces);

            xmlPath.XPath = xpath.ToString();

            StringBuilder nsString;

            foreach (var ns in namespaces)
            {
                nsString = new StringBuilder("");
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
