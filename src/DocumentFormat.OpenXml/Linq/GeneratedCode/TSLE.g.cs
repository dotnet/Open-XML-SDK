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
        public static readonly XName extLst = tsle + "extLst";

        /// <summary>
        /// Represents the tsle:timeslicer XML element.
        /// </summary>
        public static readonly XName timeslicer = tsle + "timeslicer";
    }
}
