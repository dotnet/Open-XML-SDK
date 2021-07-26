// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:sl="http://schemas.openxmlformats.org/schemaLibrary/2006/main" namespace.
    /// </summary>
    public static class SL
    {
        /// <summary>
        /// Defines the XML namespace associated with the sl prefix.
        /// </summary>
        public static readonly XNamespace sl = "http://schemas.openxmlformats.org/schemaLibrary/2006/main";

        /// <summary>
        /// Represents the sl:manifestLocation XML attribute.
        /// </summary>
        public static readonly XName manifestLocation = sl + "manifestLocation";

        /// <summary>
        /// Represents the sl:schema XML element.
        /// </summary>
        public static readonly XName schema = sl + "schema";

        /// <summary>
        /// Represents the sl:schemaLibrary XML element.
        /// </summary>
        public static readonly XName schemaLibrary = sl + "schemaLibrary";

        /// <summary>
        /// Represents the sl:schemaLocation XML attribute.
        /// </summary>
        public static readonly XName schemaLocation = sl + "schemaLocation";

        /// <summary>
        /// Represents the sl:uri XML attribute.
        /// </summary>
        public static readonly XName uri = sl + "uri";
    }
}
