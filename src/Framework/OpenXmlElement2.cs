// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Globalization;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents a base class for all elements in an Office Open XML document.
    /// </summary>
    /// <remarks>
    /// Annotations will not be cloned when calling .Clone() and .CloneNode(bool).
    /// </remarks>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    public abstract partial class OpenXmlElement : IEnumerable<OpenXmlElement>, ICloneable
    {
        /// <summary>
        /// Returns the next sibling element that is not an OpenXmlMiscNode element.
        /// </summary>
        /// <returns>The next sibling element that is not an OpenXmlMiscNode element.</returns>
        internal OpenXmlElement GetNextNonMiscElementSibling()
        {
            var next = this.NextSibling();

            while (next != null && next is OpenXmlMiscNode)
            {
                next = next.NextSibling();
            }

            return next;
        }

        /// <summary>
        /// Returns the first child element that is not an OpenXmlMiscNode element.
        /// </summary>
        /// <returns>The first child element that is not an OpenXmlMiscNode element.</returns>
        internal OpenXmlElement GetFirstNonMiscElementChild()
        {
            Debug.Assert(this is OpenXmlCompositeElement);

            var element = this.FirstChild;

            if (element is OpenXmlMiscNode)
            {
                return element.GetNextNonMiscElementSibling();
            }
            else
            {
                return element;
            }
        }

        /// <summary>
        /// Gets the root element of the current OpenXmlElement element.
        /// </summary>
        /// <returns>
        /// Returns the root element if it is an OpenXmlPartRootElement element. Returns the current element if it is an OpenXmlPartRootElement element.
        /// Returns null (Nothing in Visual Basic) if the current element has no parent or the root element is not an OpenXmlPartRootElement element.
        /// </returns>
        internal OpenXmlPartRootElement GetPartRootElement()
        {
            var root = this;

            while (root.Parent != null)
            {
                root = root.Parent;
            }

            var partRootElement = root as OpenXmlPartRootElement;

            return partRootElement;
        }
    }
}
