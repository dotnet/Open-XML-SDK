// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:tsle="http://schemas.microsoft.com/office/drawing/2012/timeslicer" namespace.
    /// </summary>
    public static class TSLE
    {
        /// <summary>
        /// Defines the XML namespace associated with the tsle prefix.
        /// </summary>
        public static readonly XNamespace tsle = "http://schemas.microsoft.com/office/drawing/2012/timeslicer";

        /// <summary>
        /// Represents the tsle:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="timeslicer" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = tsle + "extLst";

        /// <summary>
        /// Represents the tsle:timeslicer XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimeSlicer.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timeslicer = tsle + "timeslicer";
    }
}
