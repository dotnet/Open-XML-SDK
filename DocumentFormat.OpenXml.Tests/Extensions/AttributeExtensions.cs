// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    public static class AttributeExtensions
    {
        /// <summary>
        /// Get XName of pass-in OpenXmlAttribute.
        /// </summary>
        /// <param name="attribute">attribute in question</param>
        /// <returns>XName of pass-in OpenXmlAttribute</returns>
        public static XName GetXName(this OpenXmlAttribute attribute)
        {
            if (null == attribute)
                throw new ArgumentNullException(nameof(attribute));

            return XName.Get(attribute.LocalName, attribute.NamespaceUri);
        }

        /// <summary>
        /// Get name of attribute in <w:p> fashion.
        /// </summary>
        /// <param name="attribute">attribute in question</param>
        /// <returns>name of attribute in <w:p> format</returns>
        public static string GetFullName(this OpenXmlAttribute attribute)
        {
            if (null == attribute)
            {
                throw new ArgumentNullException(nameof(attribute));
            }

            if (string.IsNullOrEmpty(attribute.Prefix))
            {
                return attribute.LocalName;
            }

            return $"{attribute.Prefix}:{attribute.LocalName}";
        }
    }
}
