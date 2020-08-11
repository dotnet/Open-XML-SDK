// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines XPath like information for OpenXmlElement.
    /// </summary>
    [DebuggerDisplay("{XPath,nq}")]
    public class XmlPath
    {
        /// <summary>
        /// Initializes a new instance of the XmlPath.
        /// </summary>
        internal XmlPath(OpenXmlElement element)
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            PartUri = element.GetPartUri();

            XPath = TryBuildXPath(GetElements(element), out var namespaces);

#pragma warning disable CS0618 // Type or member is obsolete
            if (namespaces == null)
            {
                Namespaces = ReadOnlyWrapper.Instance;
                NamespacesDefinitions = Cached.Array<string>();
            }
            else
            {
                NamespacesDefinitions = namespaces
                    .GetNamespacesInScope(XmlNamespaceScope.Local)
                    .Select(ns => $"xmlns:{ns.Key}=\"{ns.Value}\"")
                    .ToArray();
                Namespaces = new ReadOnlyWrapper(namespaces);
            }
#pragma warning restore CS0618 // Type or member is obsolete
        }

        /// <summary>
        /// Initializes a new instance of the XmlPath from the specified OpenXmlPart.
        /// </summary>
        /// <param name="part">The OpenXmlPart.</param>
        internal XmlPath(OpenXmlPart part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            PartUri = part.Uri;
        }

        /// <summary>
        /// Gets the namespace definitions used in <see cref="XPath"/>. Use <see cref="Namespaces"/> instead
        /// </summary>
        [Obsolete("Use the Namespaces property instead")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public IList<string> NamespacesDefinitions { get; }

        /// <summary>
        /// Gets the namespace definitions used in <see cref="XPath"/>
        /// </summary>
        public IXmlNamespaceResolver Namespaces { get; }

        /// <summary>
        /// Gets the XPath string.
        /// </summary>
        public string XPath { get; }

        /// <summary>
        /// Gets the internal URI of the part relative to the package root.
        /// </summary>
        public Uri PartUri { get; }

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
            }

            return new XmlPath(element);
        }

        internal static XmlPath GetXPath(OpenXmlPart part)
        {
            if (part == null)
            {
                return null;
            }

            return new XmlPath(part);
        }

        private static string TryBuildXPath(Stack<OpenXmlElement> elements, out XmlNamespaceManager namespaces)
        {
            if (elements.Count == 0)
            {
                namespaces = null;
                return string.Empty;
            }

            var xpath = new StringBuilder();
            namespaces = new XmlNamespaceManager(new NameTable());

            foreach (var element in elements)
            {
                xpath.Append('/');

                if (element is OpenXmlMiscNode)
                {
                    xpath.Append(element.OuterXml);
                }
                else
                {
                    Debug.Assert(!string.IsNullOrEmpty(element.LocalName));

                    if (!string.IsNullOrEmpty(element.Prefix))
                    {
                        if (!namespaces.HasNamespace(element.Prefix))
                        {
                            namespaces.AddNamespace(element.Prefix, element.NamespaceUri);
                        }

                        xpath.Append(element.Prefix);
                        xpath.Append(':');
                    }
                    else if (!string.IsNullOrEmpty(element.NamespaceUri))
                    {
                        xpath.Append(element.NamespaceUri);
                        xpath.Append(':');
                    }

                    xpath.Append(element.LocalName);

                    xpath.Append('[');
                    xpath.Append(element.GetXPathIndex());
                    xpath.Append(']');
                }
            }

            return xpath.ToString();
        }

        private static Stack<OpenXmlElement> GetElements(OpenXmlElement element)
        {
            var elements = new Stack<OpenXmlElement>();

            while (element != null)
            {
                elements.Push(element);
                element = element.Parent;
            }

            return elements;
        }

        private class ReadOnlyWrapper : IXmlNamespaceResolver
        {
            private readonly IXmlNamespaceResolver _other;

            public static IXmlNamespaceResolver Instance { get; } = new ReadOnlyWrapper(new XmlNamespaceManager(new NameTable()));

            public ReadOnlyWrapper(IXmlNamespaceResolver other)
            {
                _other = other;
            }

            public IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) => _other.GetNamespacesInScope(scope);

            public string LookupNamespace(string prefix) => _other.LookupNamespace(prefix);

            public string LookupPrefix(string namespaceName) => _other.LookupPrefix(namespaceName);
        }
    }
}
