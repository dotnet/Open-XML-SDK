// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents arguments for element events.
    /// </summary>
    public class ElementEventArgs : EventArgs
    {
        private OpenXmlElement _element;
        private OpenXmlElement _parentElement;

        /// <summary>
        /// Initializes a new instance of the ElementEventArgs class using the
        ///  supplied elements.
        /// </summary>
        /// <param name="element">
        /// The element that caused the event.
        /// </param>
        /// <param name="parentElement">
        /// The parent element of the element that caused the event.
        /// </param>
        public ElementEventArgs(OpenXmlElement element, OpenXmlElement parentElement)
        {
            _element = element;
            _parentElement = parentElement;
        }

        /// <summary>
        /// Gets the element that caused the event.
        /// </summary>
        public OpenXmlElement Element
        {
            get { return _element; }
        }

        /// <summary>
        /// Gets the parent element of the element that caused the event.
        /// </summary>
        public OpenXmlElement ParentElement
        {
            get { return _parentElement; }
        }
    }
}
