// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:thm15="http://schemas.microsoft.com/office/thememl/2012/main" namespace.
    /// </summary>
    public static class THM15
    {
        /// <summary>
        /// Defines the XML namespace associated with the thm15 prefix.
        /// </summary>
        public static readonly XNamespace thm15 = "http://schemas.microsoft.com/office/thememl/2012/main";

        /// <summary>
        /// Represents the thm15:extLst XML element.
        /// </summary>
        public static readonly XName extLst = thm15 + "extLst";

        /// <summary>
        /// Represents the thm15:id XML attribute.
        /// </summary>
        public static readonly XName id = thm15 + "id";

        /// <summary>
        /// Represents the thm15:themeFamily XML element.
        /// </summary>
        public static readonly XName themeFamily = thm15 + "themeFamily";
    }
}
