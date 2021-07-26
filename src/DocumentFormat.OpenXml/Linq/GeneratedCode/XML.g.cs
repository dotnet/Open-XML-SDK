// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xml="http://www.w3.org/XML/1998/namespace" namespace.
    /// </summary>
    public static class XML
    {
        /// <summary>
        /// Defines the XML namespace associated with the xml prefix.
        /// </summary>
        public static readonly XNamespace xml = "http://www.w3.org/XML/1998/namespace";

        /// <summary>
        /// Represents the xml:id XML attributes.
        /// </summary>
        public static readonly XName id = xml + "id";

        /// <summary>
        /// Represents the xml:space XML attributes.
        /// </summary>
        public static readonly XName space = xml + "space";
    }
}
