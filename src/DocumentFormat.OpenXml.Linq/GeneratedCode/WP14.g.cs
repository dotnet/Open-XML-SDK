// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:wp14="http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" namespace.
    /// </summary>
    public static class WP14
    {
        /// <summary>
        /// Defines the XML namespace associated with the wp14 prefix.
        /// </summary>
        public static readonly XNamespace wp14 = "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing";

        /// <summary>
        /// Represents the wp14:anchorId XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="WP.anchor" />, <see cref="WP.inline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Anchor.AnchorId, Inline.AnchorId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName anchorId = wp14 + "anchorId";

        /// <summary>
        /// Represents the wp14:editId XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="WP.anchor" />, <see cref="WP.inline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Anchor.EditId, Inline.EditId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName editId = wp14 + "editId";

        /// <summary>
        /// Represents the wp14:pctHeight XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sizeRelV" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PercentageHeight.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pctHeight = wp14 + "pctHeight";

        /// <summary>
        /// Represents the wp14:pctPosHOffset XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="WP.positionH" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PercentagePositionHeightOffset.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pctPosHOffset = wp14 + "pctPosHOffset";

        /// <summary>
        /// Represents the wp14:pctPosVOffset XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="WP.positionV" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PercentagePositionVerticalOffset.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pctPosVOffset = wp14 + "pctPosVOffset";

        /// <summary>
        /// Represents the wp14:pctWidth XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sizeRelH" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PercentageWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pctWidth = wp14 + "pctWidth";

        /// <summary>
        /// Represents the wp14:sizeRelH XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="WP.anchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pctWidth" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.relativeFrom" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RelativeWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sizeRelH = wp14 + "sizeRelH";

        /// <summary>
        /// Represents the wp14:sizeRelV XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="WP.anchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pctHeight" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.relativeFrom" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RelativeHeight.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sizeRelV = wp14 + "sizeRelV";
    }
}
