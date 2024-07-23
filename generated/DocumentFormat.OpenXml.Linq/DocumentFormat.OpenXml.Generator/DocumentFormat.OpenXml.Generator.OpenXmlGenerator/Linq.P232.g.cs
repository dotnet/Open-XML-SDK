// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:p232="http://schemas.microsoft.com/office/powerpoint/2023/02/main" namespace.
    /// </summary>
    public static partial class P232
    {
        /// <summary>
        /// Defines the XML namespace associated with the p232 prefix.
        /// </summary>
        public static readonly XNamespace p232 = "http://schemas.microsoft.com/office/powerpoint/2023/02/main";

        /// <summary>
        /// Represents the p232:cameo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CameoEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cameo = p232 + "cameo";

        /// <summary>
        /// Represents the p232:phTypeExt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PlaceholderTypeExtension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName phTypeExt = p232 + "phTypeExt";

        /// <summary>
        /// Represents the p232:type XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="phTypeExt" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cameo" />, <see cref="unknown" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PlaceholderTypeACB.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName type = p232 + "type";

        /// <summary>
        /// Represents the p232:unknown XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UnknownEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName unknown = p232 + "unknown";
    }
}
