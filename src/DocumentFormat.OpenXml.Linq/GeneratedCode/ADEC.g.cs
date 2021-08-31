// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:adec="http://schemas.microsoft.com/office/drawing/2017/decorative" namespace.
    /// </summary>
    public static class ADEC
    {
        /// <summary>
        /// Defines the XML namespace associated with the adec prefix.
        /// </summary>
        public static readonly XNamespace adec = "http://schemas.microsoft.com/office/drawing/2017/decorative";

        /// <summary>
        /// Represents the adec:decorative XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Decorative.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName decorative = adec + "decorative";
    }
}
