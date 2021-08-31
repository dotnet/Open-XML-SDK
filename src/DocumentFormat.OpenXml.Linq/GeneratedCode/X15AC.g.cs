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
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.workbook" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.url" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AbsolutePath.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName absPath = x15ac + "absPath";
    }
}
