// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Provides extension methods for pure functional transformations.
    /// </summary>
    public static class OpenXmlElementFunctionalExtensions
    {
        /// <summary>
        /// Adds child elements or attributes to the given element.
        /// </summary>
        /// <typeparam name="TElement">The element type.</typeparam>
        /// <param name="element">The element.</param>
        /// <param name="content">The content to be added to the element.</param>
        /// <returns>The element with the content added to it.</returns>
        public static TElement With<TElement>(this TElement element, params object[] content)
            where TElement : OpenXmlElement
        {
            return element.With((object) content);
        }

        /// <summary>
        /// Adds child elements or attributes to the given element.
        /// </summary>
        /// <typeparam name="TElement">The element type.</typeparam>
        /// <param name="element">The element.</param>
        /// <param name="content">The content to be added to the element.</param>
        /// <returns>The element with the content added to it.</returns>
        public static TElement With<TElement>(this TElement element, object content)
            where TElement : OpenXmlElement
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            AddContent(element, content);
            return element;
        }

        private static void AddContent(OpenXmlElement element, object content)
        {
            switch (content)
            {
                case null:
                {
                    return;
                }

                case OpenXmlElement child:
                {
                    if (child.Parent != null)
                    {
                        child = child.CloneNode(true);
                    }

                    element.AppendChild(child);
                    break;
                }

                case OpenXmlAttribute attribute:
                {
                    element.SetAttribute(attribute);
                    break;
                }

                case object[] array:
                {
                    foreach (object o in array)
                    {
                        AddContent(element, o);
                    }

                    break;
                }

                case IEnumerable enumerable:
                {
                    foreach (object o in enumerable)
                    {
                        AddContent(element, o);
                    }

                    break;
                }
            }
        }
    }
}
