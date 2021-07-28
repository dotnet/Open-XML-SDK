// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:sle="http://schemas.microsoft.com/office/drawing/2010/slicer" namespace.
    /// </summary>
    public static class SLE
    {
        /// <summary>
        /// Defines the XML namespace associated with the sle prefix.
        /// </summary>
        public static readonly XNamespace sle = "http://schemas.microsoft.com/office/drawing/2010/slicer";

        /// <summary>
        /// Represents the sle:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="slicer" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = sle + "extLst";

        /// <summary>
        /// Represents the sle:slicer XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Slicer.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicer = sle + "slicer";
    }
}
