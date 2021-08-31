// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:o="urn:schemas-microsoft-com:office:office" namespace.
    /// </summary>
    public static class O
    {
        /// <summary>
        /// Defines the XML namespace associated with the o prefix.
        /// </summary>
        public static readonly XNamespace o = "urn:schemas-microsoft-com:office:office";

        /// <summary>
        /// Represents the o:allowincell XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="shapedefaults" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.AllowInCell, Curve.AllowInCell, Group.AllowInCell, ImageFile.AllowInCell, Line.AllowInCell, Oval.AllowInCell, PolyLine.AllowInCell, Rectangle.AllowInCell, RoundRectangle.AllowInCell, Shape.AllowInCell, ShapeDefaults.AllowInCell, Shapetype.AllowInCell.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName allowincell = o + "allowincell";

        /// <summary>
        /// Represents the o:allowoverlap XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="shapedefaults" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.AllowOverlap, Curve.AllowOverlap, Group.AllowOverlap, ImageFile.AllowOverlap, Line.AllowOverlap, Oval.AllowOverlap, PolyLine.AllowOverlap, Rectangle.AllowOverlap, RoundRectangle.AllowOverlap, Shape.AllowOverlap, ShapeDefaults.AllowOverlap, Shapetype.AllowOverlap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName allowoverlap = o + "allowoverlap";

        /// <summary>
        /// Represents the o:althref XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bottom" />, <see cref="column" />, <see cref="left" />, <see cref="right" />, <see cref="top" />, <see cref="V.fill" />, <see cref="V.stroke" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BottomStroke.AlternateImageReference, ColumnStroke.AlternateImageReference, Fill.AlternateImageReference, LeftStroke.AlternateImageReference, RightStroke.AlternateImageReference, Stroke.AlternateImageReference, TopStroke.AlternateImageReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName althref = o + "althref";

        /// <summary>
        /// Represents the o:borderbottomcolor XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.BorderBottomColor, Curve.BorderBottomColor, ImageFile.BorderBottomColor, Line.BorderBottomColor, Oval.BorderBottomColor, PolyLine.BorderBottomColor, Rectangle.BorderBottomColor, RoundRectangle.BorderBottomColor, Shape.BorderBottomColor, Shapetype.BorderBottomColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName borderbottomcolor = o + "borderbottomcolor";

        /// <summary>
        /// Represents the o:borderleftcolor XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.BorderLeftColor, Curve.BorderLeftColor, ImageFile.BorderLeftColor, Line.BorderLeftColor, Oval.BorderLeftColor, PolyLine.BorderLeftColor, Rectangle.BorderLeftColor, RoundRectangle.BorderLeftColor, Shape.BorderLeftColor, Shapetype.BorderLeftColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName borderleftcolor = o + "borderleftcolor";

        /// <summary>
        /// Represents the o:borderrightcolor XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.BorderRightColor, Curve.BorderRightColor, ImageFile.BorderRightColor, Line.BorderRightColor, Oval.BorderRightColor, PolyLine.BorderRightColor, Rectangle.BorderRightColor, RoundRectangle.BorderRightColor, Shape.BorderRightColor, Shapetype.BorderRightColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName borderrightcolor = o + "borderrightcolor";

        /// <summary>
        /// Represents the o:bordertopcolor XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.BorderTopColor, Curve.BorderTopColor, ImageFile.BorderTopColor, Line.BorderTopColor, Oval.BorderTopColor, PolyLine.BorderTopColor, Rectangle.BorderTopColor, RoundRectangle.BorderTopColor, Shape.BorderTopColor, Shapetype.BorderTopColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bordertopcolor = o + "bordertopcolor";

        /// <summary>
        /// Represents the o:bottom XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.stroke" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.color" />, <see cref="NoNamespace.color2" />, <see cref="NoNamespace.dashstyle" />, <see cref="NoNamespace.endarrow" />, <see cref="NoNamespace.endarrowlength" />, <see cref="NoNamespace.endarrowwidth" />, <see cref="NoNamespace.endcap" />, <see cref="NoNamespace.filltype" />, <see cref="NoNamespace.imagealignshape" />, <see cref="NoNamespace.imageaspect" />, <see cref="NoNamespace.imagesize" />, <see cref="NoNamespace.insetpen" />, <see cref="NoNamespace.joinstyle" />, <see cref="NoNamespace.linestyle" />, <see cref="NoNamespace.miterlimit" />, <see cref="althref" />, <see cref="forcedash" />, <see cref="href" />, <see cref="title" />, <see cref="NoNamespace.on" />, <see cref="NoNamespace.opacity" />, <see cref="NoNamespace.src" />, <see cref="NoNamespace.startarrow" />, <see cref="NoNamespace.startarrowlength" />, <see cref="NoNamespace.startarrowwidth" />, <see cref="V.ext" />, <see cref="NoNamespace.weight" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BottomStroke.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bottom = o + "bottom";

        /// <summary>
        /// Represents the o:bullet XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Bullet, Curve.Bullet, Group.Bullet, ImageFile.Bullet, Line.Bullet, Oval.Bullet, PolyLine.Bullet, Rectangle.Bullet, RoundRectangle.Bullet, Shape.Bullet, Shapetype.Bullet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bullet = o + "bullet";

        /// <summary>
        /// Represents the o:button XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Button, Curve.Button, Group.Button, ImageFile.Button, Line.Button, Oval.Button, PolyLine.Button, Rectangle.Button, RoundRectangle.Button, Shape.Button, Shapetype.Button.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName button = o + "button";

        /// <summary>
        /// Represents the o:bwmode XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.background" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.BlackWhiteMode, Background.BlackWhiteMode, Curve.BlackWhiteMode, ImageFile.BlackWhiteMode, Line.BlackWhiteMode, Oval.BlackWhiteMode, PolyLine.BlackWhiteMode, Rectangle.BlackWhiteMode, RoundRectangle.BlackWhiteMode, Shape.BlackWhiteMode, Shapetype.BlackWhiteMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bwmode = o + "bwmode";

        /// <summary>
        /// Represents the o:bwnormal XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.background" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.NormalBlackWhiteMode, Background.NormalBlackWhiteMode, Curve.NormalBlackWhiteMode, ImageFile.NormalBlackWhiteMode, Line.NormalBlackWhiteMode, Oval.NormalBlackWhiteMode, PolyLine.NormalBlackWhiteMode, Rectangle.NormalBlackWhiteMode, RoundRectangle.NormalBlackWhiteMode, Shape.NormalBlackWhiteMode, Shapetype.NormalBlackWhiteMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bwnormal = o + "bwnormal";

        /// <summary>
        /// Represents the o:bwpure XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.background" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.PureBlackWhiteMode, Background.PureBlackWhiteMode, Curve.PureBlackWhiteMode, ImageFile.PureBlackWhiteMode, Line.PureBlackWhiteMode, Oval.PureBlackWhiteMode, PolyLine.PureBlackWhiteMode, Rectangle.PureBlackWhiteMode, RoundRectangle.PureBlackWhiteMode, Shape.PureBlackWhiteMode, Shapetype.PureBlackWhiteMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bwpure = o + "bwpure";

        /// <summary>
        /// Represents the o:callout XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="shapedefaults" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.accentbar" />, <see cref="NoNamespace.angle" />, <see cref="NoNamespace.distance" />, <see cref="NoNamespace.drop" />, <see cref="NoNamespace.dropauto" />, <see cref="NoNamespace.gap" />, <see cref="NoNamespace.length" />, <see cref="NoNamespace.lengthspecified" />, <see cref="NoNamespace.minusx" />, <see cref="NoNamespace.minusy" />, <see cref="NoNamespace.on" />, <see cref="NoNamespace.textborder" />, <see cref="NoNamespace.type" />, <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Callout.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName callout = o + "callout";

        /// <summary>
        /// Represents the o:clip XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Clip, Curve.Clip, ImageFile.Clip, Line.Clip, Oval.Clip, PolyLine.Clip, Rectangle.Clip, RoundRectangle.Clip, Shape.Clip, Shapetype.Clip.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clip = o + "clip";

        /// <summary>
        /// Represents the o:clippath XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="v" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ClipPath.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clippath = o + "clippath";

        /// <summary>
        /// Represents the o:cliptowrap XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.ClipToWrap, Curve.ClipToWrap, ImageFile.ClipToWrap, Line.ClipToWrap, Oval.ClipToWrap, PolyLine.ClipToWrap, Rectangle.ClipToWrap, RoundRectangle.ClipToWrap, Shape.ClipToWrap, Shapetype.ClipToWrap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cliptowrap = o + "cliptowrap";

        /// <summary>
        /// Represents the o:colormenu XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="shapedefaults" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.extrusioncolor" />, <see cref="NoNamespace.fillcolor" />, <see cref="NoNamespace.shadowcolor" />, <see cref="NoNamespace.strokecolor" />, <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorMenu.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colormenu = o + "colormenu";

        /// <summary>
        /// Represents the o:colormru XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="shapedefaults" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.colors" />, <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorMostRecentlyUsed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colormru = o + "colormru";

        /// <summary>
        /// Represents the o:column XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.stroke" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.color" />, <see cref="NoNamespace.color2" />, <see cref="NoNamespace.dashstyle" />, <see cref="NoNamespace.endarrow" />, <see cref="NoNamespace.endarrowlength" />, <see cref="NoNamespace.endarrowwidth" />, <see cref="NoNamespace.endcap" />, <see cref="NoNamespace.filltype" />, <see cref="NoNamespace.imagealignshape" />, <see cref="NoNamespace.imageaspect" />, <see cref="NoNamespace.imagesize" />, <see cref="NoNamespace.insetpen" />, <see cref="NoNamespace.joinstyle" />, <see cref="NoNamespace.linestyle" />, <see cref="NoNamespace.miterlimit" />, <see cref="althref" />, <see cref="forcedash" />, <see cref="href" />, <see cref="title" />, <see cref="NoNamespace.on" />, <see cref="NoNamespace.opacity" />, <see cref="NoNamespace.src" />, <see cref="NoNamespace.startarrow" />, <see cref="NoNamespace.startarrowlength" />, <see cref="NoNamespace.startarrowwidth" />, <see cref="V.ext" />, <see cref="NoNamespace.weight" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnStroke.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName column = o + "column";

        /// <summary>
        /// Represents the o:complex XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Complex.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName complex = o + "complex";

        /// <summary>
        /// Represents the o:connectangles XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.path" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Path.ConnectAngles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName connectangles = o + "connectangles";

        /// <summary>
        /// Represents the o:connectlocs XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.path" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Path.ConnectionPoints.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName connectlocs = o + "connectlocs";

        /// <summary>
        /// Represents the o:connectortype XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.ConnectorType, Curve.ConnectorType, ImageFile.ConnectorType, Line.ConnectorType, Oval.ConnectorType, PolyLine.ConnectorType, Rectangle.ConnectorType, RoundRectangle.ConnectorType, Shape.ConnectorType, Shapetype.ConnectorType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName connectortype = o + "connectortype";

        /// <summary>
        /// Represents the o:connecttype XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.path" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Path.ConnectionPointType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName connecttype = o + "connecttype";

        /// <summary>
        /// Represents the o:detectmouseclick XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.fill" />, <see cref="V.imagedata" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Fill.DetectMouseClick, ImageData.DetectMouseClick.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName detectmouseclick = o + "detectmouseclick";

        /// <summary>
        /// Represents the o:dgmlayout XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.DiagramLayout, Curve.DiagramLayout, Group.DiagramLayout, ImageFile.DiagramLayout, Line.DiagramLayout, Oval.DiagramLayout, PolyLine.DiagramLayout, Rectangle.DiagramLayout, RoundRectangle.DiagramLayout, Shape.DiagramLayout, Shapetype.DiagramLayout.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dgmlayout = o + "dgmlayout";

        /// <summary>
        /// Represents the o:dgmlayoutmru XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.DiagramLayoutMostRecentUsed, Curve.DiagramLayoutMostRecentUsed, Group.DiagramLayoutMostRecentUsed, ImageFile.DiagramLayoutMostRecentUsed, Line.DiagramLayoutMostRecentUsed, Oval.DiagramLayoutMostRecentUsed, PolyLine.DiagramLayoutMostRecentUsed, Rectangle.DiagramLayoutMostRecentUsed, RoundRectangle.DiagramLayoutMostRecentUsed, Shape.DiagramLayoutMostRecentUsed, Shapetype.DiagramLayoutMostRecentUsed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dgmlayoutmru = o + "dgmlayoutmru";

        /// <summary>
        /// Represents the o:dgmnodekind XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.DiagramNodeKind, Curve.DiagramNodeKind, Group.DiagramNodeKind, ImageFile.DiagramNodeKind, Line.DiagramNodeKind, Oval.DiagramNodeKind, PolyLine.DiagramNodeKind, Rectangle.DiagramNodeKind, RoundRectangle.DiagramNodeKind, Shape.DiagramNodeKind, Shapetype.DiagramNodeKind.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dgmnodekind = o + "dgmnodekind";

        /// <summary>
        /// Represents the o:diagram XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.group" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="relationtable" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autoformat" />, <see cref="NoNamespace.autolayout" />, <see cref="NoNamespace.constrainbounds" />, <see cref="NoNamespace.dgmbasetextscale" />, <see cref="NoNamespace.dgmfontsize" />, <see cref="NoNamespace.dgmscalex" />, <see cref="NoNamespace.dgmscaley" />, <see cref="NoNamespace.dgmstyle" />, <see cref="NoNamespace.reverse" />, <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Diagram.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName diagram = o + "diagram";

        /// <summary>
        /// Represents the o:doubleclicknotify XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.DoubleClickNotify, Curve.DoubleClickNotify, Group.DoubleClickNotify, ImageFile.DoubleClickNotify, Line.DoubleClickNotify, Oval.DoubleClickNotify, PolyLine.DoubleClickNotify, Rectangle.DoubleClickNotify, RoundRectangle.DoubleClickNotify, Shape.DoubleClickNotify, Shapetype.DoubleClickNotify.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doubleclicknotify = o + "doubleclicknotify";

        /// <summary>
        /// Represents the o:entry XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="regrouptable" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.@new" />, <see cref="NoNamespace.old" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Entry.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName entry = o + "entry";

        /// <summary>
        /// Represents the o:extrusion XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="shapedefaults" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autorotationcenter" />, <see cref="NoNamespace.backdepth" />, <see cref="NoNamespace.brightness" />, <see cref="NoNamespace.color" />, <see cref="NoNamespace.diffusity" />, <see cref="NoNamespace.edge" />, <see cref="NoNamespace.facet" />, <see cref="NoNamespace.foredepth" />, <see cref="NoNamespace.lightface" />, <see cref="NoNamespace.lightharsh" />, <see cref="NoNamespace.lightharsh2" />, <see cref="NoNamespace.lightlevel" />, <see cref="NoNamespace.lightlevel2" />, <see cref="NoNamespace.lightposition" />, <see cref="NoNamespace.lightposition2" />, <see cref="NoNamespace.lockrotationcenter" />, <see cref="NoNamespace.metal" />, <see cref="NoNamespace.on" />, <see cref="NoNamespace.orientation" />, <see cref="NoNamespace.orientationangle" />, <see cref="NoNamespace.render" />, <see cref="NoNamespace.rotationangle" />, <see cref="NoNamespace.rotationcenter" />, <see cref="NoNamespace.shininess" />, <see cref="NoNamespace.skewamt" />, <see cref="NoNamespace.skewangle" />, <see cref="NoNamespace.specularity" />, <see cref="NoNamespace.type" />, <see cref="V.ext" />, <see cref="NoNamespace.viewpoint" />, <see cref="NoNamespace.viewpointorigin" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Extrusion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extrusion = o + "extrusion";

        /// <summary>
        /// Represents the o:extrusionok XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.path" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Path.AllowExtrusion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extrusionok = o + "extrusionok";

        /// <summary>
        /// Represents the o:FieldCodes XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OLEObject" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FieldCodes.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName FieldCodes = o + "FieldCodes";

        /// <summary>
        /// Represents the o:fill XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.fill" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.type" />, <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FillExtendedProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fill = o + "fill";

        /// <summary>
        /// Represents the o:forcedash XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bottom" />, <see cref="column" />, <see cref="left" />, <see cref="right" />, <see cref="top" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />, <see cref="V.stroke" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.ForceDash, BottomStroke.ForceDash, ColumnStroke.ForceDash, Curve.ForceDash, ImageFile.ForceDash, LeftStroke.ForceDash, Line.ForceDash, Oval.ForceDash, PolyLine.ForceDash, Rectangle.ForceDash, RightStroke.ForceDash, RoundRectangle.ForceDash, Shape.ForceDash, Shapetype.ForceDash, Stroke.ForceDash, TopStroke.ForceDash.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName forcedash = o + "forcedash";

        /// <summary>
        /// Represents the o:gfxdata XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Gfxdata, Curve.Gfxdata, Group.Gfxdata, ImageFile.Gfxdata, Line.Gfxdata, Oval.Gfxdata, PolyLine.Gfxdata, Rectangle.Gfxdata, RoundRectangle.Gfxdata, Shape.EncodedPackage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gfxdata = o + "gfxdata";

        /// <summary>
        /// Represents the o:hr XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Horizontal, Curve.Horizontal, Group.Horizontal, ImageFile.Horizontal, Line.Horizontal, Oval.Horizontal, PolyLine.Horizontal, Rectangle.Horizontal, RoundRectangle.Horizontal, Shape.Horizontal, Shapetype.Horizontal.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hr = o + "hr";

        /// <summary>
        /// Represents the o:hralign XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.HorizontalAlignment, Curve.HorizontalAlignment, Group.HorizontalAlignment, ImageFile.HorizontalAlignment, Line.HorizontalAlignment, Oval.HorizontalAlignment, PolyLine.HorizontalAlignment, Rectangle.HorizontalAlignment, RoundRectangle.HorizontalAlignment, Shape.HorizontalAlignment, Shapetype.HorizontalAlignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hralign = o + "hralign";

        /// <summary>
        /// Represents the o:href XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bottom" />, <see cref="column" />, <see cref="left" />, <see cref="right" />, <see cref="top" />, <see cref="V.fill" />, <see cref="V.stroke" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BottomStroke.Href, ColumnStroke.Href, Fill.Href, LeftStroke.Href, RightStroke.Href, Stroke.Href, TopStroke.Href.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName href = o + "href";

        /// <summary>
        /// Represents the o:hrnoshade XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.HorizontalNoShade, Curve.HorizontalNoShade, Group.HorizontalNoShade, ImageFile.HorizontalNoShade, Line.HorizontalNoShade, Oval.HorizontalNoShade, PolyLine.HorizontalNoShade, Rectangle.HorizontalNoShade, RoundRectangle.HorizontalNoShade, Shape.HorizontalNoShade, Shapetype.HorizontalNoShade.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hrnoshade = o + "hrnoshade";

        /// <summary>
        /// Represents the o:hrpct XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.HorizontalPercentage, Curve.HorizontalPercentage, Group.HorizontalPercentage, ImageFile.HorizontalPercentage, Line.HorizontalPercentage, Oval.HorizontalPercentage, PolyLine.HorizontalPercentage, Rectangle.HorizontalPercentage, RoundRectangle.HorizontalPercentage, Shape.HorizontalPercentage, Shapetype.HorizontalPercentage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hrpct = o + "hrpct";

        /// <summary>
        /// Represents the o:hrstd XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.HorizontalStandard, Curve.HorizontalStandard, Group.HorizontalStandard, ImageFile.HorizontalStandard, Line.HorizontalStandard, Oval.HorizontalStandard, PolyLine.HorizontalStandard, Rectangle.HorizontalStandard, RoundRectangle.HorizontalStandard, Shape.HorizontalStandard, Shapetype.HorizontalStandard.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hrstd = o + "hrstd";

        /// <summary>
        /// Represents the o:idmap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="shapelayout" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.data" />, <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeIdMap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName idmap = o + "idmap";

        /// <summary>
        /// Represents the o:ink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.polyline" />, <see cref="V.shape" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.annotation" />, <see cref="NoNamespace.i" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Ink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ink = o + "ink";

        /// <summary>
        /// Represents the o:insetmode XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="shapedefaults" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.InsetMode, Curve.InsetMode, Group.InsetMode, ImageFile.InsetMode, Line.InsetMode, Oval.InsetMode, PolyLine.InsetMode, Rectangle.InsetMode, RoundRectangle.InsetMode, Shape.InsetMode, ShapeDefaults.InsetMode, Shapetype.InsetMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName insetmode = o + "insetmode";

        /// <summary>
        /// Represents the o:left XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.stroke" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.color" />, <see cref="NoNamespace.color2" />, <see cref="NoNamespace.dashstyle" />, <see cref="NoNamespace.endarrow" />, <see cref="NoNamespace.endarrowlength" />, <see cref="NoNamespace.endarrowwidth" />, <see cref="NoNamespace.endcap" />, <see cref="NoNamespace.filltype" />, <see cref="NoNamespace.imagealignshape" />, <see cref="NoNamespace.imageaspect" />, <see cref="NoNamespace.imagesize" />, <see cref="NoNamespace.insetpen" />, <see cref="NoNamespace.joinstyle" />, <see cref="NoNamespace.linestyle" />, <see cref="NoNamespace.miterlimit" />, <see cref="althref" />, <see cref="forcedash" />, <see cref="href" />, <see cref="title" />, <see cref="NoNamespace.on" />, <see cref="NoNamespace.opacity" />, <see cref="NoNamespace.src" />, <see cref="NoNamespace.startarrow" />, <see cref="NoNamespace.startarrowlength" />, <see cref="NoNamespace.startarrowwidth" />, <see cref="V.ext" />, <see cref="NoNamespace.weight" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LeftStroke.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName left = o + "left";

        /// <summary>
        /// Represents the o:LinkType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OLEObject" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LinkType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName LinkType = o + "LinkType";

        /// <summary>
        /// Represents the o:lock XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="shapedefaults" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.adjusthandles" />, <see cref="NoNamespace.aspectratio" />, <see cref="NoNamespace.cropping" />, <see cref="NoNamespace.grouping" />, <see cref="NoNamespace.position" />, <see cref="NoNamespace.rotation" />, <see cref="NoNamespace.selection" />, <see cref="NoNamespace.shapetype" />, <see cref="NoNamespace.text" />, <see cref="NoNamespace.ungrouping" />, <see cref="V.ext" />, <see cref="NoNamespace.verticies" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Lock.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @lock = o + "lock";

        /// <summary>
        /// Represents the o:LockedField XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="OLEObject" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LockedField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName LockedField = o + "LockedField";

        /// <summary>
        /// Represents the o:master XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Shapetype.Master.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName master = o + "master";

        /// <summary>
        /// Represents the o:ole XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Ole, Curve.Ole, ImageFile.Ole, Line.Ole, Oval.Ole, PolyLine.Ole, Rectangle.Ole, RoundRectangle.Ole, Shape.Ole, Shapetype.Ole.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ole = o + "ole";

        /// <summary>
        /// Represents the o:oleicon XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.OleIcon, Curve.OleIcon, ImageFile.OleIcon, Line.OleIcon, Oval.OleIcon, PolyLine.OleIcon, Rectangle.OleIcon, RoundRectangle.OleIcon, Shape.OleIcon, Shapetype.OleIcon.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oleicon = o + "oleicon";

        /// <summary>
        /// Represents the o:OLEObject XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.@object" />, <see cref="W.pict" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="FieldCodes" />, <see cref="LinkType" />, <see cref="LockedField" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.DrawAspect" />, <see cref="NoNamespace.ObjectID_" />, <see cref="NoNamespace.ProgID_" />, <see cref="R.id" />, <see cref="NoNamespace.ShapeID_" />, <see cref="NoNamespace.Type_" />, <see cref="NoNamespace.UpdateMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OleObject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName OLEObject = o + "OLEObject";

        /// <summary>
        /// Represents the o:oned XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Oned, Curve.Oned, Group.Oned, ImageFile.Oned, Line.Oned, Oval.Oned, PolyLine.Oned, Rectangle.Oned, RoundRectangle.Oned, Shape.Oned, Shapetype.Oned.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oned = o + "oned";

        /// <summary>
        /// Represents the o:opacity2 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.fill" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Fill.Opacity2.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName opacity2 = o + "opacity2";

        /// <summary>
        /// Represents the o:preferrelative XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.PreferRelative, Curve.PreferRelative, ImageFile.PreferRelative, Line.PreferRelative, Oval.PreferRelative, PolyLine.PreferRelative, Rectangle.PreferRelative, RoundRectangle.PreferRelative, Shape.PreferRelative, Shapetype.PreferRelative.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName preferrelative = o + "preferrelative";

        /// <summary>
        /// Represents the o:proxy XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="r" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.connectloc" />, <see cref="NoNamespace.end" />, <see cref="NoNamespace.idref" />, <see cref="NoNamespace.start" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Proxy.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName proxy = o + "proxy";

        /// <summary>
        /// Represents the o:r XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rules" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="proxy" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.how" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idref" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Rule.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName r = o + "r";

        /// <summary>
        /// Represents the o:regroupid XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.RegroupId, Curve.RegroupId, Group.RegroupId, ImageFile.RegroupId, Line.RegroupId, Oval.RegroupId, PolyLine.RegroupId, Rectangle.RegroupId, RoundRectangle.RegroupId, Shape.RegroupId, Shapetype.RegroupId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName regroupid = o + "regroupid";

        /// <summary>
        /// Represents the o:regrouptable XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="shapelayout" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="entry" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RegroupTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName regrouptable = o + "regrouptable";

        /// <summary>
        /// Represents the o:rel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="relationtable" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.idcntr" />, <see cref="NoNamespace.iddest" />, <see cref="NoNamespace.idsrc" />, <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Relation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rel = o + "rel";

        /// <summary>
        /// Represents the o:relationtable XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="diagram" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rel" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RelationTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName relationtable = o + "relationtable";

        /// <summary>
        /// Represents the o:relid XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.imagedata" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ImageData.RelId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName relid = o + "relid";

        /// <summary>
        /// Represents the o:right XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.stroke" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.color" />, <see cref="NoNamespace.color2" />, <see cref="NoNamespace.dashstyle" />, <see cref="NoNamespace.endarrow" />, <see cref="NoNamespace.endarrowlength" />, <see cref="NoNamespace.endarrowwidth" />, <see cref="NoNamespace.endcap" />, <see cref="NoNamespace.filltype" />, <see cref="NoNamespace.imagealignshape" />, <see cref="NoNamespace.imageaspect" />, <see cref="NoNamespace.imagesize" />, <see cref="NoNamespace.insetpen" />, <see cref="NoNamespace.joinstyle" />, <see cref="NoNamespace.linestyle" />, <see cref="NoNamespace.miterlimit" />, <see cref="althref" />, <see cref="forcedash" />, <see cref="href" />, <see cref="title" />, <see cref="NoNamespace.on" />, <see cref="NoNamespace.opacity" />, <see cref="NoNamespace.src" />, <see cref="NoNamespace.startarrow" />, <see cref="NoNamespace.startarrowlength" />, <see cref="NoNamespace.startarrowwidth" />, <see cref="V.ext" />, <see cref="NoNamespace.weight" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RightStroke.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName right = o + "right";

        /// <summary>
        /// Represents the o:rules XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="shapelayout" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="r" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Rules.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rules = o + "rules";

        /// <summary>
        /// Represents the o:shapedefaults XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.hdrShapeDefaults" />, <see cref="W.shapeDefaults" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="callout" />, <see cref="colormenu" />, <see cref="colormru" />, <see cref="extrusion" />, <see cref="@lock" />, <see cref="skew" />, <see cref="V.fill" />, <see cref="V.imagedata" />, <see cref="V.shadow" />, <see cref="V.stroke" />, <see cref="V.textbox" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fill" />, <see cref="NoNamespace.fillcolor" />, <see cref="allowincell" />, <see cref="allowoverlap" />, <see cref="insetmode" />, <see cref="NoNamespace.spidmax" />, <see cref="NoNamespace.stroke" />, <see cref="NoNamespace.strokecolor" />, <see cref="NoNamespace.style" />, <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeDefaults.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shapedefaults = o + "shapedefaults";

        /// <summary>
        /// Represents the o:shapelayout XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.hdrShapeDefaults" />, <see cref="W.shapeDefaults" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="idmap" />, <see cref="regrouptable" />, <see cref="rules" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeLayout.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shapelayout = o + "shapelayout";

        /// <summary>
        /// Represents the o:signatureline XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.addlxml" />, <see cref="NoNamespace.allowcomments" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.issignatureline" />, <see cref="suggestedsigner" />, <see cref="suggestedsigner2" />, <see cref="suggestedsigneremail" />, <see cref="NoNamespace.provid" />, <see cref="NoNamespace.showsigndate" />, <see cref="NoNamespace.signinginstructions" />, <see cref="NoNamespace.signinginstructionsset" />, <see cref="NoNamespace.sigprovurl" />, <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SignatureLine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName signatureline = o + "signatureline";

        /// <summary>
        /// Represents the o:singleclick XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.textbox" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TextBox.SingleClick.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName singleclick = o + "singleclick";

        /// <summary>
        /// Represents the o:skew XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="shapedefaults" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.matrix" />, <see cref="NoNamespace.offset" />, <see cref="NoNamespace.on" />, <see cref="NoNamespace.origin" />, <see cref="V.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Skew.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName skew = o + "skew";

        /// <summary>
        /// Represents the o:spid XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.OptionalString, Curve.OptionalString, Group.OptionalString, ImageFile.OptionalString, Line.OptionalString, Oval.OptionalString, PolyLine.OptionalString, Rectangle.OptionalString, RoundRectangle.OptionalString, Shape.OptionalString, Shapetype.OptionalString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spid = o + "spid";

        /// <summary>
        /// Represents the o:spt XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.OptionalNumber, Curve.OptionalNumber, ImageFile.OptionalNumber, Line.OptionalNumber, Oval.OptionalNumber, PolyLine.OptionalNumber, Rectangle.OptionalNumber, RoundRectangle.OptionalNumber, Shape.OptionalNumber, Shapetype.OptionalNumber.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spt = o + "spt";

        /// <summary>
        /// Represents the o:suggestedsigner XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="signatureline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SignatureLine.SuggestedSigner.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName suggestedsigner = o + "suggestedsigner";

        /// <summary>
        /// Represents the o:suggestedsigner2 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="signatureline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SignatureLine.SuggestedSigner2.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName suggestedsigner2 = o + "suggestedsigner2";

        /// <summary>
        /// Represents the o:suggestedsigneremail XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="signatureline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SignatureLine.SuggestedSignerEmail.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName suggestedsigneremail = o + "suggestedsigneremail";

        /// <summary>
        /// Represents the o:tablelimits XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.group" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Group.TableLimits.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tablelimits = o + "tablelimits";

        /// <summary>
        /// Represents the o:tableproperties XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.group" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Group.TableProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tableproperties = o + "tableproperties";

        /// <summary>
        /// Represents the o:targetscreensize XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.background" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Background.TargetScreenSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName targetscreensize = o + "targetscreensize";

        /// <summary>
        /// Represents the o:title XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bottom" />, <see cref="column" />, <see cref="left" />, <see cref="right" />, <see cref="top" />, <see cref="V.fill" />, <see cref="V.imagedata" />, <see cref="V.stroke" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BottomStroke.Title, ColumnStroke.Title, Fill.Title, ImageData.Title, LeftStroke.Title, RightStroke.Title, Stroke.Title, TopStroke.Title.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName title = o + "title";

        /// <summary>
        /// Represents the o:top XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.stroke" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.color" />, <see cref="NoNamespace.color2" />, <see cref="NoNamespace.dashstyle" />, <see cref="NoNamespace.endarrow" />, <see cref="NoNamespace.endarrowlength" />, <see cref="NoNamespace.endarrowwidth" />, <see cref="NoNamespace.endcap" />, <see cref="NoNamespace.filltype" />, <see cref="NoNamespace.imagealignshape" />, <see cref="NoNamespace.imageaspect" />, <see cref="NoNamespace.imagesize" />, <see cref="NoNamespace.insetpen" />, <see cref="NoNamespace.joinstyle" />, <see cref="NoNamespace.linestyle" />, <see cref="NoNamespace.miterlimit" />, <see cref="althref" />, <see cref="forcedash" />, <see cref="href" />, <see cref="title" />, <see cref="NoNamespace.on" />, <see cref="NoNamespace.opacity" />, <see cref="NoNamespace.src" />, <see cref="NoNamespace.startarrow" />, <see cref="NoNamespace.startarrowlength" />, <see cref="NoNamespace.startarrowwidth" />, <see cref="V.ext" />, <see cref="NoNamespace.weight" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TopStroke.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName top = o + "top";

        /// <summary>
        /// Represents the o:userdrawn XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.UserDrawn, Curve.UserDrawn, Group.UserDrawn, ImageFile.UserDrawn, Line.UserDrawn, Oval.UserDrawn, PolyLine.UserDrawn, Rectangle.UserDrawn, RoundRectangle.UserDrawn, Shape.UserDrawn, Shapetype.UserDrawn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName userdrawn = o + "userdrawn";

        /// <summary>
        /// Represents the o:userhidden XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.UserHidden, Curve.UserHidden, Group.UserHidden, ImageFile.UserHidden, Line.UserHidden, Oval.UserHidden, PolyLine.UserHidden, Rectangle.UserHidden, RoundRectangle.UserHidden, Shape.UserHidden, Shapetype.UserHidden.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName userhidden = o + "userhidden";

        /// <summary>
        /// Represents the o:v XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="clippath" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ClipPath.Value.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName v = o + "v";
    }
}
