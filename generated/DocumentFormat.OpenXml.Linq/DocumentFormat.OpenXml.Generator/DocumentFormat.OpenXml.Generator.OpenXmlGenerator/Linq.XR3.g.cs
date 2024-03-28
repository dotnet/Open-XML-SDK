// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xr3="http://schemas.microsoft.com/office/spreadsheetml/2016/revision3" namespace.
    /// </summary>
    public static class XR3
    {
        /// <summary>
        /// Defines the XML namespace associated with the xr3 prefix.
        /// </summary>
        public static readonly XNamespace xr3 = "http://schemas.microsoft.com/office/spreadsheetml/2016/revision3";

        /// <summary>
        /// Represents the xr3:uid XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="X.tableColumn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TableColumn.Uid.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName uid = xr3 + "uid";
    }
}
