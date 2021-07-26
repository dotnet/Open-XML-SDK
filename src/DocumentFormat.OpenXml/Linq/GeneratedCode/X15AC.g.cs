// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:x15ac="http://schemas.microsoft.com/office/spreadsheetml/2010/11/ac" namespace.
    /// </summary>
    public static class X15AC
    {
        /// <summary>
        /// Defines the XML namespace associated with the x15ac prefix.
        /// </summary>
        public static readonly XNamespace x15ac = "http://schemas.microsoft.com/office/spreadsheetml/2010/11/ac";

        /// <summary>
        /// Represents the x15ac:absPath XML element.
        /// </summary>
        public static readonly XName absPath = x15ac + "absPath";
    }
}
