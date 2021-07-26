// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:wp15="http://schemas.microsoft.com/office/word/2012/wordprocessingDrawing" namespace.
    /// </summary>
    public static class WP15
    {
        /// <summary>
        /// Defines the XML namespace associated with the wp15 prefix.
        /// </summary>
        public static readonly XNamespace wp15 = "http://schemas.microsoft.com/office/word/2012/wordprocessingDrawing";

        /// <summary>
        /// Represents the wp15:webVideoPr XML element.
        /// </summary>
        public static readonly XName webVideoPr = wp15 + "webVideoPr";
    }
}
