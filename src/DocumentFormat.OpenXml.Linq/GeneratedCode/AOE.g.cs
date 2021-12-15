// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:aoe="http://schemas.microsoft.com/office/drawing/2021/oembed" namespace.
    /// </summary>
    public static class AOE
    {
        /// <summary>
        /// Defines the XML namespace associated with the aoe prefix.
        /// </summary>
        public static readonly XNamespace aoe = "http://schemas.microsoft.com/office/drawing/2021/oembed";

        /// <summary>
        /// Represents the aoe:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="oembedShared" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = aoe + "extLst";

        /// <summary>
        /// Represents the aoe:oembedShared XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.srcUrl" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OEmbedShared.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oembedShared = aoe + "oembedShared";
    }
}
