// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:x12ac="http://schemas.microsoft.com/office/spreadsheetml/2011/1/ac" namespace.
    /// </summary>
    public static class X12AC
    {
        /// <summary>
        /// Defines the XML namespace associated with the x12ac prefix.
        /// </summary>
        public static readonly XNamespace x12ac = "http://schemas.microsoft.com/office/spreadsheetml/2011/1/ac";

        /// <summary>
        /// Represents the x12ac:list XML element.
        /// </summary>
        public static readonly XName list = x12ac + "list";
    }
}
