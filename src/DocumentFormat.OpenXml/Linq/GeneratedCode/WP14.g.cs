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
        public static readonly XName anchorId = wp14 + "anchorId";

        /// <summary>
        /// Represents the wp14:editId XML attributes.
        /// </summary>
        public static readonly XName editId = wp14 + "editId";

        /// <summary>
        /// Represents the wp14:pctHeight XML element.
        /// </summary>
        public static readonly XName pctHeight = wp14 + "pctHeight";

        /// <summary>
        /// Represents the wp14:pctPosHOffset XML element.
        /// </summary>
        public static readonly XName pctPosHOffset = wp14 + "pctPosHOffset";

        /// <summary>
        /// Represents the wp14:pctPosVOffset XML element.
        /// </summary>
        public static readonly XName pctPosVOffset = wp14 + "pctPosVOffset";

        /// <summary>
        /// Represents the wp14:pctWidth XML element.
        /// </summary>
        public static readonly XName pctWidth = wp14 + "pctWidth";

        /// <summary>
        /// Represents the wp14:sizeRelH XML element.
        /// </summary>
        public static readonly XName sizeRelH = wp14 + "sizeRelH";

        /// <summary>
        /// Represents the wp14:sizeRelV XML element.
        /// </summary>
        public static readonly XName sizeRelV = wp14 + "sizeRelV";
    }
}
