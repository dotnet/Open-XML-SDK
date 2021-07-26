// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:wetp="http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11" namespace.
    /// </summary>
    public static class WETP
    {
        /// <summary>
        /// Defines the XML namespace associated with the wetp prefix.
        /// </summary>
        public static readonly XNamespace wetp = "http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11";

        /// <summary>
        /// Represents the wetp:extLst XML element.
        /// </summary>
        public static readonly XName extLst = wetp + "extLst";

        /// <summary>
        /// Represents the wetp:taskpane XML element.
        /// </summary>
        public static readonly XName taskpane = wetp + "taskpane";

        /// <summary>
        /// Represents the wetp:taskpanes XML element.
        /// </summary>
        public static readonly XName taskpanes = wetp + "taskpanes";

        /// <summary>
        /// Represents the wetp:webextensionref XML element.
        /// </summary>
        public static readonly XName webextensionref = wetp + "webextensionref";
    }
}
