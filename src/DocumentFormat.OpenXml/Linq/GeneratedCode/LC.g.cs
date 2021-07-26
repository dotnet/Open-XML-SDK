// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:lc="http://schemas.openxmlformats.org/drawingml/2006/lockedCanvas" namespace.
    /// </summary>
    public static class LC
    {
        /// <summary>
        /// Defines the XML namespace associated with the lc prefix.
        /// </summary>
        public static readonly XNamespace lc = "http://schemas.openxmlformats.org/drawingml/2006/lockedCanvas";

        /// <summary>
        /// Represents the lc:lockedCanvas XML element.
        /// </summary>
        public static readonly XName lockedCanvas = lc + "lockedCanvas";
    }
}
