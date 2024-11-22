// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:am3d="http://schemas.microsoft.com/office/drawing/2017/model3d" namespace.
    /// </summary>
    public static partial class AM3D
    {
        /// <summary>
        /// Defines the XML namespace associated with the am3d prefix.
        /// </summary>
        public static readonly XNamespace am3d = "http://schemas.microsoft.com/office/drawing/2017/model3d";

        /// <summary>
        /// Represents the am3d:clr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.clrChange" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clr = am3d + "clr";
    }
}
