// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:wp15="http://schemas.microsoft.com/office/word/2012/wordprocessingDrawing" namespace.
    /// </summary>
    public static class WP15
    {
        /// <summary>
        /// Defines the XML namespace associated with the wp15 prefix.
        /// </summary>
        public static readonly XNamespace wp15 = "http://schemas.microsoft.com/office/word/2012/wordprocessingDrawing";

        /// <summary>
        /// Represents the wp15:webVideoPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.embeddedHtml" />, <see cref="NoNamespace.h" />, <see cref="NoNamespace.w" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebVideoProperty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webVideoPr = wp15 + "webVideoPr";
    }
}
