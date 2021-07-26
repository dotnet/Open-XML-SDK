// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:op="http://schemas.openxmlformats.org/officeDocument/2006/custom-properties" namespace.
    /// </summary>
    public static class OP
    {
        /// <summary>
        /// Defines the XML namespace associated with the op prefix.
        /// </summary>
        public static readonly XNamespace op = "http://schemas.openxmlformats.org/officeDocument/2006/custom-properties";

        /// <summary>
        /// Represents the op:Properties XML element.
        /// </summary>
        public static readonly XName Properties = op + "Properties";

        /// <summary>
        /// Represents the op:property XML element.
        /// </summary>
        public static readonly XName property = op + "property";
    }
}
