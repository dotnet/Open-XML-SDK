// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xprd="http://schemas.microsoft.com/office/spreadsheetml/2022/pivotRichData" namespace.
    /// </summary>
    public static partial class XPRD
    {
        /// <summary>
        /// Defines the XML namespace associated with the xprd prefix.
        /// </summary>
        public static readonly XNamespace xprd = "http://schemas.microsoft.com/office/spreadsheetml/2022/pivotRichData";

        /// <summary>
        /// Represents the xprd:pivotCacheHasRichValue XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotCacheHasRichValuePivotCacheRichInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotCacheHasRichValue = xprd + "pivotCacheHasRichValue";

        /// <summary>
        /// Represents the xprd:richInfo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichInfoPivotCacheRichInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName richInfo = xprd + "richInfo";
    }
}
