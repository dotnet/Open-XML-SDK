// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:ds="http://schemas.openxmlformats.org/officeDocument/2006/customXml" namespace.
    /// </summary>
    public static class DS
    {
        /// <summary>
        /// Defines the XML namespace associated with the ds prefix.
        /// </summary>
        public static readonly XNamespace ds = "http://schemas.openxmlformats.org/officeDocument/2006/customXml";

        /// <summary>
        /// Represents the ds:datastoreItem XML element.
        /// </summary>
        public static readonly XName datastoreItem = ds + "datastoreItem";

        /// <summary>
        /// Represents the ds:itemID XML attribute.
        /// </summary>
        public static readonly XName itemID = ds + "itemID";

        /// <summary>
        /// Represents the ds:schemaRef XML element.
        /// </summary>
        public static readonly XName schemaRef = ds + "schemaRef";

        /// <summary>
        /// Represents the ds:schemaRefs XML element.
        /// </summary>
        public static readonly XName schemaRefs = ds + "schemaRefs";

        /// <summary>
        /// Represents the ds:uri XML attribute.
        /// </summary>
        public static readonly XName uri = ds + "uri";
    }
}
