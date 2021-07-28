// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:c16r3="http://schemas.microsoft.com/office/drawing/2017/03/chart" namespace.
    /// </summary>
    public static class C16R3
    {
        /// <summary>
        /// Defines the XML namespace associated with the c16r3 prefix.
        /// </summary>
        public static readonly XNamespace c16r3 = "http://schemas.microsoft.com/office/drawing/2017/03/chart";

        /// <summary>
        /// Represents the c16r3:dataDisplayOptions16 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dispNaAsBlank" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataDisplayOptions16.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataDisplayOptions16 = c16r3 + "dataDisplayOptions16";

        /// <summary>
        /// Represents the c16r3:dispNaAsBlank XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="C.ext" />, <see cref="dataDisplayOptions16" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BooleanFalse.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dispNaAsBlank = c16r3 + "dispNaAsBlank";

        /// <summary>
        /// Represents the c16r3:val XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="dispNaAsBlank" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BooleanFalse.Val.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName val = c16r3 + "val";
    }
}
