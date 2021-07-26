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
        public static readonly XName arc = v + "arc";

        /// <summary>
        /// Represents the v:background XML element.
        /// </summary>
        public static readonly XName background = v + "background";

        /// <summary>
        /// Represents the v:curve XML element.
        /// </summary>
        public static readonly XName curve = v + "curve";

        /// <summary>
        /// Represents the v:ext XML attributes.
        /// </summary>
        public static readonly XName ext = v + "ext";

        /// <summary>
        /// Represents the v:f XML element.
        /// </summary>
        public static readonly XName f = v + "f";

        /// <summary>
        /// Represents the v:fill XML element.
        /// </summary>
        public static readonly XName fill = v + "fill";

        /// <summary>
        /// Represents the v:formulas XML element.
        /// </summary>
        public static readonly XName formulas = v + "formulas";

        /// <summary>
        /// Represents the v:group XML element.
        /// </summary>
        public static readonly XName group = v + "group";

        /// <summary>
        /// Represents the v:h XML element.
        /// </summary>
        public static readonly XName h = v + "h";

        /// <summary>
        /// Represents the v:handles XML element.
        /// </summary>
        public static readonly XName handles = v + "handles";

        /// <summary>
        /// Represents the v:image XML element.
        /// </summary>
        public static readonly XName image = v + "image";

        /// <summary>
        /// Represents the v:imagedata XML element.
        /// </summary>
        public static readonly XName imagedata = v + "imagedata";

        /// <summary>
        /// Represents the v:line XML element.
        /// </summary>
        public static readonly XName line = v + "line";

        /// <summary>
        /// Represents the v:oval XML element.
        /// </summary>
        public static readonly XName oval = v + "oval";

        /// <summary>
        /// Represents the v:path XML element.
        /// </summary>
        public static readonly XName path = v + "path";

        /// <summary>
        /// Represents the v:polyline XML element.
        /// </summary>
        public static readonly XName polyline = v + "polyline";

        /// <summary>
        /// Represents the v:rect XML element.
        /// </summary>
        public static readonly XName rect = v + "rect";

        /// <summary>
        /// Represents the v:roundrect XML element.
        /// </summary>
        public static readonly XName roundrect = v + "roundrect";

        /// <summary>
        /// Represents the v:shadow XML element.
        /// </summary>
        public static readonly XName shadow = v + "shadow";

        /// <summary>
        /// Represents the v:shape XML element.
        /// </summary>
        public static readonly XName shape = v + "shape";

        /// <summary>
        /// Represents the v:shapetype XML element.
        /// </summary>
        public static readonly XName shapetype = v + "shapetype";

        /// <summary>
        /// Represents the v:stroke XML element.
        /// </summary>
        public static readonly XName stroke = v + "stroke";

        /// <summary>
        /// Represents the v:textbox XML element.
        /// </summary>
        public static readonly XName textbox = v + "textbox";

        /// <summary>
        /// Represents the v:textpath XML element.
        /// </summary>
        public static readonly XName textpath = v + "textpath";
    }
}
