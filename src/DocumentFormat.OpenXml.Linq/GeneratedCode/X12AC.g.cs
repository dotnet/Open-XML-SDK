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
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.dataValidation" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: List.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName list = x12ac + "list";
    }
}
