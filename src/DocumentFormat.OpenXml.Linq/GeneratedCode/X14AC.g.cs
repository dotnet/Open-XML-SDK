// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:x14ac="http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac" namespace.
    /// </summary>
    public static class X14AC
    {
        /// <summary>
        /// Defines the XML namespace associated with the x14ac prefix.
        /// </summary>
        public static readonly XNamespace x14ac = "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac";

        /// <summary>
        /// Represents the x14ac:dyDescent XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="X.row" />, <see cref="X.sheetFormatPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Row.DyDescent, SheetFormatProperties.DyDescent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dyDescent = x14ac + "dyDescent";

        /// <summary>
        /// Represents the x14ac:knownFonts XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="X.fonts" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Fonts.KnownFonts.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName knownFonts = x14ac + "knownFonts";
    }
}
