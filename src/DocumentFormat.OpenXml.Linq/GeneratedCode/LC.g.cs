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
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.cxnSp" />, <see cref="A.extLst" />, <see cref="A.graphicFrame" />, <see cref="A.grpSp" />, <see cref="A.grpSpPr" />, <see cref="A.nvGrpSpPr" />, <see cref="A.pic" />, <see cref="A.sp" />, <see cref="A.txSp" />, <see cref="A14.contentPart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LockedCanvas.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lockedCanvas = lc + "lockedCanvas";
    }
}
