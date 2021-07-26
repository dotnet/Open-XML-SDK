// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:pic14="http://schemas.microsoft.com/office/drawing/2010/picture" namespace.
    /// </summary>
    public static class PIC14
    {
        /// <summary>
        /// Defines the XML namespace associated with the pic14 prefix.
        /// </summary>
        public static readonly XNamespace pic14 = "http://schemas.microsoft.com/office/drawing/2010/picture";

        /// <summary>
        /// Represents the pic14:extLst XML element.
        /// </summary>
        public static readonly XName extLst = pic14 + "extLst";

        /// <summary>
        /// Represents the pic14:style XML element.
        /// </summary>
        public static readonly XName style = pic14 + "style";
    }
}
