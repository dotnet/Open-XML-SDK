// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:asl="http://schemas.microsoft.com/office/drawing/2021/scriptlink" namespace.
    /// </summary>
    public static class ASL
    {
        /// <summary>
        /// Defines the XML namespace associated with the asl prefix.
        /// </summary>
        public static readonly XNamespace asl = "http://schemas.microsoft.com/office/drawing/2021/scriptlink";

        /// <summary>
        /// Represents the asl:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="scriptLink" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = asl + "extLst";

        /// <summary>
        /// Represents the asl:scriptLink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScriptLink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName scriptLink = asl + "scriptLink";
    }
}
