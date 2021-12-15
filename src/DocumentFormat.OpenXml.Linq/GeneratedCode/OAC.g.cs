// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:oac="http://schemas.microsoft.com/office/drawing/2013/main/command" namespace.
    /// </summary>
    public static class OAC
    {
        /// <summary>
        /// Defines the XML namespace associated with the oac prefix.
        /// </summary>
        public static readonly XNamespace oac = "http://schemas.microsoft.com/office/drawing/2013/main/command";

        /// <summary>
        /// Represents the oac:deMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DeMkLstDrawingElementMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName deMkLst = oac + "deMkLst";

        /// <summary>
        /// Represents the oac:gridColMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableColumnMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gridColMkLst = oac + "gridColMkLst";

        /// <summary>
        /// Represents the oac:tcMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableCellMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tcMkLst = oac + "tcMkLst";

        /// <summary>
        /// Represents the oac:trMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableRowMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName trMkLst = oac + "trMkLst";

        /// <summary>
        /// Represents the oac:txBodyMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBodyMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txBodyMkLst = oac + "txBodyMkLst";

        /// <summary>
        /// Represents the oac:txMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextCharRangeMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txMkLst = oac + "txMkLst";
    }
}
