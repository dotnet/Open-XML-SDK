// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:v="urn:schemas-microsoft-com:vml" namespace.
    /// </summary>
    public static class V
    {
        /// <summary>
        /// Defines the XML namespace associated with the v prefix.
        /// </summary>
        public static readonly XNamespace v = "urn:schemas-microsoft-com:vml";

        /// <summary>
        /// Represents the v:arc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="group" />, <see cref="W.@object" />, <see cref="W.pict" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.callout" />, <see cref="O.clippath" />, <see cref="O.extrusion" />, <see cref="O.@lock" />, <see cref="O.signatureline" />, <see cref="O.skew" />, <see cref="PVML.textdata" />, <see cref="fill" />, <see cref="formulas" />, <see cref="handles" />, <see cref="imagedata" />, <see cref="path" />, <see cref="shadow" />, <see cref="stroke" />, <see cref="textbox" />, <see cref="textpath" />, <see cref="W10.anchorlock" />, <see cref="W10.borderbottom" />, <see cref="W10.borderleft" />, <see cref="W10.borderright" />, <see cref="W10.bordertop" />, <see cref="W10.wrap" />, <see cref="XVML.ClientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alt" />, <see cref="NoNamespace.coordorigin" />, <see cref="NoNamespace.coordsize" />, <see cref="NoNamespace.endangle" />, <see cref="NoNamespace.fillcolor" />, <see cref="NoNamespace.filled" />, <see cref="NoNamespace.href" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.insetpen" />, <see cref="O.allowincell" />, <see cref="O.allowoverlap" />, <see cref="O.borderbottomcolor" />, <see cref="O.borderleftcolor" />, <see cref="O.borderrightcolor" />, <see cref="O.bordertopcolor" />, <see cref="O.bullet" />, <see cref="O.button" />, <see cref="O.bwmode" />, <see cref="O.bwnormal" />, <see cref="O.bwpure" />, <see cref="O.clip" />, <see cref="O.cliptowrap" />, <see cref="O.connectortype" />, <see cref="O.dgmlayout" />, <see cref="O.dgmlayoutmru" />, <see cref="O.dgmnodekind" />, <see cref="O.doubleclicknotify" />, <see cref="O.forcedash" />, <see cref="O.gfxdata" />, <see cref="O.hr" />, <see cref="O.hralign" />, <see cref="O.hrnoshade" />, <see cref="O.hrpct" />, <see cref="O.hrstd" />, <see cref="O.insetmode" />, <see cref="O.ole" />, <see cref="O.oleicon" />, <see cref="O.oned" />, <see cref="O.preferrelative" />, <see cref="O.regroupid" />, <see cref="O.spid" />, <see cref="O.spt" />, <see cref="O.userdrawn" />, <see cref="O.userhidden" />, <see cref="NoNamespace.print" />, <see cref="NoNamespace.startangle" />, <see cref="NoNamespace.strokecolor" />, <see cref="NoNamespace.stroked" />, <see cref="NoNamespace.strokeweight" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.target" />, <see cref="NoNamespace.title" />, <see cref="NoNamespace.wrapcoords" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Arc.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName arc = v + "arc";

        /// <summary>
        /// Represents the v:background XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.background" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="fill" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fill" />, <see cref="NoNamespace.fillcolor" />, <see cref="NoNamespace.id" />, <see cref="O.bwmode" />, <see cref="O.bwnormal" />, <see cref="O.bwpure" />, <see cref="O.targetscreensize" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Background.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName background = v + "background";

        /// <summary>
        /// Represents the v:curve XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="group" />, <see cref="W.@object" />, <see cref="W.pict" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.callout" />, <see cref="O.clippath" />, <see cref="O.extrusion" />, <see cref="O.@lock" />, <see cref="O.signatureline" />, <see cref="O.skew" />, <see cref="PVML.textdata" />, <see cref="fill" />, <see cref="formulas" />, <see cref="handles" />, <see cref="imagedata" />, <see cref="path" />, <see cref="shadow" />, <see cref="stroke" />, <see cref="textbox" />, <see cref="textpath" />, <see cref="W10.anchorlock" />, <see cref="W10.borderbottom" />, <see cref="W10.borderleft" />, <see cref="W10.borderright" />, <see cref="W10.bordertop" />, <see cref="W10.wrap" />, <see cref="XVML.ClientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alt" />, <see cref="NoNamespace.@class" />, <see cref="NoNamespace.control1" />, <see cref="NoNamespace.control2" />, <see cref="NoNamespace.coordorigin" />, <see cref="NoNamespace.coordsize" />, <see cref="NoNamespace.fillcolor" />, <see cref="NoNamespace.filled" />, <see cref="NoNamespace.from" />, <see cref="NoNamespace.href" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.insetpen" />, <see cref="O.allowincell" />, <see cref="O.allowoverlap" />, <see cref="O.borderbottomcolor" />, <see cref="O.borderleftcolor" />, <see cref="O.borderrightcolor" />, <see cref="O.bordertopcolor" />, <see cref="O.bullet" />, <see cref="O.button" />, <see cref="O.bwmode" />, <see cref="O.bwnormal" />, <see cref="O.bwpure" />, <see cref="O.clip" />, <see cref="O.cliptowrap" />, <see cref="O.connectortype" />, <see cref="O.dgmlayout" />, <see cref="O.dgmlayoutmru" />, <see cref="O.dgmnodekind" />, <see cref="O.doubleclicknotify" />, <see cref="O.forcedash" />, <see cref="O.gfxdata" />, <see cref="O.hr" />, <see cref="O.hralign" />, <see cref="O.hrnoshade" />, <see cref="O.hrpct" />, <see cref="O.hrstd" />, <see cref="O.insetmode" />, <see cref="O.ole" />, <see cref="O.oleicon" />, <see cref="O.oned" />, <see cref="O.preferrelative" />, <see cref="O.regroupid" />, <see cref="O.spid" />, <see cref="O.spt" />, <see cref="O.userdrawn" />, <see cref="O.userhidden" />, <see cref="NoNamespace.print" />, <see cref="NoNamespace.strokecolor" />, <see cref="NoNamespace.stroked" />, <see cref="NoNamespace.strokeweight" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.target" />, <see cref="NoNamespace.title" />, <see cref="NoNamespace.to" />, <see cref="NoNamespace.wrapcoords" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Curve.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName curve = v + "curve";

        /// <summary>
        /// Represents the v:ext XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="O.bottom" />, <see cref="O.callout" />, <see cref="O.colormenu" />, <see cref="O.colormru" />, <see cref="O.column" />, <see cref="O.complex" />, <see cref="O.diagram" />, <see cref="O.extrusion" />, <see cref="O.fill" />, <see cref="O.idmap" />, <see cref="O.left" />, <see cref="O.@lock" />, <see cref="O.regrouptable" />, <see cref="O.rel" />, <see cref="O.relationtable" />, <see cref="O.right" />, <see cref="O.rules" />, <see cref="O.shapedefaults" />, <see cref="O.shapelayout" />, <see cref="O.signatureline" />, <see cref="O.skew" />, <see cref="O.top" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BottomStroke.Extension, Callout.Extension, ColorMenu.Extension, ColorMostRecentlyUsed.Extension, ColumnStroke.Extension, Complex.Extension, Diagram.Extension, Extrusion.Extension, FillExtendedProperties.Extension, LeftStroke.Extension, Lock.Extension, RegroupTable.Extension, Relation.Extension, RelationTable.Extension, RightStroke.Extension, Rules.Extension, ShapeDefaults.Extension, ShapeIdMap.Extension, ShapeLayout.Extension, SignatureLine.Extension, Skew.Extension, TopStroke.Extension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ext = v + "ext";

        /// <summary>
        /// Represents the v:f XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="formulas" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.eqn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Formula.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName f = v + "f";

        /// <summary>
        /// Represents the v:fill XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="O.shapedefaults" />, <see cref="arc" />, <see cref="background" />, <see cref="curve" />, <see cref="image" />, <see cref="line" />, <see cref="oval" />, <see cref="polyline" />, <see cref="rect" />, <see cref="roundrect" />, <see cref="shape" />, <see cref="shapetype" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.fill" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alignshape" />, <see cref="NoNamespace.angle" />, <see cref="NoNamespace.aspect" />, <see cref="NoNamespace.color" />, <see cref="NoNamespace.color2" />, <see cref="NoNamespace.colors" />, <see cref="NoNamespace.focus" />, <see cref="NoNamespace.focusposition" />, <see cref="NoNamespace.focussize" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.method" />, <see cref="O.althref" />, <see cref="O.detectmouseclick" />, <see cref="O.href" />, <see cref="O.opacity2" />, <see cref="O.title" />, <see cref="NoNamespace.on" />, <see cref="NoNamespace.opacity" />, <see cref="NoNamespace.origin" />, <see cref="NoNamespace.position" />, <see cref="R.id" />, <see cref="NoNamespace.recolor" />, <see cref="NoNamespace.rotate" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.src" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Fill.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fill = v + "fill";

        /// <summary>
        /// Represents the v:formulas XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="arc" />, <see cref="curve" />, <see cref="image" />, <see cref="line" />, <see cref="oval" />, <see cref="polyline" />, <see cref="rect" />, <see cref="roundrect" />, <see cref="shape" />, <see cref="shapetype" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="f" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Formulas.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName formulas = v + "formulas";

        /// <summary>
        /// Represents the v:group XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="group" />, <see cref="W.@object" />, <see cref="W.pict" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.clippath" />, <see cref="O.diagram" />, <see cref="O.@lock" />, <see cref="arc" />, <see cref="curve" />, <see cref="group" />, <see cref="image" />, <see cref="line" />, <see cref="oval" />, <see cref="polyline" />, <see cref="rect" />, <see cref="roundrect" />, <see cref="shape" />, <see cref="shapetype" />, <see cref="W10.anchorlock" />, <see cref="W10.wrap" />, <see cref="XVML.ClientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alt" />, <see cref="NoNamespace.@class" />, <see cref="NoNamespace.coordorigin" />, <see cref="NoNamespace.coordsize" />, <see cref="NoNamespace.editas" />, <see cref="NoNamespace.href" />, <see cref="NoNamespace.id" />, <see cref="O.allowincell" />, <see cref="O.allowoverlap" />, <see cref="O.bullet" />, <see cref="O.button" />, <see cref="O.dgmlayout" />, <see cref="O.dgmlayoutmru" />, <see cref="O.dgmnodekind" />, <see cref="O.doubleclicknotify" />, <see cref="O.gfxdata" />, <see cref="O.hr" />, <see cref="O.hralign" />, <see cref="O.hrnoshade" />, <see cref="O.hrpct" />, <see cref="O.hrstd" />, <see cref="O.insetmode" />, <see cref="O.oned" />, <see cref="O.regroupid" />, <see cref="O.spid" />, <see cref="O.tablelimits" />, <see cref="O.tableproperties" />, <see cref="O.userdrawn" />, <see cref="O.userhidden" />, <see cref="NoNamespace.print" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.target" />, <see cref="NoNamespace.title" />, <see cref="NoNamespace.wrapcoords" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Group.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName group = v + "group";

        /// <summary>
        /// Represents the v:h XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="handles" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.invx" />, <see cref="NoNamespace.invy" />, <see cref="NoNamespace.map" />, <see cref="NoNamespace.polar" />, <see cref="NoNamespace.position" />, <see cref="NoNamespace.radiusrange" />, <see cref="NoNamespace.@switch" />, <see cref="NoNamespace.xrange" />, <see cref="NoNamespace.yrange" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeHandle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName h = v + "h";

        /// <summary>
        /// Represents the v:handles XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="arc" />, <see cref="curve" />, <see cref="image" />, <see cref="line" />, <see cref="oval" />, <see cref="polyline" />, <see cref="rect" />, <see cref="roundrect" />, <see cref="shape" />, <see cref="shapetype" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="h" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeHandles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName handles = v + "handles";

        /// <summary>
        /// Represents the v:image XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="group" />, <see cref="W.@object" />, <see cref="W.pict" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.callout" />, <see cref="O.clippath" />, <see cref="O.extrusion" />, <see cref="O.@lock" />, <see cref="O.signatureline" />, <see cref="O.skew" />, <see cref="PVML.textdata" />, <see cref="fill" />, <see cref="formulas" />, <see cref="handles" />, <see cref="imagedata" />, <see cref="path" />, <see cref="shadow" />, <see cref="stroke" />, <see cref="textbox" />, <see cref="textpath" />, <see cref="W10.anchorlock" />, <see cref="W10.borderbottom" />, <see cref="W10.borderleft" />, <see cref="W10.borderright" />, <see cref="W10.bordertop" />, <see cref="W10.wrap" />, <see cref="XVML.ClientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alt" />, <see cref="NoNamespace.bilevel" />, <see cref="NoNamespace.blacklevel" />, <see cref="NoNamespace.@class" />, <see cref="NoNamespace.coordsize" />, <see cref="NoNamespace.cropbottom" />, <see cref="NoNamespace.cropleft" />, <see cref="NoNamespace.cropright" />, <see cref="NoNamespace.croptop" />, <see cref="NoNamespace.fillcolor" />, <see cref="NoNamespace.filled" />, <see cref="NoNamespace.gain" />, <see cref="NoNamespace.gamma" />, <see cref="NoNamespace.grayscale" />, <see cref="NoNamespace.href" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.insetpen" />, <see cref="O.allowincell" />, <see cref="O.allowoverlap" />, <see cref="O.borderbottomcolor" />, <see cref="O.borderleftcolor" />, <see cref="O.borderrightcolor" />, <see cref="O.bordertopcolor" />, <see cref="O.bullet" />, <see cref="O.button" />, <see cref="O.bwmode" />, <see cref="O.bwnormal" />, <see cref="O.bwpure" />, <see cref="O.clip" />, <see cref="O.cliptowrap" />, <see cref="O.connectortype" />, <see cref="O.dgmlayout" />, <see cref="O.dgmlayoutmru" />, <see cref="O.dgmnodekind" />, <see cref="O.doubleclicknotify" />, <see cref="O.forcedash" />, <see cref="O.gfxdata" />, <see cref="O.hr" />, <see cref="O.hralign" />, <see cref="O.hrnoshade" />, <see cref="O.hrpct" />, <see cref="O.hrstd" />, <see cref="O.insetmode" />, <see cref="O.ole" />, <see cref="O.oleicon" />, <see cref="O.oned" />, <see cref="O.preferrelative" />, <see cref="O.regroupid" />, <see cref="O.spid" />, <see cref="O.spt" />, <see cref="O.userdrawn" />, <see cref="O.userhidden" />, <see cref="NoNamespace.print" />, <see cref="NoNamespace.src" />, <see cref="NoNamespace.strokecolor" />, <see cref="NoNamespace.stroked" />, <see cref="NoNamespace.strokeweight" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.target" />, <see cref="NoNamespace.title" />, <see cref="NoNamespace.wrapcoords" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ImageFile.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName image = v + "image";

        /// <summary>
        /// Represents the v:imagedata XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="O.shapedefaults" />, <see cref="arc" />, <see cref="curve" />, <see cref="image" />, <see cref="line" />, <see cref="oval" />, <see cref="polyline" />, <see cref="rect" />, <see cref="roundrect" />, <see cref="shape" />, <see cref="shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bilevel" />, <see cref="NoNamespace.blacklevel" />, <see cref="NoNamespace.chromakey" />, <see cref="NoNamespace.cropbottom" />, <see cref="NoNamespace.cropleft" />, <see cref="NoNamespace.cropright" />, <see cref="NoNamespace.croptop" />, <see cref="NoNamespace.embosscolor" />, <see cref="NoNamespace.gain" />, <see cref="NoNamespace.gamma" />, <see cref="NoNamespace.grayscale" />, <see cref="NoNamespace.id" />, <see cref="O.detectmouseclick" />, <see cref="O.relid" />, <see cref="O.title" />, <see cref="R.href" />, <see cref="R.id" />, <see cref="R.pict" />, <see cref="NoNamespace.recolortarget" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ImageData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName imagedata = v + "imagedata";

        /// <summary>
        /// Represents the v:line XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="group" />, <see cref="W.@object" />, <see cref="W.pict" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.callout" />, <see cref="O.clippath" />, <see cref="O.extrusion" />, <see cref="O.@lock" />, <see cref="O.signatureline" />, <see cref="O.skew" />, <see cref="PVML.textdata" />, <see cref="fill" />, <see cref="formulas" />, <see cref="handles" />, <see cref="imagedata" />, <see cref="path" />, <see cref="shadow" />, <see cref="stroke" />, <see cref="textbox" />, <see cref="textpath" />, <see cref="W10.anchorlock" />, <see cref="W10.borderbottom" />, <see cref="W10.borderleft" />, <see cref="W10.borderright" />, <see cref="W10.bordertop" />, <see cref="W10.wrap" />, <see cref="XVML.ClientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alt" />, <see cref="NoNamespace.@class" />, <see cref="NoNamespace.coordorigin" />, <see cref="NoNamespace.coordsize" />, <see cref="NoNamespace.fillcolor" />, <see cref="NoNamespace.filled" />, <see cref="NoNamespace.from" />, <see cref="NoNamespace.href" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.insetpen" />, <see cref="O.allowincell" />, <see cref="O.allowoverlap" />, <see cref="O.borderbottomcolor" />, <see cref="O.borderleftcolor" />, <see cref="O.borderrightcolor" />, <see cref="O.bordertopcolor" />, <see cref="O.bullet" />, <see cref="O.button" />, <see cref="O.bwmode" />, <see cref="O.bwnormal" />, <see cref="O.bwpure" />, <see cref="O.clip" />, <see cref="O.cliptowrap" />, <see cref="O.connectortype" />, <see cref="O.dgmlayout" />, <see cref="O.dgmlayoutmru" />, <see cref="O.dgmnodekind" />, <see cref="O.doubleclicknotify" />, <see cref="O.forcedash" />, <see cref="O.gfxdata" />, <see cref="O.hr" />, <see cref="O.hralign" />, <see cref="O.hrnoshade" />, <see cref="O.hrpct" />, <see cref="O.hrstd" />, <see cref="O.insetmode" />, <see cref="O.ole" />, <see cref="O.oleicon" />, <see cref="O.oned" />, <see cref="O.preferrelative" />, <see cref="O.regroupid" />, <see cref="O.spid" />, <see cref="O.spt" />, <see cref="O.userdrawn" />, <see cref="O.userhidden" />, <see cref="NoNamespace.print" />, <see cref="NoNamespace.strokecolor" />, <see cref="NoNamespace.stroked" />, <see cref="NoNamespace.strokeweight" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.target" />, <see cref="NoNamespace.title" />, <see cref="NoNamespace.to" />, <see cref="NoNamespace.wrapcoords" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Line.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName line = v + "line";

        /// <summary>
        /// Represents the v:oval XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="group" />, <see cref="W.@object" />, <see cref="W.pict" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.callout" />, <see cref="O.clippath" />, <see cref="O.extrusion" />, <see cref="O.@lock" />, <see cref="O.signatureline" />, <see cref="O.skew" />, <see cref="PVML.textdata" />, <see cref="fill" />, <see cref="formulas" />, <see cref="handles" />, <see cref="imagedata" />, <see cref="path" />, <see cref="shadow" />, <see cref="stroke" />, <see cref="textbox" />, <see cref="textpath" />, <see cref="W10.anchorlock" />, <see cref="W10.borderbottom" />, <see cref="W10.borderleft" />, <see cref="W10.borderright" />, <see cref="W10.bordertop" />, <see cref="W10.wrap" />, <see cref="XVML.ClientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alt" />, <see cref="NoNamespace.@class" />, <see cref="NoNamespace.coordorigin" />, <see cref="NoNamespace.coordsize" />, <see cref="NoNamespace.fillcolor" />, <see cref="NoNamespace.filled" />, <see cref="NoNamespace.href" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.insetpen" />, <see cref="O.allowincell" />, <see cref="O.allowoverlap" />, <see cref="O.borderbottomcolor" />, <see cref="O.borderleftcolor" />, <see cref="O.borderrightcolor" />, <see cref="O.bordertopcolor" />, <see cref="O.bullet" />, <see cref="O.button" />, <see cref="O.bwmode" />, <see cref="O.bwnormal" />, <see cref="O.bwpure" />, <see cref="O.clip" />, <see cref="O.cliptowrap" />, <see cref="O.connectortype" />, <see cref="O.dgmlayout" />, <see cref="O.dgmlayoutmru" />, <see cref="O.dgmnodekind" />, <see cref="O.doubleclicknotify" />, <see cref="O.forcedash" />, <see cref="O.gfxdata" />, <see cref="O.hr" />, <see cref="O.hralign" />, <see cref="O.hrnoshade" />, <see cref="O.hrpct" />, <see cref="O.hrstd" />, <see cref="O.insetmode" />, <see cref="O.ole" />, <see cref="O.oleicon" />, <see cref="O.oned" />, <see cref="O.preferrelative" />, <see cref="O.regroupid" />, <see cref="O.spid" />, <see cref="O.spt" />, <see cref="O.userdrawn" />, <see cref="O.userhidden" />, <see cref="NoNamespace.print" />, <see cref="NoNamespace.strokecolor" />, <see cref="NoNamespace.stroked" />, <see cref="NoNamespace.strokeweight" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.target" />, <see cref="NoNamespace.title" />, <see cref="NoNamespace.wrapcoords" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Oval.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oval = v + "oval";

        /// <summary>
        /// Represents the v:path XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="arc" />, <see cref="curve" />, <see cref="image" />, <see cref="line" />, <see cref="oval" />, <see cref="polyline" />, <see cref="rect" />, <see cref="roundrect" />, <see cref="shape" />, <see cref="shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.arrowok" />, <see cref="NoNamespace.fillok" />, <see cref="NoNamespace.gradientshapeok" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.insetpenok" />, <see cref="NoNamespace.limo" />, <see cref="O.connectangles" />, <see cref="O.connectlocs" />, <see cref="O.connecttype" />, <see cref="O.extrusionok" />, <see cref="NoNamespace.shadowok" />, <see cref="NoNamespace.strokeok" />, <see cref="NoNamespace.textboxrect" />, <see cref="NoNamespace.textpathok" />, <see cref="NoNamespace.v" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Path.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName path = v + "path";

        /// <summary>
        /// Represents the v:polyline XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="group" />, <see cref="W.@object" />, <see cref="W.pict" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.callout" />, <see cref="O.clippath" />, <see cref="O.extrusion" />, <see cref="O.ink" />, <see cref="O.@lock" />, <see cref="O.signatureline" />, <see cref="O.skew" />, <see cref="PVML.textdata" />, <see cref="fill" />, <see cref="formulas" />, <see cref="handles" />, <see cref="imagedata" />, <see cref="path" />, <see cref="shadow" />, <see cref="stroke" />, <see cref="textbox" />, <see cref="textpath" />, <see cref="W10.anchorlock" />, <see cref="W10.borderbottom" />, <see cref="W10.borderleft" />, <see cref="W10.borderright" />, <see cref="W10.bordertop" />, <see cref="W10.wrap" />, <see cref="XVML.ClientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alt" />, <see cref="NoNamespace.@class" />, <see cref="NoNamespace.coordorigin" />, <see cref="NoNamespace.coordsize" />, <see cref="NoNamespace.fillcolor" />, <see cref="NoNamespace.filled" />, <see cref="NoNamespace.href" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.insetpen" />, <see cref="O.allowincell" />, <see cref="O.allowoverlap" />, <see cref="O.borderbottomcolor" />, <see cref="O.borderleftcolor" />, <see cref="O.borderrightcolor" />, <see cref="O.bordertopcolor" />, <see cref="O.bullet" />, <see cref="O.button" />, <see cref="O.bwmode" />, <see cref="O.bwnormal" />, <see cref="O.bwpure" />, <see cref="O.clip" />, <see cref="O.cliptowrap" />, <see cref="O.connectortype" />, <see cref="O.dgmlayout" />, <see cref="O.dgmlayoutmru" />, <see cref="O.dgmnodekind" />, <see cref="O.doubleclicknotify" />, <see cref="O.forcedash" />, <see cref="O.gfxdata" />, <see cref="O.hr" />, <see cref="O.hralign" />, <see cref="O.hrnoshade" />, <see cref="O.hrpct" />, <see cref="O.hrstd" />, <see cref="O.insetmode" />, <see cref="O.ole" />, <see cref="O.oleicon" />, <see cref="O.oned" />, <see cref="O.preferrelative" />, <see cref="O.regroupid" />, <see cref="O.spid" />, <see cref="O.spt" />, <see cref="O.userdrawn" />, <see cref="O.userhidden" />, <see cref="NoNamespace.points" />, <see cref="NoNamespace.print" />, <see cref="NoNamespace.strokecolor" />, <see cref="NoNamespace.stroked" />, <see cref="NoNamespace.strokeweight" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.target" />, <see cref="NoNamespace.title" />, <see cref="NoNamespace.wrapcoords" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PolyLine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName polyline = v + "polyline";

        /// <summary>
        /// Represents the v:rect XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="group" />, <see cref="W.@object" />, <see cref="W.pict" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.callout" />, <see cref="O.clippath" />, <see cref="O.extrusion" />, <see cref="O.@lock" />, <see cref="O.signatureline" />, <see cref="O.skew" />, <see cref="PVML.textdata" />, <see cref="fill" />, <see cref="formulas" />, <see cref="handles" />, <see cref="imagedata" />, <see cref="path" />, <see cref="shadow" />, <see cref="stroke" />, <see cref="textbox" />, <see cref="textpath" />, <see cref="W10.anchorlock" />, <see cref="W10.borderbottom" />, <see cref="W10.borderleft" />, <see cref="W10.borderright" />, <see cref="W10.bordertop" />, <see cref="W10.wrap" />, <see cref="XVML.ClientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alt" />, <see cref="NoNamespace.@class" />, <see cref="NoNamespace.coordorigin" />, <see cref="NoNamespace.coordsize" />, <see cref="NoNamespace.fillcolor" />, <see cref="NoNamespace.filled" />, <see cref="NoNamespace.href" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.insetpen" />, <see cref="O.allowincell" />, <see cref="O.allowoverlap" />, <see cref="O.borderbottomcolor" />, <see cref="O.borderleftcolor" />, <see cref="O.borderrightcolor" />, <see cref="O.bordertopcolor" />, <see cref="O.bullet" />, <see cref="O.button" />, <see cref="O.bwmode" />, <see cref="O.bwnormal" />, <see cref="O.bwpure" />, <see cref="O.clip" />, <see cref="O.cliptowrap" />, <see cref="O.connectortype" />, <see cref="O.dgmlayout" />, <see cref="O.dgmlayoutmru" />, <see cref="O.dgmnodekind" />, <see cref="O.doubleclicknotify" />, <see cref="O.forcedash" />, <see cref="O.gfxdata" />, <see cref="O.hr" />, <see cref="O.hralign" />, <see cref="O.hrnoshade" />, <see cref="O.hrpct" />, <see cref="O.hrstd" />, <see cref="O.insetmode" />, <see cref="O.ole" />, <see cref="O.oleicon" />, <see cref="O.oned" />, <see cref="O.preferrelative" />, <see cref="O.regroupid" />, <see cref="O.spid" />, <see cref="O.spt" />, <see cref="O.userdrawn" />, <see cref="O.userhidden" />, <see cref="NoNamespace.print" />, <see cref="NoNamespace.strokecolor" />, <see cref="NoNamespace.stroked" />, <see cref="NoNamespace.strokeweight" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.target" />, <see cref="NoNamespace.title" />, <see cref="NoNamespace.wrapcoords" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Rectangle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rect = v + "rect";

        /// <summary>
        /// Represents the v:roundrect XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="group" />, <see cref="W.@object" />, <see cref="W.pict" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.callout" />, <see cref="O.clippath" />, <see cref="O.extrusion" />, <see cref="O.@lock" />, <see cref="O.signatureline" />, <see cref="O.skew" />, <see cref="PVML.textdata" />, <see cref="fill" />, <see cref="formulas" />, <see cref="handles" />, <see cref="imagedata" />, <see cref="path" />, <see cref="shadow" />, <see cref="stroke" />, <see cref="textbox" />, <see cref="textpath" />, <see cref="W10.anchorlock" />, <see cref="W10.borderbottom" />, <see cref="W10.borderleft" />, <see cref="W10.borderright" />, <see cref="W10.bordertop" />, <see cref="W10.wrap" />, <see cref="XVML.ClientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alt" />, <see cref="NoNamespace.arcsize" />, <see cref="NoNamespace.@class" />, <see cref="NoNamespace.coordsize" />, <see cref="NoNamespace.fillcolor" />, <see cref="NoNamespace.filled" />, <see cref="NoNamespace.href" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.insetpen" />, <see cref="O.allowincell" />, <see cref="O.allowoverlap" />, <see cref="O.borderbottomcolor" />, <see cref="O.borderleftcolor" />, <see cref="O.borderrightcolor" />, <see cref="O.bordertopcolor" />, <see cref="O.bullet" />, <see cref="O.button" />, <see cref="O.bwmode" />, <see cref="O.bwnormal" />, <see cref="O.bwpure" />, <see cref="O.clip" />, <see cref="O.cliptowrap" />, <see cref="O.connectortype" />, <see cref="O.dgmlayout" />, <see cref="O.dgmlayoutmru" />, <see cref="O.dgmnodekind" />, <see cref="O.doubleclicknotify" />, <see cref="O.forcedash" />, <see cref="O.gfxdata" />, <see cref="O.hr" />, <see cref="O.hralign" />, <see cref="O.hrnoshade" />, <see cref="O.hrpct" />, <see cref="O.hrstd" />, <see cref="O.insetmode" />, <see cref="O.ole" />, <see cref="O.oleicon" />, <see cref="O.oned" />, <see cref="O.preferrelative" />, <see cref="O.regroupid" />, <see cref="O.spid" />, <see cref="O.spt" />, <see cref="O.userdrawn" />, <see cref="O.userhidden" />, <see cref="NoNamespace.print" />, <see cref="NoNamespace.strokecolor" />, <see cref="NoNamespace.stroked" />, <see cref="NoNamespace.strokeweight" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.target" />, <see cref="NoNamespace.title" />, <see cref="NoNamespace.wrapcoords" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RoundRectangle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName roundrect = v + "roundrect";

        /// <summary>
        /// Represents the v:shadow XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="O.shapedefaults" />, <see cref="arc" />, <see cref="curve" />, <see cref="image" />, <see cref="line" />, <see cref="oval" />, <see cref="polyline" />, <see cref="rect" />, <see cref="roundrect" />, <see cref="shape" />, <see cref="shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.color" />, <see cref="NoNamespace.color2" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.matrix" />, <see cref="NoNamespace.obscured" />, <see cref="NoNamespace.offset" />, <see cref="NoNamespace.offset2" />, <see cref="NoNamespace.on" />, <see cref="NoNamespace.opacity" />, <see cref="NoNamespace.origin" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shadow.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shadow = v + "shadow";

        /// <summary>
        /// Represents the v:shape XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="group" />, <see cref="W.@object" />, <see cref="W.pict" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.callout" />, <see cref="O.clippath" />, <see cref="O.extrusion" />, <see cref="O.ink" />, <see cref="O.@lock" />, <see cref="O.signatureline" />, <see cref="O.skew" />, <see cref="PVML.iscomment" />, <see cref="PVML.textdata" />, <see cref="fill" />, <see cref="formulas" />, <see cref="handles" />, <see cref="imagedata" />, <see cref="path" />, <see cref="shadow" />, <see cref="stroke" />, <see cref="textbox" />, <see cref="textpath" />, <see cref="W10.anchorlock" />, <see cref="W10.borderbottom" />, <see cref="W10.borderleft" />, <see cref="W10.borderright" />, <see cref="W10.bordertop" />, <see cref="W10.wrap" />, <see cref="XVML.ClientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.adj" />, <see cref="NoNamespace.alt" />, <see cref="NoNamespace.@class" />, <see cref="NoNamespace.coordorigin" />, <see cref="NoNamespace.coordsize" />, <see cref="NoNamespace.equationxml" />, <see cref="NoNamespace.fillcolor" />, <see cref="NoNamespace.filled" />, <see cref="NoNamespace.href" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.insetpen" />, <see cref="O.allowincell" />, <see cref="O.allowoverlap" />, <see cref="O.borderbottomcolor" />, <see cref="O.borderleftcolor" />, <see cref="O.borderrightcolor" />, <see cref="O.bordertopcolor" />, <see cref="O.bullet" />, <see cref="O.button" />, <see cref="O.bwmode" />, <see cref="O.bwnormal" />, <see cref="O.bwpure" />, <see cref="O.clip" />, <see cref="O.cliptowrap" />, <see cref="O.connectortype" />, <see cref="O.dgmlayout" />, <see cref="O.dgmlayoutmru" />, <see cref="O.dgmnodekind" />, <see cref="O.doubleclicknotify" />, <see cref="O.forcedash" />, <see cref="O.gfxdata" />, <see cref="O.hr" />, <see cref="O.hralign" />, <see cref="O.hrnoshade" />, <see cref="O.hrpct" />, <see cref="O.hrstd" />, <see cref="O.insetmode" />, <see cref="O.ole" />, <see cref="O.oleicon" />, <see cref="O.oned" />, <see cref="O.preferrelative" />, <see cref="O.regroupid" />, <see cref="O.spid" />, <see cref="O.spt" />, <see cref="O.userdrawn" />, <see cref="O.userhidden" />, <see cref="NoNamespace.path" />, <see cref="NoNamespace.print" />, <see cref="NoNamespace.strokecolor" />, <see cref="NoNamespace.stroked" />, <see cref="NoNamespace.strokeweight" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.target" />, <see cref="NoNamespace.title" />, <see cref="NoNamespace.type" />, <see cref="NoNamespace.wrapcoords" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shape = v + "shape";

        /// <summary>
        /// Represents the v:shapetype XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="group" />, <see cref="W.@object" />, <see cref="W.pict" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.callout" />, <see cref="O.clippath" />, <see cref="O.complex" />, <see cref="O.extrusion" />, <see cref="O.@lock" />, <see cref="O.signatureline" />, <see cref="O.skew" />, <see cref="PVML.textdata" />, <see cref="fill" />, <see cref="formulas" />, <see cref="handles" />, <see cref="imagedata" />, <see cref="path" />, <see cref="shadow" />, <see cref="stroke" />, <see cref="textbox" />, <see cref="textpath" />, <see cref="W10.anchorlock" />, <see cref="W10.borderbottom" />, <see cref="W10.borderleft" />, <see cref="W10.borderright" />, <see cref="W10.bordertop" />, <see cref="W10.wrap" />, <see cref="XVML.ClientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.adj" />, <see cref="NoNamespace.alt" />, <see cref="NoNamespace.@class" />, <see cref="NoNamespace.coordorigin" />, <see cref="NoNamespace.coordsize" />, <see cref="NoNamespace.fillcolor" />, <see cref="NoNamespace.filled" />, <see cref="NoNamespace.href" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.insetpen" />, <see cref="O.allowincell" />, <see cref="O.allowoverlap" />, <see cref="O.borderbottomcolor" />, <see cref="O.borderleftcolor" />, <see cref="O.borderrightcolor" />, <see cref="O.bordertopcolor" />, <see cref="O.bullet" />, <see cref="O.button" />, <see cref="O.bwmode" />, <see cref="O.bwnormal" />, <see cref="O.bwpure" />, <see cref="O.clip" />, <see cref="O.cliptowrap" />, <see cref="O.connectortype" />, <see cref="O.dgmlayout" />, <see cref="O.dgmlayoutmru" />, <see cref="O.dgmnodekind" />, <see cref="O.doubleclicknotify" />, <see cref="O.forcedash" />, <see cref="O.hr" />, <see cref="O.hralign" />, <see cref="O.hrnoshade" />, <see cref="O.hrpct" />, <see cref="O.hrstd" />, <see cref="O.insetmode" />, <see cref="O.master" />, <see cref="O.ole" />, <see cref="O.oleicon" />, <see cref="O.oned" />, <see cref="O.preferrelative" />, <see cref="O.regroupid" />, <see cref="O.spid" />, <see cref="O.spt" />, <see cref="O.userdrawn" />, <see cref="O.userhidden" />, <see cref="NoNamespace.path" />, <see cref="NoNamespace.print" />, <see cref="NoNamespace.strokecolor" />, <see cref="NoNamespace.stroked" />, <see cref="NoNamespace.strokeweight" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.target" />, <see cref="NoNamespace.title" />, <see cref="NoNamespace.wrapcoords" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shapetype.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shapetype = v + "shapetype";

        /// <summary>
        /// Represents the v:stroke XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="O.shapedefaults" />, <see cref="arc" />, <see cref="curve" />, <see cref="image" />, <see cref="line" />, <see cref="oval" />, <see cref="polyline" />, <see cref="rect" />, <see cref="roundrect" />, <see cref="shape" />, <see cref="shapetype" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.bottom" />, <see cref="O.column" />, <see cref="O.left" />, <see cref="O.right" />, <see cref="O.top" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.color" />, <see cref="NoNamespace.color2" />, <see cref="NoNamespace.dashstyle" />, <see cref="NoNamespace.endarrow" />, <see cref="NoNamespace.endarrowlength" />, <see cref="NoNamespace.endarrowwidth" />, <see cref="NoNamespace.endcap" />, <see cref="NoNamespace.filltype" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.imagealignshape" />, <see cref="NoNamespace.imageaspect" />, <see cref="NoNamespace.imagesize" />, <see cref="NoNamespace.insetpen" />, <see cref="NoNamespace.joinstyle" />, <see cref="NoNamespace.linestyle" />, <see cref="NoNamespace.miterlimit" />, <see cref="O.althref" />, <see cref="O.forcedash" />, <see cref="O.href" />, <see cref="O.title" />, <see cref="NoNamespace.on" />, <see cref="NoNamespace.opacity" />, <see cref="R.id" />, <see cref="NoNamespace.src" />, <see cref="NoNamespace.startarrow" />, <see cref="NoNamespace.startarrowlength" />, <see cref="NoNamespace.startarrowwidth" />, <see cref="NoNamespace.weight" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Stroke.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName stroke = v + "stroke";

        /// <summary>
        /// Represents the v:textbox XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="O.shapedefaults" />, <see cref="arc" />, <see cref="curve" />, <see cref="image" />, <see cref="line" />, <see cref="oval" />, <see cref="polyline" />, <see cref="rect" />, <see cref="roundrect" />, <see cref="shape" />, <see cref="shapetype" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="W.txbxContent" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.inset" />, <see cref="O.singleclick" />, <see cref="NoNamespace.style" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName textbox = v + "textbox";

        /// <summary>
        /// Represents the v:textpath XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="arc" />, <see cref="curve" />, <see cref="image" />, <see cref="line" />, <see cref="oval" />, <see cref="polyline" />, <see cref="rect" />, <see cref="roundrect" />, <see cref="shape" />, <see cref="shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fitpath" />, <see cref="NoNamespace.fitshape" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.on" />, <see cref="NoNamespace.@string" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.trim" />, <see cref="NoNamespace.xscale" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextPath.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName textpath = v + "textpath";
    }
}
