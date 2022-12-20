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
            Element = element;
            ParentElement = parentElement;
        }

        /// <summary>
        /// Gets the element that caused the event.
        /// </summary>
        public OpenXmlElement Element { get; }

        /// <summary>
        /// Gets the parent element of the element that caused the event.
        /// </summary>
        public OpenXmlElement ParentElement { get; }
    }
}
