// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:ahyp="http://schemas.microsoft.com/office/drawing/2018/hyperlinkcolor" namespace.
    /// </summary>
    public static class AHYP
    {
        /// <summary>
        /// Defines the XML namespace associated with the ahyp prefix.
        /// </summary>
        public static readonly XNamespace ahyp = "http://schemas.microsoft.com/office/drawing/2018/hyperlinkcolor";

        /// <summary>
        /// Represents the ahyp:hlinkClr XML element.
        /// </summary>
        public static readonly XName hlinkClr = ahyp + "hlinkClr";
    }
}
