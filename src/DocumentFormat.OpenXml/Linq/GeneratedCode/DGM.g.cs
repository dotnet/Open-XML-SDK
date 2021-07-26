// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:dgm="http://schemas.openxmlformats.org/drawingml/2006/diagram" namespace.
    /// </summary>
    public static class DGM
    {
        /// <summary>
        /// Defines the XML namespace associated with the dgm prefix.
        /// </summary>
        public static readonly XNamespace dgm = "http://schemas.openxmlformats.org/drawingml/2006/diagram";

        /// <summary>
        /// Represents the dgm:adj XML element.
        /// </summary>
        public static readonly XName adj = dgm + "adj";

        /// <summary>
        /// Represents the dgm:adjLst XML element.
        /// </summary>
        public static readonly XName adjLst = dgm + "adjLst";

        /// <summary>
        /// Represents the dgm:alg XML element.
        /// </summary>
        public static readonly XName alg = dgm + "alg";

        /// <summary>
        /// Represents the dgm:animLvl XML element.
        /// </summary>
        public static readonly XName animLvl = dgm + "animLvl";

        /// <summary>
        /// Represents the dgm:animOne XML element.
        /// </summary>
        public static readonly XName animOne = dgm + "animOne";

        /// <summary>
        /// Represents the dgm:bg XML element.
        /// </summary>
        public static readonly XName bg = dgm + "bg";

        /// <summary>
        /// Represents the dgm:bulletEnabled XML element.
        /// </summary>
        public static readonly XName bulletEnabled = dgm + "bulletEnabled";

        /// <summary>
        /// Represents the dgm:cat XML elements.
        /// </summary>
        public static readonly XName cat = dgm + "cat";

        /// <summary>
        /// Represents the dgm:catLst XML elements.
        /// </summary>
        public static readonly XName catLst = dgm + "catLst";

        /// <summary>
        /// Represents the dgm:chMax XML element.
        /// </summary>
        public static readonly XName chMax = dgm + "chMax";

        /// <summary>
        /// Represents the dgm:choose XML element.
        /// </summary>
        public static readonly XName choose = dgm + "choose";

        /// <summary>
        /// Represents the dgm:chPref XML element.
        /// </summary>
        public static readonly XName chPref = dgm + "chPref";

        /// <summary>
        /// Represents the dgm:clrData XML element.
        /// </summary>
        public static readonly XName clrData = dgm + "clrData";

        /// <summary>
        /// Represents the dgm:colorsDef XML element.
        /// </summary>
        public static readonly XName colorsDef = dgm + "colorsDef";

        /// <summary>
        /// Represents the dgm:colorsDefHdr XML element.
        /// </summary>
        public static readonly XName colorsDefHdr = dgm + "colorsDefHdr";

        /// <summary>
        /// Represents the dgm:colorsDefHdrLst XML element.
        /// </summary>
        public static readonly XName colorsDefHdrLst = dgm + "colorsDefHdrLst";

        /// <summary>
        /// Represents the dgm:constr XML element.
        /// </summary>
        public static readonly XName constr = dgm + "constr";

        /// <summary>
        /// Represents the dgm:constrLst XML element.
        /// </summary>
        public static readonly XName constrLst = dgm + "constrLst";

        /// <summary>
        /// Represents the dgm:cxn XML element.
        /// </summary>
        public static readonly XName cxn = dgm + "cxn";

        /// <summary>
        /// Represents the dgm:cxnLst XML element.
        /// </summary>
        public static readonly XName cxnLst = dgm + "cxnLst";

        /// <summary>
        /// Represents the dgm:dataModel XML elements.
        /// </summary>
        public static readonly XName dataModel = dgm + "dataModel";

        /// <summary>
        /// Represents the dgm:desc XML elements.
        /// </summary>
        public static readonly XName desc = dgm + "desc";

        /// <summary>
        /// Represents the dgm:dir XML element.
        /// </summary>
        public static readonly XName dir = dgm + "dir";

        /// <summary>
        /// Represents the dgm:effectClrLst XML element.
        /// </summary>
        public static readonly XName effectClrLst = dgm + "effectClrLst";

        /// <summary>
        /// Represents the dgm:else XML element.
        /// </summary>
        public static readonly XName @else = dgm + "else";

        /// <summary>
        /// Represents the dgm:ext XML element.
        /// </summary>
        public static readonly XName ext = dgm + "ext";

        /// <summary>
        /// Represents the dgm:extLst XML elements.
        /// </summary>
        public static readonly XName extLst = dgm + "extLst";

        /// <summary>
        /// Represents the dgm:fillClrLst XML element.
        /// </summary>
        public static readonly XName fillClrLst = dgm + "fillClrLst";

        /// <summary>
        /// Represents the dgm:forEach XML element.
        /// </summary>
        public static readonly XName forEach = dgm + "forEach";

        /// <summary>
        /// Represents the dgm:hierBranch XML element.
        /// </summary>
        public static readonly XName hierBranch = dgm + "hierBranch";

        /// <summary>
        /// Represents the dgm:if XML element.
        /// </summary>
        public static readonly XName @if = dgm + "if";

        /// <summary>
        /// Represents the dgm:layoutDef XML element.
        /// </summary>
        public static readonly XName layoutDef = dgm + "layoutDef";

        /// <summary>
        /// Represents the dgm:layoutDefHdr XML element.
        /// </summary>
        public static readonly XName layoutDefHdr = dgm + "layoutDefHdr";

        /// <summary>
        /// Represents the dgm:layoutDefHdrLst XML element.
        /// </summary>
        public static readonly XName layoutDefHdrLst = dgm + "layoutDefHdrLst";

        /// <summary>
        /// Represents the dgm:layoutNode XML element.
        /// </summary>
        public static readonly XName layoutNode = dgm + "layoutNode";

        /// <summary>
        /// Represents the dgm:linClrLst XML element.
        /// </summary>
        public static readonly XName linClrLst = dgm + "linClrLst";

        /// <summary>
        /// Represents the dgm:orgChart XML element.
        /// </summary>
        public static readonly XName orgChart = dgm + "orgChart";

        /// <summary>
        /// Represents the dgm:param XML element.
        /// </summary>
        public static readonly XName param = dgm + "param";

        /// <summary>
        /// Represents the dgm:presLayoutVars XML element.
        /// </summary>
        public static readonly XName presLayoutVars = dgm + "presLayoutVars";

        /// <summary>
        /// Represents the dgm:presOf XML element.
        /// </summary>
        public static readonly XName presOf = dgm + "presOf";

        /// <summary>
        /// Represents the dgm:prSet XML element.
        /// </summary>
        public static readonly XName prSet = dgm + "prSet";

        /// <summary>
        /// Represents the dgm:pt XML element.
        /// </summary>
        public static readonly XName pt = dgm + "pt";

        /// <summary>
        /// Represents the dgm:ptLst XML element.
        /// </summary>
        public static readonly XName ptLst = dgm + "ptLst";

        /// <summary>
        /// Represents the dgm:relIds XML element.
        /// </summary>
        public static readonly XName relIds = dgm + "relIds";

        /// <summary>
        /// Represents the dgm:resizeHandles XML element.
        /// </summary>
        public static readonly XName resizeHandles = dgm + "resizeHandles";

        /// <summary>
        /// Represents the dgm:rule XML element.
        /// </summary>
        public static readonly XName rule = dgm + "rule";

        /// <summary>
        /// Represents the dgm:ruleLst XML element.
        /// </summary>
        public static readonly XName ruleLst = dgm + "ruleLst";

        /// <summary>
        /// Represents the dgm:sampData XML element.
        /// </summary>
        public static readonly XName sampData = dgm + "sampData";

        /// <summary>
        /// Represents the dgm:scene3d XML element.
        /// </summary>
        public static readonly XName scene3d = dgm + "scene3d";

        /// <summary>
        /// Represents the dgm:shape XML element.
        /// </summary>
        public static readonly XName shape = dgm + "shape";

        /// <summary>
        /// Represents the dgm:sp3d XML element.
        /// </summary>
        public static readonly XName sp3d = dgm + "sp3d";

        /// <summary>
        /// Represents the dgm:spPr XML element.
        /// </summary>
        public static readonly XName spPr = dgm + "spPr";

        /// <summary>
        /// Represents the dgm:style XML element.
        /// </summary>
        public static readonly XName style = dgm + "style";

        /// <summary>
        /// Represents the dgm:styleData XML element.
        /// </summary>
        public static readonly XName styleData = dgm + "styleData";

        /// <summary>
        /// Represents the dgm:styleDef XML element.
        /// </summary>
        public static readonly XName styleDef = dgm + "styleDef";

        /// <summary>
        /// Represents the dgm:styleDefHdr XML element.
        /// </summary>
        public static readonly XName styleDefHdr = dgm + "styleDefHdr";

        /// <summary>
        /// Represents the dgm:styleDefHdrLst XML element.
        /// </summary>
        public static readonly XName styleDefHdrLst = dgm + "styleDefHdrLst";

        /// <summary>
        /// Represents the dgm:styleLbl XML elements.
        /// </summary>
        public static readonly XName styleLbl = dgm + "styleLbl";

        /// <summary>
        /// Represents the dgm:t XML element.
        /// </summary>
        public static readonly XName t = dgm + "t";

        /// <summary>
        /// Represents the dgm:title XML elements.
        /// </summary>
        public static readonly XName title = dgm + "title";

        /// <summary>
        /// Represents the dgm:txEffectClrLst XML element.
        /// </summary>
        public static readonly XName txEffectClrLst = dgm + "txEffectClrLst";

        /// <summary>
        /// Represents the dgm:txFillClrLst XML element.
        /// </summary>
        public static readonly XName txFillClrLst = dgm + "txFillClrLst";

        /// <summary>
        /// Represents the dgm:txLinClrLst XML element.
        /// </summary>
        public static readonly XName txLinClrLst = dgm + "txLinClrLst";

        /// <summary>
        /// Represents the dgm:txPr XML element.
        /// </summary>
        public static readonly XName txPr = dgm + "txPr";

        /// <summary>
        /// Represents the dgm:varLst XML element.
        /// </summary>
        public static readonly XName varLst = dgm + "varLst";

        /// <summary>
        /// Represents the dgm:whole XML element.
        /// </summary>
        public static readonly XName whole = dgm + "whole";
    }
}
