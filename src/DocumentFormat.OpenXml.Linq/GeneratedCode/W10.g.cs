// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:w10="urn:schemas-microsoft-com:office:word" namespace.
    /// </summary>
    public static class W10
    {
        /// <summary>
        /// Defines the XML namespace associated with the w10 prefix.
        /// </summary>
        public static readonly XNamespace w10 = "urn:schemas-microsoft-com:office:word";

        /// <summary>
        /// Represents the w10:anchorlock XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AnchorLock.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName anchorlock = w10 + "anchorlock";

        /// <summary>
        /// Represents the w10:borderbottom XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.shadow" />, <see cref="NoNamespace.type" />, <see cref="NoNamespace.width" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BottomBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName borderbottom = w10 + "borderbottom";

        /// <summary>
        /// Represents the w10:borderleft XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.shadow" />, <see cref="NoNamespace.type" />, <see cref="NoNamespace.width" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LeftBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName borderleft = w10 + "borderleft";

        /// <summary>
        /// Represents the w10:borderright XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.shadow" />, <see cref="NoNamespace.type" />, <see cref="NoNamespace.width" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RightBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName borderright = w10 + "borderright";

        /// <summary>
        /// Represents the w10:bordertop XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.shadow" />, <see cref="NoNamespace.type" />, <see cref="NoNamespace.width" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TopBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bordertop = w10 + "bordertop";

        /// <summary>
        /// Represents the w10:wrap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.anchorx" />, <see cref="NoNamespace.anchory" />, <see cref="NoNamespace.side" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextWrap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wrap = w10 + "wrap";
    }
}
