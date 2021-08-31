// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:pic14="http://schemas.microsoft.com/office/drawing/2010/picture" namespace.
    /// </summary>
    public static class PIC14
    {
        /// <summary>
        /// Defines the XML namespace associated with the pic14 prefix.
        /// </summary>
        public static readonly XNamespace pic14 = "http://schemas.microsoft.com/office/drawing/2010/picture";

        /// <summary>
        /// Represents the pic14:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="PIC.pic_" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = pic14 + "extLst";

        /// <summary>
        /// Represents the pic14:style XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="PIC.pic_" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.effectRef" />, <see cref="A.fillRef" />, <see cref="A.fontRef" />, <see cref="A.lnRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName style = pic14 + "style";
    }
}
