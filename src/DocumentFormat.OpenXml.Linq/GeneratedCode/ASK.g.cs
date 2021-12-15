// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:ask="http://schemas.microsoft.com/office/drawing/2018/sketchyshapes" namespace.
    /// </summary>
    public static class ASK
    {
        /// <summary>
        /// Defines the XML namespace associated with the ask prefix.
        /// </summary>
        public static readonly XNamespace ask = "http://schemas.microsoft.com/office/drawing/2018/sketchyshapes";

        /// <summary>
        /// Represents the ask:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lineSketchStyleProps" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = ask + "extLst";

        /// <summary>
        /// Represents the ask:lineSketchCurved XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineSketchCurvedEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lineSketchCurved = ask + "lineSketchCurved";

        /// <summary>
        /// Represents the ask:lineSketchFreehand XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineSketchFreehandEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lineSketchFreehand = ask + "lineSketchFreehand";

        /// <summary>
        /// Represents the ask:lineSketchNone XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineSketchNoneEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lineSketchNone = ask + "lineSketchNone";

        /// <summary>
        /// Represents the ask:lineSketchScribble XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineSketchScribbleEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lineSketchScribble = ask + "lineSketchScribble";

        /// <summary>
        /// Represents the ask:lineSketchStyleProps XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.custGeom" />, <see cref="A.prstGeom" />, <see cref="extLst" />, <see cref="seed" />, <see cref="type" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.sd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineSketchStyleProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lineSketchStyleProps = ask + "lineSketchStyleProps";

        /// <summary>
        /// Represents the ask:seed XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lineSketchStyleProps" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineSketchSeed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName seed = ask + "seed";

        /// <summary>
        /// Represents the ask:type XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lineSketchStyleProps" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="lineSketchCurved" />, <see cref="lineSketchFreehand" />, <see cref="lineSketchNone" />, <see cref="lineSketchScribble" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineSketchTypeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName type = ask + "type";
    }
}
