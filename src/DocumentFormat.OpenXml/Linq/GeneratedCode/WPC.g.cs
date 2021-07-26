// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" namespace.
    /// </summary>
    public static class WPC
    {
        /// <summary>
        /// Defines the XML namespace associated with the wpc prefix.
        /// </summary>
        public static readonly XNamespace wpc = "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas";

        /// <summary>
        /// Represents the wpc:bg XML element.
        /// </summary>
        public static readonly XName bg = wpc + "bg";

        /// <summary>
        /// Represents the wpc:extLst XML element.
        /// </summary>
        public static readonly XName extLst = wpc + "extLst";

        /// <summary>
        /// Represents the wpc:graphicFrame XML element.
        /// </summary>
        public static readonly XName graphicFrame = wpc + "graphicFrame";

        /// <summary>
        /// Represents the wpc:whole XML element.
        /// </summary>
        public static readonly XName whole = wpc + "whole";

        /// <summary>
        /// Represents the wpc:wpc XML element.
        /// </summary>
        public static readonly XName wpc_ = wpc + "wpc";
    }
}
