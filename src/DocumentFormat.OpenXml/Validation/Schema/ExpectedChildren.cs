// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
        private List<Type> _elementTypes;
        private List<string> _xsdanyNamespaces;

        /// <summary>
        /// Add a known element of the child.
        /// </summary>
        /// <param name="elementType"></param>
        public void Add(Type elementType)
        {
            // No lock, not safe for multi-thread
            if (_elementTypes == null)
            {
                _elementTypes = new List<Type>();
            }

            _elementTypes.Add(elementType);
        }

        /// <summary>
        /// Add namespace string of xsd:any child.
        /// </summary>
        /// <param name="namesapceForXsdany"></param>
        public void Add(string namesapceForXsdany)
        {
            // No lock, not safe for multi-thread
            if (_xsdanyNamespaces == null)
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
            if (expectedChildren._elementTypes != null &&
                expectedChildren._elementTypes.Count > 0)
            {
                // No lock, not safe for multi-thread
                if (_elementTypes == null)
                {
                    _elementTypes = new List<Type>();
                }

                foreach (var id in expectedChildren._elementTypes)
                {
                    _elementTypes.Add(id);
                }
            }

            if (expectedChildren._xsdanyNamespaces != null &&
                expectedChildren._xsdanyNamespaces.Count > 0)
            {
                // No lock, not safe for multi-thread
                if (_xsdanyNamespaces == null)
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
                if (_elementTypes != null)
                {
                    count = _elementTypes.Count;
                }

                if (_xsdanyNamespaces != null)
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
        internal string GetExpectedChildrenMessage(OpenXmlElement parent)
        {
            Debug.Assert(parent != null);

            if (_elementTypes != null || _xsdanyNamespaces != null)
            {
                Debug.Assert(_elementTypes != null && _elementTypes.Count > 0 ||
                             _xsdanyNamespaces != null && _xsdanyNamespaces.Count > 0);

                var childrenNames = new List<string>();

                if (_elementTypes != null)
                {
                    foreach (var childElement in parent.Metadata.Children.Elements)
                    {
                        if (_elementTypes.Contains(childElement.Type))
                        {
                            // <namespace:localname>, use InvariantCulture
                            childrenNames.Add(SR.Format(ValidationResources.Fmt_ElementName, childElement.Namespace, childElement.Name));
                        }
                    }
                }

                if (_xsdanyNamespaces != null)
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
            if (_elementTypes != null)
            {
                _elementTypes.Clear();
            }

            if (_xsdanyNamespaces != null)
            {
                _xsdanyNamespaces.Clear();
            }
        }
    }
}
