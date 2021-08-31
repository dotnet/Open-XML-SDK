// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:c14="http://schemas.microsoft.com/office/drawing/2007/8/2/chart" namespace.
    /// </summary>
    public static class C14
    {
        /// <summary>
        /// Defines the XML namespace associated with the c14 prefix.
        /// </summary>
        public static readonly XNamespace c14 = "http://schemas.microsoft.com/office/drawing/2007/8/2/chart";

        /// <summary>
        /// Represents the c14:dropZoneCategories XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotOptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DropZoneCategories.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dropZoneCategories = c14 + "dropZoneCategories";

        /// <summary>
        /// Represents the c14:dropZoneData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotOptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DropZoneData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dropZoneData = c14 + "dropZoneData";

        /// <summary>
        /// Represents the c14:dropZoneFilter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotOptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DropZoneFilter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dropZoneFilter = c14 + "dropZoneFilter";

        /// <summary>
        /// Represents the c14:dropZoneSeries XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotOptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DropZoneSeries.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dropZoneSeries = c14 + "dropZoneSeries";

        /// <summary>
        /// Represents the c14:dropZonesVisible XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotOptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DropZonesVisible.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dropZonesVisible = c14 + "dropZonesVisible";

        /// <summary>
        /// Represents the c14:inSketchMode XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sketchOptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InSketchMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName inSketchMode = c14 + "inSketchMode";

        /// <summary>
        /// Represents the c14:invertSolidFillFmt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InvertSolidFillFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName invertSolidFillFmt = c14 + "invertSolidFillFmt";

        /// <summary>
        /// Represents the c14:pivotOptions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dropZoneCategories" />, <see cref="dropZoneData" />, <see cref="dropZoneFilter" />, <see cref="dropZoneSeries" />, <see cref="dropZonesVisible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotOptions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotOptions = c14 + "pivotOptions";

        /// <summary>
        /// Represents the c14:showSketchBtn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sketchOptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowSketchButton.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showSketchBtn = c14 + "showSketchBtn";

        /// <summary>
        /// Represents the c14:sketchOptions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="inSketchMode" />, <see cref="showSketchBtn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SketchOptions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sketchOptions = c14 + "sketchOptions";

        /// <summary>
        /// Represents the c14:spPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="invertSolidFillFmt" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.custGeom" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.ln" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.prstGeom" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.sp3d" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spPr = c14 + "spPr";

        /// <summary>
        /// Represents the c14:style XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.chartSpace" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Style.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName style = c14 + "style";
    }
}
