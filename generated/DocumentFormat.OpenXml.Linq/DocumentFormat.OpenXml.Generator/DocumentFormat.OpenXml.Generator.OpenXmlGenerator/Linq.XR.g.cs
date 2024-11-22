// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xr="http://schemas.microsoft.com/office/spreadsheetml/2014/revision" namespace.
    /// </summary>
    public static partial class XR
    {
        /// <summary>
        /// Defines the XML namespace associated with the xr prefix.
        /// </summary>
        public static readonly XNamespace xr = "http://schemas.microsoft.com/office/spreadsheetml/2014/revision";

        /// <summary>
        /// Represents the xr:dxf XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="XLRD2.dxfs" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.alignment" />, <see cref="X.border" />, <see cref="X.extLst" />, <see cref="X.fill" />, <see cref="X.font" />, <see cref="X.numFmt" />, <see cref="X.protection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DifferentialFormatType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dxf = xr + "dxf";

        /// <summary>
        /// Represents the xr:is XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.c" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.phoneticPr" />, <see cref="X.r" />, <see cref="X.rPh" />, <see cref="X.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RstType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @is = xr + "is";
    }
}
