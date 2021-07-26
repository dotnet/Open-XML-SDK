// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" namespace.
    /// </summary>
    public static class WP
    {
        /// <summary>
        /// Defines the XML namespace associated with the wp prefix.
        /// </summary>
        public static readonly XNamespace wp = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing";

        /// <summary>
        /// Represents the wp:align XML elements.
        /// </summary>
        public static readonly XName align = wp + "align";

        /// <summary>
        /// Represents the wp:anchor XML element.
        /// </summary>
        public static readonly XName anchor = wp + "anchor";

        /// <summary>
        /// Represents the wp:cNvGraphicFramePr XML element.
        /// </summary>
        public static readonly XName cNvGraphicFramePr = wp + "cNvGraphicFramePr";

        /// <summary>
        /// Represents the wp:docPr XML element.
        /// </summary>
        public static readonly XName docPr = wp + "docPr";

        /// <summary>
        /// Represents the wp:effectExtent XML element.
        /// </summary>
        public static readonly XName effectExtent = wp + "effectExtent";

        /// <summary>
        /// Represents the wp:extent XML element.
        /// </summary>
        public static readonly XName extent = wp + "extent";

        /// <summary>
        /// Represents the wp:inline XML element.
        /// </summary>
        public static readonly XName inline = wp + "inline";

        /// <summary>
        /// Represents the wp:lineTo XML element.
        /// </summary>
        public static readonly XName lineTo = wp + "lineTo";

        /// <summary>
        /// Represents the wp:positionH XML element.
        /// </summary>
        public static readonly XName positionH = wp + "positionH";

        /// <summary>
        /// Represents the wp:positionV XML element.
        /// </summary>
        public static readonly XName positionV = wp + "positionV";

        /// <summary>
        /// Represents the wp:posOffset XML element.
        /// </summary>
        public static readonly XName posOffset = wp + "posOffset";

        /// <summary>
        /// Represents the wp:simplePos XML element.
        /// </summary>
        public static readonly XName simplePos = wp + "simplePos";

        /// <summary>
        /// Represents the wp:start XML element.
        /// </summary>
        public static readonly XName start = wp + "start";

        /// <summary>
        /// Represents the wp:wrapNone XML element.
        /// </summary>
        public static readonly XName wrapNone = wp + "wrapNone";

        /// <summary>
        /// Represents the wp:wrapPolygon XML element.
        /// </summary>
        public static readonly XName wrapPolygon = wp + "wrapPolygon";

        /// <summary>
        /// Represents the wp:wrapSquare XML element.
        /// </summary>
        public static readonly XName wrapSquare = wp + "wrapSquare";

        /// <summary>
        /// Represents the wp:wrapThrough XML element.
        /// </summary>
        public static readonly XName wrapThrough = wp + "wrapThrough";

        /// <summary>
        /// Represents the wp:wrapTight XML element.
        /// </summary>
        public static readonly XName wrapTight = wp + "wrapTight";

        /// <summary>
        /// Represents the wp:wrapTopAndBottom XML element.
        /// </summary>
        public static readonly XName wrapTopAndBottom = wp + "wrapTopAndBottom";
    }
}
