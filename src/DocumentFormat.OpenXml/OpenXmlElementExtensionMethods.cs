// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Static class to hold extension methods for OpenXmlElement.
    /// </summary>
    internal static class OpenXmlElementExtensionMethods
    {
        /// <summary>
        /// Get position index in same type in the ChildElements of it's parent element.
        /// </summary>
        /// <param name="element">The OpenxmlElement.</param>
        /// <returns>The position index in same type element in parent.</returns>
        internal static int GetXPathIndex(this OpenXmlElement element)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            if (element.Parent is null)
            {
                return 1;
            }

            int count = 1;

            if (element is OpenXmlMiscNode)
            {
                return 1;
            }

            if (element is OpenXmlUnknownElement)
            {
                foreach (var child in element.Parent.ChildElements)
                {
                    if (element == child)
                    {
                        return count;
                    }

                    if (child is OpenXmlUnknownElement &&
                        child.NamespaceUri == element.NamespaceUri &&
                        child.LocalName == element.LocalName)
                    {
                        count++;
                    }
                }
            }
            else
            {
                Type type = element.GetType();

                foreach (var child in element.Parent.ChildElements)
                {
                    if (element == child)
                    {
                        return count;
                    }

                    if (type == child.GetType())
                    {
                        count++;
                    }
                }
            }

            Debug.Assert(false);
            return count;
        }

        /// <summary>
        /// Get the part in which the element is in.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns>The part in which the element is in. Returns null if not in a part.</returns>
        internal static OpenXmlPart? GetPart(this OpenXmlElement element)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            return element.GetPartRootElement()?.OpenXmlPart;
        }

        /// <summary>
        /// Gets the URI of the part the element is in.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns>The URI of the part the element is in. Returns null if not in a part.</returns>
        internal static Uri? GetPartUri(this OpenXmlElement element)
        {
            var part = element.GetPart();

            if (part is not null)
            {
                return part.Uri;
            }

            return null;
        }

        /// <summary>
        /// Get attribute value of the specified attribute.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="localName"></param>
        /// <param name="namespaceUri"></param>
        /// <returns></returns>
        internal static string? GetAttributeValueEx(this OpenXmlElement element, string localName, string namespaceUri)
        {
            try
            {
                return element.GetAttribute(localName, namespaceUri).Value;
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        internal static bool CanContainChild(this OpenXmlElement parent, OpenXmlElement child)
        {
            if (parent is OpenXmlCompositeElement)
            {
                foreach (var element in parent.Metadata.Children.Elements)
                {
                    if (element.Type is not null && element.Type.GetTypeInfo().IsAssignableFrom(child.GetType().GetTypeInfo()))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Trys to create an OpenXmlElement from the specified namespace URI and local name.
        /// </summary>
        /// <param name="parent">The parent element.</param>
        /// <param name="fileFormat">The specified file format version.</param>
        /// <param name="namespaceUri">The namespace URI of the requested child element.</param>
        /// <param name="localName">The local name of the requested child element.</param>
        /// <returns>A new OpenXmlElement if the parent element can contains a child with the specified namespace and local name. Otherwise, returns null.</returns>
        internal static OpenXmlElement? TryCreateValidChild(this OpenXmlElement parent, FileFormatVersions fileFormat, string namespaceUri, string localName)
        {
            Debug.Assert(parent is OpenXmlCompositeElement);

            var newElement = parent.CreateElement(new(namespaceUri, localName), string.Empty);

            if (newElement is OpenXmlUnknownElement || !newElement.IsInVersion(fileFormat))
            {
                return null;
            }

            return newElement;
        }

        internal static bool IsInVersion(this OpenXmlElement element, FileFormatVersions version)
        {
            if (element.InitialVersion == FileFormatVersions.None)
            {
                return false;
            }

            return version.AtLeast(element.InitialVersion);
        }
    }
}
