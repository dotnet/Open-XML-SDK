// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Hold expected children for error reporting.
    /// </summary>
    internal partial class ExpectedChildren
    {
        static partial void IncressInstanceCount();

        #region private fields

        private ICollection<int> _elementTypeIds;

        private ICollection<string> _xsdanyNamespaces;

        #endregion

        internal ExpectedChildren()
        {
            IncressInstanceCount();
        }

        /// <summary>
        /// Add ElementTypeId of the child.
        /// </summary>
        /// <param name="elementTypeId"></param>
        internal void Add(int elementTypeId)
        {
            // No lock, not safe for multi-thread
            if ( this._elementTypeIds == null )
            {
                this._elementTypeIds = new List<int>();
            }
            this._elementTypeIds.Add(elementTypeId);
        }

        /// <summary>
        /// Add namespace string of xsd:any child.
        /// </summary>
        /// <param name="namesapceForXsdany"></param>
        internal void Add(string namesapceForXsdany)
        {
            // No lock, not safe for multi-thread
            if (this._xsdanyNamespaces == null)
            {
                this._xsdanyNamespaces = new List<string>();
            }
            this._xsdanyNamespaces.Add(namesapceForXsdany);
        }

        /// <summary>
        /// Add all expected children from another ExpectedChildren.
        /// </summary>
        /// <param name="expectedChildren"></param>
        internal void Add(ExpectedChildren expectedChildren)
        {
            if (expectedChildren._elementTypeIds != null &&
                expectedChildren._elementTypeIds.Count > 0)
            {
                // No lock, not safe for multi-thread
                if (this._elementTypeIds == null)
                {
                    this._elementTypeIds = new List<int>();
                }

                foreach (var id in expectedChildren._elementTypeIds)
                {
                    this._elementTypeIds.Add(id);
                }
            }

            if (expectedChildren._xsdanyNamespaces != null &&
                expectedChildren._xsdanyNamespaces.Count > 0)
            {
                // No lock, not safe for multi-thread
                if (this._xsdanyNamespaces == null)
                {
                    this._xsdanyNamespaces = new List<string>();
                }

                foreach (var ns in expectedChildren._xsdanyNamespaces)
                {
                    this._xsdanyNamespaces.Add(ns);
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
                if (this._elementTypeIds != null)
                {
                    count = this._elementTypeIds.Count;
                }
                if (this._xsdanyNamespaces != null)
                {
                    count += this._xsdanyNamespaces.Count;
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

            if (this._elementTypeIds != null || this._xsdanyNamespaces != null)
            {
                Debug.Assert(this._elementTypeIds != null && this._elementTypeIds.Count > 0 ||
                             this._xsdanyNamespaces != null && this._xsdanyNamespaces.Count > 0);

                string expectedChildren = null;
                StringBuilder childrenNames = new StringBuilder();
                string separator = string.Empty;

                if (this._elementTypeIds != null)
                {
                    foreach (var childElement in parent.CreateChildrenElementsByIds(this._elementTypeIds))
                    {
                        childrenNames.Append(separator);
                        // <namespace:localname>, use InvariantCulture
                        childrenNames.Append(string.Format(CultureInfo.CurrentUICulture, ValidationResources.Fmt_ElementName, childElement.NamespaceUri, childElement.LocalName));

                        separator = ValidationResources.Fmt_ElementNameSeparator;
                    }
                }

                if (this._xsdanyNamespaces != null)
                {
                    foreach (var namespaceForXsdany in this._xsdanyNamespaces)
                    {
                        childrenNames.Append(separator);
                        childrenNames.Append(string.Format(CultureInfo.CurrentUICulture, ValidationResources.Fmt_AnyElementInNamespace, namespaceForXsdany));
                    }
                }

                expectedChildren = string.Format(CultureInfo.CurrentUICulture, ValidationResources.Fmt_ListOfPossibleElements, childrenNames.ToString());

                return expectedChildren;
            }

            return string.Empty;
        }

        internal void Clear()
        {
            if (this._elementTypeIds != null)
            {
                this._elementTypeIds.Clear();
            }

            if (this._xsdanyNamespaces != null)
            {
                this._xsdanyNamespaces.Clear();
            }
        }
    }
}
