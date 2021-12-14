// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:w16cur="http://schemas.microsoft.com/office/word/2018/wordml" namespace.
    /// </summary>
    public static class W16CUR
    {
        /// <summary>
        /// Defines the XML namespace associated with the w16cur prefix.
        /// </summary>
        public static readonly XNamespace w16cur = "http://schemas.microsoft.com/office/word/2018/wordml";

        /// <summary>
        /// Represents the w16cur:ext XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="W16CEX.extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="uri" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Extension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ext = w16cur + "ext";

        /// <summary>
        /// Represents the w16cur:uri XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Extension.Uri.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName uri = w16cur + "uri";
    }
}
