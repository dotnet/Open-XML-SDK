// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Hold expected children for error reporting.
    /// </summary>
    internal class ExpectedChildren
    {
        private List<OpenXmlSchemaType>? _elements;
        private List<string>? _xsdanyNamespaces;

        /// <summary>
        /// Add a known element of the child.
        /// </summary>
        /// <param name="type"></param>
        public void Add(OpenXmlSchemaType type)
        {
            // No lock, not safe for multi-thread
            if (_elements is null)
            {
                _elements = [];
            }

            _elements.Add(type);
        }

        /// <summary>
        /// Add namespace string of xsd:any child.
        /// </summary>
        /// <param name="namesapceForXsdany"></param>
        public void Add(string namesapceForXsdany)
        {
            // No lock, not safe for multi-thread
            if (_xsdanyNamespaces is null)
            {
                _xsdanyNamespaces = new List<string>();
            }

            _xsdanyNamespaces.Add(namesapceForXsdany);
        }

        /// <summary>
        /// Add all expected children from another ExpectedChildren.
        /// </summary>
        /// <param name="expectedChildren"></param>
        internal void Add(ExpectedChildren expectedChildren)
        {
            if (expectedChildren._elements is not null &&
                expectedChildren._elements.Count > 0)
            {
                // No lock, not safe for multi-thread
                if (_elements is null)
                {
                    _elements = [];
                }

                foreach (var id in expectedChildren._elements)
                {
                    _elements.Add(id);
                }
            }

            if (expectedChildren._xsdanyNamespaces is not null &&
                expectedChildren._xsdanyNamespaces.Count > 0)
            {
                // No lock, not safe for multi-thread
                if (_xsdanyNamespaces is null)
                {
                    _xsdanyNamespaces = new List<string>();
                }

                foreach (var ns in expectedChildren._xsdanyNamespaces)
                {
                    _xsdanyNamespaces.Add(ns);
                }
            }
        }

        /// <summary>
        /// Gets the count of required children elements.
        /// </summary>
        internal int Count
        {
            get
            {
                int count = 0;
                if (_elements is not null)
                {
                    count = _elements.Count;
                }

                if (_xsdanyNamespaces is not null)
                {
                    count += _xsdanyNamespaces.Count;
                }

                return count;
            }
        }

        /// <summary>
        /// Returns the list of expected children message used in error reporting.
        /// </summary>
        /// <param name="parent">The parent element. Used to map ElementTypeId to element name for child element.</param>
        /// <returns>The Fmt_ListOfPossibleElements sub string to be used in error reporting.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1508:Avoid dead conditional code", Justification = "Needs refactoring")]
        internal string GetExpectedChildrenMessage(OpenXmlElement parent)
        {
            if (_elements is not null || _xsdanyNamespaces is not null)
            {
                Debug.Assert((_elements is not null && _elements.Count > 0) || (_xsdanyNamespaces is not null && _xsdanyNamespaces.Count > 0));

                var childrenNames = new List<string>();

                if (_elements is not null)
                {
                    foreach (var child in parent.Metadata.Children.Elements)
                    {
                        if (_elements.Contains(child.Type))
                        {
                            // <namespace:localname>, use InvariantCulture
                            childrenNames.Add(SR.Format(ValidationResources.Fmt_ElementName, child.Type.Name.Namespace.Uri, child.Type.Name.Name));
                        }
                    }
                }

                if (_xsdanyNamespaces is not null)
                {
                    foreach (var namespaceForXsdany in _xsdanyNamespaces)
                    {
                        childrenNames.Add(SR.Format(ValidationResources.Fmt_AnyElementInNamespace, namespaceForXsdany));
                    }
                }

#if NET35
                var final = childrenNames.ToArray();
#else
                var final = childrenNames;
#endif

                return SR.Format(ValidationResources.Fmt_ListOfPossibleElements, string.Join(ValidationResources.Fmt_ElementNameSeparator, final));
            }

            return string.Empty;
        }

        internal void Clear()
        {
            if (_elements is not null)
            {
                _elements.Clear();
            }

            if (_xsdanyNamespaces is not null)
            {
                _xsdanyNamespaces.Clear();
            }
        }
    }
}
