// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:p15="http://schemas.microsoft.com/office/powerpoint/2012/main" namespace.
    /// </summary>
    public static class P15
    {
        /// <summary>
        /// Defines the XML namespace associated with the p15 prefix.
        /// </summary>
        public static readonly XNamespace p15 = "http://schemas.microsoft.com/office/powerpoint/2012/main";

        /// <summary>
        /// Represents the p15:chartTrackingRefBased XML element.
        /// </summary>
        public static readonly XName chartTrackingRefBased = p15 + "chartTrackingRefBased";

        /// <summary>
        /// Represents the p15:clr XML element.
        /// </summary>
        public static readonly XName clr = p15 + "clr";

        /// <summary>
        /// Represents the p15:extLst XML element.
        /// </summary>
        public static readonly XName extLst = p15 + "extLst";

        /// <summary>
        /// Represents the p15:guide XML element.
        /// </summary>
        public static readonly XName guide = p15 + "guide";

        /// <summary>
        /// Represents the p15:notesGuideLst XML element.
        /// </summary>
        public static readonly XName notesGuideLst = p15 + "notesGuideLst";

        /// <summary>
        /// Represents the p15:parentCm XML element.
        /// </summary>
        public static readonly XName parentCm = p15 + "parentCm";

        /// <summary>
        /// Represents the p15:presenceInfo XML element.
        /// </summary>
        public static readonly XName presenceInfo = p15 + "presenceInfo";

        /// <summary>
        /// Represents the p15:prstTrans XML element.
        /// </summary>
        public static readonly XName prstTrans = p15 + "prstTrans";

        /// <summary>
        /// Represents the p15:sldGuideLst XML element.
        /// </summary>
        public static readonly XName sldGuideLst = p15 + "sldGuideLst";

        /// <summary>
        /// Represents the p15:threadingInfo XML element.
        /// </summary>
        public static readonly XName threadingInfo = p15 + "threadingInfo";
    }
}
