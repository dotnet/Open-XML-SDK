﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
        /// Initializes a new instance of the <see cref="XmlPath"/> from
        /// the specified <see cref="OpenXmlElement"/>.
        /// </summary>
        /// <param name="element">
        /// The <see cref="OpenXmlElement"/>.
        /// </param>
        public XmlPath(OpenXmlElement element)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            PartUri = element.GetPartUri();
            XPath = TryBuildXPath(GetElements(element), out var namespaces);

            if (namespaces is null)
            {
                Namespaces = ReadOnlyWrapper.Instance;
            }
            else
            {
                Namespaces = new ReadOnlyWrapper(namespaces);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XmlPath"/> from
        /// the specified <see cref="OpenXmlPart"/>.
        /// </summary>
        /// <param name="part">The <see cref="OpenXmlPart"/>.</param>
        public XmlPath(OpenXmlPart part)
        {
            if (part is null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            PartUri = part.Uri;
            XPath = string.Empty;

            Namespaces = ReadOnlyWrapper.Instance;
        }

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
        public Uri? PartUri { get; }

        /// <summary>
        /// Gets XmlPath information of the specified OpenXmlElement.
        /// </summary>
        /// <param name="element">The OpenXmlElement.</param>
        /// <returns>XmlPath to this element from root element.</returns>
        internal static XmlPath? GetXPath(OpenXmlElement? element)
        {
            if (element is null)
            {
                return null;
            }

            return new XmlPath(element);
        }

        internal static XmlPath? GetXPath(OpenXmlPart? part)
        {
            if (part is null)
            {
                return null;
            }

            return new XmlPath(part);
        }

        private static string TryBuildXPath(Stack<OpenXmlElement> elements, [MaybeNullWhen(false)] out XmlNamespaceManager namespaces)
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

        private static Stack<OpenXmlElement> GetElements(OpenXmlElement? element)
        {
            var elements = new Stack<OpenXmlElement>();

            while (element is not null)
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

            public string? LookupNamespace(string prefix) => _other.LookupNamespace(prefix);

            public string? LookupPrefix(string namespaceName) => _other.LookupPrefix(namespaceName);
        }
    }
}
