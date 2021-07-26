// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:pic="http://schemas.openxmlformats.org/drawingml/2006/picture" namespace.
    /// </summary>
    public static class PIC
    {
        /// <summary>
        /// Defines the XML namespace associated with the pic prefix.
        /// </summary>
        public static readonly XNamespace pic = "http://schemas.openxmlformats.org/drawingml/2006/picture";

        /// <summary>
        /// Represents the pic:blipFill XML element.
        /// </summary>
        public static readonly XName blipFill = pic + "blipFill";

        /// <summary>
        /// Represents the pic:cNvPicPr XML element.
        /// </summary>
        public static readonly XName cNvPicPr = pic + "cNvPicPr";

        /// <summary>
        /// Represents the pic:cNvPr XML element.
        /// </summary>
        public static readonly XName cNvPr = pic + "cNvPr";

        /// <summary>
        /// Represents the pic:nvPicPr XML element.
        /// </summary>
        public static readonly XName nvPicPr = pic + "nvPicPr";

        /// <summary>
        /// Represents the pic:pic XML element.
        /// </summary>
        public static readonly XName pic_ = pic + "pic";

        /// <summary>
        /// Represents the pic:spPr XML element.
        /// </summary>
        public static readonly XName spPr = pic + "spPr";
    }
}
