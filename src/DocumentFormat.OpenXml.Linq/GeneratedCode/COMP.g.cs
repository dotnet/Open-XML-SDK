// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:comp="http://schemas.openxmlformats.org/drawingml/2006/compatibility" namespace.
    /// </summary>
    public static class COMP
    {
        /// <summary>
        /// Defines the XML namespace associated with the comp prefix.
        /// </summary>
        public static readonly XNamespace comp = "http://schemas.openxmlformats.org/drawingml/2006/compatibility";

        /// <summary>
        /// Represents the comp:legacyDrawing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.spid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LegacyDrawing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName legacyDrawing = comp + "legacyDrawing";
    }
}
