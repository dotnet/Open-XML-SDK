// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:woe="http://schemas.microsoft.com/office/word/2020/oembed" namespace.
    /// </summary>
    public static class WOE
    {
        /// <summary>
        /// Defines the XML namespace associated with the woe prefix.
        /// </summary>
        public static readonly XNamespace woe = "http://schemas.microsoft.com/office/word/2020/oembed";

        /// <summary>
        /// Represents the woe:oembed XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mediaType" />, <see cref="NoNamespace.oEmbedUrl" />, <see cref="NoNamespace.picLocksAutoForOEmbed" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OEmbed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oembed = woe + "oembed";
    }
}
