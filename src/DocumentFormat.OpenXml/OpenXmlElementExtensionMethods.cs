// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Xml;

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
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            if (element.Parent == null)
                return 1;

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
        internal static OpenXmlPart GetPart(this OpenXmlElement element)
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            OpenXmlPartRootElement partRootElement = element.GetPartRootElement();

            if (partRootElement != null && partRootElement.OpenXmlPart != null)
            {
                return partRootElement.OpenXmlPart;
            }

            return null;
        }

        /// <summary>
        /// Gets the URI of the part the element is in.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns>The URI of the part the element is in. Returns null if not in a part.</returns>
        internal static Uri GetPartUri(this OpenXmlElement element)
        {
            var part = element.GetPart();

            if (part != null)
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
        internal static string GetAttributeValueEx(this OpenXmlElement element, string localName, string namespaceUri)
        {
            try
            {
                OpenXmlAttribute attribute = element.GetAttribute(localName, namespaceUri);
                return attribute.Value;
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        /// <summary>
        /// Creates a collection of new OpenXmlElement from the element type IDs.
        /// </summary>
        /// <param name="parent">The parent element.</param>
        /// <param name="elementIds">The IDs of the children elements.</param>
        /// <returns>A collection of new OpenXmlElements.</returns>
        /// <remarks>
        /// This method use reflection to create the elements. So be aware the performance tax.
        /// </remarks>
        internal static ICollection<OpenXmlElement> CreateChildrenElementsByIds(this OpenXmlElement parent, IEnumerable<int> elementIds)
        {
            Debug.Assert(parent is OpenXmlCompositeElement);
            Debug.Assert(elementIds != null);

            List<OpenXmlElement> childElements = new List<OpenXmlElement>();

            if (elementIds.Count() > 0)
            {
                // use reflection
                var childElementTypeAttributes = parent.GetType().GetTypeInfo().GetCustomAttributes<ChildElementInfoAttribute>();

                foreach (ChildElementInfoAttribute childElementTypeAttribute in childElementTypeAttributes)
                {
                    Type childType = childElementTypeAttribute.ElementType;

                    var childElement = (OpenXmlElement)System.Activator.CreateInstance(childType);

                    foreach (var id in elementIds)
                    {
                        if (childElement.ElementTypeId == id)
                        {
                            childElements.Add(childElement);
                        }
                    }
                }
            }

            return childElements;
        }

        internal static bool CanContainsChild(this OpenXmlElement parent, OpenXmlElement child)
        {
            if (parent is OpenXmlCompositeElement)
            {
                // use reflection
                var childElementTypeAttributes = parent.GetType().GetTypeInfo().GetCustomAttributes<ChildElementInfoAttribute>();

                foreach (ChildElementInfoAttribute childElementTypeAttribute in childElementTypeAttributes)
                {
                    if (childElementTypeAttribute.ElementType.GetTypeInfo().IsAssignableFrom(child.GetType().GetTypeInfo()))
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
        internal static OpenXmlElement TryCreateValidChild(this OpenXmlElement parent, FileFormatVersions fileFormat, string namespaceUri, string localName)
        {
            Debug.Assert(parent is OpenXmlCompositeElement);
            Debug.Assert(localName != null);

            var newElement = parent.ElementFactory(string.Empty, localName, namespaceUri);
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
