// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:dsp="http://schemas.microsoft.com/office/drawing/2008/diagram" namespace.
    /// </summary>
    public static class DSP
    {
        /// <summary>
        /// Defines the XML namespace associated with the dsp prefix.
        /// </summary>
        public static readonly XNamespace dsp = "http://schemas.microsoft.com/office/drawing/2008/diagram";

        /// <summary>
        /// Represents the dsp:cNvGrpSpPr XML element.
        /// </summary>
        public static readonly XName cNvGrpSpPr = dsp + "cNvGrpSpPr";

        /// <summary>
        /// Represents the dsp:cNvPr XML element.
        /// </summary>
        public static readonly XName cNvPr = dsp + "cNvPr";

        /// <summary>
        /// Represents the dsp:cNvSpPr XML element.
        /// </summary>
        public static readonly XName cNvSpPr = dsp + "cNvSpPr";

        /// <summary>
        /// Represents the dsp:dataModelExt XML element.
        /// </summary>
        public static readonly XName dataModelExt = dsp + "dataModelExt";

        /// <summary>
        /// Represents the dsp:drawing XML element.
        /// </summary>
        public static readonly XName drawing = dsp + "drawing";

        /// <summary>
        /// Represents the dsp:extLst XML element.
        /// </summary>
        public static readonly XName extLst = dsp + "extLst";

        /// <summary>
        /// Represents the dsp:grpSp XML element.
        /// </summary>
        public static readonly XName grpSp = dsp + "grpSp";

        /// <summary>
        /// Represents the dsp:grpSpPr XML element.
        /// </summary>
        public static readonly XName grpSpPr = dsp + "grpSpPr";

        /// <summary>
        /// Represents the dsp:nvGrpSpPr XML element.
        /// </summary>
        public static readonly XName nvGrpSpPr = dsp + "nvGrpSpPr";

        /// <summary>
        /// Represents the dsp:nvSpPr XML element.
        /// </summary>
        public static readonly XName nvSpPr = dsp + "nvSpPr";

        /// <summary>
        /// Represents the dsp:sp XML element.
        /// </summary>
        public static readonly XName sp = dsp + "sp";

        /// <summary>
        /// Represents the dsp:spPr XML element.
        /// </summary>
        public static readonly XName spPr = dsp + "spPr";

        /// <summary>
        /// Represents the dsp:spTree XML element.
        /// </summary>
        public static readonly XName spTree = dsp + "spTree";

        /// <summary>
        /// Represents the dsp:style XML element.
        /// </summary>
        public static readonly XName style = dsp + "style";

        /// <summary>
        /// Represents the dsp:txBody XML element.
        /// </summary>
        public static readonly XName txBody = dsp + "txBody";

        /// <summary>
        /// Represents the dsp:txXfrm XML element.
        /// </summary>
        public static readonly XName txXfrm = dsp + "txXfrm";
    }
}
